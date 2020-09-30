USE [DB_ESTACIONAMIENTO]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarCobroImpresion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarCobroImpresion] AS' 
END
GO

ALTER PROCEDURE [dbo].[pa_buscarCobroImpresion]
	@idUso int
AS
BEGIN
    SELECT USO.IdUso
	      ,USO.IdTurno IdTurnoUso
		  ,USO.FechaEntrada
		  ,USO.FechaSalida
		  ,USO.TiempoUso
		  ,USO.PrecioPorMinuto
		  ,USO.Total
		  ,USO.EstaActivo
		  ,EMP.IdEmpleado
		  ,EMP.Nombre NombreEmpleado
		  ,COB.IdCobro
		  ,COB.IdTurno IdTurnoCobro
		  ,COB.fecha
		  ,COB.Descuento
		  ,COB.MontoCobrado
		  ,COB.MontoPagado
		  ,COB.Devuelta
	FROM USO_DE_PARQUEO USO
	JOIN TURNO TUR
		ON USO.IdTurno = TUR.IdTurno
	JOIN EMPLEADO EMP
		ON EMP.IdEmpleado = TUR.IdEmpleado
	JOIN COBRO_PARQUEO COB
		ON COB.IdUso = USO.IdUso
	WHERE (@idUso IS NULL OR COB.IdUso = @idUso)
END
GO
