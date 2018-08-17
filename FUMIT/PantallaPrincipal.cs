using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT
{
    public partial class PantallaPrincipal : Form
    {
        protected Formularios.Catalogos.Sucursales formulariosSucursales;
        protected Formularios.Catalogos.Servicios formularioServicios;

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

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSucursales.Show();
            FormularioSucursales.Activate();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioServicios.Show();
            FormularioServicios.Activate();
        }
    }
}
