CREATE TABLE [dbo].[MantenimientosEquipo] (
    [MantenimientoEquipoId] INT IDENTITY (1, 1) NOT NULL,
    [EquipoId]              INT NOT NULL,
    [MantenimientoId]       INT NOT NULL,
    [Borrado]               BIT CONSTRAINT [DF_MantenimientosEquipo_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_MantenimientosEquipo] PRIMARY KEY CLUSTERED ([MantenimientoEquipoId] ASC),
    CONSTRAINT [FK_MantenimientosEquipo_Equipo] FOREIGN KEY ([EquipoId]) REFERENCES [dbo].[Equipo] ([EquipoId]),
    CONSTRAINT [FK_MantenimientosEquipo_Mantenimientos] FOREIGN KEY ([MantenimientoId]) REFERENCES [dbo].[Mantenimientos] ([MantenimientoId])
);



