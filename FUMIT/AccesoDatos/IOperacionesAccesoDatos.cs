using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IOperacionesAccesoDatos<T> where T: class
    {
        T Crear(T entidad);
        Task<T> CrearAsync(T entidad);
        T RecuperarPorId(int Id);
        Task<T> RecuperarPorIdAsync(int Id);
        IEnumerable<T> Recuperar();
        Task<IEnumerable<T>> RecuperarAsync();
        T Actualizar(T entidad);
        Task<T> ActualizarAsync(T entidad);
        void Eliminar(T entidad);
        Task EliminarAsync(T entidad);
    }
}
