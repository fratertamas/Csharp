using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VideoKolcsonzo
{
    class SQLUtasitasok
    {
        String connectionstring;
        MySqlConnection con;

        // EZ EGY ELJÁRÁS! KAPCSÓLÓDUNK A MYSQL-hez!
        public void kapcsolodas() 
        {
            try
            {
                connectionstring = "datasource = localhost; DataBase = videokolcsonzo; username = root; password = ";
                con = new MySqlConnection(connectionstring);
                con.Open();

                if (con.State != ConnectionState.Open)
                {
                    MessageBox.Show("NEM TUDOTT KAPCSOLÓDNI!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable tablatoltes(string sqlParancs)
        {
            DataTable dtTabla = new DataTable();                              
            MySqlCommand listakeszit = new MySqlCommand(sqlParancs, con);    
            MySqlDataReader megnyit = listakeszit.ExecuteReader();  
            dtTabla.Load(megnyit);

            return dtTabla;

        }

        public string beszuras(string sqlParancs)
        {
            MySqlCommand beszuras = new MySqlCommand(sqlParancs, con);
            try
            {
                if (beszuras.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Adatok rögzítve");
                    return "OK";
                }
                else
                {
                    //MessageBox.Show("Az adatok rögzítése nem valósult meg!");
                    return "NEM OK";
                }


            }
            catch (Exception)
            {
                return "Az adatbázis szerver lezárta a kapcsolatot!";
            }
        }

        //public void beszuras(string sqlParancs)
        //{
        //    MySqlCommand beszuras = new MySqlCommand(sqlParancs, con);
        //    try
        //    {
        //        if (beszuras.ExecuteNonQuery() == 1)
        //        {
        //            MessageBox.Show("Adatok rögzítve");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Az adatok rögzítése nem valósult meg!");
        //        }


        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Az adatbázis szerver lezárta a kapcsolatot!");
        //    }
        //}

        public void modositas(string sqlParancs)
        {
            try
            {
                MySqlCommand frissites = new MySqlCommand(sqlParancs, con);
                if (frissites.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Adatok frissítve");
                }
                else
                {
                    MessageBox.Show("Az adatok frissítése eredménytelen");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void torles(string sqlParancs)
        {
            MySqlCommand command = new MySqlCommand(sqlParancs, con);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A törlés sikeres volt!");
            }
            else
            {
                MessageBox.Show("A törlés sikertelen volt!");
            }
        }

        public void kapcsolodasVege()
        {
            con.Close();
        }
    }
}
