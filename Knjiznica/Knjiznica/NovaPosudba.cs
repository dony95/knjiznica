﻿using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class NovaPosudba : Form
    {
        List<Knjiga> listaKnjiga;
        List<Korisnik> listaKorisnika;
        int selectedCheckBoxRowIndex = -1;


        public NovaPosudba(List<Knjiga> listaKnjiga, List<Korisnik> listaKorisnika)
        {
            this.listaKnjiga = listaKnjiga;
            this.listaKorisnika = listaKorisnika;
            InitializeComponent();
            dodajKnjigeUGrid(listaKnjiga);
            dodajKorisnikeUGrid(listaKorisnika);
        }

        //_____________________________________________________________________

        //Keypress check

        //_____________________________________________________________________

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Godina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if(tb_Godina.Text.Length < 5)
                {
                    e.Handled = true;
                } 
            }          
        }

        private void tb_IDkorisnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //_____________________________________________________________________

        //pretraga Buttonovi

        //_____________________________________________________________________


        private void btn_PretragaKorisnik_Click(object sender, EventArgs e)
        {
            IEnumerable<Korisnik> listaKorisnikatmp = listaKorisnika;

            if (tb_IDkorisnik.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.Where(u => u.id == int.Parse(tb_IDkorisnik.Text));

            if (tb_Ime.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.Where(u => u.ime.ToLower().Contains(tb_Ime.Text.ToLower()));

            if (tb_Prezime.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.Where(u => u.ime.ToLower().Contains(tb_Prezime.Text.ToLower()));

            if (tb_MjestoStan.Text != "")
                listaKorisnikatmp = listaKorisnikatmp.Where(u => u.ime.ToLower().Contains(tb_MjestoStan.Text.ToLower()));

            dodajKorisnikeUGrid(listaKorisnikatmp.ToList());

        }

        private void btn_PretragaKnjiga_Click(object sender, EventArgs e)
        {
            IEnumerable<Knjiga> listaKnjigatmp = listaKnjiga;

            if (tb_Autor.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.autor.ToLower().Contains(tb_Autor.Text.ToLower()));

            if (tb_ISBN.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.id == int.Parse(tb_ISBN.Text));

            if (tb_Izdavac.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.izdavac.ToLower().Contains(tb_Izdavac.Text.ToLower()));

            if (tb_Godina.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.godina == int.Parse(tb_Godina.Text));

            if (tb_NazivKnjige.Text != "")
                listaKnjigatmp = listaKnjigatmp.Where(k => k.naziv.ToLower().Contains(tb_NazivKnjige.Text.ToLower()));

            dodajKnjigeUGrid(listaKnjigatmp.ToList());
        }

        private void dodajKnjigeUGrid(List<Knjiga> listaKnjiga)
        {
            dgw_KnjigeSearch.Rows.Clear();

            foreach (Knjiga k in listaKnjiga)
                dgw_KnjigeSearch.Rows.Add(k.isbn, k.naziv, k.autor, k.izdavac, k.godina, k.brojKopija);
        }

        private void dodajKorisnikeUGrid(List<Korisnik> listaKorisnika)
        {
            dgw_KorisnikSearch.Rows.Clear();

            foreach (Korisnik k in listaKorisnika)
                dgw_KorisnikSearch.Rows.Add(k.id, k.ime, k.prezime, k.mjestoStanovanja);
        }

        private void dgw_KorisnikSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgw = (DataGridView)sender;

            if(dgw.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                if(selectedCheckBoxRowIndex != -1)
                    dgw.Rows[selectedCheckBoxRowIndex].Cells["OznaciKorisnik"].Value = false;

                selectedCheckBoxRowIndex = e.RowIndex;
            }
        }

        private void btn_Posudi_Click(object sender, EventArgs e)
        {
            List<Knjiga> listaKnjigaPosudba;

            foreach(DataGridViewRow r in dgw_KnjigeSearch.Rows)
            {
                if ((bool)r.Cells["Posudi"].Value == true)
                    MessageBox.Show((string)r.Cells[2].Value);
            }
        }
    }
}
