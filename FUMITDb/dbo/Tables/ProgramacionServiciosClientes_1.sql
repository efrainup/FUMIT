CREATE TABLE [dbo].[ProgramacionServiciosClientes] (
    [ProgramacionServiciosClienteId] INT      IDENTITY (1, 1) NOT NULL,
    [ProgramacionServicioId]         INT      NOT NULL,
    [ClienteId]                      INT      NOT NULL,
    [FechaInicio]                    DATETIME NOT NULL,
    [FechaTermino]                   DATETIME NULL,
    [Activo]                         BIT      CONSTRAINT [DF_ProgramacionServiciosClientes_Activo] DEFAULT ((1)) NOT NULL,
    [Borrado]                        BIT      CONSTRAINT [DF_ProgramacionServiciosClientes_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ProgramacionServiciosClientes] PRIMARY KEY CLUSTERED ([ProgramacionServiciosClienteId] ASC),
    CONSTRAINT [FK_ProgramacionServiciosClientes_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]),
    CONSTRAINT [FK_ProgramacionServiciosClientes_ProgramacionServicios] FOREIGN KEY ([ProgramacionServicioId]) REFERENCES [dbo].[ProgramacionServicios] ([ProgramacionServicioId])
);

