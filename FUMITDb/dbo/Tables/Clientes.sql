CREATE TABLE [dbo].[Clientes] (
    [ClienteId]          INT           IDENTITY (1, 1) NOT NULL,
    [SucursalId]         INT           NOT NULL,
    [Clave]              VARCHAR (10)  NULL,
    [Nombre]             VARCHAR (150) NULL,
    [NombreFiscal]       VARCHAR (180) NULL,
    [SucursalCliente]    VARCHAR (80)  NULL,
    [PersonaMoral]       BIT           CONSTRAINT [DF_Clientes_PersonaMoral] DEFAULT ((0)) NOT NULL,
    [RFC]                VARCHAR (13)  NULL,
    [Direccion]          VARCHAR (250) NULL,
    [DireccionFiscal]    VARCHAR (250) NULL,
    [Ubicacion]          VARCHAR (30)  NULL,
    [Contacto]           VARCHAR (300) NULL,
    [Telefono]           VARCHAR (300) NULL,
    [Correo]             VARCHAR (300) NULL,
    [FechaCreacion]      DATETIME      CONSTRAINT [DF_Clientes_FechaCreacion] DEFAULT (getdate()) NULL,
    [Observaciones]      VARCHAR (500) NULL,
    [RequiereManifiesto] BIT           CONSTRAINT [DF_Clientes_RequiereManifiesto] DEFAULT ((0)) NOT NULL,
    [Moroso]             BIT           NOT NULL,
    [Bloqueado]          BIT           NOT NULL,
    [Activo]             BIT           NOT NULL,
    [Borrado]            BIT           NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([ClienteId] ASC),
    CONSTRAINT [FK_Clientes_Sucursales] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([SucursalId])
);









