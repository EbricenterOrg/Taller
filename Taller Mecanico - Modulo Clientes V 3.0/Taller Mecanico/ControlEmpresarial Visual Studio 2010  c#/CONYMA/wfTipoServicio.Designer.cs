namespace EBRICENTER
{
    partial class wfTipoServicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfTipoServicio));
            this.txtTipServ = new System.Windows.Forms.TextBox();
            this.lblTipServ = new System.Windows.Forms.Label();
            this.btnGuardaTS = new System.Windows.Forms.Button();
            this.btnCancelaTS = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioTS = new System.Windows.Forms.TextBox();
            this.dgvTipServ = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipServ)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipServ
            // 
            this.txtTipServ.Location = new System.Drawing.Point(392, 21);
            this.txtTipServ.Name = "txtTipServ";
            this.txtTipServ.Size = new System.Drawing.Size(131, 22);
            this.txtTipServ.TabIndex = 0;
            // 
            // lblTipServ
            // 
            this.lblTipServ.AutoSize = true;
            this.lblTipServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipServ.Location = new System.Drawing.Point(233, 21);
            this.lblTipServ.Name = "lblTipServ";
            this.lblTipServ.Size = new System.Drawing.Size(133, 18);
            this.lblTipServ.TabIndex = 1;
            this.lblTipServ.Text = "Tipo De Servicio";
            // 
            // btnGuardaTS
            // 
            this.btnGuardaTS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardaTS.BackgroundImage")));
            this.btnGuardaTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaTS.Location = new System.Drawing.Point(306, 363);
            this.btnGuardaTS.Name = "btnGuardaTS";
            this.btnGuardaTS.Size = new System.Drawing.Size(64, 44);
            this.btnGuardaTS.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnGuardaTS, "Guardar");
            this.btnGuardaTS.UseVisualStyleBackColor = true;
            this.btnGuardaTS.Click += new System.EventHandler(this.btnGuardaTS_Click);
            // 
            // btnCancelaTS
            // 
            this.btnCancelaTS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelaTS.BackgroundImage")));
            this.btnCancelaTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelaTS.Location = new System.Drawing.Point(376, 363);
            this.btnCancelaTS.Name = "btnCancelaTS";
            this.btnCancelaTS.Size = new System.Drawing.Size(64, 44);
            this.btnCancelaTS.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCancelaTS, "Cancelar");
            this.btnCancelaTS.UseVisualStyleBackColor = true;
            this.btnCancelaTS.Click += new System.EventHandler(this.btnCancelaTS_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(236, 363);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 44);
            this.btnNuevo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(233, 51);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecioTS
            // 
            this.txtPrecioTS.Location = new System.Drawing.Point(392, 51);
            this.txtPrecioTS.Name = "txtPrecioTS";
            this.txtPrecioTS.Size = new System.Drawing.Size(131, 22);
            this.txtPrecioTS.TabIndex = 7;
            // 
            // dgvTipServ
            // 
            this.dgvTipServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipServ.Location = new System.Drawing.Point(102, 132);
            this.dgvTipServ.Name = "dgvTipServ";
            this.dgvTipServ.RowTemplate.Height = 24;
            this.dgvTipServ.Size = new System.Drawing.Size(571, 175);
            this.dgvTipServ.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::EBRICENTER.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(446, 363);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 44);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackgroundImage = global::EBRICENTER.Properties.Resources.Refrescar;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefrescar.Location = new System.Drawing.Point(679, 278);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(44, 34);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.UseVisualStyleBackColor = true;
   //         this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // wfTipoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 444);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtPrecioTS);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dgvTipServ);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelaTS);
            this.Controls.Add(this.btnGuardaTS);
            this.Controls.Add(this.lblTipServ);
            this.Controls.Add(this.txtTipServ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Servicio";
            this.Load += new System.EventHandler(this.wfTipoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipServ;
        private System.Windows.Forms.Label lblTipServ;
        private System.Windows.Forms.Button btnGuardaTS;
        private System.Windows.Forms.Button btnCancelaTS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioTS;
        private System.Windows.Forms.DataGridView dgvTipServ;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRefrescar;
    }
}