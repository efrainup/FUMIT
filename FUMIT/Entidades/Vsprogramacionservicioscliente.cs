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

    // vsProgramacionServiciosClientes
    [Table("vsProgramacionServiciosClientes", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Vsprogramacionservicioscliente: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProgramacionServiciosClienteId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Programacion servicios cliente ID")]
        public int ProgramacionServiciosClienteId { get; set; } // ProgramacionServiciosClienteId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProgramacionServicioId", Order = 2, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Programacion servicio ID")]
        public int ProgramacionServicioId { get; set; } // ProgramacionServicioId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ClienteId", Order = 3, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; } // ClienteId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FechaInicio", Order = 4, TypeName = "datetime")]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha inicio")]
        public System.DateTime FechaInicio { get; set; } // FechaInicio (Primary key)

        [Column(@"FechaTermino", Order = 5, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha termino")]
        public System.DateTime? FechaTermino { get; set; } // FechaTermino

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Activo", Order = 6, TypeName = "bit")]
        [Required]
        [Key]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Borrado", Order = 7, TypeName = "bit")]
        [Required]
        [Key]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ServicioId", Order = 8, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Servicio ID")]
        public int ServicioId { get; set; } // ServicioId (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Nombre", Order = 9, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Nombre (Primary key) (length: 50)

        [Column(@"NombreHorarioProgramado", Order = 10, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Nombre horario programado")]
        public string NombreHorarioProgramado { get; set; } // NombreHorarioProgramado (length: 50)

        [Column(@"Area", Order = 11, TypeName = "varchar")]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Area")]
        public string Area { get; set; } // Area (length: 80)

        public Vsprogramacionservicioscliente()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
