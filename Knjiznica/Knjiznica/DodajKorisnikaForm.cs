﻿using System;
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
    public partial class DodajKorisnikaForm : Form
    {
        bool error = false;
        public DodajKorisnikaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik()
            {
                adresa = adresaTextBox.Text,
                datumRodenja = dateTimePicker.Value,
                ime = imeTextBox.Text,
                mjestoStanovanja = mjestoStanovanjaTextBox.Text,
                prezime = prezimeTextBox.Text
            };
            if (muskiRadioButton.Enabled)
                korisnik.spol = 'M';
            else korisnik.spol = 'Ž';

            string ConnectionString = string.Empty;

            DialogResult dialog = MessageBox.Show("Lokalna baza podataka?", "Upit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                ConnectionString = "server=192.168.1.8;uid=suky;" +
                    "pwd=0000;database=knjiznica;";
            else if (dialog == DialogResult.No)
                ConnectionString = "server=donyslav.ddns.net;uid=suky;" +
                    "pwd=0000;database=knjiznica;";

            MySqlConnection conn = new MySqlConnection(ConnectionString);
            if(!error)
                conn.Open();
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO users (ime, prezime, datumRodenja, mjestoStanovanja, adresa, spol) VALUES (@ime, @prezime, @datumRodenja, @mjestoStanovanja, @adresa, @spol)";
                command.Parameters.AddWithValue("@ime", korisnik.ime);
                command.Parameters.AddWithValue("@prezime", korisnik.prezime);
                command.Parameters.AddWithValue("@datumRodenja", korisnik.datumRodenja);
                command.Parameters.AddWithValue("@mjestoStanovanja", korisnik.mjestoStanovanja);
                command.Parameters.AddWithValue("@adresa", korisnik.adresa);
                command.Parameters.AddWithValue("@spol", korisnik.spol);
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
                    conn.Close();
                }
            }
        }
    }
}
