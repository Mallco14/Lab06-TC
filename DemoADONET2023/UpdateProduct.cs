using Entidad;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoADONET2023
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el objeto DataRowView seleccionado en el combobox
            DataRowView selectedRow = (DataRowView)cbCodigo.SelectedItem;

            // Obtener el ID seleccionado en el combobox
            int selectedId = Convert.ToInt32(selectedRow["idProducto"]);

            // Conexión a la base de datos
            SqlConnection conn = new SqlConnection("Data Source=PCJHON\\SQLEXPRESS; Initial Catalog=crud;User ID=PCJHON ;;Password=");

            try
            {
                // Abrir la conexión a la base de datos
                conn.Open();

                // Consulta para obtener los datos del producto seleccionado
                string query = "SELECT nombre, precio FROM producto WHERE idProducto = @idProducto";

                // Crear un comando para ejecutar la consulta
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idProducto", selectedId);

                // Ejecutar la consulta y obtener los datos del producto
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Asignar los valores obtenidos a los campos correspondientes del formulario
                    txtNombre.Text = reader["nombre"].ToString();
                    txtPrecio.Text = reader["precio"].ToString();
                    //cbCodigo.SelectedItem = reader["estado"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conn.Close();
            }


        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=PCJHON\\SQLEXPRESS; database=crud; Integrated Security = True;");

            SqlDataAdapter da = new SqlDataAdapter("SELECT idProducto FROM producto WHERE estado != 'Eliminado'", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbCodigo.DataSource = dt;
            cbCodigo.DisplayMember = "idProducto";
            cbCodigo.ValueMember = "idProducto";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbCodigo.SelectedItem;
            int idProduct = 0;

            try
            {
                BProduct negocio = new BProduct();
                negocio.Actualizar(new Entidad.Product
                {
                    idProducto = Convert.ToInt32(selectedRow["idProducto"]),
                    nombre = Convert.ToString(txtNombre.Text),    
                    precio = Convert.ToDecimal(txtPrecio.Text),
                    estado = Convert.ToString(cbEstado.Text)
                });
                MessageBox.Show("Actualizacion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }



    }
    
}
