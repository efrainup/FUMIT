CREATE TABLE [dbo].[Equipo] (
    [EquipoId]              INT           IDENTITY (1, 1) NOT NULL,
    [TipoEquipoId]          INT           NOT NULL,
    [NumeroEconomico]       VARCHAR (15)  NULL,
    [Estado]                VARCHAR (50)  NOT NULL,
    [RequiereMantenimiento] BIT           NOT NULL,
    [EnMantenimiento]       BIT           NOT NULL,
    [Observaciones]         VARCHAR (250) NULL,
    [Activo]                BIT           CONSTRAINT [DF_Equipo_Activo] DEFAULT ((1)) NOT NULL,
    [Borrado]               BIT           CONSTRAINT [DF_Equipo_Borrado] DEFAULT ((0)) NOT NULL,
    [Asignado]              BIT           CONSTRAINT [DF_Equipo_Asignado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Equipo] PRIMARY KEY CLUSTERED ([EquipoId] ASC),
    CONSTRAINT [FK_Equipo_TipoEquipos] FOREIGN KEY ([TipoEquipoId]) REFERENCES [dbo].[TipoEquipos] ([TipoEquipoId])
);



