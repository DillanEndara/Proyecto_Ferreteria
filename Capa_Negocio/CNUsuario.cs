using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CNUsuario
    {
        private CDUsuario objetoCD = new CDUsuario();

        public int logeo(string correo, string pass)
        {
            int rol = objetoCD.login(correo, pass);
            return rol;
        }
    }
}
