using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CDConexion
    {
        private SqlConnection con = new SqlConnection("Data Source=VICTORIA;Initial Catalog=dbFerreteria;Integrated Security=True");

        public SqlConnection abrirCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection cerrarCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
