USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarCobro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarCobro] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_buscarCobro]
    @idCobro int = null,
	@idUso int = null
AS
BEGIN
    SELECT IdCobro
		  ,IdUso
		  ,IdTurno
		  ,fecha
		  ,Descuento
		  ,MontoCobrado
		  ,MontoPagado
		  ,Devuelta
	FROM COBRO_PARQUEO
	WHERE (@idCobro IS NULL OR IdTurno = @idCobro)
	  AND (@idUso IS NULL OR IdUso = @idUso)
END
GO
