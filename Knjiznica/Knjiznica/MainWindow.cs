using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Knjiznica.Model;
using System.Globalization;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Knjiznica
{
    public partial class MainWindow : Form
    {
        List<Knjiga> listaKnjiga;
        List<Korisnik> listaKorisnika;
        List<Posudba> listaPosudba;
        MySqlConnection conn;
        string ConnectionString = string.Empty;
        string mongoConnString = string.Empty;
        public static MongoClient mongoClient;
        public MainWindow()
        {
            connectionType();
            conn = new MySqlConnection(ConnectionString);
            conn.Open();
            mongoClient = new MongoClient(mongoConnString);
            if (ucitajLoginFormu() != DialogResult.OK)
            {
                MessageBox.Show("Neuspjesna prijava. Aplikacija ce se sada zatvoriti!");
                this.Close();
                return;
            }
            InitializeComponent();
            ucitajKnjige();
            ucitajKorisnike();
            ucitajPosudbe();
        }

        //_____________________________________________________________________

        //pretraga Buttonovi

        //_____________________________________________________________________

        private void btn_PretragaKnjiga_Click(object sender, EventArgs e)
        {
            IEnumerable<Knjiga> listaKnjigatmp = listaKnjiga;

            if (tb_AutorKnjige.Text != "")
                listaKnjigatmp = listaKnjigatmp.
                    Where(k => k.autor.ToLower().Contains(tb_AutorKnjige.Text.ToLower()));

            if (tb_ISBN.Text != "")
                listaKnjigatmp = listaKnjigatmp.
                    Where(k => k.isbn == tb_ISBN.Text);

            if (tb_Izdavac.Text != "")
                listaKnjigatmp = listaKnjigatmp.
                    Where(k => k.izdavac.ToLower().Contains(tb_Izdavac.Text.ToLower()));

            //if (num_Godina.Value != 0)
            //    listaKnjigatmp = listaKnjigatmp.
                    //Where(k => k.godina == num_Godina.Value);

            if (tb_Godina.Text != "")
                listaKnjigatmp = listaKnjigatmp.
                    Where(k => k.godina == int.Parse(tb_Godina.Text));

            //if (cb_Kategorija.SelectedIndex != 0)
            //    listaKnjigatmp = listaKnjigatmp.
                    //Where(k => k.kategorija == cb_Kategorija.SelectedText);

            if (tb_NazivKnjige.Text != "")
                listaKnjigatmp = listaKnjigatmp.
                    Where(k => k.naziv.ToLower().Contains(tb_NazivKnjige.Text.ToLower()));

            dodajKnjigeUGrid(listaKnjigatmp.ToList());
        }

        private void btn_PretragaKorisnika_Click(object sender, EventArgs e)
        {
            IEnumerable<Korisnik> listaKorisnikatmp = listaKorisnika;

            if (tb_IDkorisnik.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.
                    Where(k => k.id == int.Parse(tb_IDkorisnik.Text));

            if (tb_ImeKorisnika.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.
                    Where(k => k.ime.ToLower().Contains(tb_ImeKorisnika.Text.ToLower()));

            if (tb_Prezime.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.
                    Where(k => k.prezime.ToLower().Contains(tb_Prezime.Text.ToLower()));

            if (tb_email.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.
                    Where(k => k.email.ToLower().Contains(tb_email.Text.ToLower()));

            dodajKorisnikeUGrid(listaKorisnikatmp.ToList());
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
            DodajUrediKnjigu forma = new DodajUrediKnjigu(conn, null);
            forma.ShowDialog();
            ucitajKnjige();
        }

        private void btn_DodajKorisnika_Click(object sender, EventArgs e)
        {
            DodajUrediKorisnika forma = new DodajUrediKorisnika(conn, null);
            forma.ShowDialog();
            ucitajKorisnike();
        }

        private void btn_NovaPosudba_Click(object sender, EventArgs e)
        {
            NovaPosudba forma = new NovaPosudba(conn, listaKnjiga, listaKorisnika);
            forma.ShowDialog();
            ucitajPosudbe();
        }

        //_____________________________________________________________________

        //funkcije za ucitavanje

        //_____________________________________________________________________

        public void ucitajKnjige()
        {
            listaKnjiga = new List<Knjiga>();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT knjige.*, kategorije_knjiga.naziv_kategorije FROM knjige " +
                "join kategorije_knjiga on knjige.kategorijaID = kategorije_knjiga.id_kategorije";
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
                        kategorija = (string)dt.Rows[i][9],
                        izdavac = (string)dt.Rows[i][4],
                        godina = (int)dt.Rows[i][5],
                        isbn = (string)dt.Rows[i][6],
                        brojStranica = (int)dt.Rows[i][7],
                        brojKopija = (int)dt.Rows[i][8]
                    });
                }
            }
            dodajKnjigeUGrid(listaKnjiga);
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

        private void ucitajPosudbe()
        {
            listaPosudba = new List<Posudba>();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM posudbe where vraceno = 'N'";
            command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listaPosudba.Add(new Posudba()
                    {
                        ID = (int)dt.Rows[i][0],
                        korisnik = listaKorisnika.Find(k => k.id == (int)dt.Rows[i][1]),
                        listaKnjiga = knjigeIdUObjekte((string)dt.Rows[i][2]),
                        datumPosudbe = parsirajDatum((string)dt.Rows[i][3]),
                        datumIstekaPosudbe = parsirajDatum((string)dt.Rows[i][4])
                    });
                }
            }

            dodajPosudbeUGrid(listaPosudba);
        }

        private DialogResult ucitajLoginFormu()
        {
            LoginForma forma = new LoginForma(conn);
            return forma.ShowDialog();
        }

        //_____________________________________________________________________

        //dodaj u grid funkcije

        //_____________________________________________________________________

        private void dodajKnjigeUGrid(List<Knjiga> listaKnjiga)
        {
            data_Knjige.Rows.Clear();
            int dataGridCount = 0;

            foreach (Knjiga k in listaKnjiga)
            {
                data_Knjige.Rows.Add(k.isbn, k.naziv, k.autor, k.kategorija, k.izdavac, 
                    k.godina, k.brojStranica, k.brojKopija);
                data_Knjige.Rows[dataGridCount++].Cells["edit"].Value = "Izbrisi";
            }
        }

        private void dodajKorisnikeUGrid(List<Korisnik> listaKorisnika)
        {
            data_Korisnici.Rows.Clear();

            foreach (Korisnik k in listaKorisnika)
            {
                data_Korisnici.Rows.Add(k.id, k.ime, k.prezime, k.email, 
                    k.datumRodenja.ToShortDateString(), k.mjestoStanovanja, 
                    k.adresa, k.datumIstekaClanarine.ToShortDateString(), k.spol);
            }
        }

        private void dodajPosudbeUGrid(List<Posudba> listaPosudba)
        {
            data_Posudbe.Rows.Clear();
            int dataGridCount = 0;

            foreach (Posudba p in listaPosudba)
            {
                data_Posudbe.Rows.Add(p.ID, p.korisnik.ime + " " + p.korisnik.prezime,
                                        p.datumPosudbe.ToShortDateString(), 
                                        p.datumIstekaPosudbe.ToShortDateString(), p.listaKnjiga.Count);
                data_Posudbe.Rows[dataGridCount].Cells["Vrati"].Value = "text" + p.ID;
                dataGridCount++;
            }
                
            
        }

        //_____________________________________________________________________

        //parsiranje podataka

        //_____________________________________________________________________

        private List<Knjiga> knjigeIdUObjekte(string stringID)
        {
            List<Knjiga> lista = new List<Knjiga>();
            string[] polje = stringID.Split(',');

            for (int i = 0; i < polje.Length; i++)
                lista.Add(listaKnjiga.Find(k => k.id == int.Parse(polje[i])));

            return lista;
        }

        private DateTime parsirajDatum(string s)
        {
            return DateTime.ParseExact(s, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
        }

        //odredivanje tipa konekcije
        private void connectionType()
        {
            if (Properties.Settings.Default["databaseLocation"].ToString() == "local")
            {
                ConnectionString = Properties.Settings.Default["localConnection"].ToString();
                mongoConnString = Properties.Settings.Default["mongoLocalConn"].ToString();
                return;
            }
            else if (Properties.Settings.Default["databaseLocation"].ToString() == "remote")
            {
                ConnectionString = Properties.Settings.Default["remoteConneciton"].ToString();
                mongoConnString = Properties.Settings.Default["mongoRemoteConn"].ToString();
                return;
            }

            DialogResult dialog = MessageBox.Show("Lokalna baza podataka?", "Upit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ConnectionString = Properties.Settings.Default["localConnection"].ToString();
                mongoConnString = Properties.Settings.Default["mongoLocalConn"].ToString();
                Properties.Settings.Default["databaseLocation"] = "local";
            }
            else if (dialog == DialogResult.No)
            {
                ConnectionString = Properties.Settings.Default["remoteConneciton"].ToString();
                mongoConnString = Properties.Settings.Default["mongoRemoteConn"].ToString();
                Properties.Settings.Default["databaseLocation"] = "remote";
            }
            Properties.Settings.Default.Save();
        }

        //test
        private void data_Knjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data_grid = (DataGridView)sender;

            if(data_grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                IzbrisiKnjigu forma = new IzbrisiKnjigu(conn, 
                    listaKnjiga.Find(k => k.isbn == (string)data_grid.Rows[e.RowIndex].Cells["ISBN"].Value));
                forma.ShowDialog();
                dodajKnjigeUGrid(listaKnjiga);
            }
        }

        //zatvaranje apliakcije
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            conn.Close();
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }

        //switchanje funkcije aktiviranje enter tipkom na promejnu aktivnog taba
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

        private void tb_Godina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void data_Posudbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data_grid = (DataGridView)sender;

            if (data_grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Posudba p = listaPosudba.Find(pos => pos.ID == (int)data_grid.Rows[e.RowIndex].Cells["posudbaID"].Value);
                NovaPosudba forma = new NovaPosudba(conn, listaKnjiga, new List<Korisnik>() { p.korisnik });
                forma.ShowDialog();
            }
        }

        private void data_Korisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data_grid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                DodajUrediKorisnika forma = new DodajUrediKorisnika(conn,
                    listaKorisnika.Find(k => k.id == (int)data_grid.Rows[e.RowIndex].Cells["ID"].Value));
                forma.ShowDialog();
                ucitajKorisnike();
            }
        }

        private void data_Knjige_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data_grid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                DodajUrediKnjigu forma = new DodajUrediKnjigu(conn,
                    listaKnjiga.Find(k => k.isbn == (string)data_grid.Rows[e.RowIndex].Cells["ISBN"].Value));
                forma.ShowDialog();
                ucitajKnjige();
            }
        }

        private void ispisLogovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvjestajForma forma = new IzvjestajForma();
            forma.ShowDialog();
        }
    }
}
