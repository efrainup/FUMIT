using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
            
            dgS.ItemsSource = HorarioServiciosSemanales;

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
            //Print();
        }

        public void Print()
        {
            System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
            Printdlg.PrintTicket.PageOrientation = System.Printing.PageOrientation.Landscape;


            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printdlg.PrintableAreaWidth-10, Printdlg.PrintableAreaHeight-10);

                // sizing of the element.

                dgS.Measure(pageSize);
                dgS.Arrange(new Rect(10, 10, pageSize.Width, pageSize.Height));

                Printdlg.PrintVisual(dgS, "Calendario de servicio");

            }

            //new PrintDG().printDG(dgS, "Calendario de servicio");
        }

        private void dgS_CopyingRowClipboardContent(object sender, DataGridRowClipboardEventArgs e)
        {
            //e.
        }
    }

    public class PrintDG
    {
        public void printDG(DataGrid dataGrid, string title)
        {



            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument fd = new FlowDocument();

                Paragraph p = new Paragraph(new Run(title));
                p.FontStyle = dataGrid.FontStyle;
                p.FontFamily = dataGrid.FontFamily;
                p.FontSize = 18;
                fd.Blocks.Add(p);

                Table table = new Table();
                TableRowGroup tableRowGroup = new TableRowGroup();
                TableRow r = new TableRow();
                fd.PageWidth = printDialog.PrintableAreaWidth;
                fd.PageHeight = printDialog.PrintableAreaHeight;
                fd.BringIntoView();

                fd.TextAlignment = TextAlignment.Center;
                fd.ColumnWidth = 500;
                table.CellSpacing = 0;

                var headerList = dataGrid.Columns.Select(e => e.Header.ToString()).ToList();
                List<dynamic> bindList = new List<dynamic>();


                for (int j = 0; j < headerList.Count; j++)
                {

                    r.Cells.Add(new TableCell(new Paragraph(new Run(headerList[j]))));
                    r.Cells[j].ColumnSpan = 4;
                    r.Cells[j].Padding = new Thickness(4);



                    r.Cells[j].BorderBrush = Brushes.Black;
                    r.Cells[j].FontWeight = FontWeights.Bold;
                    r.Cells[j].Background = Brushes.DarkGray;
                    r.Cells[j].Foreground = Brushes.White;
                    r.Cells[j].BorderThickness = new Thickness(1, 1, 1, 1);
                    var binding = (dataGrid.Columns[j] as DataGridBoundColumn).Binding as Binding;

                    bindList.Add(binding.Path.Path);
                }
                tableRowGroup.Rows.Add(r);
                table.RowGroups.Add(tableRowGroup);
                for (int i = 0; i < dataGrid.Items.Count; i++)
                {

                    dynamic row;
                    if (dataGrid.ItemsSource.ToString().ToLower() == "system.data.linqdataview")
                    { row = (DataRowView)dataGrid.Items.GetItemAt(i); }
                    else
                    {
                        //row = (BalanceClient)dataGrid.Items.GetItemAt(i);
                        row = dataGrid.Items.GetItemAt(i);

                    }

                    table.BorderBrush = Brushes.Gray;
                    table.BorderThickness = new Thickness(1, 1, 0, 0);
                    table.FontStyle = dataGrid.FontStyle;
                    table.FontFamily = dataGrid.FontFamily;
                    table.FontSize = 13;
                    tableRowGroup = new TableRowGroup();
                    r = new TableRow();
                    for (int j = 0; j < row.Row.ItemArray.Count(); j++)
                    {

                        if (dataGrid.ItemsSource.ToString().ToLower() == "system.data.linqdataview")
                        {
                            r.Cells.Add(new TableCell(new Paragraph(new Run(row.Row.ItemArray[j].ToString()))));

                        }
                        else
                        {

                            r.Cells.Add(new TableCell(new Paragraph(new Run(row.GetType().GetProperty(bindList[j]).GetValue(row, null)))));

                        }



                        r.Cells[j].ColumnSpan = 4;
                        r.Cells[j].Padding = new Thickness(4);

                        r.Cells[j].BorderBrush = Brushes.DarkGray;
                        r.Cells[j].BorderThickness = new Thickness(0, 0, 1, 1);
                    }

                    tableRowGroup.Rows.Add(r);
                    table.RowGroups.Add(tableRowGroup);

                }
                fd.Blocks.Add(table);

                printDialog.PrintDocument(((IDocumentPaginatorSource)fd).DocumentPaginator, "");

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
