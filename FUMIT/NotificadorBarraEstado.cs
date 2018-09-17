using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FUMIT
{
    public class NotificadorBarraEstado : INotificador
    {
        public System.Windows.Forms.StatusStrip StatusStripInstancia { get; set; }
        public System.Windows.Forms.ToolStripItem ControlMostrarMensajes { get; set; }
        public Timer ControlDeTiempo { get; }

        public NotificadorBarraEstado(System.Windows.Forms.StatusStrip statusStrip)
        {
            ControlDeTiempo = new Timer(2500);
            ControlDeTiempo.Elapsed += ControlDeTiempo_Elapsed;
        }

        private void ControlDeTiempo_Elapsed(object sender, ElapsedEventArgs e)
        {
            ControlMostrarMensajes.Text = "";
        }

        public void EnviarMensaje(string Mensaje)
        {
            ControlDeTiempo.Enabled = false;
            ControlMostrarMensajes.Text = Mensaje;
            ControlDeTiempo.Enabled = true;
            ControlDeTiempo.Start();
        }

        public void EnviarMensaje(string Mensaje, string Titulo)
        {
            ControlMostrarMensajes.Text = Titulo + ": " + Mensaje;
            ControlDeTiempo.Start();
        }

        public void EnviarMensaje(string Mensaje, string Titulo, Func<object> Respuesta)
        {
            throw new NotImplementedException();
        }
    }
}
