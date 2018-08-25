using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        private ObservableCollection<Semana> horarioServiciosSemanales;
        internal ObservableCollection<Semana> HorarioServiciosSemanales {
            get {
                return horarioServiciosSemanales;
            }
            set
            {
                horarioServiciosSemanales = value;
                dgS.Items.Clear();
                dgS.ItemsSource = null;
                dgS.ItemsSource = horarioServiciosSemanales;

            }
        }

        public event EventHandler<Servicio> MoverServicio;
        public event EventHandler<Servicio> CancelarServicio;
        public event EventHandler<Servicio> VerExpedienteCliente;
        public event EventHandler<Servicio> CapturarTicketServicio;

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
            }
            

        }

        private void MenuItemMover_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            MoverServicio.Invoke(this, servicio);
        }

        private void MenuItemCancelar_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            MoverServicio.Invoke(this, servicio);
        }

        private void MenuItemVerExpediente_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            MoverServicio.Invoke(this, servicio);
        }

        private void MenuItemCapturarTicket_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = ((sender as MenuItem).CommandParameter as Servicio);
            MoverServicio.Invoke(this, servicio);
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

    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Cliente { get; set; }
        public string Unidad { get; set; }
        public string Status { get; set; }
        public bool Cancelado { get; set; }
    }

    
}
