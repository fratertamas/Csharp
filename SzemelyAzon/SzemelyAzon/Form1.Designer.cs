namespace SzemelyAzon
{
    partial class Form1
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
            this.lbNev = new System.Windows.Forms.Label();
            this.lbNem = new System.Windows.Forms.Label();
            this.lbSzDatum = new System.Windows.Forms.Label();
            this.grbLakcim = new System.Windows.Forms.GroupBox();
            this.lbIrszSzam = new System.Windows.Forms.Label();
            this.lbTelepules = new System.Windows.Forms.Label();
            this.lbKoztAdatai = new System.Windows.Forms.Label();
            this.lbAllampolgarsag = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtIrsz = new System.Windows.Forms.TextBox();
            this.txtTelepules = new System.Windows.Forms.TextBox();
            this.txtKoztAdatai = new System.Windows.Forms.TextBox();
            this.dtpSzulDatum = new System.Windows.Forms.DateTimePicker();
            this.chbMagyarE = new System.Windows.Forms.CheckBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbFerfi = new System.Windows.Forms.RadioButton();
            this.btnSzemelyiAzonositoGeneralas = new System.Windows.Forms.Button();
            this.txtSzAzonosito = new System.Windows.Forms.TextBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.grbLakcim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNev
            // 
            this.lbNev.AutoSize = true;
            this.lbNev.Location = new System.Drawing.Point(32, 29);
            this.lbNev.Name = "lbNev";
            this.lbNev.Size = new System.Drawing.Size(27, 13);
            this.lbNev.TabIndex = 0;
            this.lbNev.Text = "Név";
            // 
            // lbNem
            // 
            this.lbNem.AutoSize = true;
            this.lbNem.Location = new System.Drawing.Point(32, 59);
            this.lbNem.Name = "lbNem";
            this.lbNem.Size = new System.Drawing.Size(29, 13);
            this.lbNem.TabIndex = 1;
            this.lbNem.Text = "Nem";
            // 
            // lbSzDatum
            // 
            this.lbSzDatum.AutoSize = true;
            this.lbSzDatum.Location = new System.Drawing.Point(32, 84);
            this.lbSzDatum.Name = "lbSzDatum";
            this.lbSzDatum.Size = new System.Drawing.Size(81, 13);
            this.lbSzDatum.TabIndex = 2;
            this.lbSzDatum.Text = "Születési dátum";
            // 
            // grbLakcim
            // 
            this.grbLakcim.Controls.Add(this.txtKoztAdatai);
            this.grbLakcim.Controls.Add(this.txtTelepules);
            this.grbLakcim.Controls.Add(this.txtIrsz);
            this.grbLakcim.Controls.Add(this.lbKoztAdatai);
            this.grbLakcim.Controls.Add(this.lbTelepules);
            this.grbLakcim.Controls.Add(this.lbIrszSzam);
            this.grbLakcim.Location = new System.Drawing.Point(32, 143);
            this.grbLakcim.Name = "grbLakcim";
            this.grbLakcim.Size = new System.Drawing.Size(237, 152);
            this.grbLakcim.TabIndex = 3;
            this.grbLakcim.TabStop = false;
            this.grbLakcim.Text = "Lakcím";
            // 
            // lbIrszSzam
            // 
            this.lbIrszSzam.AutoSize = true;
            this.lbIrszSzam.Location = new System.Drawing.Point(7, 39);
            this.lbIrszSzam.Name = "lbIrszSzam";
            this.lbIrszSzam.Size = new System.Drawing.Size(67, 13);
            this.lbIrszSzam.TabIndex = 0;
            this.lbIrszSzam.Text = "Irányítószám";
            // 
            // lbTelepules
            // 
            this.lbTelepules.AutoSize = true;
            this.lbTelepules.Location = new System.Drawing.Point(10, 66);
            this.lbTelepules.Name = "lbTelepules";
            this.lbTelepules.Size = new System.Drawing.Size(53, 13);
            this.lbTelepules.TabIndex = 1;
            this.lbTelepules.Text = "Település";
            // 
            // lbKoztAdatai
            // 
            this.lbKoztAdatai.AutoSize = true;
            this.lbKoztAdatai.Location = new System.Drawing.Point(10, 94);
            this.lbKoztAdatai.Name = "lbKoztAdatai";
            this.lbKoztAdatai.Size = new System.Drawing.Size(86, 13);
            this.lbKoztAdatai.TabIndex = 2;
            this.lbKoztAdatai.Text = "Közterület adatai";
            // 
            // lbAllampolgarsag
            // 
            this.lbAllampolgarsag.AutoSize = true;
            this.lbAllampolgarsag.Location = new System.Drawing.Point(32, 110);
            this.lbAllampolgarsag.Name = "lbAllampolgarsag";
            this.lbAllampolgarsag.Size = new System.Drawing.Size(78, 13);
            this.lbAllampolgarsag.TabIndex = 4;
            this.lbAllampolgarsag.Text = "Állampolgárság";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(130, 26);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 5;
            this.txtNev.TextChanged += new System.EventHandler(this.txtNev_TextChanged);
            this.txtNev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNev_KeyPress);
            // 
            // txtIrsz
            // 
            this.txtIrsz.Location = new System.Drawing.Point(98, 32);
            this.txtIrsz.Name = "txtIrsz";
            this.txtIrsz.Size = new System.Drawing.Size(100, 20);
            this.txtIrsz.TabIndex = 3;
            // 
            // txtTelepules
            // 
            this.txtTelepules.Location = new System.Drawing.Point(98, 66);
            this.txtTelepules.Name = "txtTelepules";
            this.txtTelepules.Size = new System.Drawing.Size(100, 20);
            this.txtTelepules.TabIndex = 4;
            // 
            // txtKoztAdatai
            // 
            this.txtKoztAdatai.Location = new System.Drawing.Point(98, 94);
            this.txtKoztAdatai.Name = "txtKoztAdatai";
            this.txtKoztAdatai.Size = new System.Drawing.Size(100, 20);
            this.txtKoztAdatai.TabIndex = 5;
            // 
            // dtpSzulDatum
            // 
            this.dtpSzulDatum.Location = new System.Drawing.Point(119, 84);
            this.dtpSzulDatum.Name = "dtpSzulDatum";
            this.dtpSzulDatum.Size = new System.Drawing.Size(142, 20);
            this.dtpSzulDatum.TabIndex = 7;
            // 
            // chbMagyarE
            // 
            this.chbMagyarE.AutoSize = true;
            this.chbMagyarE.Location = new System.Drawing.Point(119, 110);
            this.chbMagyarE.Name = "chbMagyarE";
            this.chbMagyarE.Size = new System.Drawing.Size(61, 17);
            this.chbMagyarE.TabIndex = 8;
            this.chbMagyarE.Text = "Magyar";
            this.chbMagyarE.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Checked = true;
            this.rdbNo.Location = new System.Drawing.Point(130, 57);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 9;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "Nő";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbFerfi
            // 
            this.rdbFerfi.AutoSize = true;
            this.rdbFerfi.Location = new System.Drawing.Point(185, 55);
            this.rdbFerfi.Name = "rdbFerfi";
            this.rdbFerfi.Size = new System.Drawing.Size(45, 17);
            this.rdbFerfi.TabIndex = 10;
            this.rdbFerfi.Text = "Férfi";
            this.rdbFerfi.UseVisualStyleBackColor = true;
            // 
            // btnSzemelyiAzonositoGeneralas
            // 
            this.btnSzemelyiAzonositoGeneralas.Location = new System.Drawing.Point(32, 263);
            this.btnSzemelyiAzonositoGeneralas.Name = "btnSzemelyiAzonositoGeneralas";
            this.btnSzemelyiAzonositoGeneralas.Size = new System.Drawing.Size(237, 51);
            this.btnSzemelyiAzonositoGeneralas.TabIndex = 11;
            this.btnSzemelyiAzonositoGeneralas.Text = "Szemelyi Azonosító Generálás";
            this.btnSzemelyiAzonositoGeneralas.UseVisualStyleBackColor = true;
            this.btnSzemelyiAzonositoGeneralas.Click += new System.EventHandler(this.btnSzemelyiAzonositoGeneralas_Click);
            // 
            // txtSzAzonosito
            // 
            this.txtSzAzonosito.Location = new System.Drawing.Point(32, 331);
            this.txtSzAzonosito.Name = "txtSzAzonosito";
            this.txtSzAzonosito.Size = new System.Drawing.Size(237, 20);
            this.txtSzAzonosito.TabIndex = 12;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(60, 366);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(162, 23);
            this.btnMentes.TabIndex = 13;
            this.btnMentes.Text = "Adatok Mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.txtSzAzonosito);
            this.Controls.Add(this.btnSzemelyiAzonositoGeneralas);
            this.Controls.Add(this.rdbFerfi);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.chbMagyarE);
            this.Controls.Add(this.dtpSzulDatum);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.lbAllampolgarsag);
            this.Controls.Add(this.grbLakcim);
            this.Controls.Add(this.lbSzDatum);
            this.Controls.Add(this.lbNem);
            this.Controls.Add(this.lbNev);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Személyi Azonosító Generátor";
            this.grbLakcim.ResumeLayout(false);
            this.grbLakcim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNev;
        private System.Windows.Forms.Label lbNem;
        private System.Windows.Forms.Label lbSzDatum;
        private System.Windows.Forms.GroupBox grbLakcim;
        private System.Windows.Forms.TextBox txtKoztAdatai;
        private System.Windows.Forms.TextBox txtTelepules;
        private System.Windows.Forms.TextBox txtIrsz;
        private System.Windows.Forms.Label lbKoztAdatai;
        private System.Windows.Forms.Label lbTelepules;
        private System.Windows.Forms.Label lbIrszSzam;
        private System.Windows.Forms.Label lbAllampolgarsag;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.DateTimePicker dtpSzulDatum;
        private System.Windows.Forms.CheckBox chbMagyarE;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbFerfi;
        private System.Windows.Forms.Button btnSzemelyiAzonositoGeneralas;
        private System.Windows.Forms.TextBox txtSzAzonosito;
        private System.Windows.Forms.Button btnMentes;
    }
}

