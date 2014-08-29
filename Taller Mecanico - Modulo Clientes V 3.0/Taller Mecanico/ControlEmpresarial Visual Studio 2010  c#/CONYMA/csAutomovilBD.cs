/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 27/08/2014
 *Comentario: Clase que tendra la interaccion con la base de datos de Automovil.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
   public class csAutomovilBD
    {
        /*Metodo que nos permite agregar registro de vehiculos a la Base de Datos.. */
        public static int Agregar(csAutomovil pAutomovil)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into tab_automovil (matricula_auto, marca_auto, modelo_auto, tipo_auto, color_auto, kilometros_auto, numpolisa_auto, idcliente_auto) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}') ",
               pAutomovil.sMatricula_auto, pAutomovil.sMarca_auto, pAutomovil.sModelo_auto, pAutomovil.sTipo_auto, pAutomovil.sColor_auto, pAutomovil.sKim_auto, pAutomovil.sNumPolisa_auto, pAutomovil.iIdcte_auto), csConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
/*
       //Modifica Registro de Vehiculo 
       public static int Modificar(csAutomovil pAuto)
        {
            int retorno = 0;
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update tab_automovil set matricula_auto='{0}', marca_auto='{1}', modelo_auto='{2}', tipo_auto='{3}', color_auto='{4}', kilometros_auto='{5}', numpolisa_auto='{6}' where idcliente_auto='{7}' AND id_auto='{8}'",
                pAuto.sMatricula_auto, pAuto.sMarca_auto, pAuto.sModelo_auto, pAuto.sTipo_auto, pAuto.sColor_auto, pAuto.sKim_auto, pAuto.sNumPolisa_auto, pAuto.iIdcte_auto, pAuto.iId_auto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }
    */
   }

}
