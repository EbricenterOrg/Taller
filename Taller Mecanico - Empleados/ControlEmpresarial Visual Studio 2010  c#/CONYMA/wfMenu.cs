using System;
using System.Drawing;
using System.Windows.Forms;

namespace EBRICENTER {
	public partial class btnprodu : Form {
		int iFlag;
        private string usuario;
		
		public btnprodu(string sUsuario) {
            usuario = sUsuario;
          
			InitializeComponent();
		}
		
		void WfMenuLoad(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Conectado...." +usuario;
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e) {
			this.Close();
		}

        private void btninfo_Click(object sender, EventArgs e)
        {
                        
            wfInformacion info = new wfInformacion();
            info.MdiParent = this;
            info.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ingresoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ingresoClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            wfClientes info = new wfClientes();
            info.MdiParent = this;
            info.Show();
        }

        private void ingresoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfProveedor info = new wfProveedor();
            info.MdiParent = this;
            info.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfEmpleado info = new wfEmpleado();
            info.MdiParent = this;
            info.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfFactura info = new wfFactura();
            info.MdiParent = this;
            info.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfClientes info = new wfClientes();
            info.MdiParent = this;
            info.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfProveedor info = new wfProveedor();
            info.MdiParent = this;
            info.Show();
        }

        private void reporteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfReporteCte info = new wfReporteCte();
            info.MdiParent = this;
            info.Show();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {

        }

        private void jorndaDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfJornadaTrabajo obJorndaM = new wfJornadaTrabajo();
            obJorndaM.MdiParent = this;
            obJorndaM.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfDepartamento obDepartamentoM = new wfDepartamento();
            obDepartamentoM.MdiParent = this;
            obDepartamentoM.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfAutomovil obAutomovilM = new wfAutomovil();
            obAutomovilM.MdiParent = this;
            obAutomovilM.Show();

        }

        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfTipoUsuario obTipoUsuarioM = new wfTipoUsuario();
            obTipoUsuarioM.MdiParent = this;
            obTipoUsuarioM.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfUsuario obUsuarioM = new wfUsuario();
            obUsuarioM.MdiParent = this;
            obUsuarioM.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfBusquedaEmpleado obEmpleadoM = new wfBusquedaEmpleado();
            obEmpleadoM.MdiParent = this;
            obEmpleadoM.Show();
        }

	}
}
