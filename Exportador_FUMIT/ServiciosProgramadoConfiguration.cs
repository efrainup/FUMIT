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

    // ServiciosProgramados
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ServiciosProgramadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ServiciosProgramado>
    {
        public ServiciosProgramadoConfiguration()
            : this("dbo")
        {
        }

        public ServiciosProgramadoConfiguration(string schema)
        {
            ToTable("ServiciosProgramados", schema);
            HasKey(x => x.ServicioProgramadoId);

            Property(x => x.ServicioProgramadoId).HasColumnName(@"ServicioProgramadoId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired();
            Property(x => x.ServicioId).HasColumnName(@"ServicioId").HasColumnType("int").IsRequired();
            Property(x => x.FechaServicio).HasColumnName(@"FechaServicio").HasColumnType("datetime").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cancelado).HasColumnName(@"Cancelado").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Cliente).WithMany(b => b.ServiciosProgramadoes).HasForeignKey(c => c.ClienteId).WillCascadeOnDelete(false); // FK_ServiciosProgramados_Clientes
            HasRequired(a => a.Servicio).WithMany(b => b.ServiciosProgramadoes).HasForeignKey(c => c.ServicioId).WillCascadeOnDelete(false); // FK_ServiciosProgramados_Servicios
        }
    }

}
// </auto-generated>
