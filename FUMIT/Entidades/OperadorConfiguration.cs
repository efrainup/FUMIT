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

    // Operadores
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class OperadorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Operador>
    {
        public OperadorConfiguration()
            : this("dbo")
        {
        }

        public OperadorConfiguration(string schema)
        {
            ToTable("Operadores", schema);
            HasKey(x => x.OperadorId);

            Property(x => x.OperadorId).HasColumnName(@"OperadorId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();
            Property(x => x.SucursalId).HasColumnName(@"SucursalId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sucursal).WithMany(b => b.Operadores).HasForeignKey(c => c.SucursalId).WillCascadeOnDelete(false); // FK_Operadores_Sucursales
        }
    }

}
// </auto-generated>