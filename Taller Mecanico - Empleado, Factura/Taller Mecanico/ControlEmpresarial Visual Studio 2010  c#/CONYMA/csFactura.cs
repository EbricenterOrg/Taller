using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    class csFactura
    {
        public int gIdFact { get; set; }
        public string gFechaFact { get; set; }
        public int gIdCtefact { get; set; }
        public int gIdfactdet { get; set; }
        public int gIdServFact { get; set; }
        public int gIdRepFact { get; set; }
        public int gValorFact { get; set; }

        public csFactura() { }

        public csFactura(int pIdfact, string pFechFact, int pIdCteFact, int pIdfacDet, int pIdSerFact, int pIdRepFact, int pValor)
        {
            this.gIdFact = pIdfact;
            this.gFechaFact = pFechFact;
            this.gIdCtefact = pIdCteFact;
            this.gIdfactdet = pIdfacDet;
            this.gIdServFact = pIdSerFact;
            this.gIdRepFact = pIdRepFact;
            this.gValorFact = pValor;
        }


    }
}
