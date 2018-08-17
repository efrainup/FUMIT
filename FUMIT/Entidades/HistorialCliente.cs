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

    // HistorialCliente
    [Table("HistorialCliente", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class HistorialCliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"HistorialClienteId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Historial cliente ID")]
        public int HistorialClienteId { get; set; } // HistorialClienteId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ClienteId", Order = 2, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; } // ClienteId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"EventoClienteId", Order = 3, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Evento cliente ID")]
        public int EventoClienteId { get; set; } // EventoClienteId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Fecha", Order = 4, TypeName = "datetime")]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // Fecha (Primary key)

        [Column(@"Observaciones", Order = 5, TypeName = "varchar")]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; } // Observaciones (length: 250)

        public HistorialCliente()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
