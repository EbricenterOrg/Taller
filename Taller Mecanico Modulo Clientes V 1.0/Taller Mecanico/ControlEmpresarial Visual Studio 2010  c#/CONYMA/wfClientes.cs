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
    public partial class wfClientes : Form
    {
        public wfClientes()
        {
            InitializeComponent();
        }

        public csCliente ClienteActual { get; set; }

        public csCliente pClienteDet { get; set; }

        private void btnCancelaCte_Click(object sender, EventArgs e)
        {
           // Limpiar();
            //Deshabilitar();
            this.Close();
        }

  /*      private void btnajuste_Click(object sender, EventArgs e)
        {
            csConexion.ObtenerConexion();
            MessageBox.Show("Eee Conectado a la Base de Datos","Conectado...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
*/
        /*Boton guardar, ejecuta el metodo para agregar para que nos inserte el cliente*/
       private void btnGuardarCte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPriNomCte.Text) || string.IsNullOrEmpty(txtPriApeCte.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                csCliente pCliente = new csCliente();
                
                pCliente.sNombre1_cte = txtPriNomCte.Text;
                pCliente.sNombre2_cte = txtSegNomCte.Text;
                pCliente.sApellido1_cte = txtPriApeCte.Text;
                pCliente.sApellido2_cte = txtSegApeCte.Text;
                pCliente.snit_cte = txtNitCte.Text;
               
                pCliente.sDomicilio_cte = txtDireCte.Text;
                pCliente.iTelefono_cte = Convert.ToInt64(txtTelCte.Text);
                pCliente.iMovil_cte = Convert.ToInt64(txtMovilCte.Text);
                pCliente.sEmail_cte = txtEmailCte.Text;

                int iresultado = csClienteBD.Agregar(pCliente); 
                 if (iresultado > 0)
                {
                    MessageBox.Show("Datos Guardados Exitosamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                    //Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se puedo Guardar el Cliente", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
           }
        }

       private void btnBusCliente_Click(object sender, EventArgs e)
       {
           wfBusqueda buscar = new wfBusqueda();
           buscar.ShowDialog();

           if (buscar.ClienteSeleccionado!=null)
           {
               ClienteActual = buscar.ClienteSeleccionado;

               txtPriNomCte.Text = buscar.ClienteSeleccionado.sNombre1_cte;
               txtSegNomCte.Text = buscar.ClienteSeleccionado.sNombre2_cte;
               txtPriApeCte.Text = buscar.ClienteSeleccionado.sApellido1_cte;
               txtSegApeCte.Text = buscar.ClienteSeleccionado.sApellido2_cte;
               txtNitCte.Text = buscar.ClienteSeleccionado.snit_cte;
               txtDireCte.Text = buscar.ClienteSeleccionado.sDomicilio_cte;
    /*       Convert.ToInt64(txtTelCte.Text) = buscar.ClienteSeleccionado.iTelefono_cte;
           Convert.ToInt64(txtMovilCte.Text)= buscar.ClienteSeleccionado.iMovil_cte ;
    */           txtEmailCte.Text = buscar.ClienteSeleccionado.sEmail_cte;
               

               btnGuardarCte.Enabled = true;
               btnEliminaCte.Enabled = true;

             //  Habilitar();
             //  btnGuardarCte.Enabled = false;
           
           }
       }

        private void btnModificaCte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPriNomCte.Text) || string.IsNullOrEmpty(txtPriApeCte.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                csCliente pCliente = new csCliente();
                pCliente.sNombre1_cte = txtPriNomCte.Text.Trim();
                pCliente.sNombre2_cte = txtSegNomCte.Text.Trim();
                pCliente.sApellido1_cte = txtPriApeCte.Text.Trim();
                pCliente.sApellido2_cte = txtSegApeCte.Text.Trim();
                pCliente.snit_cte = txtNitCte.Text.Trim();
                pCliente.iId_cte = ClienteActual.iId_cte;

                pCliente.sDomicilio_cte = txtDireCte.Text.Trim();
           /*   pCliente.iTelefono_cte = Convert.ToInt64(txtTelCte.Text.Trim());
                pCliente.iMovil_cte = Convert.ToInt64(txtMovilCte.Text.Trim());
           */   pCliente.sEmail_cte = txtEmailCte.Text.Trim();

                if (csClienteBD.Modificar(pCliente) > 0)
                {
                    MessageBox.Show("Los datos del cliente se actualizaron", "Datos Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);

               //     Limpiar();
                 //   Deshabilitar();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void btnEliminaCte_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar este Cliente", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (csClienteBD.Eliminar(ClienteActual.iId_cte) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // Limpiar();
                    //Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void wfClientes_Load(object sender, EventArgs e)
        {

        }

       /*Metodos para ser Reutilizables y asi ahorrarnos Codigo*/
       /* NOTA: Estos metodos sirven pero me falta hacerle arreglos para que habilite el boton(Agregar Cliente) sin este boton no se puede hacer nada solo estaria
        * habilitado el boton Buscar jaja
        * 
        //Limpia la Pantalla, para que deje vacias los cuadros de texto despues de guardar, eliminar, modificar, etc.
        void Limpiar()
        {
            txtPriNomCte.Clear();
            txtSegNomCte.Clear();
            txtPriApeCte.Clear();
            txtSegApeCte.Clear();
            txtDireCte.Clear();
            txtEmailCte.Clear();
            txtTelCte.Clear();
            txtMovilCte.Clear();
            txtNitCte.Clear();
        }

        //Habilita los Botones los que sean necesarios
        void Habilitar()
        {
            txtPriNomCte.Enabled = true;
            txtSegNomCte.Enabled = true;
            txtPriApeCte.Enabled = true;
            txtSegApeCte.Enabled = true;
            txtDireCte.Enabled = true;
            txtEmailCte.Enabled = true;
            txtTelCte.Enabled = true;
            txtMovilCte.Enabled = true;
            txtNitCte.Enabled = true;
            btnGuardarCte.Enabled = true;
            btnCancelaCte.Enabled = true;

        }

        //Deshabilita o Desactivar los Botones
        void Deshabilitar()
        {
            txtPriNomCte.Enabled = false;
            txtSegNomCte.Enabled = false;
            txtPriApeCte.Enabled = false;
            txtSegApeCte.Enabled = false;
            txtDireCte.Enabled = false;
            txtEmailCte.Enabled = false;
            txtTelCte.Enabled = false;
            txtMovilCte.Enabled = false;
            txtNitCte.Enabled = false;
            btnGuardarCte.Enabled = false;
            btnEliminaCte.Enabled = false;
            btnCancelaCte.Enabled = false;
            btnModificaCte.Enabled = false;

        }

        private void wfClientes_Load(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnNuevoCte_Click(object sender, EventArgs e)
        {

            btnNuevoCte.Enabled = true;
        }
          */

    }
}
