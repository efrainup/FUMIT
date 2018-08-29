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
            return dbSet.Where(w => w.ClienteId == ClienteId && w.Borrado==false).ToList();
        }

        public IEnumerable<Contacto> RecuperarPorCliente(Cliente Cliente)
        {
            if (Cliente != null)
            {
                return Cliente.Contactos.Where(w => w.Borrado== false).ToArray();
            }
            else {
                return new List<Entidades.Contacto>();
            }
        }

    }
}
