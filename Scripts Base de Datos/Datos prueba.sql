----Datos de prueba
pa_insertarEmpleado null
		   ,'40224245487'
           ,'soy un empleado'
           ,'mi casa'
           ,'8095487454'
		   ,1
           ,'admin'
		   ,'123'
GO
pa_ActualizarConfiguracion 'Soy una empresa'
        ,'Mi casa'
        ,'8095784578'
        ,25
        ,10
GO
pa_aperturar_turno 1
        ,250
GO
pa_AperturarUso 1
GO
pa_InsertarCobro 1
        ,1
        ,10
        ,750
        ,1000
        ,250
GO

-- pa_CancelarUso
-- pa_cerrar_turno
-- pa_CerrarUso