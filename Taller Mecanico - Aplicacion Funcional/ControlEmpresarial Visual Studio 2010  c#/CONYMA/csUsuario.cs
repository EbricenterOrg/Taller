/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase Usuario y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
   public class csUsuario
    {
        public int giIdUsuario;
        public string gsUsuario;
        public string gsContraseña;
        public int giIdEmpUsuario;
        public int giIdTipoUsuario;

        public csUsuario() { }

        public csUsuario(int pidUsuario, string pUsuario, string pContraseña, int pIdempusuario, int pIdtipusuario)
        {
            this.giIdEmpUsuario = pidUsuario;
            this.gsUsuario = pUsuario;
            this.gsContraseña = pContraseña;
            this.giIdEmpUsuario = pIdempusuario;
            this.giIdTipoUsuario = pIdtipusuario;

        }
    }
}
