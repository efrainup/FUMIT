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
    using System.ComponentModel;
    using System.Runtime.Serialization;

    // CiclosFacturacion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CiclosFacturacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CiclosFacturacion>
    {
        public CiclosFacturacionConfiguration()
            : this("dbo")
        {
        }

        public CiclosFacturacionConfiguration(string schema)
        {
            Property(x => x.Dia).IsUnicode(false);
            Property(x => x.Nombre).IsOptional().IsUnicode(false);

        }
    }

}
// </auto-generated>
