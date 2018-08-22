using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class ServiciosRepositorio : AOperacionesBase<Servicio>, IServicio
    {
        public void Actualizar(Servicio entidad)
        {
            throw new NotImplementedException();
        }

        public new async Task ActualizarAsync(Servicio entidad)
        {
            //Servicio objetoActualizar = dbSet.FirstOrDefault(f => f.ServicioId == entidad.ServicioId);

            //PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            //foreach (PropertyInfo propiedad in propiedades)
            //{
            //    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            //}

            await dbContext.SaveChangesAsync();
        }

        public void Crear(Servicio entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Servicio entidad)
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

        public IEnumerable<Servicio> Recuperar()
        {
            return dbSet.Where(w => w.Borrado == false).ToList();
        }

        public Task<IEnumerable<Servicio>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Servicio RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Servicio> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
