namespace EBRICENTER
{
    partial class wfInformacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfInformacion));
            this.tlpPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tlpPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPanel1
            // 
            this.tlpPanel1.ColumnCount = 2;
            this.tlpPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tlpPanel1.Controls.Add(this.pboLogo, 0, 0);
            this.tlpPanel1.Controls.Add(this.lblNomProducto, 1, 0);
            this.tlpPanel1.Controls.Add(this.lblVersion, 1, 1);
            this.tlpPanel1.Controls.Add(this.lblCopyright, 1, 2);
            this.tlpPanel1.Controls.Add(this.lblComName, 1, 3);
            this.tlpPanel1.Controls.Add(this.txtDescription, 1, 4);
            this.tlpPanel1.Controls.Add(this.btnAceptar, 1, 5);
            this.tlpPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanel1.Location = new System.Drawing.Point(9, 9);
            this.tlpPanel1.Name = "tlpPanel1";
            this.tlpPanel1.RowCount = 6;
            this.tlpPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel1.Size = new System.Drawing.Size(417, 265);
            this.tlpPanel1.TabIndex = 0;
            // 
            // pboLogo
            // 
            this.pboLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboLogo.Image")));
            this.pboLogo.Location = new System.Drawing.Point(3, 3);
            this.pboLogo.Name = "pboLogo";
            this.tlpPanel1.SetRowSpan(this.pboLogo, 6);
            this.pboLogo.Size = new System.Drawing.Size(131, 230);
            this.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLogo.TabIndex = 12;
            this.pboLogo.TabStop = false;
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomProducto.Location = new System.Drawing.Point(143, 0);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblNomProducto.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(271, 17);
            this.lblNomProducto.TabIndex = 19;
            this.lblNomProducto.Text = "Nombre de producto: Taller Mecánico";
            this.lblNomProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomProducto.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(143, 26);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(271, 17);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Versión: Prototipo 1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(143, 52);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(271, 17);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComName
            // 
            this.lblComName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComName.Location = new System.Drawing.Point(143, 78);
            this.lblComName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblComName.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(271, 17);
            this.lblComName.TabIndex = 22;
            this.lblComName.Text = "Nombre de la compañía: Ebri Center";
            this.lblComName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(143, 107);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(271, 126);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = "Descripción:\r\n\r\nPrototipo planteado por el Grupo No. 4";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(339, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // wfInformacion
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.tlpPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfInformacion";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.wfAcercaDe_Load);
            this.tlpPanel1.ResumeLayout(false);
            this.tlpPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPanel1;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAceptar;
    }
}
