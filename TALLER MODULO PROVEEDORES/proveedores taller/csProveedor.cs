//elaborado por abner rodas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proveedores_taller
{
    public class csProveedor
    {
       public string Id { get; set; }
       public string nombre { get; set; }
       public string direccion { get; set; }
       public string telefono { get; set; }
       public string email { get; set; }
        public csProveedor() { }

       public csProveedor(string pId, string pNombre)

       {
           this.Id = pId;
           this.nombre = pNombre;
       }
    }
}
