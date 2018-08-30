using System;
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
            CommonServiceLocator.ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaPrincipal());
        }
    }
}
