using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IAsignacionesEquipo : IOperacionesAccesoDatos<Entidades.Asignacionesequipo>
    {
        IEnumerable<Entidades.Asignacionesequipo> RecuperarEquiposPorCliente(int ClienteId);
        IEnumerable<Entidades.Asignacionesequipo> RecuperarEquiposPorCliente(Entidades.Cliente cliente);
    }
}
