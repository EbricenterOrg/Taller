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
    public partial class wfInvenarioRep : Form
    {
        public wfInvenarioRep()
        {
            InitializeComponent();
            inventario();
        }


        void inventario()
        {
            MySqlCommand cmdRepEmp = new MySqlCommand(string.Format("select r.descripcion_repto as 'Producto', r.marca_repto as 'Marca', r.precio_repto as 'Precio', r.existencia_repto as 'Existencias', p.nombre_prov as 'Proveedor', i.fecha_inventario as 'Fecha Inventario', u.descripcion as 'Ubicacion', b.descripcion as 'Bodega', e.descripcion as 'Estante' from tab_repuesto r inner join tab_proveedor p on r.idproveedor_repto = p.id_prov inner join tab_inventario i on i.id_repto = r.id_repto inner join tab_ubicacion u on i.id_ubicacion = u. id_ubica inner join tab_bodega b on u.id_bodega = b.id_bodega inner join tab_estante e on u.id_estante = e.id_estante; "), csConexion.ObtenerConexion());
            try
            {
                MySqlDataAdapter msd = new MySqlDataAdapter();
                msd.SelectCommand = cmdRepEmp;
                DataTable dbset = new DataTable();
                msd.Fill(dbset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbset;
                dgvInventario.DataSource = bsource;
                msd.Update(dbset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wfInvenarioRep_Load(object sender, EventArgs e)
        {

        }
    }
}
