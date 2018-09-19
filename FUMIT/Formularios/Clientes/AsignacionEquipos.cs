using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FUMIT.Entidades;
using System.Data.Entity.Validation;
using CommonServiceLocator;
using EntLibExtensions.ExceptionHandling;

namespace FUMIT.Formularios.Clientes
{
    public partial class AsignacionEquipos : BaseUserControl, IFormularioEditable, IFormularioSeleccionable<Entidades.Asignacionesequipo>
    {


        public AsignacionEquipos()
        {
            InitializeComponent();
        }

        #region Propiedades
        private bool modoEdicion = false;
        private int clienteId = 0;
        Entidades.Asignacionesequipo asignacionesequipoActual;

        public bool ModoEdicion {
            get
            {
                return modoEdicion;
            }
            set
            {
                modoEdicion = value;
                tsbCancelar.Visible = modoEdicion;
                tsbCancelar.Enabled = modoEdicion;
                if (asignacionesequipoBindingSource != null)
                {
                    tsbEditar.Enabled = !modoEdicion && asignacionesequipoBindingSource.Count > 0;
                }
                else
                {
                    tsbEditar.Enabled = !modoEdicion;
                }

                bindingNavigatorAddNewItem.Enabled = !modoEdicion;
                bindingNavigatorDeleteItem.Enabled = !modoEdicion;
                asignacionesequipoBindingNavigatorSaveItem.Enabled = modoEdicion;

                ubicacionTextBox.ReadOnly = !modoEdicion;
                numeroEconomicoTextBox.ReadOnly = !modoEdicion;
                fechaAsignaciónDateTimePicker.Enabled = modoEdicion;
                fechaEntregaDateTimePicker.Enabled = modoEdicion;
                fechaRegresoDateTimePicker.Enabled = modoEdicion;

            }
        }
        public AccesoDatos.IAsignacionesEquipo AsignacionesEquipoRepositorio { get; set; }
        public AccesoDatos.IEquipos EquiposRepositorio{ get; set; }
        public bool ModoSeleccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ClienteId {
            get {
                return clienteId;
            }
            set
            {
                clienteId = value;

                if(AsignacionesEquipoRepositorio != null)
                {
                    CargarAsignacionesPorCliente();
                }


            }
        }
        public Asignacionesequipo SeleccionActual => asignacionesequipoBindingSource.Current as Asignacionesequipo;
        List<Entidades.Equipo> equipos;
        public AccesoDatos.ITipoEquipos TiposEquiposRepositorio { get; set; }
        #endregion


        public event EventHandler<Asignacionesequipo> ItemSeleccionado;

        private void AsignacionEquipos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                AsignacionesEquipoRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<AccesoDatos.IAsignacionesEquipo>();
                EquiposRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<AccesoDatos.IEquipos>();
                TiposEquiposRepositorio = ServiceLocator.Current.GetInstance<AccesoDatos.ITipoEquipos>();
                //Autocomplete 

                CargarAutocompletadoEquipos();

            }
        }

        private void CargarAutocompletadoEquipos()
        {
            equipos = EquiposRepositorio.RecuperarEquiposDisponiblesParaAsignacion().ToList();

            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            coll.AddRange(equipos.Select(s => s.NumeroEconomico).ToArray());

            numeroEconomicoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            numeroEconomicoTextBox.AutoCompleteCustomSource = coll;
        }

        private void CargarAsignacionesPorCliente()
        {
            IEnumerable<Asignacionesequipo> asignacionesequipos = AsignacionesEquipoRepositorio.RecuperarEquiposPorCliente(ClienteId);
            BindingList<Entidades.Asignacionesequipo> bindingList = new BindingList<Asignacionesequipo>(asignacionesequipos.ToList());
            asignacionesequipoBindingSource.DataSource = bindingList;

            //Checar si 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            //No se puede editar 
            ModoEdicion = true;
        }

        private async void asignacionesequipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            await FormExceptionManager.ProcessAsync(Exceptions.ExceptionHandlingPolicies.CrearActualizarEntidadesDesdeUI ,async () =>
            {
                    SeleccionActual.ClienteId = ClienteId;
                    SeleccionActual.Clientes = new AccesoDatos.ClientesRepositorio().RecuperarPorId(ClienteId);

                    if (SeleccionActual.AsignacionEquipoId > 0)
                    {
                        await AsignacionesEquipoRepositorio.ActualizarAsync(SeleccionActual);
                    }
                    else
                    {
                        await AsignacionesEquipoRepositorio.CrearAsync(SeleccionActual);
                    }

                    //Se refrescan los equipos disponibles para asignar
                    CargarAutocompletadoEquipos();

                    ModoEdicion = false;
                
            });
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (SeleccionActual.AsignacionEquipoId <= 0)
            {
                asignacionesequipoBindingSource.RemoveCurrent();
            }
            ModoEdicion = false;
        }

        //No puede ser async porque hay otros métodos que lo llaman indirectamente
        private void numeroEconomicoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if((sender as TextBox).ReadOnly)
            {
                return;
            }

            string numeroEconomico = numeroEconomicoTextBox.Text;
            
            //Efrain Hernandez 19/09/2018: Se modificó porque se enecesita saber si el contenedor está en el catálogo. Y no si está en el catalogo de disponibles.
            Equipo equipoSeleccionado = EquiposRepositorio.RecuperarPorNumeroEconomico(numeroEconomico);

            if (equipoSeleccionado != null)
            {
                SeleccionActual.EquipoId = equipoSeleccionado.EquipoId;
                SeleccionActual.Equipo = equipoSeleccionado; //Se tiene que asignar el equipo por que sino el equipo actual sufre cambios en el número económico y se actualiza en la base de datos
                asignacionesequipoBindingSource.ResetBindings(false);
            }
            else
            {
                DialogoContenedorInexistente();
                return;

            }

        }

        private void DialogoContenedorInexistente()
        {
            DialogResult entradaUsuario = MessageBox.Show($"El número económico {numeroEconomicoTextBox.Text} que ingresó no existe en la base de datos de contenedores. ¿Desea agrgarlo?", "Contenedor inexistente", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            if (entradaUsuario == DialogResult.Yes)
            {
                List<Tipoequipo> tiposEquiposList = new List<Tipoequipo>();
                if (numeroEconomicoTextBox.Text.Contains("F03") || numeroEconomicoTextBox.Text.Contains("F3"))
                {
                    tiposEquiposList = TiposEquiposRepositorio.RecuperarPorNombre(false, "Contenedor", "3").ToList();
                }
                else if (numeroEconomicoTextBox.Text.Contains("F06") || numeroEconomicoTextBox.Text.Contains("F6"))
                {
                    tiposEquiposList = TiposEquiposRepositorio.RecuperarPorNombre(false, "Contenedor", "6").ToList();
                }

                if (tiposEquiposList.Count < 1)
                {
                    MessageBox.Show("No fue posible agregar el contenedor porque no se encontró una clasificación de equipo", "Agregar contenedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }


                string numeroEconomicoEquipo = numeroEconomicoTextBox.Text;
                Entidades.Equipo equipo = new Equipo()
                {
                    Activo = true,
                    Asignado = false,
                    Borrado = false,
                    EnMantenimiento = false,
                    Estado = "Bueno",
                    Observaciones = "",
                    NumeroEconomico = numeroEconomicoTextBox.Text,
                    RequiereMantenimiento = false,
                    Tipoequipo = tiposEquiposList.First(),
                    TipoEquipoId = tiposEquiposList.First().TipoEquipoId
                };

                equipo = EquiposRepositorio.Crear(equipo);
                equipos.Add(equipo);

                SeleccionActual.EquipoId = equipo.EquipoId;
                //SeleccionActual.Equipo = equipo;
            }
            else if (entradaUsuario == DialogResult.No)
            {
                numeroEconomicoTextBox.Text = "";
            }
            return;
        }

        private async void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                await AsignacionesEquipoRepositorio.EliminarAsync(SeleccionActual);
                asignacionesequipoBindingSource.RemoveCurrent();

                CargarAutocompletadoEquipos();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hubo un error al eliminar la asignacion");
            }
        }

        private void asignacionesequipoBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //Cuando la lista no contiene elementos no se debe poder editar
            //Se dispara el evento cuando se inicializa la lista, se agrega o se borran elementos
            if(e.ListChangedType == ListChangedType.PropertyDescriptorChanged  || e.ListChangedType== ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                tsbEditar.Enabled = !ModoEdicion && (sender as BindingSource).Count > 0;
            }
        }
    }
}
