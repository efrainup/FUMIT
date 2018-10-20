CREATE TABLE [dbo].[ContenedoresTickets] (
    [ContenedorTicketId] INT IDENTITY (1, 1) NOT NULL,
    [TicketId]           INT NOT NULL,
    [ContenedorId]       INT NOT NULL,
    [Levantes]           INT NOT NULL,
    [Borrado]            BIT CONSTRAINT [DF_ContenedoresTickets_Borrado] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ContenedoresTickets] PRIMARY KEY CLUSTERED ([ContenedorTicketId] ASC),
    CONSTRAINT [FK_ContenedoresTickets_Equipo] FOREIGN KEY ([ContenedorId]) REFERENCES [dbo].[Equipo] ([EquipoId]),
    CONSTRAINT [FK_ContenedoresTickets_Tickets] FOREIGN KEY ([TicketId]) REFERENCES [dbo].[Tickets] ([TicketId])
);



