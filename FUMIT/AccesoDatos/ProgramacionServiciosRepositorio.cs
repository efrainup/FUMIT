using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ProgramacionServiciosRepositorio : AOperacionesBase<Entidades.Programacionservicio>, IProgramacionServicios
    {
        public IEnumerable<Programacionservicio> RecuperarPorIdSucursal(int sucursalId)
        {
            return dbSet.Where(w => w.SucursalId == sucursalId).AsEnumerable();
        }

        public new async Task ActualizarAsync(Programacionservicio entidad)
        {
            Programacionservicio objetoActualizar = dbSet.FirstOrDefault(f => f.ProgramacionServicioId == entidad.ProgramacionServicioId);

            PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
