using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class CiclosFacturacionRepositorio : AOperacionesBase<Entidades.CiclosFacturacion>, ICiclosFacturacion
    {
        public void Actualizar(CiclosFacturacion entidad)
        {
            throw new NotImplementedException();
        }

        public Task ActualizarAsync(CiclosFacturacion entidad)
        {
            throw new NotImplementedException();
        }

        public void Crear(CiclosFacturacion entidad)
        {
            throw new NotImplementedException();
        }

        public Task CrearAsync(CiclosFacturacion entidad)
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

        public IEnumerable<CiclosFacturacion> Recuperar()
        {
            return dbSet.Where(w => w.Borrado == false).ToList();
        }

        public Task<IEnumerable<CiclosFacturacion>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public CiclosFacturacion RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<CiclosFacturacion> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
