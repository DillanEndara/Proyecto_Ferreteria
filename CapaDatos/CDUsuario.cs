using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class CDUsuario
    {
        private CDConexion con = new CDConexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable login(string correo, string pass)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "BusquedaUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@pass", pass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            cmd.Connection = con.cerrarCon();
            return dt;
        }

        public void crearUuario(string nombre, string apellido, string correo, int rol, string pass, string ced, int telf)
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "RegistroUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@rol", rol);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@ced", ced);
            cmd.Parameters.AddWithValue("@telf", telf);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = con.cerrarCon();
        }

        public DataTable listarRol()
        {
            cmd.Connection = con.abrirCon();
            cmd.CommandText = "ListarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.cerrarCon();

            return tabla;
        }
    }
}
