using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.Formularios
{
    interface IFormularioSeleccionable<T>
    {
        bool ModoSeleccion { get; set; }
        T SeleccionActual { get; }
        event EventHandler<T> ItemSeleccionado;
    }
}
