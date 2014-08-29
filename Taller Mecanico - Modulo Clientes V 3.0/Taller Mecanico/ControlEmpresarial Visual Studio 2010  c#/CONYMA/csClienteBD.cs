/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 04 Agosto del 2014
 *Comentario: Clase que va a interactuar con la base de datos, tales que esta clase
 *tendra metodos que nos ejecutaran comandos para tener interaccion con la bd
 *(Insert, Update, Delete, Select, etc).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;



namespace EBRICENTER
{
   
    public class csClienteBD
    {
       /*Metodo que nos permite agregar nuevos clientes a la Base de Datos.. */

        public static int Agregar(csCliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_cliente (nombre1_cte, nombre2_cte, apellido1_cte, apellido2_cte, nit_cte, domicilio_cte, telefono_cte, movil_cte, email_cte) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                pCliente.sNombre1_cte, pCliente.sNombre2_cte, pCliente.sApellido1_cte, pCliente.sApellido2_cte, pCliente.snit_cte, pCliente.sDomicilio_cte, pCliente.iTelefono_cte, pCliente.iMovil_cte, pCliente.sEmail_cte), csConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        /*Metodo que nos permite buscar a un cliente por medio una lista*/
        public static List<csCliente> Buscar(string pNombre1_cte, string pApellido1_cte)
        {
            List<csCliente> _lista = new List<csCliente>();

            //Consulta para buscar el cliente
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT id_cte,  nombre1_cte, nombre2_cte,apellido1_cte, telefono_cte, movil_cte, email_cte FROM tab_Cliente  where nombre1_cte ='{0}' or apellido1_cte='{1}'", pNombre1_cte, pApellido1_cte), csConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read()) 
            {
                csCliente pCliente = new csCliente();

                pCliente.iId_cte = _reader.GetInt32(0);
                pCliente.sNombre1_cte = _reader.GetString(1);
                pCliente.sNombre2_cte = _reader.GetString(2);
                pCliente.sApellido1_cte = _reader.GetString(3);
                pCliente.iTelefono_cte = _reader.GetString(4);
                pCliente.iMovil_cte = _reader.GetString(5);
                pCliente.sEmail_cte = _reader.GetString(6);                
                _lista.Add(pCliente);
            }

            return _lista;
        }

        /*Metodo que selecciona u obtiene los datos del cliente para ser modificados o eliminados*/
        public static csCliente ObtenerCliente(int piId_cte)
        {
            csCliente pCliente = new csCliente();
            MySqlConnection conexion = csConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(" SELECT * FROM tab_Cliente where id_cte ={0}", piId_cte), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
                {
                    pCliente.iId_cte = _reader.GetInt32(0);
                    pCliente.sNombre1_cte = _reader.GetString(1);
                    pCliente.sNombre2_cte = _reader.GetString(2);
                    pCliente.sApellido1_cte = _reader.GetString(3);
                    pCliente.sApellido2_cte = _reader.GetString(4);
                    pCliente.snit_cte = _reader.GetString(5);
                    pCliente.sDomicilio_cte = _reader.GetString(6);
                    pCliente.iTelefono_cte = _reader.GetString(7);
                    pCliente.iMovil_cte = _reader.GetString(8);
                    pCliente.sEmail_cte = _reader.GetString(9);
  
                }
            conexion.Close();
            return pCliente;
        }

      /*Obtiene datos de la busqueda para que sean modificados */
        public static int Modificar(csCliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update tab_cliente set nombre1_cte='{0}', nombre2_cte='{1}', apellido1_cte='{2}', apellido2_cte='{3}', nit_cte='{4}', domicilio_cte='{5}', telefono_cte='{6}', movil_cte='{7}', email_cte='{8}'  where id_cte='{9}'",
                pCliente.sNombre1_cte, pCliente.sNombre2_cte, pCliente.sApellido1_cte, pCliente.sApellido2_cte, pCliente.snit_cte, pCliente.sDomicilio_cte, pCliente.iTelefono_cte, pCliente.iMovil_cte, pCliente.sEmail_cte ,pCliente.iId_cte), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        /*Metodo para eliminar cliente*/
        public static int Eliminar(int pId_cte)
        {
            int retorno = 0;
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From tab_cliente where id_cte= {0}", pId_cte), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }
     }
}

