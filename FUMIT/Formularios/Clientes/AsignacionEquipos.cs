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

namespace FUMIT.Formularios.Clientes
{
    public partial class AsignacionEquipos : UserControl, IFormularioEditable, IFormularioSeleccionable<Entidades.Asignacionesequipo>
    {
        private bool modoEdicion = false;
        private int clienteId = 0;


        public AsignacionEquipos()
        {
            InitializeComponent();
        }

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
                tsbEditar.Enabled = !modoEdicion;
                 bindingNavigatorAddNewItem.Enabled = !modoEdicion;
                 bindingNavigatorDeleteItem.Enabled = !modoEdicion;
                asignacionesequipoBindingNavigatorSaveItem.Enabled = modoEdicion;

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

        IEnumerable<Entidades.Equipo> equipos;

        public event EventHandler<Asignacionesequipo> ItemSeleccionado;

        private void AsignacionEquipos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                AsignacionesEquipoRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<AccesoDatos.IAsignacionesEquipo>();
                EquiposRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<AccesoDatos.IEquipos>();

                //Autocomplete 

                CargarAutocompletadoEquipos();

            }
        }

        private void CargarAutocompletadoEquipos()
        {
            equipos = EquiposRepositorio.RecuperarEquiposDisponiblesParaAsignacion();

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
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private async void asignacionesequipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
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

                    //Se refrescan los equipos disponibles para asignar
                    CargarAutocompletadoEquipos();
                }

                ModoEdicion = false;
            }
            catch (DbEntityValidationException excepcionValidacion)
            {
                string Mensaje = "";
                foreach (DbEntityValidationResult validacion in excepcionValidacion.EntityValidationErrors)
                {

                    foreach (DbValidationError errorvalidacion in validacion.ValidationErrors)
                    {
                        Mensaje += $"•{errorvalidacion.ErrorMessage}";
                        //this.Controls[0].DataBindings.Add()
                    }

                }
                MessageBox.Show(Mensaje, "Errores de validacion");

            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Se produjo un error. Favor de intentar nuevamente", "Error");
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            ModoEdicion = false;
        }

        private void numeroEconomicoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string numeroEconomico = numeroEconomicoTextBox.Text;

            Equipo equipoSeleccionado = equipos.FirstOrDefault(f => f.NumeroEconomico == numeroEconomico);

            SeleccionActual.EquipoId = equipoSeleccionado.EquipoId;
            SeleccionActual.Equipo = equipoSeleccionado;

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
    }
}
