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
            Property(x => x.Clave).IsUnicode(false);
            Property(x => x.Nombre).IsUnicode(false);
            Property(x => x.SucursalCliente).IsOptional().IsUnicode(false);
            Property(x => x.Rfc).IsUnicode(false);
            Property(x => x.Direccion).IsUnicode(false);
            Property(x => x.Ubicacion).IsOptional().IsUnicode(false);
            Property(x => x.Contacto).IsOptional().IsUnicode(false);
            Property(x => x.Telefono).IsOptional().IsUnicode(false);
            Property(x => x.Correo).IsOptional().IsUnicode(false);
            Property(x => x.Observaciones).IsOptional().IsUnicode(false);

        }
    }

}
// </auto-generated>