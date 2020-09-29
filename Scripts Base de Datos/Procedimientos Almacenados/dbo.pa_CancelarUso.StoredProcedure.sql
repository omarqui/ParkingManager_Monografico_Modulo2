USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_CancelarUso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_CancelarUso] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_CancelarUso] 
    @idUso int  
AS
    UPDATE USO_DE_PARQUEO
	SET EstaActivo = 0
	WHERE IdUso = @idUso
GO
