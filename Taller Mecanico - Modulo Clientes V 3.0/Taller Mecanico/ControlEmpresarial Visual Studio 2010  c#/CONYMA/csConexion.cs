﻿/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 04 de Agosto del 2014
 *Comentario: Esto nos servira para tener la conexion de la base de datos en MySQL.
 *          ObtenerConexion: Metodo que conecta a la BD
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace EBRICENTER
{
    public class csConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=taller2014; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
          /*  MySqlConnection conectar = new MySqlConnection("server=192.168.1.30; database=taller2014; Uid=prueba; pwd=grupo4;");
                conectar.Open();
            return conectar;*/
        }
    }
}