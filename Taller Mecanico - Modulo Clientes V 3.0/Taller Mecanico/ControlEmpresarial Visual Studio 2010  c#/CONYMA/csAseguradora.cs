
/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase Aseguradora y Creación de Constructor*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csAseguradora
    {
        public int giIdAseg;
        public string gsDescripcionAseg;
        public int giIdAutoAseg;

        public csAseguradora() { }

        public csAseguradora(int pIdaseg, string pDescripcionAseg, int pIdAuto)
        {
            this.giIdAseg = pIdaseg;
            this.gsDescripcionAseg = pDescripcionAseg;
            this.giIdAutoAseg = pIdAuto;
        }
    }
}
