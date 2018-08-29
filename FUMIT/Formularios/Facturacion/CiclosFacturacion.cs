using CommonServiceLocator;
using FUMIT.AccesoDatos;
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

namespace FUMIT.Formularios.Facturacion
{
    public partial class CiclosFacturacion : Form
    {
        protected bool modoEditar = false;
        protected bool modoSeleccionar = false;

        protected Formularios.Compartidos.BusquedaSucursal formulariobusquedaSucursal;
        public event EventHandler<Entidades.CiclosFacturacion> CicloFacturaciónSeleccionado;

        public bool ModoEditar {
            get
            {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                if (modoEditar)
                {
                    ciclosFacturacionBindingNavigatorSaveItem.Enabled = true;
                }
                else
                {
                    ciclosFacturacionBindingNavigatorSaveItem.Enabled = false;
                }
            }
        }
        public bool ModoSeleccionar { get {
                return modoSeleccionar;
            }
            set {
                modoSeleccionar = value;
                button1.Enabled = modoSeleccionar;
                button1.Visible = modoSeleccionar;
            }
        }

        public Formularios.Compartidos.BusquedaSucursal FormularioBusquedaSucursal {
            get
            {
                formulariobusquedaSucursal = formulariobusquedaSucursal ?? new Compartidos.BusquedaSucursal();
                formulariobusquedaSucursal.FormClosed += (sender, e) => formulariobusquedaSucursal = null;
                return formulariobusquedaSucursal;
            }
        }
        public Entidades.CiclosFacturacion CicloFactuacionActual
        {
            get
            {
                return (ciclosFacturacionBindingSource.Current as Entidades.CiclosFacturacion);
            }
        }
        public ICiclosFacturacion CiclosFacturacionRepositorio { get; set; }
        public IEnumerable<Entidades.CiclosFacturacion> CiclosFacturacionEnumerable { get; set; }

        public CiclosFacturacion()
        {
            InitializeComponent();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeroLabel_Click(object sender, EventArgs e)
        {

        }

        private async void ciclosFacturacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CicloFactuacionActual.CicloFacturacionId > 0)
                {
                    await CiclosFacturacionRepositorio.ActualizarAsync(CicloFactuacionActual);
                }
                else
                {
                    await CiclosFacturacionRepositorio.CrearAsync(CicloFactuacionActual);
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

        private void btnBusquedaSucursal_Click(object sender, EventArgs e)
        {
            FormularioBusquedaSucursal.SucursalSeleccionada += (object sender2, Entidades.Sucursal sucursal) =>
            {
                CicloFactuacionActual.SucursalId = sucursal.SucursalId;
                CicloFactuacionActual.Sucursal = sucursal;
                ciclosFacturacionBindingSource.ResetBindings(false);
            };

            FormularioBusquedaSucursal.ShowDialog(this);
        }

        private void CiclosFacturacion_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CiclosFacturacionRepositorio = ServiceLocator.Current.GetInstance<ICiclosFacturacion>();

                CiclosFacturacionEnumerable = CiclosFacturacionRepositorio.Recuperar();
                foreach (var i in CiclosFacturacionEnumerable)
                {
                    ciclosFacturacionBindingSource.Add(i);
                    //ciclosFacturacionBindingSource.DataSource = CiclosFacturacionEnumerable;
                }
            }
        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ModoEditar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CicloFacturaciónSeleccionado.Invoke(this, CicloFactuacionActual);

        }
    }
}
