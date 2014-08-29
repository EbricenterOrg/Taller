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
    public partial class wfReporteEmp : Form
    {
        public wfReporteEmp()
        {
            InitializeComponent();
            mostrar_RepEmp();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           MySqlCommand cmdRepEmp = new MySqlCommand(string.Format("select * from tab_empleado"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = cmdRepEmp;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dgvRepEmp.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        void mostrar_RepEmp()
        {
            MySqlCommand cmdRepEmp = new MySqlCommand(string.Format("select id_emp as 'Codigo', nombre1_emp as 'Primer Nombre', nombre2_emp as 'Segundo Nombre', apellido1_emp as 'Primer Apellido', apellido2_emp as 'Segundo Apellido', salario_emp as 'Salario', domicilio_emp as 'Direccion', telefono_emp as 'Telefono', email_emp as 'E-mail' from tab_empleado"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = cmdRepEmp;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dgvRepEmp.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wfReporteEmp_Load(object sender, EventArgs e)
        {

        }

        private void txtNomEmp_TextChanged(object sender, EventArgs e)
        {
            dgvRepEmp.DataSource = csBuscarDatos.buscar(txtCodEmp.Text, txtNomEmp.Text);
            //dgvDatosEmp.DataSource = csBuscarDatos.buscar(txtCodEmpb.Text, txtBusqdaNombre.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wfEmpleado obEmpleado = new wfEmpleado();
            obEmpleado.ShowDialog();
            wfReporteEmp obRepEmp = new wfReporteEmp();
            obRepEmp.Close();
        }

        
    }
}
