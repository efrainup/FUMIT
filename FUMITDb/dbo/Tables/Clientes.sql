CREATE TABLE [dbo].[Clientes] (
    [ClienteId]       INT           IDENTITY (1, 1) NOT NULL,
    [SucursalId]      INT           NOT NULL,
    [Clave]           VARCHAR (10)  NOT NULL,
    [Nombre]          VARCHAR (150) NOT NULL,
    [SucursalCliente] VARCHAR (80)  NULL,
    [RFC]             VARCHAR (13)  NOT NULL,
    [Direccion]       VARCHAR (150) NOT NULL,
    [Ubicacion]       VARCHAR (30)  NULL,
    [Contacto]        VARCHAR (80)  NULL,
    [Telefono]        VARCHAR (80)  NULL,
    [Correo]          VARCHAR (80)  NULL,
    [FechaCreacion]   DATETIME      NOT NULL,
    [Observaciones]   VARCHAR (250) NULL,
    [Moroso]          BIT           NOT NULL,
    [Bloqueado]       BIT           NOT NULL,
    [Activo]          BIT           NOT NULL,
    [Borrado]         BIT           NOT NULL,
    CONSTRAINT [FK_Clientes_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([SucursalId])
);

