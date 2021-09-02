using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDVentas
    {
        private CDConexion con = new CDConexion();
        DataTable tabla = new DataTable();
        SqlDataReader leer;
        SqlCommand cmd = new SqlCommand();

        public void agregarVenta(int usu, string fecha, double prec)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "AgregarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", usu);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@precioTotal", prec);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public DataTable buscarVenta()
        {
            //procedimientos almacenados
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "BuscarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.cerrarCon();

            return tabla;
        }

        public DataTable listarDetalle(int id)
        {
            //procedimientos almacenados
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "ListarDetalle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            leer = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            tabla.Load(leer);
            con.cerrarCon();

            return tabla;
        }

        public DataTable listarVenta(int id)
        {
            //procedimientos almacenados
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "ListarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            leer = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            tabla.Load(leer);
            con.cerrarCon();

            return tabla;
        }

        public void editarVenta(double prec, int id)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "EditarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@precioTotal", prec);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public void agregarDetalle(int venta, int prod, int cant, double precio)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "AgregarDetalle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@venta", venta);
            cmd.Parameters.AddWithValue("@prod", prod);
            cmd.Parameters.AddWithValue("@cant", cant);
            cmd.Parameters.AddWithValue("@prec", precio);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public void eliminarDetalle(int id)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "EliminarDetalle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public void cancelarVenta(int id)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "CancelarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public void finalizarVenta(int id)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "FinalizarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

    }
}
