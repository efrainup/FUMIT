using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class VSProgramacionServiciosClienteRepositorio : AOperacionesBase<Entidades.Vsprogramacionservicioscliente>, IVSProgramacionServiciosCliente
    {
       
        public IEnumerable<Vsprogramacionservicioscliente> RecuperarPorClienteId(int clienteId)
        {
            return dbSet.Where(w => w.ClienteId == clienteId).ToList();
        }

    }
}
