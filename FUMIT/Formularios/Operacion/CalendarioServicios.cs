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

                DateTime primerDiaAño  = new DateTime(Convert.ToInt32(tsbAñoTextBox.Text), 12, 1);
                DateTime primerDiaSemana = calendar.AddWeeks(primerDiaAño, semanaActual);

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
            while (fechaActual < dtpFechaFinal.Value.Date && i < 7)
            {
                //dataGridView1.Columns.Add($"Fecha{i}", $"{fechaActual.ToLongDateString()}");



                Entidades.Serviciosprogramado[] serviciosprogramados = serviciosProgramadosLista.Where(w => w.FechaServicio.Date == fechaActual).ToArray();


                for (int j = 0; j < serviciosprogramados.Length; j++)
                {
                    FUMIT.UserControls.Wpf.Semana semana = miLista.ElementAtOrDefault(j);
                    if (semana == null)
                    {
                        semana = new FUMIT.UserControls.Wpf.Semana();
                        //elemento = new object[Math.Abs(diasDiferencia.Days)];
                        miLista.Add(semana);
                    }

                    switch (fechaActual.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            semana.Lunes = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;
                        case DayOfWeek.Tuesday:
                            semana.Martes = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;
                        case DayOfWeek.Wednesday:
                            semana.Miercoles = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;
                        case DayOfWeek.Thursday:
                            semana.Jueves = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;
                        case DayOfWeek.Friday:
                            semana.Viernes = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;
                        case DayOfWeek.Saturday:
                            semana.Sabado = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;
                        case DayOfWeek.Sunday:
                            semana.Domingo = new FUMIT.UserControls.Wpf.Servicio()
                            {
                                ServicioId = 1,
                                Cliente = serviciosprogramados[j].Clientes.Nombre,
                                Status = "Pendiente",
                                Unidad = "T000"
                            };
                            break;


                    }
                    //elemento[i] = serviciosprogramados[j].Clientes.Nombre;

                }
                fechaActual = fechaActual.AddDays(1);
                i++;

            }

           
            CalendarioUC.HorarioServiciosSemanales = new System.Collections.ObjectModel.ObservableCollection<UserControls.Wpf.Semana>(miLista);
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
            ServiciosProgramadosRepo = new ServiciosProgramadosRepositorio();

            //Se agrega calendario
            CalendarioUC = new FUMIT.UserControls.Wpf.CalendarioSemanalUserControl();
            CalendarioUC.InitializeComponent();
            CalendarioUC.MoverServicio += MoverServicio;
            elementHost2.Child = CalendarioUC;


            //Se calculan las semanas del año actual
            int año = DateTime.Now.Year;
            CalcularSemanasAño(año);

        }

        private void CalcularSemanasAño(int año)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar calendar = dfi.Calendar;
            TotalSemanas = calendar.GetWeekOfYear(new DateTime(año, 12, 31), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            //Solo en el año actual pone la semana actual
            if (año == DateTime.Now.Year)
            {
                SemanaActual = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            }
            tsbAñoTextBox.Text = año.ToString();
        }

        protected void MoverServicio(object sender, FUMIT.UserControls.Wpf.Servicio servicio)
        {
            var editarServicioFormulario = new Operacion.EditarServicio();
            editarServicioFormulario.ShowDialog();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            SemanaActual++;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            SemanaActual--;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            SemanaActual = TotalSemanas;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            SemanaActual = 1;
        }

        private void TsbAñoTextBox_Leave(object sender, EventArgs e)
        {
            CalcularSemanasAño(Convert.ToInt32(tsbAñoTextBox.Text));
        }
    }
}
