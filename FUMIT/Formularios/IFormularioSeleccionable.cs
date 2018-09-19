using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.Formularios
{
    /// <summary>
    /// Establece si un formulario permite la selección de registros
    /// </summary>
    /// <typeparam name="T">Tipo de dato que se selecciona en el formulario</typeparam>
    interface IFormularioSeleccionable<T>
    {
        /// <summary>
        /// Establece si el formulario está en modo selección
        /// </summary>
        bool ModoSeleccion { get; set; }
        /// <summary>
        /// Devuelve el registro seleccionado
        /// </summary>
        T SeleccionActual { get; }
        /// <summary>
        /// Evento que se dispara cuando se ha finalizado la seleccion
        /// </summary>
        event EventHandler<T> ItemSeleccionado;
    }
}
