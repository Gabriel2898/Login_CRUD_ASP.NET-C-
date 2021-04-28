using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using Controlador;
using System.Web.UI.WebControls;

namespace VIsta
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }
        }

        protected void btnLOGIN_Click(object sender, EventArgs e)
        {
            C_Login log = new C_Login();
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                msjMensaje.Text = "Falta usuario o contraseña!!";
            }
            else
            {


                SqlDataReader leer;
                log.Usuario = txtUsuario.Text;
                log.Password = txtContraseña.Text;
                leer = log.IniciarSesion();
                if (leer.Read() == true)
                {
                    Response.Redirect("Productos.aspx");
                }
                else
                {
                    msjMensaje.Text = "usuario o contrasela incorrecta";
                }
            }
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {

        }
    }
}