/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase TipoServicio y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csTipoServicio
    {
        public int giIdServicio { get; set; }
        public string gsDescripcionTipServ { get; set; }

        public csTipoServicio() { }

        public csTipoServicio(int pIdServicio, string pDescripcionTipServ)
        {
            this.giIdServicio = pIdServicio;
            this.gsDescripcionTipServ = pDescripcionTipServ;
        }
    }
}
