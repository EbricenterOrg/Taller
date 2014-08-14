//elaborado por abner rodas


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace proveedores_taller
{
    class csProveedorBD
    {
        public static int Agregar(csProveedor pcsProveedor)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into clientes (id_prov, nombre_prov) values ('{0}','{1}')",
                pcsProveedor.Id, pcsProveedor.nombre), csConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<csProveedor> Buscar(string pId, string pNombre)
        {
            List<csProveedor> _lista = new List<csProveedor>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT id_prov, Nombre_prov FROM tab_proveedor  where id_prov ='{0}' or nombre_prov='{1}'", pId, pNombre), csConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                csProveedor pcsProveedor = new csProveedor();
                pcsProveedor.Id = _reader.GetString(0);
                pcsProveedor.nombre = _reader.GetString(1);
             
                _lista.Add(pcsProveedor);
            }

            return _lista;
        }


        public static csProveedor ObtenerProveedor(string pId)
        {
            csProveedor pcsProveedor = new csProveedor();
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT id_prov, nombre_prov FROM tab_proveedor where id_prov={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pcsProveedor.Id = _reader.GetString(0);
                pcsProveedor.nombre = _reader.GetString(1);
            }

            conexion.Close();
            return pcsProveedor;

        }



        public static int Actualizar(csProveedor pcsProveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update clientes set id_prov='{0}', nombre_prov='{1}' where id_prov={4}",
                pcsProveedor.Id, pcsProveedor.nombre), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

            }
}
