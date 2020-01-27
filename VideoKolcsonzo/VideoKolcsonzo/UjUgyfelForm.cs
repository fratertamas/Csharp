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
    public partial class UjUgyfelForm : Form
    {
        SQLUtasitasok sql = new SQLUtasitasok();
        MezoMuveletek muveletek = new MezoMuveletek();
        string sqlParancs;
        public UjUgyfelForm()
        {
            InitializeComponent();
            ujUgyfelHozzaadasaToolStripMenuItem.Enabled = false;
        }

        private void UjUgyfelClosed(object sender, FormClosedEventArgs e)
        {
            Main foablak = new Main();
            foablak.Show();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.kapcsolodasVege();
            Application.Exit();
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

        private void btnUjUgyfelRogzitese_Click(object sender, EventArgs e)
        {
            sql.kapcsolodas();
            int utolsoVevoId = Convert.ToInt32(sql.tablatoltes("SELECT Ugyfel_Id FROM ugyfel ORDER BY Ugyfel_Id DESC LIMIT 1;").Rows[0]["Ugyfel_Id"].ToString());
            /*
             INSERT INTO `ugyfel`(`Ugyfel_Id`, `Nev`, `Ir_szam`, `Varos`, `Utca`, `Hazszam`, `Tel_sz`) 
             VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7])
             */
            sqlParancs = "INSERT INTO ugyfel VALUES (\'"+(utolsoVevoId+1)+"\', \'"+txtUjUgyfelNev.Text+"\'" +
                ", \'"+txtUjUgyfelIranyitoszam.Text+"\', \'"+txtUjUgyfelVaros.Text+"\'" +
                ", \'"+txtUjUgyfelUtca.Text+"\', \'"+txtUjUgyfelHazszam.Text+"\', \'"+txtUjUgyfelTelefonszam.Text+"\');";

            string beszurasEredmeny = sql.beszuras(sqlParancs);

            if (beszurasEredmeny == "Az adatbázis szerver lezárta a kapcsolatot!")
            {
                MessageBox.Show("Az adatbázis szerver lezárta a kapcsolatot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(beszurasEredmeny == "OK")
            {
                //Kérdezzük meg, hogy akar-e másik személyt felvinni
                DialogResult ujUgyfelKerdes = MessageBox.Show("Az új ügyfél adatainak rögzitése sikeres volt.\n" +
                    "Szeretne-e még új ügyfél adatát rögzíteni?", "Információ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ujUgyfelKerdes == DialogResult.Yes)
                {
                    mezokKiuritese();
                }
                else
                {
                    UgyfelekKezeleseForm ugyfelekKezelese = new UgyfelekKezeleseForm();
                    ugyfelekKezelese.Show();
                    this.Hide();
                    sql.kapcsolodasVege();
                }
            }
            else
            {
                MessageBox.Show("Az új ügyfél rögzitése sikertelen volt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mezokKiuritese()
        {
            txtUjUgyfelNev.Clear();
            txtUjUgyfelTelefonszam.Clear();
            txtUjUgyfelIranyitoszam.Clear();
            txtUjUgyfelVaros.Clear();
            txtUjUgyfelUtca.Clear();
            txtUjUgyfelHazszam.Clear();
        }

        private void ellenorizBetuE(object sender, KeyPressEventArgs e)
        {
            muveletek.textBoxEllenorizBetuE(e);
            
        }

        private void ellenorizSzamE(object sender, KeyPressEventArgs e)
        {
            muveletek.textBoxEllenorizSzamE(e);
        }
    }
}
