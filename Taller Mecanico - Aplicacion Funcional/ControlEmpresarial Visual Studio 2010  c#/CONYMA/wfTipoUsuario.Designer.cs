namespace EBRICENTER
{
    partial class wfTipoUsuario
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
            this.lblCodTipoUsuario = new System.Windows.Forms.Label();
            this.lblDescTipoUsuario = new System.Windows.Forms.Label();
            this.txtCodTipUsuario = new System.Windows.Forms.TextBox();
            this.txtDescTipoUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardarTipoUsuario = new System.Windows.Forms.Button();
            this.lblRegitroTU = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodTipoUsuario
            // 
            this.lblCodTipoUsuario.AutoSize = true;
            this.lblCodTipoUsuario.Location = new System.Drawing.Point(29, 86);
            this.lblCodTipoUsuario.Name = "lblCodTipoUsuario";
            this.lblCodTipoUsuario.Size = new System.Drawing.Size(103, 13);
            this.lblCodTipoUsuario.TabIndex = 0;
            this.lblCodTipoUsuario.Text = "Codigo Tipo Usuario";
            // 
            // lblDescTipoUsuario
            // 
            this.lblDescTipoUsuario.AutoSize = true;
            this.lblDescTipoUsuario.Location = new System.Drawing.Point(42, 123);
            this.lblDescTipoUsuario.Name = "lblDescTipoUsuario";
            this.lblDescTipoUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblDescTipoUsuario.TabIndex = 1;
            this.lblDescTipoUsuario.Text = "Tipo Usuario";
            // 
            // txtCodTipUsuario
            // 
            this.txtCodTipUsuario.Location = new System.Drawing.Point(151, 79);
            this.txtCodTipUsuario.Name = "txtCodTipUsuario";
            this.txtCodTipUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodTipUsuario.TabIndex = 2;
            // 
            // txtDescTipoUsuario
            // 
            this.txtDescTipoUsuario.Location = new System.Drawing.Point(151, 116);
            this.txtDescTipoUsuario.Name = "txtDescTipoUsuario";
            this.txtDescTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtDescTipoUsuario.TabIndex = 3;
            // 
            // btnGuardarTipoUsuario
            // 
            this.btnGuardarTipoUsuario.Image = global::EBRICENTER.Properties.Resources.Guardar;
            this.btnGuardarTipoUsuario.Location = new System.Drawing.Point(88, 162);
            this.btnGuardarTipoUsuario.Name = "btnGuardarTipoUsuario";
            this.btnGuardarTipoUsuario.Size = new System.Drawing.Size(44, 36);
            this.btnGuardarTipoUsuario.TabIndex = 4;
            this.btnGuardarTipoUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarTipoUsuario.Click += new System.EventHandler(this.btnGuardarTipoUsuario_Click);
            // 
            // lblRegitroTU
            // 
            this.lblRegitroTU.AutoSize = true;
            this.lblRegitroTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegitroTU.Location = new System.Drawing.Point(44, 42);
            this.lblRegitroTU.Name = "lblRegitroTU";
            this.lblRegitroTU.Size = new System.Drawing.Size(183, 20);
            this.lblRegitroTU.TabIndex = 5;
            this.lblRegitroTU.Text = "Registro Tipo Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::EBRICENTER.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(151, 162);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // wfTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 210);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegitroTU);
            this.Controls.Add(this.btnGuardarTipoUsuario);
            this.Controls.Add(this.txtDescTipoUsuario);
            this.Controls.Add(this.txtCodTipUsuario);
            this.Controls.Add(this.lblDescTipoUsuario);
            this.Controls.Add(this.lblCodTipoUsuario);
            this.Name = "wfTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfTipoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodTipoUsuario;
        private System.Windows.Forms.Label lblDescTipoUsuario;
        private System.Windows.Forms.TextBox txtCodTipUsuario;
        private System.Windows.Forms.TextBox txtDescTipoUsuario;
        private System.Windows.Forms.Button btnGuardarTipoUsuario;
        private System.Windows.Forms.Label lblRegitroTU;
        private System.Windows.Forms.Button btnSalir;
    }
}