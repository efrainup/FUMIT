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

    // MantenimientosEquipo
    [Table("MantenimientosEquipo", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class MantenimientosEquipo: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"MantenimientoEquipoId", Order = 1, TypeName = "int")]
        [Index(@"PK_MantenimientosEquipo", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Mantenimiento equipo ID")]
        public int MantenimientoEquipoId { get; set; } // MantenimientoEquipoId (Primary key)

        [Column(@"EquipoId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Equipo ID")]
        public int EquipoId { get; set; } // EquipoId

        [Column(@"MantenimientoId", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Mantenimiento ID")]
        public int MantenimientoId { get; set; } // MantenimientoId

        // Foreign keys

        /// <summary>
        /// Parent Equipo pointed by [MantenimientosEquipo].([EquipoId]) (FK_MantenimientosEquipo_Equipo)
        /// </summary>
        [ForeignKey("EquipoId"), Required] public virtual Equipo Equipo { get; set; } // FK_MantenimientosEquipo_Equipo

        /// <summary>
        /// Parent Mantenimiento pointed by [MantenimientosEquipo].([MantenimientoId]) (FK_MantenimientosEquipo_Mantenimientos)
        /// </summary>
        [ForeignKey("MantenimientoId"), Required] public virtual Mantenimiento Mantenimiento { get; set; } // FK_MantenimientosEquipo_Mantenimientos

        public MantenimientosEquipo()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
