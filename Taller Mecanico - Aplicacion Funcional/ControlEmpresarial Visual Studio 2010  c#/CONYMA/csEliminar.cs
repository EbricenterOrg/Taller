using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public class csEliminar
    {
        public static int eliminar(int pIdEmp)
        {
            int iRetorno = 0;
            MySqlCommand cmdEliminar = new MySqlCommand(string.Format("delete from tab_empleado where id_emp = {0}", pIdEmp ), csconectar.conectarse());
            iRetorno = cmdEliminar.ExecuteNonQuery();
            csconectar.conectarse().Close();

            return iRetorno;

        }
    }
}
