USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_insertarEmpleado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_insertarEmpleado] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_insertarEmpleado]
	@IdEmpleado int
   ,@Cedula char(11)
   ,@Nombre nvarchar(100)
   ,@Direccion nvarchar(400)
   ,@Celular nvarchar(30)
   ,@Usuario nvarchar(30) = null
   ,@Clave nvarchar(30) = null
   ,@EstaActivo bit = 1
AS
BEGIN
	DECLARE @idGenerado int = (SELECT ISNULL((SELECT MAX(IdEmpleado) FROM EMPLEADO)+1,1))

	IF (@IdEmpleado IS NULL OR @IdEmpleado = 0)
		INSERT INTO [dbo].[EMPLEADO]
				   ([IdEmpleado]
				   ,[Cedula]
				   ,[Nombre]
				   ,[Direccion]
				   ,[Celular]
				   ,[Usuario]
				   ,[Clave]
				   ,EstaActivo)
			 VALUES
				   (@idGenerado
				   ,@Cedula
				   ,@Nombre
				   ,@Direccion
				   ,@Celular
				   ,@Usuario
				   ,HASHBYTES('SHA2_512',@Clave)
				   ,@EstaActivo)
	ELSE 
		UPDATE [dbo].[EMPLEADO]
		   SET [Cedula] = @Cedula
			  ,[Nombre] = @Nombre
			  ,[Direccion] = @Direccion
			  ,[Celular] = @Celular
			  ,EstaActivo = EstaActivo
		 WHERE IdEmpleado = @IdEmpleado
END
GO
