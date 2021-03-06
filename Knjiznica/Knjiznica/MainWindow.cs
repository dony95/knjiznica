﻿using System;
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
    public partial class MainWindow : Form
    {
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
            DodajKorisnikaForm forma = new DodajKorisnikaForm();
            forma.Show();
        }
    }
}
