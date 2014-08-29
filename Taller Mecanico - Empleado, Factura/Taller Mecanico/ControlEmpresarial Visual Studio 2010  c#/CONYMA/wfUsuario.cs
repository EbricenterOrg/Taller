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
    public partial class wfUsuario : Form
    {
        public wfUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            csUsuario obUsuario = new csUsuario();
            obUsuario.giIdUsuario = Convert.ToInt32(txtCodUsuario.Text);
            obUsuario.gsUsuario = txtNombreUsuario.Text;
            obUsuario.gsContraseña = txtPassUsuario.Text;
            obUsuario.giIdEmpUsuario = Convert.ToInt32(txtCodEmp.Text);
            obUsuario.giIdTipoUsuario = Convert.ToInt32(txtCodTipoUsuario.Text);

            int iRespuesta = csInsertarDatos.agregar(obUsuario);
            if (iRespuesta > 0)
            {
                MessageBox.Show("Usuario Guardado con exito...." + MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("NO se puee Guardar el Usuario..." + MessageBoxButtons.OK);
            }

        }

        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader lectura;

            string query = "select * from tab_tipusuario where descripcion_tipuser = '" + cboTipoUsuario.Text + "';";
            MySqlCommand cmdQuery = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmdQuery.ExecuteReader();
            while (lectura.Read())
            {
                string sIdTipoUsuario = lectura.GetInt32("id_tipuser").ToString();
                txtCodTipoUsuario.Text = sIdTipoUsuario;
            }
        }

        private void wfUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tipoUsuario.tab_tipusuario' table. You can move, or remove it, as needed.
            this.tab_tipusuarioTableAdapter.Fill(this.tipoUsuario.tab_tipusuario);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
