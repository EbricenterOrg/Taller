/*Autor:Cesar Estuardo Flores Escobar
 *Fechar: 31 de Julio del 2014 y Modificacion 05 de Agosto del 2014
 *Comentario: Formulario que permite la busqueda de un Cliente por medio
 *de un nombre o apellido, desplegando en un DataGridView los resultados.
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
    public partial class wfBusqueda : Form
    {
        public wfBusqueda()
        {
            InitializeComponent();
        }

        public csCliente ClienteSeleccionado { get; set; }
        private void btnBusCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusquedaCte.Text))

                MessageBox.Show("Ingrese un Dato!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                 dgvBusCliente.DataSource = csClienteBD.Buscar(txtBusquedaCte.Text, txtBusApeCte.Text);
            }
        }


        private void bttAcepBusCte_Click(object sender, EventArgs e)
        {
            if (dgvBusCliente.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32( dgvBusCliente.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = csClienteBD.ObtenerCliente(id);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void wfBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void bttCanBusCte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              
    }
}
