using Knjiznica.Model;
using MySql.Data.MySqlClient;
using System;
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
    public partial class NovaPosudba : Form
    {
        List<Knjiga> listaKnjiga;
        List<Korisnik> listaKorisnika;


        public NovaPosudba()
        {
            listaKorisnika = new List<Korisnik>();
            InitializeComponent();
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

            //filtriraj datagrid

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

            //dodajKnjigeUGrid(listaKnjigatmp.ToList());
        }

        
    }
}
