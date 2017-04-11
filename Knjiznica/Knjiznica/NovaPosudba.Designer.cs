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
            this.tb_NazivKnjige = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Autor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_IDknjiga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Izdavac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_Godina = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_Korisnik.SuspendLayout();
            this.gb_Knjiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Godina)).BeginInit();
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
            this.tb_IDkorisnik.Size = new System.Drawing.Size(45, 20);
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
            this.gb_Knjiga.Controls.Add(this.label10);
            this.gb_Knjiga.Controls.Add(this.num_Godina);
            this.gb_Knjiga.Controls.Add(this.tb_Izdavac);
            this.gb_Knjiga.Controls.Add(this.label9);
            this.gb_Knjiga.Controls.Add(this.tb_NazivKnjige);
            this.gb_Knjiga.Controls.Add(this.label8);
            this.gb_Knjiga.Controls.Add(this.tb_Autor);
            this.gb_Knjiga.Controls.Add(this.label7);
            this.gb_Knjiga.Controls.Add(this.tb_ISBN);
            this.gb_Knjiga.Controls.Add(this.label6);
            this.gb_Knjiga.Controls.Add(this.tb_IDknjiga);
            this.gb_Knjiga.Controls.Add(this.label5);
            this.gb_Knjiga.Location = new System.Drawing.Point(12, 119);
            this.gb_Knjiga.Name = "gb_Knjiga";
            this.gb_Knjiga.Size = new System.Drawing.Size(804, 105);
            this.gb_Knjiga.TabIndex = 2;
            this.gb_Knjiga.TabStop = false;
            this.gb_Knjiga.Text = "Podaci o knjizi";
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
            this.tb_ISBN.Location = new System.Drawing.Point(60, 32);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(153, 20);
            this.tb_ISBN.TabIndex = 6;
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ISBN";
            // 
            // tb_IDknjiga
            // 
            this.tb_IDknjiga.Location = new System.Drawing.Point(9, 32);
            this.tb_IDknjiga.Name = "tb_IDknjiga";
            this.tb_IDknjiga.Size = new System.Drawing.Size(45, 20);
            this.tb_IDknjiga.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 314);
            this.dataGridView1.TabIndex = 11;
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
            // num_Godina
            // 
            this.num_Godina.Location = new System.Drawing.Point(486, 71);
            this.num_Godina.Name = "num_Godina";
            this.num_Godina.Size = new System.Drawing.Size(120, 20);
            this.num_Godina.TabIndex = 10;
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
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // NovaPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Knjiga);
            this.Controls.Add(this.gb_Korisnik);
            this.MinimumSize = new System.Drawing.Size(613, 0);
            this.Name = "NovaPosudba";
            this.Text = "Nova posudba";
            this.gb_Korisnik.ResumeLayout(false);
            this.gb_Korisnik.PerformLayout();
            this.gb_Knjiga.ResumeLayout(false);
            this.gb_Knjiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Godina)).EndInit();
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
        private System.Windows.Forms.TextBox tb_IDknjiga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Izdavac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_Godina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}