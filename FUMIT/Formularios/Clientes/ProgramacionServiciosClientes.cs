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
            IVSProgramacionServiciosCliente vsp = new VSProgramacionServiciosClienteRepositorio();
            //foreach (Programacionservicioscliente programacionObjeto in programacion)
            //{
            //    programacionserviciosclienteBindingSource.Add(programacionObjeto);
            //}
            programacionserviciosclienteBindingSource.DataSource = new BindingList<Programacionservicioscliente>(programacion.ToList());


            if (programacionserviciosclienteBindingSource.Count > 0)
            {
                btnBusquedaProgramacionServicioPorId.Enabled = true;
                btnBusquedaProgramacionServicioPorNombre.Enabled = true;
            }


            vsprogramacionserviciosclienteBindingSource.DataSource = vsp.Recuperar();
        }

        private void ProgramacionServiciosClientes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ProgramacionServiciosClienteRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<IProgramacionServiciosCliente>();

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnBusquedaProgramacionServicioPorId.Enabled = true;
            btnBusquedaProgramacionServicioPorNombre.Enabled = true;
            programacionserviciosclienteBindingNavigatorSaveItem.Enabled = true;

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

            DateTime fechaActual = ProgramacionServicioClienteActual.FechaInicio;
            int[] ds = ProgramacionServicioClienteActual.Programacionservicio.Dias.Split(',').Select(s => Convert.ToInt32(s.Replace("7", "0"))).ToArray();


            while (fechaActual <= ProgramacionServicioClienteActual.FechaTermino)
            {
                if (ds.Any(a => ((int)fechaActual.DayOfWeek).CompareTo(a) == 0))
                {
                    

                    Entidades.Serviciosprogramado servicio = new Serviciosprogramado()
                    {
                        ServicioProgramadoId = 0,
                        ClienteId = ProgramacionServicioClienteActual.ClienteId,
                        Cancelado = false,
                        Tipo = "Programado",
                        ServicioId = ProgramacionServicioClienteActual.ProgramacionServicioId,
                        FechaServicio = fechaActual,
                        Servicio = (new ServiciosRepositorio()).Recuperar().ToArray()[0],
                        Clientes = ProgramacionServicioClienteActual.Clientes
                    };


                    await serviciosProgramados.CrearAsync(servicio);
                }

                fechaActual = fechaActual.AddDays(1);
            }


        }

        private void vsprogramacionserviciosclienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            programacionserviciosclienteBindingSource.Position = vsprogramacionserviciosclienteBindingSource.Position;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
