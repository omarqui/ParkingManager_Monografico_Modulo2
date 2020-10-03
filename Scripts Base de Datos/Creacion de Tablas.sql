--Create Database DB_ESTACIONAMIENTO
--GO
USE [DB_ESTACIONAMIENTO]
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'CONFIGURACIONES'
)
	DROP TABLE CONFIGURACIONES

CREATE TABLE CONFIGURACIONES (
NombreEmpresa nvarchar(400) NOT NULL,
DireccionEmpresa nvarchar(400) NOT NULL DEFAULT '',
TelefonoEmpresa nvarchar(20) NOT NULL DEFAULT '',
PrecioPorHora decimal(10,2) NOT NULL DEFAULT 0, 
CantidadParqueos int NOT NULL DEFAULT 1, 
CONSTRAINT CHK_CantidadParqueos CHECK (CantidadParqueos >= 0)
)

GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_NAME = 'EMPLEADO')
BEGIN
	DROP TABLE PERMISO
	DROP TABLE USO_DE_PARQUEO
	DROP TABLE TURNO
	DROP TABLE EMPLEADO	
END 

CREATE TABLE EMPLEADO(
IdEmpleado int,
Cedula char(11),
Nombre nvarchar(100) NOT NULL,
Direccion nvarchar(400) DEFAULT '',
Celular nvarchar(30) DEFAULT '',
Usuario nvarchar(30) NOT NULL UNIQUE,
Clave binary(64) NOT NULL,
EstaActivo bit NOT NULL DEFAULT 1,
PuedeHacerDescuento bit NOT NULL DEFAULT 0,
CONSTRAINT PK_EMPLEADO_IdEmpleado PRIMARY KEY (IdEmpleado),
CONSTRAINT CHK_EMPLEADO_Clave CHECK (Clave <> ''),
CONSTRAINT Unico_Usuario UNIQUE (Usuario)
)

GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'PERMISO'
)
	DROP TABLE PERMISO

CREATE TABLE PERMISO(	
	IdEmpleado int,
	IdFormulario int,
	TieneAcceso bit,
 CONSTRAINT [FK_IdEmpleado] FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO (IdEmpleado)
)
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = 'TURNO')
	DROP TABLE TURNO

CREATE TABLE TURNO(
IdTurno INT, 
IdEmpleado INT NOT NULL, 
FechaApertura datetime NOT NULL CONSTRAINT DF_TURNO_FechaApertura DEFAULT GETDATE(), 
FechaCierre datetime NULL, 
MontoApertura decimal(10,2) NOT NULL,
MontoCobrado decimal(10,2),
MontoEntregado decimal(10,2),
MontoDiferencia decimal(10,2),
TotalEnCaja decimal(10,2),
EstaAbierto bit NOT NULL CONSTRAINT DF_TURNO_EstaAbierto DEFAULT 1,
CONSTRAINT PK_IdTurno PRIMARY KEY (IdTurno),
CONSTRAINT FK_IdEmpleado_TURNO FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO(IdEmpleado)
)

GO

--CREACION DE TABLA DE USO DE PARQUIO
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'USO_DE_PARQUEO'
)
	DROP TABLE USO_DE_PARQUEO

CREATE TABLE USO_DE_PARQUEO(
IdUso int,
IdTurno int,
FechaEntrada datetime NOT NULL CONSTRAINT DF_USO_DE_PARQUEO_FechaEntrada DEFAULT GETDATE(),
FechaSalida datetime NULL,
TiempoUso decimal(10,2) NULL,
PrecioPorMinuto decimal(10,2) NOT NULL,
Total decimal(10,2) NULL,
EstaActivo bit NOT NULL CONSTRAINT DF_USO_DE_PARQUEO_EstaActivo DEFAULT 1
CONSTRAINT PK_IdUso PRIMARY KEY (IdUso), 
CONSTRAINT FK_ID_TURNO FOREIGN KEY (IdTurno) REFERENCES TURNO (IdTurno)
)

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_NAME = 'COBRO_PARQUEO'
)
	DROP TABLE COBRO_PARQUEO

CREATE TABLE COBRO_PARQUEO(
IdCobro int,
IdUso int,
IdTurno int,
fecha datetime NOT NULL CONSTRAINT DF_COBRO_PARQUEO_fecha DEFAULT GETDATE(),
Descuento decimal(10,2) NULL,
MontoCobrado decimal(10,2) NOT NULL,
MontoPagado decimal(10,2) NOT NULL,
Devuelta decimal(10,2) NOT NULL,
CONSTRAINT PK_IdCobro PRIMARY KEY (IdUso),
CONSTRAINT FK_COBRO_PARQUEO_IdTurno FOREIGN KEY (IdTurno) REFERENCES TURNO (IdTurno),
CONSTRAINT FK_COBRO_PARQUEO_IdUso FOREIGN KEY (IdUso) REFERENCES USO_DE_PARQUEO (IdUso)
)
