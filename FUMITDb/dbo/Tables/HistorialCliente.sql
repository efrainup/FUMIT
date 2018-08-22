CREATE TABLE [dbo].[HistorialCliente] (
    [HistorialClienteId] INT           IDENTITY (1, 1) NOT NULL,
    [ClienteId]          INT           NOT NULL,
    [EventoClienteId]    INT           NOT NULL,
    [Fecha]              DATETIME      NOT NULL,
    [Observaciones]      VARCHAR (250) NULL,
    [Borrado]            BIT           CONSTRAINT [DF_HistorialCliente_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_HistorialCliente] PRIMARY KEY CLUSTERED ([HistorialClienteId] ASC),
    CONSTRAINT [FK_HistorialCliente_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]),
    CONSTRAINT [FK_HistorialCliente_Eventos] FOREIGN KEY ([EventoClienteId]) REFERENCES [dbo].[Eventos] ([EventoClienteId])
);





