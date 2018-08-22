// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FUMIT.Entidades
{
    using System.ComponentModel;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FumitDbContext : System.Data.Entity.DbContext, IFumitDbContext
    {
        public System.Data.Entity.DbSet<CicloFacturacionCliente> Ciclofacturacionclientes { get; set; } // CicloFacturacionCliente
        public System.Data.Entity.DbSet<CiclosFacturacion> Ciclosfacturaciones { get; set; } // CiclosFacturacion
        public System.Data.Entity.DbSet<Cliente> Clientes { get; set; } // Clientes
        public System.Data.Entity.DbSet<Contacto> Contactos { get; set; } // Contactos
        public System.Data.Entity.DbSet<Evento> Eventos { get; set; } // Eventos
        public System.Data.Entity.DbSet<HistorialCliente> Historialclientes { get; set; } // HistorialCliente
        public System.Data.Entity.DbSet<Programacionservicio> Programacionservicios { get; set; } // ProgramacionServicios
        public System.Data.Entity.DbSet<Programacionservicioscliente> Programacionserviciosclientes { get; set; } // ProgramacionServiciosClientes
        public System.Data.Entity.DbSet<Servicio> Servicios { get; set; } // Servicios
        public System.Data.Entity.DbSet<Serviciosprogramado> Serviciosprogramados { get; set; } // ServiciosProgramados
        public System.Data.Entity.DbSet<Serviciossucursal> Serviciossucursales { get; set; } // ServiciosSucursales
        public System.Data.Entity.DbSet<Sucursal> Sucursales { get; set; } // Sucursales
        public System.Data.Entity.DbSet<Vsprogramacionservicioscliente> Vsprogramacionserviciosclientes { get; set; } // vsProgramacionServiciosClientes

        static FumitDbContext()
        {
            System.Data.Entity.Database.SetInitializer<FumitDbContext>(null);
        }

        public FumitDbContext()
            : base("Name=FUMIT")
        {
        }

        public FumitDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public FumitDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public FumitDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public FumitDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CicloFacturacionClienteConfiguration());
            modelBuilder.Configurations.Add(new CiclosFacturacionConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ContactoConfiguration());
            modelBuilder.Configurations.Add(new EventoConfiguration());
            modelBuilder.Configurations.Add(new HistorialClienteConfiguration());
            modelBuilder.Configurations.Add(new ProgramacionservicioConfiguration());
            modelBuilder.Configurations.Add(new ProgramacionserviciosclienteConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new ServiciosprogramadoConfiguration());
            modelBuilder.Configurations.Add(new ServiciossucursalConfiguration());
            modelBuilder.Configurations.Add(new SucursalConfiguration());
            modelBuilder.Configurations.Add(new VsprogramacionserviciosclienteConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CicloFacturacionClienteConfiguration(schema));
            modelBuilder.Configurations.Add(new CiclosFacturacionConfiguration(schema));
            modelBuilder.Configurations.Add(new ClienteConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactoConfiguration(schema));
            modelBuilder.Configurations.Add(new EventoConfiguration(schema));
            modelBuilder.Configurations.Add(new HistorialClienteConfiguration(schema));
            modelBuilder.Configurations.Add(new ProgramacionservicioConfiguration(schema));
            modelBuilder.Configurations.Add(new ProgramacionserviciosclienteConfiguration(schema));
            modelBuilder.Configurations.Add(new ServicioConfiguration(schema));
            modelBuilder.Configurations.Add(new ServiciosprogramadoConfiguration(schema));
            modelBuilder.Configurations.Add(new ServiciossucursalConfiguration(schema));
            modelBuilder.Configurations.Add(new SucursalConfiguration(schema));
            modelBuilder.Configurations.Add(new VsprogramacionserviciosclienteConfiguration(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>
