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
        CDUsuario objd = new CDUsuario();
        public DataTable CNusuario(CEUsuario obje) 
        {
            return objd.CDusuario(obje);

        }
    }
}
