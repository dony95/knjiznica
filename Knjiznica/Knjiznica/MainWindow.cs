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

namespace Knjiznica
{
    public partial class MainWindow : Form
    {
        MySqlCommand conn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_DodajKnjigu_Click(object sender, EventArgs e)
        {
            //Prikazi formu za dodavanje i uredjivanje knjige
            DodajUrediKnjigu DodajUrediForma = new DodajUrediKnjigu();
            DodajUrediForma.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajUrediKorisnika forma = new DodajUrediKorisnika();
            forma.Show();
        }

        private void btn_PretragaKnjiga_Click(object sender, EventArgs e)
        {

        }

        private void btn_DodajKorisnika_Click(object sender, EventArgs e)
        {
            DodajUrediKorisnika forma = new DodajUrediKorisnika();
            forma.Show();
        }

        private void btn_PretragaKorisnika_Click(object sender, EventArgs e)
        {

        }

        private void btn_NovaPosudba_Click(object sender, EventArgs e)
        {
            NovaPosudba forma = new NovaPosudba();
            forma.Show();
        }

        private void novaPosudbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaPosudba forma = new NovaPosudba();
            forma.Show();
        }

        private void btn_PretragaPosudbe_Click(object sender, EventArgs e)
        {

        }
    }
}
