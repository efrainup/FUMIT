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

    // Tickets
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Ticket: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [Required]
        [Display(Name = "Ticket ID")]
        [Key]
        public int TicketId { get; set; } // TicketId (Primary key)

        [Required]
        [Display(Name = "Servicio programado ID")]
        public int ServicioProgramadoId { get; set; } // ServicioProgramadoId

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Folio")]
        public string Folio { get; set; } // Folio (length: 10)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // Fecha

        [Required]
        [Display(Name = "Numero servicios")]
        public int NumeroServicios { get; set; } // NumeroServicios

        [Required]
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; } // ClienteId

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Unidad")]
        public string Unidad { get; set; } // Unidad (length: 10)

        [Display(Name = "Operador ID")]
        public int? OperadorId { get; set; } // OperadorId

        [Display(Name = "Ayudante ID")]
        public int? AyudanteId { get; set; } // AyudanteId

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Hora entrada")]
        public string HoraEntrada { get; set; } // HoraEntrada (length: 5)

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Horasalida")]
        public string Horasalida { get; set; } // Horasalida (length: 5)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; } // Observaciones (length: 250)

        [Required]
        [Display(Name = "Borrado")]
        public bool Borrado { get; set; } // Borrado

        [Required]
        [Display(Name = "Servicio ID")]
        public int ServicioId { get; set; } // ServicioId

        // Reverse navigation

        /// <summary>
        /// Child Contenedorestickets where [ContenedoresTickets].[TicketId] point to this entity (FK_ContenedoresTickets_Tickets)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Contenedoresticket> Contenedorestickets { get; set; } // ContenedoresTickets.FK_ContenedoresTickets_Tickets

        // Foreign keys

        /// <summary>
        /// Parent Clientes pointed by [Tickets].([ClienteId]) (FK_Tickets_Clientes)
        /// </summary>
        public virtual Cliente Clientes { get; set; } // FK_Tickets_Clientes

        /// <summary>
        /// Parent Operadores pointed by [Tickets].([AyudanteId]) (FK_Tickets_Operadores1)
        /// </summary>
        public virtual Operador Ayudante { get; set; } // FK_Tickets_Operadores1

        /// <summary>
        /// Parent Operadores pointed by [Tickets].([OperadorId]) (FK_Tickets_Operadores)
        /// </summary>
        public virtual Operador Operador { get; set; } // FK_Tickets_Operadores

        /// <summary>
        /// Parent Servicio pointed by [Tickets].([ServicioId]) (FK_Tickets_Servicios)
        /// </summary>
        public virtual Servicio Servicio { get; set; } // FK_Tickets_Servicios

        /// <summary>
        /// Parent Serviciosprogramado pointed by [Tickets].([ServicioProgramadoId]) (FK_Tickets_ServiciosProgramados)
        /// </summary>
        public virtual Serviciosprogramado Serviciosprogramado { get; set; } // FK_Tickets_ServiciosProgramados

        public Ticket()
        {
            Borrado = false;
            Contenedorestickets = new System.Collections.Generic.List<Contenedoresticket>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
