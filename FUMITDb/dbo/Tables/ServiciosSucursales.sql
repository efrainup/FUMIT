CREATE TABLE [dbo].[ServiciosSucursales] (
    [ServicioSucursalId] INT IDENTITY (1, 1) NOT NULL,
    [SucursalId]         INT NOT NULL,
    [ServicioId]         INT NOT NULL,
    [Borrado]            BIT CONSTRAINT [DF_ServiciosSucursales_Borrado] DEFAULT ((0)) NOT NULL,
    [Activo]             BIT CONSTRAINT [DF_ServiciosSucursales_Activo] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ServiciosSucursales] PRIMARY KEY CLUSTERED ([ServicioSucursalId] ASC)
);

