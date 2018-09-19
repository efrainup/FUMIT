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

    // vsProgramacionServiciosClientes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VsprogramacionserviciosclienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vsprogramacionservicioscliente>
    {
        public VsprogramacionserviciosclienteConfiguration()
            : this("dbo")
        {
        }

        public VsprogramacionserviciosclienteConfiguration(string schema)
        {
            ToTable("vsProgramacionServiciosClientes", schema);
            HasKey(x => new { x.ProgramacionServiciosClienteId, x.ProgramacionServicioId, x.ClienteId, x.FechaInicio, x.Activo, x.Borrado, x.ServicioId, x.Nombre });

            Property(x => x.ProgramacionServiciosClienteId).HasColumnName(@"ProgramacionServiciosClienteId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProgramacionServicioId).HasColumnName(@"ProgramacionServicioId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FechaInicio).HasColumnName(@"FechaInicio").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FechaTermino).HasColumnName(@"FechaTermino").HasColumnType("datetime").IsOptional();
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ServicioId).HasColumnName(@"ServicioId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NombreHorarioProgramado).HasColumnName(@"NombreHorarioProgramado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Area).HasColumnName(@"Area").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
        }
    }

}
// </auto-generated>
