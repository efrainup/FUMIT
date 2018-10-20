using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class TicketsRepositorio : AOperacionesBase<Entidades.Ticket>, ITickets
    {
        #region Propiedades
        internal IServiciosProgramados ServiciosProgramadosRepositorio { get; set; }
        internal IOperadores OperadoresRepositorio { get; set; }
        #endregion

        public TicketsRepositorio()
        {
            ServiciosProgramadosRepositorio = ServiceLocator.Current.GetInstance<IServiciosProgramados>();
            OperadoresRepositorio = ServiceLocator.Current.GetInstance<IOperadores>();
        }

        public IEnumerable<Ticket> RecuperarTicketsPorCliente(int IdCliente)
        {
            return dbSet.Where(w => w.Borrado == false && w.ClienteId == IdCliente);
        }

        public IEnumerable<Ticket> RecuperarTicketsPorCliente(Cliente Cliente)
        {
            return Cliente.Tickets;
        }

        public override Ticket Crear(Ticket entidad)
        {
            Entidades.Serviciosprogramado serviciosprogramado = null;

            if (entidad.ServicioProgramadoId == 0 && entidad.Serviciosprogramado == null)
            {
                serviciosprogramado = dbContext.Serviciosprogramados.FirstOrDefault(w => w.ClienteId == entidad.ClienteId && w.ServicioId == entidad.ServicioId && w.FechaServicio == entidad.Fecha);

                if (serviciosprogramado == null)
                {
                    //Existe una programación?
                    int f = (int)entidad.Fecha.DayOfWeek + 1;
                    string diaCadena = f.ToString();

                    //Existe una programación?
                    var programacionCLiente = dbContext.Programacionserviciosclientes.FirstOrDefault(w => w.ClienteId == entidad.ClienteId && w.ServicioId == entidad.ServicioId && (w.FechaInicio <= entidad.Fecha && (w.FechaTermino == null || entidad.Fecha <= w.FechaTermino)) && w.Borrado == false && w.Activo == true && w.Programacionservicio.Dias.Contains(diaCadena));

                    serviciosprogramado = new Serviciosprogramado()
                    {
                        Borrado = false,
                        Activo = true,
                        Cancelado = false,
                        Prioridad = 1000,
                        ClienteId = entidad.ClienteId,
                        FechaServicio = entidad.Fecha.Date,
                        Observaciones = "",
                        ServicioId = entidad.ServicioId,
                        Tipo = programacionCLiente == null ? "Express" : "Programado",
                        ProgramacionServiciosClientesId = programacionCLiente == null ? null : (Nullable<int>)programacionCLiente.ProgramacionServiciosClienteId,
                        Clientes = entidad.Clientes,
                        Servicio = entidad.Servicio,
                        Realizado = true
                    };

                    //Se agrega servicio programado si no existe
                    serviciosprogramado = ServiciosProgramadosRepositorio.Crear(serviciosprogramado);
                    serviciosprogramado.ServicioProgramadoId = serviciosprogramado.ServicioProgramadoId;
                }
                

                //Se agrega el operador si no existe
                if (entidad.Operador != null && entidad.Operador.OperadorId == 0)
                {
                    entidad.Operador = OperadoresRepositorio.Crear(entidad.Operador);
                    entidad.OperadorId = entidad.Operador.OperadorId;
                }

                entidad.Serviciosprogramado = serviciosprogramado;
            }


            //El servicio programado hay que marcarlo como realizado sino lo está
            if (!serviciosprogramado.Realizado)
            {
                serviciosprogramado.Realizado = true;
                 ServiciosProgramadosRepositorio.Actualizar(serviciosprogramado);
            }

            return base.Crear(entidad);
        }

        public async override Task<Ticket> CrearAsync(Ticket entidad)
        {
            Entidades.Serviciosprogramado serviciosprogramado = entidad.Serviciosprogramado;

            //En caso de que no tenga un servicio programado hay que obtener el mas parecido o agregar uno nuevo
            if (entidad.ServicioProgramadoId == 0 && entidad.Serviciosprogramado == null)
            {
                serviciosprogramado = dbContext.Serviciosprogramados.FirstOrDefault(w => w.ClienteId == entidad.ClienteId && w.ServicioId == entidad.ServicioId && w.FechaServicio == entidad.Fecha );
                
                if (serviciosprogramado == null)
                {

                    //Existe una programación?
                    int f = (int)entidad.Fecha.DayOfWeek;
                    f = f == 0 ? 7 : f;
                    string diaCadena = f.ToString();
                    

                    var programacionCLiente = dbContext.Programacionserviciosclientes.FirstOrDefault(w => w.ClienteId == entidad.ClienteId && w.ServicioId == entidad.ServicioId && (w.FechaInicio <= entidad.Fecha && (w.FechaTermino == null || entidad.Fecha <= w.FechaTermino)) && w.Borrado == false && w.Activo == true && w.Programacionservicio.Dias.Contains(diaCadena));
                    
                    serviciosprogramado = new Serviciosprogramado()
                    {
                        Borrado = false,
                        Activo = true,
                        Cancelado = false,
                        Prioridad = 1000,
                        ClienteId = entidad.ClienteId,
                        FechaServicio = entidad.Fecha.Date,
                        Observaciones = "",
                        ServicioId = entidad.ServicioId,
                        Tipo = programacionCLiente == null ? "Express" : "Programado",
                        ProgramacionServiciosClientesId = programacionCLiente == null ? null : (Nullable<int>)programacionCLiente.ProgramacionServiciosClienteId,
                        Clientes = entidad.Clientes,
                        Servicio = entidad.Servicio,
                        Realizado = true
                    };

                    //Se agrega servicio programado si no existe
                    serviciosprogramado = await ServiciosProgramadosRepositorio.CrearAsync(serviciosprogramado);
                    serviciosprogramado.ServicioProgramadoId = serviciosprogramado.ServicioProgramadoId;
                }
                

                //Se agrega el operador si no existe
                if (entidad.Operador != null && entidad.Operador.OperadorId == 0)
                {
                    entidad.Operador = await OperadoresRepositorio.CrearAsync(entidad.Operador);
                    entidad.OperadorId = entidad.Operador.OperadorId;
                }

                entidad.Serviciosprogramado = serviciosprogramado;
            }

            //El servicio programado hay que marcarlo como realizado sino lo está
            if (!serviciosprogramado.Realizado)
            {
                serviciosprogramado.Realizado = true;
                await ServiciosProgramadosRepositorio.ActualizarAsync(serviciosprogramado);
            }


            return await base.CrearAsync(entidad);
        }

        public IEnumerable<Ticket> RecuperarTicketsPorServicioProgramado(int IdServicioProgramado)
        {
            return dbSet.Where(w => w.ServicioProgramadoId == IdServicioProgramado);
        }

        public IEnumerable<Ticket> RecuperarTicketsPorServicioProgramado(Serviciosprogramado ServicioProgramado)
        {
            return ServicioProgramado.Tickets;
        }
    }
}
