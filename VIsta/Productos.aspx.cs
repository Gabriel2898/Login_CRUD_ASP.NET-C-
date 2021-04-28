using Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VIsta
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cargarEmpleados();
            }

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            C_Productos empresa = new C_Productos();
            empresa.EliminarPRod(hf_id.Value);
            lbl_error.Text = "registro eliminado";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_marca.Text = "";
            txt_precio.Text = "";
            txt_stock.Text = "";
            hf_id.Value = "";
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text == "" ||
                txt_descripcion.Text == "" ||
                txt_marca.Text == "" ||
                txt_precio.Text == "" ||
                txt_stock.Text == "")
                {
                    lbl_error.Text = "Los Campos Son requeridos";
                }
                else
                {
                    C_Productos ot = new C_Productos();
                  

                        if (hf_id.Value == "")
                        {
                        C_Productos dep = new C_Productos();
                            dep.InsertarPRod(txt_nombre.Text, txt_descripcion.Text, txt_marca.Text, txt_precio.Text, txt_stock.Text);
                            lbl_error.Text = "registro agregado";
                        txt_nombre.Text = "";
                        txt_descripcion.Text = "";
                        txt_marca.Text = "";
                        txt_precio.Text = "";
                        txt_stock.Text = "";
                            hf_id.Value = "";
                        }
                        else
                        {
                            C_Productos dep = new C_Productos();
                            dep.EditarProd(hf_id.Value, txt_nombre.Text, txt_descripcion.Text, txt_marca.Text, txt_precio.Text, txt_stock.Text);
                            lbl_error.Text = "registro actualizado";
                        txt_nombre.Text = "";
                        txt_descripcion.Text = "";
                        txt_marca.Text = "";
                        txt_precio.Text = "";
                        txt_stock.Text = "";
                        hf_id.Value = "";

                    }
                    }
                
            }
            catch (Exception ex)
            {
                lbl_error.Text = "error" + ex;
            }
        }

        protected void linkVer_Click(object sender, EventArgs e)
        {
            C_Productos cargo = new C_Productos();
            DataTable tbl = cargo.buscar((sender as LinkButton).CommandArgument);
            hf_id.Value = (sender as LinkButton).CommandArgument;
            txt_nombre.Text = tbl.Rows[0]["Nombre"].ToString();
            txt_descripcion.Text = tbl.Rows[0]["Descripcion"].ToString();
            txt_marca.Text = tbl.Rows[0]["Marca"].ToString();
            txt_precio.Text = tbl.Rows[0]["Precio"].ToString();
            txt_stock.Text = tbl.Rows[0]["Stock"].ToString();
        }
        public void cargarEmpleados()
        {
            try
            {
                C_Productos cargo = new C_Productos();
                GrvEmpleados.DataSource = cargo.MostrarProd();
                GrvEmpleados.DataBind();
            }
            catch (Exception ex)
            {
                lbl_error.Text = "Error" + ex;
            }

        }
    }
}