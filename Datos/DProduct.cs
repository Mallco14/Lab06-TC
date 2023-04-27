using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.CodeDom.Compiler;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Datos
{
    public class DProduct
    {

        private string connectionString = "server=PCJHON\\SQLEXPRESS; database=crud; Integrated Security = True;";

        public List<Product> Listar(string name)
        {

            //Obtengo la conexión
            SqlConnection connection = null;
            SqlParameter param = null;
            SqlCommand command = null;
            List<Product> products = null;
            try
            {
                connection = new SqlConnection(connectionString);

                connection.Open();

                //Hago mi consulta
                command = new SqlCommand("AllProducts", connection);
                command.CommandType = CommandType.StoredProcedure;

                //param = new SqlParameter();
                //param.ParameterName = "@nombre";
                //param.SqlDbType = SqlDbType.VarChar;
                //param.Value = name;

                //command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                products = new List<Product>();


                while (reader.Read())
                {

                    Product Product = new Product();
                    Product.idProducto = (int)reader["idProducto"];
                    Product.nombre = reader["nombre"].ToString();
                    Product.precio = (decimal)reader["precio"];
                    Product.fecha_creacion = (DateTime)reader["fecha_creacion"];
                    Product.estado = reader["estado"].ToString();


                    products.Add(Product);

                }

                connection.Close();

                //Muestro la información
                return products;


            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }
            finally
            {
                connection = null;
                command = null;
                param = null;
                products = null;

            }


        }

        public void Insertar(Product Product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertProducto", connection); // Nombre del procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado                
                    command.Parameters.AddWithValue("@nombre", Product.nombre);
                    command.Parameters.AddWithValue("@precio", Product.precio);
                    command.Parameters.AddWithValue("@estado", Product.estado);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Actualizar(Product producto)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                SqlParameter param1;
                SqlParameter param2;
                SqlParameter param3;
                SqlParameter param4;

                param1 = new SqlParameter();
                param1.ParameterName = "@idProducto";
                param1.SqlDbType = SqlDbType.Int;
                param1.Value = producto.idProducto;

                param2 = new SqlParameter();
                param2.ParameterName = "@nombre";
                param2.SqlDbType = SqlDbType.VarChar;
                param2.Value = producto.nombre;

                param3 = new SqlParameter();
                param3.ParameterName = "@precio";
                param3.SqlDbType = SqlDbType.Decimal;
                param3.Value = producto.precio;


                param4 = new SqlParameter();
                param4.ParameterName = "@estado";
                param4.SqlDbType = SqlDbType.VarChar;
                param4.Value = producto.estado;

                parameters.Add(param1);
                parameters.Add(param2);
                parameters.Add(param3);
                parameters.Add(param4);

                SqlHelper.ExecuteNonQuery(connectionString, "UpdateProducto", CommandType.StoredProcedure, parameters.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Eliminar(Product producto)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                SqlParameter param1;

                param1 = new SqlParameter();
                param1.ParameterName = "@idProducto";
                param1.SqlDbType = SqlDbType.Int;
                param1.Value = producto.idProducto;

                parameters.Add(param1);

                SqlHelper.ExecuteNonQuery(connectionString, "DeleteProducto", CommandType.StoredProcedure, parameters.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }

}
