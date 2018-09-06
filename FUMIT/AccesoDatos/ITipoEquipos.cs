using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface ITipoEquipos : IOperacionesAccesoDatos<Entidades.Tipoequipo>
    {
        /// <summary>
        /// Recupera los tipos de equipos por nombre
        /// </summary>
        /// <param name="exacto">Si es verdadero, busca el nombre exacto</param>
        /// <param name="nombre">Nombre o partes del nombre del tipo de equipo que se requiere recuperar</param>
        /// <returns></returns>
        IEnumerable<Entidades.Tipoequipo> RecuperarPorNombre(bool exacto, params string[] nombre);
    }
}
