namespace EBRICENTER
{
    partial class wfReporteRep
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
            this.lblRepRep = new System.Windows.Forms.Label();
            this.txtNomRep = new System.Windows.Forms.TextBox();
            this.dgvRepRep = new System.Windows.Forms.DataGridView();
            this.txtCodRep = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepRep)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRepRep
            // 
            this.lblRepRep.AutoSize = true;
            this.lblRepRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepRep.Location = new System.Drawing.Point(189, 395);
            this.lblRepRep.Name = "lblRepRep";
            this.lblRepRep.Size = new System.Drawing.Size(131, 15);
            this.lblRepRep.TabIndex = 1;
            this.lblRepRep.Text = "Buscar por Nombre";
            // 
            // txtNomRep
            // 
            this.txtNomRep.Location = new System.Drawing.Point(326, 390);
            this.txtNomRep.Name = "txtNomRep";
            this.txtNomRep.Size = new System.Drawing.Size(100, 20);
            this.txtNomRep.TabIndex = 2;
            this.txtNomRep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvRepRep
            // 
            this.dgvRepRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepRep.Location = new System.Drawing.Point(0, -1);
            this.dgvRepRep.Name = "dgvRepRep";
            this.dgvRepRep.Size = new System.Drawing.Size(801, 370);
            this.dgvRepRep.TabIndex = 3;
            // 
            // txtCodRep
            // 
            this.txtCodRep.Location = new System.Drawing.Point(83, 394);
            this.txtCodRep.Name = "txtCodRep";
            this.txtCodRep.Size = new System.Drawing.Size(100, 20);
            this.txtCodRep.TabIndex = 4;
            this.txtCodRep.Text = "1";
            this.txtCodRep.Visible = false;
            this.txtCodRep.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // wfReporteRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 441);
            this.Controls.Add(this.txtCodRep);
            this.Controls.Add(this.dgvRepRep);
            this.Controls.Add(this.txtNomRep);
            this.Controls.Add(this.lblRepRep);
            this.Controls.Add(this.button1);
            this.Name = "wfReporteRep";
            this.Text = "wfReporteRep";
            this.Load += new System.EventHandler(this.wfReporteRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRepRep;
        private System.Windows.Forms.TextBox txtNomRep;
        private System.Windows.Forms.DataGridView dgvRepRep;
        private System.Windows.Forms.TextBox txtCodRep;
    }
}