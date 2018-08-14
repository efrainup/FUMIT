CREATE TABLE [dbo].[Sucursales] (
    [SucursalId] INT           IDENTITY (1, 1) NOT NULL,
    [Numero]     VARCHAR (5)   NULL,
    [Nombre]     VARCHAR (120) NOT NULL,
    [Direccion]  VARCHAR (250) NULL,
    [Estado]     VARCHAR (50)  NULL,
    [Ciudad]     VARCHAR (50)  NULL,
    [Activo]     BIT           CONSTRAINT [DF_Sucursales_Activo] DEFAULT ((1)) NOT NULL,
    [Borrado]    BIT           CONSTRAINT [DF_Sucursales_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Sucursales] PRIMARY KEY CLUSTERED ([SucursalId] ASC)
);

