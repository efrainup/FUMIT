using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IProgramacionServiciosCliente : IOperacionesAccesoDatos<Entidades.Programacionservicioscliente>
    {
        IEnumerable<Entidades.Programacionservicioscliente> RecuperarProgramacionServiciosClientePorIdCliente(int clienteId);
    }
}
