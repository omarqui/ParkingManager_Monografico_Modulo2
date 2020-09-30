USE [DB_ESTACIONAMIENTO]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pa_buscarTurnoImpresion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pa_buscarTurnoImpresion] AS' 
END
GO
ALTER PROCEDURE [dbo].[pa_buscarTurnoImpresion]  
    @idTurno int
AS  
BEGIN  
    SELECT TURNO.IdTurno  
		,TURNO.IdEmpleado
	    ,EMPLEADO.Nombre AS NombreEmpleado
		,ISNULL(TURNO.FechaApertura,'') AS FechaApertura 
		,ISNULL(TURNO.FechaCierre,'') AS FechaCierre 
		,ISNULL(TURNO.MontoApertura,0.00) AS MontoApertura
		,ISNULL(TURNO.MontoCobrado,0.00) AS MontoCobrado  
		,ISNULL(TURNO.MontoEntregado,0.00) AS MontoEntregado   
		,ISNULL(TURNO.MontoDiferencia,0.00) AS MontoDiferencia
		,TURNO.EstaAbierto
		,COBRO_PARQUEO.IdCobro
		,USO_DE_PARQUEO.IdUso
		,USO_DE_PARQUEO.FechaEntrada
		,USO_DE_PARQUEO.FechaSalida
		,USO_DE_PARQUEO.PrecioPorMinuto
		,USO_DE_PARQUEO.TiempoUso
		,USO_DE_PARQUEO.Total
		,COBRO_PARQUEO.Descuento
		,COBRO_PARQUEO.MontoCobrado
 FROM TURNO
 JOIN EMPLEADO
	ON EMPLEADO.IdEmpleado = TURNO.IdEmpleado
 JOIN COBRO_PARQUEO
	ON COBRO_PARQUEO.IdTurno = TURNO.IdTurno
 JOIN USO_DE_PARQUEO
	ON USO_DE_PARQUEO.IdUso = COBRO_PARQUEO.IdUso
 WHERE TURNO.IdTurno = @idTurno
END
GO
