using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoKolcsonzo
{
    public partial class Main : Form
    {
        SQLUtasitasok sql = new SQLUtasitasok();
        string sqlParancs;
        
        public Main()
        {
            InitializeComponent();

            lbVHSFilmekSzama.Text += vhsFilmekSzama() + " db";
            lbDVDFilmekSzama.Text += dvdFilmekSzama() + " db";
            lbBlueRayFilmekSzama.Text += blueRayFilmekSzama() + " db";
            lbFilmekSzama.Text += "\n"+filmekSzama() + " db";
            sql.kapcsolodasVege();
        }

        private string filmekSzama()
        {
            sql.kapcsolodas();
            sqlParancs = "SELECT COUNT(Film_Id) FROM film;";
            return sql.tablatoltes(sqlParancs).Rows[0]["COUNT(Film_Id)"].ToString();
        }

        private string blueRayFilmekSzama()
        {
            sql.kapcsolodas();
            sqlParancs = "SELECT COUNT(Adathordozo) FROM film WHERE Adathordozo = \'Blue-Ray\';";
            return sql.tablatoltes(sqlParancs).Rows[0]["COUNT(Adathordozo)"].ToString();
        }

        private string dvdFilmekSzama()
        {
            sql.kapcsolodas();
            sqlParancs = "SELECT COUNT(Adathordozo) FROM film WHERE Adathordozo = \'DVD\';";
            return sql.tablatoltes(sqlParancs).Rows[0]["COUNT(Adathordozo)"].ToString();
        }

        private string vhsFilmekSzama()
        {
            sql.kapcsolodas();
            sqlParancs = "SELECT COUNT(Adathordozo) FROM film WHERE Adathordozo = \'VHS\';";
            return sql.tablatoltes(sqlParancs).Rows[0]["COUNT(Adathordozo)"].ToString();
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ujUgyfelHozzaadasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjUgyfelForm ujUgyfel = new UjUgyfelForm();
            ujUgyfel.Show();
            this.Hide();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            sql.kapcsolodasVege();
        }

        private void ugyfelekKezeleseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UgyfelekKezeleseForm ugyfelekKezelese = new UgyfelekKezeleseForm();
            ugyfelekKezelese.Show();
            this.Hide();
        }

        private void ujKolcsonzesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjKolcsonzesForm ujKolcsonzes = new UjKolcsonzesForm();
            ujKolcsonzes.Show();
            this.Hide();
        }

        private void kolcsonzesekKezeleseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KolcsonzesekKezeleseForm kolcsonzesekKezelese = new KolcsonzesekKezeleseForm();
            kolcsonzesekKezelese.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            MaximumSize = new Size(450, 352);
            MinimumSize = new Size(450, 352);
        }
    }
}
