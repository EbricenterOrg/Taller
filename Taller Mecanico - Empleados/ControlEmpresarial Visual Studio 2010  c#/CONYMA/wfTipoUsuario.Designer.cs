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
            this.SuspendLayout();
            // 
            // lblCodTipoUsuario
            // 
            this.lblCodTipoUsuario.AutoSize = true;
            this.lblCodTipoUsuario.Location = new System.Drawing.Point(46, 37);
            this.lblCodTipoUsuario.Name = "lblCodTipoUsuario";
            this.lblCodTipoUsuario.Size = new System.Drawing.Size(103, 13);
            this.lblCodTipoUsuario.TabIndex = 0;
            this.lblCodTipoUsuario.Text = "Codigo Tipo Usuario";
            // 
            // lblDescTipoUsuario
            // 
            this.lblDescTipoUsuario.AutoSize = true;
            this.lblDescTipoUsuario.Location = new System.Drawing.Point(46, 74);
            this.lblDescTipoUsuario.Name = "lblDescTipoUsuario";
            this.lblDescTipoUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblDescTipoUsuario.TabIndex = 1;
            this.lblDescTipoUsuario.Text = "Tipo Usuario";
            // 
            // txtCodTipUsuario
            // 
            this.txtCodTipUsuario.Location = new System.Drawing.Point(155, 30);
            this.txtCodTipUsuario.Name = "txtCodTipUsuario";
            this.txtCodTipUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodTipUsuario.TabIndex = 2;
            // 
            // txtDescTipoUsuario
            // 
            this.txtDescTipoUsuario.Location = new System.Drawing.Point(155, 67);
            this.txtDescTipoUsuario.Name = "txtDescTipoUsuario";
            this.txtDescTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtDescTipoUsuario.TabIndex = 3;
            // 
            // btnGuardarTipoUsuario
            // 
            this.btnGuardarTipoUsuario.Location = new System.Drawing.Point(123, 109);
            this.btnGuardarTipoUsuario.Name = "btnGuardarTipoUsuario";
            this.btnGuardarTipoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTipoUsuario.TabIndex = 4;
            this.btnGuardarTipoUsuario.Text = "Guardar";
            this.btnGuardarTipoUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarTipoUsuario.Click += new System.EventHandler(this.btnGuardarTipoUsuario_Click);
            // 
            // wfTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 201);
            this.Controls.Add(this.btnGuardarTipoUsuario);
            this.Controls.Add(this.txtDescTipoUsuario);
            this.Controls.Add(this.txtCodTipUsuario);
            this.Controls.Add(this.lblDescTipoUsuario);
            this.Controls.Add(this.lblCodTipoUsuario);
            this.Name = "wfTipoUsuario";
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
    }
}