USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_aperturar_turno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_aperturar_turno] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_aperturar_turno] 
    @idEmpleado int,
	@montoApertura decimal(10,2)
AS
BEGIN
	DECLARE @idGenerado int 
	EXEC @idGenerado = pa_buscarSiguienteSecuencia 'TURNO', 'IdTurno'
	
    INSERT INTO TURNO (
		IdTurno
	   ,IdEmpleado
	   ,FechaApertura
	   ,MontoApertura
	)
	VALUES (
		@idGenerado
	   ,@idEmpleado
	   ,GETDATE()
	   ,@montoApertura
	)

	RETURN @idGenerado
END


GO
