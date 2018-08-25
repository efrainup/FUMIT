using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        //ObservableCollection<Servicio> ss = new ObservableCollection<Servicio>();
        ObservableCollection<Semana> variasSemanas = new ObservableCollection<Semana>();

        public UserControl1()
        {
            InitializeComponent();

            
                var s = new Servicio();
                s.Cliente = "Altamira Terminal Portuaria";
                s.Unidad = "045354";
                s.Status = "Terminado";

            for (int i = 0; i < 10; i++)
            {
                var semana = new Semana();
                semana.Lunes = s;
                semana.Martes = s;

                semana.Miercoles = s;
                semana.Jueves = s;

                variasSemanas.Add(semana);
            }



            //ObservableCollection variasSemanas = new ObservableCollection<Semana>();
            

            dgS.Items.Clear();
            dgS.ItemsSource = null;
            dgS.ItemsSource = variasSemanas;

        }
    }

    class Semana
    {
        public Servicio Lunes { get; set; }
        public Servicio Martes { get; set; }
        public Servicio Miercoles { get; set; }
        public Servicio Jueves { get; set; }
        public Servicio Viernes { get; set; }
        public Servicio Sabado { get; set; }
    }

    class Servicio
    {
        public string Cliente { get; set; }
        public string Unidad { get; set; }
        public string Status { get; set; }
    }
}
