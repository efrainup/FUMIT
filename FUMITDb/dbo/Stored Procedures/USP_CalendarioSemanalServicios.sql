-- =============================================
-- Author:		Efrain Hernandez
-- Create date: 05/09/2018
-- Description:	Obtiene el calendario semanal de servicios programados. 
-- =============================================
CREATE PROCEDURE [dbo].[USP_CalendarioSemanalServicios] 
	-- Add the parameters for the stored procedure here
	 @fechaInicio datetime,
	 @fechaFin datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET DATEFORMAT 'ymd'
	SET LANGUAGE N'Español'

	DECLARE @dias TABLE(dia VARCHAR(2) COLLATE Modern_Spanish_CI_AS, nombre VARCHAR(20) COLLATE Modern_Spanish_CI_AS, fecha DATETIME)
	DECLARE @fechaActual DATETIME
	DECLARE @DiaSemana INT 

	SET @fechaActual = @fechaInicio
	SET @DiaSemana= 1

	WHILE @fechaActual <= @fechaFin
	BEGIN
		INSERT INTO @dias
		SELECT CONVERT(VARCHAR(2),@DiaSemana),DATENAME(WEEKDAY, @fechaActual),@fechaActual
	
		SET @fechaActual = DATEADD(DD,1,@fechaActual)
		SET @DiaSemana = @DiaSemana + 1
	END
	
	--Se obtienen servicios programados semanales
	SELECT 
		d.Fecha AS [FechaServicio],
		d.nombre AS [DiaSemana], 
		cl.ClienteId AS [ClienteId],
		cl.Nombre AS [NombreCliente],
		p.Nombre AS [NombreProgramacion], 
		p.ProgramacionServicioId, 
		PSC.ProgramacionServiciosClienteId,
		s.ServicioId AS [ServicioId],
		s.Nombre AS [NombreServicio], 
		SP.ServicioProgramadoId, 
		Sp.Cancelado AS [Cancelado],
		SP.Prioridad AS [Prioridad],
		SP.Realizado AS [Realizado],
		PSC.Area AS [Area]
	FROM [dbo].[ProgramacionServicios] p
		INNER JOIN @dias d on p.Dias like '%' + d.dia + '%'
		INNER JOIN [dbo].[ProgramacionServiciosClientes] PSC ON PSC.ProgramacionServicioId=p.ProgramacionServicioId
		INNER JOIN [dbo].[Clientes] cl ON cl.ClienteId=psc.ClienteId
		INNER JOIN [dbo].[Servicios] s ON s.ServicioId=PSC.ServicioId
		LEFT JOIN  [dbo].[ServiciosProgramados] SP ON SP.ProgramacionServiciosClientesId=PSC.ProgramacionServiciosClienteId AND (SP.FechaServicio IS NULL OR DATEADD(DD,0,DATEDIFF(DD,0,SP.FechaServicio))=D.Fecha )
	WHERE (PSC.FechaInicio <= @fechaFin) and (PSC.FechaTermino IS NULL OR PSC.FechaTermino >= @fechaInicio)
		AND (SP.FechaServicio IS NULL OR DATEADD(DD,0,DATEDIFF(DD,0,SP.FechaServicio))=D.Fecha )
		AND PSC.Borrado=0 AND CL.Borrado=0 AND S.Borrado=0 AND (SP.Borrado IS NULL OR SP.Borrado=0)
		AND (SP.Tipo IS NULL OR SP.Tipo='Programado') AND (p.Semana=1)

	UNION ALL 
	--Servicios programados quincenales

	SELECT 
		 SPDC.Fecha AS [FechaServicio],
		 D.Nombre AS [DiaSemana],
		 SPDC.ClienteId AS [ClienteId],
		 SPDC.NombreCliente AS [NombreCliente],
		 SPDC.Nombre AS [NombreProgramacion],
		 SPDC.ProgramacionServicioId AS [ProgramacionServicioId],
		 SPDC.ProgramacionServiciosClienteId AS [ProgramacionServiciosClienteId],
		 SPDC.ServicioId AS [ServicioId],
		 SPDC.NombreServicio AS [NombreServicio],
		 SPDC.ServicioProgramadoId AS [ServicioProgramadoId],
		 SPDC.ServicioCancelado,
	     SPDC.ServicioPrioridad,
		 SPDC.ServicioRealizado,
		 SPDC.Area
	FROM [dbo].ServiciosProgramadosPorDíasCalculados(@fechaInicio,@fechaFin) SPDC
	INNER JOIN @dias D ON D.Fecha=SPDC.Fecha
	

	UNION ALL
	--Servicios extra
	SELECT 
		SP.FechaServicio AS [FechaServicio],
		d.nombre AS [DiaSemana], 
		SP.ClienteId AS [ClienteId],
		cl.Nombre AS [NombreCliente],
		'Express' AS [NombreProgramacion], 
		0 AS [ProgramacionServicioId], 
		SP.ProgramacionServiciosClientesId,
		SP.ServicioId AS [ServicioId],
		s.Nombre AS [NombreServicio], 
		SP.ServicioProgramadoId, 
		Sp.Cancelado AS [Cancelado],
		SP.Prioridad AS [Prioridad],
		SP.Realizado AS [Realizado],
		'' AS Area
	FROM [dbo].[ServiciosProgramados] SP
	INNER JOIN @dias d on d.fecha=SP.FechaServicio
	INNER JOIN [dbo].[Servicios] s ON s.ServicioId=SP.ServicioId
	INNER JOIN [dbo].[Clientes] cl ON cl.ClienteId=SP.ClienteId
	WHERE SP.Tipo='Express' AND SP.FechaServicio BETWEEN @fechaInicio and @fechafin
	ORDER BY D.Fecha

END