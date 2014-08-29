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
            this.btnSigRepCte = new System.Windows.Forms.Button();
            this.btnAtrasRepCte = new System.Windows.Forms.Button();
            this.dtvRepCte = new System.Windows.Forms.DataGridView();
            this.lblRepCte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRepCte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSigRepCte
            // 
            this.btnSigRepCte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSigRepCte.BackgroundImage")));
            this.btnSigRepCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSigRepCte.Location = new System.Drawing.Point(963, 618);
            this.btnSigRepCte.Margin = new System.Windows.Forms.Padding(4);
            this.btnSigRepCte.Name = "btnSigRepCte";
            this.btnSigRepCte.Size = new System.Drawing.Size(59, 44);
            this.btnSigRepCte.TabIndex = 2;
            this.btnSigRepCte.UseVisualStyleBackColor = true;
            // 
            // btnAtrasRepCte
            // 
            this.btnAtrasRepCte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtrasRepCte.BackgroundImage")));
            this.btnAtrasRepCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtrasRepCte.Location = new System.Drawing.Point(64, 618);
            this.btnAtrasRepCte.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtrasRepCte.Name = "btnAtrasRepCte";
            this.btnAtrasRepCte.Size = new System.Drawing.Size(59, 44);
            this.btnAtrasRepCte.TabIndex = 3;
            this.btnAtrasRepCte.UseVisualStyleBackColor = true;
            // 
            // dtvRepCte
            // 
            this.dtvRepCte.AllowUserToAddRows = false;
            this.dtvRepCte.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtvRepCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRepCte.Location = new System.Drawing.Point(64, 142);
            this.dtvRepCte.Margin = new System.Windows.Forms.Padding(4);
            this.dtvRepCte.Name = "dtvRepCte";
            this.dtvRepCte.ReadOnly = true;
            this.dtvRepCte.Size = new System.Drawing.Size(958, 468);
            this.dtvRepCte.TabIndex = 5;
            // 
            // lblRepCte
            // 
            this.lblRepCte.AutoSize = true;
            this.lblRepCte.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepCte.Location = new System.Drawing.Point(365, 63);
            this.lblRepCte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepCte.Name = "lblRepCte";
            this.lblRepCte.Size = new System.Drawing.Size(322, 47);
            this.lblRepCte.TabIndex = 6;
            this.lblRepCte.Text = "Reporte Cliente";
            // 
            // wfReporteCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1077, 692);
            this.Controls.Add(this.lblRepCte);
            this.Controls.Add(this.dtvRepCte);
            this.Controls.Add(this.btnAtrasRepCte);
            this.Controls.Add(this.btnSigRepCte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "wfReporteCte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cliente";
            this.Load += new System.EventHandler(this.wfReporteCte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvRepCte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSigRepCte;
        private System.Windows.Forms.Button btnAtrasRepCte;
        private System.Windows.Forms.DataGridView dtvRepCte;
        private System.Windows.Forms.Label lblRepCte;
    }
}