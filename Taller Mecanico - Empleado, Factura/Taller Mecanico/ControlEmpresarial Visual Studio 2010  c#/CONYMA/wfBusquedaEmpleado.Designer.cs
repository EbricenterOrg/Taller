namespace EBRICENTER
{
    partial class wfBusquedaEmpleado
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
            this.lblCodCte = new System.Windows.Forms.Label();
            this.txtCodEmpb = new System.Windows.Forms.TextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.dgvDatosEmp = new System.Windows.Forms.DataGridView();
            this.btnEnviardDtxtEmp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqdaNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCte
            // 
            this.lblCodCte.AutoSize = true;
            this.lblCodCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCte.Location = new System.Drawing.Point(127, 63);
            this.lblCodCte.Name = "lblCodCte";
            this.lblCodCte.Size = new System.Drawing.Size(107, 15);
            this.lblCodCte.TabIndex = 0;
            this.lblCodCte.Text = "Nombre Cliente";
            // 
            // txtCodEmpb
            // 
            this.txtCodEmpb.Location = new System.Drawing.Point(24, 18);
            this.txtCodEmpb.Name = "txtCodEmpb";
            this.txtCodEmpb.Size = new System.Drawing.Size(100, 20);
            this.txtCodEmpb.TabIndex = 1;
            this.txtCodEmpb.Text = "1";
            this.txtCodEmpb.Visible = false;
            this.txtCodEmpb.TextChanged += new System.EventHandler(this.txtCodEmpb_TextChanged);
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Image = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBuscarEmp.Location = new System.Drawing.Point(395, 49);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(44, 36);
            this.btnBuscarEmp.TabIndex = 4;
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // dgvDatosEmp
            // 
            this.dgvDatosEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEmp.Location = new System.Drawing.Point(24, 96);
            this.dgvDatosEmp.Name = "dgvDatosEmp";
            this.dgvDatosEmp.Size = new System.Drawing.Size(532, 191);
            this.dgvDatosEmp.TabIndex = 5;
            // 
            // btnEnviardDtxtEmp
            // 
            this.btnEnviardDtxtEmp.Image = global::EBRICENTER.Properties.Resources.Add;
            this.btnEnviardDtxtEmp.Location = new System.Drawing.Point(215, 305);
            this.btnEnviardDtxtEmp.Name = "btnEnviardDtxtEmp";
            this.btnEnviardDtxtEmp.Size = new System.Drawing.Size(44, 36);
            this.btnEnviardDtxtEmp.TabIndex = 6;
            this.btnEnviardDtxtEmp.UseVisualStyleBackColor = true;
            this.btnEnviardDtxtEmp.Click += new System.EventHandler(this.btnEnviardDtxtEmp_Click);
            // 
            // button2
            // 
            this.button2.Image = global::EBRICENTER.Properties.Resources.Salir;
            this.button2.Location = new System.Drawing.Point(296, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 36);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(172, 18);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(200, 20);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Busqueda de Empleado";
            // 
            // txtBusqdaNombre
            // 
            this.txtBusqdaNombre.Location = new System.Drawing.Point(240, 58);
            this.txtBusqdaNombre.Name = "txtBusqdaNombre";
            this.txtBusqdaNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBusqdaNombre.TabIndex = 9;
            this.txtBusqdaNombre.TextChanged += new System.EventHandler(this.txtBusqdaNombre_TextChanged);
            // 
            // wfBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 358);
            this.Controls.Add(this.txtBusqdaNombre);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnviardDtxtEmp);
            this.Controls.Add(this.dgvDatosEmp);
            this.Controls.Add(this.btnBuscarEmp);
            this.Controls.Add(this.txtCodEmpb);
            this.Controls.Add(this.lblCodCte);
            this.Name = "wfBusquedaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfBusquedaEmpleado";
            this.Load += new System.EventHandler(this.wfBusquedaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCte;
        private System.Windows.Forms.TextBox txtCodEmpb;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.DataGridView dgvDatosEmp;
        private System.Windows.Forms.Button btnEnviardDtxtEmp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqdaNombre;
    }
}