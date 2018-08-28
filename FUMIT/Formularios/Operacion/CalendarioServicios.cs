using FUMIT.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT.Formularios.Operacion
{
    public partial class CalendarioServicios : Form
    {
        private int semanaActual;
        private int totalSemanas;

        List<string> serviciosFiltrados = new List<string>();
        public IServicio ServiciosRepositorio { get; set; }
        public IServiciosProgramados ServiciosProgramadosRepo { get; set; }
        FUMIT.UserControls.Wpf.CalendarioSemanalUserControl CalendarioUC ;
        public int SemanaActual { get {
                return semanaActual;
            }
            set
            {
                semanaActual = value;
                tsbSemanaActual.Text = semanaActual.ToString();

                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar calendar = dfi.Calendar;

                DateTime primerDiaAño  = new DateTime(Año, 1, 1);
                //Se resta una semana porque el primer día del año está en la semana 1 y si se agrega una semana entonces nos daría la semana 2.
                DateTime primerDiaSemana = calendar.AddWeeks(primerDiaAño, semanaActual -1);

                dtpFechaInicio.Value = primerDiaSemana;
                dtpFechaFinal.Value = primerDiaSemana.AddDays(6); //Lunes +6 días es igual a domingo

                //TotalSemanas = calendar.GetWeekOfYear(new DateTime(año, 12, 31), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                ////Solo en el año actual pone la semana actual
                //if (año == DateTime.Now.Year)
                //{
                //    SemanaActual = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                //}

            }
        }
        public int TotalSemanas {
            get
            {
                return totalSemanas;
            }
            set
            {
                totalSemanas = value;
                tsbNumeroSemanas.Text = totalSemanas.ToString();
            }
        }
        public int Año { get; set; }


        public CalendarioServicios()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //NewMethod();
            IEnumerable<Entidades.Serviciosprogramado> serviciosProgramadosLista = ServiciosProgramadosRepo.Recuperar();

            TimeSpan diasDiferencia = dtpFechaFinal.Value - dtpFechaInicio.Value;
            diasDiferencia = diasDiferencia.Add(TimeSpan.FromDays(1));

            List<FUMIT.UserControls.Wpf.Semana> miLista = new List<FUMIT.UserControls.Wpf.Semana>();


            DateTime fechaActual = dtpFechaInicio.Value.Date;
            //dataGridView1.Columns.Clear();
            int i = 0;
            while (fechaActual <= dtpFechaFinal.Value.Date && i < 7)
            {
                //dataGridView1.Columns.Add($"Fecha{i}", $"{fechaActual.ToLongDateString()}");



                Entidades.Serviciosprogramado[] serviciosprogramados = serviciosProgramadosLista
                    .Where(w => w.FechaServicio.Date == fechaActual && serviciosFiltrados.Contains(w.Servicio.Nombre))
                    .OrderBy(o => o.Prioridad)
                    .ThenBy(t => t.ClienteId)
                    .ToArray();


                for (int j = 0; j < serviciosprogramados.Length; j++)
                {
                    FUMIT.UserControls.Wpf.Semana semana = miLista.ElementAtOrDefault(j);
                    if (semana == null)
                    {
                        semana = new FUMIT.UserControls.Wpf.Semana();
                        //elemento = new object[Math.Abs(diasDiferencia.Days)];
                        miLista.Add(semana);
                    }

                    var nuevoServicio = new FUMIT.UserControls.Wpf.Servicio()
                    {
                        Id = serviciosprogramados[j].ServicioProgramadoId,
                        Cliente = serviciosprogramados[j].Clientes.Nombre,
                        Status = serviciosprogramados[j].Cancelado ? "Cancelado" : "Pendiente",
                        Cancelado = serviciosprogramados[j].Cancelado,
                        DescripcionServicio = serviciosprogramados[j].Servicio.Nombre,
                        Unidad = "Sin unidad asignada",
                        Entidad = serviciosprogramados[j],
                        
                    };

                    switch (fechaActual.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            semana.Lunes = nuevoServicio;
                            break;
                        case DayOfWeek.Tuesday:
                            semana.Martes = nuevoServicio;
                            break;
                        case DayOfWeek.Wednesday:
                            semana.Miercoles = nuevoServicio;
                            break;
                        case DayOfWeek.Thursday:
                            semana.Jueves = nuevoServicio;
                            break;
                        case DayOfWeek.Friday:
                            semana.Viernes = nuevoServicio;
                            break;
                        case DayOfWeek.Saturday:
                            semana.Sabado = nuevoServicio;
                            break;
                        case DayOfWeek.Sunday:
                            semana.Domingo = nuevoServicio;
                            break;
                    }

                }
                fechaActual = fechaActual.AddDays(1);
                i++;

            }

            CalendarioUC.HorarioServiciosSemanales.Clear();
            foreach(UserControls.Wpf.Semana semana in miLista)
            {
                CalendarioUC.HorarioServiciosSemanales.Add(semana);
            }

            //CalendarioUC.HorarioServiciosSemanales.Add()
            
        }

        private void NewMethod()
        {
            IEnumerable<Entidades.Serviciosprogramado> serviciosProgramadosLista = ServiciosProgramadosRepo.Recuperar();

            TimeSpan diasDiferencia = dtpFechaFinal.Value - dtpFechaInicio.Value;
            diasDiferencia = diasDiferencia.Add(TimeSpan.FromDays(1));

            List<object[]> miLista = new List<object[]>();

            DateTime fechaActual = dtpFechaInicio.Value.Date;
            //dataGridView1.Columns.Clear();
            int i = 0;
            while (fechaActual < dtpFechaFinal.Value.Date)
            {
                //dataGridView1.Columns.Add($"Fecha{i}", $"{fechaActual.ToLongDateString()}");



                Entidades.Serviciosprogramado[] serviciosprogramados = serviciosProgramadosLista.Where(w => w.FechaServicio.Date == fechaActual).ToArray();


                for (int j = 0; j < serviciosprogramados.Length; j++)
                {
                    object[] elemento = miLista.ElementAtOrDefault(j);
                    if (elemento == null)
                    {
                        elemento = new object[Math.Abs(diasDiferencia.Days)];
                        miLista.Add(elemento);
                    }

                    elemento[i] = serviciosprogramados[j].Clientes.Nombre;

                }
                fechaActual = fechaActual.AddDays(1);
                i++;

            }


            var enume = miLista.GetEnumerator();
            while (enume.MoveNext())
            {
                var obj = enume.Current;
              //  dataGridView1.Rows.Add(obj);
            }
        }

        private void CalendarioServicios_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ServiciosProgramadosRepo = new ServiciosProgramadosRepositorio();
                ServiciosRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<IServicio>();

                //Se cargan datos en el filtro
                IEnumerable<Entidades.Servicio> servicios = ServiciosRepositorio.Recuperar();
                serviciosCheckList.ItemCheck -= serviciosCheckList_ItemCheck;
                foreach (Entidades.Servicio servicio in servicios)
                {
                    serviciosCheckList.Items.Add(servicio.Nombre, true);
                    serviciosFiltrados.Add(servicio.Nombre);
                }
                serviciosCheckList.ItemCheck += serviciosCheckList_ItemCheck;
                
                //serviciosCheckList.Items.AddRange(ServiciosRepositorio.Recuperar().Select(s => s.Nombre).ToArray());


                //Se agrega calendario
                CalendarioUC = new FUMIT.UserControls.Wpf.CalendarioSemanalUserControl();
                CalendarioUC.InitializeComponent();
                CalendarioUC.MoverServicio += CalendarioUC_MoverServicio;
                CalendarioUC.CancelarServicio += CalendarioUC_CancelarServicio;
                CalendarioUC.VerExpedienteCliente += CalendarioUC_VerExpedienteCliente;
                elementHost2.Child = CalendarioUC;


                //Se calculan las semanas del año actual
                Año = DateTime.Now.Year;
                CalcularSemanasAño(Año);
                btnActualizar_Click(sender, e);
            }

        }

        private void CalendarioUC_VerExpedienteCliente(object sender, object e)
        {
            Entidades.Serviciosprogramado servicioProgramado = e as Entidades.Serviciosprogramado;

            Formularios.Clientes.Expedientes expedientes = new Clientes.Expedientes();
            expedientes.Load += (sender_load, e_load) =>
            {
                int indice = expedientes.clienteBindingSource.IndexOf(servicioProgramado.Clientes);
                expedientes.clienteBindingSource.Position = indice;
            };
            expedientes.Show();
        }

        private async void CalendarioUC_CancelarServicio(object sender, object e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desa cancelar este servicio?", "Cancelación de servicio", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            if(respuesta == DialogResult.Yes)
            {
                Entidades.Serviciosprogramado servicioProramado = (e as Entidades.Serviciosprogramado);
                servicioProramado.Cancelado = true;
                await ServiciosProgramadosRepo.ActualizarAsync(servicioProramado);

                btnActualizar_Click(sender, null);
            }

            return;
        }

        private void CalcularSemanasAño(int año)
        {
            DateTimeFormatInfo informacionFormatoDeFecha = DateTimeFormatInfo.CurrentInfo;
            Calendar calendar = informacionFormatoDeFecha.Calendar;
            TotalSemanas = calendar.GetWeekOfYear(new DateTime(año, 12, 31), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            //Solo en el año actual pone la semana actual
            if (año == DateTime.Now.Year)
            {
                SemanaActual = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            }
            tsbAñoTextBox.Text = año.ToString();
        }

        protected void CalendarioUC_MoverServicio(object sender, object servicio)
        {

            var servicioProgramad = servicio as Entidades.Serviciosprogramado;

            var editarServicioFormulario = new Operacion.EditarServicio();
            editarServicioFormulario.ObjetoEditable = servicioProgramad;
            editarServicioFormulario.ModoEditar = true;

            editarServicioFormulario.serviciosProgramadosUC.ServicioProgramadoGuardado += (sender_servicioguardado, servicioGuardado) =>
            {
                btnActualizar_Click(sender_servicioguardado, null);
            };

            editarServicioFormulario.ShowDialog();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            SemanaActual++;
            btnActualizar_Click(sender, e);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            SemanaActual--;
            btnActualizar_Click(sender, e);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            SemanaActual = TotalSemanas;
            btnActualizar_Click(sender, e);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            SemanaActual = 1;
            btnActualizar_Click(sender, e);
        }

        private void TsbAñoTextBox_Leave(object sender, EventArgs e)
        {
            CalcularSemanasAño(Convert.ToInt32(tsbAñoTextBox.Text));
            btnActualizar_Click(sender, e);
        }

        private void AgregarServicioButton_Click(object sender, EventArgs e)
        {

            var editarServicioFormulario = new Operacion.EditarServicio();
            editarServicioFormulario.serviciosProgramadosUC.serviciosprogramadoBindingSource.AddNew();
            editarServicioFormulario.ModoEditar = true;
            editarServicioFormulario.serviciosProgramadosUC.CancelarCargaDefault = true;

            editarServicioFormulario.serviciosProgramadosUC.ServicioProgramadoGuardado += (sender_servicioguardado, servicioGuardado) =>
            {
                btnActualizar_Click(sender_servicioguardado, null);
            };

            editarServicioFormulario.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void serviciosCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Se obtienen los filtros
            serviciosFiltrados = serviciosCheckList.CheckedItems.OfType<string>().ToList();

            if (e.NewValue == CheckState.Checked)
            {
                serviciosFiltrados.Add(serviciosCheckList.Items[e.Index].ToString());
            }
            else
            {
                serviciosFiltrados.Remove(serviciosCheckList.Items[e.Index].ToString());
            }

            btnActualizar_Click(sender, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalendarioUC.Print();
        }
    }
}
