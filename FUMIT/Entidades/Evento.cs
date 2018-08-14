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

    // Eventos
    [Table("Eventos", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Evento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"EventoClienteId", Order = 1, TypeName = "int")]
        [Index(@"PK_Eventos", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Evento cliente ID")]
        public int EventoClienteId { get; set; } // EventoClienteId (Primary key)

        [Column(@"Codigo", Order = 2, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; } // Codigo (length: 5)

        [Column(@"Nombre", Order = 3, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Nombre (length: 50)

        [Column(@"Descripcion", Order = 4, TypeName = "varchar")]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // Descripcion (length: 250)

        [Column(@"Borrado", Order = 5, TypeName = "bit")]
        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        public Evento()
        {
            Borrado = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
