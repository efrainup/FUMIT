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
using FUMIT.Entidades;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace FUMIT.Formularios.Clientes
{
    public partial class ProgramacionServiciosClientes : UserControl
    {
        private int clienteId;
        public int ClienteId
        {
            get
            {
                return clienteId;
            }
            set
            {
                clienteId = value;
                if (ProgramacionServiciosClienteRepositorio != null)
                {
                    CargarDatos(clienteId);
                }
            }
        }

        protected bool modoEditar = false;
        public bool ModoEditar
        {
            get
            {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                bindingNavigatorAddNewItem.Enabled = !modoEditar;
                bindingNavigatorDeleteItem.Enabled = !modoEditar;
                tsbCancelar.Enabled = modoEditar;
                programacionserviciosclienteBindingNavigatorSaveItem.Enabled = modoEditar;
                fechaInicioDateTimePicker.Enabled = modoEditar;
                fechaTerminoDateTimePicker.Enabled = modoEditar;
                btnBusquedaHorario.Enabled = modoEditar;
                btnBusquedaServicio.Enabled = modoEditar;
                activoCheckBox.Enabled = modoEditar;
            }
        }
        public bool ModoNormal {
            get {
                return !modoEditar;
            }
        }

        IServiciosProgramados serviciosProgramados { get; set; }
        public IVSProgramacionServiciosCliente vistaProgramacionServiciosCliente { get; set; }
        public IProgramacionServiciosCliente ProgramacionServiciosClienteRepositorio { get; set; }
        public Entidades.Programacionservicioscliente ProgramacionServicioClienteActual { get
            {
                return (programacionserviciosclienteBindingSource.Current as Entidades.Programacionservicioscliente);
            }
        }



        public ProgramacionServiciosClientes()
        {
            InitializeComponent();
        }

        private void programacionServicioIdLabel1_Click(object sender, EventArgs e)
        {

        }

        private void programacionServicioIdTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CargarDatos(int clienteId)
        {
            IEnumerable<Programacionservicioscliente> programacion = ProgramacionServiciosClienteRepositorio.RecuperarProgramacionServiciosClientePorIdCliente(clienteId);
            
            programacionserviciosclienteBindingSource.DataSource = new BindingList<Programacionservicioscliente>(programacion.ToList());


            vsprogramacionserviciosclienteBindingSource.DataSource = vistaProgramacionServiciosCliente.RecuperarPorClienteId(clienteId);
        }

        private void ProgramacionServiciosClientes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ProgramacionServiciosClienteRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<IProgramacionServiciosCliente>();
                vistaProgramacionServiciosCliente = CommonServiceLocator.ServiceLocator.Current.GetInstance<IVSProgramacionServiciosCliente>();
                serviciosProgramados = CommonServiceLocator.ServiceLocator.Current.GetInstance<IServiciosProgramados>();

                //Se inicializa binding para que el boton de programar servicios se deshabilite cuando los servicios ya hayan sido programados
                var binding = new System.Windows.Forms.Binding("Enabled", this.programacionserviciosclienteBindingSource, "ServiciosProgramados", true);
                binding.Parse += (s, eargs) => eargs.Value = !((bool)eargs.Value);
                binding.Format += (s, eargs) => eargs.Value = !((bool)eargs.Value);
                this.btnProgramarServicios.DataBindings.Add(binding);

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEditar = true;

            ProgramacionServicioClienteActual.ClienteId = ClienteId;
        }

        private void btnBusquedaProgramacionServicioPorId_Click(object sender, EventArgs e)
        {
            var formulario = new Formularios.Operacion.ProgramacionServiciosSucursales();
            formulario.SucursalId = ClienteId;
            formulario.ModoBusqueda = true;
            formulario.Show();
            formulario.ProgramacionServicioSeleccionado += (object sender2, Entidades.Programacionservicio resultado) =>
            {
                ProgramacionServicioClienteActual.ProgramacionServicioId = resultado.ProgramacionServicioId;
                ProgramacionServicioClienteActual.Programacionservicio = resultado;

                programacionserviciosclienteBindingNavigator.Refresh();
            };
        }

        private void programacionserviciosclienteBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("Algo cambio");
        }

        private async void programacionserviciosclienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProgramacionServicioClienteActual.ProgramacionServiciosClienteId > 0)
                {
                    await ProgramacionServiciosClienteRepositorio.ActualizarAsync(ProgramacionServicioClienteActual);
                }
                else
                {
                    await ProgramacionServiciosClienteRepositorio.CrearAsync(ProgramacionServicioClienteActual);
                }

                ModoEditar = false;
            }catch(DbEntityValidationException excepcionValidacion)
            {
                foreach(DbEntityValidationResult validacion in excepcionValidacion.EntityValidationErrors)
                {
                    foreach(DbValidationError errorvalidacion in validacion.ValidationErrors)
                    {
                        //this.Controls[0].DataBindings.Add()
                        //errorProvider1.BindToDataAndErrors()
                    }
                }

                //eexception.InnerException

                //MessageBox.Show("Hubo un error al guardar. Favor de intentarlo nuevamente o contacte a sistemas.");
            }
            catch(Exception excepcion)
            {
                MessageBox.Show("Hubo un error al guardar. Favor de intentarlo nuevamente o contacte a sistemas.");
            }
        }

        private async void btnProgramarServicios_Click(object sender, EventArgs e)
        {
            IServiciosProgramados serviciosProgramados = CommonServiceLocator.ServiceLocator.Current.GetInstance<IServiciosProgramados>();

            Programacionservicioscliente programacionServicio = ProgramacionServicioClienteActual;

            await serviciosProgramados.ProgramarServicios(programacionServicio);

            programacionserviciosclienteBindingSource.ResetBindings(false);
        }


        private void vsprogramacionserviciosclienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            programacionserviciosclienteBindingSource.Position = vsprogramacionserviciosclienteBindingSource.Position;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nombreLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            ModoEditar = false;
        }

        private void btnBusquedaServicio_Click(object sender, EventArgs e)
        {
            var busquedaServicio = new Formularios.Compartidos.BusquedaServicio();
            busquedaServicio.ServicioSeleccionado += (sender2, servicio) =>
           {
               ProgramacionServicioClienteActual.ServicioId = servicio.ServicioId;
               ProgramacionServicioClienteActual.Servicio = servicio;
               programacionserviciosclienteBindingSource.ResetBindings(false);
           };
            busquedaServicio.ShowDialog();
        }

        private void btnBusquedaHorario_Click(object sender, EventArgs e)
        {
            var formulario = new Formularios.Operacion.ProgramacionServiciosSucursales();
            formulario.SucursalId = ClienteId;
            formulario.ModoBusqueda = true;
            formulario.Show();
            formulario.ProgramacionServicioSeleccionado += (object sender2, Entidades.Programacionservicio resultado) =>
            {
                ProgramacionServicioClienteActual.ProgramacionServicioId = resultado.ProgramacionServicioId;
                ProgramacionServicioClienteActual.Programacionservicio = resultado;

                programacionserviciosclienteBindingSource.ResetBindings(false);
            };
        }
    }
}
