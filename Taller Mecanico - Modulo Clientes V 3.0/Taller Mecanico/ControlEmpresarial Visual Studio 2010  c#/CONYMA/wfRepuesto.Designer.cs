namespace EBRICENTER
{
    partial class wfRepuesto
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
            this.txtNombreRep = new System.Windows.Forms.TextBox();
            this.txtMarcaRep = new System.Windows.Forms.TextBox();
            this.txtPrecioRep = new System.Windows.Forms.TextBox();
            this.txtCantRep = new System.Windows.Forms.TextBox();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.lblMarcaRep = new System.Windows.Forms.Label();
            this.lblExistRep = new System.Windows.Forms.Label();
            this.lblPrecioRep = new System.Windows.Forms.Label();
            this.btnGuardarRep = new System.Windows.Forms.Button();
            this.btnBuscarRep = new System.Windows.Forms.Button();
            this.btnActuRep = new System.Windows.Forms.Button();
            this.btnElimRep = new System.Windows.Forms.Button();
            this.lblIdProv = new System.Windows.Forms.Label();
            this.cboIdProv = new System.Windows.Forms.ComboBox();
            this.tabproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taller2014DataSet1 = new EBRICENTER.taller2014DataSet1();
            this.taller2014DataSet = new EBRICENTER.taller2014DataSet();
            this.taller2014DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_proveedorTableAdapter = new EBRICENTER.taller2014DataSet1TableAdapters.tab_proveedorTableAdapter();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtCodRep = new System.Windows.Forms.TextBox();
            this.lblIdRep = new System.Windows.Forms.Label();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabproveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller2014DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller2014DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreRep
            // 
            this.txtNombreRep.Location = new System.Drawing.Point(206, 49);
            this.txtNombreRep.Name = "txtNombreRep";
            this.txtNombreRep.Size = new System.Drawing.Size(156, 20);
            this.txtNombreRep.TabIndex = 0;
            // 
            // txtMarcaRep
            // 
            this.txtMarcaRep.Location = new System.Drawing.Point(206, 80);
            this.txtMarcaRep.Name = "txtMarcaRep";
            this.txtMarcaRep.Size = new System.Drawing.Size(156, 20);
            this.txtMarcaRep.TabIndex = 1;
            // 
            // txtPrecioRep
            // 
            this.txtPrecioRep.Location = new System.Drawing.Point(206, 112);
            this.txtPrecioRep.Name = "txtPrecioRep";
            this.txtPrecioRep.Size = new System.Drawing.Size(156, 20);
            this.txtPrecioRep.TabIndex = 2;
            // 
            // txtCantRep
            // 
            this.txtCantRep.Location = new System.Drawing.Point(206, 144);
            this.txtCantRep.Name = "txtCantRep";
            this.txtCantRep.Size = new System.Drawing.Size(156, 20);
            this.txtCantRep.TabIndex = 3;
            // 
            // lblNomRep
            // 
            this.lblNomRep.AutoSize = true;
            this.lblNomRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRep.Location = new System.Drawing.Point(52, 49);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(148, 15);
            this.lblNomRep.TabIndex = 4;
            this.lblNomRep.Text = "Descripción Repuesto";
            // 
            // lblMarcaRep
            // 
            this.lblMarcaRep.AutoSize = true;
            this.lblMarcaRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaRep.Location = new System.Drawing.Point(53, 80);
            this.lblMarcaRep.Name = "lblMarcaRep";
            this.lblMarcaRep.Size = new System.Drawing.Size(47, 15);
            this.lblMarcaRep.TabIndex = 5;
            this.lblMarcaRep.Text = "Marca";
            // 
            // lblExistRep
            // 
            this.lblExistRep.AutoSize = true;
            this.lblExistRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistRep.Location = new System.Drawing.Point(53, 144);
            this.lblExistRep.Name = "lblExistRep";
            this.lblExistRep.Size = new System.Drawing.Size(64, 15);
            this.lblExistRep.TabIndex = 7;
            this.lblExistRep.Text = "Cantidad";
            // 
            // lblPrecioRep
            // 
            this.lblPrecioRep.AutoSize = true;
            this.lblPrecioRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioRep.Location = new System.Drawing.Point(53, 112);
            this.lblPrecioRep.Name = "lblPrecioRep";
            this.lblPrecioRep.Size = new System.Drawing.Size(48, 15);
            this.lblPrecioRep.TabIndex = 8;
            this.lblPrecioRep.Text = "Precio";
            // 
            // btnGuardarRep
            // 
            this.btnGuardarRep.Image = global::EBRICENTER.Properties.Resources.Guardar;
            this.btnGuardarRep.Location = new System.Drawing.Point(50, 236);
            this.btnGuardarRep.Name = "btnGuardarRep";
            this.btnGuardarRep.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRep.TabIndex = 9;
            this.btnGuardarRep.UseVisualStyleBackColor = true;
            this.btnGuardarRep.Click += new System.EventHandler(this.btnGuardarRep_Click);
            // 
            // btnBuscarRep
            // 
            this.btnBuscarRep.Image = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBuscarRep.Location = new System.Drawing.Point(138, 236);
            this.btnBuscarRep.Name = "btnBuscarRep";
            this.btnBuscarRep.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRep.TabIndex = 10;
            this.btnBuscarRep.UseVisualStyleBackColor = true;
            this.btnBuscarRep.Click += new System.EventHandler(this.btnBuscarRep_Click);
            // 
            // btnActuRep
            // 
            this.btnActuRep.Image = global::EBRICENTER.Properties.Resources.Refrescar;
            this.btnActuRep.Location = new System.Drawing.Point(219, 236);
            this.btnActuRep.Name = "btnActuRep";
            this.btnActuRep.Size = new System.Drawing.Size(75, 23);
            this.btnActuRep.TabIndex = 11;
            this.btnActuRep.UseVisualStyleBackColor = true;
            this.btnActuRep.Click += new System.EventHandler(this.btnActuRep_Click);
            // 
            // btnElimRep
            // 
            this.btnElimRep.Image = global::EBRICENTER.Properties.Resources.Eliminar;
            this.btnElimRep.Location = new System.Drawing.Point(300, 236);
            this.btnElimRep.Name = "btnElimRep";
            this.btnElimRep.Size = new System.Drawing.Size(75, 23);
            this.btnElimRep.TabIndex = 12;
            this.btnElimRep.UseVisualStyleBackColor = true;
            this.btnElimRep.Click += new System.EventHandler(this.btnElimRep_Click);
            // 
            // lblIdProv
            // 
            this.lblIdProv.AutoSize = true;
            this.lblIdProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProv.Location = new System.Drawing.Point(53, 186);
            this.lblIdProv.Name = "lblIdProv";
            this.lblIdProv.Size = new System.Drawing.Size(72, 15);
            this.lblIdProv.TabIndex = 13;
            this.lblIdProv.Text = "Proveedor";
            // 
            // cboIdProv
            // 
            this.cboIdProv.DataSource = this.tabproveedorBindingSource;
            this.cboIdProv.DisplayMember = "nombre_prov";
            this.cboIdProv.FormattingEnabled = true;
            this.cboIdProv.Location = new System.Drawing.Point(206, 186);
            this.cboIdProv.Name = "cboIdProv";
            this.cboIdProv.Size = new System.Drawing.Size(157, 21);
            this.cboIdProv.TabIndex = 14;
            this.cboIdProv.ValueMember = "id_prov";
            this.cboIdProv.SelectedIndexChanged += new System.EventHandler(this.cmbIdProv_SelectedIndexChanged);
            // 
            // tabproveedorBindingSource
            // 
            this.tabproveedorBindingSource.DataMember = "tab_proveedor";
            this.tabproveedorBindingSource.DataSource = this.taller2014DataSet1;
            // 
            // taller2014DataSet1
            // 
            this.taller2014DataSet1.DataSetName = "taller2014DataSet1";
            this.taller2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taller2014DataSet
            // 
            this.taller2014DataSet.DataSetName = "taller2014DataSet";
            this.taller2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taller2014DataSetBindingSource
            // 
            this.taller2014DataSetBindingSource.DataSource = this.taller2014DataSet;
            this.taller2014DataSetBindingSource.Position = 0;
            // 
            // tab_proveedorTableAdapter
            // 
            this.tab_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(231, 213);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(100, 20);
            this.txtIdProv.TabIndex = 15;
            // 
            // txtCodRep
            // 
            this.txtCodRep.Location = new System.Drawing.Point(206, 23);
            this.txtCodRep.Name = "txtCodRep";
            this.txtCodRep.Size = new System.Drawing.Size(156, 20);
            this.txtCodRep.TabIndex = 16;
            // 
            // lblIdRep
            // 
            this.lblIdRep.AutoSize = true;
            this.lblIdRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRep.Location = new System.Drawing.Point(53, 28);
            this.lblIdRep.Name = "lblIdRep";
            this.lblIdRep.Size = new System.Drawing.Size(117, 15);
            this.lblIdRep.TabIndex = 17;
            this.lblIdRep.Text = "Codigo Repuesto";
            // 
            // btnActivar
            // 
            this.btnActivar.Image = global::EBRICENTER.Properties.Resources.Nuevo;
            this.btnActivar.Location = new System.Drawing.Point(50, 274);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 18;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.UseWaitCursor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::EBRICENTER.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(138, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // wfRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 320);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.lblIdRep);
            this.Controls.Add(this.txtCodRep);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.cboIdProv);
            this.Controls.Add(this.lblIdProv);
            this.Controls.Add(this.btnElimRep);
            this.Controls.Add(this.btnActuRep);
            this.Controls.Add(this.btnBuscarRep);
            this.Controls.Add(this.btnGuardarRep);
            this.Controls.Add(this.lblPrecioRep);
            this.Controls.Add(this.lblExistRep);
            this.Controls.Add(this.lblMarcaRep);
            this.Controls.Add(this.lblNomRep);
            this.Controls.Add(this.txtCantRep);
            this.Controls.Add(this.txtPrecioRep);
            this.Controls.Add(this.txtMarcaRep);
            this.Controls.Add(this.txtNombreRep);
            this.Name = "wfRepuesto";
            this.Text = "wfRepuesto";
            this.Load += new System.EventHandler(this.wfRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabproveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller2014DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller2014DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreRep;
        private System.Windows.Forms.TextBox txtMarcaRep;
        private System.Windows.Forms.TextBox txtPrecioRep;
        private System.Windows.Forms.TextBox txtCantRep;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.Label lblMarcaRep;
        private System.Windows.Forms.Label lblExistRep;
        private System.Windows.Forms.Label lblPrecioRep;
        private System.Windows.Forms.Button btnGuardarRep;
        private System.Windows.Forms.Button btnBuscarRep;
        private System.Windows.Forms.Button btnActuRep;
        private System.Windows.Forms.Button btnElimRep;
        private System.Windows.Forms.Label lblIdProv;
        private System.Windows.Forms.ComboBox cboIdProv;
        private System.Windows.Forms.BindingSource taller2014DataSetBindingSource;
        private taller2014DataSet taller2014DataSet;
        private taller2014DataSet1 taller2014DataSet1;
        private System.Windows.Forms.BindingSource tabproveedorBindingSource;
        private taller2014DataSet1TableAdapters.tab_proveedorTableAdapter tab_proveedorTableAdapter;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.TextBox txtCodRep;
        private System.Windows.Forms.Label lblIdRep;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}