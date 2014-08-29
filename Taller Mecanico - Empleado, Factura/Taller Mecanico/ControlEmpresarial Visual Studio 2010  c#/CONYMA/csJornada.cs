/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase Jornada y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
   public class csJornada
    {
        public int giIdJornada;
        public string gsDescripcionJ;

        public csJornada() { }

        public csJornada(int pIdjornada, string pDescripcionj)
        {
            this.giIdJornada = pIdjornada;
            this.gsDescripcionJ = pDescripcionj;
        }
    }
}
