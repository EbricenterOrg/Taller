namespace EBRICENTER
{
    partial class wfEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEmpleado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statEmpleado = new System.Windows.Forms.StatusStrip();
            this.btnServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnServicio,
            this.btnProductos,
            this.btnVehiculo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mspemp";
            // 
            // btnInicio
            // 
            this.btnInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSalir});
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(57, 56);
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // statEmpleado
            // 
            this.statEmpleado.Location = new System.Drawing.Point(0, 687);
            this.statEmpleado.Name = "statEmpleado";
            this.statEmpleado.Size = new System.Drawing.Size(942, 22);
            this.statEmpleado.TabIndex = 1;
            this.statEmpleado.Text = "statEmpleado";
            // 
            // btnServicio
            // 
            this.btnServicio.Image = global::EBRICENTER.Properties.Resources.se;
            this.btnServicio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServicio.Size = new System.Drawing.Size(79, 56);
            this.btnServicio.Text = "Servicios";
            this.btnServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculo.Image")));
            this.btnVehiculo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehiculo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVehiculo.Size = new System.Drawing.Size(78, 56);
            this.btnVehiculo.Text = "Vehiculo";
            this.btnVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProductos
            // 
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(89, 56);
            this.btnProductos.Text = "Rep&uestos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // wfEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EBRICENTER.Properties.Resources.Logotipo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(942, 709);
            this.Controls.Add(this.statEmpleado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wfEmpleado";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.wfEmpleado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem btnServicio;
        private System.Windows.Forms.ToolStripMenuItem btnVehiculo;
        private System.Windows.Forms.ToolStripMenuItem btnProductos;
    }
}