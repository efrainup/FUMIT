using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT.Formularios.Compartidos
{
    public partial class BusquedaServicio : Form
    {
        public AccesoDatos.IServicio ServicioRepositorio { get; set; }
        public event EventHandler<Entidades.Servicio> ServicioSeleccionado;
        public Entidades.Servicio ServicioActual {
            get
            {
                return (servicioBindingSource.Current as Entidades.Servicio);
            }
        }

        public BusquedaServicio()
        {
            InitializeComponent();
        }

        private void BusquedaServicio_Load(object sender, EventArgs e)
        {
            ServicioRepositorio = ServiceLocator.Current.GetInstance<AccesoDatos.IServicio>();
            if (!DesignMode)
            {
                servicioBindingSource.Clear();

                IEnumerable<Entidades.Servicio> serviciosEnumerable = ServicioRepositorio.Recuperar();

                foreach(Entidades.Servicio servicio in serviciosEnumerable)
                {
                    servicioBindingSource.Add(servicio);
                }

            }
        }

        private void btnSeleccionarServicio_Click(object sender, EventArgs e)
        {
            ServicioSeleccionado.Invoke(this, ServicioActual);
            Close();
        }
    }
}
