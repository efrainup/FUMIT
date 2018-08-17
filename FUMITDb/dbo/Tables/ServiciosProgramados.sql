CREATE TABLE [dbo].[ServiciosProgramados] (
    [ServicioProgramadoId] INT          IDENTITY (1, 1) NOT NULL,
    [ClienteId]            INT          NOT NULL,
    [ServicioId]           INT          NOT NULL,
    [FechaServicio]        DATETIME     NOT NULL,
    [Tipo]                 VARCHAR (50) NULL,
    [Cancelado]            BIT          CONSTRAINT [DF_ServiciosProgramados_Cancelado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ServiciosProgramados] PRIMARY KEY CLUSTERED ([ServicioProgramadoId] ASC),
    CONSTRAINT [FK_ServiciosProgramados_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]),
    CONSTRAINT [FK_ServiciosProgramados_Servicios] FOREIGN KEY ([ServicioId]) REFERENCES [dbo].[Servicios] ([ServicioId])
);

