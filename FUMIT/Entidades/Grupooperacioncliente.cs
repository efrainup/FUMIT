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

    // GrupoOperacionClientes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Grupooperacioncliente: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [Required]
        [Display(Name = "Grupo operacion cliente ID")]
        [Key]
        public int GrupoOperacionClienteId { get; set; } // GrupoOperacionClienteId (Primary key)

        [Required]
        [Display(Name = "Grupo operacion ID")]
        public int GrupoOperacionId { get; set; } // GrupoOperacionId

        [Required]
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; } // ClienteId

        [Required]
        [Display(Name = "Orden")]
        public int Orden { get; set; } // Orden

        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        // Foreign keys

        /// <summary>
        /// Parent Clientes pointed by [GrupoOperacionClientes].([ClienteId]) (FK_GrupoOperacionClientes_Clientes)
        /// </summary>
        public virtual Cliente Clientes { get; set; } // FK_GrupoOperacionClientes_Clientes

        /// <summary>
        /// Parent Gruposoperacion pointed by [GrupoOperacionClientes].([GrupoOperacionId]) (FK_GrupoOperacionClientes_GruposOperaciones)
        /// </summary>
        public virtual Gruposoperacion Gruposoperacion { get; set; } // FK_GrupoOperacionClientes_GruposOperaciones

        public Grupooperacioncliente()
        {
            Orden = 0;
            Borrado = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
