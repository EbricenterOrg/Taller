/*Autor: Roberto Alexander Grave Vicente
  Fecha: 10/08/2014
  Comentario: declaracion de Atributos de la Clase Empleado y Creación de Constructor*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csEmpleado
    {
        public string giIdEmpleado { get; set; }
        public string gsNombre1 { get; set; }
        public string gsNombre2 { get; set; }
        public string gsApellido1 { get; set; }
        public string gsApellido2 { get; set; }
        public string gsFechaAlta { get; set; }
        public string gsFechaBaja { get; set; }
        public int giSalario { get; set; }
        public int giIdDepto { get; set; }
        public int giIdJornada { get; set; }
        public string gsDomicilioEmp { get; set; }
        public string gsTelefonoEmp { get; set; }
        public string gsMovilEmp { get; set; }
        public string gsEmailEmp { get; set; }
       

        public csEmpleado() { }

        public csEmpleado(string pIdemp, string pnombre1, string pnombre2, string papellido1, string papellido2, string pfechaalta, string pfechabaja,int pSalario, int piddepto, int pidjornada, string pDomicilioEmp, string pTelefonoEmp, string pMovilEmp, string pEmailEmp)
        {
            this.giIdEmpleado = pIdemp;
            this.gsNombre1 = pnombre1;
            this.gsNombre2 = pnombre2;
            this.gsApellido1 = papellido1;
            this.gsApellido2 = papellido2;
            this.gsFechaAlta = pfechaalta;
            this.gsFechaBaja = pfechabaja;
            this.giSalario = pSalario;
            this.giIdDepto = piddepto;
            this.giIdJornada = pidjornada;
            this.gsDomicilioEmp = pDomicilioEmp;
            this.gsTelefonoEmp = pDomicilioEmp;
            this.gsMovilEmp = pMovilEmp;
            this.gsEmailEmp = pEmailEmp;

          
        }

    }
}
