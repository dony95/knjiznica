using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.Model
{
    public class Posudba
    {
        public int ID { get; set; } //ID bi bio userid + broj posudjenih knjiga jer moramo imat nacin pracenja 1 posudbe za vise knjiga
        public Korisnik korisnik { get; set; }
        public List<Knjiga> listaKnjiga { get; set; }
        public DateTime datumPosudbe { get; set; }
        public DateTime datumIstekaPosudbe { get; set; }
        public char status { get; set; }

        public void updatePosudbu(MySqlConnection conn)
        {
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE posudbe SET status = @status WHERE id = @id";
                command.Parameters.AddWithValue("@status", this.status);
                command.Parameters.AddWithValue("@id", this.ID);
                command.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        public void srediPosudbu(MySqlConnection conn)
        {
            if (this.status == 'N' && this.datumIstekaPosudbe < DateTime.Now)
            {
                this.status = 'O';
                string message = "Poštovani/a " + this.korisnik.ime + " " + this.korisnik.prezime +
                    ", vaša posudba je istekla. Molimo vas da u što kraćem roku vratite knjige kako ne biste platili veliku zakasninu.<br/>" +
                    "Datum posudbe: " + this.datumPosudbe.ToShortDateString() + "<br/>" +
                    "Datum isteka posudbe :" + this.datumIstekaPosudbe.ToShortDateString() + "<br/>" +
                    "Posudene knjige :<br/>";
                for (int i = 0; i < this.listaKnjiga.Count; i++)
                    message += (i + 1) + ". " + this.listaKnjiga[i].autor + " - " + this.listaKnjiga[i].naziv + "<br/>";
                message += "Hvala vam na povjerenju.";
                string subject = "Istek posudbe";
                MainWindow.SendMessage(this.korisnik.email, message, subject);
                this.updatePosudbu(conn);
            }
        }

        public void vratiPosudbu(MySqlConnection conn)
        {
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE posudbe SET status = @status WHERE id = @id;";
                command.Parameters.AddWithValue("@status", 'Y');
                command.Parameters.AddWithValue("@id", this.ID);
                for(int i = 0; i < listaKnjiga.Count; i++)
                {
                    command.CommandText += "UPDATE knjige SET BrojKopija = BrojKopija + 1 WHERE id = @knjID" + listaKnjiga[i].id;
                    command.Parameters.AddWithValue("@knjID", listaKnjiga[i].id);
                }
                command.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
