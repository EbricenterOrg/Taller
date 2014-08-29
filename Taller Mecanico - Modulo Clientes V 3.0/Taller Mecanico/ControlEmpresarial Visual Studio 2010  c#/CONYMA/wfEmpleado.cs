/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 27 Agosto del 2014
 *Comentario: Interfaz de empleado
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EBRICENTER
{
    public partial class wfEmpleado : Form
    {
        public wfEmpleado()
        {
            InitializeComponent();
        }

        private void wfEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
