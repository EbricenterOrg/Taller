namespace EBRICENTER
{
    partial class wfFactura
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
            this.TtNombreProd = new System.Windows.Forms.ToolTip(this.components);
            this.btnAcepFac = new System.Windows.Forms.Button();
            this.btnCancelaFac = new System.Windows.Forms.Button();
            this.txtCodRep = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnBuscarCte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblServ = new System.Windows.Forms.Label();
            this.lblCodRept = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtidSer = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtIdRep = new System.Windows.Forms.TextBox();
            this.txtIdServ = new System.Windows.Forms.TextBox();
            this.txtCodCte = new System.Windows.Forms.TextBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtNitCte = new System.Windows.Forms.TextBox();
            this.lblDirCte = new System.Windows.Forms.Label();
            this.txtDirCte = new System.Windows.Forms.TextBox();
            this.lblPriNomEmp = new System.Windows.Forms.Label();
            this.txtNonCteComp = new System.Windows.Forms.TextBox();
            this.lblCodFact = new System.Windows.Forms.Label();
            this.dtpFechFact = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcepFac
            // 
            this.btnAcepFac.BackgroundImage = global::EBRICENTER.Properties.Resources.Aceptar;
            this.btnAcepFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcepFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcepFac.Location = new System.Drawing.Point(372, 353);
            this.btnAcepFac.Name = "btnAcepFac";
            this.btnAcepFac.Size = new System.Drawing.Size(44, 36);
            this.btnAcepFac.TabIndex = 125;
            this.TtNombreProd.SetToolTip(this.btnAcepFac, "Aceptar");
            this.btnAcepFac.UseVisualStyleBackColor = true;
            this.btnAcepFac.Click += new System.EventHandler(this.btnAcepFac_Click);
            // 
            // btnCancelaFac
            // 
            this.btnCancelaFac.BackgroundImage = global::EBRICENTER.Properties.Resources.Cancelar;
            this.btnCancelaFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelaFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaFac.Location = new System.Drawing.Point(426, 353);
            this.btnCancelaFac.Name = "btnCancelaFac";
            this.btnCancelaFac.Size = new System.Drawing.Size(44, 36);
            this.btnCancelaFac.TabIndex = 124;
            this.TtNombreProd.SetToolTip(this.btnCancelaFac, "Cancelar");
            this.btnCancelaFac.UseVisualStyleBackColor = true;
            // 
            // txtCodRep
            // 
            this.txtCodRep.Location = new System.Drawing.Point(548, 101);
            this.txtCodRep.Name = "txtCodRep";
            this.txtCodRep.Size = new System.Drawing.Size(125, 20);
            this.txtCodRep.TabIndex = 123;
            this.TtNombreProd.SetToolTip(this.txtCodRep, "Nombre Producto a Buscar");
            this.txtCodRep.TextChanged += new System.EventHandler(this.txtBusquedaNomProd_TextChanged);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackgroundImage = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(22, 375);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(44, 36);
            this.btnBuscarProd.TabIndex = 122;
            this.TtNombreProd.SetToolTip(this.btnBuscarProd, "Buscar Producto");
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCte
            // 
            this.btnBuscarCte.BackgroundImage = global::EBRICENTER.Properties.Resources.Add;
            this.btnBuscarCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCte.Location = new System.Drawing.Point(729, 9);
            this.btnBuscarCte.Name = "btnBuscarCte";
            this.btnBuscarCte.Size = new System.Drawing.Size(40, 33);
            this.btnBuscarCte.TabIndex = 120;
            this.TtNombreProd.SetToolTip(this.btnBuscarCte, "Buscar Cliente");
            this.btnBuscarCte.UseVisualStyleBackColor = true;
            this.btnBuscarCte.Click += new System.EventHandler(this.btnBuscarCte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.txtTotalPagar);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblServ);
            this.groupBox1.Controls.Add(this.lblCodRept);
            this.groupBox1.Controls.Add(this.lblCant);
            this.groupBox1.Controls.Add(this.txtCant);
            this.groupBox1.Controls.Add(this.txtidSer);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtIdRep);
            this.groupBox1.Controls.Add(this.txtIdServ);
            this.groupBox1.Controls.Add(this.txtCodCte);
            this.groupBox1.Controls.Add(this.btnAcepFac);
            this.groupBox1.Controls.Add(this.btnCancelaFac);
            this.groupBox1.Controls.Add(this.txtCodRep);
            this.groupBox1.Controls.Add(this.btnBuscarProd);
            this.groupBox1.Controls.Add(this.dgvFactura);
            this.groupBox1.Controls.Add(this.btnBuscarCte);
            this.groupBox1.Controls.Add(this.lblNit);
            this.groupBox1.Controls.Add(this.txtNitCte);
            this.groupBox1.Controls.Add(this.lblDirCte);
            this.groupBox1.Controls.Add(this.txtDirCte);
            this.groupBox1.Controls.Add(this.lblPriNomEmp);
            this.groupBox1.Controls.Add(this.txtNonCteComp);
            this.groupBox1.Controls.Add(this.lblCodFact);
            this.groupBox1.Controls.Add(this.dtpFechFact);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 418);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modulo Facturacion";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(613, 363);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 136;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(563, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 135;
            this.lblTotal.Text = "Total";
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServ.Location = new System.Drawing.Point(422, 78);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(107, 15);
            this.lblServ.TabIndex = 134;
            this.lblServ.Text = "Codigo Servicio";
            // 
            // lblCodRept
            // 
            this.lblCodRept.AutoSize = true;
            this.lblCodRept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRept.Location = new System.Drawing.Point(422, 101);
            this.lblCodRept.Name = "lblCodRept";
            this.lblCodRept.Size = new System.Drawing.Size(117, 15);
            this.lblCodRept.TabIndex = 133;
            this.lblCodRept.Text = "Codigo Repuesto";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(679, 108);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(64, 15);
            this.lblCant.TabIndex = 132;
            this.lblCant.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(764, 103);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 131;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            // 
            // txtidSer
            // 
            this.txtidSer.Location = new System.Drawing.Point(546, 78);
            this.txtidSer.Name = "txtidSer";
            this.txtidSer.Size = new System.Drawing.Size(127, 20);
            this.txtidSer.TabIndex = 130;
            this.txtidSer.TextChanged += new System.EventHandler(this.txtidSer_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(764, 78);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 129;
            // 
            // txtIdRep
            // 
            this.txtIdRep.Location = new System.Drawing.Point(62, 375);
            this.txtIdRep.Name = "txtIdRep";
            this.txtIdRep.Size = new System.Drawing.Size(100, 20);
            this.txtIdRep.TabIndex = 128;
            // 
            // txtIdServ
            // 
            this.txtIdServ.Location = new System.Drawing.Point(62, 391);
            this.txtIdServ.Name = "txtIdServ";
            this.txtIdServ.Size = new System.Drawing.Size(100, 20);
            this.txtIdServ.TabIndex = 127;
            this.txtIdServ.Text = "0";
            // 
            // txtCodCte
            // 
            this.txtCodCte.Location = new System.Drawing.Point(72, 23);
            this.txtCodCte.Name = "txtCodCte";
            this.txtCodCte.Size = new System.Drawing.Size(76, 20);
            this.txtCodCte.TabIndex = 126;
            this.txtCodCte.Visible = false;
            // 
            // dgvFactura
            // 
            this.dgvFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clDescripcion,
            this.clUnidades,
            this.clPrecio,
            this.clTotal});
            this.dgvFactura.Location = new System.Drawing.Point(168, 147);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(545, 195);
            this.dgvFactura.TabIndex = 121;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Codigo";
            this.clCodigo.Name = "clCodigo";
            // 
            // clDescripcion
            // 
            this.clDescripcion.HeaderText = "Descripción";
            this.clDescripcion.Name = "clDescripcion";
            // 
            // clUnidades
            // 
            this.clUnidades.HeaderText = "Cantidad";
            this.clUnidades.Name = "clUnidades";
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio Unitario";
            this.clPrecio.Name = "clPrecio";
            // 
            // clTotal
            // 
            this.clTotal.HeaderText = "Total";
            this.clTotal.Name = "clTotal";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(6, 44);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(25, 15);
            this.lblNit.TabIndex = 119;
            this.lblNit.Text = "Nit";
            this.lblNit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNitCte
            // 
            this.txtNitCte.Location = new System.Drawing.Point(74, 47);
            this.txtNitCte.Name = "txtNitCte";
            this.txtNitCte.Size = new System.Drawing.Size(74, 20);
            this.txtNitCte.TabIndex = 118;
            this.txtNitCte.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDirCte
            // 
            this.lblDirCte.AutoSize = true;
            this.lblDirCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirCte.Location = new System.Drawing.Point(5, 94);
            this.lblDirCte.Name = "lblDirCte";
            this.lblDirCte.Size = new System.Drawing.Size(68, 15);
            this.lblDirCte.TabIndex = 117;
            this.lblDirCte.Text = "Dirección";
            this.lblDirCte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDirCte
            // 
            this.txtDirCte.Location = new System.Drawing.Point(74, 94);
            this.txtDirCte.Name = "txtDirCte";
            this.txtDirCte.Size = new System.Drawing.Size(342, 20);
            this.txtDirCte.TabIndex = 116;
            // 
            // lblPriNomEmp
            // 
            this.lblPriNomEmp.AutoSize = true;
            this.lblPriNomEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriNomEmp.Location = new System.Drawing.Point(5, 68);
            this.lblPriNomEmp.Name = "lblPriNomEmp";
            this.lblPriNomEmp.Size = new System.Drawing.Size(58, 15);
            this.lblPriNomEmp.TabIndex = 115;
            this.lblPriNomEmp.Text = "Nombre";
            this.lblPriNomEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNonCteComp
            // 
            this.txtNonCteComp.Location = new System.Drawing.Point(74, 71);
            this.txtNonCteComp.Name = "txtNonCteComp";
            this.txtNonCteComp.Size = new System.Drawing.Size(342, 20);
            this.txtNonCteComp.TabIndex = 114;
            // 
            // lblCodFact
            // 
            this.lblCodFact.BackColor = System.Drawing.Color.White;
            this.lblCodFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFact.ForeColor = System.Drawing.Color.Black;
            this.lblCodFact.Location = new System.Drawing.Point(631, 12);
            this.lblCodFact.Name = "lblCodFact";
            this.lblCodFact.Size = new System.Drawing.Size(93, 30);
            this.lblCodFact.TabIndex = 113;
            this.lblCodFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechFact
            // 
            this.dtpFechFact.CustomFormat = "dd-mm-yyyy";
            this.dtpFechFact.Enabled = false;
            this.dtpFechFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechFact.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechFact.Location = new System.Drawing.Point(631, 44);
            this.dtpFechFact.Name = "dtpFechFact";
            this.dtpFechFact.Size = new System.Drawing.Size(93, 21);
            this.dtpFechFact.TabIndex = 112;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(564, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 30);
            this.lbl.TabIndex = 111;
            this.lbl.Text = "Factura Serie C";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wfFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 442);
            this.Controls.Add(this.groupBox1);
            this.Name = "wfFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip TtNombreProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAcepFac;
        private System.Windows.Forms.Button btnCancelaFac;
        private System.Windows.Forms.TextBox txtCodRep;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnBuscarCte;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtNitCte;
        private System.Windows.Forms.Label lblDirCte;
        private System.Windows.Forms.TextBox txtDirCte;
        private System.Windows.Forms.Label lblPriNomEmp;
        private System.Windows.Forms.TextBox txtNonCteComp;
        private System.Windows.Forms.Label lblCodFact;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCodCte;
        private System.Windows.Forms.DateTimePicker dtpFechFact;
        private System.Windows.Forms.TextBox txtIdRep;
        private System.Windows.Forms.TextBox txtIdServ;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtidSer;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.Label lblCodRept;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalPagar;

    }
}