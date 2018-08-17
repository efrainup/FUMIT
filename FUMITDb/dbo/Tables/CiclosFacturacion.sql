CREATE TABLE [dbo].[CiclosFacturacion] (
    [CicloFacturacionId] INT           NOT NULL,
    [SucursalId]         INT           NOT NULL,
    [Dia]                VARCHAR (100) NOT NULL,
    [Semana]             INT           NOT NULL,
    [Mes]                INT           NOT NULL,
    [PorDefecto]         BIT           NOT NULL,
    [Activo]             BIT           NOT NULL,
    [Borrado]            BIT           NOT NULL,
    CONSTRAINT [PK_CiclosFacturacion] PRIMARY KEY CLUSTERED ([CicloFacturacionId] ASC),
    CONSTRAINT [FK_CiclosFacturacion_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([SucursalId])
);



