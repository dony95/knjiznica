using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Knjiznica.Model;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Knjiznica
{
    public partial class IzbrisiKnjigu : Form
    {
        MySqlConnection conn;
        Knjiga knjiga;
        public IzbrisiKnjigu(MySqlConnection conn, Knjiga knjiga)
        {
            this.conn = conn;
            this.knjiga = knjiga;
            InitializeComponent();
            ucitajPodatkeOknjizi();
        }

        private void ucitajPodatkeOknjizi()
        {
            lbl_naziv.Text = knjiga.naziv;
            lbl_izdavac.Text = knjiga.izdavac;
            lbl_godina.Text = knjiga.godina.ToString();
            lbl_brojstranica.Text = knjiga.brojKopija.ToString();
            lbl_autor.Text = knjiga.autor;
            lbl_brojKopija.Text = knjiga.brojKopija.ToString();
            box_brojKnjiga.Maximum = knjiga.brojKopija;
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            var kolekcija = MainWindow.mongoClient.GetDatabase("knjiznica").GetCollection<BsonDocument>("knjige");
            bool error = false;
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE knjige SET brojKopija = brojKopija - @broj WHERE id = @id";
                command.Parameters.AddWithValue("@id", knjiga.id);
                command.Parameters.AddWithValue("@broj", box_brojKnjiga.Value);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                error = true;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(!error)
                {
                    knjiga.brojKopija -= (int)box_brojKnjiga.Value;
                    MessageBox.Show("Knjige uspješno izbrisane!");
                    kolekcija.InsertOneAsync(new BsonDocument
                    {
                        { "info", "Izbrisano je " + (int)box_brojKnjiga.Value + 
                        " kopija knjige, ISBN = " + knjiga.isbn},
                        { "datumIvrijeme", DateTime.Now.ToString("dd.MM.yyyy HH:mm") }
                    });
                    this.Close();
                }
            }
            
        }
    }
}
