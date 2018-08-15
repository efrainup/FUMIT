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

namespace FUMIT.Formularios.Clientes
{
    public partial class Clientes : Form
    {
        public IClientes RepositorioClientes { get; set; }
        IEnumerable<Entidades.Cliente> ListadoClientes;
        Compartidos.BusquedaSucursal formularioBusqueda;
        public Entidades.Cliente ClienteActual { get
            {
                return (clienteBindingSource.Current as Entidades.Cliente);
            }
        }


        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                RepositorioClientes = ServiceLocator.Current.GetInstance<IClientes>();

                ListadoClientes = RepositorioClientes.Recuperar();
                foreach(Entidades.Cliente cliente in ListadoClientes)
                {
                    clienteBindingSource.Add(cliente);
                }

            }
        }

        private async void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
            var busquedaClientes = new Formularios.Compartidos.BusquedaClientes();
            busquedaClientes.Show();
        }

        private void btnBusquedaSucursal_Click(object sender, EventArgs e)
        {
            formularioBusqueda = new Compartidos.BusquedaSucursal();
            
            formularioBusqueda.SucursalSeleccionada += (object senderSucursal, Entidades.Sucursal sucursal) =>
            {
                if (sucursal != null)
                {
                    sucursalIdTextBox.Text = sucursal.SucursalId.ToString();
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

        private void tabProgramacionServiciosCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
