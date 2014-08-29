namespace EBRICENTER
{
    partial class wfServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfServicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdcteServ = new System.Windows.Forms.TextBox();
            this.txtIdveServ = new System.Windows.Forms.TextBox();
            this.txtIdtipServ = new System.Windows.Forms.TextBox();
            this.txtIdemServ = new System.Windows.Forms.TextBox();
            this.dgvClienteVehiculo = new System.Windows.Forms.DataGridView();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo Empleado";
            // 
            // txtIdcteServ
            // 
            this.txtIdcteServ.Location = new System.Drawing.Point(172, 44);
            this.txtIdcteServ.Name = "txtIdcteServ";
            this.txtIdcteServ.Size = new System.Drawing.Size(149, 22);
            this.txtIdcteServ.TabIndex = 4;
            // 
            // txtIdveServ
            // 
            this.txtIdveServ.Location = new System.Drawing.Point(172, 78);
            this.txtIdveServ.Name = "txtIdveServ";
            this.txtIdveServ.Size = new System.Drawing.Size(149, 22);
            this.txtIdveServ.TabIndex = 5;
            // 
            // txtIdtipServ
            // 
            this.txtIdtipServ.Location = new System.Drawing.Point(172, 110);
            this.txtIdtipServ.Name = "txtIdtipServ";
            this.txtIdtipServ.Size = new System.Drawing.Size(149, 22);
            this.txtIdtipServ.TabIndex = 6;
            // 
            // txtIdemServ
            // 
            this.txtIdemServ.Location = new System.Drawing.Point(172, 146);
            this.txtIdemServ.Name = "txtIdemServ";
            this.txtIdemServ.Size = new System.Drawing.Size(149, 22);
            this.txtIdemServ.TabIndex = 7;
            // 
            // dgvClienteVehiculo
            // 
            this.dgvClienteVehiculo.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvClienteVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteVehiculo.Location = new System.Drawing.Point(460, 44);
            this.dgvClienteVehiculo.Name = "dgvClienteVehiculo";
            this.dgvClienteVehiculo.RowTemplate.Height = 24;
            this.dgvClienteVehiculo.Size = new System.Drawing.Size(951, 124);
            this.dgvClienteVehiculo.TabIndex = 8;
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Location = new System.Drawing.Point(36, 193);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.RowTemplate.Height = 24;
            this.dgvTipoServicio.Size = new System.Drawing.Size(493, 150);
            this.dgvTipoServicio.TabIndex = 9;
            // 
            // wfServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1423, 538);
            this.Controls.Add(this.dgvTipoServicio);
            this.Controls.Add(this.dgvClienteVehiculo);
            this.Controls.Add(this.txtIdemServ);
            this.Controls.Add(this.txtIdtipServ);
            this.Controls.Add(this.txtIdveServ);
            this.Controls.Add(this.txtIdcteServ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.wfServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdcteServ;
        private System.Windows.Forms.TextBox txtIdveServ;
        private System.Windows.Forms.TextBox txtIdtipServ;
        private System.Windows.Forms.TextBox txtIdemServ;
        private System.Windows.Forms.DataGridView dgvClienteVehiculo;
        private System.Windows.Forms.DataGridView dgvTipoServicio;

    }
}