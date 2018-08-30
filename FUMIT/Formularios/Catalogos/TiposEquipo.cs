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
    public partial class TiposEquipo : Form, IFormularioSeleccionable<Entidades.Tipoequipo>
    {
        private bool modoEditar = false;
        private bool modoSeleccion = false;

        public AccesoDatos.ITipoEquipos TipoEquiposRepositorio { get; set; }
        public Entidades.Tipoequipo TipoEquipoActual {
            get {
                return tipoequipoBindingSource.Current as Entidades.Tipoequipo;
            }
        }
        public bool ModoEditar {
            get {

                return modoEditar;
            }
            set
            {
                modoEditar = value;
                bindingNavigatorAddNewItem.Enabled = !modoEditar;
                tsbEditarButton.Enabled = !modoEditar;
                bindingNavigatorDeleteItem.Enabled = !modoEditar;
                tsbCancelar.Visible = modoEditar;
                tsbCancelar.Enabled = modoEditar;
                tipoequipoBindingNavigatorSaveItem.Enabled = modoEditar;
            }

        }
        public bool ModoSeleccion {
            get
            {
                return modoSeleccion;
            }
            set
            {
                modoSeleccion = value;
                BotonSeleccionar.Visible = modoSeleccion;
            }
        }

        public Tipoequipo SeleccionActual {
            get
            {
                return tipoequipoBindingSource.Current as Tipoequipo;
            }
        }

        #region Eventos
        public event EventHandler<Entidades.Tipoequipo> TipoEquipoSeleccionado;
        public event EventHandler<Tipoequipo> ItemSeleccionado;
        #endregion


        public TiposEquipo()
        {
            InitializeComponent();
        }

        private async void tipoequipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoEquipoActual.TipoEquipoId > 0)
                {
                    await TipoEquiposRepositorio.ActualizarAsync(TipoEquipoActual);
                }
                else
                {
                    await TipoEquiposRepositorio.CrearAsync(TipoEquipoActual);
                }
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private void tsbEditarButton_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private async void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            await TipoEquiposRepositorio.EliminarAsync(TipoEquipoActual);
            tipoequipoBindingSource.RemoveCurrent();


            ModoEditar = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if(TipoEquipoActual.TipoEquipoId > 0)
            {
                tipoequipoBindingSource.ResetCurrentItem();
            }
            else
            {
                tipoequipoBindingSource.ResetAllowNew();
            }

            ModoEditar = false;
        }

        private void BotonSeleccionar_Click(object sender, EventArgs e)
        {
            if(ItemSeleccionado != null)
            {
                ItemSeleccionado.Invoke(this, SeleccionActual);
            }
        }

        private void TiposEquipo_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                TipoEquiposRepositorio = ServiceLocator.Current.GetInstance<ITipoEquipos>();
                tipoequipoBindingSource.DataSource = TipoEquiposRepositorio.Recuperar();
            }
        }
    }
}
