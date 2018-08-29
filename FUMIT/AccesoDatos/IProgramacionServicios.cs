using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IProgramacionServicios : IOperacionesAccesoDatos<Entidades.Programacionservicio>
    {
        IEnumerable<Entidades.Programacionservicio> RecuperarPorIdSucursal(int sucursalId);
        Entidades.Programacionservicio RecuperarPorNombreProgramacionServicio(string NombreProgramacionServicio);
    }
}
