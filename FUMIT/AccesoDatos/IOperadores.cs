using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IOperadores : IOperacionesAccesoDatos<Entidades.Operador>
    {
        IEnumerable<Entidades.Operador> RecuperarPorSucursal(int SucursalId);
        IEnumerable<Entidades.Operador> RecuperarPorNombre(string Nombre, bool CoincidenciaExacta = false);
    }
}
