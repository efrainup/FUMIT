using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class AOperacionesBase<T> : IOperacionesAccesoDatos<T> where T : class
    {
        public  DbContext dbContext
        {
            get
            {
                return CommonServiceLocator.ServiceLocator.Current.GetInstance<FUMIT.Entidades.FumitDbContext>();
            }
            
        }
        public DbSet<T> dbSet
        {
            get
            {
                return dbContext.Set<T>();
            }
        }

        public AOperacionesBase()
        {
            
        }

        public void Actualizar(T entidad)
        {
            PropertyInfo keyProperty = entidad.GetType().GetProperties().FirstOrDefault(f => f.GetCustomAttribute<System.ComponentModel.DataAnnotations.KeyAttribute>() != null);

            object valorBuscado = keyProperty.GetValue(entidad);
            T objetoActualizar = dbSet.FirstOrDefault(f => keyProperty.GetValue(f) == valorBuscado);

            PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            }

            dbContext.SaveChanges();
        }

        public async Task ActualizarAsync(T entidad)
        {
            PropertyInfo keyProperty = entidad.GetType().GetProperties().FirstOrDefault(f => f.GetCustomAttribute<System.ComponentModel.DataAnnotations.KeyAttribute>() != null);

            object valorBuscado = keyProperty.GetValue(entidad);
            T objetoActualizar = dbSet.FirstOrDefault(f =>  keyProperty.GetValue(f) == valorBuscado);

            PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            }
            
            await dbContext.SaveChangesAsync();
        }

        public void Crear(T entidad)
        {
            dbSet.Add(entidad);
            dbContext.SaveChanges();
        }

        public async Task CrearAsync(T entidad)
        {
            dbSet.Add(entidad);
            await dbContext.SaveChangesAsync();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Recuperar()
        {
            return dbSet.ToArray();
        }

        public Task<IEnumerable<T>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public T RecuperarPorId()
        {
            throw new NotImplementedException();
        }

        public Task<T> RecuperarPorIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
