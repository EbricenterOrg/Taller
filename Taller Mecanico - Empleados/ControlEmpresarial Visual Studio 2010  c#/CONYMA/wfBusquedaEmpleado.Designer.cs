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
            this.txtNomEmpb = new System.Windows.Forms.TextBox();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.dgvDatosEmp = new System.Windows.Forms.DataGridView();
            this.btnEnviardDtxtEmp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCte
            // 
            this.lblCodCte.AutoSize = true;
            this.lblCodCte.Location = new System.Drawing.Point(130, 24);
            this.lblCodCte.Name = "lblCodCte";
            this.lblCodCte.Size = new System.Drawing.Size(75, 13);
            this.lblCodCte.TabIndex = 0;
            this.lblCodCte.Text = "Codigo Cliente";
            // 
            // txtCodEmpb
            // 
            this.txtCodEmpb.Location = new System.Drawing.Point(230, 21);
            this.txtCodEmpb.Name = "txtCodEmpb";
            this.txtCodEmpb.Size = new System.Drawing.Size(100, 20);
            this.txtCodEmpb.TabIndex = 1;
            // 
            // txtNomEmpb
            // 
            this.txtNomEmpb.Location = new System.Drawing.Point(230, 43);
            this.txtNomEmpb.Name = "txtNomEmpb";
            this.txtNomEmpb.Size = new System.Drawing.Size(100, 20);
            this.txtNomEmpb.TabIndex = 2;
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Location = new System.Drawing.Point(130, 50);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmp.TabIndex = 3;
            this.lblNombreEmp.Text = "Nombre Empleado";
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Location = new System.Drawing.Point(365, 24);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmp.TabIndex = 4;
            this.btnBuscarEmp.Text = "Buscar";
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
            this.btnEnviardDtxtEmp.Location = new System.Drawing.Point(103, 306);
            this.btnEnviardDtxtEmp.Name = "btnEnviardDtxtEmp";
            this.btnEnviardDtxtEmp.Size = new System.Drawing.Size(121, 23);
            this.btnEnviardDtxtEmp.TabIndex = 6;
            this.btnEnviardDtxtEmp.Text = "Enviar Datos";
            this.btnEnviardDtxtEmp.UseVisualStyleBackColor = true;
            this.btnEnviardDtxtEmp.Click += new System.EventHandler(this.btnEnviardDtxtEmp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // wfBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnviardDtxtEmp);
            this.Controls.Add(this.dgvDatosEmp);
            this.Controls.Add(this.btnBuscarEmp);
            this.Controls.Add(this.lblNombreEmp);
            this.Controls.Add(this.txtNomEmpb);
            this.Controls.Add(this.txtCodEmpb);
            this.Controls.Add(this.lblCodCte);
            this.Name = "wfBusquedaEmpleado";
            this.Text = "wfBusquedaEmpleado";
            this.Load += new System.EventHandler(this.wfBusquedaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCte;
        private System.Windows.Forms.TextBox txtCodEmpb;
        private System.Windows.Forms.TextBox txtNomEmpb;
        private System.Windows.Forms.Label lblNombreEmp;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.DataGridView dgvDatosEmp;
        private System.Windows.Forms.Button btnEnviardDtxtEmp;
        private System.Windows.Forms.Button button2;
    }
}