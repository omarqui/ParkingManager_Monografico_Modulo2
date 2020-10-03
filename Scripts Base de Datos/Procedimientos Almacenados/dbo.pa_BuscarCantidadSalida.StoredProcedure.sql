USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_BuscarCantidadSalida]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_BuscarCantidadSalida] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_BuscarCantidadSalida]
	@idTurno INT
AS
BEGIN
	DECLARE @cantidad int
	SELECT  @cantidad = COUNT(*) 
	FROM COBRO_PARQUEO
	WHERE IdTurno = @idTurno

	RETURN ISNULL(@cantidad,0)
END
GO
