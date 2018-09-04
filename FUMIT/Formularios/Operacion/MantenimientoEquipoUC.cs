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

namespace FUMIT.Formularios.Operacion
{
    
    public partial class MantenimientoEquipoUC : BaseUserControl, IFormularioEditable, IFormularioSeleccionable<Entidades.Mantenimiento>
    {
        #region Propiedades

        private int equipoId;
        private bool modoEdicion = false;
        private Equipo equipoSeleccionado;

        public IEnumerable<Equipo> ListaEquipos { get; set; }
        public IEquipos EquiposRepositorioLocal { get; set; }
        public IMantenimientos MantenimientosRepositorioLocal { get; set; }
        public bool ModoEdicion {
            get
            {
                return modoEdicion;
            }
            set
            {
                modoEdicion = value;
                bindingNavigatorAddNewItem.Enabled = !modoEdicion;
                tsbEditar.Enabled = !modoEdicion;
                bindingNavigatorDeleteItem.Enabled = !modoEdicion;
                tsbCancelar.Visible = modoEdicion;
                tsbCancelar.Enabled = modoEdicion;
                mantenimientoBindingNavigatorSaveItem.Enabled = modoEdicion;

                numeroEconomicoTextBox.ReadOnly = !modoEdicion;
                fechaEntradaMantenimientoDateTimePicker.Enabled = modoEdicion;
                fechaProgramadaDateTimePicker.Enabled = modoEdicion;
                fechaSalidaMantenimientoDateTimePicker.Enabled = modoEdicion;
                observacionesTextBox.ReadOnly = !modoEdicion;
                realizadoCheckBox.Enabled = modoEdicion;
                activoCheckBox.Enabled = modoEdicion;
            }

        }
        public bool ModoSeleccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public Mantenimiento SeleccionActual => mantenimientoBindingSource.Current as Entidades.Mantenimiento;
        public int EquipoId {
            get
            {
                return equipoId;
            }
            set
            {
                equipoId = value;


                if (EquiposRepositorioLocal != null)
                {
                    EquipoSeleccionado = EquiposRepositorioLocal.RecuperarPorId(equipoId);
                }


                //Al modificar el equipo seleccionado traer los datos correspondientes del equipo, 
                //solo en caso de que no se pueda seleccionar el número económico.
                if (!EquipoSeleccionable && MantenimientosRepositorioLocal != null)
                {
                    IEnumerable<Mantenimiento> mantenimientos = MantenimientosRepositorioLocal.RecuperarPorEquipo(EquipoSeleccionado);
                    BindingList<Mantenimiento> bindingList = new BindingList<Mantenimiento>(mantenimientos.ToList());
                    mantenimientoBindingSource.DataSource = bindingList;
                    mantenimientosEquipoBindingSource.DataSource = new Entidades.MantenimientosEquipo()
                    {
                        Equipo = EquipoSeleccionado
                    };
                    mantenimientosEquipoBindingSource.ResetBindings(false);
                }
            }
        }
        public Equipo EquipoSeleccionado {
            get
            {
                return equipoSeleccionado;
            }
            set
            {
                equipoSeleccionado = value;

            }

        }

        [DefaultValue(true)]
        public bool EquipoSeleccionable { get; set; }
        #endregion


        public MantenimientoEquipoUC()
        {
            InitializeComponent();
        }

        public event EventHandler<Mantenimiento> ItemSeleccionado;

        private void MantenimientoEquipoUC_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                MantenimientosRepositorioLocal = CommonServiceLocator.ServiceLocator.Current.GetInstance<IMantenimientos>();
                EquiposRepositorioLocal = CommonServiceLocator.ServiceLocator.Current.GetInstance<IEquipos>();

                //Carga de Mantenimientos
                if (EquipoSeleccionable)
                {
                    IEnumerable<Mantenimiento> mantenimientos = MantenimientosRepositorioLocal.Recuperar();
                    BindingList<Mantenimiento> bindingList = new BindingList<Mantenimiento>(mantenimientos.ToList());
                    mantenimientoBindingSource.DataSource = bindingList;
                }

                //Cargar equipos en el autocomplete
                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                ListaEquipos = EquiposRepositorioLocal.Recuperar().ToList();
                autoComplete.AddRange(ListaEquipos.Select(s => s.NumeroEconomico).ToArray());

                numeroEconomicoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private async void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            await FormExceptionManager.Process(async () =>
            {
                await MantenimientosRepositorioLocal.EliminarAsync(SeleccionActual);
            }, Exceptions.ExceptionHandlingPolicies.CrearActualizarEntidadesDesdeUI);
        }

        private async void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            await FormExceptionManager.Process(async () =>
            {
                if (SeleccionActual.MantenimientoId > 0)
                {
                    await MantenimientosRepositorioLocal.ActualizarAsync(SeleccionActual);
                }
                else
                {
                    await MantenimientosRepositorioLocal.CrearMantenimientoDeEquipoAsync(SeleccionActual, numeroEconomicoTextBox.Text);

                }
                ModoEdicion = false;
            }, Exceptions.ExceptionHandlingPolicies.CrearActualizarEntidadesDesdeUI);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (SeleccionActual.MantenimientoId > 0)
            {
                mantenimientoBindingSource.ResetCurrentItem();
            }
            else
            {
                mantenimientoBindingSource.RemoveCurrent();
            }
            ModoEdicion = false;
        }

        private void numeroEconomicoTextBox_Validated(object sender, EventArgs e)
        {
            
            EquipoSeleccionado = ListaEquipos.FirstOrDefault(f => f.NumeroEconomico == numeroEconomicoTextBox.Text);
        }
    }
}
