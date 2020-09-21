USE [DB_ESTACIONAMIENTO]
GO

/****** Object:  StoredProcedure [dbo].[pa_ValidarUsuario]    Script Date: 9/4/2020 10:36:38 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[pa_ValidarUsuario]
GO

/****** Object:  StoredProcedure [dbo].[pa_insertarEmpleado]    Script Date: 9/4/2020 10:36:38 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[pa_insertarEmpleado]
GO

/****** Object:  StoredProcedure [dbo].[pa_buscarEmpleado]    Script Date: 9/4/2020 10:36:38 PM ******/
DROP PROCEDURE IF EXISTS [dbo].[pa_buscarEmpleado]
GO

/****** Object:  StoredProcedure [dbo].[pa_buscarEmpleado]    Script Date: 9/4/2020 10:36:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_buscarEmpleado]
    @id int = NULL,
    @usuario nvarchar(30) = NULL
AS
    SELECT *
	FROM empleado
	WHERE @id IS NULL OR IdEmpleado = @id
	  AND @usuario IS NULL OR Usuario = @usuario
GO

/****** Object:  StoredProcedure [dbo].[pa_insertarEmpleado]    Script Date: 9/4/2020 10:36:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarEmpleado]
	@IdEmpleado int
   ,@Cedula char(11)
   ,@Nombre nvarchar(100)
   ,@Direccion nvarchar(400)
   ,@Celular nvarchar(30)
   ,@EstaActivo bit
   ,@Usuario nvarchar(30) = null
   ,@Clave nvarchar(30) = null
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
				   ,[EstaActivo]
				   ,[Usuario]
				   ,[Clave])
			 VALUES
				   (@idGenerado
				   ,@Cedula
				   ,@Nombre
				   ,@Direccion
				   ,@Celular
				   ,@EstaActivo
				   ,@Usuario
				   ,HASHBYTES('SHA2_512',@Clave))
	ELSE 
		UPDATE [dbo].[EMPLEADO]
		   SET [Cedula] = @Cedula
			  ,[Nombre] = @Nombre
			  ,[Direccion] = @Direccion
			  ,[Celular] = @Celular
			  ,[EstaActivo] = @EstaActivo
		 WHERE IdEmpleado = @IdEmpleado
END
GO

/****** Object:  StoredProcedure [dbo].[pa_ValidarUsuario]    Script Date: 9/4/2020 10:36:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[pa_ValidarUsuario]
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

