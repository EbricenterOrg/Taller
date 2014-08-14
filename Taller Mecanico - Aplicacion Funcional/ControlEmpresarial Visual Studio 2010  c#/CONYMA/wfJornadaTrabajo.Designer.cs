namespace EBRICENTER
{
    partial class wfJornadaTrabajo
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
            this.lblidjornada = new System.Windows.Forms.Label();
            this.lbldescjornada = new System.Windows.Forms.Label();
            this.txtidjornada = new System.Windows.Forms.TextBox();
            this.txtdescjornada = new System.Windows.Forms.TextBox();
            this.btnGuradarJ = new System.Windows.Forms.Button();
            this.lblRegJTrabajo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblidjornada
            // 
            this.lblidjornada.AutoSize = true;
            this.lblidjornada.Location = new System.Drawing.Point(59, 73);
            this.lblidjornada.Name = "lblidjornada";
            this.lblidjornada.Size = new System.Drawing.Size(81, 13);
            this.lblidjornada.TabIndex = 0;
            this.lblidjornada.Text = "Codigo Jornada";
            this.lblidjornada.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldescjornada
            // 
            this.lbldescjornada.AutoSize = true;
            this.lbldescjornada.Location = new System.Drawing.Point(59, 109);
            this.lbldescjornada.Name = "lbldescjornada";
            this.lbldescjornada.Size = new System.Drawing.Size(63, 13);
            this.lbldescjornada.TabIndex = 1;
            this.lbldescjornada.Text = "Descripcion";
            // 
            // txtidjornada
            // 
            this.txtidjornada.Location = new System.Drawing.Point(146, 70);
            this.txtidjornada.Name = "txtidjornada";
            this.txtidjornada.Size = new System.Drawing.Size(101, 20);
            this.txtidjornada.TabIndex = 2;
            this.txtidjornada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdescjornada
            // 
            this.txtdescjornada.Location = new System.Drawing.Point(146, 106);
            this.txtdescjornada.Name = "txtdescjornada";
            this.txtdescjornada.Size = new System.Drawing.Size(101, 20);
            this.txtdescjornada.TabIndex = 3;
            // 
            // btnGuradarJ
            // 
            this.btnGuradarJ.Image = global::EBRICENTER.Properties.Resources.Guardar;
            this.btnGuradarJ.Location = new System.Drawing.Point(89, 151);
            this.btnGuradarJ.Name = "btnGuradarJ";
            this.btnGuradarJ.Size = new System.Drawing.Size(44, 36);
            this.btnGuradarJ.TabIndex = 4;
            this.btnGuradarJ.UseVisualStyleBackColor = true;
            this.btnGuradarJ.Click += new System.EventHandler(this.btnGuradarJ_Click);
            // 
            // lblRegJTrabajo
            // 
            this.lblRegJTrabajo.AutoSize = true;
            this.lblRegJTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegJTrabajo.Location = new System.Drawing.Point(29, 28);
            this.lblRegJTrabajo.Name = "lblRegJTrabajo";
            this.lblRegJTrabajo.Size = new System.Drawing.Size(243, 20);
            this.lblRegJTrabajo.TabIndex = 5;
            this.lblRegJTrabajo.Text = "Registrar Jornada de Trabajo";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::EBRICENTER.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(173, 151);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // wfJornadaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 224);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegJTrabajo);
            this.Controls.Add(this.btnGuradarJ);
            this.Controls.Add(this.txtdescjornada);
            this.Controls.Add(this.txtidjornada);
            this.Controls.Add(this.lbldescjornada);
            this.Controls.Add(this.lblidjornada);
            this.Name = "wfJornadaTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfJornadaTrabajo";
            this.Load += new System.EventHandler(this.wfJornadaTrabajo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidjornada;
        private System.Windows.Forms.Label lbldescjornada;
        private System.Windows.Forms.TextBox txtidjornada;
        private System.Windows.Forms.TextBox txtdescjornada;
        private System.Windows.Forms.Button btnGuradarJ;
        private System.Windows.Forms.Label lblRegJTrabajo;
        private System.Windows.Forms.Button btnSalir;
    }
}