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

namespace FUMIT.Formularios.Operacion
{
    public partial class ServiciosProgramados: UserControl
    {
        private bool modoEditar = false;
        private int clienteId;
        public int ClienteId { get {
                return clienteId;
            }
            set
            {
                clienteId = value;
                if (Repositorio != null)
                {
                    CargarDatosCliente(clienteId);
                }
            }
        }
        public bool ModoEditar { get {
                return modoEditar;
            }
            set {
                modoEditar = value;
                tsbCancelar.Enabled = modoEditar;
                tsbEditar.Enabled = !modoEditar;
                bindingNavigatorAddNewItem.Enabled = !modoEditar;
                bindingNavigatorDeleteItem.Enabled = !modoEditar;
                serviciosprogramadoBindingNavigatorSaveItem.Enabled = modoEditar;
                tsbCancelar.Visible = modoEditar;

                //Formulario
                fechaServicioDateTimePicker.Enabled = modoEditar;
                prioridadTextBox.ReadOnly = !modoEditar;
                TipoServicioComboBox.Enabled = modoEditar;
                activoCheckBox.Enabled = modoEditar;
                canceladoCheckBox.Enabled = modoEditar;
                observacionesTextBox.ReadOnly = !modoEditar;
            }

        }

        [DefaultValue(false)]
        public bool CancelarCargaDefault { get; set; }
        public IServiciosProgramados Repositorio { get; set; }
        public Entidades.Serviciosprogramado ServicioProgramadoActual
        {
            get
            {
                return serviciosprogramadoBindingSource.Current as Entidades.Serviciosprogramado;
            }
        }

        #region Eventos
        public event EventHandler<Entidades.Serviciosprogramado> ServicioProgramadoGuardado;
        #endregion

        public ServiciosProgramados()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private void ServiciosProgramados_Load(object sender, EventArgs e)
        {

            if (!DesignMode)
            {
                Repositorio = ServiceLocator.Current.GetInstance<IServiciosProgramados>();
                if (!CancelarCargaDefault)
                {
                    CargarDatosCliente(ClienteId);
                }

            }
        }

        private void CargarDatosCliente(int clienteId)
        {
            List<Entidades.Serviciosprogramado> serviciosprogramados = Repositorio.RecuperarPorClienteId(clienteId).ToList();
            BindingList<Entidades.Serviciosprogramado> bindingList = new BindingList<Entidades.Serviciosprogramado>(serviciosprogramados);

            serviciosprogramadoBindingSource.DataSource = bindingList;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private async void serviciosprogramadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(ServicioProgramadoActual != null)
            {
                if(ServicioProgramadoActual.ServicioProgramadoId > 0)
                {
                    await Repositorio.ActualizarAsync(ServicioProgramadoActual);
                }
                else
                {
                    await Repositorio.CrearAsync(ServicioProgramadoActual);
                }
            }

            //Se dispara evento para notificar cuando s ha guardado un nuevo servicio
            ServicioProgramadoGuardado.Invoke(this, ServicioProgramadoActual);

            ModoEditar = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            ModoEditar = false;
        }
    }
}
