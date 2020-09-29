USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarSiguienteSecuencia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarSiguienteSecuencia] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_buscarSiguienteSecuencia]
    @nombreTabla varchar(200),
	@nombreColumna varchar(200)
AS
    declare @cmd nvarchar(max), @siguienteSecuencia int
	set @cmd = 'SELECT TOP 1 @siguienteSecuenciaReturn = '+@nombreColumna+'+1
                FROM '+@nombreTabla+'
                ORDER BY '+@nombreColumna+' DESC'
	
	exec sp_executesql @cmd,N'@siguienteSecuenciaReturn int OUTPUT',
					   @siguienteSecuenciaReturn = @siguienteSecuencia output
	
	return isnull(@siguienteSecuencia,1)
GO
