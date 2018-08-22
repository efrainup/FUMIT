using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ClientesRepositorio : AOperacionesBase<Entidades.Cliente>, IClientes
    {
        public void Actualizar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public new async Task ActualizarAsync(Cliente entidad)
        {
            Cliente objetoActualizar = dbSet.FirstOrDefault(f => f.ClienteId == entidad.ClienteId);

            PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                var keyAttribute = propiedad.CustomAttributes.FirstOrDefault(f => f.AttributeType.Equals(typeof(System.ComponentModel.DataAnnotations.KeyAttribute)));
                if (keyAttribute == null)
                {
                    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
                }
            }

            await dbContext.SaveChangesAsync();
        }

        public void Crear(Cliente entidad)
        {
            dbSet.Add(entidad);
            dbContext.SaveChanges();
        }

        public async Task CrearAsync(Cliente entidad)
        {
            dbSet.Add(entidad);
            await dbContext.SaveChangesAsync();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EliminarAsync(int id)
        {

            Cliente cliente = dbSet.FirstOrDefault(f => f.ClienteId == id);
            cliente.Borrado = true;
            await dbContext.SaveChangesAsync();

        }

        public IEnumerable<Cliente> Recuperar()
        {
            return dbSet.Where(w => w.Borrado == false).AsEnumerable();
        }

        public Task<IEnumerable<Cliente>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Cliente RecuperarPorId(int Id)
        {
            return dbSet.FirstOrDefault(f => f.ClienteId == Id);
        }

        public  Task<Cliente> RecuperarPorIdAsync(int Id)
        {
            return  Task.Run(() => dbSet.FirstOrDefault(f => f.ClienteId == Id));
        }
    }
}
