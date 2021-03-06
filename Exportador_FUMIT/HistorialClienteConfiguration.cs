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

    // HistorialCliente
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HistorialClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HistorialCliente>
    {
        public HistorialClienteConfiguration()
            : this("dbo")
        {
        }

        public HistorialClienteConfiguration(string schema)
        {
            ToTable("HistorialCliente", schema);
            HasKey(x => x.HistorialClienteId);

            Property(x => x.HistorialClienteId).HasColumnName(@"HistorialClienteId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired();
            Property(x => x.EventoClienteId).HasColumnName(@"EventoClienteId").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Observaciones).HasColumnName(@"Observaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Cliente).WithMany(b => b.HistorialClientes).HasForeignKey(c => c.ClienteId).WillCascadeOnDelete(false); // FK_HistorialCliente_Clientes
            HasRequired(a => a.Evento).WithMany(b => b.HistorialClientes).HasForeignKey(c => c.EventoClienteId).WillCascadeOnDelete(false); // FK_HistorialCliente_Eventos
        }
    }

}
// </auto-generated>
