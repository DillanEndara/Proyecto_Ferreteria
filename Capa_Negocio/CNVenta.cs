using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CNVenta
    {
        private CDVentas objetoCD = new CDVentas();

        public void agregarVenta(int usu, string fecha, double prec)
        {
            objetoCD.agregarVenta(Convert.ToInt32(usu), fecha, Convert.ToDouble(prec));
        }

        public DataTable buscarVenta()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.buscarVenta();
            return tabla;
        }

        public DataTable listarVenta(int id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.listarVenta(id);
            return tabla;
        }

        public void editarVenta(double total, int id)
        {
            objetoCD.editarVenta(total, id);
        }

        public void agregarDetalle(int venta, string prod, int cant, double precio)
        {
            objetoCD.agregarDetalle(venta, Convert.ToInt32(prod), cant, precio);
        }

        public DataTable listarDetalle(int id)
        {
            DataTable table = new DataTable();
            table = objetoCD.listarDetalle(id);
            return table;
        }

        public void eliminarDetalle(int id)
        {
            objetoCD.eliminarDetalle(id);
        }

        public void cancelarVenta(int id)
        {
            objetoCD.cancelarVenta(id);
        }

        public void finalizarVenta(int id)
        {
            objetoCD.finalizarVenta(id);
        }
    }
}
