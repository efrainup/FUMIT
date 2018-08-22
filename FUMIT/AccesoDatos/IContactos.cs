using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IContactos : IOperacionesAccesoDatos<Entidades.Contacto>
    {
        IEnumerable<Entidades.Contacto> RecuperarPorCliente(int ClienteId);
        IEnumerable<Entidades.Contacto> RecuperarPorCliente(Entidades.Cliente Cliente);
    }
}
