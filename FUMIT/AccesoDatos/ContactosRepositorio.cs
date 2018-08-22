using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class ContactosRepositorio : AOperacionesBase<Entidades.Contacto>,IContactos
    {
        public void Actualizar(Contacto entidad)
        {
            throw new NotImplementedException();
        }

        public new async Task ActualizarAsync(Contacto entidad)
        {
            Contacto objetoActualizar = dbSet.FirstOrDefault(f => f.ClienteId == entidad.ClienteId);

            PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                var keyAttribute = propiedad.CustomAttributes.FirstOrDefault(f => f.AttributeType.Equals(typeof(System.ComponentModel.DataAnnotations.KeyAttribute)));
                if (keyAttribute == null) {
                    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
                }
            }

            await dbContext.SaveChangesAsync();
        }

        public void Crear(Contacto entidad)
        {
            dbSet.Add(entidad);
            dbContext.SaveChanges();
        }

        public async Task CrearAsync(Contacto entidad)
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

        public IEnumerable<Contacto> Recuperar()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contacto>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contacto> RecuperarPorCliente(int ClienteId)
        {
            return dbSet.Where(w => w.ClienteId == ClienteId).ToList();
        }

        public IEnumerable<Contacto> RecuperarPorCliente(Cliente Cliente)
        {
            if (Cliente != null)
            {
                return Cliente.Contactos;
            }
            else {
                return new List<Entidades.Contacto>();
            }
        }

        public Contacto RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Contacto> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
