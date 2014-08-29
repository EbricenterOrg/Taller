/*Autor: Cesar Estuardo Flores Escobar
 *Fecha: 27/08/2014
 *Comentario: Formulario Automovil.
 */
namespace EBRICENTER
{
    partial class wfAutomovil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAutomovil));
            this.lblCodCte = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lbltipoVehi = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblNumPoliza = new System.Windows.Forms.Label();
            this.lblRegistraVehiculo = new System.Windows.Forms.Label();
            this.txtCodCte = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtNumPoliza = new System.Windows.Forms.TextBox();
            this.cdbMoodelo = new System.Windows.Forms.ComboBox();
            this.btnGuardaRegVehiculo = new System.Windows.Forms.Button();
            this.btnCancelaRegVehiculo = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.ttRegistraVehiculo = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificarReg = new System.Windows.Forms.Button();
            this.cdbTipoAuto = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cdbMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCodCte
            // 
            this.lblCodCte.AutoSize = true;
            this.lblCodCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCte.Location = new System.Drawing.Point(93, 165);
            this.lblCodCte.Name = "lblCodCte";
            this.lblCodCte.Size = new System.Drawing.Size(119, 18);
            this.lblCodCte.TabIndex = 0;
            this.lblCodCte.Text = "Codigo Cliente";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(531, 170);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(77, 18);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(98, 284);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 18);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // lbltipoVehi
            // 
            this.lbltipoVehi.AutoSize = true;
            this.lbltipoVehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoVehi.Location = new System.Drawing.Point(93, 246);
            this.lbltipoVehi.Name = "lbltipoVehi";
            this.lbltipoVehi.Size = new System.Drawing.Size(110, 18);
            this.lbltipoVehi.TabIndex = 3;
            this.lbltipoVehi.Text = "Tipo Vehiculo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(531, 204);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(64, 18);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(531, 242);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(149, 18);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Kilometros / Millas";
            // 
            // lblNumPoliza
            // 
            this.lblNumPoliza.AutoSize = true;
            this.lblNumPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPoliza.Location = new System.Drawing.Point(531, 284);
            this.lblNumPoliza.Name = "lblNumPoliza";
            this.lblNumPoliza.Size = new System.Drawing.Size(143, 18);
            this.lblNumPoliza.TabIndex = 7;
            this.lblNumPoliza.Text = "Numero de Poliza";
            // 
            // lblRegistraVehiculo
            // 
            this.lblRegistraVehiculo.AutoSize = true;
            this.lblRegistraVehiculo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistraVehiculo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRegistraVehiculo.Location = new System.Drawing.Point(283, 63);
            this.lblRegistraVehiculo.Name = "lblRegistraVehiculo";
            this.lblRegistraVehiculo.Size = new System.Drawing.Size(440, 47);
            this.lblRegistraVehiculo.TabIndex = 8;
            this.lblRegistraVehiculo.Text = "Registro de Vehiculos";
            // 
            // txtCodCte
            // 
            this.txtCodCte.Location = new System.Drawing.Point(236, 169);
            this.txtCodCte.Name = "txtCodCte";
            this.txtCodCte.Size = new System.Drawing.Size(167, 22);
            this.txtCodCte.TabIndex = 9;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(717, 164);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(159, 22);
            this.txtMatricula.TabIndex = 11;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(236, 281);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(167, 22);
            this.txtColor.TabIndex = 13;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(717, 242);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(159, 22);
            this.txtKm.TabIndex = 14;
            // 
            // txtNumPoliza
            // 
            this.txtNumPoliza.Location = new System.Drawing.Point(717, 280);
            this.txtNumPoliza.Name = "txtNumPoliza";
            this.txtNumPoliza.Size = new System.Drawing.Size(159, 22);
            this.txtNumPoliza.TabIndex = 16;
            // 
            // cdbMoodelo
            // 
            this.cdbMoodelo.FormattingEnabled = true;
            this.cdbMoodelo.Items.AddRange(new object[] {
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.cdbMoodelo.Location = new System.Drawing.Point(717, 198);
            this.cdbMoodelo.Name = "cdbMoodelo";
            this.cdbMoodelo.Size = new System.Drawing.Size(159, 24);
            this.cdbMoodelo.TabIndex = 17;
            this.ttRegistraVehiculo.SetToolTip(this.cdbMoodelo, "Año vehiculo");
            this.cdbMoodelo.SelectedIndexChanged += new System.EventHandler(this.cdbMoodelo_SelectedIndexChanged);
            // 
            // btnGuardaRegVehiculo
            // 
            this.btnGuardaRegVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardaRegVehiculo.BackgroundImage")));
            this.btnGuardaRegVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaRegVehiculo.Location = new System.Drawing.Point(352, 372);
            this.btnGuardaRegVehiculo.Name = "btnGuardaRegVehiculo";
            this.btnGuardaRegVehiculo.Size = new System.Drawing.Size(64, 44);
            this.btnGuardaRegVehiculo.TabIndex = 18;
            this.ttRegistraVehiculo.SetToolTip(this.btnGuardaRegVehiculo, "Guardar");
            this.btnGuardaRegVehiculo.UseVisualStyleBackColor = true;
            this.btnGuardaRegVehiculo.Click += new System.EventHandler(this.btnGuardaRegVehiculo_Click);
            // 
            // btnCancelaRegVehiculo
            // 
            this.btnCancelaRegVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelaRegVehiculo.BackgroundImage")));
            this.btnCancelaRegVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelaRegVehiculo.Location = new System.Drawing.Point(434, 372);
            this.btnCancelaRegVehiculo.Name = "btnCancelaRegVehiculo";
            this.btnCancelaRegVehiculo.Size = new System.Drawing.Size(64, 44);
            this.btnCancelaRegVehiculo.TabIndex = 19;
            this.ttRegistraVehiculo.SetToolTip(this.btnCancelaRegVehiculo, "Cancelar");
            this.btnCancelaRegVehiculo.UseVisualStyleBackColor = true;
            this.btnCancelaRegVehiculo.Click += new System.EventHandler(this.btnCancelaRegVehiculo_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalida.BackgroundImage")));
            this.btnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalida.Location = new System.Drawing.Point(576, 372);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(64, 44);
            this.btnSalida.TabIndex = 20;
            this.ttRegistraVehiculo.SetToolTip(this.btnSalida, "Salir");
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(268, 372);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 44);
            this.btnNuevo.TabIndex = 24;
            this.ttRegistraVehiculo.SetToolTip(this.btnNuevo, "Nuevo Vehiculo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificarReg
            // 
            this.btnModificarReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarReg.BackgroundImage")));
            this.btnModificarReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarReg.Location = new System.Drawing.Point(506, 372);
            this.btnModificarReg.Name = "btnModificarReg";
            this.btnModificarReg.Size = new System.Drawing.Size(64, 44);
            this.btnModificarReg.TabIndex = 25;
            this.ttRegistraVehiculo.SetToolTip(this.btnModificarReg, "Modificar");
            this.btnModificarReg.UseVisualStyleBackColor = true;
            // 
            // cdbTipoAuto
            // 
            this.cdbTipoAuto.FormattingEnabled = true;
            this.cdbTipoAuto.Items.AddRange(new object[] {
            "Cupé",
            "Camioneta",
            "Deportivo",
            "Furgoneta",
            "Limosina",
            "Pickup 4 x 2",
            "Pickup 4 x 4",
            "Roadster",
            "Sedan",
            "Suv",
            "Suv 4 x4",
            "Todo Terreno"});
            this.cdbTipoAuto.Location = new System.Drawing.Point(236, 242);
            this.cdbTipoAuto.Name = "cdbTipoAuto";
            this.cdbTipoAuto.Size = new System.Drawing.Size(167, 24);
            this.cdbTipoAuto.TabIndex = 21;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(93, 204);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 18);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // cdbMarca
            // 
            this.cdbMarca.FormattingEnabled = true;
            this.cdbMarca.Items.AddRange(new object[] {
            "Abarth",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Cadillac",
            "Chevrolet",
            "Citroen",
            "Corvette",
            "Daewoo",
            "Dodge",
            "Ferrari ",
            "Fiat",
            "Ford\t",
            "Honda",
            "Hummer",
            "Hyundai",
            "Isuzu",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Land Rover",
            "Lincoln",
            "Lifan",
            "Mahindra",
            "Maserati",
            "Mazda",
            "Mercedes",
            "Mini ",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Renault",
            "Rolls Royce",
            "Seat",
            "Skoda",
            "Smart",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cdbMarca.Location = new System.Drawing.Point(236, 204);
            this.cdbMarca.Name = "cdbMarca";
            this.cdbMarca.Size = new System.Drawing.Size(167, 24);
            this.cdbMarca.TabIndex = 22;
            // 
            // wfAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(910, 428);
            this.Controls.Add(this.btnModificarReg);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cdbMarca);
            this.Controls.Add(this.cdbTipoAuto);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnCancelaRegVehiculo);
            this.Controls.Add(this.btnGuardaRegVehiculo);
            this.Controls.Add(this.cdbMoodelo);
            this.Controls.Add(this.txtNumPoliza);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtCodCte);
            this.Controls.Add(this.lblRegistraVehiculo);
            this.Controls.Add(this.lblNumPoliza);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lbltipoVehi);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCodCte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automovil";
      //      this.Load += new System.EventHandler(this.wfAutomovil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCte;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lbltipoVehi;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblNumPoliza;
        private System.Windows.Forms.Label lblRegistraVehiculo;
        private System.Windows.Forms.TextBox txtCodCte;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtNumPoliza;
        private System.Windows.Forms.ComboBox cdbMoodelo;
        private System.Windows.Forms.Button btnGuardaRegVehiculo;
        private System.Windows.Forms.Button btnCancelaRegVehiculo;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.ToolTip ttRegistraVehiculo;
        private System.Windows.Forms.ComboBox cdbTipoAuto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cdbMarca;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificarReg;
    }
}