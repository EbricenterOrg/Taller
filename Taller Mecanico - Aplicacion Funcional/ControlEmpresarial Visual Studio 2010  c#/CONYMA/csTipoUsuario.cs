/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase TipoUsuario y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    class csTipoUsuario
    {
        public int giIdTipoUsuario { get; set; }
        public string gsDescripcionTipUsuario { get; set; }

        public csTipoUsuario() { }

        public csTipoUsuario(int pIdTipoUsuario, string pDescripcionTipoUsuario)
        {
            this.giIdTipoUsuario = pIdTipoUsuario;
            this.gsDescripcionTipUsuario = pDescripcionTipoUsuario;
        }
        
    }
}
