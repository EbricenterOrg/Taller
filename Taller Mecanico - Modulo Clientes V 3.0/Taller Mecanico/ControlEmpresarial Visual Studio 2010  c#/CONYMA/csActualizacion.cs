using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    class csActualizacion
    {
        public static int actualizar(csEmpleado pEmpleadoA)
        {
            int retorno = 0;

            MySqlCommand cmdActualizar = new MySqlCommand(string.Format("update tab_empleado set nombre1_emp = '{0}', nombre2_emp = '{1}', apellido1_emp = '{2}', apellido2_emp = '{3}', fechaalta_emp = '{4}', fechabaja_emp ='{5}', salario_emp ='{6}', domicilio_emp = '{7}', telefono_emp = '{8}', movil_emp = '{9}', email_emp = '{10}', iddepartament_emp = '{11}', idjornada_emp ='{12}' where id_emp = {13}", pEmpleadoA.gsNombre1, pEmpleadoA.gsNombre2, pEmpleadoA.gsApellido1, pEmpleadoA.gsApellido2, pEmpleadoA.gsFechaAlta, pEmpleadoA.gsFechaBaja, pEmpleadoA.giSalario,pEmpleadoA.gsDomicilioEmp, pEmpleadoA.gsTelefonoEmp, pEmpleadoA.gsMovilEmp, pEmpleadoA.gsEmailEmp, pEmpleadoA.giIdDepto, pEmpleadoA.giIdJornada, pEmpleadoA.giIdEmpleado), csconectar.conectarse());
            retorno = cmdActualizar.ExecuteNonQuery();
            csconectar.conectarse().Close();
            return retorno;

        }

    }
}
