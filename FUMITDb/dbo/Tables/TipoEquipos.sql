CREATE TABLE [dbo].[TipoEquipos] (
    [TipoEquipoId] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]       VARCHAR (30)  NULL,
    [Descripcion]  VARCHAR (100) NULL,
    [Borrado]      BIT           CONSTRAINT [DF_TipoEquipos_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_TipoEquipos] PRIMARY KEY CLUSTERED ([TipoEquipoId] ASC)
);

