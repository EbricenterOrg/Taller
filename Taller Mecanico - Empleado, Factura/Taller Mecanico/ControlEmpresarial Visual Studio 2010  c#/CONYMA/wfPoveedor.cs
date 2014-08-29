using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public partial class wfProveedor : Form
    {
        public wfProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public csProveedor ProveedorActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            csProveedor pcsProveedor = new csProveedor();
            pcsProveedor.Id = txtidprov.Text.Trim();
            pcsProveedor.nombre = txtnomprov.Text.Trim();
            
            int resultado = csProveedorBD.Agregar(pcsProveedor);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            wfBuscarProveedor buscar = new wfBuscarProveedor();
            buscar.ShowDialog();

            if (buscar.ProveedorSeleccionado != null)
            {
                ProveedorActual = buscar.ProveedorSeleccionado;
                txtidprov.Text = buscar.ProveedorSeleccionado.Id;
                txtnomprov.Text = buscar.ProveedorSeleccionado.nombre;


            }
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            csProveedor pcsProveedor = new csProveedor();

            pcsProveedor.Id = txtidprov.Text.Trim();
            pcsProveedor.nombre = txtnomprov.Text.Trim();

            if (csProveedorBD.Actualizar(pcsProveedor) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
