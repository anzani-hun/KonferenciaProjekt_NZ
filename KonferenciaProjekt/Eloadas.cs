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
        string cim;
        int sorDb;
        int helyDb;
        int[,] ertekeles;
        //itt constructor generálása//



        //az adattagokhoz készítsen get property-ket //
        public string Cim { get => cim; set => cim = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }



        //paraméteres konstruktor létrejött, amely a paraméterek értékével inicializálja az adattagokat  //
        public Eloadas(string cim, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.cim = cim;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }


    }
}
