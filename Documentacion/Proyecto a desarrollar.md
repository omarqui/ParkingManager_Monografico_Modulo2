# 98-SISTEMA INFORMÁTICO PARA MANEJO DE PARQUEADEROS

Este proyecto consiste en crear un sistema que ayude al facil y rapido desembolvimiento de las actividades relacionadas al manejo de parqueos.

## Consideraciones

1. Cantidad de parqueo se trabaja por configuraion
2. Precio se defino por hora en configuracion

## Formularios

1. Registro Empleado
2. Registro de Uso de Parqueo
3. Apertura de caja
4. Configuraciones
5. Permiso

## Proceso

1. Entrega de Parqueo en Uso
2. Cuadre caja

## Consulta

1. Parqueos en uso x tiempo

## Reporte

1. Cuadre caja
2. Tiket de Parqueo en Uso
3. Recibo de Ingreso
4. Lista de facturas

# Entidades

## Configuraciones

campo|tipo dato|logitud|nota
---|---|---|---
NombreEmpresa|varchar
DireccionEmpresa|varchar
TelefonoEmpresa|varchar
PrecioXHora|decimal
CantidadParqueos|int

## Empleado

campo|tipo dato|logitud|nota
---|---|---|---
IdEmpleado|int||identity, primary key
Cedula|char|11
Nombre|varchar
Direccion|varchar
Celular|varchar
Usuario|varchar|25
Clave|binary|64|Encriptada

## Permiso

campo|tipo dato|logitud|nota
---|---|---|---
IdEmpleado|int||foreingh key
IdFormulario|int
TieneAcceso|bit

## Turno

campo|tipo dato|logitud|nota
---|---|---|---
IdTurno|int||primary key
IdEmpleado|int||foreingh key
FechaApertura|datetime
FechaCierre|datetime
MontoApertura|decimal
MontoCobrado|decimal
MontoEntregado|decimal
MontoDiferencia|decimal

## Uso de Parqueo

campo|tipo dato|logitud|nota
---|---|---|---
IdUso|int
IdTurno|int||Se llena en el proceso de salida
FechaEntrada|datetime
FechaSalida|datetime
TiempoUso|decimal
PrecioXMinuto|decimal
Descuento|decimal
Total|decimal
MontoPagado|decimal
Devuelta|decimal
