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
    public partial class UjKolcsonzesForm : Form
    {
        SQLUtasitasok sql = new SQLUtasitasok();
        MezoMuveletek muveletek = new MezoMuveletek();
        string sqlParancs;


        public UjKolcsonzesForm()
        {
            InitializeComponent();

            ujKolcsonzesToolStripMenuItem.Enabled = false;
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.kapcsolodasVege();
            Application.Exit();
        }

        private void kolcsonzesekKezeleseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KolcsonzesekKezeleseForm kolcsonzesekKezelese = new KolcsonzesekKezeleseForm();
            kolcsonzesekKezelese.Show();
            this.Hide();
        }

        private void ujUgyfelHozzaadasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjUgyfelForm ujUgyfel = new UjUgyfelForm();
            ujUgyfel.Show();
            this.Hide();
        }

        private void ugyfelekKezeleseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UgyfelekKezeleseForm ugyfelekKezelese = new UgyfelekKezeleseForm();
            ugyfelekKezelese.Show();
            this.Hide();
        }

        private void ujKolcsonzesFormClosed(object sender, FormClosedEventArgs e)
        {
            Main foablak = new Main();
            foablak.Show();
        }

        private void ellenorizSzamE(object sender, KeyPressEventArgs e)
        {
            muveletek.textBoxEllenorizSzamE(e);
        }

        private void UjKolcsonzesForm_Load(object sender, EventArgs e)
        {
            sql.kapcsolodas();
            DataTable nevekTabla = new DataTable();
            sqlParancs = "SELECT * FROM ugyfel ORDER BY Nev;";
            //Próba Béla (ID: 3) ---> SELECT Ugyfel_Id, CONCAT(Nev,' (ID: )',Ugyfel_Id) AS Nev FROM ugyfel ORDER BY Nev;
            nevekTabla = sql.tablatoltes(sqlParancs);

            DataTable filmekTabla = new DataTable();
            sqlParancs = "SELECT Film_Id, CONCAT(Cim,' (',Adathordozo,')') AS Cim FROM film ORDER BY Cim;";
            filmekTabla = sql.tablatoltes(sqlParancs);

            //Combobox adatforrasa nevekTabla (DataTable)
            cmbUgyfelNev.DataSource = nevekTabla;
            //sor nevezetu DataRow valtozo letrehozasa, es ennek a nevekTabla uj sor metodusa ertekuladasa
            DataRow sor = nevekTabla.NewRow();
            //sor ertekeinek beallitasa (megfelelo oszlopokhoz)
            sor["Ugyfel_Id"] = "0";
            sor["Nev"] = "--Nincs Kiválasztva--";
            //nevekTabla-ba megadjuk, hogy mit es hova szurja be (jelen esetben, 0. sorba)
            nevekTabla.Rows.InsertAt(sor,0);
            //kivalasztasa annak, hogy mi jelenjen meg a comboBox-ban es mi legyen annak az erteke
            cmbUgyfelNev.DisplayMember="Nev";
            cmbUgyfelNev.ValueMember = "Ugyfel_Id";
            //megadjuk, hogy mi jelenjen meg eloszor a comboBox-ban
            cmbUgyfelNev.SelectedIndex = 0;

            //Film cimek comboBox elkeszitese
            cmbFilmCim.DataSource = filmekTabla;
            sor = filmekTabla.NewRow();
            sor["Film_Id"] = "0";
            sor["Cim"] = "--Nincs Kiválasztva--";
            filmekTabla.Rows.InsertAt(sor, 0);
            cmbFilmCim.DisplayMember = "Cim";
            cmbFilmCim.ValueMember = "Film_Id";
            cmbFilmCim.SelectedIndex = 0;

            sql.kapcsolodasVege();

        }

        private void btnUjKolcsonzesRogzitese_Click(object sender, EventArgs e)
        {
            string hibauzenet = "";
            bool hibaVan = false;
            if (cmbUgyfelNev.SelectedIndex == 0)
            {
                hibauzenet += "Nem választott ki ügyfelet!\n";
                hibaVan = true;
            }
            if (cmbFilmCim.SelectedIndex == 0)
            {
                hibauzenet += "Nem választott ki filmet!\n";
                hibaVan = true;
            }
            if (txtKolcsonzesiDij.Text == "")
            {
                hibauzenet += "Nem adta meg a kölcsönzési díj összegét!\n";
                hibaVan = true;
            }
            if (nudKolcsonzesiIdo.Value == 0)
            {
                hibauzenet += "Nem adta meg a kölcsönzési idő (nap) időtartamát!\n";
                hibaVan = true;
            }
            if (dtpKolcsonzesDatuma.Value < DateTime.Today)
            {
                hibauzenet += "Nem lehet korábbi a kölcsönzés napja, mint az aktuális dátum!";
                hibaVan = true;
            }
            if (hibaVan)
            {
                MessageBox.Show(hibauzenet, "Hiányoságok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql.kapcsolodas();
                int utolsoKolcsonzesId = Convert.ToInt32(sql.tablatoltes("SELECT Kolcsonzes_Id FROM kolcsonzes ORDER BY Kolcsonzes_Id DESC LIMIT 1;").Rows[0]["Kolcsonzes_Id"].ToString());
                /*
                 INSERT INTO `kolcsonzes`(`Kolcsonzes_Id`, `Ugyfel_Id`, `Film_Id`, `Ar`, `Kolcsonzes_nap`, `Kolcsonzes_datum`) 
                 VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6])
                 */
                sqlParancs = "INSERT INTO kolcsonzes (Kolcsonzes_Id, Ugyfel_Id, Film_Id, Ar, Kolcsonzes_nap, Kolcsonzes_datum) " +
                    "VALUES ('" + (utolsoKolcsonzesId + 1) + "', '" + cmbUgyfelNev.SelectedValue.ToString() + "', " +
                    "'" + cmbFilmCim.SelectedValue.ToString() + "', '" + txtKolcsonzesiDij.Text + "', " +
                    "'" + nudKolcsonzesiIdo.Value + "', '" + dtpKolcsonzesDatuma.Value + "');";

                string beszurasEredmeny = sql.beszuras(sqlParancs);

                if (beszurasEredmeny == "Az adatbázis szerver lezárta a kapcsolatot!")
                {
                    MessageBox.Show("Az adatbázis szerver lezárta a kapcsolatot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (beszurasEredmeny == "OK")
                {
                    DialogResult ujKolcsonzesKerdes = MessageBox.Show("Az új kölcsönzés adatainak rögzitése sikeres volt.\n" +
                                        "Szeretne-e még új kölcsönzést rögzíteni?", "Információ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (ujKolcsonzesKerdes == DialogResult.Yes)
                    {
                        mezokKiuritese();
                    }
                    else
                    {
                        KolcsonzesekKezeleseForm kolcsonzesekKezelese = new KolcsonzesekKezeleseForm();
                        kolcsonzesekKezelese.Show();
                        this.Hide();
                        sql.kapcsolodasVege();
                    }
                }
                else
                {
                    MessageBox.Show("Az új kölcsönzés rögzitése sikertelen volt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    sql.kapcsolodasVege();
            }
            //lbSeged.Text = "ÜgyfélIndex: " + cmbUgyfelNev.SelectedIndex + " " +
            //    "ÜgyfélNév: " + cmbUgyfelNev.Text.ToString() + " " +
            //    "ÜgyfélID: " + cmbUgyfelNev.SelectedValue.ToString();
        }

        private void mezokKiuritese()
        {
            cmbUgyfelNev.SelectedIndex = 0;
            cmbFilmCim.SelectedIndex = 0;
            txtKolcsonzesiDij.Text = "";
            nudKolcsonzesiIdo.Value = 0;
            dtpKolcsonzesDatuma.Value = DateTime.Today;
        }
    }
}
