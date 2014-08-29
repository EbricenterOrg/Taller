/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 27/08/2014
 *Comentario: Formulario
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
    public partial class wfAutomovil : Form
    {
        public wfAutomovil()
        {
            InitializeComponent();
        }

        private void btnGuardaRegVehiculo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMatricula.Text) || string.IsNullOrEmpty(cdbMoodelo.Text) || string.IsNullOrEmpty(txtColor.Text) ||
                string.IsNullOrEmpty(cdbMarca.Text) || string.IsNullOrEmpty(cdbTipoAuto.Text) || string.IsNullOrEmpty(txtKm.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                csAutomovil pAuto = new csAutomovil();

                pAuto.sMatricula_auto = txtMatricula.Text.Trim();
                pAuto.sMarca_auto = cdbMarca.Text.Trim();
                pAuto.sModelo_auto = cdbMoodelo.Text.Trim();
                pAuto.sTipo_auto = cdbTipoAuto.Text.Trim();
                pAuto.sColor_auto = txtColor.Text.Trim();
                pAuto.sKim_auto = txtKm.Text.Trim();
                pAuto.sNumPolisa_auto = txtNumPoliza.Text.Trim();
                pAuto.iIdcte_auto = Convert.ToInt32(txtCodCte.Text.Trim());

                int iresultado = csAutomovilBD.Agregar(pAuto);
                if (iresultado > 0)
                {
                    MessageBox.Show("Datos Guardados Exitosamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se puedo Guardar Automovil", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        /*Metodos para ser Reutilizables y asi ahorrarnos Codigo*/

        //Limpia la Pantalla, para que deje vacias los cuadros de texto despues de guardar, eliminar, modificar, etc.
        void Limpiar()
        {
            txtCodCte.Clear();
            txtMatricula.Clear();
            txtColor.Clear();
            txtKm.Clear();
            txtNumPoliza.Clear();
        }

        //Habilita los Botones los que sean necesarios
        void Habilitar()
        {
            txtCodCte.Enabled = true;
            txtMatricula.Enabled = true;
            cdbMarca.Enabled = true;
            cdbMoodelo.Enabled = true;
            cdbTipoAuto.Enabled = true;
            txtColor.Enabled = true;
            txtKm.Enabled = true;
            txtNumPoliza.Enabled = true;
        }

        //Deshabilita o Desactivar los Botones
        void Deshabilitar()
        {
            txtCodCte.Enabled = false;
            txtMatricula.Enabled = false;
            cdbMarca.Enabled = false;
            cdbMoodelo.Enabled = false;
            cdbTipoAuto.Enabled = false;
            txtColor.Enabled = false;
            txtKm.Enabled = false;
            txtNumPoliza.Enabled = false;
        }

        private void btnCancelaRegVehiculo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                Deshabilitar();
            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            wfBusqueda busca = new wfBusqueda();
            busca.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        private void cdbMoodelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* private void btnModificarReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text) || string.IsNullOrEmpty(cdbMarca.Text) || string.IsNullOrEmpty(cdbMoodelo.Text)
                || string.IsNullOrEmpty(cdbTipoAuto.Text) || string.IsNullOrEmpty(txtKm.Text))
                MessageBox.Show("Hay uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                csAutomovil pAuto = new csAutomovil();
                pAuto.sMatricula_auto = txtMatricula.Text.Trim();
                pAuto.sMarca_auto = cdbMarca.Text.Trim();
                pAuto.sModelo_auto = cdbMoodelo.Text.Trim();
                pAuto.sTipo_auto = cdbTipoAuto.Text.Trim();
                pAuto.sColor_auto = txtColor.Text.Trim();
                pAuto.sKim_auto = txtKm.Text.Trim();
                pAuto.sNumPolisa_auto = txtNumPoliza.Text.Trim();

                //pCliente.iId_cte = ClienteActual.iId_cte;

                if (csAutomovilBD.Modificar(pAuto) > 0)
                {
                    MessageBox.Show("Los datos del cliente se actualizaron", "Datos Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        */
        }
    }

