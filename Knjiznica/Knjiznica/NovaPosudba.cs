﻿using Knjiznica.Model;
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
        List<Knjiga> knjige;

        public NovaPosudba()
        {
            InitializeComponent();
            knjige = new List<Knjiga>();
        }

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
