using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csRepuesto
    {
        public int gIdRep { get; set; }
        public string gdesRep { get; set; }
        public string gMarcaRep { get; set; }
        public int gPrecioRep { get; set; }
        public int gExistRep { get; set; }
        public int gIdProvRep { get; set; }

        public csRepuesto() { }

        public csRepuesto(int pIdRep, string pDesrep, string pMarcaRep, int pPrecioRep, int pgExisRep, int pIdProvRep )
        {

            this.gIdRep = pIdRep;
            this.gdesRep = pDesrep;
            this.gMarcaRep = pMarcaRep;
            this.gPrecioRep = pPrecioRep;
            this.gExistRep = pgExisRep;
            this.gIdProvRep = pIdProvRep;
        }
    }
}
