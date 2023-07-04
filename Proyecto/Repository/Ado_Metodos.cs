using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace Proyecto.Repository
{
    internal class Ado_Metodos
    {
        string connectionString = "Server=localhost;Database=ManipulaciondeDatos;Trusted_Connection=True;"; 
        
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, descripciones, costo, precioVenta, stock, idUsuario FROM Producto";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.id = Convert.ToInt32(reader["id"]);

                    producto.descripciones = (string)reader["descripciones"];

                    producto.costo = Convert.ToInt32(reader["costo"]);
                    producto.precioVenta = Convert.ToInt32(reader["precioVenta"]);
                    producto.stock = Convert.ToInt32(reader["stock"]);
                    producto.idusuario = Convert.ToInt32(reader["idusuario"]);

                    productos.Add(producto);
                }
                reader.Close();
            }
        }

    }
}