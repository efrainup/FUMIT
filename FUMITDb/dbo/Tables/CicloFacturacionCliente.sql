CREATE TABLE [dbo].[CicloFacturacionCliente] (
    [CicloFacturacionClienteId] INT      IDENTITY (1, 1) NOT NULL,
    [CicloFacturacionId]        INT      NOT NULL,
    [ServicioId]                INT      NOT NULL,
    [FechaInicioVigencia]       DATETIME NOT NULL,
    [FechaFinVigencia]          DATETIME NOT NULL,
    [Activo]                    BIT      NOT NULL,
    [Borrado]                   BIT      NOT NULL,
    CONSTRAINT [PK_CicloFacturacionCliente] PRIMARY KEY CLUSTERED ([CicloFacturacionClienteId] ASC),
    CONSTRAINT [FK_CicloFacturacionCliente_CicloFacturacionCliente] FOREIGN KEY ([CicloFacturacionId]) REFERENCES [dbo].[CiclosFacturacion] ([CicloFacturacionId])
);

