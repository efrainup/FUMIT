using CommonServiceLocator;
using FUMIT.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT.Formularios.Operacion
{
    public partial class ProgramacionServiciosSucursales : Form, INotifyPropertyChanged
    {
        private bool modoBusqueda = false;
        private bool modoEditar = false;
        private bool modoNormal = true;
        private int sucursalId;

        public Compartidos.BusquedaSucursal FormularioBusquedaSucursal { get; set; }
        public IProgramacionServicios ProgramacionServicioRepositorio { get; set; }
        IEnumerable<Entidades.Programacionservicio> programacionServicios;

        public event EventHandler<Entidades.Programacionservicio> ProgramacionServicioSeleccionado;
        public event PropertyChangedEventHandler PropertyChanged;

        public Entidades.Programacionservicio ProgramacionServicioActual
        {
            get
            {
                return (programacionservicioBindingSource.Current as Entidades.Programacionservicio);
            }
        }

        public bool ModoBusqueda {
            get
            {
                return modoBusqueda;
            }
            set
            {
                modoBusqueda = value;
                if (modoBusqueda)
                {
                    btnSeleccionar.Visible = true;
                    bindingNavigatorDeleteItem.Enabled = false;
                    
                }
                else
                {
                    btnSeleccionar.Visible = false;
                    bindingNavigatorDeleteItem.Enabled = true;
                }
            }
        }
        public bool ModoEditar { 
            get {
                return modoEditar;
            }
            set
            {
                modoEditar = value;
                ModoNormal = !modoEditar;
                tsbCancelar.Enabled = modoEditar;
                programacionservicioBindingNavigatorSaveItem.Enabled = modoEditar;
                
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
                bindingNavigatorAddNewItem.Enabled = modoNormal;
                bindingNavigatorDeleteItem.Enabled = modoNormal;
                toolStripButton1.Enabled = modoNormal;
            }
        }

        public int SucursalId
        {
            get
            {
                return sucursalId;
            }
            set
            {
                sucursalId = value;
                if(ProgramacionServicioRepositorio != null)
                {
                    programacionServicios = ProgramacionServicioRepositorio.RecuperarPorIdSucursal(sucursalId);
                    foreach (Entidades.Programacionservicio programacionServicio in programacionServicios)
                    {
                        programacionservicioBindingSource.Add(programacionServicio);
                    }
                }

            }
        }

        public ProgramacionServiciosSucursales()
        {
            InitializeComponent();
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void mesLabel_Click(object sender, EventArgs e)
        {

        }

        private void mesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void diaLabel_Click(object sender, EventArgs e)
        {

        }

        private void diaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sucursalIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnBusquedaSucursal_Click(object sender, EventArgs e)
        {
            FormularioBusquedaSucursal = new Compartidos.BusquedaSucursal();

            FormularioBusquedaSucursal.SucursalSeleccionada += (object senderSucursal, Entidades.Sucursal sucursal) =>
            {
                if (sucursal != null)
                {
                    //(programacionservicioBindingSource.Current as Entidades.Programacionservicio).Sucursal = sucursal;
                    //sucursalIdTextBox.Text = sucursal.SucursalId.ToString();
                    (programacionservicioBindingSource.Current as Entidades.Programacionservicio).SucursalId = sucursal.SucursalId;
                    (programacionservicioBindingSource.Current as Entidades.Programacionservicio).Sucursal = sucursal;

                    programacionservicioBindingSource.ResetBindings(false);
                }
            };

            FormularioBusquedaSucursal.Show(this);
            FormularioBusquedaSucursal.Activate();
        }

        private void chkListDiasSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = (sender as CheckedListBox);
            CheckedListBox.CheckedItemCollection DiasProgramacion = checkedListBox.CheckedItems;

            

            IEnumerable<string> diasProgramados = DiasProgramacion.Cast<String>().AsEnumerable();

            string resultadoDias = "";
            if (ProgramacionServicioActual.Semana.HasValue)
            {
                int numeroSemanas = Convert.ToInt32(ProgramacionServicioActual.Semana.Value);

                if (numeroSemanas > 0)
                {
                    //Efrain Hernandez 20/08/2018: Solo se indica una semana debido a que si se establece
                    //Lunes cada 2 semanas, debería ser el día lunes cada 2 semanas y no el día lunes de cada semana.
                    resultadoDias = ObtenerDiasTexto(diasProgramados, 1);

                    if (resultadoDias.Length > 0)
                    {
                        resultadoDias = resultadoDias.Substring(0, resultadoDias.Length - 1);
                    }

                    (programacionservicioBindingSource.Current as Entidades.Programacionservicio).Dias = resultadoDias;
                }
            }

        }

        private static string ObtenerDiasTexto(IEnumerable<string> diasProgramados, int numeroSemanas)
        {
            string resultadoDias = "";
            for (int i = 0; i < numeroSemanas; i++)
            {
                foreach (string dia in diasProgramados)
                {
                    switch (dia)
                    {
                        case "Lunes":
                            resultadoDias += 1 + (7 * i);
                            break;
                        case "Martes":
                            resultadoDias += 2 + (7 * i);
                            break;
                        case "Miercoles":
                            resultadoDias += 3 + (7 * i);
                            break;
                        case "Jueves":
                            resultadoDias += 4 + (7 * i);
                            break;
                        case "Viernes":
                            resultadoDias += 5 + (7 * i);
                            break;
                        case "Sabado":
                            resultadoDias += 6 + (7 * i);
                            break;
                        case "Domingo":
                            resultadoDias += 7 + (7 * i);
                            break;
                    }
                    resultadoDias += ",";
                }

            }

            return resultadoDias;
        }

        private void semanaTextBox_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(semanaTextBox.Text) > 0)
            {
                chkListDiasSemana.Enabled = true;
                CheckedListBox.CheckedItemCollection DiasProgramacion = chkListDiasSemana.CheckedItems;
                IEnumerable<string> diasProgramados = DiasProgramacion.Cast<String>().AsEnumerable();

                string resultadoDias = "";
                int numeroSemanas = Convert.ToInt32(semanaTextBox.Text);

                if (numeroSemanas > 0)
                {
                    resultadoDias = ObtenerDiasTexto(diasProgramados, numeroSemanas);

                    diasTextBox.Text = resultadoDias.Substring(0, resultadoDias.Length - 1);
                }
            }
            else
            {
                chkListDiasSemana.Enabled = false;
            }
        }

        private void chkListTipoProgramacion_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                string tipo = chkListTipoProgramacion.Items[e.Index].ToString();

                //Se deschequean los demas
                int conteo = chkListTipoProgramacion.Items.Count;
                for(int i=0; i < conteo; i++)
                {
                    if(e.Index != i)
                    {
                        chkListTipoProgramacion.SetItemChecked(i, false);
                    }
                }

                //CheckedListBox.CheckedItemCollection TipoProgramacion = (sender as CheckedListBox).CheckedItems;
                //string tipo = TipoProgramacion.Cast<String>().FirstOrDefault();

                switch (tipo)
                {
                    case "Diaria":
                        chkListDiasSemana.Enabled = true;
                        diasTextBox.Text = "1,2,3,4,5,6,7";
                        for (int i = 0; i < chkListDiasSemana.Items.Count; i++)
                        {
                            chkListDiasSemana.SetItemChecked(i, true);
                        }
                        semanaTextBox.Text = "1";
                        break;
                    case "Semanal":
                        chkListDiasSemana.Enabled = true;
                        semanaTextBox.Text = "1";
                        break;
                    case "Mensual":
                        mesTextBox.Text = "1";
                        chkListDiasSemana.Enabled = false;
                        break;
                    default:
                        chkListDiasSemana.Enabled = true;
                        break;
                }
            }
            
        }

        private void semanaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void programacionservicioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Entidades.Programacionservicio programacionServicioActual = programacionservicioBindingSource.Current as Entidades.Programacionservicio;

            if(programacionServicioActual.ProgramacionServicioId > 0)
            {
                await ProgramacionServicioRepositorio.ActualizarAsync(programacionServicioActual);
            }
            else
            {
                await ProgramacionServicioRepositorio.CrearAsync(programacionServicioActual);
            }

            ModoEditar = false;
        }

        private void ProgramacionServiciosSucursales_Load(object sender, EventArgs e)
        {
            ProgramacionServicioRepositorio = ServiceLocator.Current.GetInstance<IProgramacionServicios>();
            if (!DesignMode)
            {
                programacionServiciosSucursalesbindingSource.DataSource = this;
                programacionservicioBindingSource.Clear();
                programacionServicios = ProgramacionServicioRepositorio.Recuperar();
                foreach(Entidades.Programacionservicio programacionServicio in programacionServicios)
                {
                    programacionservicioBindingSource.Add(programacionServicio);
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProgramacionServicioSeleccionado.Invoke(this, ProgramacionServicioActual);
            Close();
        }

        private void programacionservicioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            //Se limpia
            for (int i = 0; i < 7; i++)
            {
                chkListDiasSemana.SetItemChecked(i,false);
            }


            if (ProgramacionServicioActual.Dias != null && ProgramacionServicioActual.Semana.HasValue && ProgramacionServicioActual.Semana.Value > 0)
            {
                int[] dias = ProgramacionServicioActual.Dias.Split(',').Select(s => Convert.ToInt32(s)).ToArray();

                for (int i = 0; (i < dias.Length) && (i < 8); i++)
                {
                    chkListDiasSemana.SetItemChecked(i, i + 1 == dias[i]);
                }
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModoEditar = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (ProgramacionServicioActual.ProgramacionServicioId == 0)
            {
                programacionservicioBindingSource.RemoveAt(programacionservicioBindingSource.Position);
            }
            else
            {
                programacionservicioBindingSource.ResetItem(programacionservicioBindingSource.Position);
            }
            
            ModoEditar = false;
        }

        private async  void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            await ProgramacionServicioRepositorio.EliminarAsync(ProgramacionServicioActual);
            programacionservicioBindingSource.RemoveCurrent();

        }
    }
}
