using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public partial class wfRepuesto : Form
    {
        public wfRepuesto()
        {
            InitializeComponent();
            bloquear();
        }

        public csRepuesto RepActual { get; set; }

        void limpiar()
        {
            txtNombreRep.Clear();
            txtCantRep.Clear();
            txtIdProv.Clear();
            txtMarcaRep.Clear();
            txtPrecioRep.Clear();
            txtCodRep.Clear();
        }

        void bloquear()
        {
            txtCodRep.Enabled = false;
            txtNombreRep.Enabled = false;
            txtCantRep.Enabled = false;
            txtIdProv.Enabled = false;
            txtMarcaRep.Enabled = false;
            txtPrecioRep.Enabled = false;
            txtCodRep.Visible = false;
            cboIdProv.Enabled = false;
        }

        private void wfRepuesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taller2014DataSet1.tab_proveedor' table. You can move, or remove it, as needed.
            this.tab_proveedorTableAdapter.Fill(this.taller2014DataSet1.tab_proveedor);

        }

        private void btnGuardarRep_Click(object sender, EventArgs e)
        {
            csRepuesto obEmpleado = new csRepuesto();

            obEmpleado.gdesRep = txtNombreRep.Text;
            obEmpleado.gMarcaRep = txtMarcaRep.Text;
            obEmpleado.gPrecioRep = Convert.ToInt32(txtPrecioRep.Text);
            obEmpleado.gExistRep = Convert.ToInt32(txtCantRep.Text);
            obEmpleado.gIdProvRep = Convert.ToInt32(txtIdProv.Text);

            int iRespuesta = csInsertarDatos.agregar(obEmpleado);

            if (iRespuesta > 0)
            {
                limpiar();
                MessageBox.Show("Repuesto Ingresado con Exito." + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se ha Podido Hacer el Registro." + MessageBoxButtons.OK);
            }

        }

        private void cmbIdProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader lectura;

            string query = "select * from tab_proveedor where nombre_prov = '" + cboIdProv.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                string sIdProv = lectura.GetInt32("id_prov").ToString();
                txtIdProv.Text = sIdProv;
            }
        }

        private void btnBuscarRep_Click(object sender, EventArgs e)
        {
            txtCodRep.Visible = true;
            btnActivar.Visible = false;
            btnGuardarRep.Visible = false;
            lblIdRep.Visible = true;

            txtCodRep.Enabled = true;
            txtNombreRep.Enabled = true;
            txtCantRep.Enabled = true;
            txtIdProv.Enabled = true;
            txtMarcaRep.Enabled = true;
            txtPrecioRep.Enabled = true;
            cboIdProv.Enabled = true;

            wfBuscarRepuesto obBuscarRep = new wfBuscarRepuesto();

            obBuscarRep.ShowDialog();


            if(obBuscarRep.gSelectRep != null)
            {
                RepActual = obBuscarRep.gSelectRep;

                string iIdR = Convert.ToInt32(obBuscarRep.gSelectRep.gIdRep).ToString();
                txtCodRep.Text = iIdR;
                txtNombreRep.Text = obBuscarRep.gSelectRep.gdesRep;
                txtMarcaRep.Text = obBuscarRep.gSelectRep.gMarcaRep;
                string iPrecR = Convert.ToInt32(obBuscarRep.gSelectRep.gPrecioRep).ToString();
                txtPrecioRep.Text = iPrecR;
                string iExistR = Convert.ToInt32(obBuscarRep.gSelectRep.gExistRep).ToString();
                txtCantRep.Text = iExistR;
                string iIdProvR = Convert.ToInt32(obBuscarRep.gSelectRep.gIdProvRep).ToString();
                txtIdProv.Text = iIdProvR;



            }
        }

        private void btnActuRep_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdUpdateRep = new MySqlCommand(string.Format("update tab_repuesto set id_repto = '" + this.txtCodRep.Text + "', descripcion_repto = '" + this.txtNombreRep.Text + "', marca_repto = '" + this.txtMarcaRep.Text + "', precio_repto = '" + this.txtPrecioRep.Text + "', existencia_repto = '" + this.txtCantRep.Text + "', idproveedor_reptO = '" + this.txtIdProv.Text + "' where id_repto = '" + this.txtCodRep.Text + "' "), csconectar.conectarse());
            MySqlDataReader lectura;
            try
            {
                lectura = cmdUpdateRep.ExecuteReader();
                limpiar();
                MessageBox.Show("Registros Actualizados.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnElimRep_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdElimEmp = new MySqlCommand(string.Format("delete from tab_repuesto where id_repto = '" + this.txtCodRep.Text + "'"), csConexion.ObtenerConexion());
            MySqlDataReader rdLeer;

            try
            {
                rdLeer = cmdElimEmp.ExecuteReader();
                limpiar();
                MessageBox.Show("Registro Eliminado.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            txtCodRep.Enabled = true;
            txtNombreRep.Enabled = true;
            txtCantRep.Enabled = true;
            txtIdProv.Enabled = true;
            txtMarcaRep.Enabled = true;
            txtPrecioRep.Enabled = true;
            cboIdProv.Enabled = true;
            txtNombreRep.Focus();
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        
    }
}
