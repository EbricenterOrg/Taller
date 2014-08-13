/*Autor: Roberto Alexander Grave Vicente
  Fecha: 12/08/2014
  Comentario: Boton Guardar Empleado*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    class csBuscarDatos
    {
        public static List<csEmpleado> buscar(int pId_Emp)
        {
            List<csEmpleado> lista = new List<csEmpleado>();

            MySqlCommand cmdBusqueda = new MySqlCommand(string.Format("select * from tab_empleado inner join tabt_det_emp on id_emp = idempleado_detemp where id_emp = '{0}'", pId_Emp), csconectar.conectarse());
            MySqlDataReader leer = cmdBusqueda.ExecuteReader();

            while (leer.Read())
            {
                csEmpleado obEmpleado = new csEmpleado();
                obEmpleado.giIdEmpleado = leer.GetInt32(0);
                obEmpleado.gsNombre1 = leer.GetString(1);
                obEmpleado.gsNombre2 = leer.GetString(2);
                obEmpleado.gsApellido1 = leer.GetString(3);
                obEmpleado.gsApellido2 = leer.GetString(4);
                obEmpleado.gsFechaAlta = leer.GetString(5);
                obEmpleado.gsFechaBaja = leer.GetString(6);
                obEmpleado.giSalario = leer.GetInt32(7);
                obEmpleado.giIdDepto = leer.GetInt32(8);
                obEmpleado.giIdJornada = leer.GetInt32(9);
                obEmpleado.gsDomicilioEmp = leer.GetString(10);
                obEmpleado.gsTelefonoEmp = leer.GetString(11);
                obEmpleado.gsMovilEmp = leer.GetString(12);
                obEmpleado.gsEmailEmp = leer.GetString(13);

                lista.Add(obEmpleado);
            }

            return lista;
        }


        public static csEmpleado obtener(int pIdEmp)
        {
            csEmpleado obSelectEmp = new csEmpleado();
            //MySqlConnection conn = csconectar.conectarse();

            MySqlCommand cmdObtener = new MySqlCommand(string.Format("select * from tab_empleado inner join tabt_det_emp on id_emp = idempleado_detemp where id_emp = {0}", pIdEmp), csconectar.conectarse());

            MySqlDataReader leer = cmdObtener.ExecuteReader();

            while (leer.Read())
            {
                obSelectEmp.giIdEmpleado = leer.GetInt32(0);
                obSelectEmp.gsNombre1 = leer.GetString(1);
                obSelectEmp.gsNombre2 = leer.GetString(2);
                obSelectEmp.gsApellido1 = leer.GetString(3);
                obSelectEmp.gsApellido2 = leer.GetString(4);
                obSelectEmp.gsFechaAlta = leer.GetString(5);
                obSelectEmp.gsFechaBaja = leer.GetString(6);
                obSelectEmp.giSalario = leer.GetInt32(7);
                obSelectEmp.giIdDepto = leer.GetInt32(8);
                obSelectEmp.giIdJornada = leer.GetInt32(9);
                obSelectEmp.gsDomicilioEmp = leer.GetString(10);
                obSelectEmp.gsTelefonoEmp = leer.GetString(11);
                obSelectEmp.gsMovilEmp = leer.GetString(12);
                obSelectEmp.gsEmailEmp = leer.GetString(13);
            }

            csconectar.conectarse().Close();
            return obSelectEmp;

        }



    }
}
