using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonferenciaProjekt
{
    internal class Konferencia
    {

        // az előadások adattag egy "ELOADAS" típusú objektumokat tartalmazó lista, ami lehetővé teszi a konferencia összes előadás kezelését
        List<Eloadas> eloadasok;
        public List<Eloadas> Eloadasok { get => eloadasok; }


        public Konferencia()
        {
            eloadasok = new List<Eloadas>();

        }










    }

    
}
