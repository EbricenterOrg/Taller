/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 27 Agosto del 2014
 *Comentario:*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csTipoServicio
    {
       //Propiedades de Tabla Cliente, campos que se encuentran en la base de datos
       
       public int iId_Tserv { get; set; }
       public string sDescripcion_serv { get; set; }
       public string sPrecio_serv { get; set; }
          
    public csTipoServicio() { } //Se utiliza para crear los objetos, ya que de esta forma no recibe parámetros
    
    public csTipoServicio(int piId_Tserv, string psDescripcion_serv, string psPrecio_serv) 
        {

        //Asignacion de Parametros a Propiedades
            this.iId_Tserv = piId_Tserv;
            this.sDescripcion_serv = psDescripcion_serv;
            this.sPrecio_serv = psPrecio_serv;
        }
    }       
}
