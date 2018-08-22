using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT
{
    public interface INotificador
    {
        void EnviarMensaje(string Mensaje);
        void EnviarMensaje(string Mensaje, string Titulo);
        void EnviarMensaje(string Mensaje, string Titulo, Func<object> Respuesta );
    }
}
