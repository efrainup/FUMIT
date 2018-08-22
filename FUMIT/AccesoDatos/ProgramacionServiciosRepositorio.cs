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
            //Programacionservicio objetoActualizar = dbSet.FirstOrDefault(f => f.ProgramacionServicioId == entidad.ProgramacionServicioId);

            //PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            //foreach (PropertyInfo propiedad in propiedades)
            //{
            //    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            //}

            await dbContext.SaveChangesAsync();
        }

        public Programacionservicio RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Programacionservicio> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Crear(Programacionservicio entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Programacionservicio entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Programacionservicio> Recuperar()
        {
            return dbSet.ToList();
        }

        public Task<IEnumerable<Programacionservicio>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public void Actualizar(Programacionservicio entidad)
        {
            throw new NotImplementedException();
        }
    }
}
