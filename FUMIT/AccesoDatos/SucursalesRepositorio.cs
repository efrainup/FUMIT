using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class SucursalesRepositorio : ISucursales
    {
        FumitDbContext dbContext = new FumitDbContext();

        public void Actualizar(Sucursal entidad)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(Sucursal entidad)
        {
            throw new NotImplementedException();
        }

        public void Crear(Sucursal entidad)
        {
            dbContext.Sucursales.Add(entidad);
            dbContext.SaveChanges();
        }

        public async Task CrearAsync(Sucursal entidad)
        {
            dbContext.Sucursales.Add(entidad);
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

        public IEnumerable<Sucursal> Recuperar()
        {
            return dbContext.Sucursales.ToArray();
        }

        public Task<IEnumerable<Sucursal>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Sucursal RecuperarPorId()
        {
            throw new NotImplementedException();
        }

        public Task<Sucursal> RecuperarPorIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
