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

    // Mantenimientos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MantenimientoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mantenimiento>
    {
        public MantenimientoConfiguration()
            : this("dbo")
        {
        }

        public MantenimientoConfiguration(string schema)
        {
            ToTable("Mantenimientos", schema);
            HasKey(x => x.MantenimientoId);

            Property(x => x.MantenimientoId).HasColumnName(@"MantenimientoId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FechaProgramada).HasColumnName(@"FechaProgramada").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaEntradaMantenimiento).HasColumnName(@"FechaEntradaMantenimiento").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaSalidaMantenimiento).HasColumnName(@"FechaSalidaMantenimiento").HasColumnType("datetime").IsOptional();
            Property(x => x.Observaciones).HasColumnName(@"Observaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();
            Property(x => x.Realizado).HasColumnName(@"Realizado").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
