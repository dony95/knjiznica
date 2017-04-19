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
    public partial class DodajUrediKorisnika : Form
    {
        MySqlConnection conn;
        bool error = false;
        public DodajUrediKorisnika(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidacijaKorisnika())
            {
                Korisnik korisnik = new Korisnik()
                {
                    adresa = tb_Adresa.Text,
                    datumRodenja = dtp_DatRodjenja.Value,
                    ime = tb_Ime.Text,
                    mjestoStanovanja = tb_MjestoStan.Text,
                    prezime = tb_Prezime.Text,
                    email = tb_Email.Text,
                    datumIstekaClanarine = DateTime.Now.AddYears(1)
                };
                if (rb_Muski.Enabled)
                    korisnik.spol = 'M';
                else korisnik.spol = 'Ž';

                try
                {
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO users (ime, prezime, datumRodenja, mjestoStanovanja, adresa, datumIstekaClanarine, spol, email) VALUES (@ime, @prezime, @datumRodenja, @mjestoStanovanja, @adresa, @datumIstekaClanarine, @spol, @email)";
                    command.Parameters.AddWithValue("@ime", korisnik.ime);
                    command.Parameters.AddWithValue("@prezime", korisnik.prezime);
                    command.Parameters.AddWithValue("@datumRodenja", korisnik.datumRodenja.ToString("dd.MM.yyyy."));
                    command.Parameters.AddWithValue("@mjestoStanovanja", korisnik.mjestoStanovanja);
                    command.Parameters.AddWithValue("@adresa", korisnik.adresa);
                    command.Parameters.AddWithValue("@datumIstekaClanarine", korisnik.datumIstekaClanarine.ToString("dd.MM.yyyy."));
                    command.Parameters.AddWithValue("@spol", korisnik.spol);
                    command.Parameters.AddWithValue("@email", korisnik.email);
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
                        MessageBox.Show("Korisnik uspjesno unesen");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Sva polja moraju biti popunjena.");

            
        }

        private bool validacijaEmail()
        {
            if (tb_Email.Text.Contains("@"))
            {
                int at = tb_Email.Text.IndexOf("@");
                if(tb_Email.Text.Contains("."))
                {
                    int dot = tb_Email.Text.IndexOf(".");
                    if (at < dot)
                        return true;
                }
            }

            return false;
        }

        private bool ValidacijaKorisnika()
        {
            if (tb_Ime.Text == "")
                return false;

            if (tb_Prezime.Text == "")
                return false;

            if (tb_Adresa.Text == "")
                return false;

            if (tb_MjestoStan.Text == "")
                return false;

            if (tb_Ime.Text == "")
                return false;

            if (!rb_Muski.Checked && !rb_Zenski.Checked)
                return false;

            if (tb_Email.Text == "")
                return false;

            return true;
        }

        private void tb_Email_Leave(object sender, EventArgs e)
        {
            if(!validacijaEmail())
            {
                if(tb_Email.Text != "")
                {
                    MessageBox.Show("Neispravan email.");
                    tb_Email.Focus();
                }
            }
        }
    }
}
