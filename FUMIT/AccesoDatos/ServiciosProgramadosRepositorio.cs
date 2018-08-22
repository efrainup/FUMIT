using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class ServiciosProgramadosRepositorio : AOperacionesBase<Serviciosprogramado>, IServiciosProgramados
    {
        public void Actualizar(Serviciosprogramado entidad)
        {
            throw new NotImplementedException();
        }

        public new async Task ActualizarAsync(Entidades.Serviciosprogramado entidad)
        {
            //Serviciosprogramado objetoActualizar = dbSet.FirstOrDefault(f => f.ServicioProgramadoId == entidad.ServicioProgramadoId);

            //PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            //foreach (PropertyInfo propiedad in propiedades)
            //{
            //    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            //}

            await dbContext.SaveChangesAsync();
        }

        public void Crear(Serviciosprogramado entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Serviciosprogramado entidad)
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

        public IEnumerable<Serviciosprogramado> Recuperar()
        {
            return dbSet.ToList();
        }

        public Task<IEnumerable<Serviciosprogramado>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Serviciosprogramado RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Serviciosprogramado> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
