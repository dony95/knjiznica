using Knjiznica.Model;
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
        public DodajUrediKnjigu(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btn_DodajUredi_Click(object sender, EventArgs e)
        {
            if(validacijaKnjige())
            {
                Knjiga knjiga = new Knjiga()
                {
                    autor = tb_Autor.Text,
                    naziv = tb_NazivKnjige.Text,
                    izdavac = tb_Izdavac.Text,
                    godina = int.Parse(tb_Godina.Text),
                    isbn = tb_ISBN.Text,
                    kategorija = cb_Kategorija.SelectedText,
                    brojStranica = (int)num_BrojStranica.Value,
                    brojKopija = (int)num_BrKopija.Value
                };

                try
                {
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO knjige (autor, naziv, izdavac, godina, isbn, kategorija, brojStranica, brojKopija) VALUES (@Autor, @Naziv, @Izdavac, @Godina, @ISBN, @Kategorija, @BrojStranica, @BrojKopija)";
                    command.Parameters.AddWithValue("@Autor", knjiga.autor);
                    command.Parameters.AddWithValue("@Naziv", knjiga.naziv);
                    command.Parameters.AddWithValue("@Izdavac", knjiga.izdavac);
                    command.Parameters.AddWithValue("@Godina", knjiga.godina);
                    command.Parameters.AddWithValue("@ISBN", knjiga.isbn);
                    command.Parameters.AddWithValue("@Kategorija", knjiga.kategorija);
                    command.Parameters.AddWithValue("@BrojStranica", knjiga.brojStranica);
                    command.Parameters.AddWithValue("@BrojKopija", knjiga.brojStranica);
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
                        MessageBox.Show("Knjiga uspjesno unesena");
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
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;               
            }
        }

        private void tb_ISBN_Leave(object sender, EventArgs e)
        {
            if(tb_ISBN.Text.Length != 13 && tb_ISBN.Text != "")
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
    }
}
