using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proveedores_taller
{
    public partial class BuscarProveedor : Form
    {
        public BuscarProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btbuscarprov_Click(object sender, EventArgs e)
        {
            dtvbuscarprov.DataSource = csProveedorBD.Buscar(txtidprovb.Text, txtnomprovb.Text);

        
        }

        public csProveedor ProveedorSeleccionado { get; set; }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            if (dtvbuscarprov.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dtvbuscarprov.CurrentRow.Cells[0].Value);
                ProveedorSeleccionado = csProveedorBD.ObtenerProveedor(string pid);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
    }
}
