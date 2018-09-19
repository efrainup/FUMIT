CREATE TABLE [dbo].[Tickets] (
    [TicketId]             INT           IDENTITY (1, 1) NOT NULL,
    [ServicioProgramadoId] INT           NOT NULL,
    [Folio]                VARCHAR (10)  NOT NULL,
    [Fecha]                DATETIME      NOT NULL,
    [NumeroServicios]      INT           NOT NULL,
    [ClienteId]            INT           NOT NULL,
    [Unidad]               VARCHAR (10)  NULL,
    [OperadorId]           INT           NULL,
    [AyudanteId]           INT           NULL,
    [HoraEntrada]          VARCHAR (5)   NULL,
    [Horasalida]           VARCHAR (5)   NULL,
    [Observaciones]        VARCHAR (250) NULL,
    [Borrado]              BIT           CONSTRAINT [DF_Tickets_Borrado] DEFAULT ((0)) NOT NULL,
    [ServicioId]           INT           NOT NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED ([TicketId] ASC),
    CONSTRAINT [FK_Tickets_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]),
    CONSTRAINT [FK_Tickets_Operadores] FOREIGN KEY ([OperadorId]) REFERENCES [dbo].[Operadores] ([OperadorId]),
    CONSTRAINT [FK_Tickets_Operadores1] FOREIGN KEY ([AyudanteId]) REFERENCES [dbo].[Operadores] ([OperadorId]),
    CONSTRAINT [FK_Tickets_Servicios] FOREIGN KEY ([ServicioId]) REFERENCES [dbo].[Servicios] ([ServicioId]),
    CONSTRAINT [FK_Tickets_ServiciosProgramados] FOREIGN KEY ([ServicioProgramadoId]) REFERENCES [dbo].[ServiciosProgramados] ([ServicioProgramadoId])
);

