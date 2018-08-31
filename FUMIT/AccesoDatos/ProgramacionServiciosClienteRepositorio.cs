using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ProgramacionServiciosClienteRepositorio : AOperacionesBase<Programacionservicioscliente>, IProgramacionServiciosCliente
    {
        public IEnumerable<Programacionservicioscliente> RecuperarProgramacionServiciosClientePorIdCliente(int clienteId)
        {
            return dbSet.Where(w => !w.Borrado && w.ClienteId == clienteId).ToList();
        }

        public override Task ActualizarAsync(Programacionservicioscliente entidad)
        {
            //Si se actualiza el estado de activo, entonces se pone una fecha final. Solo si estaba activo anteriormente
            bool estabaActivo = dbContext.Entry(entidad).OriginalValues.GetValue<bool>("Activo");
            if (estabaActivo && entidad.Activo == false)
            {
                entidad.FechaTermino = DateTime.Now;
            }

            return base.ActualizarAsync(entidad);
        }
        

    }
}
