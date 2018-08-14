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

    // CiclosFacturacion
    [Table("CiclosFacturacion", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class CiclosFacturacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CicloFacturacionId", Order = 1, TypeName = "int")]
        [Index(@"PK_CiclosFacturacion", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Ciclo facturacion ID")]
        public int CicloFacturacionId { get; set; } // CicloFacturacionId (Primary key)

        [Column(@"SucursalId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Sucursal ID")]
        public int SucursalId { get; set; } // SucursalId

        [Column(@"Dia", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Dia")]
        public int Dia { get; set; } // Dia

        [Column(@"Semana", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Semana")]
        public int Semana { get; set; } // Semana

        [Column(@"Mes", Order = 5, TypeName = "int")]
        [Required]
        [Display(Name = "Mes")]
        public int Mes { get; set; } // Mes

        [Column(@"PorDefecto", Order = 6, TypeName = "bit")]
        [Required]
        [Display(Name = "Por defecto")]
        public bool PorDefecto { get; set; } // PorDefecto

        [Column(@"Activo", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo

        [Column(@"Borrado", Order = 8, TypeName = "bit")]
        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        // Reverse navigation

        /// <summary>
        /// Child Ciclofacturacionclientes where [CicloFacturacionCliente].[CicloFacturacionId] point to this entity (FK_CicloFacturacionCliente_CicloFacturacionCliente)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CicloFacturacionCliente> Ciclofacturacionclientes { get; set; } // CicloFacturacionCliente.FK_CicloFacturacionCliente_CicloFacturacionCliente

        // Foreign keys

        /// <summary>
        /// Parent Sucursal pointed by [CiclosFacturacion].([SucursalId]) (FK_CiclosFacturacion_Sucursales)
        /// </summary>
        [ForeignKey("SucursalId"), Required] public virtual Sucursal Sucursal { get; set; } // FK_CiclosFacturacion_Sucursales

        public CiclosFacturacion()
        {
            Ciclofacturacionclientes = new System.Collections.Generic.List<CicloFacturacionCliente>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
