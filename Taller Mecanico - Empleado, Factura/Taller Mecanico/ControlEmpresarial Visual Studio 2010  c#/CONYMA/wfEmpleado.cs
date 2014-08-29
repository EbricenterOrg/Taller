
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
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public partial class wfEmpleado : Form
    {
        public wfEmpleado()
        {
            InitializeComponent();
            bloquear();
        
        }

        public csEmpleado EmpActual { get; set; }


        void seleccionComobo()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taller2014DataSet6.tab_departamento' table. You can move, or remove it, as needed.
            this.tab_departamentoTableAdapter1.Fill(this.taller2014DataSet6.tab_departamento);
            // TODO: This line of code loads data into the 'taller2014DataSet5.tab_jornada' table. You can move, or remove it, as needed.
            this.tab_jornadaTableAdapter4.Fill(this.taller2014DataSet5.tab_jornada);
            // TODO: This line of code loads data into the 'taller2014DataSet4.tab_jornada' table. You can move, or remove it, as needed.
            this.tab_jornadaTableAdapter3.Fill(this.taller2014DataSet4.tab_jornada);
            // TODO: This line of code loads data into the 'taller2014DataSet3.tab_jornada' table. You can move, or remove it, as needed.
            this.tab_jornadaTableAdapter2.Fill(this.taller2014DataSet3.tab_jornada);
            // TODO: This line of code loads data into the 'taller2014DataSet2.tab_jornada' table. You can move, or remove it, as needed.
            this.tab_jornadaTableAdapter1.Fill(this.taller2014DataSet2.tab_jornada);
            // TODO: This line of code loads data into the 'departamento.tab_departamento' table. You can move, or remove it, as needed.
            this.tab_departamentoTableAdapter.Fill(this.departamento.tab_departamento);
            // TODO: This line of code loads data into the 'bdtallerDataSet.tab_jornada' table. You can move, or remove it, as needed.
            this.tab_jornadaTableAdapter.Fill(this.bdtallerDataSet.tab_jornada);

        }

        private void btnCancelaEmp_Click(object sender, EventArgs e)
        {
            txtDomEmp.Enabled = true;
            txtDomEmp.Enabled = true;
            txtEmailEmp.Enabled = true;
            txtIddepto.Enabled = true;
            txtIdJornada.Enabled = true;
            txtMovil.Enabled = true;
            txtPrimApellEmp.Enabled = true;
            txtPriNomEmp.Enabled = true;
            txtSalEmp.Enabled = true;
            txtSegApellEmp.Enabled = true;
            txtSegApellEmp.Enabled = true;
            txtSegNomEmp.Enabled = true;
            cboJornada.Enabled = true;
            cboDepEmp.Enabled = true;
            txtTelEmp.Enabled = true;
            dtpFecIniEmp.Enabled = true;
            txtPriNomEmp.Focus();
            
        }

        private void btnGuardarEmp_Click(object sender, EventArgs e)
        {
            csEmpleado obEmpleado = new csEmpleado();
            //obEmpleado.giIdEmpleado = txtIdEmpleado.Text;
            obEmpleado.gsNombre1 = txtPriNomEmp.Text.Trim();
            obEmpleado.gsNombre2 = txtSegNomEmp.Text.Trim();
            obEmpleado.gsApellido1 = txtPrimApellEmp.Text.Trim();
            obEmpleado.gsApellido2 = txtSegApellEmp.Text.Trim();
            obEmpleado.gsFechaAlta = dtpFecIniEmp.Value.Year + "/" + dtpFecIniEmp.Value.Month + "/" + dtpFecIniEmp.Value.Day;
            obEmpleado.gsFechaBaja = dtpFecSalEmp.Value.Year + "/" + dtpFecSalEmp.Value.Month + "/" + dtpFecSalEmp.Value.Day;
            obEmpleado.giSalario = Convert.ToInt32(txtSalEmp.Text);
            obEmpleado.giIdDepto = Convert.ToInt32(txtIddepto.Text);
            obEmpleado.giIdJornada = Convert.ToInt32(txtIdJornada.Text);
            obEmpleado.gsDomicilioEmp = txtDomEmp.Text.Trim();
            obEmpleado.gsTelefonoEmp = txtTelEmp.Text.Trim();
            obEmpleado.gsMovilEmp = txtMovil.Text.Trim();
            obEmpleado.gsEmailEmp = txtEmailEmp.Text.Trim();

            int iRespuesta = csInsertarDatos.agregar(obEmpleado);
            if (iRespuesta > 0)
            {
                limpiar();
                MessageBox.Show("Empleado Registado con Exito." + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se pudo Registrar el Usuario." + MessageBoxButtons.OK);
            }
            
            
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader lectura;

            string query = "select * from tab_jornada where descripcion_jornada = '" + cboJornada.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                string sIdJornada = lectura.GetInt32("id_jornada").ToString();
                txtIdJornada.Text = sIdJornada;
                
                
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTerNomEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDepEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader lectura;

            string query = "select * from tab_departamento where descripcion_depto = '" + cboDepEmp.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                string sIdDepto = lectura.GetInt32("id_depto").ToString();
                txtIddepto.Text = sIdDepto;


            }
        }

        private void txtSegSoEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtIddepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminaEmp_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdElimEmp = new MySqlCommand(string.Format("delete from tab_empleado where id_emp = '"+this.txtIdEmpleado.Text+"'"), csConexion.ObtenerConexion());
            MySqlDataReader rdLeer;

            try
            {
                rdLeer = cmdElimEmp.ExecuteReader();
                limpiar();
                MessageBox.Show("El Empleado ha sido Eliminado");

            }
            catch(Exception ex)
            {       
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizaEmp_Click(object sender, EventArgs e)
        {
            csEmpleado obEmpleadoA = new csEmpleado();
            obEmpleadoA.gsNombre1 = txtPriNomEmp.Text;
            obEmpleadoA.gsNombre2 = txtSegNomEmp.Text;
            obEmpleadoA.gsApellido1 = txtPrimApellEmp.Text;
            obEmpleadoA.gsApellido2 = txtSegApellEmp.Text;
            obEmpleadoA.gsFechaAlta = dtpFecIniEmp.Text;
            obEmpleadoA.gsFechaBaja = dtpFecSalEmp.Text;
            obEmpleadoA.giSalario = Convert.ToInt32(txtSalEmp.Text);
            obEmpleadoA.gsDomicilioEmp = txtDomEmp.Text;
            obEmpleadoA.gsTelefonoEmp = txtTelEmp.Text;
            obEmpleadoA.gsMovilEmp = txtMovil.Text;
            obEmpleadoA.gsEmailEmp = txtEmailEmp.Text;
            obEmpleadoA.giIdDepto = Convert.ToInt32(txtIddepto.Text);
            obEmpleadoA.giIdJornada = Convert.ToInt32(txtIdJornada.Text);
            obEmpleadoA.giIdEmpleado = txtIdEmpleado.Text;

            if (csActualizacion.actualizar(obEmpleadoA) > 0)
            {
                limpiar();
                MessageBox.Show("Los Datos del Empleado se Actualizaron...");
            }
            else
            {
                MessageBox.Show("Los Datos del Empleado NO se Actualizaron...");
            }


        }

        private void btnBuscaEmp_Click(object sender, EventArgs e)
        {
            wfBusquedaEmpleado obBuscarEmp = new wfBusquedaEmpleado();

            obBuscarEmp.ShowDialog();
            lblRegEmp.Visible = false;
            txtIdEmpleado.Visible = true;
            lblCodEmp.Visible = true;

            lblInfoEmp.Visible = true;
            btnCancelaEmp.Visible = false;
            btnGuardarEmp.Visible = false;
            btnCancelaEmp.Visible = false;
            btnModificaEmp.Visible = false;
            
            //btnActualizaEmp.Visible = false;
            if (obBuscarEmp.gSelectEmpleado != null )
            {
                EmpActual = obBuscarEmp.gSelectEmpleado;


                string iIdd = Convert.ToInt32(obBuscarEmp.gSelectEmpleado.giIdEmpleado).ToString();
                txtIdEmpleado.Text = iIdd;
                txtPriNomEmp.Text = obBuscarEmp.gSelectEmpleado.gsNombre1;
                txtSegNomEmp.Text = obBuscarEmp.gSelectEmpleado.gsNombre2;
                txtPrimApellEmp.Text = obBuscarEmp.gSelectEmpleado.gsApellido1;
                txtSegApellEmp.Text = obBuscarEmp.gSelectEmpleado.gsApellido2;
                dtpFecIniEmp.Text = obBuscarEmp.gSelectEmpleado.gsFechaAlta;
                dtpFecSalEmp.Text = obBuscarEmp.gSelectEmpleado.gsFechaBaja;
                string iSalario = Convert.ToInt32(obBuscarEmp.gSelectEmpleado.giSalario).ToString();
                txtSalEmp.Text = iSalario;
                
                txtDomEmp.Text = obBuscarEmp.gSelectEmpleado.gsDomicilioEmp;
                txtTelEmp.Text = obBuscarEmp.gSelectEmpleado.gsTelefonoEmp;
                txtMovil.Text = obBuscarEmp.gSelectEmpleado.gsMovilEmp;
                txtEmailEmp.Text = obBuscarEmp.gSelectEmpleado.gsEmailEmp;
                string iIdEmp = Convert.ToInt32(obBuscarEmp.gSelectEmpleado.giIdDepto).ToString();
                txtIddepto.Text = iIdEmp;
                string iIdJornada = Convert.ToInt32(obBuscarEmp.gSelectEmpleado.giIdJornada).ToString();
                txtIdJornada.Text = iIdJornada;
            }

        }

        void limpiar()
        {
            txtIdEmpleado.Clear();
            txtDomEmp.Clear();
            txtEmailEmp.Clear();
            txtIddepto.Clear();
            txtIdJornada.Clear();
            txtMovil.Clear();
            txtPrimApellEmp.Clear();
            txtPriNomEmp.Clear();
            txtSalEmp.Clear();
            txtSegApellEmp.Clear();
            txtTelEmp.Clear();
            txtSegNomEmp.Clear();

        }

        void bloquear() 
        {
            txtDomEmp.Enabled = false;
            txtDomEmp.Enabled = false;
            txtEmailEmp.Enabled = false;
            txtIddepto.Enabled = false;
            txtIdJornada.Enabled = false;
            txtMovil.Enabled = false;
            txtPrimApellEmp.Enabled = false;
            txtPriNomEmp.Enabled = false;
            txtSalEmp.Enabled = false;
            txtSegApellEmp.Enabled = false;
            txtSegNomEmp.Enabled = false;
            cboJornada.Enabled = false;
            cboDepEmp.Enabled = false;
            txtTelEmp.Enabled = false;
            dtpFecIniEmp.Enabled = false;
        }

        private void btnModificaEmp_Click(object sender, EventArgs e)
        {

            limpiar();
        }

      
    }
}
