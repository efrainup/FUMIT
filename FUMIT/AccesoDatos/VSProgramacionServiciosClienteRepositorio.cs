using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class VSProgramacionServiciosClienteRepositorio : AOperacionesBase<Entidades.Vsprogramacionservicioscliente>, IVSProgramacionServiciosCliente
    {
        public void Actualizar(Vsprogramacionservicioscliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(Vsprogramacionservicioscliente entidad)
        {
            throw new NotImplementedException();
        }

        public void Crear(Vsprogramacionservicioscliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(Vsprogramacionservicioscliente entidad)
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

        public IEnumerable<Vsprogramacionservicioscliente> Recuperar()
        {
            return dbSet.Where(w => w.Borrado == false).ToList();
        }

        public Task<IEnumerable<Vsprogramacionservicioscliente>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public Vsprogramacionservicioscliente RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Vsprogramacionservicioscliente> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
