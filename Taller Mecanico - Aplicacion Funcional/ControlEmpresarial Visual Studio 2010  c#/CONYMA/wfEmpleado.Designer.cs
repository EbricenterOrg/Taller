﻿namespace EBRICENTER
{
    partial class wfEmpleado
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
            this.lblPriNomEmp = new System.Windows.Forms.Label();
            this.txtPriNomEmp = new System.Windows.Forms.TextBox();
            this.lblFecIniEmp = new System.Windows.Forms.Label();
            this.lblTelEmp = new System.Windows.Forms.Label();
            this.lblDomEmp = new System.Windows.Forms.Label();
            this.lblPrimApellEmp = new System.Windows.Forms.Label();
            this.lblSegNomEmp = new System.Windows.Forms.Label();
            this.txtSegNomEmp = new System.Windows.Forms.TextBox();
            this.txtSegApellEmp = new System.Windows.Forms.TextBox();
            this.txtDomEmp = new System.Windows.Forms.TextBox();
            this.cboDepEmp = new System.Windows.Forms.ComboBox();
            this.tabdepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamento = new EBRICENTER.departamento();
            this.tabjornadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdtallerDataSet = new EBRICENTER.bdtallerDataSet();
            this.txtTelEmp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.lblEmailEmp = new System.Windows.Forms.Label();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.lblDepCarEmp = new System.Windows.Forms.Label();
            this.lblSalEmp = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboJornada = new System.Windows.Forms.ComboBox();
            this.txtSalEmp = new System.Windows.Forms.TextBox();
            this.dtpFecIniEmp = new System.Windows.Forms.DateTimePicker();
            this.dtpFecSalEmp = new System.Windows.Forms.DateTimePicker();
            this.lblFecSalEmp = new System.Windows.Forms.Label();
            this.TtEmpleado = new System.Windows.Forms.ToolTip(this.components);
            this.btnActualizaEmp = new System.Windows.Forms.Button();
            this.btnEliminaEmp = new System.Windows.Forms.Button();
            this.btnBuscaEmp = new System.Windows.Forms.Button();
            this.btnModificaEmp = new System.Windows.Forms.Button();
            this.btnCancelaEmp = new System.Windows.Forms.Button();
            this.btnGuardarEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblSegApellEmp = new System.Windows.Forms.Label();
            this.txtPrimApellEmp = new System.Windows.Forms.TextBox();
            this.txtIdJornada = new System.Windows.Forms.TextBox();
            this.tab_jornadaTableAdapter = new EBRICENTER.bdtallerDataSetTableAdapters.tab_jornadaTableAdapter();
            this.txtIddepto = new System.Windows.Forms.TextBox();
            this.bdtallerDataSet1 = new EBRICENTER.bdtallerDataSet1();
            this.bdtallerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdtallerDataSet2 = new EBRICENTER.bdtallerDataSet2();
            this.bdtallerDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_departamentoTableAdapter = new EBRICENTER.departamentoTableAdapters.tab_departamentoTableAdapter();
            this.lblInfoEmp = new System.Windows.Forms.Label();
            this.lblRegEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabdepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabjornadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPriNomEmp
            // 
            this.lblPriNomEmp.AutoSize = true;
            this.lblPriNomEmp.Location = new System.Drawing.Point(41, 107);
            this.lblPriNomEmp.Name = "lblPriNomEmp";
            this.lblPriNomEmp.Size = new System.Drawing.Size(76, 13);
            this.lblPriNomEmp.TabIndex = 66;
            this.lblPriNomEmp.Text = "Primer Nombre";
            this.lblPriNomEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPriNomEmp
            // 
            this.txtPriNomEmp.Location = new System.Drawing.Point(130, 107);
            this.txtPriNomEmp.Name = "txtPriNomEmp";
            this.txtPriNomEmp.Size = new System.Drawing.Size(125, 20);
            this.txtPriNomEmp.TabIndex = 65;
            // 
            // lblFecIniEmp
            // 
            this.lblFecIniEmp.Location = new System.Drawing.Point(48, 319);
            this.lblFecIniEmp.Name = "lblFecIniEmp";
            this.lblFecIniEmp.Size = new System.Drawing.Size(83, 20);
            this.lblFecIniEmp.TabIndex = 67;
            this.lblFecIniEmp.Text = "Fecha de Inicio";
            this.lblFecIniEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelEmp
            // 
            this.lblTelEmp.AutoSize = true;
            this.lblTelEmp.Location = new System.Drawing.Point(41, 220);
            this.lblTelEmp.Name = "lblTelEmp";
            this.lblTelEmp.Size = new System.Drawing.Size(49, 13);
            this.lblTelEmp.TabIndex = 68;
            this.lblTelEmp.Text = "Telefono";
            this.lblTelEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDomEmp
            // 
            this.lblDomEmp.AutoSize = true;
            this.lblDomEmp.Location = new System.Drawing.Point(41, 174);
            this.lblDomEmp.Name = "lblDomEmp";
            this.lblDomEmp.Size = new System.Drawing.Size(49, 13);
            this.lblDomEmp.TabIndex = 70;
            this.lblDomEmp.Text = "Domicilio";
            this.lblDomEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrimApellEmp
            // 
            this.lblPrimApellEmp.AutoSize = true;
            this.lblPrimApellEmp.Location = new System.Drawing.Point(41, 138);
            this.lblPrimApellEmp.Name = "lblPrimApellEmp";
            this.lblPrimApellEmp.Size = new System.Drawing.Size(76, 13);
            this.lblPrimApellEmp.TabIndex = 71;
            this.lblPrimApellEmp.Text = "Primer Apellido";
            this.lblPrimApellEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegNomEmp
            // 
            this.lblSegNomEmp.Location = new System.Drawing.Point(261, 107);
            this.lblSegNomEmp.Name = "lblSegNomEmp";
            this.lblSegNomEmp.Size = new System.Drawing.Size(95, 20);
            this.lblSegNomEmp.TabIndex = 72;
            this.lblSegNomEmp.Text = "Segundo Nombre";
            this.lblSegNomEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSegNomEmp
            // 
            this.txtSegNomEmp.Location = new System.Drawing.Point(355, 106);
            this.txtSegNomEmp.Name = "txtSegNomEmp";
            this.txtSegNomEmp.Size = new System.Drawing.Size(143, 20);
            this.txtSegNomEmp.TabIndex = 73;
            // 
            // txtSegApellEmp
            // 
            this.txtSegApellEmp.Location = new System.Drawing.Point(355, 139);
            this.txtSegApellEmp.Name = "txtSegApellEmp";
            this.txtSegApellEmp.Size = new System.Drawing.Size(143, 20);
            this.txtSegApellEmp.TabIndex = 74;
            this.txtSegApellEmp.TextChanged += new System.EventHandler(this.txtTerNomEmp_TextChanged);
            // 
            // txtDomEmp
            // 
            this.txtDomEmp.Location = new System.Drawing.Point(130, 174);
            this.txtDomEmp.Name = "txtDomEmp";
            this.txtDomEmp.Size = new System.Drawing.Size(368, 20);
            this.txtDomEmp.TabIndex = 75;
            // 
            // cboDepEmp
            // 
            this.cboDepEmp.DataSource = this.tabdepartamentoBindingSource;
            this.cboDepEmp.DisplayMember = "descripcion_depto";
            this.cboDepEmp.FormattingEnabled = true;
            this.cboDepEmp.Location = new System.Drawing.Point(355, 275);
            this.cboDepEmp.Name = "cboDepEmp";
            this.cboDepEmp.Size = new System.Drawing.Size(143, 21);
            this.cboDepEmp.TabIndex = 76;
            this.cboDepEmp.ValueMember = "id_depto";
            this.cboDepEmp.SelectedIndexChanged += new System.EventHandler(this.cboDepEmp_SelectedIndexChanged);
            // 
            // tabdepartamentoBindingSource
            // 
            this.tabdepartamentoBindingSource.DataMember = "tab_departamento";
            this.tabdepartamentoBindingSource.DataSource = this.departamento;
            // 
            // departamento
            // 
            this.departamento.DataSetName = "departamento";
            this.departamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabjornadaBindingSource
            // 
            this.tabjornadaBindingSource.DataMember = "tab_jornada";
            this.tabjornadaBindingSource.DataSource = this.bdtallerDataSet;
            // 
            // bdtallerDataSet
            // 
            this.bdtallerDataSet.DataSetName = "bdtallerDataSet";
            this.bdtallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTelEmp
            // 
            this.txtTelEmp.Location = new System.Drawing.Point(130, 214);
            this.txtTelEmp.Name = "txtTelEmp";
            this.txtTelEmp.Size = new System.Drawing.Size(125, 20);
            this.txtTelEmp.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Movil";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(130, 244);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(125, 20);
            this.txtMovil.TabIndex = 84;
            // 
            // lblEmailEmp
            // 
            this.lblEmailEmp.Location = new System.Drawing.Point(261, 213);
            this.lblEmailEmp.Name = "lblEmailEmp";
            this.lblEmailEmp.Size = new System.Drawing.Size(53, 20);
            this.lblEmailEmp.TabIndex = 85;
            this.lblEmailEmp.Text = "E-mail";
            this.lblEmailEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.Location = new System.Drawing.Point(355, 214);
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(143, 20);
            this.txtEmailEmp.TabIndex = 86;
            // 
            // lblDepCarEmp
            // 
            this.lblDepCarEmp.Location = new System.Drawing.Point(268, 279);
            this.lblDepCarEmp.Name = "lblDepCarEmp";
            this.lblDepCarEmp.Size = new System.Drawing.Size(83, 20);
            this.lblDepCarEmp.TabIndex = 87;
            this.lblDepCarEmp.Text = "Departamento";
            this.lblDepCarEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalEmp
            // 
            this.lblSalEmp.Location = new System.Drawing.Point(249, 244);
            this.lblSalEmp.Name = "lblSalEmp";
            this.lblSalEmp.Size = new System.Drawing.Size(83, 20);
            this.lblSalEmp.TabIndex = 88;
            this.lblSalEmp.Text = "Salario";
            this.lblSalEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 95;
            this.label16.Text = "Jornada";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboJornada
            // 
            this.cboJornada.DataSource = this.tabjornadaBindingSource;
            this.cboJornada.DisplayMember = "descripcion_jornada";
            this.cboJornada.FormattingEnabled = true;
            this.cboJornada.Location = new System.Drawing.Point(130, 278);
            this.cboJornada.Name = "cboJornada";
            this.cboJornada.Size = new System.Drawing.Size(121, 21);
            this.cboJornada.TabIndex = 96;
            this.cboJornada.ValueMember = "id_jornada";
            this.cboJornada.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtSalEmp
            // 
            this.txtSalEmp.Location = new System.Drawing.Point(355, 240);
            this.txtSalEmp.Name = "txtSalEmp";
            this.txtSalEmp.Size = new System.Drawing.Size(143, 20);
            this.txtSalEmp.TabIndex = 97;
            this.txtSalEmp.TextChanged += new System.EventHandler(this.txtSalEmp_TextChanged);
            // 
            // dtpFecIniEmp
            // 
            this.dtpFecIniEmp.Location = new System.Drawing.Point(151, 319);
            this.dtpFecIniEmp.Name = "dtpFecIniEmp";
            this.dtpFecIniEmp.Size = new System.Drawing.Size(200, 20);
            this.dtpFecIniEmp.TabIndex = 98;
            // 
            // dtpFecSalEmp
            // 
            this.dtpFecSalEmp.Location = new System.Drawing.Point(467, 317);
            this.dtpFecSalEmp.Name = "dtpFecSalEmp";
            this.dtpFecSalEmp.Size = new System.Drawing.Size(200, 20);
            this.dtpFecSalEmp.TabIndex = 100;
            // 
            // lblFecSalEmp
            // 
            this.lblFecSalEmp.Location = new System.Drawing.Point(357, 319);
            this.lblFecSalEmp.Name = "lblFecSalEmp";
            this.lblFecSalEmp.Size = new System.Drawing.Size(102, 20);
            this.lblFecSalEmp.TabIndex = 99;
            this.lblFecSalEmp.Text = "Fecha de Salida";
            this.lblFecSalEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizaEmp
            // 
            this.btnActualizaEmp.BackgroundImage = global::EBRICENTER.Properties.Resources.Refrescar;
            this.btnActualizaEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaEmp.Location = new System.Drawing.Point(540, 374);
            this.btnActualizaEmp.Name = "btnActualizaEmp";
            this.btnActualizaEmp.Size = new System.Drawing.Size(44, 36);
            this.btnActualizaEmp.TabIndex = 106;
            this.TtEmpleado.SetToolTip(this.btnActualizaEmp, "Refrescar");
            this.btnActualizaEmp.UseVisualStyleBackColor = true;
            this.btnActualizaEmp.Click += new System.EventHandler(this.btnActualizaEmp_Click);
            // 
            // btnEliminaEmp
            // 
            this.btnEliminaEmp.BackgroundImage = global::EBRICENTER.Properties.Resources.Eliminar;
            this.btnEliminaEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaEmp.Location = new System.Drawing.Point(490, 374);
            this.btnEliminaEmp.Name = "btnEliminaEmp";
            this.btnEliminaEmp.Size = new System.Drawing.Size(44, 36);
            this.btnEliminaEmp.TabIndex = 105;
            this.TtEmpleado.SetToolTip(this.btnEliminaEmp, "Eliminar Empleado");
            this.btnEliminaEmp.UseVisualStyleBackColor = true;
            this.btnEliminaEmp.Click += new System.EventHandler(this.btnEliminaEmp_Click);
            // 
            // btnBuscaEmp
            // 
            this.btnBuscaEmp.BackgroundImage = global::EBRICENTER.Properties.Resources.Buscar;
            this.btnBuscaEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaEmp.Location = new System.Drawing.Point(390, 374);
            this.btnBuscaEmp.Name = "btnBuscaEmp";
            this.btnBuscaEmp.Size = new System.Drawing.Size(44, 36);
            this.btnBuscaEmp.TabIndex = 104;
            this.TtEmpleado.SetToolTip(this.btnBuscaEmp, "Buscar Empleado");
            this.btnBuscaEmp.UseVisualStyleBackColor = true;
            this.btnBuscaEmp.Click += new System.EventHandler(this.btnBuscaEmp_Click);
            // 
            // btnModificaEmp
            // 
            this.btnModificaEmp.BackgroundImage = global::EBRICENTER.Properties.Resources.Modificar;
            this.btnModificaEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaEmp.Location = new System.Drawing.Point(440, 374);
            this.btnModificaEmp.Name = "btnModificaEmp";
            this.btnModificaEmp.Size = new System.Drawing.Size(44, 36);
            this.btnModificaEmp.TabIndex = 103;
            this.TtEmpleado.SetToolTip(this.btnModificaEmp, "Modificar Empleado");
            this.btnModificaEmp.UseVisualStyleBackColor = true;
            // 
            // btnCancelaEmp
            // 
            this.btnCancelaEmp.BackgroundImage = global::EBRICENTER.Properties.Resources.Cancelar;
            this.btnCancelaEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaEmp.Location = new System.Drawing.Point(224, 374);
            this.btnCancelaEmp.Name = "btnCancelaEmp";
            this.btnCancelaEmp.Size = new System.Drawing.Size(44, 36);
            this.btnCancelaEmp.TabIndex = 102;
            this.TtEmpleado.SetToolTip(this.btnCancelaEmp, "Cancelar");
            this.btnCancelaEmp.UseVisualStyleBackColor = true;
            this.btnCancelaEmp.Click += new System.EventHandler(this.btnCancelaEmp_Click);
            // 
            // btnGuardarEmp
            // 
            this.btnGuardarEmp.BackgroundImage = global::EBRICENTER.Properties.Resources.Guardar;
            this.btnGuardarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmp.Location = new System.Drawing.Point(175, 374);
            this.btnGuardarEmp.Name = "btnGuardarEmp";
            this.btnGuardarEmp.Size = new System.Drawing.Size(44, 36);
            this.btnGuardarEmp.TabIndex = 101;
            this.TtEmpleado.SetToolTip(this.btnGuardarEmp, "Guardar");
            this.btnGuardarEmp.UseVisualStyleBackColor = true;
            this.btnGuardarEmp.Click += new System.EventHandler(this.btnGuardarEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Codigo Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(130, 78);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(125, 20);
            this.txtIdEmpleado.TabIndex = 108;
            this.txtIdEmpleado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSegApellEmp
            // 
            this.lblSegApellEmp.AutoSize = true;
            this.lblSegApellEmp.Location = new System.Drawing.Point(261, 145);
            this.lblSegApellEmp.Name = "lblSegApellEmp";
            this.lblSegApellEmp.Size = new System.Drawing.Size(90, 13);
            this.lblSegApellEmp.TabIndex = 109;
            this.lblSegApellEmp.Text = "Segundo Apellido";
            // 
            // txtPrimApellEmp
            // 
            this.txtPrimApellEmp.Location = new System.Drawing.Point(130, 138);
            this.txtPrimApellEmp.Name = "txtPrimApellEmp";
            this.txtPrimApellEmp.Size = new System.Drawing.Size(121, 20);
            this.txtPrimApellEmp.TabIndex = 112;
            this.txtPrimApellEmp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIdJornada
            // 
            this.txtIdJornada.Enabled = false;
            this.txtIdJornada.Location = new System.Drawing.Point(567, 249);
            this.txtIdJornada.Name = "txtIdJornada";
            this.txtIdJornada.Size = new System.Drawing.Size(100, 20);
            this.txtIdJornada.TabIndex = 113;
            this.txtIdJornada.Visible = false;
            this.txtIdJornada.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tab_jornadaTableAdapter
            // 
            this.tab_jornadaTableAdapter.ClearBeforeFill = true;
            // 
            // txtIddepto
            // 
            this.txtIddepto.Enabled = false;
            this.txtIddepto.Location = new System.Drawing.Point(567, 275);
            this.txtIddepto.Name = "txtIddepto";
            this.txtIddepto.Size = new System.Drawing.Size(100, 20);
            this.txtIddepto.TabIndex = 114;
            this.txtIddepto.Visible = false;
            this.txtIddepto.TextChanged += new System.EventHandler(this.txtIddepto_TextChanged);
            // 
            // bdtallerDataSet1
            // 
            this.bdtallerDataSet1.DataSetName = "bdtallerDataSet1";
            this.bdtallerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdtallerDataSet1BindingSource
            // 
            this.bdtallerDataSet1BindingSource.DataSource = this.bdtallerDataSet1;
            this.bdtallerDataSet1BindingSource.Position = 0;
            // 
            // bdtallerDataSet2
            // 
            this.bdtallerDataSet2.DataSetName = "bdtallerDataSet2";
            this.bdtallerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdtallerDataSet2BindingSource
            // 
            this.bdtallerDataSet2BindingSource.DataSource = this.bdtallerDataSet2;
            this.bdtallerDataSet2BindingSource.Position = 0;
            // 
            // tab_departamentoTableAdapter
            // 
            this.tab_departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // lblInfoEmp
            // 
            this.lblInfoEmp.AutoEllipsis = true;
            this.lblInfoEmp.AutoSize = true;
            this.lblInfoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmp.Location = new System.Drawing.Point(248, 33);
            this.lblInfoEmp.Name = "lblInfoEmp";
            this.lblInfoEmp.Size = new System.Drawing.Size(250, 24);
            this.lblInfoEmp.TabIndex = 115;
            this.lblInfoEmp.Text = "Informacion de Empleado";
            this.lblInfoEmp.Visible = false;
            // 
            // lblRegEmp
            // 
            this.lblRegEmp.AutoSize = true;
            this.lblRegEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegEmp.Location = new System.Drawing.Point(267, 33);
            this.lblRegEmp.Name = "lblRegEmp";
            this.lblRegEmp.Size = new System.Drawing.Size(218, 24);
            this.lblRegEmp.TabIndex = 116;
            this.lblRegEmp.Text = "Registro de Empleado";
            // 
            // wfEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.lblRegEmp);
            this.Controls.Add(this.lblInfoEmp);
            this.Controls.Add(this.txtIddepto);
            this.Controls.Add(this.txtIdJornada);
            this.Controls.Add(this.txtPrimApellEmp);
            this.Controls.Add(this.lblSegApellEmp);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizaEmp);
            this.Controls.Add(this.btnEliminaEmp);
            this.Controls.Add(this.btnBuscaEmp);
            this.Controls.Add(this.btnModificaEmp);
            this.Controls.Add(this.btnCancelaEmp);
            this.Controls.Add(this.btnGuardarEmp);
            this.Controls.Add(this.dtpFecSalEmp);
            this.Controls.Add(this.lblFecSalEmp);
            this.Controls.Add(this.dtpFecIniEmp);
            this.Controls.Add(this.txtSalEmp);
            this.Controls.Add(this.cboJornada);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblSalEmp);
            this.Controls.Add(this.lblDepCarEmp);
            this.Controls.Add(this.txtEmailEmp);
            this.Controls.Add(this.lblEmailEmp);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelEmp);
            this.Controls.Add(this.cboDepEmp);
            this.Controls.Add(this.txtDomEmp);
            this.Controls.Add(this.txtSegApellEmp);
            this.Controls.Add(this.txtSegNomEmp);
            this.Controls.Add(this.lblSegNomEmp);
            this.Controls.Add(this.lblPrimApellEmp);
            this.Controls.Add(this.lblDomEmp);
            this.Controls.Add(this.lblTelEmp);
            this.Controls.Add(this.lblFecIniEmp);
            this.Controls.Add(this.lblPriNomEmp);
            this.Controls.Add(this.txtPriNomEmp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabdepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabjornadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtallerDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriNomEmp;
        private System.Windows.Forms.TextBox txtPriNomEmp;
        private System.Windows.Forms.Label lblFecIniEmp;
        private System.Windows.Forms.Label lblTelEmp;
        private System.Windows.Forms.Label lblDomEmp;
        private System.Windows.Forms.Label lblPrimApellEmp;
        private System.Windows.Forms.Label lblSegNomEmp;
        private System.Windows.Forms.TextBox txtSegNomEmp;
        private System.Windows.Forms.TextBox txtSegApellEmp;
        private System.Windows.Forms.TextBox txtDomEmp;
        private System.Windows.Forms.ComboBox cboDepEmp;
        private System.Windows.Forms.TextBox txtTelEmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label lblEmailEmp;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label lblDepCarEmp;
        private System.Windows.Forms.Label lblSalEmp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboJornada;
        private System.Windows.Forms.TextBox txtSalEmp;
        private System.Windows.Forms.DateTimePicker dtpFecIniEmp;
        private System.Windows.Forms.DateTimePicker dtpFecSalEmp;
        private System.Windows.Forms.Label lblFecSalEmp;
        private System.Windows.Forms.Button btnActualizaEmp;
        private System.Windows.Forms.Button btnEliminaEmp;
        private System.Windows.Forms.Button btnBuscaEmp;
        private System.Windows.Forms.Button btnModificaEmp;
        private System.Windows.Forms.Button btnCancelaEmp;
        private System.Windows.Forms.Button btnGuardarEmp;
        private System.Windows.Forms.ToolTip TtEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblSegApellEmp;
        private System.Windows.Forms.TextBox txtPrimApellEmp;
        private System.Windows.Forms.TextBox txtIdJornada;
        private bdtallerDataSet bdtallerDataSet;
        private System.Windows.Forms.BindingSource tabjornadaBindingSource;
        private bdtallerDataSetTableAdapters.tab_jornadaTableAdapter tab_jornadaTableAdapter;
        private System.Windows.Forms.TextBox txtIddepto;
        private System.Windows.Forms.BindingSource bdtallerDataSet2BindingSource;
        private bdtallerDataSet2 bdtallerDataSet2;
        private bdtallerDataSet1 bdtallerDataSet1;
        private System.Windows.Forms.BindingSource bdtallerDataSet1BindingSource;
        private departamento departamento;
        private System.Windows.Forms.BindingSource tabdepartamentoBindingSource;
        private departamentoTableAdapters.tab_departamentoTableAdapter tab_departamentoTableAdapter;
        private System.Windows.Forms.Label lblInfoEmp;
        private System.Windows.Forms.Label lblRegEmp;
    }
}