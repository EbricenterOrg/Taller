/*Autor: Roberto Alexander Grave Vicente
  Fecha: 11/08/2014
  Comentario: Boton Guardar Empleado*/
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
    public partial class wfBusquedaEmpleado : Form
    {
        public wfBusquedaEmpleado()
        {
            InitializeComponent();
        }

        public csEmpleado gSelectEmpleado { get; set; }

        private void btnEnviardDtxtEmp_Click(object sender, EventArgs e)
        {
            
            if (dgvDatosEmp.SelectedRows.Count == 1)
            {
               // wfEmpleado obEmp = new wfEmpleado(); 
                //obEmp.Show();

                int iIdEmp = Convert.ToInt32(dgvDatosEmp.CurrentRow.Cells[0].Value);
                gSelectEmpleado = csBuscarDatos.obtener(iIdEmp);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila...");
            }
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            dgvDatosEmp.DataSource = csBuscarDatos.buscar(txtCodEmpb.Text, txtBusqdaNombre.Text);
        }

        private void wfBusquedaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodEmpb_TextChanged(object sender, EventArgs e)
        {
            dgvDatosEmp.DataSource = csBuscarDatos.buscar(txtCodEmpb.Text, txtBusqdaNombre.Text);

        }

        private void txtBusqdaNombre_TextChanged(object sender, EventArgs e)
        {
            dgvDatosEmp.DataSource = csBuscarDatos.buscar(txtCodEmpb.Text, txtBusqdaNombre.Text);
        }
    }
}
