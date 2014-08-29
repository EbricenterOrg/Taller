
/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase Automovil y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    class csAutomovil
    {
        public int giIdAuto { get; set; }
        public string gsMatricula { get; set; }
        public int giModeloAuto { get; set; }
        public string gsColorAuto { get; set; }
        public string gsStadoAuto { get; set; }
        public string gsKmsAuto { get; set; }
        public string gsNumPolisa { get; set; }
        public int giIdClienteAuto { get; set; }

        public csAutomovil() { }

        public csAutomovil(int pIdAuto, string pMatricula, int pModeloAuto, string pColorAuto, string pStadoAuto, string pKmsAuto, string pNumPolisa, int pIdClienteAuto )
        {
            this.giIdAuto = pIdAuto;
            this.gsMatricula = pMatricula;
            this.giModeloAuto = pModeloAuto;
            this.gsColorAuto = pColorAuto;
            this.gsStadoAuto = pStadoAuto;
            this.gsKmsAuto = pKmsAuto;
            this.gsNumPolisa = pNumPolisa;
            this.giIdClienteAuto = pIdClienteAuto; 
        }

    }
}
