/*Autor: Roberto Alexander Grave Vicente
  Fecha: 11/08/2014
  Comentario: boton guardar vehiculo*/
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
    public partial class wfAutomovil : Form
    {
        public wfAutomovil()
        {
            InitializeComponent();
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            csAutomovil obAutomovil = new csAutomovil();
            obAutomovil.giIdAuto = Convert.ToInt32(txtCodVehiculo.Text);
            obAutomovil.gsMatricula = txtMatricula.Text;
            obAutomovil.giModeloAuto = Convert.ToInt32(cbdModelo.SelectedItem);
            obAutomovil.gsColorAuto = txtColor.Text;
            obAutomovil.gsStadoAuto = txtEstado.Text;
            obAutomovil.gsKmsAuto = txtKms.Text;
            obAutomovil.gsNumPolisa = txtNumPoliza.Text;
            obAutomovil.giIdClienteAuto = Convert.ToInt32(txtCodCtedet.Text);

            int iRespuesta = csInsertarDatos.agregar(obAutomovil);
            if (iRespuesta > 0)
            {
                MessageBox.Show("Se ha Registrado el Vehiculo." + MessageBoxButtons.OK);   
            }
            else
            {
                MessageBox.Show("No se Ingresado Vehiculo." + MessageBoxButtons.OK);
            }
            
        }

        private void cbdModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSalirRegistroAuto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
