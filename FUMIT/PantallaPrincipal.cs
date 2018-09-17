using CommonServiceLocator;
using FUMIT.Entidades;
using FUMIT.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT
{
    public partial class PantallaPrincipal : Form
    {
        #region Propiedades
        protected Formularios.Catalogos.Sucursales formulariosSucursales;
        protected Formularios.Catalogos.Servicios formularioServicios;
        protected Formularios.Operacion.ProgramacionServiciosSucursales formularioProgramacionServiciosSucursales;
        protected Formularios.Facturacion.CiclosFacturacion formularioCicloFacturacion;

        public AccesoDatos.ISucursales SucursalesRepositorio { get; set; }
        Entidades.Sucursal[] CatalogoSucursales;

        public INotificador NotificadorEstado { get; set; }
        #endregion

        public Formularios.Catalogos.Sucursales FormularioSucursales {
            get
            {
                formulariosSucursales = formulariosSucursales ??  new Formularios.Catalogos.Sucursales();
                formulariosSucursales.MdiParent = this;
                formulariosSucursales.Disposed += (sender, e) => formulariosSucursales = null;
                
                return formulariosSucursales;
            }
        }
        public Formularios.Catalogos.Servicios FormularioServicios {
            get
            {
                formularioServicios = formularioServicios ?? new Formularios.Catalogos.Servicios();
                formularioServicios.MdiParent = this;
                formularioServicios.Disposed += (sender, e) => formularioServicios = null;

                return formularioServicios;
            }
        }
        public Formularios.Operacion.ProgramacionServiciosSucursales FormularioProgramacionServiciosSucursales
        {
            get
            {
                formularioProgramacionServiciosSucursales = formularioProgramacionServiciosSucursales ?? new Formularios.Operacion.ProgramacionServiciosSucursales();
                formularioProgramacionServiciosSucursales.MdiParent = this;
                formularioProgramacionServiciosSucursales.Disposed += (sender, e) => formularioProgramacionServiciosSucursales = null;

                return formularioProgramacionServiciosSucursales;
            }
        }
        public Formularios.Facturacion.CiclosFacturacion FormularioCicloFacturacion { get
            {
                formularioCicloFacturacion = formularioCicloFacturacion ?? new Formularios.Facturacion.CiclosFacturacion();
                formularioCicloFacturacion.MdiParent = this;
                formularioCicloFacturacion.Disposed += (sender, e) => formularioCicloFacturacion = null;

                return formularioCicloFacturacion;
            }
        }


        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                NotificadorEstado = ServiceLocator.Current.GetInstance<INotificador>("BarraDeEstado");
                SucursalesRepositorio = ServiceLocator.Current.GetInstance<AccesoDatos.ISucursales>();


                CatalogoSucursales = SucursalesRepositorio.Recuperar().ToArray();
                tsbSucursalActiva.Items.AddRange(CatalogoSucursales);
                tsbSucursalActiva.ComboBox.DisplayMember = "Nombre";

                //Seleccionar la primera sucursal, solo en el caso que haya
                if (tsbSucursalActiva.Items.Count > 0)
                {
                    tsbSucursalActiva.SelectedIndex = 0;
                }

                string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                NotificadorEstado.EnviarMensaje("Sistema de operaciones FUMIT " + version);
            }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSucursales.Show();
            FormularioSucursales.Activate();
        }

        private void ExpedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Formularios.Clientes.Expedientes();
            t.MdiParent = this;
            t.Show();
        }

        private void programacionDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programacionDeServiciosSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProgramacionServiciosSucursales.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioAcercaDe = new Formularios.Ayuda.AcercaDe();
            formularioAcercaDe.Show();

        }

        private void ciclosDeFactuacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCicloFacturacion.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioServicios.Show();
            FormularioServicios.Activate();
        }

        private void calendarioDeServiciosProgramadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serviciosProgramados = new Formularios.Operacion.CalendarioServicios();
            serviciosProgramados.MdiParent = this;
            serviciosProgramados.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var equiposFormulario = new Formularios.Catalogos.Equipos();
            equiposFormulario.MdiParent = this;
            equiposFormulario.Show();
        }

        private void PantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void capturaDeTicketsDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CapturaDeTicketFormulario = new Formularios.Operacion.CapturaDeTicketForm();
            CapturaDeTicketFormulario.MdiParent = this;
            CapturaDeTicketFormulario.Show();
        }
    }
}
