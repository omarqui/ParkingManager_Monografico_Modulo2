USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_AperturarUso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_AperturarUso] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_AperturarUso]
	@IdTurno int
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @idGenerado int,
			@precioXHora decimal(18,2)

	EXEC @idGenerado = pa_buscarSiguienteSecuencia 'USO_DE_PARQUEO', 'IdUso'
	
	SELECT TOP 1 @precioXHora = PrecioPorHora 
	FROM CONFIGURACIONES

	INSERT INTO [dbo].USO_DE_PARQUEO
				   (IdUso
				   ,IdTurno
				   ,PrecioPorMinuto)
			 VALUES
				   (@idGenerado
				   ,@IdTurno
				   ,@precioXHora)

	RETURN @idGenerado 
END
GO
