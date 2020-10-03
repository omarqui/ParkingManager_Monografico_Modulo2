USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CerrarUso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_CerrarUso] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_CerrarUso]
	@idUso int,
	@IdTurno int,
	@fechaSalida datetime,
	@total decimal(10,2),
	@tiempo decimal(10,2)
AS
BEGIN
	UPDATE [dbo].USO_DE_PARQUEO
	SET FechaSalida = @fechaSalida
	   ,TiempoUso = @tiempo
	   ,Total = @total
	WHERE IdTurno = @IdTurno 
	  AND FechaSalida IS NULL AND IdUso = @idUso
END
GO
