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

    // Contactos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ContactoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Contacto>
    {
        public ContactoConfiguration()
            : this("dbo")
        {
        }

        public ContactoConfiguration(string schema)
        {
            ToTable("Contactos", schema);
            HasKey(x => x.ContactoId);

            Property(x => x.ContactoId).HasColumnName(@"ContactoId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Telefono).HasColumnName(@"Telefono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Correo).HasColumnName(@"Correo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Cliente).WithMany(b => b.Contactoes).HasForeignKey(c => c.ClienteId).WillCascadeOnDelete(false); // FK_Contactos_Clientes
        }
    }

}
// </auto-generated>
