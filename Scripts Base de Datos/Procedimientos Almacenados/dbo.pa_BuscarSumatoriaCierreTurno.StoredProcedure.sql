USE [DB_ESTACIONAMIENTO]
GO
/****** Object:  StoredProcedure [dbo].[pa_BuscarSumatoriaCierreTurno]    Script Date: 9/28/2020 8:00:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[pa_BuscarSumatoriaCierreTurno]
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
