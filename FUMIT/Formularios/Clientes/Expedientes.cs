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
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Data.Entity.Validation;

namespace FUMIT.Formularios.Clientes
{
    public partial class Expedientes : Form, INotifyPropertyChanged
    {

        protected bool modoEdicion = false;
        protected bool modoNormal = true;


        public IClientes RepositorioClientes { get; set; }
        IEnumerable<Entidades.Cliente> ListadoClientes;
        Compartidos.BusquedaSucursal formularioBusqueda;
        BindingList<Entidades.Cliente> bindingList;
        Entidades.Cliente clienteBorrar;

        public event PropertyChangedEventHandler PropertyChanged;

        public Entidades.Cliente ClienteActual { get
            {
                return (clienteBindingSource.Current as Entidades.Cliente);
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
                if (modoEdicion)
                {
                    ModoNormal = false;
                    clienteBindingNavigatorSaveItem.Enabled = true;
                    tsbCancelarEdicion.Enabled = true;
                    tsbCancelarEdicion.Visible = true;
                }
                else
                {
                    ModoNormal = true;
                    clienteBindingNavigatorSaveItem.Enabled = false;
                    tsbCancelarEdicion.Enabled = false;
                    tsbCancelarEdicion.Visible = false;
                }

               
                NotifyPropertyChanged();
            }
        }
        public bool ModoNormal
        {
            get
            {
                return modoNormal;
            }
            set
            {
                modoNormal = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Expedientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                
                RepositorioClientes = ServiceLocator.Current.GetInstance<IClientes>();

                ListadoClientes = RepositorioClientes.Recuperar();

                
                //foreach(Entidades.Cliente cliente in ListadoClientes)
                //{
                //    clienteBindingSource.Add(cliente);
                //}
                bindingList = new BindingList<Entidades.Cliente>(ListadoClientes.ToList());
                clienteBindingSource.DataSource = bindingList;
                expedientesBindingSource.DataSource = this;
            }
        }

        private async void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            await GuardarEdicion();

        }

        private async Task GuardarEdicion()
        {
            try
            {
                var cliente = clienteBindingSource.Current as Entidades.Cliente;

                if (cliente.ClienteId == 0)
                {
                    await RepositorioClientes.CrearAsync(cliente);
                }
                else
                {
                    await RepositorioClientes.ActualizarAsync(cliente);
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

            ModoEdicion = false;
        }

        private void btnBuscarPorClave_Click(object sender, EventArgs e)
        {
            string claveBusqueda = claveTextBox.Text;

            Entidades.Cliente clienteBuscado = ListadoClientes.FirstOrDefault(f => f.Clave == claveBusqueda);
            if(clienteBuscado == null)
            {
                return;
            }
            else
            {
                int indice = clienteBindingSource.IndexOf(clienteBuscado);
                clienteBindingSource.Position = indice;
            }
        }

        private void btnBusquedaClientePorNombre_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = nombreTextBox.Text;

            Entidades.Cliente clienteBuscado = ListadoClientes.FirstOrDefault(f => f.Nombre.StartsWith(nombreBusqueda));
            if (clienteBuscado == null)
            {
                return;
            }
            else
            {
                int indice = clienteBindingSource.IndexOf(clienteBuscado);
                clienteBindingSource.Position = indice;
            }
        }

        private void toolBtnBusqueda_Click(object sender, EventArgs e)
        {
            MostrarFormularioDeBusqueda();
        }

        private void MostrarFormularioDeBusqueda()
        {
            var busquedaClientes = new Formularios.Compartidos.BusquedaClientes();
            busquedaClientes.ClienteSeleccionado += (object senderC, Entidades.Cliente clienteSeleccionado) =>
            {
                int indice = clienteBindingSource.IndexOf(clienteSeleccionado);
                clienteBindingSource.Position = indice;
            };
            busquedaClientes.Show();
        }

        private void btnBusquedaSucursal_Click(object sender, EventArgs e)
        {
            formularioBusqueda = new Compartidos.BusquedaSucursal();

            formularioBusqueda.SucursalSeleccionada += (object senderSucursal, Entidades.Sucursal sucursal) =>
            {
                if (sucursal != null)
                {
                    ClienteActual.Sucursal = sucursal;
                    ClienteActual.SucursalId = sucursal.SucursalId;
                    clienteBindingSource.ResetBindings(false);
                }
            };

            formularioBusqueda.Show(this);
            formularioBusqueda.Activate();
        }

        private void tabDatosCliente_TabIndexChanged(object sender, EventArgs e)
        {
            TabPage pagina = tabDatosCliente.TabPages[tabDatosCliente.TabIndex];
            


            switch (pagina.Name)
            {
                case "tabProgramacionServiciosCliente":
                    
                    if(programacionServiciosClientes1.ClienteId != ClienteActual.ClienteId)
                    {
                        programacionServiciosClientes1.ClienteId = ClienteActual.ClienteId;
                    }

                    break;
            }


          // 
        }

        private void tabDatosCliente_Selected(object sender, TabControlEventArgs e)
        {
            TabPage pagina = e.TabPage;

            switch (pagina.Name)
            {
                case "tabProgramacionServiciosCliente":

                    if (programacionServiciosClientes1.ClienteId != ClienteActual.ClienteId)
                    {
                        programacionServiciosClientes1.ClienteId = ClienteActual.ClienteId;
                    }

                    break;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //clienteBindingSource.chang
            //ModoEdicion = true;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ModoEdicion = true;
        }

        private void tsbCancelarEdicion_Click(object sender, EventArgs e)
        {
            CancelarEdicion();
        }

        private void CancelarEdicion()
        {
            ModoEdicion = false;
            if (ClienteActual.ClienteId == 0)
            {
                clienteBindingSource.RemoveCurrent();
            }
            else
            {
                clienteBindingSource.ResetCurrentItem();
            }
        }

        private void programacionServiciosClientes1_Load(object sender, EventArgs e)
        {

        }

        private void sucursalIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void sucursalIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void clienteBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemDeleted)
            {
                await RepositorioClientes.EliminarAsync(clienteBorrar);
            }
        }


        private void clienteBindingSource_CurrentItemChanged_1(object sender, EventArgs e)
        {
            clienteBorrar = ClienteActual;
        }

        private async void bindingNavigatorDeleteItem_Click_2(object sender, EventArgs e)
        {
            await RepositorioClientes.EliminarAsync(ClienteActual);
            clienteBindingSource.RemoveCurrent();
        }

        private void Expedientes_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if(e.KeyChar == Keys.Control
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.B))
            {
                MostrarFormularioDeBusqueda();
                return true;
            }
            if(keyData == (Keys.Control | Keys.N))
            {
                clienteBindingSource.AddNew();
                return true;
            }
            if(keyData == (Keys.Escape) && ModoEdicion)
            {
                CancelarEdicion();
                return true;
            }
            if (keyData == (Keys.Escape) && !ModoEdicion)
            {
                Close();
                return true;
            }
            if (keyData == (Keys.F2)) {
                ModoEdicion = true;
                return true;
            }
            if (keyData == (Keys.Control | Keys.G) && ModoEdicion)
            {
                GuardarEdicion().RunSynchronously();
                return true;
            }
            if (keyData == (Keys.Down | Keys.Control))
            {
                clienteBindingSource.Position++;
                return true;
            }
            if (keyData == (Keys.Up | Keys.Control))
            {
                clienteBindingSource.Position--;
                return true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
