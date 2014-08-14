namespace EBRICENTER
{
    partial class wfBuscarProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidprovb = new System.Windows.Forms.TextBox();
            this.txtnomprovb = new System.Windows.Forms.TextBox();
            this.dtvbuscarprov = new System.Windows.Forms.DataGridView();
            this.btbuscarprov = new System.Windows.Forms.Button();
            this.btaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvbuscarprov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtidprovb
            // 
            this.txtidprovb.Location = new System.Drawing.Point(181, 35);
            this.txtidprovb.Name = "txtidprovb";
            this.txtidprovb.Size = new System.Drawing.Size(100, 20);
            this.txtidprovb.TabIndex = 2;
            // 
            // txtnomprovb
            // 
            this.txtnomprovb.Location = new System.Drawing.Point(181, 67);
            this.txtnomprovb.Name = "txtnomprovb";
            this.txtnomprovb.Size = new System.Drawing.Size(100, 20);
            this.txtnomprovb.TabIndex = 3;
            this.txtnomprovb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dtvbuscarprov
            // 
            this.dtvbuscarprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvbuscarprov.Location = new System.Drawing.Point(16, 110);
            this.dtvbuscarprov.Name = "dtvbuscarprov";
            this.dtvbuscarprov.Size = new System.Drawing.Size(513, 199);
            this.dtvbuscarprov.TabIndex = 4;
            // 
            // btbuscarprov
            // 
            this.btbuscarprov.Image = global::EBRICENTER.Properties.Resources.Buscar;
            this.btbuscarprov.Location = new System.Drawing.Point(316, 37);
            this.btbuscarprov.Name = "btbuscarprov";
            this.btbuscarprov.Size = new System.Drawing.Size(44, 36);
            this.btbuscarprov.TabIndex = 5;
            this.btbuscarprov.UseVisualStyleBackColor = true;
            this.btbuscarprov.Click += new System.EventHandler(this.btbuscarprov_Click);
            // 
            // btaceptar
            // 
            this.btaceptar.Image = global::EBRICENTER.Properties.Resources.Add;
            this.btaceptar.Location = new System.Drawing.Point(199, 315);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(44, 36);
            this.btaceptar.TabIndex = 6;
            this.btaceptar.UseVisualStyleBackColor = true;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // wfBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.btbuscarprov);
            this.Controls.Add(this.dtvbuscarprov);
            this.Controls.Add(this.txtnomprovb);
            this.Controls.Add(this.txtidprovb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "wfBuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtvbuscarprov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidprovb;
        private System.Windows.Forms.TextBox txtnomprovb;
        private System.Windows.Forms.DataGridView dtvbuscarprov;
        private System.Windows.Forms.Button btbuscarprov;
        private System.Windows.Forms.Button btaceptar;
    }
}