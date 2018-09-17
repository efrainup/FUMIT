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


namespace Exportador_FUMIT
{

    // AsignacionesEquipos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class AsignacionesEquiposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AsignacionesEquipos>
    {
        public AsignacionesEquiposConfiguration()
            : this("dbo")
        {
        }

        public AsignacionesEquiposConfiguration(string schema)
        {
            ToTable("AsignacionesEquipos", schema);
            HasKey(x => x.AsignacionEquipoId);

            Property(x => x.AsignacionEquipoId).HasColumnName(@"AsignacionEquipoId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EquipoId).HasColumnName(@"EquipoId").HasColumnType("int").IsRequired();
            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired();
            Property(x => x.FechaAsignación).HasColumnName(@"FechaAsignación").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaEntrega).HasColumnName(@"FechaEntrega").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaRegreso).HasColumnName(@"FechaRegreso").HasColumnType("datetime").IsOptional();
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();
            Property(x => x.Ubicacion).HasColumnName(@"Ubicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(120);

            // Foreign keys
            HasRequired(a => a.Cliente).WithMany(b => b.AsignacionesEquipos).HasForeignKey(c => c.ClienteId).WillCascadeOnDelete(false); // FK_AsignacionesEquipos_Clientes
            HasRequired(a => a.Equipo).WithMany(b => b.AsignacionesEquipos).HasForeignKey(c => c.EquipoId).WillCascadeOnDelete(false); // FK_AsignacionesEquipos_Equipo
        }
    }

}
// </auto-generated>
