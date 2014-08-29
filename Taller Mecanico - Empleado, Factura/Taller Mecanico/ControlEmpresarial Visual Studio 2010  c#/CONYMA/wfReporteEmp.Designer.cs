namespace EBRICENTER
{
    partial class wfReporteEmp
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRepEmp = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.lblBusEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1095, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRepEmp
            // 
            this.dgvRepEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepEmp.Location = new System.Drawing.Point(0, 0);
            this.dgvRepEmp.Name = "dgvRepEmp";
            this.dgvRepEmp.Size = new System.Drawing.Size(1170, 331);
            this.dgvRepEmp.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::EBRICENTER.Properties.Resources.Add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(668, 338);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 44);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new System.Drawing.Point(476, 351);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(161, 20);
            this.txtNomEmp.TabIndex = 4;
            this.txtNomEmp.WordWrap = false;
            this.txtNomEmp.TextChanged += new System.EventHandler(this.txtNomEmp_TextChanged);
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(370, 351);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(100, 20);
            this.txtCodEmp.TabIndex = 2;
            this.txtCodEmp.Visible = false;
            // 
            // lblBusEmp
            // 
            this.lblBusEmp.AutoSize = true;
            this.lblBusEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusEmp.Location = new System.Drawing.Point(307, 351);
            this.lblBusEmp.Name = "lblBusEmp";
            this.lblBusEmp.Size = new System.Drawing.Size(163, 20);
            this.lblBusEmp.TabIndex = 5;
            this.lblBusEmp.Text = "Buscar por Nombre";
            // 
            // wfReporteEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 389);
            this.Controls.Add(this.lblBusEmp);
            this.Controls.Add(this.txtNomEmp);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtCodEmp);
            this.Controls.Add(this.dgvRepEmp);
            this.Controls.Add(this.button1);
            this.Name = "wfReporteEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfReporteEmp";
            this.Load += new System.EventHandler(this.wfReporteEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRepEmp;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.Label lblBusEmp;
    }
}