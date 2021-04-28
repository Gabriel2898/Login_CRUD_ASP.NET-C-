using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class C_Productos
    {
        private M_Productos objetoCD = new M_Productos();
        DataTable tabla = new DataTable();
        public DataTable MostrarProd()
        {


            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable buscar(string emplId)
        {
            tabla = objetoCD.MostrarxNombre(emplId);
            return tabla;
        }

        public void InsertarPRod(string nombre, string desc, string marca, string precio, string stock)
        {

            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarPRod(int id)
        {

            objetoCD.Eliminar(id);
        }


    }
}
