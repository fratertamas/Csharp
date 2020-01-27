namespace VideoKolcsonzo
{
    partial class UjKolcsonzesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UjKolcsonzesForm));
            this.lbUjKolcsonzesAdatai = new System.Windows.Forms.Label();
            this.lbUgyfelNev = new System.Windows.Forms.Label();
            this.lbFilmCim = new System.Windows.Forms.Label();
            this.lbKolcsonzesiAr = new System.Windows.Forms.Label();
            this.lbKolcsonzesiIdo = new System.Windows.Forms.Label();
            this.lbKolcsonzesDatuma = new System.Windows.Forms.Label();
            this.cmbUgyfelNev = new System.Windows.Forms.ComboBox();
            this.cmbFilmCim = new System.Windows.Forms.ComboBox();
            this.txtKolcsonzesiDij = new System.Windows.Forms.TextBox();
            this.nudKolcsonzesiIdo = new System.Windows.Forms.NumericUpDown();
            this.dtpKolcsonzesDatuma = new System.Windows.Forms.DateTimePicker();
            this.btnUjKolcsonzesRogzitese = new System.Windows.Forms.Button();
            this.mtsMenusor = new System.Windows.Forms.MenuStrip();
            this.ugyfelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelHozzaadasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKolcsonzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolcsonzesiIdo)).BeginInit();
            this.mtsMenusor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUjKolcsonzesAdatai
            // 
            this.lbUjKolcsonzesAdatai.AutoSize = true;
            this.lbUjKolcsonzesAdatai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUjKolcsonzesAdatai.Location = new System.Drawing.Point(12, 37);
            this.lbUjKolcsonzesAdatai.Name = "lbUjKolcsonzesAdatai";
            this.lbUjKolcsonzesAdatai.Size = new System.Drawing.Size(184, 17);
            this.lbUjKolcsonzesAdatai.TabIndex = 0;
            this.lbUjKolcsonzesAdatai.Text = "Az új kölcsönzés adatai:";
            // 
            // lbUgyfelNev
            // 
            this.lbUgyfelNev.AutoSize = true;
            this.lbUgyfelNev.Location = new System.Drawing.Point(15, 74);
            this.lbUgyfelNev.Name = "lbUgyfelNev";
            this.lbUgyfelNev.Size = new System.Drawing.Size(67, 13);
            this.lbUgyfelNev.TabIndex = 1;
            this.lbUgyfelNev.Text = "Ügyfél neve:";
            // 
            // lbFilmCim
            // 
            this.lbFilmCim.AutoSize = true;
            this.lbFilmCim.Location = new System.Drawing.Point(15, 107);
            this.lbFilmCim.Name = "lbFilmCim";
            this.lbFilmCim.Size = new System.Drawing.Size(28, 13);
            this.lbFilmCim.TabIndex = 2;
            this.lbFilmCim.Text = "Film:";
            // 
            // lbKolcsonzesiAr
            // 
            this.lbKolcsonzesiAr.AutoSize = true;
            this.lbKolcsonzesiAr.Location = new System.Drawing.Point(15, 136);
            this.lbKolcsonzesiAr.Name = "lbKolcsonzesiAr";
            this.lbKolcsonzesiAr.Size = new System.Drawing.Size(81, 13);
            this.lbKolcsonzesiAr.TabIndex = 3;
            this.lbKolcsonzesiAr.Text = "Kölcsönzési díj:";
            // 
            // lbKolcsonzesiIdo
            // 
            this.lbKolcsonzesiIdo.AutoSize = true;
            this.lbKolcsonzesiIdo.Location = new System.Drawing.Point(15, 167);
            this.lbKolcsonzesiIdo.Name = "lbKolcsonzesiIdo";
            this.lbKolcsonzesiIdo.Size = new System.Drawing.Size(110, 13);
            this.lbKolcsonzesiIdo.TabIndex = 4;
            this.lbKolcsonzesiIdo.Text = "Kölcsönzési idő (nap):";
            // 
            // lbKolcsonzesDatuma
            // 
            this.lbKolcsonzesDatuma.AutoSize = true;
            this.lbKolcsonzesDatuma.Location = new System.Drawing.Point(15, 199);
            this.lbKolcsonzesDatuma.Name = "lbKolcsonzesDatuma";
            this.lbKolcsonzesDatuma.Size = new System.Drawing.Size(102, 13);
            this.lbKolcsonzesDatuma.TabIndex = 5;
            this.lbKolcsonzesDatuma.Text = "Kölcsönzés dátuma:";
            // 
            // cmbUgyfelNev
            // 
            this.cmbUgyfelNev.FormattingEnabled = true;
            this.cmbUgyfelNev.Location = new System.Drawing.Point(131, 71);
            this.cmbUgyfelNev.Name = "cmbUgyfelNev";
            this.cmbUgyfelNev.Size = new System.Drawing.Size(121, 21);
            this.cmbUgyfelNev.TabIndex = 6;
            // 
            // cmbFilmCim
            // 
            this.cmbFilmCim.FormattingEnabled = true;
            this.cmbFilmCim.Location = new System.Drawing.Point(130, 104);
            this.cmbFilmCim.Name = "cmbFilmCim";
            this.cmbFilmCim.Size = new System.Drawing.Size(121, 21);
            this.cmbFilmCim.TabIndex = 7;
            // 
            // txtKolcsonzesiDij
            // 
            this.txtKolcsonzesiDij.Location = new System.Drawing.Point(131, 133);
            this.txtKolcsonzesiDij.Name = "txtKolcsonzesiDij";
            this.txtKolcsonzesiDij.Size = new System.Drawing.Size(75, 20);
            this.txtKolcsonzesiDij.TabIndex = 8;
            this.txtKolcsonzesiDij.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // nudKolcsonzesiIdo
            // 
            this.nudKolcsonzesiIdo.Location = new System.Drawing.Point(130, 165);
            this.nudKolcsonzesiIdo.Name = "nudKolcsonzesiIdo";
            this.nudKolcsonzesiIdo.Size = new System.Drawing.Size(57, 20);
            this.nudKolcsonzesiIdo.TabIndex = 9;
            // 
            // dtpKolcsonzesDatuma
            // 
            this.dtpKolcsonzesDatuma.Location = new System.Drawing.Point(131, 199);
            this.dtpKolcsonzesDatuma.Name = "dtpKolcsonzesDatuma";
            this.dtpKolcsonzesDatuma.Size = new System.Drawing.Size(121, 20);
            this.dtpKolcsonzesDatuma.TabIndex = 10;
            // 
            // btnUjKolcsonzesRogzitese
            // 
            this.btnUjKolcsonzesRogzitese.BackColor = System.Drawing.Color.Green;
            this.btnUjKolcsonzesRogzitese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjKolcsonzesRogzitese.ForeColor = System.Drawing.Color.White;
            this.btnUjKolcsonzesRogzitese.Location = new System.Drawing.Point(41, 252);
            this.btnUjKolcsonzesRogzitese.Name = "btnUjKolcsonzesRogzitese";
            this.btnUjKolcsonzesRogzitese.Size = new System.Drawing.Size(188, 31);
            this.btnUjKolcsonzesRogzitese.TabIndex = 15;
            this.btnUjKolcsonzesRogzitese.Text = "Új kölcsönzés rögzítése";
            this.btnUjKolcsonzesRogzitese.UseVisualStyleBackColor = false;
            this.btnUjKolcsonzesRogzitese.Click += new System.EventHandler(this.btnUjKolcsonzesRogzitese_Click);
            // 
            // mtsMenusor
            // 
            this.mtsMenusor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfelekToolStripMenuItem,
            this.kolcsonzesekToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.mtsMenusor.Location = new System.Drawing.Point(0, 0);
            this.mtsMenusor.Name = "mtsMenusor";
            this.mtsMenusor.Size = new System.Drawing.Size(273, 24);
            this.mtsMenusor.TabIndex = 16;
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
            // 
            // kolcsonzesekKezeleseToolStripMenuItem
            // 
            this.kolcsonzesekKezeleseToolStripMenuItem.Image = global::VideoKolcsonzo.Properties.Resources.control_panel;
            this.kolcsonzesekKezeleseToolStripMenuItem.Name = "kolcsonzesekKezeleseToolStripMenuItem";
            this.kolcsonzesekKezeleseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kolcsonzesekKezeleseToolStripMenuItem.Text = "Kölcsönzések kezelése";
            this.kolcsonzesekKezeleseToolStripMenuItem.Click += new System.EventHandler(this.kolcsonzesekKezeleseToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // UjKolcsonzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 305);
            this.Controls.Add(this.mtsMenusor);
            this.Controls.Add(this.btnUjKolcsonzesRogzitese);
            this.Controls.Add(this.dtpKolcsonzesDatuma);
            this.Controls.Add(this.nudKolcsonzesiIdo);
            this.Controls.Add(this.txtKolcsonzesiDij);
            this.Controls.Add(this.cmbFilmCim);
            this.Controls.Add(this.cmbUgyfelNev);
            this.Controls.Add(this.lbKolcsonzesDatuma);
            this.Controls.Add(this.lbKolcsonzesiIdo);
            this.Controls.Add(this.lbKolcsonzesiAr);
            this.Controls.Add(this.lbFilmCim);
            this.Controls.Add(this.lbUgyfelNev);
            this.Controls.Add(this.lbUjKolcsonzesAdatai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 343);
            this.Name = "UjKolcsonzesForm";
            this.Text = "Kölcsönzés rögzítése";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ujKolcsonzesFormClosed);
            this.Load += new System.EventHandler(this.UjKolcsonzesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKolcsonzesiIdo)).EndInit();
            this.mtsMenusor.ResumeLayout(false);
            this.mtsMenusor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUjKolcsonzesAdatai;
        private System.Windows.Forms.Label lbUgyfelNev;
        private System.Windows.Forms.Label lbFilmCim;
        private System.Windows.Forms.Label lbKolcsonzesiAr;
        private System.Windows.Forms.Label lbKolcsonzesiIdo;
        private System.Windows.Forms.Label lbKolcsonzesDatuma;
        private System.Windows.Forms.ComboBox cmbUgyfelNev;
        private System.Windows.Forms.ComboBox cmbFilmCim;
        private System.Windows.Forms.TextBox txtKolcsonzesiDij;
        private System.Windows.Forms.NumericUpDown nudKolcsonzesiIdo;
        private System.Windows.Forms.DateTimePicker dtpKolcsonzesDatuma;
        private System.Windows.Forms.Button btnUjKolcsonzesRogzitese;
        private System.Windows.Forms.MenuStrip mtsMenusor;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelHozzaadasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujKolcsonzesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
    }
}