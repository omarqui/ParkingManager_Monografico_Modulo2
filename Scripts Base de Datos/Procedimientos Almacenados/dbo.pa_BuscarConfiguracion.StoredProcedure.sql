USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_BuscarConfiguracion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_BuscarConfiguracion] AS' 
END
GO
ALTER proc [dbo].[pa_BuscarConfiguracion]
AS
BEGIN
	IF NOT EXISTS(SELECT TOP 1 * FROM CONFIGURACIONES)
		EXEC pa_InsertDefaultConfig 

	SELECT TOP 1 * 
	FROM CONFIGURACIONES
END
GO
