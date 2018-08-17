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
using FUMIT.Utils;

namespace FUMIT.Formularios.Catalogos
{
    public partial class Sucursales : Form, IModosEdicion
    {
        protected bool modoEditar = false;
        protected bool modoAgregar = false;


        [DefaultValue(false)]
        public bool CambiosPendientes { get; set; }
        public ISucursales DatosSucursales { get; set; }
        public bool ModoEditar
        {
            get
            {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                if (value)
                {
                    EntrarModoEdicion();
                }
                else
                {
                    SalirModoEdicion();
                }
            }
        }
        public bool ModoAgregar { get
            {
                return modoAgregar;
            }
            set {
                modoAgregar = value;
                if (value)
                {
                    EntrarModoEdicion();
                }
                else
                {
                    SalirModoEdicion();
                }
            }
        }

        public Sucursales()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
            {

            }
            else
            {
                //TODO: Implementar inyeccion de dependencias
                DatosSucursales = new SucursalesRepositorio();
                IEnumerable<Entidades.Sucursal> coleccionSucursales = DatosSucursales.Recuperar();
                foreach (Entidades.Sucursal sucursal in coleccionSucursales)
                {
                    ListaSucursales.Rows.Add(new object[] { sucursal.SucursalId, sucursal.Numero, sucursal.Nombre, sucursal.Estado, sucursal.Ciudad, sucursal.Direccion, sucursal.Activo });
                }
            }
        }

        private void CargarSucursales()
        {
            IEnumerable<Entidades.Sucursal> coleccionSucursales = DatosSucursales.Recuperar();
            ListaSucursales.Rows.Clear();
            foreach (Entidades.Sucursal sucursal in coleccionSucursales)
            {
                ListaSucursales.Rows.Add(new object[] { sucursal.SucursalId, sucursal.Numero, sucursal.Nombre, sucursal.Estado, sucursal.Ciudad, sucursal.Direccion, sucursal.Activo });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
        }

        private void ListaSucursales_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            CambiosPendientes = true;
        }

        private void ListaSucursales_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CambiosPendientes = true;
        }

        private void ListaSucursales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CambiosPendientes = true;
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            ModoAgregar = true;

            int rowId = ListaSucursales.Rows.Add();

            ListaSucursales.ReadOnly = false;
            ListaSucursales.Rows[rowId].Selected = true;
            ListaSucursales.Rows[rowId].ReadOnly = false;


            ListaSucursales.BeginEdit(true);
        }

        private async void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            
            Entidades.Sucursal nuevaSucursal = new Entidades.Sucursal();

            nuevaSucursal.SucursalId = Convert.ToInt32(lblIdSucursal.Text);
            nuevaSucursal.Numero = txtNumero.Text;
            nuevaSucursal.Nombre = txtNombre.Text;
            nuevaSucursal.Ciudad = txtCiudad.Text;
            nuevaSucursal.Estado = txtEstado.Text;
            nuevaSucursal.Direccion = txtDireccion.Text;
            nuevaSucursal.Activo = chkActivo.Checked;

            if (ModoAgregar)
            {
                await DatosSucursales.CrearAsync(nuevaSucursal);
            }
            else if (ModoEditar)
            {
                await DatosSucursales.ActualizarAsync(nuevaSucursal);
            }
            CargarSucursales();

            ModoAgregar = false;
            ModoEditar = false;
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            if (ModoAgregar)
            {
                LimpiarCampos();
            }

            ModoEditar = false;
            ModoAgregar = false;
        }

        private void LimpiarCampos()
        {
            txtNumero.Text = "";
            txtNombre.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            txtDireccion.Text = "";
            chkActivo.Checked = false;

            lblIdSucursal.Text = "0";

            ListaSucursales_SelectionChanged(ListaSucursales, null);
        }

        private void btnEditarSucursal_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
            EntrarModoEdicion();
        }

        public void EntrarModoEdicion()
        {
            btnAgregarSucursal.Enabled = false;
            btnEditarSucursal.Enabled = false;
            btnAceptarAgregar.Enabled = true;
            btnAceptarAgregar.Visible = true;
            btnCancelarEdicion.Visible = true;
            btnCancelarEdicion.Enabled = true;
            txtNumero.Enabled = true;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtEstado.Enabled = true;
            txtCiudad.Enabled = true;
            chkActivo.Enabled = true;
            ListaSucursales.Enabled = false;
        }

        public void SalirModoEdicion()
        {
            btnAceptarAgregar.Enabled = false;
            btnAceptarAgregar.Visible = false;
            btnCancelarEdicion.Visible = false;
            btnCancelarEdicion.Enabled = false;
            btnEditarSucursal.Enabled = true;
            btnAgregarSucursal.Enabled = true;
            txtDireccion.Enabled = false;
            txtEstado.Enabled = false;
            txtCiudad.Enabled = false;
            chkActivo.Enabled = false;
            ListaSucursales.Enabled = true;
        }

        private void ListaSucursales_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView senderGridView = sender as DataGridView;

            if (senderGridView.SelectedRows.Count > 0 && !ModoAgregar)
            {
                DataGridViewRow row = senderGridView.SelectedRows[0];

                lblIdSucursal.Text = row.Cells["SucursalId"].Value.ToString();
                txtNumero.Text = row.Cells["Numero"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtEstado.Text = row.Cells["Estado"].Value.ToString();
                txtCiudad.Text = row.Cells["Ciudad"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
            }

        }
    }
}
