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


namespace Exportador_FUMIT
{

    // Sucursales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Sucursale
    {
        public int SucursalId { get; set; } // SucursalId (Primary key)
        public string Numero { get; set; } // Numero (length: 5)
        public string Nombre { get; set; } // Nombre (length: 120)
        public string Direccion { get; set; } // Direccion (length: 250)
        public string Estado { get; set; } // Estado (length: 50)
        public string Ciudad { get; set; } // Ciudad (length: 50)
        public bool Activo { get; set; } // Activo
        public bool Borrado { get; set; } // Borrado

        // Reverse navigation

        /// <summary>
        /// Child CiclosFacturacions where [CiclosFacturacion].[SucursalId] point to this entity (FK_CiclosFacturacion_Sucursales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CiclosFacturacion> CiclosFacturacions { get; set; } // CiclosFacturacion.FK_CiclosFacturacion_Sucursales
        /// <summary>
        /// Child Clientes where [Clientes].[SucursalId] point to this entity (FK_Clientes_Sucursales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Cliente> Clientes { get; set; } // Clientes.FK_Clientes_Sucursales
        /// <summary>
        /// Child ProgramacionServicios where [ProgramacionServicios].[SucursalId] point to this entity (FK_ProgramacionServicios_Sucursales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProgramacionServicio> ProgramacionServicios { get; set; } // ProgramacionServicios.FK_ProgramacionServicios_Sucursales

        public Sucursale()
        {
            Activo = true;
            Borrado = false;
            CiclosFacturacions = new System.Collections.Generic.List<CiclosFacturacion>();
            Clientes = new System.Collections.Generic.List<Cliente>();
            ProgramacionServicios = new System.Collections.Generic.List<ProgramacionServicio>();
        }
    }

}
// </auto-generated>
