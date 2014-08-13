using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EBRICENTER {
	public partial class wfMenuPrincipal : Form {



        private string usuario;


		
		public wfMenuPrincipal(string sUsuario) {
            usuario = sUsuario;
			InitializeComponent();
           
		}

        private void iniciarConexion()
        {
          


        }

		
		void WfMenuLoad(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Conectado..." +usuario;
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e) {
			this.Close();
		}

        private void btninfo_Click(object sender, EventArgs e)
        {
                     
            wfAcercaDe info = new wfAcercaDe();
            info.MdiParent = this;
            info.Show();
            

        }

        private void btnNu_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        
	}
}
