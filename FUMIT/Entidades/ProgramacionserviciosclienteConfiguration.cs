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

namespace FUMIT.Entidades
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    // ProgramacionServiciosClientes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ProgramacionserviciosclienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Programacionservicioscliente>
    {
        public ProgramacionserviciosclienteConfiguration()
            : this("dbo")
        {
        }

        public ProgramacionserviciosclienteConfiguration(string schema)
        {
            ToTable("ProgramacionServiciosClientes", schema);
            HasKey(x => x.ProgramacionServiciosClienteId);

            Property(x => x.ProgramacionServiciosClienteId).HasColumnName(@"ProgramacionServiciosClienteId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProgramacionServicioId).HasColumnName(@"ProgramacionServicioId").HasColumnType("int").IsRequired();
            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired();
            Property(x => x.FechaInicio).HasColumnName(@"FechaInicio").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaTermino).HasColumnName(@"FechaTermino").HasColumnType("datetime").IsOptional();
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();
            Property(x => x.ServicioId).HasColumnName(@"ServicioId").HasColumnType("int").IsRequired();
            Property(x => x.ServiciosProgramados).HasColumnName(@"ServiciosProgramados").HasColumnType("bit").IsRequired();
            Property(x => x.Area).HasColumnName(@"Area").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);

            // Foreign keys
            HasRequired(a => a.Clientes).WithMany(b => b.Programacionserviciosclientes).HasForeignKey(c => c.ClienteId).WillCascadeOnDelete(false); // FK_ProgramacionServiciosClientes_Clientes
            HasRequired(a => a.Programacionservicio).WithMany(b => b.Programacionserviciosclientes).HasForeignKey(c => c.ProgramacionServicioId).WillCascadeOnDelete(false); // FK_ProgramacionServiciosClientes_ProgramacionServicios
            HasRequired(a => a.Servicio).WithMany(b => b.Programacionserviciosclientes).HasForeignKey(c => c.ServicioId).WillCascadeOnDelete(false); // FK_ProgramacionServiciosClientes_Servicios
        }
    }

}
// </auto-generated>
