CREATE TABLE [dbo].[Servicios] (
    [ServicioId]  INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]      NVARCHAR (50)  NOT NULL,
    [Descripcion] NVARCHAR (250) NULL,
    [Activo]      BIT            NOT NULL,
    [Borrado]     BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ServicioId] ASC)
);

