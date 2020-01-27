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
    public partial class UgyfelekKezeleseForm : Form
    {
        SQLUtasitasok sql = new SQLUtasitasok();
        MezoMuveletek muveletek = new MezoMuveletek();
        string sqlParancs;
        public UgyfelekKezeleseForm()
        {
            InitializeComponent();
            ugyfelekKezeleseToolStripMenuItem.Enabled = false;
            lbUgyfelAdatID.Hide();
            grbKikolcsonzottFilmek.Hide();

            sql.kapcsolodas();
            sqlParancs = "SELECT * FROM ugyfel;";
            dgvUgyfelekAdatai.DataSource = sql.tablatoltes(sqlParancs);

        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.kapcsolodasVege();
            Application.Exit();
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

        private void ujUgyfelHozzaadasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjUgyfelForm ujUgyfel = new UjUgyfelForm();
            ujUgyfel.Show();
            this.Hide();
        }

        private void ugyfelekKezeleseFormClosed(object sender, FormClosedEventArgs e)
        {
            Main foablak = new Main();
            foablak.Show();
        }

        private void dgvUgyfelekAdataiCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sorIndex = e.RowIndex;
            if (sorIndex > -1)
            {
                DataGridViewRow kivalasztottSor = dgvUgyfelekAdatai.Rows[sorIndex];
                lbUgyfelAdatID.Text = kivalasztottSor.Cells[0].Value.ToString();
                grbUgyfelAdatai.Text = kivalasztottSor.Cells[1].Value.ToString() + " adatai:";
                txtUgyfelAdatNev.Text = kivalasztottSor.Cells[1].Value.ToString();
                txtUgyfelAdatIranyitoszam.Text = kivalasztottSor.Cells[2].Value.ToString();
                txtUgyfelAdatVaros.Text = kivalasztottSor.Cells[3].Value.ToString();
                txtUgyfelAdatUtca.Text = kivalasztottSor.Cells[4].Value.ToString();
                txtUgyfelAdatHazszam.Text = kivalasztottSor.Cells[5].Value.ToString();
                txtUgyfelAdatTelefonszam.Text = kivalasztottSor.Cells[6].Value.ToString();

                sql.kapcsolodas();
                /*
                 SELECT ugyfel.Nev, film.Cim FROM ugyfel, film, kolcsonzes 
                 WHERE kolcsonzes.Ugyfel_Id = ugyfel.Ugyfel_Id AND kolcsonzes.Film_Id = film.Film_Id;
                 */
                sqlParancs = "SELECT ugyfel.Nev, film.Cim FROM ugyfel, film, kolcsonzes " +
                    "WHERE kolcsonzes.Ugyfel_Id = ugyfel.Ugyfel_Id AND kolcsonzes.Film_Id = film.Film_Id " +
                    "AND ugyfel.Ugyfel_Id = '" + kivalasztottSor.Cells[0].Value.ToString() + "';";
                dgvKikolcsonzottFilmek.DataSource = sql.tablatoltes(sqlParancs);
                grbKikolcsonzottFilmek.Show();
                sql.kapcsolodasVege();

            }
        }

        private void btnUgyfelAdatokMezokUresseTetele_Click(object sender, EventArgs e)
        {
            mezokKiuritese();
        }

        private void mezokKiuritese()
        {
            lbUgyfelAdatID.Text = "";
            txtUgyfelAdatNev.Clear();
            txtUgyfelAdatIranyitoszam.Clear();
            txtUgyfelAdatVaros.Clear();
            txtUgyfelAdatUtca.Clear();
            txtUgyfelAdatHazszam.Clear();
            txtUgyfelAdatTelefonszam.Clear();
            grbUgyfelAdatai.Text = "Ügyfél adatai:";
        }

        private void btnUgyfelAdatainakModositasa_Click(object sender, EventArgs e)
        {
            if (txtUgyfelAdatNev.Text == "" || txtUgyfelAdatIranyitoszam.Text == "" ||
                txtUgyfelAdatVaros.Text == "" || txtUgyfelAdatUtca.Text == "" ||
                txtUgyfelAdatHazszam.Text == "" || txtUgyfelAdatTelefonszam.Text == "" )
            {
                MessageBox.Show("Nem töltött ki minden mezőt!!!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //UPDATE `ugyfel` SET `Ugyfel_Id`=[value-1],`Nev`=[value-2],`Ir_szam`=[value-3],
                //`Varos`=[value-4],`Utca`=[value-5],`Hazszam`=[value-6],`Tel_sz`=[value-7] WHERE 1
                sqlParancs = "UPDATE ugyfel SET Nev = '" + txtUgyfelAdatNev.Text + "', Ir_szam = '" +
                    txtUgyfelAdatIranyitoszam.Text + "', Varos = '" + txtUgyfelAdatVaros.Text + "', " +
                    "Utca = '" + txtUgyfelAdatUtca.Text + "', Hazszam = '" + txtUgyfelAdatHazszam.Text + "', " +
                    "Tel_sz = '" + txtUgyfelAdatTelefonszam.Text + "' WHERE Ugyfel_Id = '" + lbUgyfelAdatID.Text + "';";
                sql.kapcsolodas();
                sql.beszuras(sqlParancs);
                sqlParancs = "SELECT * FROM ugyfel;";
                dgvUgyfelekAdatai.DataSource = sql.tablatoltes(sqlParancs);
                sql.kapcsolodasVege();
            }
            
        }

        private void ellenorizBetuE(object sender, KeyPressEventArgs e)
        {
            muveletek.textBoxEllenorizBetuE(e);

        }

        private void ellenorizSzamE(object sender, KeyPressEventArgs e)
        {
            muveletek.textBoxEllenorizSzamE(e);
        }

        private void btnUgyfelTorlese_Click(object sender, EventArgs e)
        {
            sqlParancs = "DELETE FROM ugyfel WHERE Ugyfel_Id = '" + lbUgyfelAdatID.Text + "';";
            sql.kapcsolodas();
            sql.torles(sqlParancs);
            sqlParancs = "SELECT * FROM ugyfel;";
            dgvUgyfelekAdatai.DataSource = sql.tablatoltes(sqlParancs);
            sql.kapcsolodasVege();
        }

        private void btnUgyfelKeresNevAlapjan_Click(object sender, EventArgs e)
        {
            sql.kapcsolodas();
            sqlParancs = "SELECT * FROM ugyfel WHERE Nev LIKE \'%" + txtUgyfelKeresNevAlapjan.Text + "%\';";
            dgvUgyfelekAdatai.DataSource = sql.tablatoltes(sqlParancs);
            sql.kapcsolodasVege();
        }
    }
}
