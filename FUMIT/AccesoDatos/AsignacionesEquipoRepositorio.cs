using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class AsignacionesEquipoRepositorio : AOperacionesBase<Entidades.Asignacionesequipo>, IAsignacionesEquipo
    {
        public IEnumerable<Asignacionesequipo> RecuperarEquiposPorCliente(int ClienteId)
        {
            return dbSet.Where(w => w.Borrado == false && w.ClienteId == ClienteId).ToArray();
        }

        public IEnumerable<Asignacionesequipo> RecuperarEquiposPorCliente(Cliente cliente)
        {
            return cliente.Asignacionesequipos.Where(w => w.Borrado == false).ToArray();
        }
    }
}
