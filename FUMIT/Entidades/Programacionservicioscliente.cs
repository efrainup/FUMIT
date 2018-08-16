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

    // ProgramacionServiciosClientes
    [Table("ProgramacionServiciosClientes", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Programacionservicioscliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProgramacionServiciosClienteId", Order = 1, TypeName = "int")]
        [Index(@"PK_ProgramacionServiciosClientes", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Programacion servicios cliente ID")]
        public int ProgramacionServiciosClienteId { get; set; } // ProgramacionServiciosClienteId (Primary key)

        [Column(@"ProgramacionServicioId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Programacion servicio ID")]
        public int ProgramacionServicioId { get; set; } // ProgramacionServicioId

        [Column(@"ClienteId", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; } // ClienteId

        [Column(@"FechaInicio", Order = 4, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha inicio")]
        public System.DateTime FechaInicio { get; set; } // FechaInicio

        [Column(@"FechaTermino", Order = 5, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha termino")]
        public System.DateTime? FechaTermino { get; set; } // FechaTermino

        [Column(@"Activo", Order = 6, TypeName = "bit")]
        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo

        [Column(@"Borrado", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        // Foreign keys

        /// <summary>
        /// Parent Clientes pointed by [ProgramacionServiciosClientes].([ClienteId]) (FK_ProgramacionServiciosClientes_Clientes)
        /// </summary>
        [ForeignKey("ClienteId"), Required] public virtual Cliente Clientes { get; set; } // FK_ProgramacionServiciosClientes_Clientes

        /// <summary>
        /// Parent Programacionservicio pointed by [ProgramacionServiciosClientes].([ProgramacionServicioId]) (FK_ProgramacionServiciosClientes_ProgramacionServicios)
        /// </summary>
        [ForeignKey("ProgramacionServicioId"), Required] public virtual Programacionservicio Programacionservicio { get; set; } // FK_ProgramacionServiciosClientes_ProgramacionServicios

        public Programacionservicioscliente()
        {
            Activo = true;
            Borrado = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
