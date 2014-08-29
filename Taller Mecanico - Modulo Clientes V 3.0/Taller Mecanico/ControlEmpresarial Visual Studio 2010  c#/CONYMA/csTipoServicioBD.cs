/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 27 Agosto del 2014
 *Comentario: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public class csTipoServicioBD
    {
        public static int Agregar(csTipoServicio pTipoServicio)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into tab_tiposervicio(descripcion_tserv, precio_tserv) values ('{0}','{1}')", 
                pTipoServicio.sDescripcion_serv, pTipoServicio.sPrecio_serv), csConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
