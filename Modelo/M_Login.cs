using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Login
    {
        private Conexion con = new Conexion();
        public SqlDataReader leer;
        public SqlDataReader Auntenticar(string usuario, string contraseña)
        {
            SqlCommand cmd = new SqlCommand("IniciarSesion", con.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", usuario);
            cmd.Parameters.AddWithValue("@pass", contraseña);
            leer = cmd.ExecuteReader();
            return leer;

        }
    }
}
