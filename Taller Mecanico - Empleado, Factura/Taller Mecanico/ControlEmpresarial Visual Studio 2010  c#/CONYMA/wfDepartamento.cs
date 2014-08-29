/*Autor: Roberto Alexander Grave Vicente
  Fecha: 11/08/2014
  Comentario: Botón Guardar Departamento*/
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
    public partial class wfDepartamento : Form
    {
        public wfDepartamento()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarDepto_Click(object sender, EventArgs e)
        {
            csDepartamento obDepartamento = new csDepartamento();
            obDepartamento.giIdDepto = Convert.ToInt32(txtCodDepto.Text.Trim());
            obDepartamento.gsDescripcionDepto = txtDescDepto.Text.Trim();

            int iRespuesta = csInsertarDatos.agregar(obDepartamento);

            if (iRespuesta > 0)
            {
                MessageBox.Show("Departamento Guardado con Exito." + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se pudo Guardar el Departamento." + MessageBoxButtons.OK);
            }
        }
    }
}
