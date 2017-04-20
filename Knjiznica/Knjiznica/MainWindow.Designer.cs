namespace Knjiznica
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.novaPosudbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_Godina = new System.Windows.Forms.TextBox();
            this.btn_DodajKnjigu = new System.Windows.Forms.Button();
            this.tb_Izdavac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Kategorija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_PretragaKnjige = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AutorKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_Knjige = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojStranica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKopija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NazivKnjige = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_DodajKorisnika = new System.Windows.Forms.Button();
            this.data_Korisnici = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoStanovanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIstekaClanarine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PretragaKorisnika = new System.Windows.Forms.Button();
            this.tb_Prezime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ImeKorisnika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_IDkorisnik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_KorisnikPrez = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_KorisnikID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_NovaPosudba = new System.Windows.Forms.Button();
            this.data_Posudbe = new System.Windows.Forms.DataGridView();
            this.posudbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeIprezimeKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPosudbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIstekaPosudbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojKnjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produzi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_PretragaPosudbe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_IDposudba = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Knjige)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Korisnici)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Posudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaKnjigaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem,
            this.toolStripSeparator1,
            this.novaPosudbaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // novaKnjigaToolStripMenuItem
            // 
            this.novaKnjigaToolStripMenuItem.Name = "novaKnjigaToolStripMenuItem";
            this.novaKnjigaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novaKnjigaToolStripMenuItem.Text = "Dodaj knjigu";
            this.novaKnjigaToolStripMenuItem.Click += new System.EventHandler(this.btn_DodajKnjigu_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.btn_DodajKorisnika_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // novaPosudbaToolStripMenuItem
            // 
            this.novaPosudbaToolStripMenuItem.Name = "novaPosudbaToolStripMenuItem";
            this.novaPosudbaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novaPosudbaToolStripMenuItem.Text = "Nova posudba";
            this.novaPosudbaToolStripMenuItem.Click += new System.EventHandler(this.btn_NovaPosudba_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 553);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_Godina);
            this.tabPage1.Controls.Add(this.btn_DodajKnjigu);
            this.tabPage1.Controls.Add(this.tb_Izdavac);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_ISBN);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cb_Kategorija);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_PretragaKnjige);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_AutorKnjige);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.data_Knjige);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_NazivKnjige);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Knjige";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_Godina
            // 
            this.tb_Godina.Location = new System.Drawing.Point(801, 19);
            this.tb_Godina.MaxLength = 4;
            this.tb_Godina.Name = "tb_Godina";
            this.tb_Godina.Size = new System.Drawing.Size(100, 20);
            this.tb_Godina.TabIndex = 43;
            this.tb_Godina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Godina_KeyPress);
            // 
            // btn_DodajKnjigu
            // 
            this.btn_DodajKnjigu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DodajKnjigu.Location = new System.Drawing.Point(960, 496);
            this.btn_DodajKnjigu.Name = "btn_DodajKnjigu";
            this.btn_DodajKnjigu.Size = new System.Drawing.Size(110, 25);
            this.btn_DodajKnjigu.TabIndex = 9;
            this.btn_DodajKnjigu.Text = "Dodaj knjigu";
            this.btn_DodajKnjigu.UseVisualStyleBackColor = true;
            this.btn_DodajKnjigu.Click += new System.EventHandler(this.btn_DodajKnjigu_Click);
            // 
            // tb_Izdavac
            // 
            this.tb_Izdavac.Location = new System.Drawing.Point(642, 19);
            this.tb_Izdavac.Name = "tb_Izdavac";
            this.tb_Izdavac.Size = new System.Drawing.Size(153, 20);
            this.tb_Izdavac.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Izdavač";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(6, 19);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(153, 20);
            this.tb_ISBN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "ISBN";
            // 
            // cb_Kategorija
            // 
            this.cb_Kategorija.FormattingEnabled = true;
            this.cb_Kategorija.ItemHeight = 13;
            this.cb_Kategorija.Location = new System.Drawing.Point(483, 18);
            this.cb_Kategorija.Name = "cb_Kategorija";
            this.cb_Kategorija.Size = new System.Drawing.Size(153, 21);
            this.cb_Kategorija.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Kategorija";
            // 
            // btn_PretragaKnjige
            // 
            this.btn_PretragaKnjige.Location = new System.Drawing.Point(909, 18);
            this.btn_PretragaKnjige.Name = "btn_PretragaKnjige";
            this.btn_PretragaKnjige.Size = new System.Drawing.Size(95, 22);
            this.btn_PretragaKnjige.TabIndex = 7;
            this.btn_PretragaKnjige.Text = "Pretraži";
            this.btn_PretragaKnjige.UseVisualStyleBackColor = true;
            this.btn_PretragaKnjige.Click += new System.EventHandler(this.btn_PretragaKnjiga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Godina izdanja";
            // 
            // tb_AutorKnjige
            // 
            this.tb_AutorKnjige.Location = new System.Drawing.Point(324, 19);
            this.tb_AutorKnjige.Name = "tb_AutorKnjige";
            this.tb_AutorKnjige.Size = new System.Drawing.Size(153, 20);
            this.tb_AutorKnjige.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Autor knjige";
            // 
            // data_Knjige
            // 
            this.data_Knjige.AllowUserToAddRows = false;
            this.data_Knjige.AllowUserToDeleteRows = false;
            this.data_Knjige.AllowUserToOrderColumns = true;
            this.data_Knjige.AllowUserToResizeRows = false;
            this.data_Knjige.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Knjige.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Knjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.NazivKnjige,
            this.AutorKnjige,
            this.Kategorija,
            this.Izdavac,
            this.Godina,
            this.BrojStranica,
            this.Cijena,
            this.BrojKopija,
            this.edit});
            this.data_Knjige.Location = new System.Drawing.Point(6, 46);
            this.data_Knjige.Name = "data_Knjige";
            this.data_Knjige.ReadOnly = true;
            this.data_Knjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Knjige.Size = new System.Drawing.Size(1064, 444);
            this.data_Knjige.TabIndex = 8;
            this.data_Knjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Knjige_CellContentClick);
            this.data_Knjige.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Knjige_CellDoubleClick);
            this.data_Knjige.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Knjige_CellDoubleClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.HeaderText = "Naziv Knjige";
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.ReadOnly = true;
            // 
            // AutorKnjige
            // 
            this.AutorKnjige.HeaderText = "Autor Knjige";
            this.AutorKnjige.Name = "AutorKnjige";
            this.AutorKnjige.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Izdavac
            // 
            this.Izdavac.HeaderText = "Izdavac";
            this.Izdavac.Name = "Izdavac";
            this.Izdavac.ReadOnly = true;
            // 
            // Godina
            // 
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // BrojStranica
            // 
            this.BrojStranica.HeaderText = "BrojStranica";
            this.BrojStranica.Name = "BrojStranica";
            this.BrojStranica.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // BrojKopija
            // 
            this.BrojKopija.HeaderText = "BrojKopija";
            this.BrojKopija.Name = "BrojKopija";
            this.BrojKopija.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Kontrola";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Uredi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Naziv knjige";
            // 
            // tb_NazivKnjige
            // 
            this.tb_NazivKnjige.Location = new System.Drawing.Point(165, 19);
            this.tb_NazivKnjige.Name = "tb_NazivKnjige";
            this.tb_NazivKnjige.Size = new System.Drawing.Size(153, 20);
            this.tb_NazivKnjige.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tb_email);
            this.tabPage2.Controls.Add(this.btn_DodajKorisnika);
            this.tabPage2.Controls.Add(this.data_Korisnici);
            this.tabPage2.Controls.Add(this.btn_PretragaKorisnika);
            this.tabPage2.Controls.Add(this.tb_Prezime);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb_ImeKorisnika);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tb_IDkorisnik);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Korisnici";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(324, 56);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(153, 20);
            this.tb_email.TabIndex = 44;
            // 
            // btn_DodajKorisnika
            // 
            this.btn_DodajKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DodajKorisnika.Location = new System.Drawing.Point(960, 53);
            this.btn_DodajKorisnika.Name = "btn_DodajKorisnika";
            this.btn_DodajKorisnika.Size = new System.Drawing.Size(110, 23);
            this.btn_DodajKorisnika.TabIndex = 6;
            this.btn_DodajKorisnika.Text = "Dodaj korisnika";
            this.btn_DodajKorisnika.UseVisualStyleBackColor = true;
            this.btn_DodajKorisnika.Click += new System.EventHandler(this.btn_DodajKorisnika_Click);
            // 
            // data_Korisnici
            // 
            this.data_Korisnici.AllowUserToAddRows = false;
            this.data_Korisnici.AllowUserToDeleteRows = false;
            this.data_Korisnici.AllowUserToResizeRows = false;
            this.data_Korisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Korisnici.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Korisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.DatumRodenja,
            this.MjestoStanovanja,
            this.Adresa,
            this.DatumIstekaClanarine,
            this.Spol});
            this.data_Korisnici.Location = new System.Drawing.Point(6, 84);
            this.data_Korisnici.Name = "data_Korisnici";
            this.data_Korisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Korisnici.Size = new System.Drawing.Size(1064, 437);
            this.data_Korisnici.TabIndex = 5;
            this.data_Korisnici.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Korisnici_CellContentDoubleClick);
            this.data_Korisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Korisnici_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Email
            // 
            this.Email.HeaderText = "email";
            this.Email.Name = "Email";
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.HeaderText = "Datum Rodenja";
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.Width = 120;
            // 
            // MjestoStanovanja
            // 
            this.MjestoStanovanja.HeaderText = "Mjesto Stanovanja";
            this.MjestoStanovanja.Name = "MjestoStanovanja";
            this.MjestoStanovanja.Width = 120;
            // 
            // Adresa
            // 
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // DatumIstekaClanarine
            // 
            this.DatumIstekaClanarine.HeaderText = "Istek clanarine";
            this.DatumIstekaClanarine.Name = "DatumIstekaClanarine";
            this.DatumIstekaClanarine.Width = 120;
            // 
            // Spol
            // 
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // btn_PretragaKorisnika
            // 
            this.btn_PretragaKorisnika.Location = new System.Drawing.Point(483, 54);
            this.btn_PretragaKorisnika.Name = "btn_PretragaKorisnika";
            this.btn_PretragaKorisnika.Size = new System.Drawing.Size(90, 23);
            this.btn_PretragaKorisnika.TabIndex = 4;
            this.btn_PretragaKorisnika.Text = "Pretraži";
            this.btn_PretragaKorisnika.UseVisualStyleBackColor = true;
            this.btn_PretragaKorisnika.Click += new System.EventHandler(this.btn_PretragaKorisnika_Click);
            // 
            // tb_Prezime
            // 
            this.tb_Prezime.Location = new System.Drawing.Point(165, 56);
            this.tb_Prezime.Name = "tb_Prezime";
            this.tb_Prezime.Size = new System.Drawing.Size(153, 20);
            this.tb_Prezime.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Prezime";
            // 
            // tb_ImeKorisnika
            // 
            this.tb_ImeKorisnika.Location = new System.Drawing.Point(6, 56);
            this.tb_ImeKorisnika.Name = "tb_ImeKorisnika";
            this.tb_ImeKorisnika.Size = new System.Drawing.Size(153, 20);
            this.tb_ImeKorisnika.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ime";
            // 
            // tb_IDkorisnik
            // 
            this.tb_IDkorisnik.Location = new System.Drawing.Point(6, 19);
            this.tb_IDkorisnik.Name = "tb_IDkorisnik";
            this.tb_IDkorisnik.Size = new System.Drawing.Size(59, 20);
            this.tb_IDkorisnik.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_KorisnikPrez);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.tb_KorisnikID);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btn_NovaPosudba);
            this.tabPage3.Controls.Add(this.data_Posudbe);
            this.tabPage3.Controls.Add(this.btn_PretragaPosudbe);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tb_IDposudba);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1076, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posudbe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_KorisnikPrez
            // 
            this.tb_KorisnikPrez.Location = new System.Drawing.Point(324, 56);
            this.tb_KorisnikPrez.Name = "tb_KorisnikPrez";
            this.tb_KorisnikPrez.Size = new System.Drawing.Size(153, 20);
            this.tb_KorisnikPrez.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Prezime korisnika";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(321, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "ID korisnika";
            // 
            // tb_KorisnikID
            // 
            this.tb_KorisnikID.Location = new System.Drawing.Point(324, 19);
            this.tb_KorisnikID.Name = "tb_KorisnikID";
            this.tb_KorisnikID.Size = new System.Drawing.Size(153, 20);
            this.tb_KorisnikID.TabIndex = 58;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Autor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Naziv knjige";
            // 
            // btn_NovaPosudba
            // 
            this.btn_NovaPosudba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NovaPosudba.Location = new System.Drawing.Point(960, 53);
            this.btn_NovaPosudba.Name = "btn_NovaPosudba";
            this.btn_NovaPosudba.Size = new System.Drawing.Size(110, 23);
            this.btn_NovaPosudba.TabIndex = 7;
            this.btn_NovaPosudba.Text = "Nova Posudba";
            this.btn_NovaPosudba.UseVisualStyleBackColor = true;
            this.btn_NovaPosudba.Click += new System.EventHandler(this.btn_NovaPosudba_Click);
            // 
            // data_Posudbe
            // 
            this.data_Posudbe.AllowUserToAddRows = false;
            this.data_Posudbe.AllowUserToDeleteRows = false;
            this.data_Posudbe.AllowUserToOrderColumns = true;
            this.data_Posudbe.AllowUserToResizeRows = false;
            this.data_Posudbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Posudbe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Posudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Posudbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posudbaID,
            this.imeIprezimeKorisnika,
            this.datumPosudbe,
            this.datumIstekaPosudbe,
            this.brojKnjiga,
            this.Produzi});
            this.data_Posudbe.Location = new System.Drawing.Point(6, 84);
            this.data_Posudbe.Name = "data_Posudbe";
            this.data_Posudbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Posudbe.Size = new System.Drawing.Size(1064, 437);
            this.data_Posudbe.TabIndex = 6;
            this.data_Posudbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Posudbe_CellContentClick);
            // 
            // posudbaID
            // 
            this.posudbaID.HeaderText = "ID";
            this.posudbaID.Name = "posudbaID";
            // 
            // imeIprezimeKorisnika
            // 
            this.imeIprezimeKorisnika.HeaderText = "Korisnik";
            this.imeIprezimeKorisnika.Name = "imeIprezimeKorisnika";
            // 
            // datumPosudbe
            // 
            this.datumPosudbe.HeaderText = "Datum posudbe";
            this.datumPosudbe.Name = "datumPosudbe";
            // 
            // datumIstekaPosudbe
            // 
            this.datumIstekaPosudbe.HeaderText = "Datum isteka posudbe";
            this.datumIstekaPosudbe.Name = "datumIstekaPosudbe";
            // 
            // brojKnjiga
            // 
            this.brojKnjiga.HeaderText = "Broj knjiga";
            this.brojKnjiga.Name = "brojKnjiga";
            // 
            // Produzi
            // 
            this.Produzi.HeaderText = "Produzi";
            this.Produzi.Name = "Produzi";
            this.Produzi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Produzi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_PretragaPosudbe
            // 
            this.btn_PretragaPosudbe.Location = new System.Drawing.Point(483, 54);
            this.btn_PretragaPosudbe.Name = "btn_PretragaPosudbe";
            this.btn_PretragaPosudbe.Size = new System.Drawing.Size(90, 23);
            this.btn_PretragaPosudbe.TabIndex = 5;
            this.btn_PretragaPosudbe.Text = "Pretraži";
            this.btn_PretragaPosudbe.UseVisualStyleBackColor = true;
            this.btn_PretragaPosudbe.Click += new System.EventHandler(this.btn_PretragaPosudbe_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "ISBN";
            // 
            // tb_IDposudba
            // 
            this.tb_IDposudba.Location = new System.Drawing.Point(6, 19);
            this.tb_IDposudba.Name = "tb_IDposudba";
            this.tb_IDposudba.Size = new System.Drawing.Size(59, 20);
            this.tb_IDposudba.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "ID";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btn_PretragaKnjige;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 590);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(962, 300);
            this.Name = "MainWindow";
            this.Text = "Knjiznica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Knjige)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Korisnici)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Posudbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_DodajKnjigu;
        private System.Windows.Forms.TextBox tb_Izdavac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Kategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_PretragaKnjige;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_AutorKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_Knjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NazivKnjige;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_DodajKorisnika;
        private System.Windows.Forms.DataGridView data_Korisnici;
        private System.Windows.Forms.Button btn_PretragaKorisnika;
        private System.Windows.Forms.TextBox tb_Prezime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_ImeKorisnika;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_IDkorisnik;
        private System.Windows.Forms.ToolStripMenuItem novaPosudbaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_NovaPosudba;
        private System.Windows.Forms.DataGridView data_Posudbe;
        private System.Windows.Forms.Button btn_PretragaPosudbe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_IDposudba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_KorisnikPrez;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izdavac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojStranica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKopija;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.TextBox tb_Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoStanovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIstekaClanarine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn posudbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeIprezimeKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPosudbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIstekaPosudbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojKnjiga;
        private System.Windows.Forms.DataGridViewButtonColumn Produzi;
    }
}

