CREATE TABLE [dbo].[HistorialCliente] (
    [HistorialClienteId] INT           IDENTITY (1, 1) NOT NULL,
    [ClienteId]          INT           NOT NULL,
    [EventoClienteId]    INT           NOT NULL,
    [Fecha]              DATETIME      NOT NULL,
    [Observaciones]      VARCHAR (250) NULL
);

