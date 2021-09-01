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
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        

        public DataTable CDusuario(CEUsuario obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logue_ez", co);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //private CDConexion con = new CDConexion();
        /*public int login(string correo, string pass)
        {
            int Rol = 0;
            try
            {
                con.abrirCon();
                SqlCommand cmd = new SqlCommand("Select * from TblUsuario where correoUsu=@correo and passUsu=@pass", co);
                cmd.Parameters.AddWithValue("correo", correo);
                cmd.Parameters.AddWithValue("pass", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.cerrarCon();
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][4].ToString() == "1")
                    {
                        Rol = 1;
                    }
                    else if (dt.Rows[0][4].ToString() == "2")
                    {
                        Rol = 2;
                    }
                }
                else
                {
                    Rol = 0;
                }
                return Rol;
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
