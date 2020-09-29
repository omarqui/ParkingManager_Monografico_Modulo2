USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarCantidadParqueosDisponibles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarCantidadParqueosDisponibles] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_buscarCantidadParqueosDisponibles]
AS
BEGIN
    declare @cantidad int
	
	SELECT @cantidad = COUNT(*)
	FROM USO_DE_PARQUEO
	WHERE FechaSalida IS NULL
	
	RETURN ISNULL(@cantidad,0)
END
GO
