
/*Autor: Roberto Alexander Grave Vicente
  Fecha: 11/08/2014
  Comentario: Boton Guardar TipoUsuario*/
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
    public partial class wfTipoUsuario : Form
    {
        public wfTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarTipoUsuario_Click(object sender, EventArgs e)
        {
            csTipoUsuario obTipoUsuario = new csTipoUsuario();
            obTipoUsuario.giIdTipoUsuario = Convert.ToInt32(txtCodTipUsuario.Text);
            obTipoUsuario.gsDescripcionTipUsuario = txtDescTipoUsuario.Text;

            int iRespuesta = csInsertarDatos.agregar(obTipoUsuario);

            if (iRespuesta > 0)
            {
                MessageBox.Show("Se ha Ingresado un Nuevo Tipo de Usuario." + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se ha Guardadola el dato" + MessageBoxButtons.OK);   
            }
        }
    }
}
