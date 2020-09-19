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
				   ,[Usuario]
				   ,[Clave])
			 VALUES
				   (@idGenerado
				   ,@Cedula
				   ,@Nombre
				   ,@Direccion
				   ,@Celular
				   ,@Usuario
				   ,HASHBYTES('SHA2_512',@Clave))
	ELSE 
		UPDATE [dbo].[EMPLEADO]
		   SET [Cedula] = @Cedula
			  ,[Nombre] = @Nombre
			  ,[Direccion] = @Direccion
			  ,[Celular] = @Celular
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

CREATE proc pa_BuscarConfiguracion
AS
BEGIN
	IF NOT EXISTS(SELECT TOP 1 * FROM CONFIGURACIONES)
		EXEC pa_InsertDefaultConfig 

	SELECT TOP 1 * 
	FROM CONFIGURACIONES
END
GO
CREATE PROC pa_InsertDefaultConfig
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
CREATE PROC pa_ActualizarConfiguracion(
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

