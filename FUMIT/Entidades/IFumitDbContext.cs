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
    using System.Runtime.Serialization;

    public interface IFumitDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<CicloFacturacionCliente> Ciclofacturacionclientes { get; set; } // CicloFacturacionCliente
        System.Data.Entity.DbSet<CiclosFacturacion> Ciclosfacturaciones { get; set; } // CiclosFacturacion
        System.Data.Entity.DbSet<Cliente> Clientes { get; set; } // Clientes
        System.Data.Entity.DbSet<Evento> Eventos { get; set; } // Eventos
        System.Data.Entity.DbSet<HistorialCliente> Historialclientes { get; set; } // HistorialCliente
        System.Data.Entity.DbSet<Servicio> Servicios { get; set; } // Servicios
        System.Data.Entity.DbSet<Sucursal> Sucursales { get; set; } // Sucursales

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

}
// </auto-generated>
