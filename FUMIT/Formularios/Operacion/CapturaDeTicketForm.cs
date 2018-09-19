using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT.Formularios.Operacion
{
    public partial class CapturaDeTicketForm : Form
    {
        public CapturaDeTicketForm()
        {
            InitializeComponent();
        }

        public CapturaDeTicketForm(Serviciosprogramado serviciosprogramado )
        {
            InitializeComponent();
            ticketsUC1.ServicioProgramadoAsociado = serviciosprogramado;
        }

        private void CapturaDeTicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}
