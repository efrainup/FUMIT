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

    // Contactos
    [Table("Contactos", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Contacto: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ContactoId", Order = 1, TypeName = "int")]
        [Index(@"PK_Contactos", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Contacto ID")]
        public int ContactoId { get; set; } // ContactoId (Primary key)

        [Column(@"ClienteId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; } // ClienteId

        [Column(@"Nombre", Order = 3, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Nombre (length: 120)

        [Column(@"Telefono", Order = 4, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; } // Telefono (length: 100)

        [Column(@"Correo", Order = 5, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Correo")]
        public string Correo { get; set; } // Correo (length: 100)

        [Column(@"Tipo", Order = 6, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // Tipo (length: 20)

        [Column(@"Borrado", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        // Foreign keys

        /// <summary>
        /// Parent Clientes pointed by [Contactos].([ClienteId]) (FK_Contactos_Clientes)
        /// </summary>
        [ForeignKey("ClienteId"), Required] public virtual Cliente Clientes { get; set; } // FK_Contactos_Clientes

        public Contacto()
        {
            Borrado = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
