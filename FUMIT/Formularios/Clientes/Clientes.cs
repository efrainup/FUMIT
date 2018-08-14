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

namespace FUMIT.Formularios.Clientes
{
    public partial class Clientes : Form
    {
        public IClientes RepositorioClientes { get; set; }
        IEnumerable<Entidades.Cliente> ListadoClientes;
        Compartidos.BusquedaSucursal formularioBusqueda;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                RepositorioClientes = new ClientesRepositorio();

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
            await RepositorioClientes.CrearAsync(cliente);

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
    }
}
