using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class ContactosRepositorio : AOperacionesBase<Entidades.Contacto>,IContactos
    {

        public IEnumerable<Contacto> RecuperarPorCliente(int ClienteId)
        {
            return dbSet.Where(w => w.ClienteId == ClienteId).ToList();
        }

        public IEnumerable<Contacto> RecuperarPorCliente(Cliente Cliente)
        {
            if (Cliente != null)
            {
                return Cliente.Contactos;
            }
            else {
                return new List<Entidades.Contacto>();
            }
        }

    }
}
