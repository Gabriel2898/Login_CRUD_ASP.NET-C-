using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class C_Login
    {

        M_Login logn = new M_Login();

        public C_Login()
        {

        }
        private int id;
        private string usuario;
        private string pass;

    
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Password
        {
            get { return pass; }
            set { pass = value; }
        }
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader leer;
            leer = logn.Auntenticar(usuario,pass);
            return leer;
        }
    }
}
