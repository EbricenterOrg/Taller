using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBRICENTER
{
    public class csServicio
    {
        public int iId_servicio { get; set; }
        public int iIdCliente_servicio { get; set; }
        public int iIdAutomovil_servicio { get; set; }
        public int iIdEmpleado_servicio { get; set; }
        public int iIdTipoServicio_servicio { get; set; }

        public csServicio() { }

        public csServicio(int piId_servicio, int piIdCliente_servicio, int piIdAutomovil_servicio, int piIdEmpleado_servicio, int piIdTipoServicio_servicio)
        { 
            this.iId_servicio =  piId_servicio;
            this.iIdCliente_servicio = piIdCliente_servicio;
            this.iIdAutomovil_servicio = piIdAutomovil_servicio;
            this.iIdEmpleado_servicio = piIdEmpleado_servicio;
            this.iIdTipoServicio_servicio = piIdTipoServicio_servicio;
        }

    }
}
