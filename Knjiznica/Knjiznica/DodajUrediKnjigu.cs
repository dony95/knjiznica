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
            Knjiga knjiga = new Knjiga()
            {
                autor = tb_Autor.Text,
                naziv = tb_NazivKnjige.Text,
                izdavac = tb_Izdavac.Text,
                godina = dtp_Godina.Value.Year,
                isbn = Int32.Parse(tb_ISBN.Text),
                kategorija = cb_Kategorija.SelectedText,
                brojStranica = (int)num_BrojStranica.Value
            };

            if (!error)
                conn.Open();
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO knjige (autor, naziv, izdavac, godina, isbn, kategorija, brojStranica) VALUES (@Autor, @Naziv, @Izdavac, @Godina, @ISBN, @Kategorija, @BrojStranica)";
                command.Parameters.AddWithValue("@Autor", knjiga.autor);
                command.Parameters.AddWithValue("@Naziv", knjiga.naziv);
                command.Parameters.AddWithValue("@Izdavac", knjiga.izdavac);
                command.Parameters.AddWithValue("@Godina", knjiga.godina);
                command.Parameters.AddWithValue("@ISBN", knjiga.isbn);
                command.Parameters.AddWithValue("@Kategorija", knjiga.kategorija);
                command.Parameters.AddWithValue("@BrojStranica", knjiga.brojStranica);
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
                    conn.Close();
                }
            }


        }
    }
}
