/*Autor: Cesar Estuardo Flore Escobar
 *Fecha: 28 Agosto del 2014
 *Comentario:*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace EBRICENTER
{
    public partial class wfServicio : Form
    {
        public wfServicio()
        {
            InitializeComponent();
        }

        private void wfServicio_Load(object sender, EventArgs e)
        {
            MySqlCommand tipserv = new MySqlCommand(string.Format("select id_tserv as 'codigo', descripcion_tserv as 'Tipo Servicio', precio_tserv as 'Precio' from tab_tiposervicio"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = tipserv;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dgvTipoServicio.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //MUESTRA CLIENTE Y VEHICULO
            MySqlCommand muestrarep = new MySqlCommand(string.Format("select id_cte as 'Codigo', nombre1_cte 'Nombre', apellido1_cte as 'Apellido', tipo_auto as 'Tipo de Vehiculo' , marca_auto as 'Marca', matricula_auto as 'Placa' from tab_cliente inner join tab_automovil on idcliente_auto = id_cte"), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = muestrarep;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dgvClienteVehiculo.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
