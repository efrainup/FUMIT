using FUMIT.AccesoDatos;
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
    public partial class CalendarioServicios : Form
    {
        public IServiciosProgramados ServiciosProgramadosRepo { get; set; }

        public CalendarioServicios()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            IEnumerable<Entidades.Serviciosprogramado> serviciosProgramadosLista = ServiciosProgramadosRepo.Recuperar();

            TimeSpan diasDiferencia =  dtpFechaFinal.Value - dtpFechaInicio.Value;
            diasDiferencia = diasDiferencia.Add(TimeSpan.FromDays(1));

            List<object[]> miLista = new List<object[]>();

            DateTime fechaActual = dtpFechaInicio.Value.Date;
            dataGridView1.Columns.Clear();
            int i = 0;
            while (fechaActual < dtpFechaFinal.Value.Date)
            {
                dataGridView1.Columns.Add($"Fecha{i}", $"{fechaActual.ToLongDateString()}");
                
                

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
                dataGridView1.Rows.Add(obj);
            }
        }

        private void CalendarioServicios_Load(object sender, EventArgs e)
        {
            ServiciosProgramadosRepo = new ServiciosProgramadosRepositorio();
        }
    }
}
