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

    // Sucursales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SucursalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sucursal>
    {
        public SucursalConfiguration()
            : this("dbo")
        {
        }

        public SucursalConfiguration(string schema)
        {
            Property(x => x.Numero).IsOptional().IsUnicode(false);
            Property(x => x.Nombre).IsUnicode(false);
            Property(x => x.Direccion).IsOptional().IsUnicode(false);
            Property(x => x.Estado).IsOptional().IsUnicode(false);
            Property(x => x.Ciudad).IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>
