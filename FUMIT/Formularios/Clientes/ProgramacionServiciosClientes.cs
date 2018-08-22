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

            DateTime fechaActual = ProgramacionServicioClienteActual.FechaInicio;
            int[] ds = ProgramacionServicioClienteActual.Programacionservicio.Dias.Split(',').Select(s => Convert.ToInt32(s.Replace("7", "0"))).ToArray();

            //El conteo siempre comeinza a partir del proximo lunes.

            //Si hay dias especificados, sin semanas ni meses, entonces el ciclo se repite cada x dias
            //Ej. D=15,S=0,M=0 el ciclo se repite cada 15 dias.

            //Si hay varios dias especificados, sin semanas ni meses, entonces el ciclo se repite cada x dias
            //Ej. D=7,15 ,S=0,M=0 el ciclo se repite cada 15 dias (Se toma el último).

            //Si hay semanas especificadas, entonces el ciclo se repite cada x semanas * 7

            //Si hay meses especificados, entonces el ciclo se repite cada cambio de mes

            int dia = 1;
            int mes = 1;
            int diasCiclo = 0;
            int mesCiclo = 0;
            bool cambioDeMes = false;

            int i = 0;
            if (fechaActual.DayOfWeek != DayOfWeek.Monday)
            {
                while (fechaActual.AddDays(i).DayOfWeek != DayOfWeek.Monday)
                {
                    i++;
                };

                dia = dia - i;
            }

            if (!ProgramacionServicioClienteActual.Programacionservicio.Semana.HasValue || ProgramacionServicioClienteActual.Programacionservicio.Semana.Value == 0)
            {
                diasCiclo = ds.Max();
            }
            else
            {
                diasCiclo = ProgramacionServicioClienteActual.Programacionservicio.Semana.Value * 7;
            }

            cambioDeMes = ProgramacionServicioClienteActual.Programacionservicio.Mes.HasValue && ProgramacionServicioClienteActual.Programacionservicio.Mes.Value > 0;


            while (fechaActual <= ProgramacionServicioClienteActual.FechaTermino)
            {
                
                if (ds.Any(a => a==dia))
                {
                    

                    Entidades.Serviciosprogramado servicio = new Serviciosprogramado()
                    {
                        ServicioProgramadoId = 0,
                        ClienteId = ProgramacionServicioClienteActual.ClienteId,
                        Cancelado = false,
                        Tipo = "Programado",
                        ServicioId = ProgramacionServicioClienteActual.ServicioId,
                        FechaServicio = fechaActual,
                        Servicio = ProgramacionServicioClienteActual.Servicio,
                        Clientes = ProgramacionServicioClienteActual.Clientes
                    };


                    await serviciosProgramados.CrearAsync(servicio);
                }

                //Se agrega un dia a la fecha actual.
                //El contador de días se reinicia si se alcanza el ciclo de días o de mes
                dia++;
                if (cambioDeMes)
                {
                    if (fechaActual.AddDays(1).Month != fechaActual.Month)
                    {
                        mes++;
                    }
                    if(mes > mesCiclo)
                    {
                        mes = 1;
                        dia = 1;
                    }

                }else if(dia > diasCiclo)
                {
                    dia = 1;
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
