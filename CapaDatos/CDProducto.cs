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
    public class CDProducto
    {
        private CDConexion con = new CDConexion();
        DataTable tabla = new DataTable();
        SqlDataReader leer;
        SqlCommand cmd = new SqlCommand();

        public DataTable mostrarEstudiante()
        {
            //procedimientos almacenados
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "ListarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.cerrarCon();

            return tabla;
        }

        public void agregarProd(string cod, string nomb, int cat, double prec, int stock, string descr)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "IngresoProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", cod);
            cmd.Parameters.AddWithValue("@nombre", nomb);
            cmd.Parameters.AddWithValue("@categoria", cat);
            cmd.Parameters.AddWithValue("@precio", prec);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@descripcion", descr);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public void editarProd(string cod, string nomb, int cat, double prec, int stock, string descr, int id)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "EditarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", cod);
            cmd.Parameters.AddWithValue("@nombre", nomb);
            cmd.Parameters.AddWithValue("@categoria", cat);
            cmd.Parameters.AddWithValue("@precio", prec);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@descripcion", descr);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public void eliminarProd(int id)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "EliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrarCon();
        }

        public DataTable listarCat()
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "ListarCategoria";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.cerrarCon();

            return tabla;
        }
    }
}
