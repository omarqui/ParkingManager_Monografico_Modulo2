--Create Database DB_ESTACIONAMIENTO
--GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'CONFIGURACION'
)

CREATE TABLE CONFIGURACIONES (
NombreEmpresa nvarchar(400) NOT NULL,
DireccionEmpresa nvarchar(400) NOT NULL DEFAULT '',
TelefonoEmpresa nvarchar(20) NOT NULL DEFAULT '',
PrecioPorHora decimal(10,2) NOT NULL DEFAULT 0, 
CantidadParqueos int NOT NULL DEFAULT 1, 
CONSTRAINT CHK_CantidadParqueos CHECK (CantidadParqueos >= 0)
)

GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = 'EMPLEADO')

CREATE TABLE EMPLEADO(
IdEmpleado int , 
Cedula char(11),
Nombre nvarchar(100) NOT NULL,
Direccion nvarchar(400) DEFAULT '',
Celular nvarchar(30) DEFAULT '',
Usuario nvarchar(30),
Clave binary(64) NOT NULL,
CONSTRAINT PK_IdEmpleado PRIMARY KEY (IdEmpleado),
CONSTRAINT CHK_Clave CHECK (Clave <> '')
)

GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'PERMISO'
)

CREATE TABLE PERMISO(	
	IdEmpleado int,
	IdFormulario int,
	TieneAcceso bit,
 CONSTRAINT [FK_IdEmpleado] FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO (IdEmpleado)
)
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = 'TURNO')

CREATE TABLE TURNO(
IdTurno INT, 
IdEmpleado INT, 
FechaApertura datetime DEFAULT GETDATE(), 
FechaCierre datetime, 
MontoApertura decimal(10,2) NOT NULL DEFAULT 0,
MontoCobrado decimal(10,2) NOT NULL DEFAULT 0,
MontoEntregado decimal(10,2) NOT NULL DEFAULT 0,
MontoDiferencia decimal(10,2) NOT NULL DEFAULT 0,
CONSTRAINT PK_IdTurno PRIMARY KEY (IdTurno),
CONSTRAINT FK_IdEmpleado_TURNO FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO(IdEmpleado)
)

GO

--CREACION DE TABLA DE USO DE PARQUIO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'USO_DE_PARQUEO'
)

CREATE TABLE USO_DE_PARQUEO(
IdUso int,
IdTurno int,
FechaEntrada datetime,
FechaSalida datetime,
TiempoUso decimal(10,2),
PrecioPorMinuto decimal(10,2),
Descuento decimal(10,2),
Total decimal(10,2),
MontoPagado decimal(10,2),
Devuelta decimal(10,2),
CONSTRAINT PK_IdUso PRIMARY KEY (IdUso), 
CONSTRAINT FK_ID_TURNO FOREIGN KEY (IdTurno) REFERENCES TURNO (IdTurno)
)