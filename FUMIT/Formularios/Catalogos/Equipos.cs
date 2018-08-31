using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonServiceLocator;
using FUMIT.AccesoDatos;
using FUMIT.Entidades;

namespace FUMIT.Formularios.Catalogos
{
    public partial class Equipos : Form, IFormularioSeleccionable<Entidades.Equipo>, IFormularioEditable
    {

        private bool modoEdicion = false;

        public IEquipos EquiposRepositorio { get; set; }
        public ITipoEquipos TiposEquipoRepositorio { get; set; }
        public bool ModoSeleccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Equipo SeleccionActual {
            get {
                return equipoBindingSource.Current as Equipo;
            }

        }

        public bool ModoEdicion {
            get
            {
                return modoEdicion;
            }
            set
            {
                modoEdicion = value;
                tiposEquiposComboBox.Enabled = modoEdicion;
                numeroEconomicoTextBox.ReadOnly = !modoEdicion;
                estadoComboBox.Enabled = modoEdicion;
                requiereMantenimientoCheckBox.Enabled = modoEdicion;
                enMantenimientoCheckBox.Enabled = modoEdicion;
                activoCheckBox.Enabled = modoEdicion;
                observacionesTextBox.ReadOnly = !modoEdicion;

                bindingNavigatorAddNewItem.Enabled = !modoEdicion;
                tsbEditar.Enabled = !modoEdicion;
                bindingNavigatorDeleteItem.Enabled = !modoEdicion;
                equipoBindingNavigatorSaveItem.Enabled = modoEdicion;
                tsbCancelar.Enabled = modoEdicion;
                tsbCancelar.Visible = modoEdicion;
                AgregarTipoEquipoBoton.Enabled = modoEdicion;
            }

        }

        public Equipos()
        {
            InitializeComponent();
        }

        public event EventHandler<Equipo> ItemSeleccionado;

        private void Equipos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                TiposEquipoRepositorio = ServiceLocator.Current.GetInstance<ITipoEquipos>();
                EquiposRepositorio = ServiceLocator.Current.GetInstance<IEquipos>();

                //Carga los tipos
                List<Entidades.Tipoequipo> tiposEquipos = TiposEquipoRepositorio.Recuperar().ToList();
                tiposEquiposComboBox.DataSource = tiposEquipos;
                tiposEquiposComboBox.DisplayMember = "Nombre";

                //Cargar equipos
                equipoBindingSource.DataSource = EquiposRepositorio.Recuperar();

            }
        }

        private void tiposEquiposComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionActual != null && ModoEdicion)
            {
                SeleccionActual.Tipoequipo = tiposEquiposComboBox.SelectedValue as Entidades.Tipoequipo;
                SeleccionActual.TipoEquipoId = (tiposEquiposComboBox.SelectedValue as Entidades.Tipoequipo).TipoEquipoId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formularioAgregarTipoEquipo = new Formularios.Catalogos.TiposEquipo();
            formularioAgregarTipoEquipo.Load += (sender_load, e_args) =>
            {
                formularioAgregarTipoEquipo.tipoequipoBindingSource.AddNew();
            };
            formularioAgregarTipoEquipo.ModoEditar = true;
            formularioAgregarTipoEquipo.ModoSeleccion = true;
            formularioAgregarTipoEquipo.ItemSeleccionado += (sneder_tipo, tipoequipo) =>
            {
                SeleccionActual.TipoEquipoId = tipoequipo.TipoEquipoId;
                SeleccionActual.Tipoequipo = tipoequipo;

                equipoBindingSource.ResetBindings(false);
            };

            formularioAgregarTipoEquipo.ShowDialog();
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
            try
            {
                await EquiposRepositorio.EliminarAsync(SeleccionActual);
                equipoBindingSource.RemoveCurrent();
            }catch(Exception exc)
            {
                MessageBox.Show("Hubo un error al eliminar");
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            ModoEdicion = false;
        }

        private async void equipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeleccionActual.EquipoId > 0)
                {
                    await EquiposRepositorio.ActualizarAsync(SeleccionActual);
                }
                else
                {
                    await EquiposRepositorio.CrearAsync(SeleccionActual);
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
    }
}
