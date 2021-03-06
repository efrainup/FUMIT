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

    // GruposOperaciones
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Gruposoperacion: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [Required]
        [Display(Name = "Grupo operacion ID")]
        [Key]
        public int GrupoOperacionId { get; set; } // GrupoOperacionId (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Nombre (length: 250)

        [Required]
        [Display(Name = "Servicio ID")]
        public int ServicioId { get; set; } // ServicioId

        [Required]
        [Display(Name = "Servicios diarios")]
        public int ServiciosDiarios { get; set; } // ServiciosDiarios

        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Inicio operaciones")]
        public System.DateTime InicioOperaciones { get; set; } // InicioOperaciones

        [DataType(DataType.DateTime)]
        [Display(Name = "Fin operaciones")]
        public System.DateTime? FinOperaciones { get; set; } // FinOperaciones

        // Reverse navigation

        /// <summary>
        /// Child Grupooperacionclientes where [GrupoOperacionClientes].[GrupoOperacionId] point to this entity (FK_GrupoOperacionClientes_GruposOperaciones)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Grupooperacioncliente> Grupooperacionclientes { get; set; } // GrupoOperacionClientes.FK_GrupoOperacionClientes_GruposOperaciones

        // Foreign keys

        /// <summary>
        /// Parent Servicio pointed by [GruposOperaciones].([ServicioId]) (FK_GruposOperaciones_Servicios)
        /// </summary>
        public virtual Servicio Servicio { get; set; } // FK_GruposOperaciones_Servicios

        public Gruposoperacion()
        {
            Borrado = false;
            Activo = true;
            InicioOperaciones = System.DateTime.Now;
            Grupooperacionclientes = new System.Collections.Generic.List<Grupooperacioncliente>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
