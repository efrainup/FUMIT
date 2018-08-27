using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IServiciosProgramados : IOperacionesAccesoDatos<Entidades.Serviciosprogramado>
    {
        Task ProgramarServicios(Entidades.Programacionservicioscliente programacionservicio);
        IEnumerable<Entidades.Serviciosprogramado> RecuperarPorClienteId(int ClienteId);
    }
}
