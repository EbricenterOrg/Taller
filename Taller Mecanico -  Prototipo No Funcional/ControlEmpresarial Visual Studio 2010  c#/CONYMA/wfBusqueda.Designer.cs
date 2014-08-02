namespace EBRICENTER
{
    partial class wfBusqueda
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
            this.lblBusquedaCte = new System.Windows.Forms.Label();
            this.txtBusquedaCte = new System.Windows.Forms.TextBox();
            this.bttAcepBusCte = new System.Windows.Forms.Button();
            this.TtBusquedaCte = new System.Windows.Forms.ToolTip(this.components);
            this.bttCanBusCte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBusquedaCte
            // 
            this.lblBusquedaCte.Location = new System.Drawing.Point(38, 23);
            this.lblBusquedaCte.Name = "lblBusquedaCte";
            this.lblBusquedaCte.Size = new System.Drawing.Size(83, 20);
            this.lblBusquedaCte.TabIndex = 68;
            this.lblBusquedaCte.Text = "Nombre Cliente";
            this.lblBusquedaCte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaCte
            // 
            this.txtBusquedaCte.Location = new System.Drawing.Point(127, 24);
            this.txtBusquedaCte.Name = "txtBusquedaCte";
            this.txtBusquedaCte.Size = new System.Drawing.Size(125, 20);
            this.txtBusquedaCte.TabIndex = 67;
            // 
            // bttAcepBusCte
            // 
            this.bttAcepBusCte.BackgroundImage = global::EBRICENTER.Properties.Resources.Aceptar;
            this.bttAcepBusCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAcepBusCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAcepBusCte.Location = new System.Drawing.Point(146, 50);
            this.bttAcepBusCte.Name = "bttAcepBusCte";
            this.bttAcepBusCte.Size = new System.Drawing.Size(44, 36);
            this.bttAcepBusCte.TabIndex = 104;
            // 
            // bttCanBusCte
            // 
            this.bttCanBusCte.BackgroundImage = global::EBRICENTER.Properties.Resources.Cancelar;
            this.bttCanBusCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttCanBusCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCanBusCte.Location = new System.Drawing.Point(196, 50);
            this.bttCanBusCte.Name = "bttCanBusCte";
            this.bttCanBusCte.Size = new System.Drawing.Size(44, 36);
            this.bttCanBusCte.TabIndex = 103;
            this.TtBusquedaCte.SetToolTip(this.bttCanBusCte, "Cancelar");
            this.bttCanBusCte.UseVisualStyleBackColor = true;
            // 
            // wfBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 98);
            this.Controls.Add(this.bttAcepBusCte);
            this.Controls.Add(this.bttCanBusCte);
            this.Controls.Add(this.lblBusquedaCte);
            this.Controls.Add(this.txtBusquedaCte);
            this.Name = "wfBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusquedaCte;
        private System.Windows.Forms.TextBox txtBusquedaCte;
        private System.Windows.Forms.Button bttAcepBusCte;
        private System.Windows.Forms.ToolTip TtBusquedaCte;
        private System.Windows.Forms.Button bttCanBusCte;

    }
}