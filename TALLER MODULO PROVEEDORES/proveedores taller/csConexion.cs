//elaborado por cesar flores


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace proveedores_taller
{
    class csConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=BasedeDatosTallerM; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}
