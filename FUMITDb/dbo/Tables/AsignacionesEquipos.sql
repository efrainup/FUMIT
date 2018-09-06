CREATE TABLE [dbo].[AsignacionesEquipos] (
    [AsignacionEquipoId] INT           IDENTITY (1, 1) NOT NULL,
    [EquipoId]           INT           NOT NULL,
    [ClienteId]          INT           NOT NULL,
    [FechaAsignación]    DATETIME      NULL,
    [FechaEntrega]       DATETIME      NULL,
    [FechaRegreso]       DATETIME      NULL,
    [Borrado]            BIT           CONSTRAINT [DF_AsignacionesEquipos_Borrado] DEFAULT ((0)) NOT NULL,
    [Ubicacion]          VARCHAR (120) NULL,
    CONSTRAINT [PK_AsignacionesEquipos] PRIMARY KEY CLUSTERED ([AsignacionEquipoId] ASC),
    CONSTRAINT [FK_AsignacionesEquipos_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]),
    CONSTRAINT [FK_AsignacionesEquipos_Equipo] FOREIGN KEY ([EquipoId]) REFERENCES [dbo].[Equipo] ([EquipoId])
);



