namespace Knjiznica
{
    partial class NovaPosudba
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
            this.gb_Korisnik = new System.Windows.Forms.GroupBox();
            this.tb_MjestoStan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_IDkorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Knjiga = new System.Windows.Forms.GroupBox();
            this.tb_Godina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Izdavac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_NazivKnjige = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Autor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgw_KnjigeSearch = new System.Windows.Forms.DataGridView();
            this.dgw_KorisnikSearch = new System.Windows.Forms.DataGridView();
            this.btn_Posudi = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoStan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OznaciKorisnik = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posudi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gb_Korisnik.SuspendLayout();
            this.gb_Knjiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_KnjigeSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_KorisnikSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Korisnik
            // 
            this.gb_Korisnik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Korisnik.Controls.Add(this.tb_MjestoStan);
            this.gb_Korisnik.Controls.Add(this.label4);
            this.gb_Korisnik.Controls.Add(this.tb_Prezime);
            this.gb_Korisnik.Controls.Add(this.label3);
            this.gb_Korisnik.Controls.Add(this.tb_Ime);
            this.gb_Korisnik.Controls.Add(this.label2);
            this.gb_Korisnik.Controls.Add(this.tb_IDkorisnik);
            this.gb_Korisnik.Controls.Add(this.label1);
            this.gb_Korisnik.Location = new System.Drawing.Point(12, 12);
            this.gb_Korisnik.Name = "gb_Korisnik";
            this.gb_Korisnik.Size = new System.Drawing.Size(804, 101);
            this.gb_Korisnik.TabIndex = 1;
            this.gb_Korisnik.TabStop = false;
            this.gb_Korisnik.Text = "Podaci o korisniku";
            // 
            // tb_MjestoStan
            // 
            this.tb_MjestoStan.Location = new System.Drawing.Point(327, 71);
            this.tb_MjestoStan.Name = "tb_MjestoStan";
            this.tb_MjestoStan.Size = new System.Drawing.Size(153, 20);
            this.tb_MjestoStan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mjesto stanovanja";
            // 
            // tb_Prezime
            // 
            this.tb_Prezime.Location = new System.Drawing.Point(168, 71);
            this.tb_Prezime.Name = "tb_Prezime";
            this.tb_Prezime.Size = new System.Drawing.Size(153, 20);
            this.tb_Prezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime";
            // 
            // tb_Ime
            // 
            this.tb_Ime.Location = new System.Drawing.Point(9, 71);
            this.tb_Ime.Name = "tb_Ime";
            this.tb_Ime.Size = new System.Drawing.Size(153, 20);
            this.tb_Ime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // tb_IDkorisnik
            // 
            this.tb_IDkorisnik.Location = new System.Drawing.Point(9, 32);
            this.tb_IDkorisnik.Name = "tb_IDkorisnik";
            this.tb_IDkorisnik.Size = new System.Drawing.Size(73, 20);
            this.tb_IDkorisnik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // gb_Knjiga
            // 
            this.gb_Knjiga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Knjiga.Controls.Add(this.tb_Godina);
            this.gb_Knjiga.Controls.Add(this.label10);
            this.gb_Knjiga.Controls.Add(this.tb_Izdavac);
            this.gb_Knjiga.Controls.Add(this.label9);
            this.gb_Knjiga.Controls.Add(this.tb_NazivKnjige);
            this.gb_Knjiga.Controls.Add(this.label8);
            this.gb_Knjiga.Controls.Add(this.tb_Autor);
            this.gb_Knjiga.Controls.Add(this.label7);
            this.gb_Knjiga.Controls.Add(this.tb_ISBN);
            this.gb_Knjiga.Controls.Add(this.label6);
            this.gb_Knjiga.Location = new System.Drawing.Point(12, 274);
            this.gb_Knjiga.Name = "gb_Knjiga";
            this.gb_Knjiga.Size = new System.Drawing.Size(804, 105);
            this.gb_Knjiga.TabIndex = 2;
            this.gb_Knjiga.TabStop = false;
            this.gb_Knjiga.Text = "Podaci o knjizi";
            // 
            // tb_Godina
            // 
            this.tb_Godina.Location = new System.Drawing.Point(486, 71);
            this.tb_Godina.Name = "tb_Godina";
            this.tb_Godina.Size = new System.Drawing.Size(89, 20);
            this.tb_Godina.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Godina izdavanja";
            // 
            // tb_Izdavac
            // 
            this.tb_Izdavac.Location = new System.Drawing.Point(327, 71);
            this.tb_Izdavac.Name = "tb_Izdavac";
            this.tb_Izdavac.Size = new System.Drawing.Size(153, 20);
            this.tb_Izdavac.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Izdavač";
            // 
            // tb_NazivKnjige
            // 
            this.tb_NazivKnjige.Location = new System.Drawing.Point(168, 71);
            this.tb_NazivKnjige.Name = "tb_NazivKnjige";
            this.tb_NazivKnjige.Size = new System.Drawing.Size(153, 20);
            this.tb_NazivKnjige.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Naziv knjige";
            // 
            // tb_Autor
            // 
            this.tb_Autor.Location = new System.Drawing.Point(9, 71);
            this.tb_Autor.Name = "tb_Autor";
            this.tb_Autor.Size = new System.Drawing.Size(153, 20);
            this.tb_Autor.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Autor";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(9, 32);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(153, 20);
            this.tb_ISBN.TabIndex = 6;
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ISBN";
            // 
            // dgw_KnjigeSearch
            // 
            this.dgw_KnjigeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_KnjigeSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgw_KnjigeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_KnjigeSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.NazivKnjige,
            this.Autor,
            this.Izdavac,
            this.godina,
            this.Posudi});
            this.dgw_KnjigeSearch.Location = new System.Drawing.Point(12, 385);
            this.dgw_KnjigeSearch.Name = "dgw_KnjigeSearch";
            this.dgw_KnjigeSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_KnjigeSearch.Size = new System.Drawing.Size(804, 121);
            this.dgw_KnjigeSearch.TabIndex = 11;
            // 
            // dgw_KorisnikSearch
            // 
            this.dgw_KorisnikSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_KorisnikSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgw_KorisnikSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_KorisnikSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.MjestoStan,
            this.OznaciKorisnik});
            this.dgw_KorisnikSearch.Location = new System.Drawing.Point(12, 119);
            this.dgw_KorisnikSearch.Name = "dgw_KorisnikSearch";
            this.dgw_KorisnikSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_KorisnikSearch.Size = new System.Drawing.Size(804, 121);
            this.dgw_KorisnikSearch.TabIndex = 12;
            // 
            // btn_Posudi
            // 
            this.btn_Posudi.Location = new System.Drawing.Point(12, 605);
            this.btn_Posudi.Name = "btn_Posudi";
            this.btn_Posudi.Size = new System.Drawing.Size(103, 31);
            this.btn_Posudi.TabIndex = 13;
            this.btn_Posudi.Text = "Posudi";
            this.btn_Posudi.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // MjestoStan
            // 
            this.MjestoStan.HeaderText = "Mjesto stanovanja";
            this.MjestoStan.Name = "MjestoStan";
            this.MjestoStan.Width = 150;
            // 
            // OznaciKorisnik
            // 
            this.OznaciKorisnik.HeaderText = "Označi";
            this.OznaciKorisnik.Name = "OznaciKorisnik";
            this.OznaciKorisnik.Width = 50;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.HeaderText = "Naziv knjige";
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Izdavac
            // 
            this.Izdavac.HeaderText = "Izdavač";
            this.Izdavac.Name = "Izdavac";
            // 
            // godina
            // 
            this.godina.HeaderText = "Godina";
            this.godina.Name = "godina";
            // 
            // Posudi
            // 
            this.Posudi.HeaderText = "Posudi";
            this.Posudi.Name = "Posudi";
            this.Posudi.Width = 50;
            // 
            // NovaPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 648);
            this.Controls.Add(this.btn_Posudi);
            this.Controls.Add(this.dgw_KorisnikSearch);
            this.Controls.Add(this.dgw_KnjigeSearch);
            this.Controls.Add(this.gb_Knjiga);
            this.Controls.Add(this.gb_Korisnik);
            this.MinimumSize = new System.Drawing.Size(844, 687);
            this.Name = "NovaPosudba";
            this.Text = "Nova posudba";
            this.gb_Korisnik.ResumeLayout(false);
            this.gb_Korisnik.PerformLayout();
            this.gb_Knjiga.ResumeLayout(false);
            this.gb_Knjiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_KnjigeSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_KorisnikSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Korisnik;
        private System.Windows.Forms.TextBox tb_Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_IDkorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MjestoStan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_Knjiga;
        private System.Windows.Forms.TextBox tb_NazivKnjige;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Autor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgw_KnjigeSearch;
        private System.Windows.Forms.TextBox tb_Izdavac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgw_KorisnikSearch;
        private System.Windows.Forms.Button btn_Posudi;
        private System.Windows.Forms.TextBox tb_Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoStan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OznaciKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izdavac;
        private System.Windows.Forms.DataGridViewTextBoxColumn godina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Posudi;
    }
}