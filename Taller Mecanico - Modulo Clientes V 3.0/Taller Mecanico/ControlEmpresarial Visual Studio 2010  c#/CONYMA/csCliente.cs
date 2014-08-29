/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 04/08/2014
 *Comentario: Se creara la clase par aque contenga todos los datos del cliente y su detalle.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
   public class csCliente
    {
       //Propiedades de Tabla Cliente, campos que se encuentran en la base de datos
       
       public int iId_cte { get; set; }
       public string sNombre1_cte { get; set; }
       public string sNombre2_cte { get; set; }
       public string sApellido1_cte { get; set; }
       public string sApellido2_cte { get; set; }
       public string snit_cte { get; set; }
       public string sDomicilio_cte { get; set; }
       public string iTelefono_cte { get; set; }
       public string iMovil_cte { get; set; }
       public string sEmail_cte { get; set; }
          
    public csCliente() { } //Se utiliza para crear los objetos, ya que de esta forma no recibe parámetros
    
    //Constructor que envía parámetros, que se necesitan para ejecutar las consultas.

    public csCliente(int piId_cte, string psNombre1_cte, string psNombre2_cte, string psApellido1_cte, string psApelldio2_cte, string psNit_cte,
      string psDomicilio_cte, string piTelefono_cte, string piMovil_cte, string psEmail_cte) 
        {

        //Asignacion de Parametros a Propiedades
            this.iId_cte = piId_cte;
            this.sNombre1_cte = psNombre1_cte;
            this.sNombre2_cte = psNombre2_cte;
            this.sApellido1_cte = psApellido1_cte;
            this.sApellido2_cte = psApelldio2_cte;
            this.snit_cte = psNit_cte;

            this.sDomicilio_cte = psDomicilio_cte;
            this.iTelefono_cte = piTelefono_cte;
            this.iMovil_cte = piMovil_cte;
            this.sEmail_cte = psEmail_cte;
        }
    }       
}
