/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: Conexion a la Base de Datos bdtaller*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    class csconectar
    {

        public static MySqlConnection conectarse()
        {
            MySqlConnection Mscconn = new MySqlConnection("server=127.0.0.1; database=taller2014; uid=root; pwd=;");
            Mscconn.Open();
            return Mscconn;
        }
    }
}
