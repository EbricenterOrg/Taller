/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 27 Agosto del 2014
 *Comentario:*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace EBRICENTER
{
    public partial class wfReporteCte : Form
    {
        public wfReporteCte()
        {
            InitializeComponent();
            ReporteCliente();
        }

        private void wfReporteCte_Load(object sender, EventArgs e)
        {

        }

       void ReporteCliente() 
        {
            MySqlCommand repcte  = new MySqlCommand(string.Format("select id_cte as 'Codigo', nombre1_cte 'Nombre', apellido1_cte as 'Apellido', tipo_auto as 'Tipo de Vehiculo' , marca_auto as 'Marca', modelo_auto as 'Modelo', matricula_auto as 'Placa' from tab_cliente inner join tab_automovil on idcliente_auto = id_cte"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = repcte;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dtvRepCte.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
