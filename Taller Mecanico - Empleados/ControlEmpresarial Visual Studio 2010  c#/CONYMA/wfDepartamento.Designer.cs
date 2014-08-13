namespace EBRICENTER
{
    partial class wfDepartamento
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
            this.lblCodDepto = new System.Windows.Forms.Label();
            this.lblDesDepto = new System.Windows.Forms.Label();
            this.txtCodDepto = new System.Windows.Forms.TextBox();
            this.txtDescDepto = new System.Windows.Forms.TextBox();
            this.btnGuardarDepto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodDepto
            // 
            this.lblCodDepto.AutoSize = true;
            this.lblCodDepto.Location = new System.Drawing.Point(26, 47);
            this.lblCodDepto.Name = "lblCodDepto";
            this.lblCodDepto.Size = new System.Drawing.Size(110, 13);
            this.lblCodDepto.TabIndex = 0;
            this.lblCodDepto.Text = "Codigo Departamento";
            // 
            // lblDesDepto
            // 
            this.lblDesDepto.AutoSize = true;
            this.lblDesDepto.Location = new System.Drawing.Point(26, 77);
            this.lblDesDepto.Name = "lblDesDepto";
            this.lblDesDepto.Size = new System.Drawing.Size(63, 13);
            this.lblDesDepto.TabIndex = 1;
            this.lblDesDepto.Text = "Descripcion";
            // 
            // txtCodDepto
            // 
            this.txtCodDepto.Location = new System.Drawing.Point(142, 44);
            this.txtCodDepto.Name = "txtCodDepto";
            this.txtCodDepto.Size = new System.Drawing.Size(109, 20);
            this.txtCodDepto.TabIndex = 2;
            // 
            // txtDescDepto
            // 
            this.txtDescDepto.Location = new System.Drawing.Point(143, 70);
            this.txtDescDepto.Name = "txtDescDepto";
            this.txtDescDepto.Size = new System.Drawing.Size(108, 20);
            this.txtDescDepto.TabIndex = 3;
            this.txtDescDepto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnGuardarDepto
            // 
            this.btnGuardarDepto.Location = new System.Drawing.Point(90, 107);
            this.btnGuardarDepto.Name = "btnGuardarDepto";
            this.btnGuardarDepto.Size = new System.Drawing.Size(74, 29);
            this.btnGuardarDepto.TabIndex = 4;
            this.btnGuardarDepto.Text = "Guardar";
            this.btnGuardarDepto.UseVisualStyleBackColor = true;
            this.btnGuardarDepto.Click += new System.EventHandler(this.btnGuardarDepto_Click);
            // 
            // wfDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGuardarDepto);
            this.Controls.Add(this.txtDescDepto);
            this.Controls.Add(this.txtCodDepto);
            this.Controls.Add(this.lblDesDepto);
            this.Controls.Add(this.lblCodDepto);
            this.Name = "wfDepartamento";
            this.Text = "wfDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodDepto;
        private System.Windows.Forms.Label lblDesDepto;
        private System.Windows.Forms.TextBox txtCodDepto;
        private System.Windows.Forms.TextBox txtDescDepto;
        private System.Windows.Forms.Button btnGuardarDepto;
    }
}