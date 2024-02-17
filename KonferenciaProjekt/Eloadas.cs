using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace KonferenciaProjekt
{
    internal class Eloadas
    {

        readonly int eloadasid; //csak olvasható legyen

        string cim;
        int sorok;  //sorDb;
        int szekek; //helyDb;
        int[,] ertekeles;
        //itt constructor generálása//



        //az adattagokhoz készítsen get property-ket //
        public int Eloadasid => eloadasid;
        public string Cim { get => cim; set => cim = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }



        //paraméteres konstruktor létrejött, amely a paraméterek értékével inicializálja az adattagokat  //
        public Eloadas(int eloadasid, string cim, int sorok, int szekek)
        {
            this.eloadasid = eloadasid;
            this.Cim = cim;
            this.Sorok = sorok;     //sorDb
            this.Szekek = szekek;   //helyDb
            this.ertekeles = new int[sorok, szekek];
        }


        //a helyes adatkiolvasas miatt -1el el kell csúsztatni a tömbünket
        internal void SorSzekInformacio(int sor, int szek, int ertekeles)
        {
            this.ertekeles[sor -1, szek -1 ] = ertekeles;
        }

    }
}
