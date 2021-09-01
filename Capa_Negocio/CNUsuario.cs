using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

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
                if (table.Rows[0][5].ToString() == "1")
                {
                    rol = 1;
                }
                else if (table.Rows[0][5].ToString() == "2")
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


        CDUsuario objd = new CDUsuario();
        public DataTable CNusuario(CEUsuario obje)
        {
            return objd.CDusuario(obje);
        }

        public void registrar(string nombre, string apellido, string correo, string rol, string pass, string ced, string telf)
        {
            objetoCD.crearUuario(nombre, apellido, correo, Convert.ToInt32(rol), pass, ced, Convert.ToInt32(telf));
        }

        public DataTable listarRol()
        {
            DataTable tableC = new DataTable();
            tableC = objetoCD.listarRol();
            return tableC;
        }
    }
}
