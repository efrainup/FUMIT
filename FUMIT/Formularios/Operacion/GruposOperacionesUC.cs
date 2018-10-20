using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FUMIT.AccesoDatos;
using CommonServiceLocator;
using FUMIT.Entidades;

namespace FUMIT.Formularios.Operacion
{
    public partial class GruposOperacionesUC : UserControl, IFormularioSeleccionable<Entidades.Gruposoperacion>
    {
        #region Propiedades
        public IGruposOperaciones GruposOperacionesRepositorio { get; set; }
        public IServicio ServiciosRpositorio { get; set; }
        public bool ModoSeleccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Gruposoperacion SeleccionActual => gruposoperacionBindingSource.Current as Gruposoperacion;
        public List<Servicio> ListaDeServicios { get; set; }
        #endregion

        public GruposOperacionesUC()
        {
            InitializeComponent();
        }

        public event EventHandler<Gruposoperacion> ItemSeleccionado;

        private void GruposOperacionesUC_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                GruposOperacionesRepositorio = ServiceLocator.Current.GetInstance<IGruposOperaciones>();
                ServiciosRpositorio = ServiceLocator.Current.GetInstance<IServicio>();

                //Se cargan los servicios en el autocomplete
                AutoCompleteStringCollection sugerenciasAutocompletado = new AutoCompleteStringCollection();
                ListaDeServicios = ServiciosRpositorio.Recuperar().ToList();
                sugerenciasAutocompletado.AddRange(ListaDeServicios.Select(s => s.Nombre).ToArray());
                servicioTextBox.AutoCompleteCustomSource = sugerenciasAutocompletado;


                gruposoperacionBindingSource.DataSource =  GruposOperacionesRepositorio.Recuperar();

            }
        }
    }
}
