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
    public partial class wfBuscarRepuesto : Form
    {
        public wfBuscarRepuesto()
        {
            InitializeComponent();
        }

        public csRepuesto gSelectRep { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBusRep.SelectedRows.Count == 1)
            {
                int iidRep = Convert.ToInt32(dgvBusRep.CurrentRow.Cells[0].Value);
                gSelectRep = csBuscarDatos.obtener_Rep(iidRep);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila.");
            }
        }

        private void wfBuscarRepuesto_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvBusRep.DataSource = csBuscarDatos.buscar_Rep(Convert.ToInt32(txtCodRep.Text), txtDescRep.Text);
        }

        private void txtDescRep_TextChanged(object sender, EventArgs e)
        {
            dgvBusRep.DataSource = csBuscarDatos.buscar_Rep(Convert.ToInt32(txtCodRep.Text), txtDescRep.Text);
        }
    }
}
