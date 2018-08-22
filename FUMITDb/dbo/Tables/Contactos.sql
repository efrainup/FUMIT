CREATE TABLE [dbo].[Contactos] (
    [ContactoId] INT           IDENTITY (1, 1) NOT NULL,
    [ClienteId]  INT           NOT NULL,
    [Nombre]     VARCHAR (120) NOT NULL,
    [Telefono]   VARCHAR (100) NULL,
    [Correo]     VARCHAR (100) NULL,
    [Tipo]       VARCHAR (20)  NULL,
    CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED ([ContactoId] ASC),
    CONSTRAINT [FK_Contactos_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId])
);



