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
    public partial class wfIniciarSesion : Form
    {
        string sUsuario;

        public wfIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection obCon = new MySqlConnection("server=localhost; User Id=root; database=taller2014");
                //En donde server="nombre del servidor", user id="root" Pwd=contaseña y database="Nombre de la BD a la que nos conectaremos.



                obCon.Open(); //Abrimos la conexion creada.
                MySqlCommand obCmd = new MySqlCommand("SELECT usuario_user,contraseña_user,idtipusuario_user FROM tab_usuario WHERE usuario_user='" + txtUsuario.Text + "'AND contraseña_user='" + txtContrasena.Text + "' ", obCon); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = obCmd.ExecuteReader();



                string sCodigo = null;



                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    sCodigo = leer.GetString("idtipusuario_user");
                    if (sCodigo.Equals("1") == true)
                    {
                        MessageBox.Show("Bienvenido al sistema " + txtUsuario.Text);
                        sUsuario = txtUsuario.Text;
                        wfMenu MenuPrincipal = new wfMenu(sUsuario);
                        MenuPrincipal.Show();
                        // MenuPrincipal.tsslEstado.Text = "Conectado - "+sUsuario;
                        this.Hide();

                    }
                    if (sCodigo.Equals("2") == true)
                    {
                        MessageBox.Show("Bienvenido " + txtUsuario.Text);
                        sUsuario = txtUsuario.Text;
                        wfEmpleado MenuPrincipal = new wfEmpleado ();
                        MenuPrincipal.Show();
                        //MenuPrincipal.tsslEstado.Text = "Conectado - "+sUsuario;
                        this.Hide();

                    }
                }

                else //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error - Ingrese sus datos correctamente");
                obCon.Close(); //Cerramos la conexion.
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Ingrese sus datos correctamente aaa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
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
