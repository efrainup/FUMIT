using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUMIT.UserControls.Wpf
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class CalendarioSemanalUserControl : UserControl
    {
        public ObservableCollection<Semana> horarioServiciosSemanales = new ObservableCollection<Semana>();
        internal ObservableCollection<Semana> HorarioServiciosSemanales {
            get
            {
                return horarioServiciosSemanales;
            }
            set
            {
                horarioServiciosSemanales = value;
                //dgS.Items.Clear();
                //dgS.ItemsSource = null;
                //dgS.ItemsSource = horarioServiciosSemanales;

            }
        }

        public event EventHandler<object> MoverServicio;
        public event EventHandler<object> CancelarServicio;
        public event EventHandler<object> VerExpedienteCliente;
        public event EventHandler<object> CapturarTicketServicio;

        public CalendarioSemanalUserControl()
        {
            InitializeComponent();
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                //Ejemplo
                var s = new Serviciosprogramado();
                //s.Cliente = "Altamira Terminal Portuaria";
                //s.Unidad = "045354";
                //s.Status = "Terminado";

                //for (int i = 0; i < 10; i++)
                //{
                //    var semana = new Semana();
                //    semana.Lunes = s;
                //    semana.Martes = s;

                //    semana.Miercoles = s;
                //    semana.Jueves = s;

                //    variasSemanas.Add(semana);
                //}

                //dgS.Items.Clear();
                //dgS.ItemsSource = null;
                //dgS.ItemsSource = variasSemanas;

                //HorarioServiciosSemanales.CollectionChanged += HorarioServiciosSemanales_CollectionChanged;

            }
            else
            {
                dgS.ItemsSource = HorarioServiciosSemanales;
            }
            

        }

        private void HorarioServiciosSemanales_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Trace.WriteLine("La coleccion ha cambiado");
        }

        private void MenuItemMover_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            MoverServicio.Invoke(this, servicio.Entidad);
        }

        private void MenuItemCancelar_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            CancelarServicio.Invoke(this, servicio.Entidad);
        }

        private void MenuItemVerExpediente_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            VerExpedienteCliente.Invoke(this, servicio.Entidad);
        }

        private void MenuItemCapturarTicket_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            if (CapturarTicketServicio != null)
            {
                CapturarTicketServicio.Invoke(this, servicio.Entidad);
            }
        }
    }
    

    public class Semana
    {
        public Servicio Lunes { get; set; }
        public Servicio Martes { get; set; }
        public Servicio Miercoles { get; set; }
        public Servicio Jueves { get; set; }
        public Servicio Viernes { get; set; }
        public Servicio Sabado { get; set; }
        public Servicio Domingo { get; set; }
    }

    public class Servicio : INotifyPropertyChanged
    {
        private object entidadServicio;

        public int Id { get; set; }
        public string DescripcionServicio { get; set; }
        public string Cliente { get; set; }
        public string Unidad { get; set; }
        public string Status { get; set; }
        public bool Cancelado { get; set; }
        public object Entidad {
            get {
                return entidadServicio;
            }
            set
            {
                entidadServicio = value;
            }
        }
        public string Observaciones { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    
}
