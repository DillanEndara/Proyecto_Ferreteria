using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CNUsuario
    {
        private CDUsuario objetoCD = new CDUsuario();
        int rol;

        public int logeo(string correo, string pass)
        {
            DataTable table;
            table = objetoCD.login(correo, pass);
            if(table.Rows.Count > 0)
            {
                if (table.Rows[0][4].ToString() == "1")
                {
                    rol = 1;
                }
                else if (table.Rows[0][4].ToString() == "2")
                {
                    rol = 2;
                }
                return rol;
            }
            else
            {
                rol = 0;
                return rol;
            }  
        }

        public void registrar(string nombre, string apellido, string correo, int rol, string pass, string ced, int telf)
        {
            objetoCD.crearUuario(nombre, apellido, correo, rol, pass, ced, telf);
        }
    }
}
