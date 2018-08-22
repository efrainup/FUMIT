using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class SucursalesRepositorio : AOperacionesBase<Sucursal>,ISucursales
    {
        public void Actualizar(Sucursal entidad)
        {
            throw new NotImplementedException();
        }

        public new async Task ActualizarAsync(Sucursal entidad)
        {
            //Sucursal objetoActualizar = dbSet.FirstOrDefault(f => f.SucursalId == entidad.SucursalId);

            //PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            //foreach (PropertyInfo propiedad in propiedades)
            //{
            //    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            //}

            await dbContext.SaveChangesAsync();
        }

        public void Crear(Sucursal entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Sucursal entidad)
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

        public IEnumerable<Sucursal> Recuperar()
        {
            return dbSet.Where(w => w.Borrado == false).ToList();
        }

        public Task<IEnumerable<Sucursal>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Sucursal RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Sucursal> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
