﻿namespace EBRICENTER
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
            this.txtBusquedaNomProd = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnBuscarCte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPriNomEmp = new System.Windows.Forms.Label();
            this.txtPriNomEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnAcepFac.Location = new System.Drawing.Point(574, 224);
            this.btnAcepFac.Name = "btnAcepFac";
            this.btnAcepFac.Size = new System.Drawing.Size(44, 36);
            this.btnAcepFac.TabIndex = 125;
            this.TtNombreProd.SetToolTip(this.btnAcepFac, "Aceptar");
            this.btnAcepFac.UseVisualStyleBackColor = true;
            // 
            // btnCancelaFac
            // 
            this.btnCancelaFac.BackgroundImage = global::EBRICENTER.Properties.Resources.Cancelar;
            this.btnCancelaFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelaFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaFac.Location = new System.Drawing.Point(624, 224);
            this.btnCancelaFac.Name = "btnCancelaFac";
            this.btnCancelaFac.Size = new System.Drawing.Size(44, 36);
            this.btnCancelaFac.TabIndex = 124;
            this.TtNombreProd.SetToolTip(this.btnCancelaFac, "Cancelar");
            this.btnCancelaFac.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaNomProd
            // 
            this.txtBusquedaNomProd.Location = new System.Drawing.Point(23, 224);
            this.txtBusquedaNomProd.Name = "txtBusquedaNomProd";
            this.txtBusquedaNomProd.Size = new System.Drawing.Size(125, 20);
            this.txtBusquedaNomProd.TabIndex = 123;
            this.TtNombreProd.SetToolTip(this.txtBusquedaNomProd, "Nombre Producto a Buscar");
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackgroundImage = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(168, 224);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(44, 36);
            this.btnBuscarProd.TabIndex = 122;
            this.TtNombreProd.SetToolTip(this.btnBuscarProd, "Buscar Producto");
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCte
            // 
            this.btnBuscarCte.BackgroundImage = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBuscarCte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCte.Location = new System.Drawing.Point(431, 68);
            this.btnBuscarCte.Name = "btnBuscarCte";
            this.btnBuscarCte.Size = new System.Drawing.Size(40, 33);
            this.btnBuscarCte.TabIndex = 120;
            this.TtNombreProd.SetToolTip(this.btnBuscarCte, "Buscar Cliente");
            this.btnBuscarCte.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.btnAcepFac);
            this.groupBox1.Controls.Add(this.btnCancelaFac);
            this.groupBox1.Controls.Add(this.txtBusquedaNomProd);
            this.groupBox1.Controls.Add(this.btnBuscarProd);
            this.groupBox1.Controls.Add(this.dgvFactura);
            this.groupBox1.Controls.Add(this.btnBuscarCte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblPriNomEmp);
            this.groupBox1.Controls.Add(this.txtPriNomEmp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 276);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modulo Facturacion";
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
            this.clDescuento,
            this.clTotal});
            this.dgvFactura.Location = new System.Drawing.Point(19, 149);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(649, 69);
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
            // clDescuento
            // 
            this.clDescuento.HeaderText = "% Descuento";
            this.clDescuento.Name = "clDescuento";
            // 
            // clTotal
            // 
            this.clTotal.HeaderText = "Total";
            this.clTotal.Name = "clTotal";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 119;
            this.label3.Text = "NIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "DIRECCION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 116;
            // 
            // lblPriNomEmp
            // 
            this.lblPriNomEmp.Location = new System.Drawing.Point(5, 68);
            this.lblPriNomEmp.Name = "lblPriNomEmp";
            this.lblPriNomEmp.Size = new System.Drawing.Size(63, 20);
            this.lblPriNomEmp.TabIndex = 115;
            this.lblPriNomEmp.Text = "NOMBRE:";
            this.lblPriNomEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPriNomEmp
            // 
            this.txtPriNomEmp.Location = new System.Drawing.Point(74, 69);
            this.txtPriNomEmp.Name = "txtPriNomEmp";
            this.txtPriNomEmp.Size = new System.Drawing.Size(342, 20);
            this.txtPriNomEmp.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(549, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 113;
            this.label1.Text = "No. 1340";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 112;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(470, 11);
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
            this.ClientSize = new System.Drawing.Size(718, 300);
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
        private System.Windows.Forms.TextBox txtBusquedaNomProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.Button btnBuscarCte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPriNomEmp;
        private System.Windows.Forms.TextBox txtPriNomEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl;

    }
}