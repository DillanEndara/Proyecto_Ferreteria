using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CDUsuario
    {
        private CDConexion con = new CDConexion();

        public int login(string correo, string pass)
        {
            int Rol = 0;
            try
            {
                con.abrirCon();
                SqlCommand cmd = new SqlCommand("Select idRol from TblUsuario where correoUsu=@correo and passUsu=@pass");
                cmd.Parameters.AddWithValue("correo", correo);
                cmd.Parameters.AddWithValue("pass", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.cerrarCon();
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        Rol = 1;
                    }
                    else if (dt.Rows[0][1].ToString() == "2")
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
        }
    }
}
