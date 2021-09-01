using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CNProducto
    {
        private CDProducto objetoCD = new CDProducto();

        public DataTable listarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarProducto();
            return tabla;
        }

        public void agregarProducto(string cod, string nomb, string cat, string prec, string stock, string descr)
        {
            objetoCD.agregarProd(cod, nomb, Convert.ToInt32(cat), Convert.ToDouble(prec), Convert.ToInt32(stock), descr);
        }

        public void editarProd(string cod, string nomb, string cat, string prec, string stock, string descr, string id)
        {
            objetoCD.editarProd(cod, nomb, Convert.ToInt32(cat), Convert.ToDouble(prec), Convert.ToInt32(stock), descr, Convert.ToInt32(id));
        }

        public void eliminarProd(string id)
        {
            objetoCD.eliminarProd(Convert.ToInt32(id));
        }

        public DataTable listarCat()
        {
            DataTable tableC = new DataTable();
            tableC = objetoCD.listarCat();
            return tableC;
        }

        public DataTable listarCmb(string id)
        {
            DataTable tableP = new DataTable();
            tableP = objetoCD.listarCmb(Convert.ToInt32(id));
            return tableP;
        }
    }
}
