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
    public partial class wfIniciarSesion : Form
    {
        string sUsuario;

        public wfIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            sUsuario = txtUsuario.Text;
            btnprodu MenuPrincipal = new btnprodu();
            MenuPrincipal.Show();
            //MenuPrincipal.tsslEstado.Text = "Conectado - "+sUsuario;
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void wfIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void pboLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
