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
    public partial class wfBuscarProveedor : Form
    {
        public wfBuscarProveedor()
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


        }

        private void btcancelar_Click(object sender, EventArgs e)
        {

        }
    }
}