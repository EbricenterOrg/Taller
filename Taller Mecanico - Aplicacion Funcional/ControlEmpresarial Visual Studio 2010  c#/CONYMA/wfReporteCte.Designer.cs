namespace EBRICENTER
{
    partial class wfReporteCte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfReporteCte));
            this.btnBusRep = new System.Windows.Forms.Button();
            this.btnSigRepCte = new System.Windows.Forms.Button();
            this.btnAtrasRepCte = new System.Windows.Forms.Button();
            this.dtpRepCte = new System.Windows.Forms.DateTimePicker();
            this.dtvRepCte = new System.Windows.Forms.DataGridView();
            this.codigo_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRepCte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRepCte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusRep
            // 
            this.btnBusRep.BackgroundImage = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBusRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBusRep.Location = new System.Drawing.Point(416, 71);
            this.btnBusRep.Name = "btnBusRep";
            this.btnBusRep.Size = new System.Drawing.Size(44, 36);
            this.btnBusRep.TabIndex = 1;
            this.btnBusRep.UseVisualStyleBackColor = true;
            // 
            // btnSigRepCte
            // 
            this.btnSigRepCte.BackgroundImage = global::EBRICENTER.Properties.Resources.Siguiente;
            this.btnSigRepCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSigRepCte.Location = new System.Drawing.Point(607, 214);
            this.btnSigRepCte.Name = "btnSigRepCte";
            this.btnSigRepCte.Size = new System.Drawing.Size(44, 36);
            this.btnSigRepCte.TabIndex = 2;
            this.btnSigRepCte.UseVisualStyleBackColor = true;
            // 
            // btnAtrasRepCte
            // 
            this.btnAtrasRepCte.BackgroundImage = global::EBRICENTER.Properties.Resources.Regresar;
            this.btnAtrasRepCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtrasRepCte.Location = new System.Drawing.Point(12, 214);
            this.btnAtrasRepCte.Name = "btnAtrasRepCte";
            this.btnAtrasRepCte.Size = new System.Drawing.Size(44, 36);
            this.btnAtrasRepCte.TabIndex = 3;
            this.btnAtrasRepCte.UseVisualStyleBackColor = true;
            // 
            // dtpRepCte
            // 
            this.dtpRepCte.Location = new System.Drawing.Point(199, 77);
            this.dtpRepCte.Name = "dtpRepCte";
            this.dtpRepCte.Size = new System.Drawing.Size(200, 20);
            this.dtpRepCte.TabIndex = 4;
            // 
            // dtvRepCte
            // 
            this.dtvRepCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRepCte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_cte,
            this.nombre_cte,
            this.direccion_cte,
            this.telefono_cte,
            this.email_cte});
            this.dtvRepCte.Location = new System.Drawing.Point(76, 125);
            this.dtvRepCte.Name = "dtvRepCte";
            this.dtvRepCte.Size = new System.Drawing.Size(543, 46);
            this.dtvRepCte.TabIndex = 5;
            // 
            // codigo_cte
            // 
            this.codigo_cte.HeaderText = "Codigo";
            this.codigo_cte.Name = "codigo_cte";
            // 
            // nombre_cte
            // 
            this.nombre_cte.HeaderText = "Nombre";
            this.nombre_cte.Name = "nombre_cte";
            // 
            // direccion_cte
            // 
            this.direccion_cte.HeaderText = "Dirección";
            this.direccion_cte.Name = "direccion_cte";
            // 
            // telefono_cte
            // 
            this.telefono_cte.HeaderText = "Teléfono";
            this.telefono_cte.Name = "telefono_cte";
            // 
            // email_cte
            // 
            this.email_cte.HeaderText = "E-mail";
            this.email_cte.Name = "email_cte";
            // 
            // lblRepCte
            // 
            this.lblRepCte.AutoSize = true;
            this.lblRepCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepCte.Location = new System.Drawing.Point(264, 33);
            this.lblRepCte.Name = "lblRepCte";
            this.lblRepCte.Size = new System.Drawing.Size(161, 25);
            this.lblRepCte.TabIndex = 6;
            this.lblRepCte.Text = "Reporte Cliente";
            // 
            // wfReporteCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 262);
            this.Controls.Add(this.lblRepCte);
            this.Controls.Add(this.dtvRepCte);
            this.Controls.Add(this.dtpRepCte);
            this.Controls.Add(this.btnAtrasRepCte);
            this.Controls.Add(this.btnSigRepCte);
            this.Controls.Add(this.btnBusRep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wfReporteCte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtvRepCte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusRep;
        private System.Windows.Forms.Button btnSigRepCte;
        private System.Windows.Forms.Button btnAtrasRepCte;
        private System.Windows.Forms.DateTimePicker dtpRepCte;
        private System.Windows.Forms.DataGridView dtvRepCte;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_cte;
        private System.Windows.Forms.Label lblRepCte;
    }
}