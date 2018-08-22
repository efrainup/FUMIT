using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ProgramacionServiciosClienteRepositorio : AOperacionesBase<Programacionservicioscliente>, IProgramacionServiciosCliente
    {
        public IEnumerable<Programacionservicioscliente> RecuperarProgramacionServiciosClientePorIdCliente(int clienteId)
        {
            return dbSet.Where(w => !w.Borrado && w.ClienteId == clienteId).ToList();
        }

        public new async Task ActualizarAsync(Entidades.Programacionservicioscliente entidad)
        {
            //Programacionservicioscliente objetoActualizar = dbSet.FirstOrDefault(f => f.ProgramacionServicioId == entidad.ProgramacionServicioId);

            //PropertyInfo[] propiedades = objetoActualizar.GetType().GetProperties();

            //foreach (PropertyInfo propiedad in propiedades)
            //{
            //    propiedad.SetValue(objetoActualizar, propiedad.GetValue(entidad));
            //}

            await dbContext.SaveChangesAsync();
        }

        public Programacionservicioscliente RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Programacionservicioscliente> RecuperarPorIdAsync(int Id)
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

        public void Crear(Programacionservicioscliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Programacionservicioscliente entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Programacionservicioscliente> Recuperar()
        {
            return dbSet.Where(w => w.Borrado == false);
        }

        public Task<IEnumerable<Programacionservicioscliente>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public void Actualizar(Programacionservicioscliente entidad)
        {
            throw new NotImplementedException();
        }
    }
}
