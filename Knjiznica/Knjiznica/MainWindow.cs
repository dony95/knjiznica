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
    public partial class MainWindow : Form
    {
        List<Knjiga> listaKnjiga;
        MySqlConnection conn;
        string ConnectionString = string.Empty;
        public MainWindow()
        {
            listaKnjiga = new List<Knjiga>();
            connectionType();
            conn = new MySqlConnection(ConnectionString);
            InitializeComponent();
            ucitajPodatke(conn);
        }

        private void btn_DodajKnjigu_Click(object sender, EventArgs e)
        {
            //Prikazi formu za dodavanje i uredjivanje knjige
            DodajUrediKnjigu DodajUrediForma = new DodajUrediKnjigu(conn);
            DodajUrediForma.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajUrediKorisnika forma = new DodajUrediKorisnika(conn);
            forma.Show();
        }

        private void btn_Pretraga_Click(object sender, EventArgs e)
        {

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

        public void ucitajPodatke(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM knjige";
            command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                for(int i = 0; i < dt.Rows.Count; i++)
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

            foreach(Knjiga k in listaKnjiga)
            {
                popisKnjigaGrid.Rows.Add(k.id, k.naziv);
            }
            conn.Close();
        }
    }
}
