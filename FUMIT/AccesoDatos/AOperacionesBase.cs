using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.ComponentModel.DataAnnotations;

namespace FUMIT.AccesoDatos
{
    public class AOperacionesBase<T>/* : IOperacionesAccesoDatos<T> */where T : class
    {
        public Entidades.FumitDbContext dbContext
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

        public virtual T Crear(T entidad)
        {
            entidad = dbSet.Add(entidad);
            dbContext.SaveChanges();

            return entidad;
        }

        public virtual async Task<T> CrearAsync(T entidad)
        {
            entidad = dbSet.Add(entidad);
            await dbContext.SaveChangesAsync();
            return entidad;
        }
        public virtual T Actualizar(T entidad)
        {
            entidad = dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
            dbContext.SaveChanges();

            return entidad;
        }

        public virtual async Task<T> ActualizarAsync(T entidad)
        {
            entidad = dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return entidad;
        }

        public virtual void Eliminar(T entidad)
        {

            dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).Property("Borrado").CurrentValue = false;//.CurrentValues.SetValues(
            dbContext.Entry<T>(entidad).Property("Borrado").IsModified = true;
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
             dbContext.SaveChanges();
        }

        public virtual async Task EliminarAsync(T entidad)
        {
            dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).Property("Borrado").CurrentValue = true;//.CurrentValues.SetValues(
            dbContext.Entry<T>(entidad).Property("Borrado").IsModified = true;
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public virtual IEnumerable<T> Recuperar()
        {
            return dbContext.Set<T>().Where("Borrado=@0", false).ToList();
        }

        public virtual async Task<IEnumerable<T>> RecuperarAsync()
        {
            return await dbContext.Set<T>().Where("Borrado=@0", false).ToListAsync();
        }

        public virtual T RecuperarPorId(int Id)
        {
            PropertyInfo propiedadId = typeof(T).GetProperties().FirstOrDefault(f => f.GetCustomAttribute(typeof(KeyAttribute)) != null);
            return dbContext.Set<T>().Where($"Borrado=@0 && {propiedadId.Name}=@1", false,Id).FirstOrDefault();
        }

        public virtual async Task<T> RecuperarPorIdAsync(int Id)
        {
            PropertyInfo propiedadId = typeof(T).GetProperties().FirstOrDefault(f => f.GetCustomAttribute(typeof(KeyAttribute)) != null);
            return await dbContext.Set<T>().Where("Borrado=@0 && @1=@2", false, propiedadId.Name, Id).FirstOrDefaultAsync();
        }
    }
}
