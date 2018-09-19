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
    public partial class Operador: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [Required]
        [Display(Name = "Operador ID")]
        [Key]
        public int OperadorId { get; set; } // OperadorId (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Nombre (length: 250)

        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo

        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        [Required]
        [Display(Name = "Sucursal ID")]
        public int SucursalId { get; set; } // SucursalId

        // Reverse navigation

        /// <summary>
        /// Child Tickets where [Tickets].[AyudanteId] point to this entity (FK_Tickets_Operadores1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Ticket> Tickets_AyudanteId { get; set; } // Tickets.FK_Tickets_Operadores1
        /// <summary>
        /// Child Tickets where [Tickets].[OperadorId] point to this entity (FK_Tickets_Operadores)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Ticket> Tickets_OperadorId { get; set; } // Tickets.FK_Tickets_Operadores

        // Foreign keys

        /// <summary>
        /// Parent Sucursal pointed by [Operadores].([SucursalId]) (FK_Operadores_Sucursales)
        /// </summary>
        public virtual Sucursal Sucursal { get; set; } // FK_Operadores_Sucursales

        public Operador()
        {
            Activo = true;
            Borrado = false;
            Tickets_AyudanteId = new System.Collections.Generic.List<Ticket>();
            Tickets_OperadorId = new System.Collections.Generic.List<Ticket>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
