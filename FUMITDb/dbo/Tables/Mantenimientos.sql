CREATE TABLE [dbo].[Mantenimientos] (
    [MantenimientoId]           INT           IDENTITY (1, 1) NOT NULL,
    [FechaProgramada]           DATETIME      NULL,
    [FechaEntradaMantenimiento] DATETIME      NULL,
    [FechaSalidaMantenimiento]  DATETIME      NULL,
    [Observaciones]             VARCHAR (250) NULL,
    [Activo]                    BIT           CONSTRAINT [DF_Mantenimientos_Activo] DEFAULT ((1)) NOT NULL,
    [Borrado]                   BIT           CONSTRAINT [DF_Mantenimientos_Borrado] DEFAULT ((0)) NOT NULL,
    [Realizado]                 BIT           CONSTRAINT [DF_Mantenimientos_Realizado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Mantenimientos] PRIMARY KEY CLUSTERED ([MantenimientoId] ASC)
);



