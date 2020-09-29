USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_InsertarCobro]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_InsertarCobro] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_InsertarCobro]
	@idUso int,
	@IdTurno int,
	@descuento decimal(10,2),
	@montoCobrado decimal(10,2),
	@montoPagado decimal(10,2),
	@devuelta decimal(10,2),
	@fecha datetime
AS
BEGIN
	DECLARE @idGenerado int

	EXEC @idGenerado = pa_buscarSiguienteSecuencia 'COBRO_PARQUEO', 'IdCobro'

	INSERT INTO [dbo].COBRO_PARQUEO
				   (IdCobro
				   ,IdUso
				   ,IdTurno
				   ,fecha
				   ,Descuento
				   ,MontoCobrado
				   ,MontoPagado
				   ,Devuelta)
			 VALUES
				   (@idGenerado
				   ,@idUso
				   ,@IdTurno
				   ,@fecha
				   ,@descuento
				   ,@montoCobrado
				   ,@montoPagado
				   ,@devuelta)
END
GO
