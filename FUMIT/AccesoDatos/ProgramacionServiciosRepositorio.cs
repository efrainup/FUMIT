using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ProgramacionServiciosRepositorio : AOperacionesBase<Entidades.Programacionservicio>, IProgramacionServicios
    {
        public IEnumerable<Programacionservicio> RecuperarPorIdSucursal(int sucursalId)
        {
            return dbSet.Where(w => w.SucursalId == sucursalId).AsEnumerable();
        }

        
    }
}
