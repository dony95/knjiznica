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
            this.btn_DodajKnjigu = new System.Windows.Forms.Button();
            this.tb_Izdavac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_IDknjiga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Kategorija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_PretragaKnjige = new System.Windows.Forms.Button();
            this.num_Godina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AutorKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_Knjige = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NazivKnjige = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DodajKorisnika = new System.Windows.Forms.Button();
            this.data_Korisnici = new System.Windows.Forms.DataGridView();
            this.btn_PretragaKorisnika = new System.Windows.Forms.Button();
            this.tb_Prezime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ImeKorisnika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_IDkorisnik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_NovaPosudba = new System.Windows.Forms.Button();
            this.data_Posudbe = new System.Windows.Forms.DataGridView();
            this.btn_PretragaPosudbe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_IDposudba = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Godina)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
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
            this.tabControl1.Size = new System.Drawing.Size(924, 553);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_DodajKnjigu);
            this.tabPage1.Controls.Add(this.tb_Izdavac);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_IDknjiga);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cb_Kategorija);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_PretragaKnjige);
            this.tabPage1.Controls.Add(this.num_Godina);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_AutorKnjige);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.data_Knjige);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_NazivKnjige);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Knjige";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_DodajKnjigu
            // 
            this.btn_DodajKnjigu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DodajKnjigu.Location = new System.Drawing.Point(800, 496);
            this.btn_DodajKnjigu.Name = "btn_DodajKnjigu";
            this.btn_DodajKnjigu.Size = new System.Drawing.Size(110, 25);
            this.btn_DodajKnjigu.TabIndex = 9;
            this.btn_DodajKnjigu.Text = "Dodaj knjigu";
            this.btn_DodajKnjigu.UseVisualStyleBackColor = true;
            this.btn_DodajKnjigu.Click += new System.EventHandler(this.btn_DodajKnjigu_Click);
            // 
            // tb_Izdavac
            // 
            this.tb_Izdavac.Location = new System.Drawing.Point(548, 19);
            this.tb_Izdavac.Name = "tb_Izdavac";
            this.tb_Izdavac.Size = new System.Drawing.Size(153, 20);
            this.tb_Izdavac.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Izdavač";
            // 
            // tb_IDknjiga
            // 
            this.tb_IDknjiga.Location = new System.Drawing.Point(6, 19);
            this.tb_IDknjiga.Name = "tb_IDknjiga";
            this.tb_IDknjiga.Size = new System.Drawing.Size(59, 20);
            this.tb_IDknjiga.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "ID";
            // 
            // cb_Kategorija
            // 
            this.cb_Kategorija.FormattingEnabled = true;
            this.cb_Kategorija.ItemHeight = 13;
            this.cb_Kategorija.Location = new System.Drawing.Point(389, 18);
            this.cb_Kategorija.Name = "cb_Kategorija";
            this.cb_Kategorija.Size = new System.Drawing.Size(153, 21);
            this.cb_Kategorija.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Kategorija";
            // 
            // btn_PretragaKnjige
            // 
            this.btn_PretragaKnjige.Location = new System.Drawing.Point(815, 18);
            this.btn_PretragaKnjige.Name = "btn_PretragaKnjige";
            this.btn_PretragaKnjige.Size = new System.Drawing.Size(95, 22);
            this.btn_PretragaKnjige.TabIndex = 7;
            this.btn_PretragaKnjige.Text = "Pretraži";
            this.btn_PretragaKnjige.UseVisualStyleBackColor = true;
            this.btn_PretragaKnjige.Click += new System.EventHandler(this.btn_PretragaKnjiga_Click);
            // 
            // num_Godina
            // 
            this.num_Godina.Location = new System.Drawing.Point(707, 19);
            this.num_Godina.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_Godina.Name = "num_Godina";
            this.num_Godina.Size = new System.Drawing.Size(102, 20);
            this.num_Godina.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Godina izdanja";
            // 
            // tb_AutorKnjige
            // 
            this.tb_AutorKnjige.Location = new System.Drawing.Point(230, 19);
            this.tb_AutorKnjige.Name = "tb_AutorKnjige";
            this.tb_AutorKnjige.Size = new System.Drawing.Size(153, 20);
            this.tb_AutorKnjige.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Autor knjige";
            // 
            // data_Knjige
            // 
            this.data_Knjige.AllowUserToOrderColumns = true;
            this.data_Knjige.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Knjige.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Knjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NazivKnjige,
            this.edit});
            this.data_Knjige.Location = new System.Drawing.Point(6, 46);
            this.data_Knjige.Name = "data_Knjige";
            this.data_Knjige.Size = new System.Drawing.Size(904, 444);
            this.data_Knjige.TabIndex = 8;
            this.data_Knjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Knjige_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.HeaderText = "Naziv Knjige";
            this.NazivKnjige.Name = "NazivKnjige";
            // 
            // edit
            // 
            this.edit.HeaderText = "Kontrola";
            this.edit.Name = "edit";
            this.edit.Text = "Uredi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Naziv knjige";
            // 
            // tb_NazivKnjige
            // 
            this.tb_NazivKnjige.Location = new System.Drawing.Point(71, 19);
            this.tb_NazivKnjige.Name = "tb_NazivKnjige";
            this.tb_NazivKnjige.Size = new System.Drawing.Size(153, 20);
            this.tb_NazivKnjige.TabIndex = 2;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(916, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Korisnici";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DodajKorisnika
            // 
            this.btn_DodajKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DodajKorisnika.Location = new System.Drawing.Point(801, 53);
            this.btn_DodajKorisnika.Name = "btn_DodajKorisnika";
            this.btn_DodajKorisnika.Size = new System.Drawing.Size(110, 25);
            this.btn_DodajKorisnika.TabIndex = 6;
            this.btn_DodajKorisnika.Text = "Dodaj korisnika";
            this.btn_DodajKorisnika.UseVisualStyleBackColor = true;
            this.btn_DodajKorisnika.Click += new System.EventHandler(this.btn_DodajKorisnika_Click);
            // 
            // data_Korisnici
            // 
            this.data_Korisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Korisnici.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Korisnici.Location = new System.Drawing.Point(6, 84);
            this.data_Korisnici.Name = "data_Korisnici";
            this.data_Korisnici.Size = new System.Drawing.Size(904, 437);
            this.data_Korisnici.TabIndex = 5;
            // 
            // btn_PretragaKorisnika
            // 
            this.btn_PretragaKorisnika.Location = new System.Drawing.Point(324, 55);
            this.btn_PretragaKorisnika.Name = "btn_PretragaKorisnika";
            this.btn_PretragaKorisnika.Size = new System.Drawing.Size(90, 22);
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
            this.tabPage3.Size = new System.Drawing.Size(916, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posudbe";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.btn_NovaPosudba.Location = new System.Drawing.Point(801, 53);
            this.btn_NovaPosudba.Name = "btn_NovaPosudba";
            this.btn_NovaPosudba.Size = new System.Drawing.Size(110, 25);
            this.btn_NovaPosudba.TabIndex = 7;
            this.btn_NovaPosudba.Text = "Nova Posudba";
            this.btn_NovaPosudba.UseVisualStyleBackColor = true;
            this.btn_NovaPosudba.Click += new System.EventHandler(this.btn_NovaPosudba_Click);
            // 
            // data_Posudbe
            // 
            this.data_Posudbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Posudbe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_Posudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Posudbe.Location = new System.Drawing.Point(6, 84);
            this.data_Posudbe.Name = "data_Posudbe";
            this.data_Posudbe.Size = new System.Drawing.Size(904, 437);
            this.data_Posudbe.TabIndex = 6;
            // 
            // btn_PretragaPosudbe
            // 
            this.btn_PretragaPosudbe.Location = new System.Drawing.Point(324, 55);
            this.btn_PretragaPosudbe.Name = "btn_PretragaPosudbe";
            this.btn_PretragaPosudbe.Size = new System.Drawing.Size(90, 22);
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
            this.ClientSize = new System.Drawing.Size(946, 590);
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
            ((System.ComponentModel.ISupportInitialize)(this.num_Godina)).EndInit();
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
        private System.Windows.Forms.TextBox tb_IDknjiga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Kategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_PretragaKnjige;
        private System.Windows.Forms.NumericUpDown num_Godina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_AutorKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_Knjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NazivKnjige;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
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
    }
}

