/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 27/08/2014
 *Comentario: Clase para el registro de Vehiculo.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csAutomovil
    {
       public int iId_auto { get; set; }
       public int iIdcte_auto { get; set; }
       public string sMatricula_auto { get; set; }
       public string sMarca_auto { get; set; }
       public string sModelo_auto { get; set; }
       public string sTipo_auto { get; set; }
       public string sColor_auto { get; set; }
       public string sKim_auto { get; set; }
       public string sNumPolisa_auto { get; set; }
          
    public csAutomovil() { }
    
    public csAutomovil(int piId_auto, int piIdcte_auto, string psMatricula_auto, string psMarca_auto, string psModelo_auto, string psTipo_auto, string psColor_auto, string psEstado_auto,
                       string psKim_auto, string psNumPolisa_auto) 
        {

        //Asignacion de Parametros a Propiedades
            this.iId_auto = piId_auto;
            this.iIdcte_auto = piIdcte_auto;
            this.sMatricula_auto = psMatricula_auto;
            this.sMarca_auto = psMarca_auto;
            this.sModelo_auto = psModelo_auto;
            this.sTipo_auto = psTipo_auto;
            this.sColor_auto = psColor_auto;
            this.sKim_auto = psKim_auto;
            this.sNumPolisa_auto = psNumPolisa_auto;
        }
    }
}
