using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class EquiposRepositorio : AOperacionesBase<Entidades.Equipo>, IEquipos
    {
        public Equipo RecuperarPorNumeroEconomico(string numeroEconomico)
        {
            return dbSet.FirstOrDefault(w => !w.Borrado && w.NumeroEconomico == numeroEconomico);
        }
    }
}
