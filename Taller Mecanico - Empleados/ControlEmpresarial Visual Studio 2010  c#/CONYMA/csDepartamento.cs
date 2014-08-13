
/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase Departamento y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csDepartamento
    {
        public int giIdDepto { get; set; }
        public string gsDescripcionDepto { get; set; }

        public csDepartamento() { }

        public csDepartamento(int pIddepto, string pDescripciondepto)
        {
            this.giIdDepto = pIddepto;
            this.gsDescripcionDepto = pDescripciondepto;
        }
    }
}
