using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT.Formularios.Clientes
{
    public partial class CicloFacturacionClientes : UserControl
    {
        private bool modoEditar = false;
        public bool ModoEditar {
            get
            {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                btnBusquedaCiclos.Enabled = modoEditar;
                cicloFacturacionClienteBindingNavigatorSaveItem.Enabled = modoEditar;
               
            }
        }
        public Entidades.CicloFacturacionCliente Actual {
            get {
                return cicloFacturacionClienteBindingSource.Current as Entidades.CicloFacturacionCliente; 
            }
        }
        AccesoDatos.ICicloFacturacionClientes Repositorio { get; set; }

        public CicloFacturacionClientes()
        {
            InitializeComponent();
        }

        private void btnBusquedaCiclos_Click(object sender, EventArgs e)
        {
            var formulario = new Formularios.Facturacion.CiclosFacturacion();
            formulario.ModoSeleccionar = true;
            formulario.CicloFacturaciónSeleccionado += (sender2, ciclo) => {
                Actual.CicloFacturacionId = ciclo.CicloFacturacionId;
                Actual.CiclosFacturacion = ciclo;
                cicloFacturacionClienteBindingSource.ResetBindings(false);
            };
            formulario.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private async void cicloFacturacionClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (Actual.CicloFacturacionClienteId > 0)
            {
                await Repositorio.ActualizarAsync(Actual);
            }
            else
            {
                await Repositorio.CrearAsync(Actual);
            }

            ModoEditar = false;
        }

        private void CicloFacturacionClientes_Load(object sender, EventArgs e)
        {
            if (!DesignMode) {
                Repositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<AccesoDatos.ICicloFacturacionClientes>();
            }
        }
    }
}
