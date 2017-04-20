namespace Knjiznica
{
    partial class DodajUrediKnjigu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Godina = new System.Windows.Forms.TextBox();
            this.num_BrKopija = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_DodajUredi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Kategorija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Izdavac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_BrojStranica = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NazivKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Autor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_idKnjige = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BrKopija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BrojStranica)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_idKnjige);
            this.groupBox1.Controls.Add(this.tb_Godina);
            this.groupBox1.Controls.Add(this.num_BrKopija);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_DodajUredi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_Kategorija);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Izdavac);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_ISBN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_BrojStranica);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_NazivKnjige);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Autor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o knjizi";
            // 
            // tb_Godina
            // 
            this.tb_Godina.Location = new System.Drawing.Point(196, 150);
            this.tb_Godina.Name = "tb_Godina";
            this.tb_Godina.Size = new System.Drawing.Size(181, 20);
            this.tb_Godina.TabIndex = 16;
            this.tb_Godina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Godina_KeyPress);
            // 
            // num_BrKopija
            // 
            this.num_BrKopija.Location = new System.Drawing.Point(196, 198);
            this.num_BrKopija.Name = "num_BrKopija";
            this.num_BrKopija.Size = new System.Drawing.Size(181, 20);
            this.num_BrKopija.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Broj kopija";
            // 
            // btn_DodajUredi
            // 
            this.btn_DodajUredi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_DodajUredi.Location = new System.Drawing.Point(119, 289);
            this.btn_DodajUredi.Name = "btn_DodajUredi";
            this.btn_DodajUredi.Size = new System.Drawing.Size(146, 32);
            this.btn_DodajUredi.TabIndex = 9;
            this.btn_DodajUredi.Text = "Potvrdi";
            this.btn_DodajUredi.UseVisualStyleBackColor = true;
            this.btn_DodajUredi.Click += new System.EventHandler(this.btn_DodajUredi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Godina izdavanja";
            // 
            // cb_Kategorija
            // 
            this.cb_Kategorija.FormattingEnabled = true;
            this.cb_Kategorija.Location = new System.Drawing.Point(9, 102);
            this.cb_Kategorija.Name = "cb_Kategorija";
            this.cb_Kategorija.Size = new System.Drawing.Size(181, 21);
            this.cb_Kategorija.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kategorija";
            // 
            // tb_Izdavac
            // 
            this.tb_Izdavac.Location = new System.Drawing.Point(9, 150);
            this.tb_Izdavac.Name = "tb_Izdavac";
            this.tb_Izdavac.Size = new System.Drawing.Size(181, 20);
            this.tb_Izdavac.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Izdavač";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(196, 102);
            this.tb_ISBN.MaxLength = 13;
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(181, 20);
            this.tb_ISBN.TabIndex = 4;
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            this.tb_ISBN.Leave += new System.EventHandler(this.tb_ISBN_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ISBN";
            // 
            // num_BrojStranica
            // 
            this.num_BrojStranica.Location = new System.Drawing.Point(9, 198);
            this.num_BrojStranica.Name = "num_BrojStranica";
            this.num_BrojStranica.Size = new System.Drawing.Size(181, 20);
            this.num_BrojStranica.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj stranica";
            // 
            // tb_NazivKnjige
            // 
            this.tb_NazivKnjige.Location = new System.Drawing.Point(196, 51);
            this.tb_NazivKnjige.Name = "tb_NazivKnjige";
            this.tb_NazivKnjige.Size = new System.Drawing.Size(181, 20);
            this.tb_NazivKnjige.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv knjige";
            // 
            // tb_Autor
            // 
            this.tb_Autor.Location = new System.Drawing.Point(9, 51);
            this.tb_Autor.Name = "tb_Autor";
            this.tb_Autor.Size = new System.Drawing.Size(181, 20);
            this.tb_Autor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            // 
            // lbl_idKnjige
            // 
            this.lbl_idKnjige.AutoSize = true;
            this.lbl_idKnjige.Location = new System.Drawing.Point(25, 237);
            this.lbl_idKnjige.Name = "lbl_idKnjige";
            this.lbl_idKnjige.Size = new System.Drawing.Size(0, 13);
            this.lbl_idKnjige.TabIndex = 17;
            this.lbl_idKnjige.Visible = false;
            // 
            // DodajUrediKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 352);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 390);
            this.MinimumSize = new System.Drawing.Size(426, 390);
            this.Name = "DodajUrediKnjigu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajUrediKnjigu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BrKopija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BrojStranica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_BrojStranica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NazivKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Autor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DodajUredi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Kategorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Izdavac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_BrKopija;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Godina;
        private System.Windows.Forms.Label lbl_idKnjige;
    }
}