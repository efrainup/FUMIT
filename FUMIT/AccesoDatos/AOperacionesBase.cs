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
        public virtual void Actualizar(T entidad)
        {
            dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public virtual async Task ActualizarAsync(T entidad)
        {
            dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public void Eliminar(T entidad)
        {

            dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).Property("Borrado").CurrentValue = false;//.CurrentValues.SetValues(
            dbContext.Entry<T>(entidad).Property("Borrado").IsModified = true;
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
             dbContext.SaveChanges();
        }

        public async Task EliminarAsync(T entidad)
        {
            dbSet.Attach(entidad);
            dbContext.Entry<T>(entidad).Property("Borrado").CurrentValue = true;//.CurrentValues.SetValues(
            dbContext.Entry<T>(entidad).Property("Borrado").IsModified = true;
            dbContext.Entry<T>(entidad).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public IEnumerable<T> Recuperar()
        {
            return dbContext.Set<T>().Where("Borrado=@0", false).ToList();
        }

        public async Task<IEnumerable<T>> RecuperarAsync()
        {
            return await dbContext.Set<T>().Where("Borrado=@0", false).ToListAsync();
        }

        public T RecuperarPorId(int Id)
        {
            PropertyInfo propiedadId = typeof(T).GetProperties().FirstOrDefault(f => f.GetCustomAttribute(typeof(KeyAttribute)) != null);
            return dbContext.Set<T>().Where($"Borrado=@0 && {propiedadId.Name}=@1", false,Id).FirstOrDefault();
        }

        public async Task<T> RecuperarPorIdAsync(int Id)
        {
            PropertyInfo propiedadId = typeof(T).GetProperties().FirstOrDefault(f => f.GetCustomAttribute(typeof(KeyAttribute)) != null);
            return await dbContext.Set<T>().Where("Borrado=@0 && @1=@2", false, propiedadId.Name, Id).FirstOrDefaultAsync();
        }
    }
}
