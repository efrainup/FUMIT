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

    // Mantenimientos
    [Table("Mantenimientos", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Mantenimiento: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"MantenimientoId", Order = 1, TypeName = "int")]
        [Index(@"PK_Mantenimientos", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Mantenimiento ID")]
        public int MantenimientoId { get; set; } // MantenimientoId (Primary key)

        [Column(@"FechaProgramada", Order = 2, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha programada")]
        public System.DateTime? FechaProgramada { get; set; } // FechaProgramada

        [Column(@"FechaEntradaMantenimiento", Order = 3, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha entrada mantenimiento")]
        public System.DateTime? FechaEntradaMantenimiento { get; set; } // FechaEntradaMantenimiento

        [Column(@"FechaSalidaMantenimiento", Order = 4, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha salida mantenimiento")]
        public System.DateTime? FechaSalidaMantenimiento { get; set; } // FechaSalidaMantenimiento

        [Column(@"Observaciones", Order = 5, TypeName = "varchar")]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; } // Observaciones (length: 250)

        [Column(@"Activo", Order = 6, TypeName = "bit")]
        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo

        [Column(@"Borrado", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        [Column(@"Realizado", Order = 8, TypeName = "bit")]
        [Required]
        [Display(Name = "Realizado")]
        public bool Realizado { get; set; } // Realizado

        // Reverse navigation

        /// <summary>
        /// Child Mantenimientosequipos where [MantenimientosEquipo].[MantenimientoId] point to this entity (FK_MantenimientosEquipo_Mantenimientos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<MantenimientosEquipo> Mantenimientosequipos { get; set; } // MantenimientosEquipo.FK_MantenimientosEquipo_Mantenimientos

        public Mantenimiento()
        {
            Activo = false;
            Borrado = false;
            Realizado = false;
            Mantenimientosequipos = new System.Collections.Generic.List<MantenimientosEquipo>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
