
/*Autor: Roberto Alexander Grave Vicente
  Fecha: 11/08/2014
  Comentario: Boton Guardar Joranda de Trabajo*/
using System;
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
    public partial class wfJornadaTrabajo : Form
    {
        public wfJornadaTrabajo()
        {
            InitializeComponent();
        }

        private void wfJornadaTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuradarJ_Click(object sender, EventArgs e)
        {
            csJornada obJornada = new csJornada();
            obJornada.giIdJornada = Convert.ToInt32(txtidjornada.Text.Trim());
            obJornada.gsDescripcionJ = txtdescjornada.Text.Trim();

            int iRespuesta = csInsertarDatos.agregar(obJornada);

            if (iRespuesta > 0)
            {
                MessageBox.Show("Jornada Guardada" + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se pudo Guardar la Información" + MessageBoxButtons.OK);
            }

        }
    }
}
