using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface ITickets : IOperacionesAccesoDatos<Entidades.Ticket>
    {
        IEnumerable<Entidades.Ticket> RecuperarTicketsPorCliente(int IdCliente);
        IEnumerable<Entidades.Ticket> RecuperarTicketsPorCliente(Entidades.Cliente Cliente);
        IEnumerable<Entidades.Ticket> RecuperarTicketsPorServicioProgramado(int IdServicioProgramado);
        IEnumerable<Entidades.Ticket> RecuperarTicketsPorServicioProgramado(Entidades.Serviciosprogramado ServicioProgramado);
    }
}
