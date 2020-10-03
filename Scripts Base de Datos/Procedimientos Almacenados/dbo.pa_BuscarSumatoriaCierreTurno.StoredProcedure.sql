USE [DB_ESTACIONAMIENTO]
GO
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_BuscarSumatoriaCierreTurno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_BuscarSumatoriaCierreTurno] AS' 
END
GO

ALTER proc [dbo].[pa_BuscarSumatoriaCierreTurno]
(
   @idTurno INT
)
as
begin
	SELECT
		 ISNULL(SUM(COBRO_PARQUEO.MontoCobrado),0) AS MontoCobrado
	FROM COBRO_PARQUEO
	JOIN TURNO
	ON COBRO_PARQUEO.IdTurno = TURNO.IdTurno
	WHERE TURNO.EstaAbierto = 1 AND COBRO_PARQUEO.IdTurno = @idTurno	
end
GO
