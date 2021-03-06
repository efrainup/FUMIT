﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonServiceLocator;
using FUMIT.AccesoDatos;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace FUMIT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Unity.UnityContainer container = new Unity.UnityContainer();
            Unity.ServiceLocation.UnityServiceLocator unityServiceLocator = new Unity.ServiceLocation.UnityServiceLocator(container);

            //Registrar tipos de operaciones con entidades
            container.RegisterInstance<FUMIT.Entidades.FumitDbContext>(new Entidades.FumitDbContext());
            container.RegisterType<AccesoDatos.IClientes, ClientesRepositorio>();
            container.RegisterType<AccesoDatos.ISucursales, SucursalesRepositorio>();
            container.RegisterType<IProgramacionServicios, ProgramacionServiciosRepositorio>();
            container.RegisterType<IProgramacionServiciosCliente, ProgramacionServiciosClienteRepositorio>();
            container.RegisterType<ICiclosFacturacion, CiclosFacturacionRepositorio>();
            container.RegisterType<IServiciosProgramados, ServiciosProgramadosRepositorio>();
            container.RegisterType<IServicio, ServiciosRepositorio>();
            container.RegisterType<IContactos, ContactosRepositorio>();
            container.RegisterType<IVSProgramacionServiciosCliente, VSProgramacionServiciosClienteRepositorio>();
            container.RegisterType<ICicloFacturacionClientes, CiclosFactuacionClienteRepositorio>();
            container.RegisterType<IEquipos, EquiposRepositorio>();
            container.RegisterType<ITipoEquipos, TipoEquiposRepositorio>();
            container.RegisterType<IAsignacionesEquipo, AsignacionesEquipoRepositorio>();
            container.RegisterType<IMantenimientos, MantenimientosRepositorio>();
            container.RegisterType<IMantenimientosEquipo, MantenimientosEquipoRepositorio>();
            container.RegisterType<ICalendarioSemanalServicios , CalendarioSemanalServiciosRepositorio>();
            container.RegisterType<IOperadores, OperadoresRepositorio>();
            container.RegisterType<ITickets, TicketsRepositorio>();
            container.RegisterType<IContenedoresTicket, ContenedoresTicketRepositorio>();

            //Se registra ExceptionManager
            Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.ExceptionManager manager = Exceptions.ExceptionHandlingPolicies.InicializarPoliticas();
            container.RegisterInstance(manager, new SingletonLifetimeManager()); 

            //Se registra service locator
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            //pantallaPrincipal.tsbEstado
            var notificador = new NotificadorBarraEstado(pantallaPrincipal.statusStrip1);
            notificador.ControlMostrarMensajes = pantallaPrincipal.tsbEstado;

            container.RegisterInstance<INotificador>("BarraDeEstado", notificador, new SingletonLifetimeManager());

            Application.Run(pantallaPrincipal);
        }
    }
}
