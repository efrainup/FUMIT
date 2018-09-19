using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class OperadoresRepositorio : AOperacionesBase<Entidades.Operador>, IOperadores
    {
        public IEnumerable<Operador> RecuperarPorNombre(string Nombre, bool CoincidenciaExacta = false)
        {
            if (CoincidenciaExacta)
            {
                return dbSet.Where(w => w.Borrado == false && w.Nombre == Nombre);
            }
            else
            {
                return dbSet.Where(w => w.Borrado == false && w.Nombre.Contains(Nombre));
            }
        }

        public IEnumerable<Operador> RecuperarPorSucursal(int SucursalId)
        {
            return dbSet.Where(w => w.Borrado == false && w.SucursalId == SucursalId);
        }
    }
}
