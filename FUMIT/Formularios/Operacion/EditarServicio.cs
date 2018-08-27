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
    public partial class EditarServicio: Form
    {
        private Entidades.Serviciosprogramado objetoEditable;
        private bool modoEditar = false;


        public Entidades.Serviciosprogramado ObjetoEditable {
            get
            {
                return objetoEditable;
            }
            set
            {
                objetoEditable = value;
                //BindingList<Entidades.Serviciosprogramado> bindingList = new BindingList<Entidades.Serviciosprogramado>();
                //bindingList.Add(objetoEditable);
                //serviciosProgramadosUC.serviciosprogramadoBindingSource.DataSource = bindingList;
                serviciosProgramadosUC.serviciosprogramadoBindingSource.Add(objetoEditable);
                serviciosProgramadosUC.serviciosprogramadoBindingSource.ResetBindings(false);
                serviciosProgramadosUC.CancelarCargaDefault = true;


            }
        }
        public bool ModoEditar
        {
            get
            {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                serviciosProgramadosUC.ModoEditar = modoEditar;
            }

        }

        public EditarServicio()
        {
            InitializeComponent();
        }
    }
}
