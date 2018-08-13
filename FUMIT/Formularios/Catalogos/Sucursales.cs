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
    public partial class Sucursales : Form
    {
        [DefaultValue(false)]
        public bool CambiosPendientes { get; set; }
        public ISucursales DatosSucursales { get; set; }
        public DataTable SucursalesDataTable { get; set; }

        public Sucursales()
        {
            InitializeComponent();

            //TODO: Implementar inyeccion de dependencias
            DatosSucursales = new SucursalesRepositorio();
            IEnumerable<Entidades.Sucursal> coleccionSucursales = DatosSucursales.Recuperar();
            foreach(Entidades.Sucursal sucursal in coleccionSucursales)
            {
                SucursalesDataTable.Rows.Add(new object[]{sucursal.SuscursalId,sucursal.Numero, sucursal.Nombre, sucursal.Estado, sucursal.Ciudad, sucursal.Direccion, sucursal.Activo });
            }

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!CambiosPendientes)
            {
                foreach(DataGridViewRow registro in ListaSucursales.Rows)
                {
                    //if(registro.... .State == DataGridViewElementStates..
                }
                
                //Cargar todas las sucursales existentes
                ListaSucursales.DataSource = DatosSucursales.Recuperar();
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (CambiosPendientes)
            {
                DialogResult resultadoDialogo = MessageBox.Show("Hay cambios que aún no se han guardado ¿Desea guardar los cambios?", "Sucursales", MessageBoxButtons.YesNoCancel,MessageBoxIcon.None,MessageBoxDefaultButton.Button1);
                if (resultadoDialogo == DialogResult.Cancel)
                {
                    return;
                } else if (resultadoDialogo == DialogResult.Yes)
                {
                    btnGuardar_Click(sender, e);
                }
            }
            this.Close();
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
            btnEditarSucursal.Enabled = false;
            btnAceptarAgregar.Visible = true;
            btnCancelarEdicion.Visible = true;
            btnCancelarEdicion.Enabled = true;

            //ListaSucursales.CurrentRow.Clone();
            
            int rowId = ListaSucursales.Rows.Add();

            ListaSucursales.ReadOnly = false;
            ListaSucursales.Rows[rowId].Selected = true;
            ListaSucursales.Rows[rowId].ReadOnly = false;
            

            ListaSucursales.BeginEdit(true);
        }

        private async void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            int nuevoRegistro = ListaSucursales.NewRowIndex;
            Entidades.Sucursal nuevaSucursal = new Entidades.Sucursal();
            nuevaSucursal.Numero = ListaSucursales.Rows[nuevoRegistro].Cells["Numero"].Value.ToString();
            nuevaSucursal.Nombre = ListaSucursales.Rows[nuevoRegistro].Cells["Nombre"].Value.ToString();
            nuevaSucursal.Ciudad = ListaSucursales.Rows[nuevoRegistro].Cells["Ciudad"].Value.ToString();
            nuevaSucursal.Estado = ListaSucursales.Rows[nuevoRegistro].Cells["Estado"].Value.ToString();
            nuevaSucursal.Direccion = ListaSucursales.Rows[nuevoRegistro].Cells["Direccion"].Value.ToString();
            nuevaSucursal.Activo = Convert.ToBoolean(ListaSucursales.Rows[nuevoRegistro].Cells["Estado"].Value);

            await DatosSucursales.CrearAsync(nuevaSucursal);

            btnAceptarAgregar.Visible = false;
            btnCancelarEdicion.Visible = false;
            btnCancelarEdicion.Enabled = false;
            btnEditarSucursal.Enabled = true;

            ListaSucursales.CurrentRow.ReadOnly = true;
            ListaSucursales.ReadOnly = true;
        }
    }
}
