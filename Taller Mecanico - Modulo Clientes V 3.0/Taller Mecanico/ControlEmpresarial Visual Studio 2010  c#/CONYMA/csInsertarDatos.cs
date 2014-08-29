/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: creacion de procedimientos para agregar registros a traves de Consultas SQl aplicando polimorfismo*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    class csInsertarDatos
    {

        public static int agregar(csRepuesto Repuesto)
        {
            int iretorno = 0;

            MySqlCommand cmdInsertar = new MySqlCommand(string.Format("insert into tab_repuesto (descripcion_repto, marca_repto, precio_repto, existencia_repto, idproveedor_repto) values ('{0}', '{1}','{2}','{3}','{4}')", Repuesto.gdesRep, Repuesto.gMarcaRep, Repuesto.gPrecioRep, Repuesto.gExistRep, Repuesto.gIdProvRep), csconectar.conectarse());

            iretorno = cmdInsertar.ExecuteNonQuery();
            return iretorno;
        }
        public static int agregar(csJornada jornada)
        {
            int iretorno = 0;

            MySqlCommand cmdInsertar = new MySqlCommand(string.Format("insert into tab_jornada (id_jornada, descripcion_jornada) values ('{0}', '{1}')", jornada.giIdJornada, jornada.gsDescripcionJ), csconectar.conectarse());

            iretorno = cmdInsertar.ExecuteNonQuery();
            return iretorno;
        }//final procedimiento agregar en la tabla tab_jornada.

        public static int agregar(csDepartamento departamento)
        {
            int iRetorno = 0;

            MySqlCommand cmdInsertar = new MySqlCommand(string.Format("insert into tab_departamento (id_depto, descripcion_depto) values('{0}', '{1}')", departamento.giIdDepto, departamento.gsDescripcionDepto), csconectar.conectarse());

            iRetorno = cmdInsertar.ExecuteNonQuery();
            return iRetorno;

        }//final procedimiento agregar en la tabla tab_departamento.

        public static int agregar(csEmpleado empleado)
        {
            int iRetorno = 0;

            MySqlCommand cmdInsertar = new MySqlCommand(string.Format("insert into tab_empleado (nombre1_emp, nombre2_emp, apellido1_emp, apellido2_emp, fechaalta_emp, fechabaja_emp, salario_emp, domicilio_emp, telefono_emp, movil_emp, email_emp,iddepartament_emp, idjornada_emp) values ('{0}', '{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}','{10}','{11}','{12}')",empleado.gsNombre1, empleado.gsNombre2, empleado.gsApellido1, empleado.gsApellido2, empleado.gsFechaAlta, empleado.gsFechaBaja, empleado.giSalario, empleado.gsDomicilioEmp, empleado.gsTelefonoEmp, empleado.gsMovilEmp, empleado.gsEmailEmp, empleado.giIdDepto, empleado.giIdJornada), csconectar.conectarse());
            iRetorno = cmdInsertar.ExecuteNonQuery();

           /* MySqlCommand cmdInsertar2 = new MySqlCommand(string.Format("insert into tabt_det_emp (domicilio_detemp, telefono_detemp, movil_detemp, email_detemp, idempleado_detemp) values('{0}', '{1}','{2}', '{3}', '{4}')", empleado.gsDomicilioEmp, empleado.gsTelefonoEmp, empleado.gsMovilEmp, empleado.gsEmailEmp, empleado.giIdEmpleado), csconectar.conectarse());
            iRetorno = cmdInsertar2.ExecuteNonQuery();*/
            return iRetorno;

        }// final procedimiento agregar empleado en la tab_empleado y tabt_det_emp

        public static int agregar(csTipoUsuario tipousuario)
        { 
            int iRetorno = 0;

            MySqlCommand cmdInsertar = new MySqlCommand(string.Format("insert into tab_tipusuario (id_tipuser, descripcion_tipuser) values('{0}', '{1}')",tipousuario.giIdTipoUsuario, tipousuario.gsDescripcionTipUsuario), csconectar.conectarse());
            iRetorno = cmdInsertar.ExecuteNonQuery();

            return iRetorno;

        }//final procedimiento agregar tipo Usuario en la tab_tipusuario.

        public static int agregar(csUsuario usuario)
        {
            int iRetorno = 0;

            MySqlCommand cmdInsertar = new MySqlCommand(string.Format("insert into tab_usuario (id_user, usuario_user, contraseña_user, idempleado_user, idtipusuario_user) values('{0}', '{1}', '{2}', '{3}','{4}')", usuario.giIdUsuario, usuario.gsUsuario, usuario.gsContraseña, usuario.giIdEmpUsuario, usuario.giIdTipoUsuario), csconectar.conectarse());
            iRetorno = cmdInsertar.ExecuteNonQuery();

            return iRetorno;

        }//final procedimiento agregar tipo Usuario en la tab_usuario.


    }
}
