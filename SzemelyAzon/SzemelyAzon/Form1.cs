using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzemelyAzon
{
    public partial class Form1 : Form
    {
        //Személy típusú lista
        private static List<Szemely> szemelyek = new List<Szemely>();

        public Form1()
        {
            InitializeComponent();

            btnSzemelyiAzonositoGeneralas.Enabled = false;
            btnMentes.Hide();

            
            if (File.Exists("adatok.txt"))
            {
                //Kiolvasuk egy adatok tömbbe a sorokat
                string[] adatok = File.ReadAllLines("adatok.txt", Encoding.UTF8);
                

                //Feltöltjük a listát személyek adataival   
                for (int i = 1; i < adatok.Length; i++)
                {
                    szemelyek.Add(new Szemely(adatok[i]));
                }
            }
        }

        private void txtNev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNev_TextChanged(object sender, EventArgs e)
        {
            string minta = "[^\\w]";

            string[] szavak = null;
            int szavakDb = 0;
            szavak = Regex.Split(txtNev.Text, minta, RegexOptions.IgnoreCase);
            for (int i = szavak.GetLowerBound(0); i <= szavak.GetUpperBound(0); i++)
            {
                if (szavak[i].ToString() == string.Empty)
                {
                    szavakDb -= 1;
                }
                szavakDb += 1;
            }
            if (szavakDb >= 2)
            {
                btnSzemelyiAzonositoGeneralas.Enabled = true;
            }
            else
            {
                btnSzemelyiAzonositoGeneralas.Enabled = false;
            }
            

        }

        private void btnSzemelyiAzonositoGeneralas_Click(object sender, EventArgs e)
        {

            if (txtNev.Text == "" || txtIrsz.Text == "" || txtTelepules.Text == "" || txtKoztAdatai.Text == "")
            {
                MessageBox.Show("Nem töltötted ki a következő mezők valamelyikét:\n" +
                        "- Név\n-Irányítószám\n-Település neve\n-Közterület adatai\n\n" +
                        "A személyi azonosító szám addig nem kerül létrehozásra, míg minden" +
                        "itt felsorolt mező kitöltésre nem kerül!", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string szemelyiAzonosito = "";
                szemelyiAzonosito += generalAzonositoKarakter1();
                szemelyiAzonosito += generalAzonositoKarakter27();
                szemelyiAzonosito += generalAzonositoKarakter810();
                szemelyiAzonosito += generalAzonositoKarakter11(szemelyiAzonosito);

                txtSzAzonosito.Text = szemelyiAzonosito;
                txtSzAzonosito.Enabled = false;
                btnMentes.Show();
            }
        }

        private int generalAzonositoKarakter11(string azonosito)
        {  
            DateTime datum1997 = new DateTime(1997, 1, 1);
            DateTime szulDatum = new DateTime(dtpSzulDatum.Value.Year, dtpSzulDatum.Value.Month, dtpSzulDatum.Value.Day);

            int osszehasonlit = DateTime.Compare(datum1997, szulDatum);

            if (osszehasonlit <= 0)
            {
                //1997.január 1 után született b rész
                /*1996. december 31. után születettek esetén a következő műveleteket kell elvégezni:
                Az 1-10. számjegyek mindegyikét meg kell szorozni egy számmal, mégpedig a 10. helyen állót eggyel, 
                a 9. helyen állót kettővel és így tovább. A szorzatokat össze kell adni, és az összeget tizeneggyel 
                elosztani.  Az osztás maradéka a 11. számjeggyel lesz egyenlő. (Mivel a 11-gyel történő osztás maradéka 10 
                is lehet, ebben az esetben a 8-10. számjegy pozíciókban szereplő „sorszámot” 1-gyel növelni kell és így 
                megismételni az imént definiált számítást)
                */
                //szamolOsszegVisszafele(azonosito);
                while (ellenorizMaradek(szamolOsszegVisszafele(azonosito)) == 10)
                {
                    azonosito = azonosito810Novel(azonosito);
                    szamolOsszegVisszafele(azonosito);
                }

                return ellenorizMaradek(szamolOsszegVisszafele(azonosito));
                
            }
            else
            {
                /*1997. január 1. előtt születettek esetén a következő műveleteket kell elvégezni:
                Az első tíz számjegy mindegyikét szorozni kell azzal a sorszámmal, ahányadik helyet foglalja el 
                a személyi azonosítón belül. (Első számjegy szorozva eggyel, a 2. számjegy szorozva kettővel és így tovább.)
                Az így kapott szorzatokat össze kell adni és az összeget tizeneggyel kell osztani. Az osztás maradéka a 11. 
                számjeggyel lesz egyenlő. (Mivel a 11-gyel történő osztás maradéka 10 is lehet, ebben az esetben a 8-10. 
                számjegy pozíciókban szereplő „sorszámot” 1-gyel növelni kell és így megismételni az imént definiált 
                számítást).
                */
                while (ellenorizMaradek(szamolOsszeg(azonosito)) == 10)
                {
                    azonosito = azonosito810Novel(azonosito);
                    szamolOsszeg(azonosito);
                }

                return ellenorizMaradek(szamolOsszeg(azonosito));
            }
        }

        private int szamolOsszegVisszafele(string azonosito)
        {
            int osszeg = 0;
            string elem = "";
            for (int i = 1; i  <= 10; i++)
            {
                elem = azonosito.Substring((10-i), 1);
                osszeg += (i * Convert.ToInt32(elem));
            }
            return osszeg;
        }

        private string azonosito810Novel(string azonosito)
        {
            string reszAzon = azonosito.Substring(7, 3);
            int szamAzon810 = Convert.ToInt32(reszAzon);
            szamAzon810++;
            reszAzon = "" + szamAzon810;
            string nulla = "0";
            StringBuilder sb = new StringBuilder(azonosito);
            if (reszAzon.Length == 1)
            {
                sb[7] = nulla[0];
                sb[8] = nulla[0];
                sb[9] = reszAzon[0];
            }
            else if(reszAzon.Length == 2)
            {
                sb[7] = nulla[0];
                sb[8] = reszAzon[0];
                sb[9] = reszAzon[1];
             }
            else
            {
                sb[7] = reszAzon[0];
                sb[8] = reszAzon[1];
                sb[9] = reszAzon[2];
            }
            
            azonosito = sb.ToString();


            return azonosito;
        }

        private int  ellenorizMaradek(int osszeg)
        {
            return osszeg % 11;
        }

        private int szamolOsszeg(string azonosito)
        {
            int osszeg = 0;
            string elem = "";
            for (int i = 1; i <= 10; i++)
            {
                elem = azonosito.Substring(i - 1, 1);
                osszeg += (i * Convert.ToInt32(elem));
            }
            return osszeg;
        }

        private string generalAzonositoKarakter810()
        {
            /*Létezik-e a fájl?
                IGEN
	                Meg kell nézni, hogy valaki született-e azon a napon?
		                IGEN
	                Akkor ki kell őket gyűjteni egy listába/tömbbe, stb… és megnézni melyik a legnagyobb szám a 8-10 számjegyeknél (MAXKIVÁL)
		                NEM
			                Akkor az első ilyen 8-10 számjegyek a 001-et kapják
                NEM
                	Akkor beállítjuk a 001-et a 8-10 számjegyekhez az adott személynél*/

            if (File.Exists("adatok.txt"))
            {
                
                //Ellenőrzés (Kiírás messageboxba)
                foreach (Szemely szemely in szemelyek)
                {
                    //MessageBox.Show("Azon: "+ szemely.Azonosito
                    //                +"\nNév: " + szemely.Nev 
                    //                +"\nSzületési dátum: " + szemely.SzuletesiDatum
                    //                +"\nLakcím: "+szemely.Iranyitoszam +" "+ szemely.Telepulesnev+" " +szemely.KozteruletAdatai, "");
                }

                //Lista azon azonosítóknak, amelyekben a születési dátum megegyezik, utána ennek vizsgálata
                List<int> azonositokListaja = new List<int>();
                foreach (Szemely szemely in szemelyek)
                {
                    
                    if (szemely.SzuletesiDatum == dtpSzulDatum.Value.ToString("yyyy-MM-dd"))
                    {
                        azonositokListaja.Add(Convert.ToInt32(szemely.Azonosito.Substring(7,3)));
                    }
                    

                }
                if (azonositokListaja.Count == 0)
                {
                    //A fájl létezik, de azon a napon még nem született senki
                    return "001";
                }
                else
                {
                    //Ellenőrzés, hogy az azonosítók listája tartalma rendben van-e
                    //foreach (int azon in azonositokListaja)
                    //{
                        
                    //    MessageBox.Show("Azon: " + azon, "Azonosítók listája");
                    //}


                    int maxReszAzon = azonositokListaja.Max();

                    maxReszAzon++;

                    string maxReszAzonString = "" + maxReszAzon;
                    

                    if (maxReszAzonString.Length == 1)
                    {
                        return "00" + maxReszAzonString;
                    }
                    else if(maxReszAzonString.Length == 2)
                    {
                        return "0" + maxReszAzonString;
                    }
                    else
                    {
                        return maxReszAzonString;
                    }
                }
            }
            else
            {
                //A fájl még nem létezik, így biztos nem tartalmaz születési dátumot arra a dátumra vonatkozólag
                return "001";
            }
        }

        private string generalAzonositoKarakter27()
        {
            /*A 2-7. számjegyeket a nyilvántartott 
             * személy születési évének utolsó két jegyéből, a születés hónapjából és napjából kell képezni.*/

            string ev = ""+dtpSzulDatum.Value.Year;
            ev = ev.Substring(2, 2);
            string honap = "" + dtpSzulDatum.Value.Month;
            if (honap.Length == 1)
            {
                honap = "0" + honap;
            }
            string nap = "" + dtpSzulDatum.Value.Day;
            if (nap.Length == 1)
            {
                nap = "0" + nap;
            }
            
            return ev + honap + nap;
        }

        private string generalAzonositoKarakter1()
        {
           
            DateTime datum1997 = new DateTime(1997, 1, 1);
            DateTime szulDatum = new DateTime(dtpSzulDatum.Value.Year, dtpSzulDatum.Value.Month, dtpSzulDatum.Value.Day);
            
            int osszehasonlit = DateTime.Compare(datum1997, szulDatum);

            if (osszehasonlit <= 0)
            {
                DateTime date1999 = new DateTime(1999, 12, 31);
                osszehasonlit = DateTime.Compare(szulDatum, date1999);
                if (osszehasonlit <= 0)
                {
                    return rdbNo.Checked ? "2" : "1";
                }
                else
                {
                    return rdbNo.Checked ? "4" : "3";
                }
            }
            else
            {
                DateTime datum1900 = new DateTime(1900, 1, 1);
                osszehasonlit = DateTime.Compare(datum1900, szulDatum);
                if (osszehasonlit <= 0)
                {
                    return chbMagyarE.Checked ? (rdbNo.Checked ? "2" : "1") : (rdbNo.Checked ? "6" : "5") ;
                }
                else
                {
                    return chbMagyarE.Checked ? (rdbNo.Checked ? "4" : "3") : (rdbNo.Checked ? "8" : "7");
                }
            }


        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if(File.Exists("adatok.txt")){

                bool tartalmazza = false;

                foreach (Szemely szemely in szemelyek)
                {
                    //MessageBox.Show("Kifejezes:" + (szemely.Nev == txtNev.Text && szemely.SzuletesiDatum == dtpSzulDatum.Value.ToString("yyy-MM-dd") &&
                    //       szemely.Iranyitoszam == txtIrsz.Text && szemely.Telepulesnev == txtTelepules.Text &&
                    //       szemely.KozteruletAdatai == txtKoztAdatai.Text) + "\n" +
                    //       "Név: "+ szemely.Nev +" - "+ txtNev.Text + "\n"+
                           
                    //       "Dátum: "+ szemely.SzuletesiDatum + " - " + dtpSzulDatum.Value.ToString("yyy-MM-dd") + "\n" +
                    //       "Irsz: "+ szemely.Iranyitoszam + " - " + txtIrsz.Text + "\n" +
                    //       "Településnév: "+ szemely.Telepulesnev + " - " + txtTelepules.Text + "\n" +
                    //       "Közterület adatai: "+ szemely.KozteruletAdatai + " - " + txtKoztAdatai.Text + "\n" 
                    //       , "Kifejezés");
                    if (szemely.Nev == txtNev.Text && szemely.SzuletesiDatum == dtpSzulDatum.Value.ToString("yyy-MM-dd") &&
                        szemely.Iranyitoszam == txtIrsz.Text && szemely.Telepulesnev == txtTelepules.Text && 
                        szemely.KozteruletAdatai == txtKoztAdatai.Text)
                    {
                        MessageBox.Show("A megadott személy adatait már tartalmazza az adatokat tartalmazó fájl",
                            "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tartalmazza = true;
                        break;
                    }
                }
                //MessageBox.Show("Tartalmazza változót: " + tartalmazza, "TArtalmaz");
                
                if (tartalmazza == false)
                {
                    string nem;
                    string allampolg;
                    nem = rdbNo.Checked ? "Nő" : "Férfi";
                    allampolg = chbMagyarE.Checked ? "Magyar" : "Nem magyar";
                    string szoveg = "";

                    szoveg += $"{txtSzAzonosito.Text};{txtNev.Text};{dtpSzulDatum.Value.ToString("yyyy-MM-dd")};{nem};{allampolg};{txtIrsz.Text};{txtTelepules.Text};{txtKoztAdatai.Text}\r\n";

                    File.AppendAllText("adatok.txt", szoveg);

                    if (uzenet() == DialogResult.Yes)
                    {
                        txtNev.Text = "";
                        rdbNo.Checked = true;
                        dtpSzulDatum.Value = DateTime.Now;
                        chbMagyarE.Checked = false;
                        txtIrsz.Text = "";
                        txtTelepules.Text = "";
                        txtKoztAdatai.Text = "";
                        btnSzemelyiAzonositoGeneralas.Enabled = false;
                        btnMentes.Hide();
                        txtSzAzonosito.Text = "";

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                
            }
            else
            {
                string nem;
                string allampolg;
                nem = rdbNo.Checked ? "Nő" : "Férfi";
                allampolg = chbMagyarE.Checked ? "Magyar" : "Nem magyar";

                string szoveg = "";
                szoveg += "Szemelyi azonosito;Név;Nem;Születési dátum; Állampolgárság; Irányítószám; Település; Közterület adatai\r\n";
                szoveg += $"{txtSzAzonosito.Text};{txtNev.Text};{dtpSzulDatum.Value.ToString("yyyy-MM-dd")};{nem};{allampolg};{txtIrsz.Text};{txtTelepules.Text};{txtKoztAdatai.Text}\r\n";
                File.WriteAllText("adatok.txt", szoveg);
                if (uzenet() == DialogResult.Yes)
                {
                    txtNev.Text = "";
                    rdbNo.Checked = true;
                    dtpSzulDatum.Value = DateTime.Now;
                    chbMagyarE.Checked = false;
                    txtIrsz.Text = "";
                    txtTelepules.Text = "";
                    txtKoztAdatai.Text = "";
                    btnSzemelyiAzonositoGeneralas.Enabled = false;
                    btnMentes.Hide();
                    txtSzAzonosito.Text = "";

                }
                else
                {
                    Application.Exit();
                }
            }
        
        }

        private DialogResult uzenet()
        {
            DialogResult uzenet = MessageBox.Show("A személy adatai mentésre kerültek!" +
                                        "\nSzeretne új személy adatait felvinni?\n" +
                                        "Ha igen, akkor kattintson az \"Igen\" gombra!\n" +
                                        "A \"Nem\" gombra kattintás esetén a program bezáródik!","Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return uzenet;
        }
    }
}
