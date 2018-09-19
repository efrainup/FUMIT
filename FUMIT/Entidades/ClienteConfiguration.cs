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

    // Clientes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
            : this("dbo")
        {
        }

        public ClienteConfiguration(string schema)
        {
            ToTable("Clientes", schema);
            HasKey(x => x.ClienteId);

            Property(x => x.ClienteId).HasColumnName(@"ClienteId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SucursalId).HasColumnName(@"SucursalId").HasColumnType("int").IsRequired();
            Property(x => x.Clave).HasColumnName(@"Clave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NombreFiscal).HasColumnName(@"NombreFiscal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(180);
            Property(x => x.SucursalCliente).HasColumnName(@"SucursalCliente").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.PersonaMoral).HasColumnName(@"PersonaMoral").HasColumnType("bit").IsRequired();
            Property(x => x.Rfc).HasColumnName(@"RFC").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(13);
            Property(x => x.Direccion).HasColumnName(@"Direccion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.DireccionFiscal).HasColumnName(@"DireccionFiscal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Ubicacion).HasColumnName(@"Ubicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Contacto).HasColumnName(@"Contacto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Telefono).HasColumnName(@"Telefono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Correo).HasColumnName(@"Correo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsOptional();
            Property(x => x.Observaciones).HasColumnName(@"Observaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.RequiereManifiesto).HasColumnName(@"RequiereManifiesto").HasColumnType("bit").IsRequired();
            Property(x => x.Moroso).HasColumnName(@"Moroso").HasColumnType("bit").IsRequired();
            Property(x => x.Bloqueado).HasColumnName(@"Bloqueado").HasColumnType("bit").IsRequired();
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
            Property(x => x.Borrado).HasColumnName(@"Borrado").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sucursal).WithMany(b => b.Clientes).HasForeignKey(c => c.SucursalId).WillCascadeOnDelete(false); // FK_Clientes_Sucursales
        }
    }

}
// </auto-generated>
