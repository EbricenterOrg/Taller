namespace EBRICENTER
{
    partial class wfBuscarRepuesto
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
            this.lblIdRep = new System.Windows.Forms.Label();
            this.lblDescRep = new System.Windows.Forms.Label();
            this.txtCodRep = new System.Windows.Forms.TextBox();
            this.txtDescRep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBusRep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusRep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdRep
            // 
            this.lblIdRep.AutoSize = true;
            this.lblIdRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRep.Location = new System.Drawing.Point(90, 28);
            this.lblIdRep.Name = "lblIdRep";
            this.lblIdRep.Size = new System.Drawing.Size(117, 15);
            this.lblIdRep.TabIndex = 0;
            this.lblIdRep.Text = "Codigo Repuesto";
            // 
            // lblDescRep
            // 
            this.lblDescRep.AutoSize = true;
            this.lblDescRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescRep.Location = new System.Drawing.Point(90, 67);
            this.lblDescRep.Name = "lblDescRep";
            this.lblDescRep.Size = new System.Drawing.Size(83, 15);
            this.lblDescRep.TabIndex = 1;
            this.lblDescRep.Text = "Descripción";
            // 
            // txtCodRep
            // 
            this.txtCodRep.Location = new System.Drawing.Point(213, 28);
            this.txtCodRep.Name = "txtCodRep";
            this.txtCodRep.Size = new System.Drawing.Size(161, 20);
            this.txtCodRep.TabIndex = 2;
            this.txtCodRep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescRep
            // 
            this.txtDescRep.Location = new System.Drawing.Point(213, 67);
            this.txtDescRep.Name = "txtDescRep";
            this.txtDescRep.Size = new System.Drawing.Size(161, 20);
            this.txtDescRep.TabIndex = 3;
            this.txtDescRep.TextChanged += new System.EventHandler(this.txtDescRep_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBusRep
            // 
            this.dgvBusRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusRep.Location = new System.Drawing.Point(0, 111);
            this.dgvBusRep.Name = "dgvBusRep";
            this.dgvBusRep.Size = new System.Drawing.Size(543, 222);
            this.dgvBusRep.TabIndex = 5;
            // 
            // wfBuscarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 385);
            this.Controls.Add(this.dgvBusRep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescRep);
            this.Controls.Add(this.txtCodRep);
            this.Controls.Add(this.lblDescRep);
            this.Controls.Add(this.lblIdRep);
            this.Name = "wfBuscarRepuesto";
            this.Text = "wfBuscarRepuesto";
            this.Load += new System.EventHandler(this.wfBuscarRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdRep;
        private System.Windows.Forms.Label lblDescRep;
        private System.Windows.Forms.TextBox txtCodRep;
        private System.Windows.Forms.TextBox txtDescRep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBusRep;
    }
}