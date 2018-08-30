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
using FUMIT.AccesoDatos;
using FUMIT.Entidades;

namespace FUMIT.Formularios.Catalogos
{
    public partial class Equipos : Form, IFormularioSeleccionable<Entidades.Equipo>
    {
        public IEquipos EquiposRepositorio { get; set; }
        public ITipoEquipos TiposEquipoRepositorio { get; set; }
        public bool ModoSeleccion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Equipo SeleccionActual {
            get {
                return equipoBindingSource.Current as Equipo;
            }

        }

        public Equipos()
        {
            InitializeComponent();
        }

        public event EventHandler<Equipo> ItemSeleccionado;

        private void Equipos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                TiposEquipoRepositorio = ServiceLocator.Current.GetInstance<ITipoEquipos>();
                EquiposRepositorio = ServiceLocator.Current.GetInstance<IEquipos>();

                //Carga los tipos
                List<Entidades.Tipoequipo> tiposEquipos = TiposEquipoRepositorio.Recuperar().ToList();
                tiposEquiposComboBox.DataSource = tiposEquipos;
                tiposEquiposComboBox.DisplayMember = "Nombre";
                tiposEquiposComboBox.Items.Insert(0,new { Nombre = "<Agregar nuevo tipo de equipo>" });

                //Cargar equipos
                equipoBindingSource.DataSource = EquiposRepositorio.Recuperar();

            }
        }

        private void tiposEquiposComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si es el último, se abre formulario para agregar otro tipo
            if(tiposEquiposComboBox.Items.Count == tiposEquiposComboBox.SelectedIndex)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formularioAgregarTipoEquipo = new Formularios.Catalogos.TiposEquipo();
            formularioAgregarTipoEquipo.Load += (sender_load, e_args) =>
            {
                formularioAgregarTipoEquipo.tipoequipoBindingSource.AddNew();
            };
            formularioAgregarTipoEquipo.ModoEditar = true;
            formularioAgregarTipoEquipo.ModoSeleccion = true;
            formularioAgregarTipoEquipo.ItemSeleccionado += (sneder_tipo, tipoequipo) =>
            {
                SeleccionActual.TipoEquipoId = tipoequipo.TipoEquipoId;
                SeleccionActual.Tipoequipo = tipoequipo;

                equipoBindingSource.ResetBindings(false);
            };

            formularioAgregarTipoEquipo.ShowDialog();
        }
    }
}
