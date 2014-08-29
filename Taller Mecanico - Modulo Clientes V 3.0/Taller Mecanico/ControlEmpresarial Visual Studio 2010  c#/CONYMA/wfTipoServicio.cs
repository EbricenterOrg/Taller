/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 28 Agosto del 2014
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace EBRICENTER
{
    public partial class wfTipoServicio : Form
    {
        public wfTipoServicio()
        {
            InitializeComponent();
        }

        private void btnGuardaTS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipServ.Text) || string.IsNullOrEmpty(txtPrecioTS.Text))

                MessageBox.Show("Campo Vacio","Error Campo Vacio!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                csTipoServicio ptiposerv = new csTipoServicio();

                ptiposerv.sDescripcion_serv = txtTipServ.Text.Trim();
                ptiposerv.sPrecio_serv = txtPrecioTS.Text.Trim();

                int iresultado = csTipoServicioBD.Agregar(ptiposerv); 
                     if (iresultado > 0)
                    {
                        MessageBox.Show("Datos Guardados Exitosamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Deshabilitar();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Guardar el Tipo de Servicio", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
           }
        }

        private void btnCancelaTS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                Deshabilitar();
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        private void wfTipoServicio_Load(object sender, EventArgs e)
        {
             MySqlCommand tipserv = new MySqlCommand(string.Format("select id_tserv as 'codigo', descripcion_tserv as 'Tipo Servicio', precio_tserv as 'Precio' from tab_tiposervicio"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = tipserv;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
               dgvTipServ.DataSource = bsource;
                msd.Update(dbset);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Metodos para ser Reutilizables y asi ahorrarnos Codigo*/

        //Limpia la Pantalla, para que deje vacias los cuadros de texto despues de guardar, eliminar, modificar, etc.
        void Limpiar()
        {
            txtTipServ.Clear();
            txtTipServ.Clear();
        }
        //Habilita los Botones los que sean necesarios
        void Habilitar()
        {
            txtTipServ.Enabled = true;
            txtTipServ.Enabled = true;
        }

        //Deshabilita o Desactivar los Botones
        void Deshabilitar()
        {
            txtTipServ.Enabled = false;
            txtTipServ.Enabled = false;
        }


    }
}