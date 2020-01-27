using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyAzon
{
    class Szemely
    {
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public string SzuletesiDatum { get; set; }
        public string Iranyitoszam { get; set; }
        public string Telepulesnev { get; set; }
        public string KozteruletAdatai { get; set; }

        public Szemely(string sor)
        {
            string[] s = sor.Split(';');
            Azonosito = s[0];
            Nev = s[1];
            SzuletesiDatum = s[2];
            Iranyitoszam = s[5];
            Telepulesnev = s[6];
            KozteruletAdatai = s[7];
        }
    }
}
