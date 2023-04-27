using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DemoADONET2023
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BProduct negocio = new BProduct();
                negocio.Insertar(new Entidad.Product
                {
                    nombre = txtNombre.Text,
                    precio = Convert.ToDecimal(txtPrecio.Text),
                    estado = cbEstado.Text
                });
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
