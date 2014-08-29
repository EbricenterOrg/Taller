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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBusqueda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBusquedaCte = new System.Windows.Forms.Label();
            this.txtBusquedaCte = new System.Windows.Forms.TextBox();
            this.bttAcepBusCte = new System.Windows.Forms.Button();
            this.TtBusquedaCte = new System.Windows.Forms.ToolTip(this.components);
            this.bttCanBusCte = new System.Windows.Forms.Button();
            this.btnBusCliente = new System.Windows.Forms.Button();
            this.dgvBusCliente = new System.Windows.Forms.DataGridView();
            this.txtBusApeCte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusquedaCte
            // 
            this.lblBusquedaCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaCte.Location = new System.Drawing.Point(316, 180);
            this.lblBusquedaCte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusquedaCte.Name = "lblBusquedaCte";
            this.lblBusquedaCte.Size = new System.Drawing.Size(111, 25);
            this.lblBusquedaCte.TabIndex = 68;
            this.lblBusquedaCte.Text = "Nombre Cliente";
            this.lblBusquedaCte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaCte
            // 
            this.txtBusquedaCte.Location = new System.Drawing.Point(435, 180);
            this.txtBusquedaCte.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaCte.Name = "txtBusquedaCte";
            this.txtBusquedaCte.Size = new System.Drawing.Size(165, 22);
            this.txtBusquedaCte.TabIndex = 67;
            // 
            // bttAcepBusCte
            // 
            this.bttAcepBusCte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAcepBusCte.BackgroundImage")));
            this.bttAcepBusCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAcepBusCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAcepBusCte.Location = new System.Drawing.Point(401, 545);
            this.bttAcepBusCte.Margin = new System.Windows.Forms.Padding(4);
            this.bttAcepBusCte.Name = "bttAcepBusCte";
            this.bttAcepBusCte.Size = new System.Drawing.Size(64, 44);
            this.bttAcepBusCte.TabIndex = 104;
            this.bttAcepBusCte.Click += new System.EventHandler(this.bttAcepBusCte_Click);
            // 
            // bttCanBusCte
            // 
            this.bttCanBusCte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttCanBusCte.BackgroundImage")));
            this.bttCanBusCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttCanBusCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCanBusCte.Location = new System.Drawing.Point(597, 545);
            this.bttCanBusCte.Margin = new System.Windows.Forms.Padding(4);
            this.bttCanBusCte.Name = "bttCanBusCte";
            this.bttCanBusCte.Size = new System.Drawing.Size(60, 44);
            this.bttCanBusCte.TabIndex = 103;
            this.TtBusquedaCte.SetToolTip(this.bttCanBusCte, "Cancelar");
            this.bttCanBusCte.UseVisualStyleBackColor = true;
            this.bttCanBusCte.Click += new System.EventHandler(this.bttCanBusCte_Click);
            // 
            // btnBusCliente
            // 
            this.btnBusCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusCliente.BackgroundImage")));
            this.btnBusCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusCliente.Location = new System.Drawing.Point(640, 169);
            this.btnBusCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusCliente.Name = "btnBusCliente";
            this.btnBusCliente.Size = new System.Drawing.Size(59, 44);
            this.btnBusCliente.TabIndex = 106;
            this.TtBusquedaCte.SetToolTip(this.btnBusCliente, "Busca a Cliente");
            this.btnBusCliente.UseVisualStyleBackColor = true;
            this.btnBusCliente.Click += new System.EventHandler(this.btnBusCliente_Click);
            // 
            // dgvBusCliente
            // 
            this.dgvBusCliente.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBusCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusCliente.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvBusCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBusCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusCliente.GridColor = System.Drawing.Color.GhostWhite;
            this.dgvBusCliente.Location = new System.Drawing.Point(84, 284);
            this.dgvBusCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBusCliente.Name = "dgvBusCliente";
            this.dgvBusCliente.ReadOnly = true;
            this.dgvBusCliente.Size = new System.Drawing.Size(896, 214);
            this.dgvBusCliente.TabIndex = 105;
            // 
            // txtBusApeCte
            // 
            this.txtBusApeCte.Location = new System.Drawing.Point(435, 212);
            this.txtBusApeCte.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusApeCte.Name = "txtBusApeCte";
            this.txtBusApeCte.Size = new System.Drawing.Size(165, 22);
            this.txtBusApeCte.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Apellido Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.Black;
            this.lblBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBusqueda.Location = new System.Drawing.Point(219, 30);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(617, 122);
            this.lblBusqueda.TabIndex = 109;
            this.lblBusqueda.Text = "Buscar Cliente";
            this.lblBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wfBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusApeCte);
            this.Controls.Add(this.btnBusCliente);
            this.Controls.Add(this.dgvBusCliente);
            this.Controls.Add(this.bttAcepBusCte);
            this.Controls.Add(this.bttCanBusCte);
            this.Controls.Add(this.lblBusquedaCte);
            this.Controls.Add(this.txtBusquedaCte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "wfBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Cliente";
            this.Load += new System.EventHandler(this.wfBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusquedaCte;
        private System.Windows.Forms.TextBox txtBusquedaCte;
        private System.Windows.Forms.Button bttAcepBusCte;
        private System.Windows.Forms.ToolTip TtBusquedaCte;
        private System.Windows.Forms.Button bttCanBusCte;
        private System.Windows.Forms.DataGridView dgvBusCliente;
        private System.Windows.Forms.Button btnBusCliente;
        private System.Windows.Forms.TextBox txtBusApeCte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBusqueda;

    }
}