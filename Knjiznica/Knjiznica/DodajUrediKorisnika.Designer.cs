namespace Knjiznica
{
    partial class DodajUrediKorisnika
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
            this.tb_Prezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Ime = new System.Windows.Forms.TextBox();
            this.tb_MjestoStan = new System.Windows.Forms.TextBox();
            this.tb_Adresa = new System.Windows.Forms.TextBox();
            this.dtp_DatRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btn_SpremiKorisnika = new System.Windows.Forms.Button();
            this.rb_Muski = new System.Windows.Forms.RadioButton();
            this.rb_Zenski = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Prezime
            // 
            this.tb_Prezime.Location = new System.Drawing.Point(110, 54);
            this.tb_Prezime.Name = "tb_Prezime";
            this.tb_Prezime.Size = new System.Drawing.Size(181, 20);
            this.tb_Prezime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mjesto stanovanja";
            // 
            // tb_Ime
            // 
            this.tb_Ime.Location = new System.Drawing.Point(110, 21);
            this.tb_Ime.Name = "tb_Ime";
            this.tb_Ime.Size = new System.Drawing.Size(181, 20);
            this.tb_Ime.TabIndex = 6;
            // 
            // tb_MjestoStan
            // 
            this.tb_MjestoStan.Location = new System.Drawing.Point(110, 193);
            this.tb_MjestoStan.Name = "tb_MjestoStan";
            this.tb_MjestoStan.Size = new System.Drawing.Size(181, 20);
            this.tb_MjestoStan.TabIndex = 9;
            // 
            // tb_Adresa
            // 
            this.tb_Adresa.Location = new System.Drawing.Point(110, 157);
            this.tb_Adresa.Name = "tb_Adresa";
            this.tb_Adresa.Size = new System.Drawing.Size(181, 20);
            this.tb_Adresa.TabIndex = 8;
            // 
            // dtp_DatRodjenja
            // 
            this.dtp_DatRodjenja.Location = new System.Drawing.Point(110, 121);
            this.dtp_DatRodjenja.Name = "dtp_DatRodjenja";
            this.dtp_DatRodjenja.Size = new System.Drawing.Size(181, 20);
            this.dtp_DatRodjenja.TabIndex = 11;
            // 
            // btn_SpremiKorisnika
            // 
            this.btn_SpremiKorisnika.Location = new System.Drawing.Point(6, 243);
            this.btn_SpremiKorisnika.Name = "btn_SpremiKorisnika";
            this.btn_SpremiKorisnika.Size = new System.Drawing.Size(93, 30);
            this.btn_SpremiKorisnika.TabIndex = 1;
            this.btn_SpremiKorisnika.Text = "Spremi";
            this.btn_SpremiKorisnika.UseVisualStyleBackColor = true;
            this.btn_SpremiKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_Muski
            // 
            this.rb_Muski.AutoSize = true;
            this.rb_Muski.Location = new System.Drawing.Point(173, 89);
            this.rb_Muski.Name = "rb_Muski";
            this.rb_Muski.Size = new System.Drawing.Size(53, 17);
            this.rb_Muski.TabIndex = 1;
            this.rb_Muski.TabStop = true;
            this.rb_Muski.Text = "Muški";
            this.rb_Muski.UseVisualStyleBackColor = true;
            // 
            // rb_Zenski
            // 
            this.rb_Zenski.AutoSize = true;
            this.rb_Zenski.Location = new System.Drawing.Point(110, 89);
            this.rb_Zenski.Name = "rb_Zenski";
            this.rb_Zenski.Size = new System.Drawing.Size(57, 17);
            this.rb_Zenski.TabIndex = 0;
            this.rb_Zenski.TabStop = true;
            this.rb_Zenski.Text = "Ženski";
            this.rb_Zenski.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_SpremiKorisnika);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_Ime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_MjestoStan);
            this.groupBox1.Controls.Add(this.dtp_DatRodjenja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_Zenski);
            this.groupBox1.Controls.Add(this.tb_Prezime);
            this.groupBox1.Controls.Add(this.rb_Muski);
            this.groupBox1.Controls.Add(this.tb_Adresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 286);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o korisniku";
            // 
            // DodajUrediKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 309);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 348);
            this.MinimumSize = new System.Drawing.Size(342, 348);
            this.Name = "DodajUrediKorisnika";
            this.Text = "DodajUrediKorisnika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Prezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Ime;
        private System.Windows.Forms.TextBox tb_MjestoStan;
        private System.Windows.Forms.TextBox tb_Adresa;
        private System.Windows.Forms.DateTimePicker dtp_DatRodjenja;
        private System.Windows.Forms.Button btn_SpremiKorisnika;
        private System.Windows.Forms.RadioButton rb_Muski;
        private System.Windows.Forms.RadioButton rb_Zenski;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}