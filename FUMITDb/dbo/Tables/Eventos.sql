CREATE TABLE [dbo].[Eventos] (
    [EventoClienteId] INT           IDENTITY (1, 1) NOT NULL,
    [Codigo]          VARCHAR (5)   NOT NULL,
    [Nombre]          VARCHAR (50)  NOT NULL,
    [Descripcion]     VARCHAR (250) NULL,
    [Borrado]         BIT           CONSTRAINT [DF_Eventos_Borrado] DEFAULT ((0)) NOT NULL,
    [Activo]          BIT           CONSTRAINT [DF_Eventos_Activo] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED ([EventoClienteId] ASC)
);



