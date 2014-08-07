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
       public String sNombre1_cte {get; set;}
       public String sNombre2_cte { get; set; }
       public String sApellido1_cte { get; set; }
       public String sApellido2_cte { get; set; }
       public String snit_cte { get; set; }

       //Propiedades de Tabla Detalle Cliente 
       public String sDomicilio_cte { get; set; }
       public Int64 iTelefono_cte { get; set; }
       public Int64 iMovil_cte { get; set; }
       public String sEmail_cte { get; set; }
       public int iIdDet_cte { get; set; }
          
    public csCliente() { } //Se utiliza para crear los objetos, ya que de esta forma no recibe parámetros
    
    //Constructor que envía parámetros, que se necesitan para ejecutar las consultas.

    public csCliente (int piId_cte, String psNombre1_cte, String psNombre2_cte, String psApellido1_cte, String psApelldio2_cte, String psNit_cte,
        String psDomicilio_cte, int piTelefono_cte, int piMovil_cte, String psEmail_cte, int piIdDet_cte ) 
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
            this.iIdDet_cte = piIdDet_cte;
        }
    }       
}
