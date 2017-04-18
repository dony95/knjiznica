using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Knjiznica.Model;

namespace Knjiznica
{
    public partial class MainWindow : Form
    {
        List<Knjiga> listaKnjiga;
        List<Korisnik> listaKorisnika;
        MySqlConnection conn;
        string ConnectionString = string.Empty;
        public MainWindow()
        {
            connectionType();
            conn = new MySqlConnection(ConnectionString);
            conn.Open();
            if(ucitajLoginFormu() != DialogResult.OK)
            {
                MessageBox.Show("Neuspjesna prijava. Aplikacija ce se sada zatvoriti!");
                this.Close();
                return;
            }
            InitializeComponent();
            ucitajPodatke();
            ucitajKorisnike();
        }

        //_____________________________________________________________________

        //pretraga Buttonovi

        //_____________________________________________________________________

        private void btn_PretragaKnjiga_Click(object sender, EventArgs e)
        {
            IEnumerable<Knjiga> listaKnjigatmp = listaKnjiga;

            if (tb_AutorKnjige.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.autor.ToLower().Contains(tb_AutorKnjige.Text.ToLower()));

            if (tb_IDknjiga.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.id == int.Parse(tb_IDknjiga.Text));

            if (tb_Izdavac.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.izdavac.ToLower().Contains(tb_Izdavac.Text.ToLower()));

            if (num_Godina.Value != 0)
                listaKnjigatmp = listaKnjigatmp.Where(k => k.godina == num_Godina.Value);

            //if (cb_Kategorija.SelectedIndex != 0)
            //    listaKnjigatmp = listaKnjigatmp.Where(k => k.kategorija == cb_Kategorija.SelectedText);

            if (tb_NazivKnjige.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.naziv.ToLower().Contains(tb_NazivKnjige.Text.ToLower()));

            dodajKnjigeUGrid(listaKnjigatmp.ToList());
        }

        private void btn_PretragaKorisnika_Click(object sender, EventArgs e)
        {

        }

        private void btn_PretragaPosudbe_Click(object sender, EventArgs e)
        {

        }

        //_____________________________________________________________________

        //Dodaj Buttonovi

        //_____________________________________________________________________

        private void btn_DodajKnjigu_Click(object sender, EventArgs e)
        {
            //Prikazi formu za dodavanje i uredjivanje knjige
            DodajUrediKnjigu forma = new DodajUrediKnjigu(conn);
            forma.ShowDialog();
            ucitajPodatke();
        }

        private void btn_DodajKorisnika_Click(object sender, EventArgs e)
        {
            DodajUrediKorisnika forma = new DodajUrediKorisnika(conn);
            forma.Show();
        }

        private void btn_NovaPosudba_Click(object sender, EventArgs e)
        {
            NovaPosudba forma = new NovaPosudba();
            forma.Show();
        }

        private void connectionType()
        {
            if (Properties.Settings.Default["databaseLocation"].ToString() == "local")
            {
                ConnectionString = Properties.Settings.Default["localConnection"].ToString();
                return;
            }
            else if (Properties.Settings.Default["databaseLocation"].ToString() == "remote")
            {
                ConnectionString = Properties.Settings.Default["remoteConneciton"].ToString();
                return;
            }

            DialogResult dialog = MessageBox.Show("Lokalna baza podataka?", "Upit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ConnectionString = Properties.Settings.Default["localConnection"].ToString();
                Properties.Settings.Default["databaseLocation"] = "local";
            }
            else if (dialog == DialogResult.No)
            {
                ConnectionString = Properties.Settings.Default["remoteConneciton"].ToString();
                Properties.Settings.Default["databaseLocation"] = "remote";
            }
            Properties.Settings.Default.Save();
        }

        public void ucitajPodatke()
        {
            listaKnjiga = new List<Knjiga>();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM knjige";
            command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listaKnjiga.Add(new Knjiga()
                    {
                        id = (int)dt.Rows[i][0],
                        autor = (string)dt.Rows[i][1],
                        naziv = (string)dt.Rows[i][2],
                        kategorija = (string)dt.Rows[i][3],
                        izdavac = (string)dt.Rows[i][4],
                        godina = (int)dt.Rows[i][5],
                        isbn = (int)dt.Rows[i][6],
                        brojStranica = (int)dt.Rows[i][7],
                        cijena = (double)dt.Rows[i][8],
                        brojKopija = (int)dt.Rows[i][9]
                    });
                }
            }

            dodajKnjigeUGrid(listaKnjiga);
        }

        private void data_Knjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data_grid = (DataGridView)sender;

            if(data_grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show("Id knjige je " + data_grid.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
        }

        private void dodajKnjigeUGrid(List<Knjiga> listaKnjiga)
        {
            data_Knjige.Rows.Clear();
            int dataGridCount = 0;

            foreach (Knjiga k in listaKnjiga)
            {
                data_Knjige.Rows.Add(k.naziv, k.autor, k.kategorija, k.izdavac, k.godina, k.isbn, k.brojStranica, k.cijena, k.brojKopija);
                data_Knjige.Rows[dataGridCount].Cells["edit"].Value = "text" + k.id;
                dataGridCount++;
            }
        }

        private DialogResult ucitajLoginFormu()
        {
            LoginForma forma = new LoginForma(conn);
            return forma.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            conn.Close();
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((sender as TabControl).SelectedIndex)
            {
                case 0:
                    this.AcceptButton = btn_PretragaKnjige;
                    return;
                case 1:
                    this.AcceptButton = btn_PretragaKorisnika;
                    return;
                case 2:
                    this.AcceptButton = btn_PretragaPosudbe;
                    return;
            }
        }

        private void ucitajKorisnike()
        {
            listaKorisnika = new List<Korisnik>();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM users";
            command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listaKorisnika.Add(new Korisnik()
                    {
                        id = (int)dt.Rows[i][0],
                        ime = (string)dt.Rows[i][1],
                        prezime = (string)dt.Rows[i][2],
                        datumRodenja = parsirajDatum((string)dt.Rows[i][3]),
                        mjestoStanovanja = (string)dt.Rows[i][4],
                        adresa = (string)dt.Rows[i][5],
                        datumIstekaClanarine = parsirajDatum((string)dt.Rows[i][6]),
                        spol = ((string)dt.Rows[i][7])[0],
                        email = (string)dt.Rows[i][8]
                    });
                }
            }
            dodajKorisnikeUGrid(listaKorisnika);
        }

        private void dodajKorisnikeUGrid(List<Korisnik> listaKorisnika)
        {
            data_Korisnici.Rows.Clear();

            foreach (Korisnik k in listaKorisnika)
            {
                data_Korisnici.Rows.Add(k.id, k.ime, k.prezime, k.email, k.datumRodenja, k.mjestoStanovanja, k.adresa, k.datumIstekaClanarine, k.spol);
            }
        }

        private DateTime parsirajDatum(string s)
        {
            return DateTime.ParseExact("10.4.2017.", )
        }
    }
}
