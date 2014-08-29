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
    public partial class wfReporteRep : Form
    {
        public wfReporteRep()
        {
            InitializeComponent();
            mostrar_RepEmp();
        }

        public csRepuesto gSelectRep { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvRepRep.DataSource = csBuscarDatos.buscar_Rep(Convert.ToInt32(txtCodRep.Text), txtNomRep.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dgvRepRep.DataSource = csBuscarDatos.buscar_Rep(Convert.ToInt32(txtCodRep.Text), txtNomRep.Text);
        }

        void mostrar_RepEmp()
        {
            MySqlCommand cmdRepEmp = new MySqlCommand(string.Format("select * from tab_repuesto"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = cmdRepEmp;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dgvRepRep.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wfReporteRep_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wfRepuesto obRepuesto = new wfRepuesto();
            obRepuesto.ShowDialog();
            
        }
    }
}
