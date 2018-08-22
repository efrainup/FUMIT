using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT
{
    class NotificadorBarraEstado : INotificador
    {
        public System.Windows.Forms.StatusStrip StatusStripInstancia { get; set; }

        public NotificadorBarraEstado(System.Windows.Forms.StatusStrip statusStrip)
        {
        }

        public void EnviarMensaje(string Mensaje)
        {
            StatusStripInstancia.Text = Mensaje;
        }

        public void EnviarMensaje(string Mensaje, string Titulo)
        {
            throw new NotImplementedException();
        }

        public void EnviarMensaje(string Mensaje, string Titulo, Func<object> Respuesta)
        {
            throw new NotImplementedException();
        }
    }
}
