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
                command.CommandText = "INSERT INTO users (ime, prezime, datumRodenja, mjestoStanovanja, adresa, datumIstekaClanarine, spol) VALUES (@ime, @prezime, @datumRodenja, @mjestoStanovanja, @adresa, @datumIstekaClanarine, @spol)";
                command.Parameters.AddWithValue("@ime", korisnik.ime);
                command.Parameters.AddWithValue("@prezime", korisnik.prezime);
                command.Parameters.AddWithValue("@datumRodenja", korisnik.datumRodenja.ToShortDateString());
                command.Parameters.AddWithValue("@mjestoStanovanja", korisnik.mjestoStanovanja);
                command.Parameters.AddWithValue("@adresa", korisnik.adresa);
                command.Parameters.AddWithValue("@datumIstekaClanarine", korisnik.datumIstekaClanarine.ToShortDateString());
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
    }
}
