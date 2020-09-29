USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ValidarUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_ValidarUsuario] AS' 
END
GO

ALTER proc [dbo].[pa_ValidarUsuario]
(
   @usuario varchar(30),
   @clave nvarchar(30)
)
as
begin
   select 1
   from EMPLEADO
   where usuario=@usuario
     and clave = HASHBYTES('SHA2_512',@clave)
end
GO
