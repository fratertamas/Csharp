namespace VideoKolcsonzo
{
    partial class UgyfelekKezeleseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgyfelekKezeleseForm));
            this.mtsMenusor = new System.Windows.Forms.MenuStrip();
            this.ugyfelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelHozzaadasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKolcsonzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUgyfelKeresNevAlapjan = new System.Windows.Forms.Button();
            this.txtUgyfelKeresNevAlapjan = new System.Windows.Forms.TextBox();
            this.dgvUgyfelekAdatai = new System.Windows.Forms.DataGridView();
            this.lbUgyfelAdatNev = new System.Windows.Forms.Label();
            this.lbUgyfeladatIranyitoszam = new System.Windows.Forms.Label();
            this.grbUgyfelAdatai = new System.Windows.Forms.GroupBox();
            this.lbUgyfelAdatID = new System.Windows.Forms.Label();
            this.txtUgyfelAdatTelefonszam = new System.Windows.Forms.TextBox();
            this.txtUgyfelAdatHazszam = new System.Windows.Forms.TextBox();
            this.txtUgyfelAdatUtca = new System.Windows.Forms.TextBox();
            this.txtUgyfelAdatVaros = new System.Windows.Forms.TextBox();
            this.txtUgyfelAdatIranyitoszam = new System.Windows.Forms.TextBox();
            this.txtUgyfelAdatNev = new System.Windows.Forms.TextBox();
            this.lbUgyfelTelefonszam = new System.Windows.Forms.Label();
            this.lbUgyfelHazszam = new System.Windows.Forms.Label();
            this.lbUgyfelUtca = new System.Windows.Forms.Label();
            this.lbUgyfelVaros = new System.Windows.Forms.Label();
            this.btnUgyfelAdatokMezokUresseTetele = new System.Windows.Forms.Button();
            this.grbUgyfelMuveletek = new System.Windows.Forms.GroupBox();
            this.btnUgyfelTorlese = new System.Windows.Forms.Button();
            this.btnUgyfelAdatainakModositasa = new System.Windows.Forms.Button();
            this.grbKikolcsonzottFilmek = new System.Windows.Forms.GroupBox();
            this.dgvKikolcsonzottFilmek = new System.Windows.Forms.DataGridView();
            this.mtsMenusor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgyfelekAdatai)).BeginInit();
            this.grbUgyfelAdatai.SuspendLayout();
            this.grbUgyfelMuveletek.SuspendLayout();
            this.grbKikolcsonzottFilmek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKikolcsonzottFilmek)).BeginInit();
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
            this.mtsMenusor.Size = new System.Drawing.Size(491, 24);
            this.mtsMenusor.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUgyfelKeresNevAlapjan);
            this.groupBox1.Controls.Add(this.txtUgyfelKeresNevAlapjan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresése név alapján";
            // 
            // btnUgyfelKeresNevAlapjan
            // 
            this.btnUgyfelKeresNevAlapjan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUgyfelKeresNevAlapjan.ForeColor = System.Drawing.Color.White;
            this.btnUgyfelKeresNevAlapjan.Location = new System.Drawing.Point(55, 61);
            this.btnUgyfelKeresNevAlapjan.Name = "btnUgyfelKeresNevAlapjan";
            this.btnUgyfelKeresNevAlapjan.Size = new System.Drawing.Size(75, 23);
            this.btnUgyfelKeresNevAlapjan.TabIndex = 1;
            this.btnUgyfelKeresNevAlapjan.Text = "Keresés";
            this.btnUgyfelKeresNevAlapjan.UseVisualStyleBackColor = false;
            this.btnUgyfelKeresNevAlapjan.Click += new System.EventHandler(this.btnUgyfelKeresNevAlapjan_Click);
            // 
            // txtUgyfelKeresNevAlapjan
            // 
            this.txtUgyfelKeresNevAlapjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUgyfelKeresNevAlapjan.Location = new System.Drawing.Point(7, 32);
            this.txtUgyfelKeresNevAlapjan.Name = "txtUgyfelKeresNevAlapjan";
            this.txtUgyfelKeresNevAlapjan.Size = new System.Drawing.Size(187, 23);
            this.txtUgyfelKeresNevAlapjan.TabIndex = 0;
            this.txtUgyfelKeresNevAlapjan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUgyfelKeresNevAlapjan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // dgvUgyfelekAdatai
            // 
            this.dgvUgyfelekAdatai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgyfelekAdatai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUgyfelekAdatai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgyfelekAdatai.Location = new System.Drawing.Point(12, 133);
            this.dgvUgyfelekAdatai.Name = "dgvUgyfelekAdatai";
            this.dgvUgyfelekAdatai.ReadOnly = true;
            this.dgvUgyfelekAdatai.Size = new System.Drawing.Size(459, 150);
            this.dgvUgyfelekAdatai.TabIndex = 4;
            this.dgvUgyfelekAdatai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUgyfelekAdataiCellContentClick);
            // 
            // lbUgyfelAdatNev
            // 
            this.lbUgyfelAdatNev.AutoSize = true;
            this.lbUgyfelAdatNev.Location = new System.Drawing.Point(6, 34);
            this.lbUgyfelAdatNev.Name = "lbUgyfelAdatNev";
            this.lbUgyfelAdatNev.Size = new System.Drawing.Size(30, 13);
            this.lbUgyfelAdatNev.TabIndex = 5;
            this.lbUgyfelAdatNev.Text = "Név:";
            // 
            // lbUgyfeladatIranyitoszam
            // 
            this.lbUgyfeladatIranyitoszam.AutoSize = true;
            this.lbUgyfeladatIranyitoszam.Location = new System.Drawing.Point(6, 58);
            this.lbUgyfeladatIranyitoszam.Name = "lbUgyfeladatIranyitoszam";
            this.lbUgyfeladatIranyitoszam.Size = new System.Drawing.Size(70, 13);
            this.lbUgyfeladatIranyitoszam.TabIndex = 6;
            this.lbUgyfeladatIranyitoszam.Text = "Irányítószám:";
            // 
            // grbUgyfelAdatai
            // 
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfelAdatID);
            this.grbUgyfelAdatai.Controls.Add(this.txtUgyfelAdatTelefonszam);
            this.grbUgyfelAdatai.Controls.Add(this.txtUgyfelAdatHazszam);
            this.grbUgyfelAdatai.Controls.Add(this.txtUgyfelAdatUtca);
            this.grbUgyfelAdatai.Controls.Add(this.txtUgyfelAdatVaros);
            this.grbUgyfelAdatai.Controls.Add(this.txtUgyfelAdatIranyitoszam);
            this.grbUgyfelAdatai.Controls.Add(this.txtUgyfelAdatNev);
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfelTelefonszam);
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfelHazszam);
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfelUtca);
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfelVaros);
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfelAdatNev);
            this.grbUgyfelAdatai.Controls.Add(this.lbUgyfeladatIranyitoszam);
            this.grbUgyfelAdatai.Location = new System.Drawing.Point(12, 303);
            this.grbUgyfelAdatai.Name = "grbUgyfelAdatai";
            this.grbUgyfelAdatai.Size = new System.Drawing.Size(225, 194);
            this.grbUgyfelAdatai.TabIndex = 7;
            this.grbUgyfelAdatai.TabStop = false;
            this.grbUgyfelAdatai.Text = "Ügyfél adatai";
            // 
            // lbUgyfelAdatID
            // 
            this.lbUgyfelAdatID.AutoSize = true;
            this.lbUgyfelAdatID.Location = new System.Drawing.Point(9, 16);
            this.lbUgyfelAdatID.Name = "lbUgyfelAdatID";
            this.lbUgyfelAdatID.Size = new System.Drawing.Size(0, 13);
            this.lbUgyfelAdatID.TabIndex = 17;
            // 
            // txtUgyfelAdatTelefonszam
            // 
            this.txtUgyfelAdatTelefonszam.Location = new System.Drawing.Point(80, 146);
            this.txtUgyfelAdatTelefonszam.Name = "txtUgyfelAdatTelefonszam";
            this.txtUgyfelAdatTelefonszam.Size = new System.Drawing.Size(127, 20);
            this.txtUgyfelAdatTelefonszam.TabIndex = 16;
            this.txtUgyfelAdatTelefonszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // txtUgyfelAdatHazszam
            // 
            this.txtUgyfelAdatHazszam.Location = new System.Drawing.Point(80, 125);
            this.txtUgyfelAdatHazszam.Name = "txtUgyfelAdatHazszam";
            this.txtUgyfelAdatHazszam.Size = new System.Drawing.Size(127, 20);
            this.txtUgyfelAdatHazszam.TabIndex = 15;
            this.txtUgyfelAdatHazszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // txtUgyfelAdatUtca
            // 
            this.txtUgyfelAdatUtca.Location = new System.Drawing.Point(80, 102);
            this.txtUgyfelAdatUtca.Name = "txtUgyfelAdatUtca";
            this.txtUgyfelAdatUtca.Size = new System.Drawing.Size(127, 20);
            this.txtUgyfelAdatUtca.TabIndex = 14;
            this.txtUgyfelAdatUtca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // txtUgyfelAdatVaros
            // 
            this.txtUgyfelAdatVaros.Location = new System.Drawing.Point(80, 78);
            this.txtUgyfelAdatVaros.Name = "txtUgyfelAdatVaros";
            this.txtUgyfelAdatVaros.Size = new System.Drawing.Size(127, 20);
            this.txtUgyfelAdatVaros.TabIndex = 13;
            this.txtUgyfelAdatVaros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // txtUgyfelAdatIranyitoszam
            // 
            this.txtUgyfelAdatIranyitoszam.Location = new System.Drawing.Point(80, 55);
            this.txtUgyfelAdatIranyitoszam.MaxLength = 4;
            this.txtUgyfelAdatIranyitoszam.Name = "txtUgyfelAdatIranyitoszam";
            this.txtUgyfelAdatIranyitoszam.Size = new System.Drawing.Size(50, 20);
            this.txtUgyfelAdatIranyitoszam.TabIndex = 12;
            this.txtUgyfelAdatIranyitoszam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizSzamE);
            // 
            // txtUgyfelAdatNev
            // 
            this.txtUgyfelAdatNev.Location = new System.Drawing.Point(80, 31);
            this.txtUgyfelAdatNev.Name = "txtUgyfelAdatNev";
            this.txtUgyfelAdatNev.Size = new System.Drawing.Size(127, 20);
            this.txtUgyfelAdatNev.TabIndex = 11;
            this.txtUgyfelAdatNev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ellenorizBetuE);
            // 
            // lbUgyfelTelefonszam
            // 
            this.lbUgyfelTelefonszam.AutoSize = true;
            this.lbUgyfelTelefonszam.Location = new System.Drawing.Point(4, 150);
            this.lbUgyfelTelefonszam.Name = "lbUgyfelTelefonszam";
            this.lbUgyfelTelefonszam.Size = new System.Drawing.Size(70, 13);
            this.lbUgyfelTelefonszam.TabIndex = 10;
            this.lbUgyfelTelefonszam.Text = "Telefonszám:";
            // 
            // lbUgyfelHazszam
            // 
            this.lbUgyfelHazszam.AutoSize = true;
            this.lbUgyfelHazszam.Location = new System.Drawing.Point(6, 128);
            this.lbUgyfelHazszam.Name = "lbUgyfelHazszam";
            this.lbUgyfelHazszam.Size = new System.Drawing.Size(53, 13);
            this.lbUgyfelHazszam.TabIndex = 9;
            this.lbUgyfelHazszam.Text = "Házszám:";
            // 
            // lbUgyfelUtca
            // 
            this.lbUgyfelUtca.AutoSize = true;
            this.lbUgyfelUtca.Location = new System.Drawing.Point(7, 105);
            this.lbUgyfelUtca.Name = "lbUgyfelUtca";
            this.lbUgyfelUtca.Size = new System.Drawing.Size(33, 13);
            this.lbUgyfelUtca.TabIndex = 8;
            this.lbUgyfelUtca.Text = "Utca:";
            // 
            // lbUgyfelVaros
            // 
            this.lbUgyfelVaros.AutoSize = true;
            this.lbUgyfelVaros.Location = new System.Drawing.Point(7, 81);
            this.lbUgyfelVaros.Name = "lbUgyfelVaros";
            this.lbUgyfelVaros.Size = new System.Drawing.Size(37, 13);
            this.lbUgyfelVaros.TabIndex = 7;
            this.lbUgyfelVaros.Text = "Város:";
            // 
            // btnUgyfelAdatokMezokUresseTetele
            // 
            this.btnUgyfelAdatokMezokUresseTetele.Location = new System.Drawing.Point(32, 29);
            this.btnUgyfelAdatokMezokUresseTetele.Name = "btnUgyfelAdatokMezokUresseTetele";
            this.btnUgyfelAdatokMezokUresseTetele.Size = new System.Drawing.Size(134, 23);
            this.btnUgyfelAdatokMezokUresseTetele.TabIndex = 8;
            this.btnUgyfelAdatokMezokUresseTetele.Text = "Mezők üressé tétele";
            this.btnUgyfelAdatokMezokUresseTetele.UseVisualStyleBackColor = true;
            this.btnUgyfelAdatokMezokUresseTetele.Click += new System.EventHandler(this.btnUgyfelAdatokMezokUresseTetele_Click);
            // 
            // grbUgyfelMuveletek
            // 
            this.grbUgyfelMuveletek.Controls.Add(this.btnUgyfelTorlese);
            this.grbUgyfelMuveletek.Controls.Add(this.btnUgyfelAdatainakModositasa);
            this.grbUgyfelMuveletek.Controls.Add(this.btnUgyfelAdatokMezokUresseTetele);
            this.grbUgyfelMuveletek.Location = new System.Drawing.Point(271, 303);
            this.grbUgyfelMuveletek.Name = "grbUgyfelMuveletek";
            this.grbUgyfelMuveletek.Size = new System.Drawing.Size(200, 194);
            this.grbUgyfelMuveletek.TabIndex = 9;
            this.grbUgyfelMuveletek.TabStop = false;
            this.grbUgyfelMuveletek.Text = "Műveletek";
            // 
            // btnUgyfelTorlese
            // 
            this.btnUgyfelTorlese.Location = new System.Drawing.Point(32, 140);
            this.btnUgyfelTorlese.Name = "btnUgyfelTorlese";
            this.btnUgyfelTorlese.Size = new System.Drawing.Size(134, 23);
            this.btnUgyfelTorlese.TabIndex = 10;
            this.btnUgyfelTorlese.Text = "Ügyfél Törlése";
            this.btnUgyfelTorlese.UseVisualStyleBackColor = true;
            this.btnUgyfelTorlese.Click += new System.EventHandler(this.btnUgyfelTorlese_Click);
            // 
            // btnUgyfelAdatainakModositasa
            // 
            this.btnUgyfelAdatainakModositasa.Location = new System.Drawing.Point(32, 81);
            this.btnUgyfelAdatainakModositasa.Name = "btnUgyfelAdatainakModositasa";
            this.btnUgyfelAdatainakModositasa.Size = new System.Drawing.Size(134, 23);
            this.btnUgyfelAdatainakModositasa.TabIndex = 9;
            this.btnUgyfelAdatainakModositasa.Text = "Adatok Módosítása";
            this.btnUgyfelAdatainakModositasa.UseVisualStyleBackColor = true;
            this.btnUgyfelAdatainakModositasa.Click += new System.EventHandler(this.btnUgyfelAdatainakModositasa_Click);
            // 
            // grbKikolcsonzottFilmek
            // 
            this.grbKikolcsonzottFilmek.Controls.Add(this.dgvKikolcsonzottFilmek);
            this.grbKikolcsonzottFilmek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grbKikolcsonzottFilmek.Location = new System.Drawing.Point(238, 28);
            this.grbKikolcsonzottFilmek.Name = "grbKikolcsonzottFilmek";
            this.grbKikolcsonzottFilmek.Size = new System.Drawing.Size(233, 100);
            this.grbKikolcsonzottFilmek.TabIndex = 10;
            this.grbKikolcsonzottFilmek.TabStop = false;
            this.grbKikolcsonzottFilmek.Text = "Ügyfél által kikölcsönzött filmek";
            // 
            // dgvKikolcsonzottFilmek
            // 
            this.dgvKikolcsonzottFilmek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKikolcsonzottFilmek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKikolcsonzottFilmek.Location = new System.Drawing.Point(6, 22);
            this.dgvKikolcsonzottFilmek.Name = "dgvKikolcsonzottFilmek";
            this.dgvKikolcsonzottFilmek.Size = new System.Drawing.Size(221, 72);
            this.dgvKikolcsonzottFilmek.TabIndex = 0;
            // 
            // UgyfelekKezeleseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 509);
            this.Controls.Add(this.grbKikolcsonzottFilmek);
            this.Controls.Add(this.grbUgyfelMuveletek);
            this.Controls.Add(this.grbUgyfelAdatai);
            this.Controls.Add(this.dgvUgyfelekAdatai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtsMenusor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UgyfelekKezeleseForm";
            this.Text = "Ügyfelek kezelése";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ugyfelekKezeleseFormClosed);
            this.mtsMenusor.ResumeLayout(false);
            this.mtsMenusor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgyfelekAdatai)).EndInit();
            this.grbUgyfelAdatai.ResumeLayout(false);
            this.grbUgyfelAdatai.PerformLayout();
            this.grbUgyfelMuveletek.ResumeLayout(false);
            this.grbKikolcsonzottFilmek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKikolcsonzottFilmek)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUgyfelKeresNevAlapjan;
        private System.Windows.Forms.TextBox txtUgyfelKeresNevAlapjan;
        private System.Windows.Forms.DataGridView dgvUgyfelekAdatai;
        private System.Windows.Forms.Label lbUgyfelAdatNev;
        private System.Windows.Forms.Label lbUgyfeladatIranyitoszam;
        private System.Windows.Forms.GroupBox grbUgyfelAdatai;
        private System.Windows.Forms.TextBox txtUgyfelAdatTelefonszam;
        private System.Windows.Forms.TextBox txtUgyfelAdatHazszam;
        private System.Windows.Forms.TextBox txtUgyfelAdatUtca;
        private System.Windows.Forms.TextBox txtUgyfelAdatVaros;
        private System.Windows.Forms.TextBox txtUgyfelAdatIranyitoszam;
        private System.Windows.Forms.TextBox txtUgyfelAdatNev;
        private System.Windows.Forms.Label lbUgyfelTelefonszam;
        private System.Windows.Forms.Label lbUgyfelHazszam;
        private System.Windows.Forms.Label lbUgyfelUtca;
        private System.Windows.Forms.Label lbUgyfelVaros;
        private System.Windows.Forms.Button btnUgyfelAdatokMezokUresseTetele;
        private System.Windows.Forms.GroupBox grbUgyfelMuveletek;
        private System.Windows.Forms.Button btnUgyfelTorlese;
        private System.Windows.Forms.Button btnUgyfelAdatainakModositasa;
        private System.Windows.Forms.Label lbUgyfelAdatID;
        private System.Windows.Forms.GroupBox grbKikolcsonzottFilmek;
        private System.Windows.Forms.DataGridView dgvKikolcsonzottFilmek;
    }
}