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

    // ServiciosSucursales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Serviciossucursal: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [Required]
        [Display(Name = "Servicio sucursal ID")]
        [Key]
        public int ServicioSucursalId { get; set; } // ServicioSucursalId (Primary key)

        [Required]
        [Display(Name = "Sucursal ID")]
        public int SucursalId { get; set; } // SucursalId

        [Required]
        [Display(Name = "Servicio ID")]
        public int ServicioId { get; set; } // ServicioId

        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        [Required]
        [Display(Name = "Activo")]
        public bool Activo { get; set; } // Activo

        public Serviciossucursal()
        {
            Borrado = false;
            Activo = true;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
