using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Productos
    {
        private Modelo.Conexion conexion = new Modelo.Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {


            SqlDataAdapter sqlDa = new SqlDataAdapter("MostrarProductos", conexion.AbrirConexion());
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            conexion.CerrarConexion();
            return dtbl;
        }
        
        public DataTable MostrarxNombre(string nombre)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("BuscarId", conexion.AbrirConexion());
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            return dtbl;
        }
        
        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.Parameters.AddWithValue("@id", id);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
