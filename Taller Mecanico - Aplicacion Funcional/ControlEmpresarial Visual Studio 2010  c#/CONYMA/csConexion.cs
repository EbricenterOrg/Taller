/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 04 de Agosto del 2014
 *Comentario: Esto nos servira para tener la conexion de la base de datos en MySQL.
 *          ObtenerConexion: Metodo que conecta a la BD
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public class csConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bdtaller; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}
