using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ClientesRepositorio : IClientes
    {
        FumitDbContext dbContext;

        public ClientesRepositorio()
        {
            dbContext = new FumitDbContext();
        }

        public void Actualizar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public void Crear(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public async Task CrearAsync(Cliente entidad)
        {
            dbContext.Clientes.Add(entidad);
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

        public IEnumerable<Cliente> Recuperar()
        {
            return dbContext.Clientes.ToList();
        }

        public Task<IEnumerable<Cliente>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Cliente RecuperarPorId()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> RecuperarPorIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
