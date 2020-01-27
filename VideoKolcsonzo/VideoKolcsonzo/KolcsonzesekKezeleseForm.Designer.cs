namespace VideoKolcsonzo
{
    partial class KolcsonzesekKezeleseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KolcsonzesekKezeleseForm));
            this.dgvKolcsonzesek = new System.Windows.Forms.DataGridView();
            this.lbKolcsonzesID = new System.Windows.Forms.Label();
            this.lbUgyfelNev = new System.Windows.Forms.Label();
            this.lbFilm = new System.Windows.Forms.Label();
            this.lbKolcsonzesiDij = new System.Windows.Forms.Label();
            this.lbKolcsonzesiIdo = new System.Windows.Forms.Label();
            this.lbKolcsonzesDatum = new System.Windows.Forms.Label();
            this.cmbUgyfelNevek = new System.Windows.Forms.ComboBox();
            this.cmbFilmek = new System.Windows.Forms.ComboBox();
            this.txtKolcsonzesiDij = new System.Windows.Forms.TextBox();
            this.nudKolcsonzesiIdo = new System.Windows.Forms.NumericUpDown();
            this.dtpKolcsonzesiDatum = new System.Windows.Forms.DateTimePicker();
            this.grbKolcsonzesAdatai = new System.Windows.Forms.GroupBox();
            this.grbMuveletek = new System.Windows.Forms.GroupBox();
            this.btnKolcsonzesTorlese = new System.Windows.Forms.Button();
            this.btnAdatokModositasa = new System.Windows.Forms.Button();
            this.btnMezokUresseTetele = new System.Windows.Forms.Button();
            this.mtsMenusor = new System.Windows.Forms.MenuStrip();
            this.ugyfelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelHozzaadasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKolcsonzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtKolcsonzesId = new System.Windows.Forms.TextBox();
            this.btnKeres = new System.Windows.Forms.Button();
            this.grbKolcsonzesKereses = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzesek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolcsonzesiIdo)).BeginInit();
            this.grbKolcsonzesAdatai.SuspendLayout();
            this.grbMuveletek.SuspendLayout();
            this.mtsMenusor.SuspendLayout();
            this.grbKolcsonzesKereses.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKolcsonzesek
            // 
            this.dgvKolcsonzesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKolcsonzesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKolcsonzesek.Location = new System.Drawing.Point(12, 154);
            this.dgvKolcsonzesek.Name = "dgvKolcsonzesek";
            this.dgvKolcsonzesek.Size = new System.Drawing.Size(511, 150);
            this.dgvKolcsonzesek.TabIndex = 0;
            this.dgvKolcsonzesek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKolcsonzesek_CellClick);
            // 
            // lbKolcsonzesID
            // 
            this.lbKolcsonzesID.AutoSize = true;
            this.lbKolcsonzesID.Location = new System.Drawing.Point(16, 260);
            this.lbKolcsonzesID.Name = "lbKolcsonzesID";
            this.lbKolcsonzesID.Size = new System.Drawing.Size(0, 13);
            this.lbKolcsonzesID.TabIndex = 1;
            // 
            // lbUgyfelNev
            // 
            this.lbUgyfelNev.AutoSize = true;
            this.lbUgyfelNev.Location = new System.Drawing.Point(3, 30);
            this.lbUgyfelNev.Name = "lbUgyfelNev";
            this.lbUgyfelNev.Size = new System.Drawing.Size(67, 13);
            this.lbUgyfelNev.TabIndex = 2;
            this.lbUgyfelNev.Text = "Ügyfél neve:";
            // 
            // lbFilm
            // 
            this.lbFilm.AutoSize = true;
            this.lbFilm.Location = new System.Drawing.Point(3, 56);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(28, 13);
            this.lbFilm.TabIndex = 3;
            this.lbFilm.Text = "Film:";
            // 
            // lbKolcsonzesiDij
            // 
            this.lbKolcsonzesiDij.AutoSize = true;
            this.lbKolcsonzesiDij.Location = new System.Drawing.Point(3, 82);
            this.lbKolcsonzesiDij.Name = "lbKolcsonzesiDij";
            this.lbKolcsonzesiDij.Size = new System.Drawing.Size(81, 13);
            this.lbKolcsonzesiDij.TabIndex = 4;
            this.lbKolcsonzesiDij.Text = "Kölcsönzési díj:";
            // 
            // lbKolcsonzesiIdo
            // 
            this.lbKolcsonzesiIdo.AutoSize = true;
            this.lbKolcsonzesiIdo.Location = new System.Drawing.Point(3, 109);
            this.lbKolcsonzesiIdo.Name = "lbKolcsonzesiIdo";
            this.lbKolcsonzesiIdo.Size = new System.Drawing.Size(110, 13);
            this.lbKolcsonzesiIdo.TabIndex = 5;
            this.lbKolcsonzesiIdo.Text = "Kölcsönzési idő (nap):";
            // 
            // lbKolcsonzesDatum
            // 
            this.lbKolcsonzesDatum.AutoSize = true;
            this.lbKolcsonzesDatum.Location = new System.Drawing.Point(3, 141);
            this.lbKolcsonzesDatum.Name = "lbKolcsonzesDatum";
            this.lbKolcsonzesDatum.Size = new System.Drawing.Size(102, 13);
            this.lbKolcsonzesDatum.TabIndex = 6;
            this.lbKolcsonzesDatum.Text = "Kölcsönzés dátuma:";
            // 
            // cmbUgyfelNevek
            // 
            this.cmbUgyfelNevek.FormattingEnabled = true;
            this.cmbUgyfelNevek.Location = new System.Drawing.Point(119, 27);
            this.cmbUgyfelNevek.Name = "cmbUgyfelNevek";
            this.cmbUgyfelNevek.Size = new System.Drawing.Size(121, 21);
            this.cmbUgyfelNevek.TabIndex = 7;
            // 
            // cmbFilmek
            // 
            this.cmbFilmek.FormattingEnabled = true;
            this.cmbFilmek.Location = new System.Drawing.Point(118, 52);
            this.cmbFilmek.Name = "cmbFilmek";
            this.cmbFilmek.Size = new System.Drawing.Size(121, 21);
            this.cmbFilmek.TabIndex = 8;
            // 
            // txtKolcsonzesiDij
            // 
            this.txtKolcsonzesiDij.Location = new System.Drawing.Point(119, 79);
            this.txtKolcsonzesiDij.Name = "txtKolcsonzesiDij";
            this.txtKolcsonzesiDij.Size = new System.Drawing.Size(59, 20);
            this.txtKolcsonzesiDij.TabIndex = 9;
            this.txtKolcsonzesiDij.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // nudKolcsonzesiIdo
            // 
            this.nudKolcsonzesiIdo.Location = new System.Drawing.Point(119, 107);
            this.nudKolcsonzesiIdo.Name = "nudKolcsonzesiIdo";
            this.nudKolcsonzesiIdo.Size = new System.Drawing.Size(59, 20);
            this.nudKolcsonzesiIdo.TabIndex = 10;
            // 
            // dtpKolcsonzesiDatum
            // 
            this.dtpKolcsonzesiDatum.Location = new System.Drawing.Point(119, 135);
            this.dtpKolcsonzesiDatum.Name = "dtpKolcsonzesiDatum";
            this.dtpKolcsonzesiDatum.Size = new System.Drawing.Size(139, 20);
            this.dtpKolcsonzesiDatum.TabIndex = 11;
            // 
            // grbKolcsonzesAdatai
            // 
            this.grbKolcsonzesAdatai.Controls.Add(this.dtpKolcsonzesiDatum);
            this.grbKolcsonzesAdatai.Controls.Add(this.lbUgyfelNev);
            this.grbKolcsonzesAdatai.Controls.Add(this.nudKolcsonzesiIdo);
            this.grbKolcsonzesAdatai.Controls.Add(this.lbFilm);
            this.grbKolcsonzesAdatai.Controls.Add(this.txtKolcsonzesiDij);
            this.grbKolcsonzesAdatai.Controls.Add(this.lbKolcsonzesiDij);
            this.grbKolcsonzesAdatai.Controls.Add(this.cmbFilmek);
            this.grbKolcsonzesAdatai.Controls.Add(this.lbKolcsonzesiIdo);
            this.grbKolcsonzesAdatai.Controls.Add(this.cmbUgyfelNevek);
            this.grbKolcsonzesAdatai.Controls.Add(this.lbKolcsonzesDatum);
            this.grbKolcsonzesAdatai.Location = new System.Drawing.Point(12, 324);
            this.grbKolcsonzesAdatai.Name = "grbKolcsonzesAdatai";
            this.grbKolcsonzesAdatai.Size = new System.Drawing.Size(268, 172);
            this.grbKolcsonzesAdatai.TabIndex = 12;
            this.grbKolcsonzesAdatai.TabStop = false;
            this.grbKolcsonzesAdatai.Text = "Kölcsönzés adatai:";
            // 
            // grbMuveletek
            // 
            this.grbMuveletek.Controls.Add(this.btnKolcsonzesTorlese);
            this.grbMuveletek.Controls.Add(this.btnAdatokModositasa);
            this.grbMuveletek.Controls.Add(this.btnMezokUresseTetele);
            this.grbMuveletek.Location = new System.Drawing.Point(323, 324);
            this.grbMuveletek.Name = "grbMuveletek";
            this.grbMuveletek.Size = new System.Drawing.Size(200, 172);
            this.grbMuveletek.TabIndex = 13;
            this.grbMuveletek.TabStop = false;
            this.grbMuveletek.Text = "Műveletek:";
            // 
            // btnKolcsonzesTorlese
            // 
            this.btnKolcsonzesTorlese.Location = new System.Drawing.Point(29, 131);
            this.btnKolcsonzesTorlese.Name = "btnKolcsonzesTorlese";
            this.btnKolcsonzesTorlese.Size = new System.Drawing.Size(135, 23);
            this.btnKolcsonzesTorlese.TabIndex = 2;
            this.btnKolcsonzesTorlese.Text = "Kölcsönzés törlése";
            this.btnKolcsonzesTorlese.UseVisualStyleBackColor = true;
            this.btnKolcsonzesTorlese.Click += new System.EventHandler(this.btnKolcsonzesTorlese_Click);
            // 
            // btnAdatokModositasa
            // 
            this.btnAdatokModositasa.Location = new System.Drawing.Point(29, 77);
            this.btnAdatokModositasa.Name = "btnAdatokModositasa";
            this.btnAdatokModositasa.Size = new System.Drawing.Size(135, 23);
            this.btnAdatokModositasa.TabIndex = 1;
            this.btnAdatokModositasa.Text = "Adatok módosítása";
            this.btnAdatokModositasa.UseVisualStyleBackColor = true;
            this.btnAdatokModositasa.Click += new System.EventHandler(this.btnAdatokModositasa_Click);
            // 
            // btnMezokUresseTetele
            // 
            this.btnMezokUresseTetele.Location = new System.Drawing.Point(29, 24);
            this.btnMezokUresseTetele.Name = "btnMezokUresseTetele";
            this.btnMezokUresseTetele.Size = new System.Drawing.Size(135, 23);
            this.btnMezokUresseTetele.TabIndex = 0;
            this.btnMezokUresseTetele.Text = "Mezők üressé tétele";
            this.btnMezokUresseTetele.UseVisualStyleBackColor = true;
            this.btnMezokUresseTetele.Click += new System.EventHandler(this.btnMezokUresseTetele_Click);
            // 
            // mtsMenusor
            // 
            this.mtsMenusor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfelekToolStripMenuItem,
            this.kolcsonzesekToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.mtsMenusor.Location = new System.Drawing.Point(0, 0);
            this.mtsMenusor.Name = "mtsMenusor";
            this.mtsMenusor.Size = new System.Drawing.Size(542, 24);
            this.mtsMenusor.TabIndex = 17;
            this.mtsMenusor.Text = "menuStrip1";
            // 
            // ugyfelekToolStripMenuItem
            // 
            this.ugyfelekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujUgyfelHozzaadasaToolStripMenuItem,
            this.ugyfelekKezeleseToolStripMenuItem});
            this.ugyfelekToolStripMenuItem.Name = "ugyfelekToolStripMenuItem";
            this.ugyfelekToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ugyfelekToolStripMenuItem.Text = "Ügyfelek";
            // 
            // ujUgyfelHozzaadasaToolStripMenuItem
            // 
            this.ujUgyfelHozzaadasaToolStripMenuItem.Image = global::VideoKolcsonzo.Properties.Resources.netvibes;
            this.ujUgyfelHozzaadasaToolStripMenuItem.Name = "ujUgyfelHozzaadasaToolStripMenuItem";
            this.ujUgyfelHozzaadasaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ujUgyfelHozzaadasaToolStripMenuItem.Text = "Új ügyfél hozzáadása";
            this.ujUgyfelHozzaadasaToolStripMenuItem.Click += new System.EventHandler(this.ujUgyfelHozzaadasaToolStripMenuItem_Click);
            // 
            // ugyfelekKezeleseToolStripMenuItem
            // 
            this.ugyfelekKezeleseToolStripMenuItem.Image = global::VideoKolcsonzo.Properties.Resources.control_panel;
            this.ugyfelekKezeleseToolStripMenuItem.Name = "ugyfelekKezeleseToolStripMenuItem";
            this.ugyfelekKezeleseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ugyfelekKezeleseToolStripMenuItem.Text = "Ügyfelek kezelése";
            this.ugyfelekKezeleseToolStripMenuItem.Click += new System.EventHandler(this.ugyfelekKezeleseToolStripMenuItem_Click);
            // 
            // kolcsonzesekToolStripMenuItem
            // 
            this.kolcsonzesekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujKolcsonzesToolStripMenuItem,
            this.kolcsonzesekKezeleseToolStripMenuItem});
            this.kolcsonzesekToolStripMenuItem.Name = "kolcsonzesekToolStripMenuItem";
            this.kolcsonzesekToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.kolcsonzesekToolStripMenuItem.Text = "Kölcsönzések";
            // 
            // ujKolcsonzesToolStripMenuItem
            // 
            this.ujKolcsonzesToolStripMenuItem.Image = global::VideoKolcsonzo.Properties.Resources.netvibes;
            this.ujKolcsonzesToolStripMenuItem.Name = "ujKolcsonzesToolStripMenuItem";
            this.ujKolcsonzesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ujKolcsonzesToolStripMenuItem.Text = "Új kölcsönzés";
            this.ujKolcsonzesToolStripMenuItem.Click += new System.EventHandler(this.ujKolcsonzesToolStripMenuItem_Click);
            // 
            // kolcsonzesekKezeleseToolStripMenuItem
            // 
            this.kolcsonzesekKezeleseToolStripMenuItem.Image = global::VideoKolcsonzo.Properties.Resources.control_panel;
            this.kolcsonzesekKezeleseToolStripMenuItem.Name = "kolcsonzesekKezeleseToolStripMenuItem";
            this.kolcsonzesekKezeleseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kolcsonzesekKezeleseToolStripMenuItem.Text = "Kölcsönzések kezelése";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // txtKolcsonzesId
            // 
            this.txtKolcsonzesId.Location = new System.Drawing.Point(6, 19);
            this.txtKolcsonzesId.Name = "txtKolcsonzesId";
            this.txtKolcsonzesId.Size = new System.Drawing.Size(100, 20);
            this.txtKolcsonzesId.TabIndex = 19;
            this.txtKolcsonzesId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(132, 16);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 20;
            this.btnKeres.Text = "Keres";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // grbKolcsonzesKereses
            // 
            this.grbKolcsonzesKereses.Controls.Add(this.btnKeres);
            this.grbKolcsonzesKereses.Controls.Add(this.txtKolcsonzesId);
            this.grbKolcsonzesKereses.Location = new System.Drawing.Point(12, 34);
            this.grbKolcsonzesKereses.Name = "grbKolcsonzesKereses";
            this.grbKolcsonzesKereses.Size = new System.Drawing.Size(227, 46);
            this.grbKolcsonzesKereses.TabIndex = 21;
            this.grbKolcsonzesKereses.TabStop = false;
            this.grbKolcsonzesKereses.Text = "Kölcsönzés keresése azonosító alapján:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 62);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Azonosító";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ügyfél Neve";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Film";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ár";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kölcsönzési napok";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kölcsönzés dátum";
            // 
            // KolcsonzesekKezeleseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 519);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grbKolcsonzesKereses);
            this.Controls.Add(this.mtsMenusor);
            this.Controls.Add(this.grbMuveletek);
            this.Controls.Add(this.grbKolcsonzesAdatai);
            this.Controls.Add(this.lbKolcsonzesID);
            this.Controls.Add(this.dgvKolcsonzesek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(558, 557);
            this.Name = "KolcsonzesekKezeleseForm";
            this.Text = "Kölcsönzések kezelése";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KolcsonzesekKezeleseClosed);
            this.Load += new System.EventHandler(this.KolcsonzesekKezeleseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzesek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolcsonzesiIdo)).EndInit();
            this.grbKolcsonzesAdatai.ResumeLayout(false);
            this.grbKolcsonzesAdatai.PerformLayout();
            this.grbMuveletek.ResumeLayout(false);
            this.mtsMenusor.ResumeLayout(false);
            this.mtsMenusor.PerformLayout();
            this.grbKolcsonzesKereses.ResumeLayout(false);
            this.grbKolcsonzesKereses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKolcsonzesek;
        private System.Windows.Forms.Label lbKolcsonzesID;
        private System.Windows.Forms.Label lbUgyfelNev;
        private System.Windows.Forms.Label lbFilm;
        private System.Windows.Forms.Label lbKolcsonzesiDij;
        private System.Windows.Forms.Label lbKolcsonzesiIdo;
        private System.Windows.Forms.Label lbKolcsonzesDatum;
        private System.Windows.Forms.ComboBox cmbUgyfelNevek;
        private System.Windows.Forms.ComboBox cmbFilmek;
        private System.Windows.Forms.TextBox txtKolcsonzesiDij;
        private System.Windows.Forms.NumericUpDown nudKolcsonzesiIdo;
        private System.Windows.Forms.DateTimePicker dtpKolcsonzesiDatum;
        private System.Windows.Forms.GroupBox grbKolcsonzesAdatai;
        private System.Windows.Forms.GroupBox grbMuveletek;
        private System.Windows.Forms.Button btnKolcsonzesTorlese;
        private System.Windows.Forms.Button btnAdatokModositasa;
        private System.Windows.Forms.Button btnMezokUresseTetele;
        private System.Windows.Forms.MenuStrip mtsMenusor;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelHozzaadasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujKolcsonzesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtKolcsonzesId;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.GroupBox grbKolcsonzesKereses;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}