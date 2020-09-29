USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_BuscarUltimoTurnoAbiertoEmpleado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_BuscarUltimoTurnoAbiertoEmpleado] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_BuscarUltimoTurnoAbiertoEmpleado]
    @idEmpleado int
AS
BEGIN
	DECLARE @idTurno int

    SELECT TOP 1 @idTurno = IdTurno
	FROM TURNO
	WHERE IdEmpleado = @idEmpleado
	  AND FechaCierre IS NULL
	  AND EstaAbierto = 1
	ORDER BY FechaApertura

	RETURN isnull(@idTurno,0)
END
GO
