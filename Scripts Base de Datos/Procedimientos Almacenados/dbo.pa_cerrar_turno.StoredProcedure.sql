USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_cerrar_turno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_cerrar_turno] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_cerrar_turno] 
    @idTurno int,
	@montoCobrado decimal(10,2),
	@montoEntregado decimal(10,2),
	@montoDiferencia decimal(10,2)
AS
BEGIN
    UPDATE TURNO 
	SET FechaCierre = GETDATE()
	   ,MontoCobrado = @montoCobrado
	   ,MontoEntregado = @montoEntregado
	   ,MontoDiferencia = @montoDiferencia
	   ,EstaAbierto = 0
	WHERE IdTurno = @idTurno
	  AND EstaAbierto = 1
END


GO
