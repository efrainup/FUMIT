CREATE TABLE [dbo].[ProgramacionServicios] (
    [ProgramacionServicioId] INT          IDENTITY (1, 1) NOT NULL,
    [SucursalId]             INT          NOT NULL,
    [Nombre]                 VARCHAR (50) NULL,
    [Dias]                   VARCHAR (50) NULL,
    [Semana]                 INT          NULL,
    [Mes]                    INT          NULL,
    [Activo]                 BIT          CONSTRAINT [DF_ProgramacionServicios_Activo] DEFAULT ((1)) NOT NULL,
    [Borrado]                BIT          CONSTRAINT [DF_ProgramacionServicios_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ProgramacionServicios] PRIMARY KEY CLUSTERED ([ProgramacionServicioId] ASC),
    CONSTRAINT [FK_ProgramacionServicios_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([SucursalId])
);



