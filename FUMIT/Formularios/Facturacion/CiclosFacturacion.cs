using CommonServiceLocator;
using FUMIT.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        protected Formularios.Compartidos.BusquedaSucursal formulariobusquedaSucursal;


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
            if(CicloFactuacionActual.CicloFacturacionId > 0)
            {
                await CiclosFacturacionRepositorio.ActualizarAsync(CicloFactuacionActual);
            }
            else
            {
                await CiclosFacturacionRepositorio.CrearAsync(CicloFactuacionActual);
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
    }
}
