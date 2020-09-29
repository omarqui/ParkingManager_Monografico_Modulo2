USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_InsertDefaultConfig]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_InsertDefaultConfig] AS' 
END
GO
ALTER PROC [dbo].[pa_InsertDefaultConfig]
AS 
INSERT INTO CONFIGURACIONES (NombreEmpresa
									,DireccionEmpresa
									,TelefonoEmpresa
									,PrecioPorHora
									,CantidadParqueos)
		VALUES ('EMPRESA PRUEBA'
			   ,'MOCA'
			   ,'8095784578'
			   ,10
			   ,50)
GO
