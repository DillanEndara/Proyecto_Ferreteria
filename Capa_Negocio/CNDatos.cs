using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CNDatos
    {
        private CNDatos objetoCD = new CNDatos();
        public DataTable trae_estudiante()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar_estudiante();
            return tabla;
        }
        public void insertarE(string nombre, string apellido, string fechan, string cedula, string dire, string genero)
        {
            objetoCD.insertar(nombre, apellido, Convert.ToDateTime(fechan), cedula, dire, genero);
        }

        public void editarE(string nombre, string apellido, string fechan, string cedula, string dire, string genero, string id)
        {
            objetoCD.editar(nombre, apellido, Convert.ToDateTime(fechan), cedula, dire, genero, Convert.ToInt32(id));
        }

        public void eliminarE(string id)
        {
            objetoCD.eliminar(Convert.ToInt32(id));
        }

    }
}
