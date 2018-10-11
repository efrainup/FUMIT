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
using EntLibExtensions.ExceptionHandling;

namespace FUMIT.Formularios.Operacion
{
    /// <summary>
    /// Formulario para la manipulacion de tikcets de servicio
    /// </summary>
    public partial class TicketsUC : Formularios.BaseUserControl, IFormularioEditable, IFormularioSeleccionable<Entidades.Ticket>
    {
        #region Propiedades
        private bool _modoEdicion = false;
        private Serviciosprogramado _servicioProgramadoAsociado = null;

        public event EventHandler<Ticket> ItemSeleccionado;
        public IServicio ServiciosRepositorio { get; set; }
        public IClientes ClientesRepositorio { get; set; }
        public ITickets TicketsRepositorio { get; set; }
        public IEquipos EquiposRepositorio { get; set; }
        public ITipoEquipos TiposEquiposRepositorio { get; set; }
        public IOperadores OperadoresRepositorio { get; set; }
        public ISucursales SucursalesRepositorio { get; set; }
        public List<Equipo> CatalogoEquipos { get; set; }
        public List<Operador> CatalogoOperadores { get; set; }
        public List<Cliente> CatalogoClientes { get; set; }
        public List<Servicio> CatalogoServicios { get; set; }
        public List<Ticket> TicketsCargados { get; set; }

        /// <summary>
        /// Servicio Programado al que está asociado la captura del ticket. Si se especifica, el ticket se creará con los datos del servicio.
        /// </summary>
        public Serviciosprogramado ServicioProgramadoAsociado {
            get
            {
                return _servicioProgramadoAsociado;
            }
            set
            {
                _servicioProgramadoAsociado = value;

                
            }
        }

        public bool ModoEdicion {
            get => _modoEdicion;
            set {
                _modoEdicion = value;
                bindingNavigatorAddNewItem.Enabled = !_modoEdicion;
                tsbCancelar.Visible = _modoEdicion;
                tsbCancelar.Enabled = _modoEdicion;
                tsbEditar.Enabled = !_modoEdicion;
                ticketBindingNavigatorSaveItem.Enabled = _modoEdicion;

                folioTextBox.ReadOnly = !_modoEdicion;
                fechaDateTimePicker.Enabled = _modoEdicion;
                clienteTextBox.ReadOnly = !_modoEdicion;
                contenedorTextBox.ReadOnly = !_modoEdicion;
                levantesUpDown.ReadOnly = !_modoEdicion;
                unidadTextBox.ReadOnly = !_modoEdicion;
                operadorTextBox.ReadOnly = !_modoEdicion;
                operadorTextBox.Enabled = _modoEdicion;
                observacionesTextBox.ReadOnly = !_modoEdicion;
                horaEntradaMaskedTextBox.ReadOnly = !_modoEdicion;
                horaSalidaMaskedTextBox.ReadOnly = !_modoEdicion;
                servicioTextBox.ReadOnly = !_modoEdicion;

                AgregarContenedorButton.Enabled = _modoEdicion;

            }
        }

        public bool ModoSeleccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Ticket SeleccionActual {
            get
            {
                return ticketBindingSource.Current as Ticket;
            }
        }

        BindingList<ContentedoresTicketsView<Contenedoresticket>> ContenedoresTicketBindingList { get; set; }
        #endregion

        #region Constructores
        public TicketsUC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el formulario para capturar el ticket de un servicio programado especifico
        /// </summary>
        /// <param name="ServicioProgramado">Servicio programado del cual se va a capturar el ticket</param>
        public TicketsUC(Serviciosprogramado ServicioProgramado)
        {
            ServicioProgramadoAsociado = ServicioProgramado ?? throw new ArgumentNullException("ServicioProgramado", "Se debe pasar un servicio programado no nulo");
            InitializeComponent();

            
            

        }
        #endregion

        #region Metodos
        private void CargarServicioProgramado()
        {
           

            //Buscar los tickets correspondientes al servicio programado
            TicketsCargados = TicketsRepositorio.RecuperarTicketsPorServicioProgramado(ServicioProgramadoAsociado).ToList();
            ticketBindingSource.DataSource = new BindingList<Ticket>(TicketsCargados);


            //Se agrega un nuevo elemento en el caso de que no exista
            if (contenedoresticketsBindingSource.Count == 0)
            {
                ticketBindingSource.AddNew();


                ModoEdicion = true;

                //Se pasan los datos hacia el modelo
                SeleccionActual.Fecha = ServicioProgramadoAsociado.FechaServicio.Date;
                SeleccionActual.ClienteId = ServicioProgramadoAsociado.ClienteId;
                SeleccionActual.ServicioProgramadoId = ServicioProgramadoAsociado.ServicioProgramadoId;
                SeleccionActual.ServicioId = ServicioProgramadoAsociado.ServicioId;

                //Recargar los clientes
                SeleccionActual.Clientes = ServicioProgramadoAsociado.Clientes;
                SeleccionActual.Serviciosprogramado = ServicioProgramadoAsociado;
                SeleccionActual.Servicio = ServicioProgramadoAsociado.Servicio;

                //Algunos campos del formulario se inhabilitan
                fechaDateTimePicker.Enabled = false;
                clienteTextBox.ReadOnly = true;
                servicioTextBox.ReadOnly = true;


                tsbEditar.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }

            ticketBindingSource.ResetBindings(false);

        }

        private void TicketsUC_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                EquiposRepositorio = ServiceLocator.Current.GetInstance<IEquipos>();
                OperadoresRepositorio = ServiceLocator.Current.GetInstance<IOperadores>();
                TiposEquiposRepositorio = ServiceLocator.Current.GetInstance<ITipoEquipos>();
                SucursalesRepositorio = ServiceLocator.Current.GetInstance<ISucursales>();
                TicketsRepositorio = ServiceLocator.Current.GetInstance<ITickets>();
                ClientesRepositorio = ServiceLocator.Current.GetInstance<IClientes>();
                ServiciosRepositorio = ServiceLocator.Current.GetInstance<IServicio>();

                //Se agrega el Autocomplete de contenedores
                CargarAutocompletadoCatalogoEquipos();

                //Se agrega autocompletado de operadores
                CargarAutocompletadoOperadores();

                //Se agrega autocompletado para clientes
                CargarAutocompletadoClientes();

                //Se agrega autocompletado para servicios
                CatalogoServicios = ServiciosRepositorio.Recuperar().ToList();
                AutoCompleteStringCollection autocompletadoServiciosCatalogo = new AutoCompleteStringCollection();
                autocompletadoServiciosCatalogo.AddRange(CatalogoServicios.Select(s => s.Nombre).ToArray());

                servicioTextBox.AutoCompleteCustomSource = autocompletadoServiciosCatalogo;

                //Si se especificó un servicio programado, hay que cargar
                if (_servicioProgramadoAsociado != null)
                {
                    CargarServicioProgramado();
                }
            }
        }

        private void CargarAutocompletadoClientes()
        {
            CatalogoClientes = ClientesRepositorio.Recuperar().ToList();
            AutoCompleteStringCollection autocompletadoClientes = new AutoCompleteStringCollection();
            autocompletadoClientes.AddRange(CatalogoClientes.Select(s => s.Nombre + (string.IsNullOrEmpty(s.SucursalCliente) ? "" : " - " + s.SucursalCliente)).ToArray());

            clienteTextBox.AutoCompleteCustomSource = autocompletadoClientes;
        }

        private void CargarAutocompletadoOperadores()
        {
            CatalogoOperadores = OperadoresRepositorio.Recuperar().ToList();
            AutoCompleteStringCollection catalogoAutocompletadoOperadores = new AutoCompleteStringCollection();
            catalogoAutocompletadoOperadores.AddRange(CatalogoOperadores.Select(s => s.Nombre).ToArray());

            operadorTextBox.AutoCompleteCustomSource = catalogoAutocompletadoOperadores;
        }

        private void CargarAutocompletadoCatalogoEquipos()
        {
            CatalogoEquipos = EquiposRepositorio.Recuperar().ToList();
            AutoCompleteStringCollection catalogoAutoComplete = new AutoCompleteStringCollection();
            catalogoAutoComplete.AddRange(CatalogoEquipos.Select(s => s.NumeroEconomico).ToArray());

            contenedorTextBox.AutoCompleteCustomSource = catalogoAutoComplete;
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private async void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();


            await FormExceptionManager.ProcessAsync(Exceptions.ExceptionHandlingPolicies.CrearActualizarEntidadesDesdeUI,GuardarEdicionAsync);

        }

        private async Task GuardarEdicionAsync()
        {
            Ticket ticket = SeleccionActual;
            Notificador.EnviarMensaje($"Guardando ticket de servicio {ticket.Folio}");
            if (SeleccionActual.TicketId > 0)
            {

                ticket = await TicketsRepositorio.ActualizarAsync(SeleccionActual);
            }
            else
            {
                ticket = await TicketsRepositorio.CrearAsync(SeleccionActual);

            }

            Notificador.EnviarMensaje($"Se guardó el ticket de servicio {ticket.Folio} exitosamente");
            ModoEdicion = false;
        }

        private void GuardarEdicion()
        {
            Ticket ticket = SeleccionActual;
            Notificador.EnviarMensaje($"Guardando ticket de servicio {ticket.Folio}");
            if (SeleccionActual.TicketId > 0)
            {
                ticket = TicketsRepositorio.Actualizar(SeleccionActual);
            }
            else
            {
                ticket = TicketsRepositorio.Crear(SeleccionActual);
            }

            Notificador.EnviarMensaje($"Se guardó el ticket de servicio {ticket.Folio} exitosamente");
            ModoEdicion = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ticketBindingSource.RemoveCurrent();
            ModoEdicion = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (SeleccionActual.TicketId > 0)
            {
                
            }
            else
            {
                ticketBindingSource.RemoveCurrent();
            }
            ModoEdicion = false;
        }

        private void AgregarContenedorButton_Click(object sender, EventArgs e)
        {
            Equipo equipo = contenedorTextBox.Tag as Equipo;
            string contenedor = contenedorTextBox.Text;
            int levantes = Convert.ToInt32(levantesUpDown.Value);
            
            //int indiceFila = contenedoresDataGrid.Rows.Add(contenedor, levantes);
            //contenedoresDataGrid.Rows[indiceFila]

            //Se crea un objeto para asociar con el contenedor
            var contenedorTicket = new Contenedoresticket()
            {
                Levantes = levantes,
                Equipo = equipo,
                ContenedorId = equipo.EquipoId,
            };

            SeleccionActual.Contenedorestickets.Add(contenedorTicket);
            contenedoresticketsBindingSource.Add(new ContentedoresTicketsView<Contenedoresticket>() {
                NumeroEconomico = contenedorTicket.Equipo.NumeroEconomico,
                Levantes = contenedorTicket.Levantes,
                ContenedorTicket = contenedorTicket
            });

            contenedoresticketsBindingSource.ResetBindings(false);

            contenedoresDataGrid.Refresh();
        }

        private void contenedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!contenedorTextBox.ReadOnly)
            {
                contenedorTextBox.Tag = null;
                Equipo equipo = EquiposRepositorio.RecuperarPorNumeroEconomico(contenedorTextBox.Text);
                if (equipo != null)
                {
                    contenedorTextBox.Tag = equipo;
                    return;
                }
                else
                {
                    Equipo nuevoEquipo = DialogoContenedorInexistente(contenedorTextBox.Text);

                    if(nuevoEquipo == null)
                    {
                        contenedorTextBox.Text = "";
                        contenedorTextBox.Tag = null;
                    }
                }
            }
            //contenedorTextBox.Text
        }

        private Equipo DialogoContenedorInexistente(string numeroEconomicoTextBox)
        {
            DialogResult entradaUsuario = MessageBox.Show($"El número económico {numeroEconomicoTextBox} que ingresó no existe en la base de datos de contenedores. ¿Desea agrgarlo?", "Contenedor inexistente", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            if (entradaUsuario == DialogResult.Yes)
            {
                List<Tipoequipo> tiposEquiposList = new List<Tipoequipo>();
                if (numeroEconomicoTextBox.Contains("F03") || numeroEconomicoTextBox.Contains("F3"))
                {
                    tiposEquiposList = TiposEquiposRepositorio.RecuperarPorNombre(false, "Contenedor", "3").ToList();
                }
                else if (numeroEconomicoTextBox.Contains("F06") || numeroEconomicoTextBox.Contains("F6"))
                {
                    tiposEquiposList = TiposEquiposRepositorio.RecuperarPorNombre(false, "Contenedor", "6").ToList();
                }

                if (tiposEquiposList.Count < 1)
                {
                    MessageBox.Show("No fue posible agregar el contenedor porque no se encontró una clasificación de equipo", "Agregar contenedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return null;
                }


                string numeroEconomicoEquipo = numeroEconomicoTextBox;
                Entidades.Equipo equipo = new Equipo()
                {
                    Activo = true,
                    Asignado = false,
                    Borrado = false,
                    EnMantenimiento = false,
                    Estado = "Bueno",
                    Observaciones = "",
                    NumeroEconomico = numeroEconomicoTextBox,
                    RequiereMantenimiento = false,
                    Tipoequipo = tiposEquiposList.First(),
                    TipoEquipoId = tiposEquiposList.First().TipoEquipoId
                };

                equipo = EquiposRepositorio.Crear(equipo);
                return equipo;
            }
            else
            {
                return null;
            }
        }

        private void eliminarContenedorButton_Click(object sender, EventArgs e)
        {
            FormExceptionManager.Process(() =>
            {
                // int rowIndex = contenedoresDataGrid.CurrentRow.Index;
                var element = contenedoresticketsBindingSource.Current as ContentedoresTicketsView<Contenedoresticket>;//<.ElementAt(rowIndex);
                                                                                                                       //ContenedoresTicketBindingList.RemoveAt(rowIndex);
                SeleccionActual.Contenedorestickets.Remove(element.ContenedorTicket);
                contenedoresticketsBindingSource.RemoveCurrent();
                contenedoresticketsBindingSource.ResetBindings(false);
            },FUMIT.Exceptions.ExceptionHandlingPolicies.CrearActualizarEntidadesDesdeUI);
        }

        private void operadorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!operadorTextBox.ReadOnly)
            {
                operadorTextBox.Tag = null;
                Operador operador = CatalogoOperadores.FirstOrDefault(f => f.Nombre.Contains(operadorTextBox.Text));

                
                if (operador == null)
                {
                    operador = new Operador()
                    {
                        Nombre = operadorTextBox.Text,
                        Activo = true,
                        Borrado = false,
                        SucursalId = 1
                    };
                }

                SeleccionActual.Operador = operador;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.F2 && !ModoEdicion)
            {
                ModoEdicion = true;
                return false;
            }
            else if (keyData ==( Keys.Control | Keys.N) && !ModoEdicion)
            {
                ModoEdicion = true;
                ticketBindingSource.AddNew();
                return false;
            }
            else if (keyData == (Keys.Escape) && ModoEdicion)
            {
                ModoEdicion = false;
                CancelarEdicion();
                return false;
            }
            else if (keyData == (Keys.Control | Keys.G) && ModoEdicion)
            {
                GuardarEdicionAsync();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CancelarEdicion()
        {
            ModoEdicion = false;
            if (SeleccionActual.TicketId == 0)
            {
                ticketBindingSource.RemoveCurrent();
            }
            else
            {
                ticketBindingSource.ResetCurrentItem();
            }
        }

        private void clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!clienteTextBox.ReadOnly)
            {
                if (!string.IsNullOrEmpty(clienteTextBox.Text))
                {
                    clienteTextBox.Tag = null;
                    Cliente cliente = CatalogoClientes.FirstOrDefault(f => f.Nombre + (string.IsNullOrEmpty(f.SucursalCliente) ? "" : " - " + f.SucursalCliente) == clienteTextBox.Text);

                    if (cliente == null)
                    {
                        DialogResult entradaUsuario = MessageBox.Show("El cliente que seleccionó no existe en la base de datos. Agregue primero los datos del cliente o revise si el cliente ingresado es correcto. ¿Desea agregar un nuevo cliente?", "Cliente inexistente", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        if (entradaUsuario == DialogResult.Yes)
                        {
                            var form = new Formularios.Clientes.Expedientes();
                            form.Show();
                        }
                        else
                        {
                            clienteTextBox.Text = "";
                        }

                        return;
                    }
                    SeleccionActual.Clientes = cliente;
                    SeleccionActual.ClienteId = cliente.ClienteId;
                }
                else
                {
                    
                    //errorProvider1.SetError(clienteTextBox, "El campo cliente es requerido");
                }
            }
        }

        private void servicioTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!servicioTextBox.ReadOnly)
            {
                if (!string.IsNullOrEmpty(servicioTextBox.Text))
                {
                    servicioTextBox.Tag = null;
                    Servicio servicio = CatalogoServicios.FirstOrDefault(f => f.Nombre.Contains(servicioTextBox.Text));

                    if (servicio == null)
                    {
                        DialogResult entradaUsuario = MessageBox.Show("El servicio que seleccionó no existe en la base de datos. Revise si el servicio ingresado es correcto.", "Servicio inexistente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        servicioTextBox.Text = "";
                        return;
                    }
                    SeleccionActual.Servicio = servicio;
                    SeleccionActual.ServicioId = servicio.ServicioId;
                }
                else
                {

                    //errorProvider1.SetError(clienteTextBox, "El campo cliente es requerido");
                }
            }
        }

        private void contenedoresDataGrid_Validating(object sender, CancelEventArgs e)
        {
            //(sender as DataGrid).VisibleRowCount > 0
        }

        private void fechaDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            //Se establece la fecha sin hora
            fechaDateTimePicker.Value = fechaDateTimePicker.Value.Date;
        }
        #endregion

        private void ticketBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            //BindingList<Contenedoresticket> contenedorestickets = new BindingList<Contenedoresticket>(SeleccionActual.Contenedorestickets);
        }

        private void ticketBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded)
            {
                
                contenedoresticketsBindingSource.DataSource = Convertir(SeleccionActual.Contenedorestickets);
                
            }
            
        }

        static IEnumerable<ContentedoresTicketsView<Contenedoresticket>> Convertir(IEnumerable<Contenedoresticket> ctickets)
        {
            List<ContentedoresTicketsView<Contenedoresticket>> contenedoresTicketList = new List<ContentedoresTicketsView<Contenedoresticket>>();

            foreach(Contenedoresticket cticket in ctickets)
            {
                contenedoresTicketList.Add(new ContentedoresTicketsView<Contenedoresticket>()
                {
                    NumeroEconomico = cticket.Equipo.NumeroEconomico,
                     Levantes=cticket.Levantes,
                     ContenedorTicket = cticket
                });
            }

            return contenedoresTicketList;
        }

        private void contenedoresticketsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            
        }
    }

    class ContentedoresTicketsView<T>
    {
        public string NumeroEconomico { get; set; }
        public int Levantes { get; set; }
        public T ContenedorTicket { get; set; }
    }
}
