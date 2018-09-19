-- =============================================
-- Author:		Efrain Hernandez
-- Create date: 19/09/2018
-- Description:	Obtiene los servicios programados por días calculados
-- =============================================
CREATE FUNCTION ServiciosProgramadosPorDíasCalculados 
(
	-- Add the parameters for the function here
	 @FechaInicio DATETIME,
	 @FechaFin DATETIME
)
RETURNS 
@ServiciosProgramadosQuincenalesResultado TABLE 
(
	-- Add the column definitions for the TABLE variable here
	FechaInicio datetime, 
	Fecha DATETIME,
	NombreCliente VARCHAR(250),
	Nombre VARCHAR(250),
	Dias VARCHAR(10),
	Diferencia INT,
	ServicioProgramadoId INT,
	ClienteId INT,
	ProgramacionServicioId INT,
	ProgramacionServiciosClienteId INT,
	ServicioId INT,
	NombreServicio VARCHAR(50),
	ServicioCancelado BIT,
	ServicioPrioridad INT,
	ServicioRealizado BIT
	
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	
	DECLARE @FechaActual DATETIME
	SET @FechaActual = @FechaInicio

	DECLARE @FechasBusqueda TABLE (Fecha DATETIME)

	WHILE @FechaActual <= @FechaFin
	BEGIN
		INSERT INTO @FechasBusqueda VALUES (@FechaActual)
		SET @FechaActual = DATEADD(Day,1,@FechaActual)
	END

	--INSERT INTO @FechasBusqueda VALUES ('2018-09')
	INSERT INTO @ServiciosProgramadosQuincenalesResultado
	SELECT 
		PSC.FechaInicio,
		FB.Fecha,
		C.Nombre,
		PS.Nombre,
		PS.Dias,
		DATEDIFF(Day,PSC.FechaInicio,FB.Fecha) AS Diferencia,
		SP.ServicioProgramadoId,
		C.ClienteId,
		ps.ProgramacionServicioId,
		PSC.ProgramacionServiciosClienteId,
		PSC.ServicioId,
		S.Nombre AS [NombreServicio],
		SP.Cancelado,
		SP.Prioridad,
		SP.Realizado
	FROM ProgramacionServicios PS
	INNER JOIN ProgramacionServiciosClientes PSC ON PSC.ProgramacionServicioId=PS.ProgramacionServicioId
	INNER JOIN Clientes C ON C.ClienteId=PSC.ClienteId
	INNER JOIN Servicios S ON S.ServicioId=PSC.ServicioId

		--SELECT * 
		--FROM ServiciosProgramados SP
		--INNER JOIN PSC
		--WHERE SP.ProgramacionServiciosClientesId

	CROSS JOIN @FechasBusqueda FB
	LEFT JOIN ServiciosProgramados SP ON SP.ProgramacionServiciosClientesId=PSC.ProgramacionServiciosClienteId AND SP.FechaServicio=FB.Fecha
	WHERE (PS.Borrado=0 AND PS.Activo=1 AND (Semana IS NULL OR Semana=0) AND (Mes IS NULL OR Mes=0))
	AND (PSC.Borrado=0 AND PSC.Activo=1)
	AND (C.Borrado = 0 AND C.Activo=1)
	AND (DATEDIFF(Day,PSC.FechaInicio,FB.Fecha) >= 0)
	AND (DATEDIFF(Day,PSC.FechaInicio,FB.Fecha) % PS.Dias = 0)
	ORDER BY FB.Fecha

	RETURN 
END