using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FUMIT.AccesoDatos;
using System.Data.Entity.Validation;

namespace FUMIT.Formularios.Clientes
{
    public partial class Contactos : UserControl
    {
        protected bool modoEditar = false;

        protected int clienteId;

        public int ClienteId { get {
                return clienteId;
            }
            set {
                clienteId = value;
                if (ContactosRepositorio != null)
                {
                    CargarDatos();
                }
            }
        }
        public IContactos ContactosRepositorio { get; set; }
        public IClientes ClientesRepositorio { get; set; }
        public bool ModoEditar
        {
            get
            {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                tsbCancelar.Enabled = modoEditar;
                contactoBindingNavigatorSaveItem.Enabled = modoEditar;
                bindingNavigatorAddNewItem.Enabled = !modoEditar;
                tsbEditar.Enabled = !modoEditar;
                bindingNavigatorDeleteItem.Enabled = !modoEditar;

                nombreTextBox.ReadOnly = !modoEditar;
                correoTextBox.ReadOnly = !modoEditar;
                telefonoTextBox.ReadOnly = !modoEditar;
                tipoComboBox.Enabled = modoEditar;

            }
        }
        public Entidades.Contacto ContactoActual { get {
                return (contactoBindingSource.Current as Entidades.Contacto);
            } }

        public Contactos()
        {
            InitializeComponent();
        }

        private void Contactos_Load(object sender, EventArgs e)
        {

            if (!DesignMode)
            {
                ClientesRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<IClientes>();
                ContactosRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<IContactos>();
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            contactoBindingSource.Clear();
            IEnumerable<Entidades.Contacto> contactos = ContactosRepositorio.RecuperarPorCliente(ClienteId);
            foreach (Entidades.Contacto contacto in contactos)
            {
                contactoBindingSource.Add(contacto);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private async void contactoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (ContactoActual.ContactoId > 0)
                {
                    await ContactosRepositorio.ActualizarAsync(ContactoActual);
                }
                else
                {
                    ContactoActual.ClienteId = ClienteId;
                    ContactoActual.Clientes = ClientesRepositorio.RecuperarPorId(ClienteId);
                    await this.ContactosRepositorio.CrearAsync(ContactoActual);
                }
                //
                ModoEditar = false;
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

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            ModoEditar = false;
        }
    }
}
