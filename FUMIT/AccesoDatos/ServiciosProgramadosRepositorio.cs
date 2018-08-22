using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public class ServiciosProgramadosRepositorio : AOperacionesBase<Serviciosprogramado>, IServiciosProgramados
    {
        protected IProgramacionServiciosCliente programacionServiciosClienteOperaciones;

        public ServiciosProgramadosRepositorio()
        {
            programacionServiciosClienteOperaciones = CommonServiceLocator.ServiceLocator.Current.GetInstance<IProgramacionServiciosCliente>();

        }

        public async Task ProgramarServicios(Programacionservicioscliente programacionServicio)
        {
            DateTime fechaActual = programacionServicio.FechaInicio;
            int[] ds = programacionServicio.Programacionservicio.Dias.Split(',').Select(s => Convert.ToInt32(s.Replace("7", "0"))).ToArray();

            //El conteo siempre comeinza a partir del proximo lunes.

            //Si hay dias especificados, sin semanas ni meses, entonces el ciclo se repite cada x dias
            //Ej. D=15,S=0,M=0 el ciclo se repite cada 15 dias.

            //Si hay varios dias especificados, sin semanas ni meses, entonces el ciclo se repite cada x dias
            //Ej. D=7,15 ,S=0,M=0 el ciclo se repite cada 15 dias (Se toma el último).

            //Si hay semanas especificadas, entonces el ciclo se repite cada x semanas * 7

            //Si hay meses especificados, entonces el ciclo se repite cada cambio de mes

            int dia = 1;
            int mes = 1;
            int diasCiclo = 0;
            int mesCiclo = 0;
            bool cambioDeMes = false;

            int i = 0;
            if (fechaActual.DayOfWeek != DayOfWeek.Monday)
            {
                while (fechaActual.AddDays(i).DayOfWeek != DayOfWeek.Monday)
                {
                    i++;
                };

                dia = dia - i;
            }

            if (!programacionServicio.Programacionservicio.Semana.HasValue || programacionServicio.Programacionservicio.Semana.Value == 0)
            {
                diasCiclo = ds.Max();
            }
            else
            {
                diasCiclo = programacionServicio.Programacionservicio.Semana.Value * 7;
            }

            cambioDeMes = programacionServicio.Programacionservicio.Mes.HasValue && programacionServicio.Programacionservicio.Mes.Value > 0;


            while (fechaActual <= programacionServicio.FechaTermino)
            {

                if (ds.Any(a => a == dia))
                {


                    Entidades.Serviciosprogramado servicio = new Serviciosprogramado()
                    {
                        ServicioProgramadoId = 0,
                        ClienteId = programacionServicio.ClienteId,
                        Cancelado = false,
                        Tipo = "Programado",
                        ServicioId = programacionServicio.ServicioId,
                        FechaServicio = fechaActual,
                        Servicio = programacionServicio.Servicio,
                        Clientes = programacionServicio.Clientes
                    };


                    await CrearAsync(servicio);
                }

                //Se agrega un dia a la fecha actual.
                //El contador de días se reinicia si se alcanza el ciclo de días o de mes
                dia++;
                if (cambioDeMes)
                {
                    if (fechaActual.AddDays(1).Month != fechaActual.Month)
                    {
                        mes++;
                    }
                    if (mes > mesCiclo)
                    {
                        mes = 1;
                        dia = 1;
                    }

                }
                else if (dia > diasCiclo)
                {
                    dia = 1;
                }
                fechaActual = fechaActual.AddDays(1);
            }

            //Se indica que ya se tienen servicios programados
            programacionServicio.ServiciosProgramados = true;
            await programacionServiciosClienteOperaciones.ActualizarAsync(programacionServicio);
        }


    }
}
