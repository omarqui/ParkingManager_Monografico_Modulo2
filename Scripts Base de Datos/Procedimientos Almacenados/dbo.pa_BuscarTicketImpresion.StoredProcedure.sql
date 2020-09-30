USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_BuscarTicketImpresion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_BuscarTicketImpresion] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_BuscarTicketImpresion]
    @idUsoParqueo INT
AS
    SELECT 
		USO_DE_PARQUEO.IdUso,
		USO_DE_PARQUEO.IdTurno,
		USO_DE_PARQUEO.FechaEntrada,
		USO_DE_PARQUEO.PrecioPorMinuto,
		EMPLEADO.IdEmpleado,
		EMPLEADO.Nombre As NombreEmpleado
	FROM
	USO_DE_PARQUEO
	JOIN TURNO 
	on USO_DE_PARQUEO.IdTurno = TURNO.IdTurno 
	JOIN EMPLEADO
	ON TURNO.IdEmpleado = EMPLEADO.IdEmpleado
	WHERE USO_DE_PARQUEO.IdUso = @idUsoParqueo
GO