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
    public partial class KolcsonzesekKezeleseForm : Form
    {
        SQLUtasitasok sql = new SQLUtasitasok();
        MezoMuveletek muveletek = new MezoMuveletek();
        string sqlParancs;

        public KolcsonzesekKezeleseForm()
        {
            InitializeComponent();
            kolcsonzesekKezeleseToolStripMenuItem.Enabled = false;

        }

        private void KolcsonzesekKezeleseClosed(object sender, FormClosedEventArgs e)
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

        private void ujUgyfelHozzaadasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjUgyfelForm ujUgyfel = new UjUgyfelForm();
            ujUgyfel.Show();
            this.Hide();
        }

        private void KolcsonzesekKezeleseForm_Load(object sender, EventArgs e)
        {
            lbKolcsonzesID.Text = "";
            lbKolcsonzesID.Hide();
            listView1.Hide();
            dgvKolcsonzesek.Height = 218;
            dgvKolcsonzesek.Location = new Point(this.dgvKolcsonzesek.Location.X,100);

            sql.kapcsolodas();
            sqlParancs = "SELECT Kolcsonzes_Id AS Azonosito, ugyfel.Ugyfel_Id, film.Film_Id, Nev AS 'Ugyfel neve', " +
                "CONCAT(Cim,' (',Adathordozo,')') AS Film, Ar, Kolcsonzes_nap AS Nap, Kolcsonzes_datum AS Datum  " +
                "FROM kolcsonzes, film, ugyfel " +
                "WHERE kolcsonzes.Film_Id = film.Film_Id AND kolcsonzes.Ugyfel_Id = ugyfel.Ugyfel_ID " +
                "ORDER BY Kolcsonzes_Id DESC;";
            dgvKolcsonzesek.DataSource = sql.tablatoltes(sqlParancs);
            dgvKolcsonzesek.Columns[1].Visible = false;
            dgvKolcsonzesek.Columns[2].Visible = false;

            //Név ComboBox:
            sql.kapcsolodas();
            DataTable nevekTabla = new DataTable();
            sqlParancs = "SELECT * FROM ugyfel ORDER BY Nev;";
            nevekTabla = sql.tablatoltes(sqlParancs);
            cmbUgyfelNevek.DataSource = nevekTabla;
            DataRow sor = nevekTabla.NewRow();
            sor["Ugyfel_Id"] = "0";
            sor["Nev"] = "--Nincs Kiválasztva--";
            nevekTabla.Rows.InsertAt(sor, 0);
            cmbUgyfelNevek.DisplayMember = "Nev";
            cmbUgyfelNevek.ValueMember = "Ugyfel_Id";
            cmbUgyfelNevek.SelectedIndex = 0;

            //Filmek
            DataTable filmekTabla = new DataTable();
            sqlParancs = "SELECT Film_Id, CONCAT(Cim,' (',Adathordozo,')') AS Cim FROM film ORDER BY Cim;";
            filmekTabla = sql.tablatoltes(sqlParancs);
            cmbFilmek.DataSource = filmekTabla;
            sor = filmekTabla.NewRow();
            sor["Film_Id"] = "0";
            sor["Cim"] = "--Nincs Kiválasztva--";
            filmekTabla.Rows.InsertAt(sor, 0);
            cmbFilmek.DisplayMember = "Cim";
            cmbFilmek.ValueMember = "Film_Id";
            cmbFilmek.SelectedIndex = 0;

            sql.kapcsolodasVege();
        }

        private void dgvKolcsonzesek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sorIndex = e.RowIndex;

            if (sorIndex > -1)
            {
                DataGridViewRow kivalasztottSor = dgvKolcsonzesek.Rows[sorIndex];
                lbKolcsonzesID.Text = kivalasztottSor.Cells[0].Value.ToString();
                cmbUgyfelNevek.SelectedValue = kivalasztottSor.Cells[1].Value.ToString();
                cmbFilmek.SelectedValue = kivalasztottSor.Cells[2].Value.ToString();
                txtKolcsonzesiDij.Text = kivalasztottSor.Cells[5].Value.ToString();
                nudKolcsonzesiIdo.Value = Convert.ToInt32(kivalasztottSor.Cells[6].Value.ToString());
                dtpKolcsonzesiDatum.Value = Convert.ToDateTime(kivalasztottSor.Cells[7].Value.ToString());

            }
        }

        private void btnMezokUresseTetele_Click(object sender, EventArgs e)
        {
            mezokKiuritese();
            
        }

        private void mezokKiuritese()
        {
            lbKolcsonzesID.Text = "";
            cmbUgyfelNevek.SelectedIndex = 0;
            cmbFilmek.SelectedIndex = 0;
            txtKolcsonzesiDij.Clear();
            nudKolcsonzesiIdo.Value = 0;
            dtpKolcsonzesiDatum.Value = DateTime.Today;
        }

        private void btnAdatokModositasa_Click(object sender, EventArgs e)
        {
            sql.kapcsolodas();
            sqlParancs = "UPDATE kolcsonzes SET " +
                "Film_Id = '" + cmbFilmek.SelectedValue + "', Ugyfel_Id = '" + cmbUgyfelNevek.SelectedValue + "', " +
                "Ar = '" + txtKolcsonzesiDij.Text + "', Kolcsonzes_nap = '" + nudKolcsonzesiIdo.Value + "', " +
                "Kolcsonzes_datum = '" + dtpKolcsonzesiDatum.Value + "' " +
                "WHERE Kolcsonzes_Id = '" + lbKolcsonzesID.Text + "';";
            sql.modositas(sqlParancs);
            sqlParancs = "SELECT Kolcsonzes_Id AS Azonosito, ugyfel.Ugyfel_Id, film.Film_Id, Nev AS 'Ugyfel neve', " +
                "CONCAT(Cim,' (',Adathordozo,')') AS Film, Ar, Kolcsonzes_nap AS Nap, Kolcsonzes_datum AS Datum  " +
                "FROM kolcsonzes, film, ugyfel " +
                "WHERE kolcsonzes.Film_Id = film.Film_Id AND kolcsonzes.Ugyfel_Id = ugyfel.Ugyfel_ID " +
                "ORDER BY Kolcsonzes_Id DESC;";
            dgvKolcsonzesek.DataSource = sql.tablatoltes(sqlParancs);
            dgvKolcsonzesek.Columns[1].Visible = false;
            dgvKolcsonzesek.Columns[2].Visible = false;
            sql.kapcsolodasVege();
            mezokKiuritese();
        }

        private void btnKolcsonzesTorlese_Click(object sender, EventArgs e)
        {
            sql.kapcsolodas();
            if (lbKolcsonzesID.Text != "")
            {
                sqlParancs = "DELETE FROM kolcsonzes WHERE Kolcsonzes_Id = '" + lbKolcsonzesID.Text + "';";
                sql.torles(sqlParancs);

                sqlParancs = "SELECT Kolcsonzes_Id AS Azonosito, ugyfel.Ugyfel_Id, film.Film_Id, Nev AS 'Ugyfel neve', " +
                "CONCAT(Cim,' (',Adathordozo,')') AS Film, Ar, Kolcsonzes_nap AS Nap, Kolcsonzes_datum AS Datum  " +
                "FROM kolcsonzes, film, ugyfel " +
                "WHERE kolcsonzes.Film_Id = film.Film_Id AND kolcsonzes.Ugyfel_Id = ugyfel.Ugyfel_ID " +
                "ORDER BY Kolcsonzes_Id DESC;";
                dgvKolcsonzesek.DataSource = sql.tablatoltes(sqlParancs);
                dgvKolcsonzesek.Columns[1].Visible = false;
                dgvKolcsonzesek.Columns[2].Visible = false;
                sql.kapcsolodasVege();
                mezokKiuritese();
            }
            else
            {
                MessageBox.Show("Törléshez előbb ki kell választania egy kölcsönzést!", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnKeres_Click(object sender, EventArgs e)
        {
            dgvKolcsonzesek.Location = new Point(this.dgvKolcsonzesek.Location.X, 154);
            dgvKolcsonzesek.Height = 150;
            listView1.Show();
            listView1.View = View.Details;

            sql.kapcsolodas();
            //sqlParancs = "SELECT * FROM kolcsonzes WHERE Kolcsonzes_Id LIKE '%" + txtKolcsonzesId.Text + "%';";
            sqlParancs = "SELECT Kolcsonzes_Id, Nev, CONCAT(Cim,' (',Adathordozo,')') AS Film, Ar,  " +
                "Kolcsonzes_nap, Kolcsonzes_datum " +
                "FROM kolcsonzes NATURAL JOIN film NATURAL JOIN ugyfel WHERE Kolcsonzes_Id lIKE '" + txtKolcsonzesId.Text + "';";
            DataTable kolcsonzesDT = sql.tablatoltes(sqlParancs);

         

            for (int i = 0; i < kolcsonzesDT.Rows.Count; i++)
            {
                DataRow sor = kolcsonzesDT.Rows[i];
                ListViewItem elem = new ListViewItem(sor["Kolcsonzes_Id"].ToString());

                elem.SubItems.Add(sor["Nev"].ToString());
                elem.SubItems.Add(sor["Film"].ToString());
                elem.SubItems.Add(sor["Ar"].ToString());
                elem.SubItems.Add(sor["Kolcsonzes_nap"].ToString());
                elem.SubItems.Add(sor["Kolcsonzes_datum"].ToString().Substring(0,11));

                listView1.Items.Add(elem);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            sql.kapcsolodasVege();
        }
    }
}
