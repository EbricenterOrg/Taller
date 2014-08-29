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
   public class csBuscarDatos
    {
        public static List<csEmpleado> buscar(string pId_Emp, string pNomEmp)
        {
            //PARA DESPLEGAR LOS REGISTROS EN EL DATAGRID

            List<csEmpleado> lista = new List<csEmpleado>();

            MySqlCommand cmdBusqueda = new MySqlCommand(string.Format("select id_emp as 'Codigo', nombre1_emp, nombre2_emp, apellido1_emp, apellido2_emp, fechaalta_emp, fechabaja_emp, salario_emp, domicilio_emp, telefono_emp, movil_emp, email_emp,iddepartament_emp, idjornada_emp from tab_empleado where id_emp = '{0}' or nombre1_emp like '%{1}%'", pId_Emp, pNomEmp), csconectar.conectarse());
            MySqlDataReader leer = cmdBusqueda.ExecuteReader();

            while (leer.Read())
            {
                csEmpleado obEmpleado = new csEmpleado();
                obEmpleado.giIdEmpleado = leer.GetString(0);
                obEmpleado.gsNombre1 = leer.GetString(1) + " " + leer.GetString(2) + " " + leer.GetString(3) + " " + leer.GetString(4);
               /*obEmpleado.gsNombre2 = leer.GetString(2);
                obEmpleado.gsApellido1 = leer.GetString(3);
                obEmpleado.gsApellido2 = leer.GetString(4);*/
                obEmpleado.gsFechaAlta = leer.GetString(5);
                obEmpleado.gsFechaBaja = leer.GetString(6);
                obEmpleado.giSalario = leer.GetInt32(7);
                obEmpleado.gsDomicilioEmp = leer.GetString(8);
                obEmpleado.gsTelefonoEmp = leer.GetString(9);
                obEmpleado.gsMovilEmp = leer.GetString(10);
                obEmpleado.gsEmailEmp = leer.GetString(11);
                obEmpleado.giIdDepto = leer.GetInt32(12);
                obEmpleado.giIdJornada = leer.GetInt32(13);

                lista.Add(obEmpleado);
            }

            return lista;
        }


        public static csEmpleado obtener(int pIdEmp)
        {
             //ENVIA LOS DATOS AL FORMULARIO
            csEmpleado obSelectEmp = new csEmpleado();
            //MySqlConnection conn = csconectar.conectarse();

            MySqlCommand cmdObtener = new MySqlCommand(string.Format("select * from tab_empleado where id_emp = '{0}'", pIdEmp), csconectar.conectarse());

            MySqlDataReader leer = cmdObtener.ExecuteReader();

            while (leer.Read())
            {
                obSelectEmp.giIdEmpleado = leer.GetString(0);
                obSelectEmp.gsNombre1 = leer.GetString(1);
                obSelectEmp.gsNombre2 = leer.GetString(2);
                obSelectEmp.gsApellido1 = leer.GetString(3);
                obSelectEmp.gsApellido2 = leer.GetString(4);
                obSelectEmp.gsFechaAlta = leer.GetString(5);
                obSelectEmp.gsFechaBaja = leer.GetString(6);
                obSelectEmp.giSalario = leer.GetInt32(7);
                obSelectEmp.gsDomicilioEmp = leer.GetString(8);
                obSelectEmp.gsTelefonoEmp = leer.GetString(9);
                obSelectEmp.gsMovilEmp = leer.GetString(10);
                obSelectEmp.gsEmailEmp = leer.GetString(11);
                obSelectEmp.giIdDepto = leer.GetInt32(12);
                obSelectEmp.giIdJornada = leer.GetInt32(13);

            }

            csconectar.conectarse().Close();
            return obSelectEmp;

        }




        public static List<csRepuesto> buscar_Rep(int pId_Rep, string pDesRep)
        {
            //PARA DESPLEGAR LOS REGISTROS EN EL DATAGRID

            List<csRepuesto> lista = new List<csRepuesto>();

            MySqlCommand cmdBusqueda = new MySqlCommand(string.Format("select * from tab_repuesto where id_repto = '{0}' or descripcion_repto like '%{1}%'", pId_Rep, pDesRep), csconectar.conectarse());
            MySqlDataReader leer = cmdBusqueda.ExecuteReader();

            while (leer.Read())
            {
                csRepuesto obRepuesto = new csRepuesto();
                obRepuesto.gIdRep = leer.GetInt32(0);
                obRepuesto.gdesRep = leer.GetString(1);
                obRepuesto.gMarcaRep = leer.GetString(2);
                obRepuesto.gPrecioRep = leer.GetInt32(3);
                obRepuesto.gExistRep = leer.GetInt32(4);
                obRepuesto.gIdProvRep = leer.GetInt32(5);
               
                lista.Add(obRepuesto);
            }

            return lista;
        }

        public static csRepuesto obtener_Rep(int pIdRep)
        {
            //ENVIA LOS DATOS AL FORMULARIO
            csRepuesto obSelectRep = new csRepuesto();
            //MySqlConnection conn = csconectar.conectarse();

            MySqlCommand cmdObtener = new MySqlCommand(string.Format("select * from tab_repuesto where id_repto = '{0}'", pIdRep), csconectar.conectarse());

            MySqlDataReader leer = cmdObtener.ExecuteReader();

            while (leer.Read())
            {

                obSelectRep.gIdRep = leer.GetInt32(0);
                obSelectRep.gdesRep = leer.GetString(1);
                obSelectRep.gMarcaRep = leer.GetString(2);
                obSelectRep.gPrecioRep = leer.GetInt32(3);
                obSelectRep.gExistRep = leer.GetInt32(4);
                obSelectRep.gIdProvRep = leer.GetInt32(5);

            }

            csconectar.conectarse().Close();
            return obSelectRep;

        }






    }
}
