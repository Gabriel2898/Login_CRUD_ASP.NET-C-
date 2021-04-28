using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Modelo
{
   public class Conexion
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GV5PGTP\SQLEXPRESS;Initial Catalog=CRUDWIN;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
            
                con.Open();
                return con;
            
        }
        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
