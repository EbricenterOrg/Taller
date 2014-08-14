namespace EBRICENTER
{
    partial class wfUsuario
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
            this.lblCodUser = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPassUsuario = new System.Windows.Forms.Label();
            this.lblCodEmp = new System.Windows.Forms.Label();
            this.lblCodTipoUsuario = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPassUsuario = new System.Windows.Forms.TextBox();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.txtCodTipoUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tabtipusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoUsuario = new EBRICENTER.TipoUsuario();
            this.tab_tipusuarioTableAdapter = new EBRICENTER.TipoUsuarioTableAdapters.tab_tipusuarioTableAdapter();
            this.lblRegNewUser = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabtipusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodUser
            // 
            this.lblCodUser.AutoSize = true;
            this.lblCodUser.Location = new System.Drawing.Point(23, 70);
            this.lblCodUser.Name = "lblCodUser";
            this.lblCodUser.Size = new System.Drawing.Size(79, 13);
            this.lblCodUser.TabIndex = 0;
            this.lblCodUser.Text = "Codigo Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(23, 110);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblPassUsuario
            // 
            this.lblPassUsuario.AutoSize = true;
            this.lblPassUsuario.Location = new System.Drawing.Point(247, 109);
            this.lblPassUsuario.Name = "lblPassUsuario";
            this.lblPassUsuario.Size = new System.Drawing.Size(61, 13);
            this.lblPassUsuario.TabIndex = 2;
            this.lblPassUsuario.Text = "Contraseña";
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Location = new System.Drawing.Point(23, 151);
            this.lblCodEmp.Name = "lblCodEmp";
            this.lblCodEmp.Size = new System.Drawing.Size(90, 13);
            this.lblCodEmp.TabIndex = 3;
            this.lblCodEmp.Text = "Codigo Empleado";
            this.lblCodEmp.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCodTipoUsuario
            // 
            this.lblCodTipoUsuario.AutoSize = true;
            this.lblCodTipoUsuario.Location = new System.Drawing.Point(247, 151);
            this.lblCodTipoUsuario.Name = "lblCodTipoUsuario";
            this.lblCodTipoUsuario.Size = new System.Drawing.Size(103, 13);
            this.lblCodTipoUsuario.TabIndex = 4;
            this.lblCodTipoUsuario.Text = "Codigo Tipo Usuario";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Location = new System.Drawing.Point(127, 70);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodUsuario.TabIndex = 5;
            this.txtCodUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(127, 103);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // txtPassUsuario
            // 
            this.txtPassUsuario.Location = new System.Drawing.Point(356, 106);
            this.txtPassUsuario.Name = "txtPassUsuario";
            this.txtPassUsuario.PasswordChar = '*';
            this.txtPassUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtPassUsuario.TabIndex = 7;
            this.txtPassUsuario.TextChanged += new System.EventHandler(this.txtPassUsuario_TextChanged);
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(127, 144);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(100, 20);
            this.txtCodEmp.TabIndex = 8;
            // 
            // txtCodTipoUsuario
            // 
            this.txtCodTipoUsuario.Location = new System.Drawing.Point(356, 170);
            this.txtCodTipoUsuario.Name = "txtCodTipoUsuario";
            this.txtCodTipoUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtCodTipoUsuario.TabIndex = 9;
            this.txtCodTipoUsuario.Visible = false;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Image = global::EBRICENTER.Properties.Resources.Guardar;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(183, 210);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(44, 36);
            this.btnGuardarUsuario.TabIndex = 10;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.DataSource = this.tabtipusuarioBindingSource;
            this.cboTipoUsuario.DisplayMember = "descripcion_tipuser";
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(356, 143);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboTipoUsuario.TabIndex = 11;
            this.cboTipoUsuario.ValueMember = "id_tipuser";
            this.cboTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cboTipoUsuario_SelectedIndexChanged);
            // 
            // tabtipusuarioBindingSource
            // 
            this.tabtipusuarioBindingSource.DataMember = "tab_tipusuario";
            this.tabtipusuarioBindingSource.DataSource = this.tipoUsuario;
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.DataSetName = "TipoUsuario";
            this.tipoUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_tipusuarioTableAdapter
            // 
            this.tab_tipusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // lblRegNewUser
            // 
            this.lblRegNewUser.AutoSize = true;
            this.lblRegNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNewUser.Location = new System.Drawing.Point(126, 31);
            this.lblRegNewUser.Name = "lblRegNewUser";
            this.lblRegNewUser.Size = new System.Drawing.Size(224, 20);
            this.lblRegNewUser.TabIndex = 12;
            this.lblRegNewUser.Text = "Registro de Nuevo Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::EBRICENTER.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(269, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // wfUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 273);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegNewUser);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.txtCodTipoUsuario);
            this.Controls.Add(this.txtCodEmp);
            this.Controls.Add(this.txtPassUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.lblCodTipoUsuario);
            this.Controls.Add(this.lblCodEmp);
            this.Controls.Add(this.lblPassUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblCodUser);
            this.Name = "wfUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfUsuario";
            this.Load += new System.EventHandler(this.wfUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabtipusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodUser;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPassUsuario;
        private System.Windows.Forms.Label lblCodEmp;
        private System.Windows.Forms.Label lblCodTipoUsuario;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPassUsuario;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.TextBox txtCodTipoUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private TipoUsuario tipoUsuario;
        private System.Windows.Forms.BindingSource tabtipusuarioBindingSource;
        private TipoUsuarioTableAdapters.tab_tipusuarioTableAdapter tab_tipusuarioTableAdapter;
        private System.Windows.Forms.Label lblRegNewUser;
        private System.Windows.Forms.Button btnSalir;
    }
}