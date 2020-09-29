USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarUso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarUso] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_buscarUso]
    @idUso int = null,
	@desde datetime = null,
	@hasta datetime = null,
	@cajero int = null,
	@estado char(1) = null,
	@textoAbierto varchar(max) = null
AS
BEGIN
    SELECT USO.IdUso
	      ,USO.IdTurno
		  ,USO.FechaEntrada
		  ,USO.FechaSalida
		  ,USO.TiempoUso
		  ,USO.PrecioPorMinuto
		  ,USO.Total
		  ,USO.EstaActivo
		  ,EMP.IdEmpleado
		  ,EMP.Nombre NombreEmpleado
		  ,COB.Descuento
		  ,COB.MontoCobrado
		  ,EMP.Nombre+
							 cast(USO.IdUso as varchar(50))--+
	FROM USO_DE_PARQUEO USO
	JOIN TURNO TUR
		ON USO.IdTurno = TUR.IdTurno
	JOIN EMPLEADO EMP
		ON EMP.IdEmpleado = TUR.IdEmpleado
	LEFT JOIN COBRO_PARQUEO COB
		ON COB.IdUso = USO.IdUso
	WHERE (@idUso IS NULL OR USO.IdUso = @idUso)
	  AND (@desde IS NULL OR USO.FechaEntrada BETWEEN @desde AND @hasta)
	  AND (@cajero IS NULL OR TUR.IdEmpleado = @cajero)
	  AND (@textoAbierto IS NULL OR EMP.Nombre+
							 cast(USO.IdUso as varchar(50))--+
							-- cast(USO.TiempoUso as varchar(50))+
							-- cast(USO.Total as varchar(50))+
							-- cast(TUR.IdEmpleado as varchar(50))+
							-- cast(COB.Descuento as varchar(50))+
							-- cast(COB.MontoCobrado as varchar(50))
							LIKE '%'+@textoAbierto+'%')
END



GO
