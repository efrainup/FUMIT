CREATE TABLE [dbo].[ProgramacionServicios] (
    [ProgramacionServicioId] INT          IDENTITY (1, 1) NOT NULL,
    [SucursalId]             INT          NOT NULL,
    [Nombre]                 VARCHAR (50) NULL,
    [Dias]                   VARCHAR (50) NULL,
    [Semana]                 INT          NULL,
    [Mes]                    INT          NULL,
    CONSTRAINT [PK_ProgramacionServicios] PRIMARY KEY CLUSTERED ([ProgramacionServicioId] ASC),
    CONSTRAINT [FK_ProgramacionServicios_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([SucursalId])
);

