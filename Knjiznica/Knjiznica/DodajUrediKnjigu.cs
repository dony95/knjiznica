using Knjiznica.Model;
using MongoDB.Bson;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class DodajUrediKnjigu : Form
    {
        MySqlConnection conn;
        bool error = false;
        bool edit = false;
        public DodajUrediKnjigu(MySqlConnection conn, Knjiga knjiga)
        {
            this.conn = conn;
            InitializeComponent();
            ucitajKategorije();
            ucitajPodatkeOknjizi(knjiga);
        }

        private void ucitajPodatkeOknjizi(Knjiga knjiga)
        {
            if (knjiga != null)
            {
                lbl_idKnjige.Text = knjiga.id.ToString();
                tb_Autor.Text = knjiga.autor;
                tb_NazivKnjige.Text = knjiga.naziv;
                tb_Izdavac.Text = knjiga.izdavac;
                tb_Godina.Text = knjiga.godina.ToString();
                tb_ISBN.Text = knjiga.isbn;
                cb_Kategorija.Text = knjiga.kategorija;
                num_BrojStranica.Value = knjiga.brojStranica;
                num_BrKopija.Value = knjiga.brojKopija;
                edit = true;
            }
        }

        private void btn_DodajUredi_Click(object sender, EventArgs e)
        {
            var kolekcija = MainWindow.mongoClient.GetDatabase("knjiznica").GetCollection<BsonDocument>("knjige");

            if (validacijaKnjige())
            {
                Knjiga knjiga = new Knjiga()
                {
                    autor = tb_Autor.Text,
                    naziv = tb_NazivKnjige.Text,
                    izdavac = tb_Izdavac.Text,
                    godina = int.Parse(tb_Godina.Text),
                    isbn = tb_ISBN.Text,
                    kategorija = cb_Kategorija.Text,
                    brojStranica = (int)num_BrojStranica.Value,
                    brojKopija = (int)num_BrKopija.Value
                };

                try
                {
                    MySqlCommand command = conn.CreateCommand();
                    if (!edit)
                        command.CommandText = "INSERT INTO knjige (autor, naziv, izdavac, godina, isbn, kategorijaID, brojStranica, brojKopija)"
                            + " VALUES (@Autor, @Naziv, @Izdavac, @Godina, @ISBN, @KategorijaID, @BrojStranica, @BrojKopija)";
                    else
                    {
                        command.CommandText = "UPDATE knjige SET autor = @autor, naziv = @naziv, izdavac = @izdavac, godina = @godina, isbn = @isbn ," +
                            "kategorijaID = @kategorijaID, brojStranica = @brojStranica, brojKopija = @brojKopija WHERE id = @id";
                        command.Parameters.AddWithValue("@id", lbl_idKnjige.Text);
                    }
                    command.Parameters.AddWithValue("@Autor", knjiga.autor);
                    command.Parameters.AddWithValue("@Naziv", knjiga.naziv);
                    command.Parameters.AddWithValue("@Izdavac", knjiga.izdavac);
                    command.Parameters.AddWithValue("@Godina", knjiga.godina);
                    command.Parameters.AddWithValue("@ISBN", knjiga.isbn);
                    command.Parameters.AddWithValue("@KategorijaID", cb_Kategorija.SelectedValue);
                    command.Parameters.AddWithValue("@BrojStranica", knjiga.brojStranica);
                    command.Parameters.AddWithValue("@BrojKopija", knjiga.brojKopija);
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    error = true;
                }
                finally
                {
                    if (!error)
                    {
                        if (!edit)
                        {
                            MessageBox.Show("Knjiga uspješno unesena");
                            kolekcija.InsertOneAsync(new BsonDocument
                            {
                                { "info", "Unesena je nova knjiga, ISBN = " + knjiga.isbn},
                                { "datumIvrijeme", DateTime.Now.ToString("dd.MM.yyyy HH:mm") }
                            });
                        }

                        else
                        {
                            MessageBox.Show("Knjiga uspješno uređena");
                            kolekcija.InsertOneAsync(new BsonDocument
                            {
                                { "info", "Uređena je knjiga, ISBN = " + knjiga.isbn},
                                { "datumIvrijeme", DateTime.Now.ToString("dd.MM.yyyy HH:mm") }
                            });
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena.");
            }


        }

        //____________________________________________
        //Validacija
        //____________________________________________

        private bool validacijaKnjige()
        {
            //Provjera da li su sva polja popunjena 

            if (tb_Autor.Text == "")
                return false;

            if (tb_NazivKnjige.Text == "")
                return false;

            if (tb_ISBN.Text == "")
                return false;

            if (tb_Izdavac.Text == "")
                return false;

            if (tb_Godina.Text == "")
                return false;

            if (num_BrojStranica.Value <= 0)
                return false;

            if (num_BrKopija.Value <= 0)
                return false;

            //TODO: Da li isbn postoji u bazi           

            return true;
        }

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_ISBN_Leave(object sender, EventArgs e)
        {
            if (tb_ISBN.Text.Length != 13 && tb_ISBN.Text != "")
            {
                MessageBox.Show("ISBN mora sadržavati 13 znamenki");
                tb_ISBN.Focus();
            }
        }

        private void tb_Godina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ucitajKategorije()
        {
            List<Object> items = new List<object>();
            cb_Kategorija.DisplayMember = "Text";
            cb_Kategorija.ValueMember = "Value";
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * from kategorije_knjiga";
                command.ExecuteNonQuery();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        items.Add(new { Value = dt.Rows[i][0], Text = dt.Rows[i][1] });
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                error = true;
            }
            cb_Kategorija.DataSource = items;
        }
    }
}
