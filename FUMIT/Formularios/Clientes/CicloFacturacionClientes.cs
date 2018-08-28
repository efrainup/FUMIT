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
        public CicloFacturacionClientes()
        {
            InitializeComponent();
        }

        private void btnBusquedaCiclos_Click(object sender, EventArgs e)
        {
            var formulario = new Formularios.Facturacion.CiclosFacturacion();
            formulario.ShowDialog();
        }
    }
}
