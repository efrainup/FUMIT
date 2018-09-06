CREATE TABLE [dbo].[ServiciosProgramados] (
    [ServicioProgramadoId]            INT           IDENTITY (1, 1) NOT NULL,
    [ClienteId]                       INT           NOT NULL,
    [ServicioId]                      INT           NOT NULL,
    [FechaServicio]                   DATETIME      NOT NULL,
    [Tipo]                            VARCHAR (50)  NULL,
    [Cancelado]                       BIT           CONSTRAINT [DF_ServiciosProgramados_Cancelado] DEFAULT ((0)) NOT NULL,
    [Borrado]                         BIT           CONSTRAINT [DF_ServiciosProgramados_Borrado] DEFAULT ((0)) NOT NULL,
    [Activo]                          BIT           CONSTRAINT [DF_ServiciosProgramados_Activo] DEFAULT ((1)) NOT NULL,
    [Prioridad]                       INT           CONSTRAINT [DF_ServiciosProgramados_Prioridad] DEFAULT ((1000)) NOT NULL,
    [Observaciones]                   VARCHAR (250) NULL,
    [ProgramacionServiciosClientesId] INT           NULL,
    CONSTRAINT [PK_ServiciosProgramados] PRIMARY KEY CLUSTERED ([ServicioProgramadoId] ASC),
    CONSTRAINT [FK_ServiciosProgramados_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]),
    CONSTRAINT [FK_ServiciosProgramados_ProgramacionServiciosClientes] FOREIGN KEY ([ProgramacionServiciosClientesId]) REFERENCES [dbo].[ProgramacionServiciosClientes] ([ProgramacionServiciosClienteId]),
    CONSTRAINT [FK_ServiciosProgramados_Servicios] FOREIGN KEY ([ServicioId]) REFERENCES [dbo].[Servicios] ([ServicioId])
);







