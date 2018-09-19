CREATE TABLE [dbo].[Operadores] (
    [OperadorId] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]     VARCHAR (250) NOT NULL,
    [Activo]     BIT           CONSTRAINT [DF_Operadores_Activo] DEFAULT ((1)) NOT NULL,
    [Borrado]    BIT           CONSTRAINT [DF_Operadores_Borrado] DEFAULT ((0)) NOT NULL,
    [SucursalId] INT           NOT NULL,
    CONSTRAINT [PK_Operadores] PRIMARY KEY CLUSTERED ([OperadorId] ASC),
    CONSTRAINT [FK_Operadores_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([SucursalId])
);

