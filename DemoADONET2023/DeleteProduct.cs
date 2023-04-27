using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADONET2023
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbCodigo.SelectedItem;
            int idProduct = 0;

            try
            {
                BProduct negocio = new BProduct();
                negocio.Eliminar(new Entidad.Product

                {
                    idProducto = Convert.ToInt32(selectedRow["idProducto"]),
                });
                MessageBox.Show("Eliminación exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }
        }

        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=PCJHON\\SQLEXPRESS; database=crud; Integrated Security = True;");

            SqlDataAdapter da = new SqlDataAdapter("SELECT idProducto FROM producto WHERE estado != 'Eliminado'", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbCodigo.DataSource = dt;
            cbCodigo.DisplayMember = "idProducto";
            cbCodigo.ValueMember = "idProducto";
        }
    }
}
