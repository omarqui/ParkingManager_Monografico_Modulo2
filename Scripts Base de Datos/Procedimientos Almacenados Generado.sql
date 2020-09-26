USE [DB_ESTACIONAMIENTO]
GO
/****** Object:  StoredProcedure [dbo].[pa_ActualizarConfiguracion]    Script Date: 9/24/2020 11:12:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_ActualizarConfiguracion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_ActualizarConfiguracion] AS' 
END
GO
ALTER proc [dbo].[pa_ActualizarConfiguracion](
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
GO
/****** Object:  StoredProcedure [dbo].[pa_aperturar_turno]    Script Date: 9/24/2020 11:12:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_aperturar_turno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_aperturar_turno] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_aperturar_turno] 
    @idEmpleado int,
	@montoApertura decimal(10,2)
AS
BEGIN
	DECLARE @idGenerado int 
	EXEC @idGenerado = pa_buscarSiguienteSecuencia 'TURNO', 'IdTurno'
	
    INSERT INTO TURNO (
		IdTurno
	   ,IdEmpleado
	   ,FechaApertura
	   ,MontoApertura
	)
	VALUES (
		@idGenerado
	   ,@idEmpleado
	   ,GETDATE()
	   ,@montoApertura
	)
END
GO
/****** Object:  StoredProcedure [dbo].[pa_BuscarConfiguracion]    Script Date: 9/24/2020 11:12:42 AM ******/
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
/****** Object:  StoredProcedure [dbo].[pa_buscarEmpleado]    Script Date: 9/24/2020 11:12:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarEmpleado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarEmpleado] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_buscarEmpleado]
    @id int = NULL,
    @usuario nvarchar(30) = NULL
AS
    SELECT *
	FROM empleado
	WHERE @id IS NULL OR IdEmpleado = @id
	  AND @usuario IS NULL OR Usuario = @usuario
GO
/****** Object:  StoredProcedure [dbo].[pa_buscarSiguienteSecuencia]    Script Date: 9/24/2020 11:12:42 AM ******/
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
/****** Object:  StoredProcedure [dbo].[pa_buscarTurno]    Script Date: 9/24/2020 11:12:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarTurno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarTurno] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_buscarTurno]
    @idTurno int
AS
BEGIN
    SELECT IdTurno
	      ,IdEmpleado
		  ,FechaApertura
		  ,FechaCierre
		  ,MontoApertura
		  ,MontoCobrado
		  ,MontoEntregado
		  ,MontoDiferencia
	FROM TURNO
	WHERE IdTurno = @idTurno
END
GO
/****** Object:  StoredProcedure [dbo].[pa_cerrar_turno]    Script Date: 9/24/2020 11:12:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_cerrar_turno]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_cerrar_turno] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_cerrar_turno] 
    @idTurno int,
	@montoCobrado decimal(10,2),
	@montoEntregado decimal(10,2),
	@montoDiferencia decimal(10,2)
AS
BEGIN
    UPDATE TURNO 
	SET FechaCierre = GETDATE()
	   ,MontoCobrado = @montoCobrado
	   ,MontoEntregado = @montoEntregado
	   ,MontoDiferencia = @montoDiferencia
	WHERE IdTurno = @idTurno
END
GO
/****** Object:  StoredProcedure [dbo].[pa_insertarEmpleado]    Script Date: 9/24/2020 11:12:42 AM ******/
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
		 WHERE IdEmpleado = @IdEmpleado
END
GO
/****** Object:  StoredProcedure [dbo].[pa_InsertDefaultConfig]    Script Date: 9/24/2020 11:12:42 AM ******/
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
/****** Object:  StoredProcedure [dbo].[pa_ValidarUsuario]    Script Date: 9/24/2020 11:12:42 AM ******/
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
