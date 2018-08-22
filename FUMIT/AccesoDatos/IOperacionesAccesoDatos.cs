using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IOperacionesAccesoDatos<T> where T: class
    {
        void Crear(T entidad);
        Task CrearAsync(T entidad);
        T RecuperarPorId(int Id);
        Task<T> RecuperarPorIdAsync(int Id);
        IEnumerable<T> Recuperar();
        Task<IEnumerable<T>> RecuperarAsync();
        void Actualizar(T entidad);
        Task ActualizarAsync(T entidad);
        void Eliminar(T entidad);
        Task EliminarAsync(T entidad);
    }
}
