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
using CommonServiceLocator;
using FUMIT.Entidades;

namespace FUMIT.Formularios.Compartidos
{
    public partial class BusquedaSucursal : Form
    {
        ISucursales SucursalesRepositorio;
        IEnumerable<Entidades.Sucursal> Sucursales;

        public event EventHandler<Entidades.Sucursal> SucursalSeleccionada;

        public BusquedaSucursal()
        {
            InitializeComponent();
        }

        private void BusquedaSucursal_Load(object sender, EventArgs e)
        {
            //SucursalesRepositorio = ServiceLocator.Current.GetInstance<ISucursales>();

            SucursalesRepositorio = ServiceLocator.Current.GetInstance<ISucursales>();

            if (!DesignMode)
            {
                Sucursales = SucursalesRepositorio.Recuperar();
                foreach (Sucursal sucursal in Sucursales)
                {
                    sucursalBindingSource.Add(sucursal);
                }

                sucursalDataGridView.Refresh();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {

            Sucursal sucursal = sucursalDataGridView.SelectedRows[0].DataBoundItem as Sucursal;
            SucursalSeleccionada(this, sucursal);
            Close();
        }
    }
}
