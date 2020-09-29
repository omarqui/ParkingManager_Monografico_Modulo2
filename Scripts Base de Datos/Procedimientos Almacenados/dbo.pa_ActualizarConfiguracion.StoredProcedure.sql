USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ActualizarConfiguracion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_ActualizarConfiguracion] AS' 
END
GO
ALTER proc [dbo].[pa_ActualizarConfiguracion](
	@NombreEmpresa nvarchar(400),
	@DireccionEmpresa nvarchar (400),
	@TelefonoEmpresa nvarchar(20),
	@PrecioPorHora decimal(10,2),
	@CantidadParqueos int
)
AS
BEGIN 
	IF NOT EXISTS(SELECT TOP 1 * FROM CONFIGURACIONES)
		EXEC pa_InsertDefaultConfig 
	 
		
	UPDATE CONFIGURACIONES
		SET NombreEmpresa = @NombreEmpresa
		   ,DireccionEmpresa = @DireccionEmpresa
		   ,TelefonoEmpresa = @TelefonoEmpresa
		   ,PrecioPorHora = @PrecioPorHora
		   ,CantidadParqueos = @CantidadParqueos
END 
GO
