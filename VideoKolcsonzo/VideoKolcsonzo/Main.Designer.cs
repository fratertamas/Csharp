namespace VideoKolcsonzo
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mtsMenusor = new System.Windows.Forms.MenuStrip();
            this.ugyfelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelHozzaadasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKolcsonzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolcsonzesekKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbVHSFilmekSzama = new System.Windows.Forms.Label();
            this.lbDVDFilmekSzama = new System.Windows.Forms.Label();
            this.lbBlueRayFilmekSzama = new System.Windows.Forms.Label();
            this.lbFilmekSzama = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtsMenusor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vhs.jpg");
            // 
            // mtsMenusor
            // 
            this.mtsMenusor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfelekToolStripMenuItem,
            this.kolcsonzesekToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.mtsMenusor.Location = new System.Drawing.Point(0, 0);
            this.mtsMenusor.Name = "mtsMenusor";
            this.mtsMenusor.Size = new System.Drawing.Size(434, 24);
            this.mtsMenusor.TabIndex = 0;
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
            this.kolcsonzesekKezeleseToolStripMenuItem.Click += new System.EventHandler(this.kolcsonzesekKezeleseToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // lbVHSFilmekSzama
            // 
            this.lbVHSFilmekSzama.AutoSize = true;
            this.lbVHSFilmekSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVHSFilmekSzama.Location = new System.Drawing.Point(13, 224);
            this.lbVHSFilmekSzama.Name = "lbVHSFilmekSzama";
            this.lbVHSFilmekSzama.Size = new System.Drawing.Size(165, 20);
            this.lbVHSFilmekSzama.TabIndex = 2;
            this.lbVHSFilmekSzama.Text = "VHS filmek száma: ";
            // 
            // lbDVDFilmekSzama
            // 
            this.lbDVDFilmekSzama.AutoSize = true;
            this.lbDVDFilmekSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDVDFilmekSzama.Location = new System.Drawing.Point(13, 253);
            this.lbDVDFilmekSzama.Name = "lbDVDFilmekSzama";
            this.lbDVDFilmekSzama.Size = new System.Drawing.Size(166, 20);
            this.lbDVDFilmekSzama.TabIndex = 3;
            this.lbDVDFilmekSzama.Text = "DVD filmek száma: ";
            // 
            // lbBlueRayFilmekSzama
            // 
            this.lbBlueRayFilmekSzama.AutoSize = true;
            this.lbBlueRayFilmekSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBlueRayFilmekSzama.Location = new System.Drawing.Point(13, 282);
            this.lbBlueRayFilmekSzama.Name = "lbBlueRayFilmekSzama";
            this.lbBlueRayFilmekSzama.Size = new System.Drawing.Size(201, 20);
            this.lbBlueRayFilmekSzama.TabIndex = 4;
            this.lbBlueRayFilmekSzama.Text = "Blue-Ray filmek száma: ";
            // 
            // lbFilmekSzama
            // 
            this.lbFilmekSzama.AutoSize = true;
            this.lbFilmekSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFilmekSzama.ForeColor = System.Drawing.Color.Red;
            this.lbFilmekSzama.Location = new System.Drawing.Point(279, 224);
            this.lbFilmekSzama.Name = "lbFilmekSzama";
            this.lbFilmekSzama.Size = new System.Drawing.Size(126, 20);
            this.lbFilmekSzama.TabIndex = 5;
            this.lbFilmekSzama.Text = "Filmek Száma:";
            this.lbFilmekSzama.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VideoKolcsonzo.Properties.Resources.vhs;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 314);
            this.Controls.Add(this.lbFilmekSzama);
            this.Controls.Add(this.lbBlueRayFilmekSzama);
            this.Controls.Add(this.lbDVDFilmekSzama);
            this.Controls.Add(this.lbVHSFilmekSzama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtsMenusor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mtsMenusor;
            this.Name = "Main";
            this.Text = "Videó kölcsönző";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.mtsMenusor.ResumeLayout(false);
            this.mtsMenusor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip mtsMenusor;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelHozzaadasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfelekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujKolcsonzesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolcsonzesekKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVHSFilmekSzama;
        private System.Windows.Forms.Label lbDVDFilmekSzama;
        private System.Windows.Forms.Label lbBlueRayFilmekSzama;
        private System.Windows.Forms.Label lbFilmekSzama;
    }
}

