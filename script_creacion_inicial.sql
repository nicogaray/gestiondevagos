--###########################################################################
--###########################################################################
-- SCRIPT DE MIGRACION Y CREACION DE OBJETOS NECESARIOS
-- GRUPO: LOS_JUS
--###########################################################################
--###########################################################################

USE [GD1C2014]
GO

IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = N'LOS_JUS' ) 
    EXEC('CREATE SCHEMA [LOS_JUS] AUTHORIZATION [gd]');
GO

--###########################################################################
--###########################################################################
-- DROP FKs 
--###########################################################################
--###########################################################################

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROLxFUNCIONALIDADES') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.ROLxFUNCIONALIDADES DROP CONSTRAINT ROLFUN_ROL
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROLxFUNCIONALIDADES') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.ROLxFUNCIONALIDADES DROP CONSTRAINT ROLFUN_FUNCIONALIDADES
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROLxUSUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.ROLxUSUARIO DROP CONSTRAINT ROLUSU_ROL
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROLxUSUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.ROLxUSUARIO DROP CONSTRAINT ROLUSU_USUARIO
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.CLIENTE') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.CLIENTE DROP CONSTRAINT CLI_USUARIO
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.EMPRESA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.EMPRESA DROP CONSTRAINT EMP_USUARIO
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.PUBLICACION DROP CONSTRAINT PUB_EMPRESA
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PREGUNTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.PREGUNTA DROP CONSTRAINT PRE_PUBLICACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PREGUNTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.PREGUNTA DROP CONSTRAINT CLIENTE
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PUBLICACIONxVISUALIZACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.PUBLICACIONxVISUALIZACION DROP CONSTRAINT PUBVIS_PUBLICACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PUBLICACIONxVISUALIZACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.PUBLICACIONxVISUALIZACION DROP CONSTRAINT PUBVIS_VISUALIZACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.RUBROxPUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.RUBROxPUBLICACION DROP CONSTRAINT RUBPUB_RUBRO
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.RUBROxPUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.RUBROxPUBLICACION DROP CONSTRAINT RUBPUB_PUBLICACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.OPERACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.OPERACION DROP CONSTRAINT OPE_PUBLICACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.OPERACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.OPERACION DROP CONSTRAINT OPE_CLIENTE
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.CALIFICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.CALIFICACION DROP CONSTRAINT CAL_OPERACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.FACTURACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.FACTURACION DROP CONSTRAINT FAC_OPERACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.COMPRA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.COMPRA DROP CONSTRAINT COM_PUBLICACION
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.SUBASTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE LOS_JUS.SUBASTA DROP CONSTRAINT SUB_PUBLICACION
;

GO


--###########################################################################
--###########################################################################
-- CREACION DE TABLAS 
--###########################################################################
--###########################################################################

-----------TABLA ROL-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.ROL
;

CREATE TABLE LOS_JUS.ROL ( 
	ROL_NOMBRE varchar(15),
	ROL_HABILITADO integer,
	primary key (ROL_NOMBRE)
)
;

-----------TABLA FUNCIONALIDADES-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.FUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.FUNCIONALIDADES
;

CREATE TABLE LOS_JUS.FUNCIONALIDADES ( 
	FUN_FUNCIONALIDAD varchar(50),
	primary key (FUN_FUNCIONALIDAD)
)
;

-----------TABLA ROLxFUNCIONALIDADES-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROLxFUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.ROLxFUNCIONALIDADES
;

CREATE TABLE LOS_JUS.ROLxFUNCIONALIDADES ( 
	ROLFUN_ROL varchar(15),
	ROLFUN_FUNCIONALIDADES VARCHAR(50),
	primary key (ROLFUN_ROL,ROLFUN_FUNCIONALIDADES),
	foreign key (ROLFUN_ROL) references LOS_JUS.ROL,
	foreign key (ROLFUN_FUNCIONALIDADES) references LOS_JUS.FUNCIONALIDADES
)
;

-----------TABLA USUARIO-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.USUARIO
;

CREATE TABLE LOS_JUS.USUARIO ( 
	USU_ID integer,
	USU_USERNAME varchar(50),
	USU_PASSWORD varchar(100),
	USU_INTENTOS integer,
	USU_HABILITADO integer,
	USU_MAIL nvarchar(255),
	USU_TELEFONO numeric(18,0),
	USU_DIRECCION varchar(400),
	USU_COD_POSTAL nvarchar(50),
	primary key (USU_ID)
)
;

-----------TABLA ROLxUSUARIO-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.ROLxUSUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.ROLxUSUARIO
;


CREATE TABLE LOS_JUS.ROLxUSUARIO ( 
	ROLUSU_ROL varchar(15),
	ROLUSU_USUARIO integer,
	primary key (ROLUSU_ROL,ROLUSU_USUARIO),
	foreign key (ROLUSU_ROL) references LOS_JUS.ROL,
	foreign key (ROLUSU_USUARIO) references LOS_JUS.USUARIO
)
;

-----------TABLA CLIENTE-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.CLIENTE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.CLIENTE
;

CREATE TABLE LOS_JUS.CLIENTE ( 
	CLI_ID integer,
	CLI_USUARIO integer,
	CLI_NOMBRE nvarchar(255),
	CLI_APELLIDO nvarchar(255),
	CLI_DNI numeric(18,0),
	CLI_TIPO_DNI char,
	CLI_FECHA_NACIMIENTO datetime,
	CLI_CUIL nvarchar(50),
	CLI_OPERACIONES_SIN_CALIFICAR integer,
	primary key (CLI_ID),
	foreign key (CLI_USUARIO) references LOS_JUS.USUARIO
)
;

-----------TABLA EMPLESA-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.EMPRESA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.EMPRESA
;

CREATE TABLE LOS_JUS.EMPRESA ( 
	EMP_ID integer,
	EMP_USUARIO integer,
	EMP_RAZON_SOCIAL nvarchar(255),
	EMP_CUIT nvarchar(50),
	EMP_CONTACTO varchar(255),
	EMP_FECHA_CREACION datetime,
	EMP_PUBLICIDADES_GRATIS integer,
	EMP_CALIFICACION integer,
	primary key (EMP_ID),
	foreign key (EMP_USUARIO) references LOS_JUS.USUARIO
)
;


-----------TABLA PUBLICACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.PUBLICACION
;

CREATE TABLE LOS_JUS.PUBLICACION ( 
	PUB_CODIGO numeric(18,0),
	PUB_EMPRESA integer,
	PUB_DESCRIPCION nvarchar(255),
	PUB_PRECIO numeric(18,0),
	PUB_PORCENTAJE numeric(18,0),
	PUB_FECHA_INICIO datetime,
	PUB_FECHA_FIN datetime,
	PUB_ESTADO nvarchar(255),
	PUB_HABILITACION_PREGUNTAS integer,
	primary key (PUB_CODIGO),
	foreign key (PUB_EMPRESA) references LOS_JUS.EMPRESA
)
;

-----------TABLA PREGUNTA-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PREGUNTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.PREGUNTA
;

CREATE TABLE LOS_JUS.PREGUNTA ( 
	PRE_CODIGO integer,
	PRE_PUBLICACION numeric(18,0),
	PRE_CLIENTE integer,
	PRE_RESPUESTA varchar(255),
	PRE_FECHA_RESPUESTA datetime,
	primary key (PRE_CODIGO),
	foreign key (PRE_PUBLICACION) references LOS_JUS.PUBLICACION,
	foreign key (PRE_CLIENTE) references LOS_JUS.CLIENTE
)
;

-----------TABLA VISUALIZACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.VISUALIZACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.VISUALIZACION
;

CREATE TABLE LOS_JUS.VISUALIZACION ( 
	VIS_CODIGO numeric(18),
	VIS_DESCRIPCION nvarchar(255),
	primary key (VIS_CODIGO)
)
;

-----------TABLA PUBLICACIONxVISUALIZACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.PUBLICACIONxVISUALIZACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.PUBLICACIONxVISUALIZACION
;

CREATE TABLE LOS_JUS.PUBLICACIONxVISUALIZACION ( 
	PUBVIS_PUBLICACION numeric(18,0),
	PUBVIS_VISUALIZACION numeric(18,0),
	PUBVIS_CANTIDAD_TIPO integer,
	primary key (PUBVIS_PUBLICACION,PUBVIS_VISUALIZACION),
	foreign key (PUBVIS_PUBLICACION) references LOS_JUS.PUBLICACION,
	foreign key (PUBVIS_VISUALIZACION) references LOS_JUS.VISUALIZACION
)
;


-----------TABLA RUBRO-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.RUBRO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.RUBRO
;

CREATE TABLE LOS_JUS.RUBRO ( 
	RUB_CODIGO integer,
	RUB_DESCRIPCION nvarchar(255),
	primary key (RUB_CODIGO)
)
;

-----------TABLA RUBROxPUBLICACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.RUBROxPUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.RUBROxPUBLICACION
;

CREATE TABLE LOS_JUS.RUBROxPUBLICACION ( 
	RUBPUB_RUBRO integer,
	RUBPUB_PUBLICACION numeric(18,0),
	primary key (RUBPUB_RUBRO,RUBPUB_PUBLICACION),
	foreign key (RUBPUB_RUBRO) references LOS_JUS.RUBRO,
	foreign key (RUBPUB_PUBLICACION) references LOS_JUS.PUBLICACION
)
;


-----------TABLA OPERACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.OPERACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.OPERACION
;

CREATE TABLE LOS_JUS.OPERACION ( 
	OPE_CODIGO integer,
	OPE_PUBLICACION numeric(18,0),
	OPE_TIPO char,
	OPE_CLIENTE integer,
	OPE_OFERTA numeric(18,2),
	OPE_CANTIDAD numeric(18,0),
	OPE_FECHA datetime,
	primary key (OPE_CODIGO),
	foreign key (OPE_PUBLICACION) references LOS_JUS.PUBLICACION,
	foreign key (OPE_CLIENTE) references LOS_JUS.CLIENTE
)
;


-----------TABLA CALIFICACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.CALIFICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.CALIFICACION
;

CREATE TABLE LOS_JUS.CALIFICACION ( 
	CAL_CODIGO numeric(18,0),
	CAL_OPERACION integer,
	CAL_ESTRELLAS numeric(18,0),
	CAL_DETALLE nvarchar(255)
	primary key (CAL_CODIGO),
	foreign key (CAL_OPERACION) references LOS_JUS.OPERACION
)
;

-----------TABLA FACTURACION-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.FACTURACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.FACTURACION
;

CREATE TABLE LOS_JUS.FACTURACION ( 
	FAC_NUMERO numeric(18,0),
	FAC_OPERACION integer,
	FAC_FORMA_PAGO nvarchar(255),
	FAC_TOTAL numeric(18,2),
	FAC_FECHA datetime,
	primary key (FAC_NUMERO),
	foreign key (FAC_OPERACION) references LOS_JUS.OPERACION
)
;


-----------TABLA COMPRA-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.COMPRA
;

CREATE TABLE LOS_JUS.COMPRA ( 
	COM_CODIGO numeric(18,0),
	COM_PUBLICACION numeric(18,0),
	COM_STOCK numeric(18,0),
	primary key (COM_CODIGO),
	foreign key (COM_PUBLICACION) references LOS_JUS.PUBLICACION
)
;

-----------TABLA SUBASTA-----------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE LOS_JUS.COMPRA
;

CREATE TABLE LOS_JUS.COMPRA ( 
	SUB_CODIGO numeric(18,0),
	SUB_PUBLICACION numeric(18,0),
	SUB_VALOR_INICIAL numeric(18,2),
	primary key (SUB_CODIGO),
	foreign key (SUB_PUBLICACION) references LOS_JUS.PUBLICACION
)
;

GO








