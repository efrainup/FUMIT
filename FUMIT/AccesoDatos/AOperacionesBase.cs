using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class AOperacionesBase<T> /*: IOperacionesAccesoDatos<T>*/ where T : class
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


    }
}
