using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class TipoEquiposRepositorio : AOperacionesBase<Entidades.Tipoequipo>, ITipoEquipos
    {
        public IEnumerable<Tipoequipo> RecuperarPorNombre(bool exacto, params string[] nombre)
        {
            if (exacto)
            {
                return dbSet.Where(w => !w.Borrado && w.Nombre == nombre[0]);
            }
            else
            {
                List<Tipoequipo> tiposEquipos = new List<Tipoequipo>();
                foreach (string partenombre in nombre)
                {
                    tiposEquipos.AddRange(dbSet.Where(w => !w.Borrado && w.Nombre.Contains(partenombre)).ToArray());
                }
                return tiposEquipos;
            }
        }
    }
}
