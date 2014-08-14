//elaborado por abner rodas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csProveedor
    {
        public string Id { get; set; }
       public string nombre { get; set; }
     
       public csProveedor() { }

       public csProveedor(string pId, string pNombre)

       {
           this.Id = pId;
           this.nombre = pNombre;
       }
    }
}
