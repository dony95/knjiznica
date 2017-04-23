using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Knjiznica.Model;
using System.Net.Mail;
using MongoDB.Bson;
using System.Globalization;
using System.Net;
using System.Collections.Generic;

namespace Knjiznica
{
    public partial class DodajUrediKorisnika : Form
    {
        MySqlConnection conn;
        bool error = false;
        bool edit = false;

        public DodajUrediKorisnika(MySqlConnection conn, Korisnik korisnik)
        {
            this.conn = conn;
            InitializeComponent();
            ucitajPodatkeOkorisniku(korisnik);
        }

        private void ucitajPodatkeOkorisniku(Korisnik korisnik)
        {
            if (korisnik != null)
            {
                lbl_idKorisnkika.Text = korisnik.id.ToString();
                tb_Adresa.Text = korisnik.adresa;
                tb_Email.Text = korisnik.email;
                tb_Ime.Text = korisnik.ime;
                tb_Prezime.Text = korisnik.prezime;
                tb_MjestoStan.Text = korisnik.mjestoStanovanja;
                dtp_DatRodjenja.Value = korisnik.datumRodenja;
                if (korisnik.spol == 'M')
                    rb_Muski.Checked = true;
                else rb_Zenski.Checked = true;
                lbl_datumIsteka.Text = korisnik.datumIstekaClanarine.ToString("dd.MM.yyyy.");
                edit = true;
            }
            else
            {
                lbl_datumIsteka.Text = DateTime.Now.AddYears(1).ToString("dd.MM.yyyy.");
            }
            if (DateTime.Now < DateTime.Parse(lbl_datumIsteka.Text).AddDays(-15))
                btn_obnoviClanarinu.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kolekcija = MainWindow.mongoClient.GetDatabase("knjiznica").GetCollection<BsonDocument>("korisnici");

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
                    datumIstekaClanarine = DateTime.Parse(lbl_datumIsteka.Text)
                };
                if (rb_Muski.Checked)
                    korisnik.spol = 'M';
                else korisnik.spol = 'Ž';

                try
                {
                    MySqlCommand command = conn.CreateCommand();
                    if (!edit)
                    {
                        command.CommandText = "INSERT INTO users (ime, prezime, datumRodenja, mjestoStanovanja, adresa, datumIstekaClanarine, spol, email)" +
                            "VALUES (@ime, @prezime, @datumRodenja, @mjestoStanovanja, @adresa, @datumIstekaClanarine, @spol, @email)";
                        command.Parameters.AddWithValue("@datumIstekaClanarine", korisnik.datumIstekaClanarine.ToString("dd.MM.yyyy."));
                    }
                    else
                    {
                        command.CommandText = "UPDATE users SET ime = @ime, prezime = @prezime, datumRodenja = @datumRodenja, " +
                            "mjestoStanovanja = @mjestoStanovanja, adresa = @adresa, spol = @spol, email = @email WHERE id = @id";
                        command.Parameters.AddWithValue("@id", lbl_idKorisnkika.Text);
                    }
                    command.Parameters.AddWithValue("@ime", korisnik.ime);
                    command.Parameters.AddWithValue("@prezime", korisnik.prezime);
                    command.Parameters.AddWithValue("@datumRodenja", korisnik.datumRodenja.ToString("dd.MM.yyyy."));
                    command.Parameters.AddWithValue("@mjestoStanovanja", korisnik.mjestoStanovanja);
                    command.Parameters.AddWithValue("@adresa", korisnik.adresa);
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
                        if (!edit)
                        {
                            MessageBox.Show("Korisnik uspjesno unesen");
                            kolekcija.InsertOneAsync(new BsonDocument
                            {
                                { "info", "Unesen je novi korisnik, email = " + korisnik.email},
                                { "datumIvrijeme", DateTime.Now.ToString("dd.MM.yyyy HH:mm") }
                            });
                            string message = "Poštovani/a " + korisnik.ime + " " + korisnik.prezime +
                        ", dobrodošli u Knjižnicu. Na mail ćemo vam slati obavijesti o isteku članarine, kako biste pravovremeno" +
                        " mogli ovnoviti svoju članarinu. Želimo vam mnogo mudrih misli. ";
                            string subject = "Dobrodosli u knjiznicu";
                            MainWindow.SendMessage(korisnik.email, message, subject);
                        }
                        else
                        {
                            MessageBox.Show("Korisnički podaci uspješno uređeni");
                            kolekcija.InsertOneAsync(new BsonDocument
                            {
                                { "info", "Korisnički podaci uređeni, email = " + korisnik.email},
                                { "datumIvrijeme", DateTime.Now.ToString("dd.MM.yyyy HH:mm") }
                            });
                        }

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
                if (tb_Email.Text.Contains("."))
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
            if (!validacijaEmail())
            {
                if (tb_Email.Text != "")
                {
                    MessageBox.Show("Neispravan email.");
                    tb_Email.Focus();
                }
            }
        }

        private void btn_obnoviClanarinu_Click(object sender, EventArgs e)
        {
            DateTime datumIsteka = DateTime.ParseExact(lbl_datumIsteka.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture).AddYears(1);
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE users SET datumIstekaClanarine = @datumIstekaClanarine WHERE id = @id";
                command.Parameters.AddWithValue("@id", lbl_idKorisnkika.Text);
                command.Parameters.AddWithValue("@datumIstekaClanarine", datumIsteka.ToString("dd.MM.yyyy."));
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                error = true;
            }
            finally
            {
                if(!error)
                {
                    MessageBox.Show("Članarina uspješno obnovljena!");
                    this.Close();
                }
            }
        }
    }
}
