using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public partial class wfFactura : Form
    {
        public wfFactura()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlDataReader lectura;

            string query = "select * from tab_cliente where nit_cte = '" + txtNitCte.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
               
                txtNonCteComp.Text = lectura.GetString("nombre1_cte") + " " + lectura.GetString("nombre2_cte") + " " + lectura.GetString("apellido1_cte") + " " + lectura.GetString("apellido2_cte");
                txtDirCte.Text = lectura.GetString("domicilio_cte");
                string sIdCte = lectura.GetInt32("id_cte").ToString();
                txtCodCte.Text = sIdCte;


            }


            

        }

        private void btnBuscarCte_Click(object sender, EventArgs e)
        {

            string _query = "insert into tab_factura (fecha_fact, idcliente_fact) values ('" + this.dtpFechFact.Text + "','" + this.txtCodCte.Text + "')";
            MySqlCommand cmdInsFact = new MySqlCommand(_query, csconectar.conectarse());
            
            MySqlDataReader leer;
            try
            {
                leer = cmdInsFact.ExecuteReader();
               // MessageBox.Show("Factura Guardada");
                while (leer.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MySqlDataReader lectura;

            string query = "select * from tab_factura;";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                string sCodfact = lectura.GetInt32("id_fact").ToString();
                lblCodFact.Text = sCodfact;
               


            }
        }

        private void txtBusquedaNomProd_TextChanged(object sender, EventArgs e)
        {

            MySqlDataReader lectura;

            string query = "select * from tab_repuesto where id_repto = '" +txtCodRep.Text+ "'";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                dgvFactura.Rows.Add(lectura.GetString("id_repto"), lectura.GetString("descripcion_repto"), lectura.GetString("precio_repto") );
                string idRep = lectura.GetInt32("id_repto").ToString();
                txtIdRep.Text = idRep;
                string valRep = lectura.GetInt32("precio_repto").ToString();
                txtValor.Text = valRep;

                /*int iValor = Convert.ToInt32(txtCant.Text);
                int icanti = Convert.ToInt32(txtValor.Text);
                int iTotal = iValor * icanti;
                string sTotal = Convert.ToInt32(iTotal).ToString();
                txtTotalPagar.Text = sTotal;*/

            }

        }

        private void btnAcepFac_Click(object sender, EventArgs e)
        {

           /* string _query = "insert into tab_factura (fecha_fact, idcliente_fact) values (?idFact, ?idserv, ?idrep, ?valor)";
            MySqlCommand cmdInsFact = new MySqlCommand(_query, csconectar.conectarse());*/

           /* foreach (DataGridViewRow renglon in dgvFactura.Rows)
            {
                try
                {
                    string _query = "insert into tabt_detfact (idfactura_detfact, idservicio_detfact, idrepuesto_detfact, valor_detfact) values ('" + this.lblCodFact.Text + "', '" + renglon.Cells[0].Value.ToString() + "', '" + renglon.Cells[1].Value.ToString() + "', '" + renglon.Cells[2].Value.ToString() + "')";
                    MySqlCommand cmdInsFact = new MySqlCommand(_query, csconectar.conectarse());
                    cmdInsFact.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Se ha Producido un Error." + ex.Message);
                }
            }*/

            try
            {
                string _query = "insert into tabt_detfact (idfactura_detfact, idservicio_detfact, idrepuesto_detfact, valor_detfact) values ('" + this.lblCodFact.Text + "', '" + this.txtIdServ.Text+ "', '" +this.txtIdRep.Text+ "', '" + this.txtValor.Text+ "')";
                MySqlCommand cmdInsFact = new MySqlCommand(_query, csconectar.conectarse());
                cmdInsFact.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha Producido un Error." + ex.Message);
            }
            /*int iValor = Convert.ToInt32(txtCant.Text);
            int icanti = Convert.ToInt32(txtValor.Text);
            int iTotal = iValor * icanti;
            string sTotal = Convert.ToInt32(iTotal).ToString();
            txtTotalPagar.Text = sTotal;*/

        }

        private void txtidSer_TextChanged(object sender, EventArgs e)
        {
            MySqlDataReader lectura;

            string query = "select id_servicio, descripcion_tserv from tabt_servicio inner join tab_tiposervicio action on idtiposervicio_servicio = id_tserv where id_servicio = 1; = '" + txtIdServ.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, csconectar.conectarse());
            lectura = cmd.ExecuteReader();
            while (lectura.Read())
            {
                dgvFactura.Rows.Add(lectura.GetString("id_servicio"), lectura.GetString("descripcion_tserv"));
                string IdServ = lectura.GetInt32("id_servicio").ToString();
                txtIdServ.Text = IdServ;
                MessageBox.Show("Factura Generada");
              
            }
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {

        }


      
      

       
    }
}
