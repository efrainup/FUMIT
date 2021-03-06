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

    // ProgramacionServiciosClientes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ProgramacionServiciosCliente
    {
        public int ProgramacionServiciosClienteId { get; set; } // ProgramacionServiciosClienteId (Primary key)
        public int ProgramacionServicioId { get; set; } // ProgramacionServicioId
        public int ClienteId { get; set; } // ClienteId
        public System.DateTime FechaInicio { get; set; } // FechaInicio
        public System.DateTime? FechaTermino { get; set; } // FechaTermino
        public bool Activo { get; set; } // Activo
        public bool Borrado { get; set; } // Borrado
        public int ServicioId { get; set; } // ServicioId
        public bool ServiciosProgramados { get; set; } // ServiciosProgramados

        // Reverse navigation

        /// <summary>
        /// Child ServiciosProgramadoes where [ServiciosProgramados].[ProgramacionServiciosClientesId] point to this entity (FK_ServiciosProgramados_ProgramacionServiciosClientes)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ServiciosProgramado> ServiciosProgramadoes { get; set; } // ServiciosProgramados.FK_ServiciosProgramados_ProgramacionServiciosClientes

        // Foreign keys

        /// <summary>
        /// Parent Cliente pointed by [ProgramacionServiciosClientes].([ClienteId]) (FK_ProgramacionServiciosClientes_Clientes)
        /// </summary>
        public virtual Cliente Cliente { get; set; } // FK_ProgramacionServiciosClientes_Clientes

        /// <summary>
        /// Parent ProgramacionServicio pointed by [ProgramacionServiciosClientes].([ProgramacionServicioId]) (FK_ProgramacionServiciosClientes_ProgramacionServicios)
        /// </summary>
        public virtual ProgramacionServicio ProgramacionServicio { get; set; } // FK_ProgramacionServiciosClientes_ProgramacionServicios

        /// <summary>
        /// Parent Servicio pointed by [ProgramacionServiciosClientes].([ServicioId]) (FK_ProgramacionServiciosClientes_Servicios)
        /// </summary>
        public virtual Servicio Servicio { get; set; } // FK_ProgramacionServiciosClientes_Servicios

        public ProgramacionServiciosCliente()
        {
            FechaInicio = System.DateTime.Now;
            Activo = true;
            Borrado = false;
            ServiciosProgramados = false;
            ServiciosProgramadoes = new System.Collections.Generic.List<ServiciosProgramado>();
        }
    }

}
// </auto-generated>
