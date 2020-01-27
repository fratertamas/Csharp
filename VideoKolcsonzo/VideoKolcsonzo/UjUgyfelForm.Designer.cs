namespace VideoKolcsonzo
{
    partial class UjUgyfelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UjUgyfelForm));
            this.mtsMenusor = new System.Windows.Forms.MenuStrip();
            this.ugyfelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelHozzaadasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKolcsonzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUjUgyfelNev = new System.Windows.Forms.Label();
            this.lbUjUgyfelIranyitoszam = new System.Windows.Forms.Label();
            this.lbUjUgyfelVaros = new System.Windows.Forms.Label();
            this.lbUjUgyfelUtca = new System.Windows.Forms.Label();
            this.lbUjUgyfelHazszam = new System.Windows.Forms.Label();
            this.lbUjUgyfelTelefonszam = new System.Windows.Forms.Label();
            this.txtUjUgyfelNev = new System.Windows.Forms.TextBox();
            this.txtUjUgyfelIranyitoszam = new System.Windows.Forms.TextBox();
            this.txtUjUgyfelVaros = new System.Windows.Forms.TextBox();
            this.txtUjUgyfelUtca = new System.Windows.Forms.TextBox();
            this.txtUjUgyfelHazszam = new System.Windows.Forms.TextBox();
            this.txtUjUgyfelTelefonszam = new System.Windows.Forms.TextBox();
            this.btnUjUgyfelRogzitese = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grbUjUgyfelCimAdatok = new System.Windows.Forms.GroupBox();
            this.grbUjUgyfelSzemelyesAdatok = new System.Windows.Forms.GroupBox();
            this.mtsMenusor.SuspendLayout();
            this.grbUjUgyfelCimAdatok.SuspendLayout();
            this.grbUjUgyfelSzemelyesAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtsMenusor
            // 
            this.mtsMenusor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfelekToolStripMenuItem,
            this.kolcsonzesekToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.mtsMenusor.Location = new System.Drawing.Point(0, 0);
            this.mtsMenusor.Name = "mtsMenusor";
            this.mtsMenusor.Size = new System.Drawing.Size(267, 24);
            this.mtsMenusor.TabIndex = 1;
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
            this.kolcsonzesekKezeleseToolStripMenuItem.Click += new System.EventHandler(this.kolcsonzesekKezeleseToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // lbUjUgyfelNev
            // 
            this.lbUjUgyfelNev.AutoSize = true;
            this.lbUjUgyfelNev.Location = new System.Drawing.Point(17, 30);
            this.lbUjUgyfelNev.Name = "lbUjUgyfelNev";
            this.lbUjUgyfelNev.Size = new System.Drawing.Size(30, 13);
            this.lbUjUgyfelNev.TabIndex = 2;
            this.lbUjUgyfelNev.Text = "Név:";
            // 
            // lbUjUgyfelIranyitoszam
            // 
            this.lbUjUgyfelIranyitoszam.AutoSize = true;
            this.lbUjUgyfelIranyitoszam.Location = new System.Drawing.Point(17, 27);
            this.lbUjUgyfelIranyitoszam.Name = "lbUjUgyfelIranyitoszam";
            this.lbUjUgyfelIranyitoszam.Size = new System.Drawing.Size(70, 13);
            this.lbUjUgyfelIranyitoszam.TabIndex = 3;
            this.lbUjUgyfelIranyitoszam.Text = "Irányítószám:";
            // 
            // lbUjUgyfelVaros
            // 
            this.lbUjUgyfelVaros.AutoSize = true;
            this.lbUjUgyfelVaros.Location = new System.Drawing.Point(17, 59);
            this.lbUjUgyfelVaros.Name = "lbUjUgyfelVaros";
            this.lbUjUgyfelVaros.Size = new System.Drawing.Size(37, 13);
            this.lbUjUgyfelVaros.TabIndex = 4;
            this.lbUjUgyfelVaros.Text = "Város:";
            // 
            // lbUjUgyfelUtca
            // 
            this.lbUjUgyfelUtca.AutoSize = true;
            this.lbUjUgyfelUtca.Location = new System.Drawing.Point(17, 89);
            this.lbUjUgyfelUtca.Name = "lbUjUgyfelUtca";
            this.lbUjUgyfelUtca.Size = new System.Drawing.Size(33, 13);
            this.lbUjUgyfelUtca.TabIndex = 5;
            this.lbUjUgyfelUtca.Text = "Utca:";
            // 
            // lbUjUgyfelHazszam
            // 
            this.lbUjUgyfelHazszam.AutoSize = true;
            this.lbUjUgyfelHazszam.Location = new System.Drawing.Point(17, 120);
            this.lbUjUgyfelHazszam.Name = "lbUjUgyfelHazszam";
            this.lbUjUgyfelHazszam.Size = new System.Drawing.Size(53, 13);
            this.lbUjUgyfelHazszam.TabIndex = 6;
            this.lbUjUgyfelHazszam.Text = "Házszám:";
            // 
            // lbUjUgyfelTelefonszam
            // 
            this.lbUjUgyfelTelefonszam.AutoSize = true;
            this.lbUjUgyfelTelefonszam.Location = new System.Drawing.Point(17, 56);
            this.lbUjUgyfelTelefonszam.Name = "lbUjUgyfelTelefonszam";
            this.lbUjUgyfelTelefonszam.Size = new System.Drawing.Size(70, 13);
            this.lbUjUgyfelTelefonszam.TabIndex = 7;
            this.lbUjUgyfelTelefonszam.Text = "Telefonszám:";
            // 
            // txtUjUgyfelNev
            // 
            this.txtUjUgyfelNev.Location = new System.Drawing.Point(96, 27);
            this.txtUjUgyfelNev.Name = "txtUjUgyfelNev";
            this.txtUjUgyfelNev.Size = new System.Drawing.Size(100, 20);
            this.txtUjUgyfelNev.TabIndex = 8;
            this.txtUjUgyfelNev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // txtUjUgyfelIranyitoszam
            // 
            this.txtUjUgyfelIranyitoszam.Location = new System.Drawing.Point(95, 24);
            this.txtUjUgyfelIranyitoszam.MaxLength = 4;
            this.txtUjUgyfelIranyitoszam.Name = "txtUjUgyfelIranyitoszam";
            this.txtUjUgyfelIranyitoszam.Size = new System.Drawing.Size(49, 20);
            this.txtUjUgyfelIranyitoszam.TabIndex = 9;
            this.txtUjUgyfelIranyitoszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // txtUjUgyfelVaros
            // 
            this.txtUjUgyfelVaros.Location = new System.Drawing.Point(95, 56);
            this.txtUjUgyfelVaros.Name = "txtUjUgyfelVaros";
            this.txtUjUgyfelVaros.Size = new System.Drawing.Size(100, 20);
            this.txtUjUgyfelVaros.TabIndex = 10;
            this.txtUjUgyfelVaros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // txtUjUgyfelUtca
            // 
            this.txtUjUgyfelUtca.Location = new System.Drawing.Point(95, 86);
            this.txtUjUgyfelUtca.Name = "txtUjUgyfelUtca";
            this.txtUjUgyfelUtca.Size = new System.Drawing.Size(100, 20);
            this.txtUjUgyfelUtca.TabIndex = 11;
            this.txtUjUgyfelUtca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // txtUjUgyfelHazszam
            // 
            this.txtUjUgyfelHazszam.Location = new System.Drawing.Point(95, 113);
            this.txtUjUgyfelHazszam.MaxLength = 15;
            this.txtUjUgyfelHazszam.Name = "txtUjUgyfelHazszam";
            this.txtUjUgyfelHazszam.Size = new System.Drawing.Size(100, 20);
            this.txtUjUgyfelHazszam.TabIndex = 12;
            this.txtUjUgyfelHazszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // txtUjUgyfelTelefonszam
            // 
            this.txtUjUgyfelTelefonszam.Location = new System.Drawing.Point(96, 53);
            this.txtUjUgyfelTelefonszam.Name = "txtUjUgyfelTelefonszam";
            this.txtUjUgyfelTelefonszam.Size = new System.Drawing.Size(100, 20);
            this.txtUjUgyfelTelefonszam.TabIndex = 13;
            this.txtUjUgyfelTelefonszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // btnUjUgyfelRogzitese
            // 
            this.btnUjUgyfelRogzitese.BackColor = System.Drawing.Color.Green;
            this.btnUjUgyfelRogzitese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjUgyfelRogzitese.ForeColor = System.Drawing.Color.White;
            this.btnUjUgyfelRogzitese.Location = new System.Drawing.Point(62, 344);
            this.btnUjUgyfelRogzitese.Name = "btnUjUgyfelRogzitese";
            this.btnUjUgyfelRogzitese.Size = new System.Drawing.Size(124, 31);
            this.btnUjUgyfelRogzitese.TabIndex = 14;
            this.btnUjUgyfelRogzitese.Text = "Új ügyfél rögzítése";
            this.btnUjUgyfelRogzitese.UseVisualStyleBackColor = false;
            this.btnUjUgyfelRogzitese.Click += new System.EventHandler(this.btnUjUgyfelRogzitese_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Az új ügyfél adatai:";
            // 
            // grbUjUgyfelCimAdatok
            // 
            this.grbUjUgyfelCimAdatok.Controls.Add(this.lbUjUgyfelIranyitoszam);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.lbUjUgyfelVaros);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.lbUjUgyfelUtca);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.lbUjUgyfelHazszam);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.txtUjUgyfelHazszam);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.txtUjUgyfelIranyitoszam);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.txtUjUgyfelUtca);
            this.grbUjUgyfelCimAdatok.Controls.Add(this.txtUjUgyfelVaros);
            this.grbUjUgyfelCimAdatok.Location = new System.Drawing.Point(19, 173);
            this.grbUjUgyfelCimAdatok.Name = "grbUjUgyfelCimAdatok";
            this.grbUjUgyfelCimAdatok.Size = new System.Drawing.Size(223, 147);
            this.grbUjUgyfelCimAdatok.TabIndex = 16;
            this.grbUjUgyfelCimAdatok.TabStop = false;
            this.grbUjUgyfelCimAdatok.Text = "Cím adatok:";
            // 
            // grbUjUgyfelSzemelyesAdatok
            // 
            this.grbUjUgyfelSzemelyesAdatok.Controls.Add(this.lbUjUgyfelNev);
            this.grbUjUgyfelSzemelyesAdatok.Controls.Add(this.lbUjUgyfelTelefonszam);
            this.grbUjUgyfelSzemelyesAdatok.Controls.Add(this.txtUjUgyfelNev);
            this.grbUjUgyfelSzemelyesAdatok.Controls.Add(this.txtUjUgyfelTelefonszam);
            this.grbUjUgyfelSzemelyesAdatok.Location = new System.Drawing.Point(19, 72);
            this.grbUjUgyfelSzemelyesAdatok.Name = "grbUjUgyfelSzemelyesAdatok";
            this.grbUjUgyfelSzemelyesAdatok.Size = new System.Drawing.Size(223, 95);
            this.grbUjUgyfelSzemelyesAdatok.TabIndex = 17;
            this.grbUjUgyfelSzemelyesAdatok.TabStop = false;
            this.grbUjUgyfelSzemelyesAdatok.Text = "Személyes adatok:";
            // 
            // UjUgyfelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.grbUjUgyfelSzemelyesAdatok);
            this.Controls.Add(this.grbUjUgyfelCimAdatok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUjUgyfelRogzitese);
            this.Controls.Add(this.mtsMenusor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UjUgyfelForm";
            this.Text = "Ügyfél hozzáadása";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UjUgyfelClosed);
            this.mtsMenusor.ResumeLayout(false);
            this.mtsMenusor.PerformLayout();
            this.grbUjUgyfelCimAdatok.ResumeLayout(false);
            this.grbUjUgyfelCimAdatok.PerformLayout();
            this.grbUjUgyfelSzemelyesAdatok.ResumeLayout(false);
            this.grbUjUgyfelSzemelyesAdatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mtsMenusor;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelHozzaadasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujKolcsonzesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.Label lbUjUgyfelNev;
        private System.Windows.Forms.Label lbUjUgyfelIranyitoszam;
        private System.Windows.Forms.Label lbUjUgyfelVaros;
        private System.Windows.Forms.Label lbUjUgyfelUtca;
        private System.Windows.Forms.Label lbUjUgyfelHazszam;
        private System.Windows.Forms.Label lbUjUgyfelTelefonszam;
        private System.Windows.Forms.TextBox txtUjUgyfelNev;
        private System.Windows.Forms.TextBox txtUjUgyfelIranyitoszam;
        private System.Windows.Forms.TextBox txtUjUgyfelVaros;
        private System.Windows.Forms.TextBox txtUjUgyfelUtca;
        private System.Windows.Forms.TextBox txtUjUgyfelHazszam;
        private System.Windows.Forms.TextBox txtUjUgyfelTelefonszam;
        private System.Windows.Forms.Button btnUjUgyfelRogzitese;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbUjUgyfelCimAdatok;
        private System.Windows.Forms.GroupBox grbUjUgyfelSzemelyesAdatok;
    }
}