/*
 * Created by SharpDevelop.
 * User: FamGutierrez
 * Date: 08/10/2013
 * Time: 07:24 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EBRICENTER
{
	partial class wfMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jorndaDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProye = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProvee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProd = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProyectos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNu = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnElim = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btninfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnProyectos,
            this.btnProveedores,
            this.btnProductos,
            this.btnClientes,
            this.btnAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(794, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnInicio
            // 
            this.btnInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnBuscar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(48, 51);
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.automovilToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.jorndaDeTrabajoToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.tipoUsuarioToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // automovilToolStripMenuItem
            // 
            this.automovilToolStripMenuItem.Name = "automovilToolStripMenuItem";
            this.automovilToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.automovilToolStripMenuItem.Text = "Repuesto";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // jorndaDeTrabajoToolStripMenuItem
            // 
            this.jorndaDeTrabajoToolStripMenuItem.Name = "jorndaDeTrabajoToolStripMenuItem";
            this.jorndaDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.jorndaDeTrabajoToolStripMenuItem.Text = "Jornda de Trabajo";
            this.jorndaDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.jorndaDeTrabajoToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            this.tipoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoUsuarioToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCliente,
            this.btnProye,
            this.btnProvee,
            this.btnProd,
            this.empleadosToolStripMenuItem});
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 22);
            this.btnBuscar.Text = "&Buscar";
            // 
            // btnCliente
            // 
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(139, 22);
            this.btnCliente.Text = "&Cliente";
            // 
            // btnProye
            // 
            this.btnProye.Image = ((System.Drawing.Image)(resources.GetObject("btnProye.Image")));
            this.btnProye.Name = "btnProye";
            this.btnProye.Size = new System.Drawing.Size(139, 22);
            this.btnProye.Text = "&Servicios";
            // 
            // btnProvee
            // 
            this.btnProvee.Image = ((System.Drawing.Image)(resources.GetObject("btnProvee.Image")));
            this.btnProvee.Name = "btnProvee";
            this.btnProvee.Size = new System.Drawing.Size(139, 22);
            this.btnProvee.Text = "Pro&veedores";
            // 
            // btnProd
            // 
            this.btnProd.Image = ((System.Drawing.Image)(resources.GetObject("btnProd.Image")));
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(139, 22);
            this.btnProd.Text = "Rep&uestos";
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
            // 
            // btnProyectos
            // 
            this.btnProyectos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNu,
            this.btnGu,
            this.btnElim});
            this.btnProyectos.Image = global::EBRICENTER.Properties.Resources.se;
            this.btnProyectos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProyectos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProyectos.Size = new System.Drawing.Size(65, 51);
            this.btnProyectos.Text = "&Servicios";
            this.btnProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNu
            // 
            this.btnNu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
            this.btnNu.Image = global::EBRICENTER.Properties.Resources.Add;
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(117, 22);
            this.btnNu.Text = "Nuevo";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // btnGu
            // 
            this.btnGu.Name = "btnGu";
            this.btnGu.Size = new System.Drawing.Size(117, 22);
            this.btnGu.Text = "Guardar";
            // 
            // btnElim
            // 
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(117, 22);
            this.btnElim.Text = "Eliminar";
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(84, 51);
            this.btnProveedores.Text = "Pro&veedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProductos
            // 
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(73, 51);
            this.btnProductos.Text = "Rep&uestos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnClientes
            // 
            this.btnClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteClienteToolStripMenuItem});
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(61, 51);
            this.btnClientes.Text = "&Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reporteClienteToolStripMenuItem
            // 
            this.reporteClienteToolStripMenuItem.Name = "reporteClienteToolStripMenuItem";
            this.reporteClienteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reporteClienteToolStripMenuItem.Text = "Reporte Cliente";
            this.reporteClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteClienteToolStripMenuItem_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Checked = true;
            this.btnAyuda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btninfo});
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(53, 51);
            this.btnAyuda.Text = "A&yuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btninfo
            // 
            this.btninfo.Image = ((System.Drawing.Image)(resources.GetObject("btninfo.Image")));
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(139, 22);
            this.btninfo.Text = "Información";
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // wfMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "wfMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WfMenuLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnSalir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem btninfo;
        private System.Windows.Forms.ToolStripMenuItem btnAyuda;
		private System.Windows.Forms.ToolStripMenuItem btnClientes;
		private System.Windows.Forms.ToolStripMenuItem btnProyectos;
		private System.Windows.Forms.ToolStripMenuItem btnCliente;
		private System.Windows.Forms.ToolStripMenuItem btnProd;
		private System.Windows.Forms.ToolStripMenuItem btnProvee;
		private System.Windows.Forms.ToolStripMenuItem btnProye;
        private System.Windows.Forms.ToolStripMenuItem btnBuscar;
		private System.Windows.Forms.ToolStripMenuItem btnNuevo;
		private System.Windows.Forms.ToolStripMenuItem btnProductos;
		private System.Windows.Forms.ToolStripMenuItem btnProveedores;
		private System.Windows.Forms.ToolStripMenuItem btnInicio;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNu;
        private System.Windows.Forms.ToolStripMenuItem btnGu;
        private System.Windows.Forms.ToolStripMenuItem btnElim;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automovilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jorndaDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
	}
}
