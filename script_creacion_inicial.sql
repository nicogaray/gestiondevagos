--###########################################################################
--###########################################################################
-- SCRIPT DE MIGRACION Y CREACION DE OBJETOS NECESARIOS
-- GRUPO: LOS_JUS
--###########################################################################
--###########################################################################

USE [GD1C2014]
GO


--###########################################################################
--###########################################################################
-- DROP PROCEDIMIENTOS
--###########################################################################
--###########################################################################

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_USUARIOS_cli]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_USUARIOS_cli

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_USUARIOS_emp]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_USUARIOS_emp


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_EMPRESAS]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_EMPRESAS

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_CLIENTES]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_CLIENTES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_RUBROS]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_RUBROS

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_VISUALIZACION]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_VISUALIZACION

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_PUBLICACIONES]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_PUBLICACIONES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_OPERACIONES]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_OPERACIONES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[MIGRAR_FACTURAS]') AND type in ('P', 'PC'))
DROP PROCEDURE LOS_JUS.MIGRAR_FACTURAS

--###########################################################################
--###########################################################################
-- DROP FKs 
--###########################################################################
--###########################################################################

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROLxFUNCIONALIDADES') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.ROLxFUNCIONALIDADES DROP CONSTRAINT ROLFUN_ROL
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROLxFUNCIONALIDADES') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.ROLxFUNCIONALIDADES DROP CONSTRAINT ROLFUN_FUNCIONALIDADES
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROLxUSUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.ROLxUSUARIO DROP CONSTRAINT ROLUSU_ROL
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROLxUSUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.ROLxUSUARIO DROP CONSTRAINT ROLUSU_USUARIO
;


IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.CLIENTE') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.CLIENTE DROP CONSTRAINT CLI_USUARIO
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.EMPRESA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.EMPRESA DROP CONSTRAINT EMP_USUARIO
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.PUBLICACION DROP CONSTRAINT PUB_EMPRESA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PREGUNTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.PREGUNTA DROP CONSTRAINT PRE_PUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PREGUNTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.PREGUNTA DROP CONSTRAINT CLIENTE
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PUBLICACIONxVISUALIZACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.PUBLICACIONxVISUALIZACION DROP CONSTRAINT PUBVIS_PUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PUBLICACIONxVISUALIZACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.PUBLICACIONxVISUALIZACION DROP CONSTRAINT PUBVIS_VISUALIZACION
;


IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.OPERACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.OPERACION DROP CONSTRAINT OPE_CLIENTE
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.CALIFICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.CALIFICACION DROP CONSTRAINT CAL_OPERACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ITEM') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.ITEM DROP CONSTRAINT ITE_FACTURA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.FACTURACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.FACTURACION DROP CONSTRAINT FAC_OPERACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.COMPRA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.COMPRA DROP CONSTRAINT COM_PUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.SUBASTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.SUBASTA DROP CONSTRAINT SUB_PUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.RUBROxPUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.RUBROxPUBLICACION DROP CONSTRAINT RUBPUB_RUBRO
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.RUBROxPUBLICACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.RUBROxPUBLICACION DROP CONSTRAINT RUBPUB_PUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.OPERACION') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE LOS_JUS.OPERACION DROP CONSTRAINT OPE_PUBLICACION
;

GO

--###########################################################################
--###########################################################################
-- DROP TABLES
--###########################################################################

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROLxUSUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.ROLxUSUARIO
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROLxFUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.ROLxFUNCIONALIDADES
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.ROL
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.FUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.FUNCIONALIDADES
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PUBLICACIONxVISUALIZACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.PUBLICACIONxVISUALIZACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.RUBROxPUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.RUBROxPUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.RUBRO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.RUBRO
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.VISUALIZACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.VISUALIZACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PREGUNTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.PREGUNTA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.COMPRA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.CALIFICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.CALIFICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.ITEM') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.ITEM
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.FACTURACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.FACTURACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.OPERACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.OPERACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.CLIENTE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.CLIENTE
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.COMPRA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.SUBASTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.SUBASTA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.PUBLICACION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.PUBLICACION
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.EMPRESA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.EMPRESA
;

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('LOS_JUS.USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE LOS_JUS.USUARIO
;

GO
/*
IF EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = 'LOS_JUS' ) 
    EXEC('DROP SCHEMA [LOS_JUS]');
GO

IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = 'LOS_JUS' ) 
    EXEC('CREATE SCHEMA [LOS_JUS] AUTHORIZATION [gd]');
GO*/
--###########################################################################
--###########################################################################
-- CREACION DE TABLAS 
--###########################################################################
--###########################################################################

-----------TABLA ROL-----------


CREATE TABLE LOS_JUS.ROL ( 
	ROL_NOMBRE varchar(15),
	ROL_HABILITADO integer,
	ROL_ELIMINADO integer DEFAULT 0,
	primary key (ROL_NOMBRE)
)
;

-----------TABLA FUNCIONALIDADES-----------


CREATE TABLE LOS_JUS.FUNCIONALIDADES ( 
	FUN_FUNCIONALIDAD varchar(50),
	FUN_DESCRIPCION varchar(255) DEFAULT '',
	FUN_ELIMINADO integer DEFAULT 0,
	primary key (FUN_FUNCIONALIDAD)
)
;

-----------TABLA ROLxFUNCIONALIDADES-----------


CREATE TABLE LOS_JUS.ROLxFUNCIONALIDADES ( 
    ROLFUN_ID integer IDENTITY(1,1),
	ROLFUN_ROL varchar(15),
	ROLFUN_FUNCIONALIDADES VARCHAR(50),
	primary key (ROLFUN_ID),
	foreign key (ROLFUN_ROL) references LOS_JUS.ROL,
	foreign key (ROLFUN_FUNCIONALIDADES) references LOS_JUS.FUNCIONALIDADES
)
;
 
-----------TABLA USUARIO-----------

CREATE TABLE LOS_JUS.USUARIO ( 
	USU_ID integer IDENTITY(1,1),
	USU_USERNAME varchar(50) NOT NULL UNIQUE,
	USU_PASSWORD varchar(100) NOT NULL,
	USU_INTENTOS integer DEFAULT 0,
	USU_ELIMINADO integer DEFAULT 0,
	primary key (USU_ID)
)
;

-----------TABLA ROLxUSUARIO-----------



CREATE TABLE LOS_JUS.ROLxUSUARIO ( 
    ROLUSU_ID integer identity(1,1),
	ROLUSU_ROL varchar(15),
	ROLUSU_USUARIO integer,
	primary key (ROLUSU_ID),
	foreign key (ROLUSU_ROL) references LOS_JUS.ROL,
	foreign key (ROLUSU_USUARIO) references LOS_JUS.USUARIO
)
;

-----------TABLA CLIENTE-----------


CREATE TABLE LOS_JUS.CLIENTE ( 
	CLI_ID integer,
	CLI_NOMBRE nvarchar(255),
	CLI_APELLIDO nvarchar(255),
	CLI_DNI numeric(18,0),
	CLI_TIPO_DNI varchar(3) DEFAULT 'DNI',
	CLI_FECHA_NACIMIENTO datetime,
	CLI_CUIL nvarchar(50) default 0,
	CLI_MAIL nvarchar(255) NOT NULL UNIQUE,
	CLI_TELEFONO numeric(18,0),
	CLI_DIRECCION varchar(255),
	CLI_COD_POSTAL nvarchar(50),
	CLI_OPERACIONES_SIN_CALIFICAR integer default 0,
	CLI_HABILITADO integer DEFAULT 1,
	CLI_ELIMINADO integer DEFAULT 0,
	primary key (CLI_ID),
	foreign key (CLI_ID) references LOS_JUS.USUARIO
)
;

-----------TABLA EMPLESA-----------


CREATE TABLE LOS_JUS.EMPRESA ( 
	EMP_ID integer,
	EMP_RAZON_SOCIAL nvarchar(255),
	EMP_CUIT nvarchar(50),
	EMP_CONTACTO varchar(255),
	EMP_FECHA_CREACION datetime,
	EMP_MAIL nvarchar(255) NOT NULL UNIQUE,
	EMP_TELEFONO numeric(18,0),
	EMP_DIRECCION varchar(255),
	EMP_COD_POSTAL nvarchar(50),
	EMP_PUBLICIDADES_GRATIS integer,
	EMP_CALIFICACION integer,
	EMP_HABILITADO integer DEFAULT 1,
	EMP_ELIMINADO integer DEFAULT 0,
	primary key (EMP_ID),
	foreign key (EMP_ID) references LOS_JUS.USUARIO
)
;


-----------TABLA PUBLICACION-----------


CREATE TABLE LOS_JUS.PUBLICACION ( 
	PUB_CODIGO numeric(18,0),
	PUB_EMPRESA integer,
	PUB_DESCRIPCION nvarchar(255),
	PUB_PRECIO numeric(18,0),
	PUB_FECHA_INICIO datetime,
	PUB_FECHA_FIN datetime,
	PUB_ESTADO nvarchar(255),
	PUB_HABILITACION_PREGUNTAS integer,
	PUB_ELIMINADO integer DEFAULT 0,
	primary key (PUB_CODIGO),
	foreign key (PUB_EMPRESA) references LOS_JUS.EMPRESA
)
;

-----------TABLA PREGUNTA-----------


CREATE TABLE LOS_JUS.PREGUNTA ( 
	PRE_CODIGO integer identity(1,1),
	PRE_PUBLICACION numeric(18,0),
	PRE_CLIENTE integer,
	PRE_PREGUNTA nvarchar(255),
	PRE_RESPUESTA nvarchar(255),
	PRE_FECHA_RESPUESTA datetime,
	primary key (PRE_CODIGO),
	foreign key (PRE_PUBLICACION) references LOS_JUS.PUBLICACION,
	foreign key (PRE_CLIENTE) references LOS_JUS.CLIENTE
)
;

-----------TABLA VISUALIZACION-----------


CREATE TABLE LOS_JUS.VISUALIZACION ( 
	VIS_CODIGO numeric(18),
	VIS_NOMBRE nvarchar(50),
	VIS_PRECIO numeric(18,2),
	VIS_PORCENTAJE numeric(18,2),
	VIS_DESCRIPCION nvarchar(255),
	VIS_ELIMINADO integer DEFAULT 0,
	primary key (VIS_CODIGO)
)
;

-----------TABLA PUBLICACIONxVISUALIZACION-----------


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


CREATE TABLE LOS_JUS.RUBRO ( 
	RUB_CODIGO integer IDENTITY(1,1),
	RUB_DESCRIPCION varchar(255),
	RUB_ELIMINADO integer DEFAULT 0,
	primary key (RUB_CODIGO)
)
;

-----------TABLA RUBROxPUBLICACION-----------

CREATE TABLE LOS_JUS.RUBROxPUBLICACION ( 
	RUBPUB_RUBRO integer,
	RUBPUB_PUBLICACION numeric(18,0),
	primary key (RUBPUB_RUBRO,RUBPUB_PUBLICACION),
	foreign key (RUBPUB_RUBRO) references LOS_JUS.RUBRO,
	foreign key (RUBPUB_PUBLICACION) references LOS_JUS.PUBLICACION
)
;


-----------TABLA OPERACION-----------


CREATE TABLE LOS_JUS.OPERACION ( 
	OPE_CODIGO integer IDENTITY(1,1),
	OPE_PUBLICACION numeric(18,0),
	OPE_TIPO char,
	OPE_CLIENTE integer,
	OPE_OFERTA numeric(18,2),
	OPE_CANTIDAD numeric(18,0),
	OPE_FECHA datetime,
	OPE_ELIMINADO integer DEFAULT 0,
	primary key (OPE_CODIGO),
	foreign key (OPE_PUBLICACION) references LOS_JUS.PUBLICACION,
	foreign key (OPE_CLIENTE) references LOS_JUS.CLIENTE
)
;


-----------TABLA CALIFICACION-----------


CREATE TABLE LOS_JUS.CALIFICACION ( 
	CAL_CODIGO numeric(18,0),
	CAL_OPERACION integer,
	CAL_ESTRELLAS numeric(18,0),
	CAL_DETALLE nvarchar(255),
	CAL_TIPO varchar(1),
	CAL_ELIMINADO integer DEFAULT 0,
	primary key (CAL_CODIGO),
	foreign key (CAL_OPERACION) references LOS_JUS.OPERACION
)
;

-----------TABLA FACTURACION-----------


CREATE TABLE LOS_JUS.FACTURACION ( 
	FAC_NUMERO numeric(18,0),
	FAC_OPERACION integer,
	FAC_FORMA_PAGO nvarchar(255),
	FAC_TOTAL numeric(18,2),
	FAC_FECHA datetime,
	FAC_ELIMINADO integer DEFAULT 0,
	primary key (FAC_NUMERO),
	foreign key (FAC_OPERACION) references LOS_JUS.OPERACION
)
;

-----------TABLA ITEM-----------


CREATE TABLE LOS_JUS.ITEM( 
	ITE_CODIGO integer IDENTITY(1,1),
	ITE_FACTURA numeric(18,0),
	ITE_MONTO numeric(18,2),
	ITE_CANTIDAD numeric(18,0),
	primary key (ITE_CODIGO),
	foreign key (ITE_FACTURA) references LOS_JUS.FACTURACION
)
;

-----------TABLA COMPRA-----------


CREATE TABLE LOS_JUS.COMPRA ( 
	COM_CODIGO numeric(18,0),
	COM_PUBLICACION numeric(18,0),
	COM_STOCK numeric(18,0),
	COM_ELIMINADO integer DEFAULT 0,
	primary key (COM_CODIGO),
	foreign key (COM_PUBLICACION) references LOS_JUS.PUBLICACION
)
;

-----------TABLA SUBASTA-----------


CREATE TABLE LOS_JUS.SUBASTA ( 
	SUB_CODIGO numeric(18,0),
	SUB_PUBLICACION numeric(18,0),
	SUB_VALOR_INICIAL numeric(18,2),
	SUB_ELIMINADO integer DEFAULT 0,
	primary key (SUB_CODIGO),
	foreign key (SUB_PUBLICACION) references LOS_JUS.PUBLICACION
)
;

 
GO


 
-------- INSERTS ROLES ------------

INSERT INTO LOS_JUS.ROL (ROL_NOMBRE,ROL_HABILITADO)VALUES('Cliente', 1),('Empresa', 1),('Administrativo', 1);
GO


-------- INSERTS FUNCIONALIDADES ------
INSERT INTO LOS_JUS.FUNCIONALIDADES (FUN_FUNCIONALIDAD, FUN_DESCRIPCION) VALUES 
('ABM DE ROL',''),
('ABM DE CLIENTE',''),
('ABM DE EMPRESA',''),
('ABM DE RUBRO',''),
('ABM DE VISIBILIDAD',''),
('LISTADOS ESTADISTICOS',''),
('MODIFICACION/REGISTRO USUARIO',''),
('COMPRA',''),
('OFERTA',''),
('FACTURAR PUBLICACION',''),
('VER RESPUESTAS A PREGUNTAS',''),
('CALIFICAR VENDEDOR',''),
('HISTORIAL DEL CLIENTE',''),
('PUBLICAR',''),
('RESPONDER PREGUNTAS',''),
('HISTORIAL DE LA EMPRESA','');
GO

INSERT INTO LOS_JUS.ROLxFUNCIONALIDADES (ROLFUN_ROL, ROLFUN_FUNCIONALIDADES) VALUES 
('Administrativo','ABM DE ROL'),
('Administrativo','ABM DE CLIENTE'),
('Administrativo','ABM DE EMPRESA'),
('Administrativo','ABM DE RUBRO'),
('Administrativo','ABM DE VISIBILIDAD'),
('Administrativo','LISTADOS ESTADISTICOS'),
('Cliente','MODIFICACION/REGISTRO USUARIO'),
('Cliente','COMPRA'),
('Cliente','OFERTA'),
('Cliente','FACTURAR PUBLICACION'),
('Cliente','VER RESPUESTAS A PREGUNTAS'),
('Cliente','CALIFICAR VENDEDOR'),
('Cliente','HISTORIAL DEL CLIENTE'),
('Empresa','MODIFICACION/REGISTRO USUARIO'),
('Empresa','PUBLICAR'),
('Empresa','RESPONDER PREGUNTAS'),
('Empresa','HISTORIAL DE LA EMPRESA');
GO

-------- INSERT ADMIN USER ------------

INSERT INTO LOS_JUS.USUARIO (USU_USERNAME,USU_PASSWORD,USU_INTENTOS,USU_ELIMINADO) VALUES ('admin','4a29adc13c3724d2914af14eae655180621f4c90020c13429d172a207b246119',0,0);
GO
INSERT INTO LOS_JUS.ROLxUSUARIO (ROLUSU_ROL,ROLUSU_USUARIO) VALUES ('Administrativo',1);
GO


-------- MIGRACON CLIENTES EN USUARIOS------------
-- password= gd2014  
CREATE PROCEDURE LOS_JUS.MIGRAR_USUARIOS_cli
AS
DECLARE	
	@password varchar(100)
BEGIN
	set @password='8623f73bbb01f6c2eb02a97f652301f6a59a1be8c75da5266bc3475c9e1e569d'
	
	INSERT INTO LOS_JUS.USUARIO 
		(USU_USERNAME
		,USU_PASSWORD
		,USU_INTENTOS
		,USU_ELIMINADO) 
		SELECT DISTINCT [Cli_Dni]
		  ,@password
		  ,0
		  ,0
		FROM [GD1C2014].[gd_esquema].[Maestra]
		WHERE [Cli_Dni] IS NOT NULL
		
	INSERT INTO LOS_JUS.CLIENTE
		(CLI_DNI
		,CLI_ID
		,CLI_NOMBRE
		,CLI_APELLIDO
		,CLI_TIPO_DNI
		,CLI_FECHA_NACIMIENTO
		,CLI_CUIL
		,CLI_MAIL
		,CLI_TELEFONO
		,CLI_DIRECCION
		,CLI_COD_POSTAL
		,CLI_OPERACIONES_SIN_CALIFICAR
		,CLI_HABILITADO
		,CLI_ELIMINADO)
		SELECT DISTINCT
			[Cli_Dni],
			(SELECT USU_ID FROM LOS_JUS.USUARIO WHERE USU_USERNAME = Cast([Cli_Dni] as VARCHAR)),
			[Cli_Nombre],
			[Cli_Apeliido],
			'DNI',
			[Cli_Fecha_Nac],
			'0-00000000-0',
			[Cli_Mail],
			44444444,
			[Cli_Dom_Calle] + ' ' + Cast([Cli_Nro_Calle] as VARCHAR) + ' Piso ' + Cast([Cli_Piso] as VARCHAR) + ' Dpto ' + [Cli_Depto],
			[Cli_Cod_Postal],
			0,
			1,
			0
		FROM [GD1C2014].[gd_esquema].[Maestra]
		WHERE [Cli_Dni] IS NOT NULL
		
	INSERT INTO LOS_JUS.ROLxUSUARIO 
		(ROLUSU_ROL, ROLUSU_USUARIO)
		SELECT 'Cliente', CLI_ID FROM LOS_JUS.CLIENTE
	
END
GO

exec LOS_JUS.MIGRAR_USUARIOS_cli
go 

-------- MIGRACON EMPRESAS EN USUARIOS ------------
-- password= gd2014  
CREATE PROCEDURE LOS_JUS.MIGRAR_USUARIOS_emp
AS 
DECLARE	
	@password varchar(100)
BEGIN
	set @password='8623f73bbb01f6c2eb02a97f652301f6a59a1be8c75da5266bc3475c9e1e569d'
	
	INSERT INTO LOS_JUS.USUARIO 
		(USU_USERNAME
		,USU_PASSWORD
		,USU_INTENTOS
		,USU_ELIMINADO) 
		SELECT DISTINCT [Publ_Empresa_Cuit]
		  ,@password
		  ,0
		  ,0
		FROM [GD1C2014].[gd_esquema].[Maestra]
		WHERE [Publ_Empresa_Cuit] IS NOT NULL
		
	INSERT INTO LOS_JUS.EMPRESA
		(EMP_CUIT
		,EMP_ID
		,EMP_RAZON_SOCIAL
		,EMP_CONTACTO
		,EMP_FECHA_CREACION
		,EMP_MAIL
		,EMP_TELEFONO
		,EMP_DIRECCION
		,EMP_COD_POSTAL
		,EMP_PUBLICIDADES_GRATIS
		,EMP_HABILITADO
		,EMP_ELIMINADO)
		SELECT DISTINCT
			[Publ_Empresa_Cuit],
			(SELECT USU_ID FROM LOS_JUS.USUARIO WHERE USU_USERNAME = [Publ_Empresa_Cuit]),
			[Publ_Empresa_Razon_Social],
			'Director',
			[Publ_Empresa_Fecha_Creacion],
			[Publ_Empresa_Mail],
			44444444,
			[Publ_Empresa_Dom_Calle] + ' ' + Cast([Publ_Empresa_Nro_Calle] as VARCHAR) + ' Piso ' +  ' Dpto ' + [Publ_Empresa_Depto], 
			[Publ_Empresa_Cod_Postal],
			0,
			1,
			0
		FROM [GD1C2014].[gd_esquema].[Maestra]
		WHERE [Publ_Empresa_Cuit] IS NOT NULL
		
	INSERT INTO LOS_JUS.ROLxUSUARIO 
		(ROLUSU_ROL, ROLUSU_USUARIO)
		SELECT 'Empresa', EMP_ID FROM LOS_JUS.EMPRESA

END
GO

EXEC LOS_JUS.MIGRAR_USUARIOS_emp
GO


-----------------------------------------------------
-------- MIGRACON RUBROS  ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_RUBROS
AS
BEGIN

	INSERT INTO LOS_JUS.RUBRO (RUB_DESCRIPCION) 
		SELECT DISTINCT [Publicacion_Rubro_Descripcion]
		FROM [GD1C2014].[gd_esquema].[Maestra]	
END
GO

EXEC LOS_JUS.MIGRAR_RUBROS
GO

-----------------------------------------------------
-------- MIGRACON TIPOS DE VISUALIZACION  ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_VISUALIZACION
AS 
BEGIN
	INSERT INTO LOS_JUS.VISUALIZACION (VIS_CODIGO, VIS_NOMBRE, VIS_PRECIO, VIS_PORCENTAJE)
		SELECT [Publicacion_Visibilidad_Cod]
			,[Publicacion_Visibilidad_Desc]
			,[Publicacion_Visibilidad_Precio]
			,[Publicacion_Visibilidad_Porcentaje]
		FROM [GD1C2014].[gd_esquema].[Maestra]
		GROUP BY [Publicacion_Visibilidad_Cod]
			,[Publicacion_Visibilidad_Desc]
			,[Publicacion_Visibilidad_Precio]
			,[Publicacion_Visibilidad_Porcentaje]
		ORDER BY [Publicacion_Visibilidad_Cod] ASC	
END
go

exec LOS_JUS.MIGRAR_VISUALIZACION
go

-----------------------------------------------------
-------- MIGRACON PUBLICACIONES ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_PUBLICACIONES
AS 
BEGIN
	INSERT INTO LOS_JUS.PUBLICACION 
	(PUB_CODIGO, PUB_EMPRESA, PUB_DESCRIPCION, PUB_PRECIO, PUB_FECHA_INICIO, PUB_FECHA_FIN, PUB_ESTADO, PUB_HABILITACION_PREGUNTAS)
	SELECT DISTINCT ([Publicacion_Cod])
		,(SELECT LOS_JUS.EMPRESA.EMP_ID 
		FROM LOS_JUS.EMPRESA 
		WHERE LOS_JUS.EMPRESA.EMP_CUIT LIKE [Publ_Empresa_Cuit])
		,[Publicacion_Descripcion]
		,[Publicacion_Precio]
		,[Publicacion_Fecha]
		,[Publicacion_Fecha_Venc]
		,[Publicacion_Estado]
		,1
	FROM [GD1C2014].[gd_esquema].[Maestra]
	ORDER BY [Publicacion_Cod] ASC

	INSERT INTO LOS_JUS.COMPRA (COM_CODIGO, COM_PUBLICACION, COM_STOCK) 
	SELECT DISTINCT ([Publicacion_Cod]) AS CodigoCompra 
		,[Publicacion_Cod]
		,[Publicacion_Stock]
	FROM [GD1C2014].[gd_esquema].[Maestra]
	WHERE [Publicacion_Tipo] LIKE 'Compra Inmediata'
	ORDER BY [Publicacion_Cod] ASC
	
	INSERT INTO LOS_JUS.SUBASTA (SUB_CODIGO, SUB_PUBLICACION, SUB_VALOR_INICIAL)
	SELECT DISTINCT ([Publicacion_Cod]) AS CodigoCompra 
		,[Publicacion_Cod]
		,[Publicacion_Precio]
	FROM [GD1C2014].[gd_esquema].[Maestra]
	WHERE [Publicacion_Tipo] LIKE 'Subasta'
	ORDER BY [Publicacion_Cod] ASC
	
	INSERT INTO LOS_JUS.RUBROxPUBLICACION (RUBPUB_PUBLICACION, RUBPUB_RUBRO)
	SELECT DISTINCT ([Publicacion_Cod])
		,(SELECT LOS_JUS.RUBRO.RUB_CODIGO 
		 FROM LOS_JUS.RUBRO 
		 WHERE LOS_JUS.RUBRO.RUB_DESCRIPCION LIKE [Publicacion_Rubro_Descripcion])
	FROM [GD1C2014].[gd_esquema].[Maestra]
	ORDER BY [Publicacion_Cod] ASC
	
	INSERT INTO LOS_JUS.PUBLICACIONxVISUALIZACION (PUBVIS_PUBLICACION, PUBVIS_VISUALIZACION, PUBVIS_CANTIDAD_TIPO) 
	SELECT DISTINCT ([Publicacion_Cod])
		,[Publicacion_Visibilidad_Cod]
		,[Publicacion_Stock]
	FROM [GD1C2014].[gd_esquema].[Maestra]
	ORDER BY [Publicacion_Cod] ASC
		
END
GO

EXEC LOS_JUS.MIGRAR_PUBLICACIONES
GO

-----------------------------------------------------
-------- MIGRACON OPERACIONES ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_OPERACIONES
AS 
BEGIN

	INSERT INTO LOS_JUS.OPERACION
			([OPE_PUBLICACION]
			,[OPE_TIPO]
			,[OPE_CLIENTE]
			,[OPE_CANTIDAD]
			,[OPE_FECHA])
		SELECT DISTINCT [Publicacion_Cod]
			,'C'
			,CLI.CLI_ID
			,[Compra_Cantidad]
			,[Compra_Fecha]
		FROM [GD1C2014].[gd_esquema].[Maestra] LEFT JOIN LOS_JUS.CLIENTE CLI ON [GD1C2014].[gd_esquema].[Maestra].[Cli_Dni] = CLI.CLI_DNI
		WHERE [Oferta_Fecha] IS NULL AND [Compra_Fecha] IS NOT NULL
			AND [Publicacion_Tipo] LIKE 'Compra Inmediata' AND [Calificacion_Codigo] IS NULL
		ORDER BY [Publicacion_Cod] ASC

	INSERT INTO LOS_JUS.OPERACION 
		([OPE_PUBLICACION]
		,[OPE_TIPO]
		,[OPE_CLIENTE]
		,[OPE_OFERTA]
		,[OPE_FECHA])
		SELECT [Publicacion_Cod]
			,'S'
			,CLI.CLI_ID
			,[Oferta_Monto]
			,[Oferta_Fecha]
		FROM [GD1C2014].[gd_esquema].[Maestra] LEFT JOIN LOS_JUS.CLIENTE CLI ON [GD1C2014].[gd_esquema].[Maestra].[Cli_Dni] = CLI.CLI_DNI
		WHERE [Oferta_Fecha] IS NOT NULL AND [Compra_Fecha] IS NULL
			AND [Publicacion_Tipo] LIKE 'Subasta' AND [Calificacion_Codigo] IS NULL
		ORDER BY [Publicacion_Cod] ASC

	INSERT INTO LOS_JUS.CALIFICACION 
		(CAL_CODIGO
		,CAL_OPERACION
		,CAL_ESTRELLAS
		,CAL_DETALLE
		,CAL_TIPO)
		SELECT [Calificacion_Codigo] 
			,(SELECT TOP 1 OPE_CODIGO FROM LOS_JUS.OPERACION WHERE OPE_PUBLICACION = [Publicacion_Cod] AND OPE_FECHA = [Compra_Fecha] and CLI.CLI_ID = OPE_CLIENTE)
			,[Calificacion_Cant_Estrellas]
			,[Calificacion_Descripcion]
			,CASE WHEN [Publ_Empresa_Cuit] IS NULL THEN 'C' ELSE 'E' END
		FROM [GD1C2014].[gd_esquema].[Maestra] JOIN LOS_JUS.CLIENTE CLI ON [GD1C2014].[gd_esquema].[Maestra].[Cli_Dni] = CLI.CLI_DNI
		WHERE [Calificacion_Codigo] IS NOT NULL
		ORDER BY  [Calificacion_Codigo] ASC
			
END
GO

EXEC LOS_JUS.MIGRAR_OPERACIONES
GO


-----------------------------------------------------
-------- MIGRACION FACTURAS ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_FACTURAS
AS 
BEGIN

	INSERT INTO LOS_JUS.FACTURACION ([FAC_NUMERO],[FAC_OPERACION],[FAC_FECHA],[FAC_TOTAL],FAC_FORMA_PAGO)
		SELECT DISTINCT [Factura_Nro]
			,(SELECT TOP 1 LOS_JUS.OPERACION.OPE_CODIGO
				 FROM LOS_JUS.OPERACION 
				 WHERE LOS_JUS.OPERACION.OPE_PUBLICACION = [Publicacion_Cod])
			,[Factura_Fecha]
			,[Factura_Total]
			,[Forma_Pago_Desc]
		FROM [GD1C2014].[gd_esquema].[Maestra]
		WHERE [Factura_Nro] IS NOT NULL
		ORDER BY [Factura_Nro] ASC
	
	INSERT INTO LOS_JUS.ITEM (ITE_FACTURA,ITE_MONTO,ITE_CANTIDAD)
		SELECT [Factura_Nro]
			,[Item_Factura_Monto]
			,[Item_Factura_Cantidad]
		FROM [GD1C2014].[gd_esquema].[Maestra]
		WHERE [Factura_Nro] IS NOT NULL
		ORDER BY [Factura_Nro] ASC
		
END
GO

EXEC LOS_JUS.MIGRAR_FACTURAS
GO


------- FUNCION BUSCAR CLIENTES -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarClientes]'))
DROP FUNCTION LOS_JUS.buscarClientes
GO

CREATE FUNCTION LOS_JUS.buscarClientes 
(
@nombre nvarchar(255) = NULL,
@apellido nvarchar(255) = NULL,
@email nvarchar(255) = NULL,
@tipo varchar(3) = 'DNI',
@dni numeric(18,0) = NULL
)
RETURNS TABLE
AS

RETURN (
	SELECT C.*
	FROM LOS_JUS.CLIENTE C 
	WHERE 
	C.CLI_NOMBRE LIKE '%' + ISNULL(@nombre, C.CLI_NOMBRE) + '%' 
	AND C.CLI_APELLIDO LIKE '%' + ISNULL(@apellido, C.CLI_APELLIDO) + '%'
	AND C.CLI_MAIL LIKE '%' + ISNULL(@email, C.CLI_MAIL) + '%'
	AND C.CLI_TIPO_DNI LIKE @tipo
	AND C.CLI_DNI = ISNULL(CASE WHEN @dni = -1 THEN NULL ELSE @dni END , C.CLI_DNI)
	AND C.CLI_HABILITADO = 1
	AND C.CLI_ELIMINADO = 0
)

GO

------- FUNCION BUSCAR EMPRESAS -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarEmpresas]'))
DROP FUNCTION LOS_JUS.buscarEmpresas
GO

CREATE FUNCTION LOS_JUS.buscarEmpresas 
(
@razon nvarchar(255) = NULL,
@cuit nvarchar(50) = NULL,
@email nvarchar(255) = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT E.*
	FROM LOS_JUS.EMPRESA E
	WHERE 
	E.EMP_RAZON_SOCIAL LIKE '%' + ISNULL(@razon, E.EMP_RAZON_SOCIAL) + '%' 
	AND E.EMP_MAIL LIKE '%' + ISNULL(@email, E.EMP_MAIL) + '%'
	AND E.EMP_CUIT = ISNULL(@cuit, E.EMP_CUIT)
	AND E.EMP_HABILITADO = 1
	AND E.EMP_ELIMINADO = 0
)
GO

------ FUNCION BUSCAR VISIBILIDADES -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarVisibilidad]'))
DROP FUNCTION LOS_JUS.buscarVisibilidad
GO

CREATE FUNCTION LOS_JUS.buscarVisibilidad 
(
@descripcion nvarchar(50) = NULL,
@precio numeric(18,2) = NULL,
@porcentaje numeric(18,2) = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT *
	FROM LOS_JUS.VISUALIZACION V
	WHERE 
	V.VIS_NOMBRE LIKE '%' + ISNULL(@descripcion, V.VIS_NOMBRE) + '%' 
	AND V.VIS_PRECIO = ISNULL(CASE WHEN @precio = -1 THEN NULL ELSE @precio END, V.VIS_PRECIO)
	AND V.VIS_PORCENTAJE = ISNULL(CASE WHEN @porcentaje = -1 THEN NULL ELSE @porcentaje END, V.VIS_PORCENTAJE)
	AND V.VIS_ELIMINADO = 0
)
GO

------- FUNCION BUSCAR VENDEDORES -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarVendedores]'))
DROP FUNCTION LOS_JUS.buscarVendedores
GO

CREATE FUNCTION LOS_JUS.buscarVendedores 
(
@idCliente integer = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT E.*, O.*, C.*
	FROM ((LOS_JUS.PUBLICACION P INNER JOIN LOS_JUS.OPERACION O ON P.PUB_CODIGO = O.OPE_PUBLICACION)
	LEFT JOIN LOS_JUS.CALIFICACION C ON O.OPE_CODIGO = C.CAL_OPERACION)
	INNER JOIN LOS_JUS.EMPRESA E ON P.PUB_EMPRESA = E.EMP_ID
	WHERE 
	O.OPE_CLIENTE = ISNULL (CASE WHEN @idCliente = -1 THEN NULL ELSE @idCliente END, O.OPE_CLIENTE)
	AND C.CAL_CODIGO IS NULL
	AND E.EMP_ELIMINADO = 0
)
GO


------- FUNCION BUSCAR PREGUNTAS SIN RESPONDER -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarPreguntasSinResponder]'))
DROP FUNCTION LOS_JUS.buscarPreguntasSinResponder
GO

CREATE FUNCTION LOS_JUS.buscarPreguntasSinResponder
(
@idEmpresa integer = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT PRE.*
	FROM (LOS_JUS.PUBLICACION P INNER JOIN LOS_JUS.PREGUNTA PRE ON P.PUB_CODIGO = PRE.PRE_PUBLICACION)
	INNER JOIN LOS_JUS.EMPRESA E ON P.PUB_EMPRESA = E.EMP_ID
	WHERE 
	E.EMP_ID = ISNULL (CASE WHEN @idEmpresa = -1 THEN NULL ELSE @idEmpresa END, E.EMP_ID)
	AND PRE.PRE_RESPUESTA IS NULL
)
GO

------- FUNCION BUSCAR PREGUNTAS CON RESPUESTAS -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[verRespuestas]'))
DROP FUNCTION LOS_JUS.verRespuestas
GO

CREATE FUNCTION LOS_JUS.verRespuestas
(
@idCliente integer = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT PRE.*
	FROM LOS_JUS.PREGUNTA PRE 
	WHERE 
	PRE.PRE_CLIENTE = ISNULL (CASE WHEN @idCliente = -1 THEN NULL ELSE @idCliente END, PRE.PRE_CLIENTE)
	AND PRE.PRE_RESPUESTA IS NOT NULL
)
GO



------- FUNCION BUSCAR INICIO TRIMESTRE -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[inicioTrim]'))
DROP FUNCTION LOS_JUS.inicioTrim
GO

CREATE FUNCTION LOS_JUS.inicioTrim
(
@anio varchar(4) = NULL,
@trim numeric(18,0) = 1
)
RETURNS datetime
AS
BEGIN
DECLARE @fecha varchar(24) = null;
SET @fecha = (CASE @trim 
		when 1 then  ISNULL(@anio,'2014') + '-01-01 00:00:00.000'
		when 2 then  ISNULL(@anio,'2014') + '-01-04 00:00:00.000'
		when 3 then  ISNULL(@anio,'2014') + '-01-07 00:00:00.000'
		else ISNULL(@anio,'2014') + '-10-01 00:00:00.000'
	END)
RETURN CONVERT(datetime,@fecha)
END
GO

------- FUNCION BUSCAR FIN TRIMESTRE -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[finTrim]'))
DROP FUNCTION LOS_JUS.finTrim
GO

CREATE FUNCTION LOS_JUS.finTrim
(
@anio varchar(4) = NULL,
@trim numeric(18,0) = 1
)
RETURNS datetime
AS
BEGIN
DECLARE @fecha varchar(24) = null;
SET @fecha = (CASE @trim 
	when 1 then  ISNULL(@anio,'2014') + '-31-03 23:59:59.000'
	when 2 then  ISNULL(@anio,'2014') + '-30-06 23:59:59.000'
	when 3 then  ISNULL(@anio,'2014') + '-30-09 23:59:59.000'
	else ISNULL(@anio,'2014') + '-31-12 23:59:59.000'
	END)
RETURN CONVERT(datetime,@fecha)
END
GO


------- FUNCION BUSCAR ESTADISTICAS 1 -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[estadisticas1]'))
DROP FUNCTION LOS_JUS.estadisticas1
GO

CREATE FUNCTION LOS_JUS.estadisticas1
(
@anio varchar(4) = NULL,
@mes varchar(2) = NULL,
@trimAnio varchar(4) = NULL,
@trim numeric(18,0) = NULL,
@vis numeric(18,0) = 10002
)
RETURNS TABLE
AS
RETURN (
	SELECT TOP 5
		COUNT(PUB.PUB_CODIGO) AS PUB_COUNT
		,[EMP_ID]
		,[EMP_RAZON_SOCIAL]
		,[EMP_CUIT]
		,[EMP_CONTACTO]
		,[EMP_FECHA_CREACION]
		,[EMP_MAIL]
		,[EMP_TELEFONO]
		,[EMP_DIRECCION]
		,[EMP_COD_POSTAL]
		,[EMP_PUBLICIDADES_GRATIS]
		,[EMP_CALIFICACION]
		,[EMP_HABILITADO]
	FROM LOS_JUS.PUBLICACION PUB 
		JOIN LOS_JUS.PUBLICACIONxVISUALIZACION PV ON PV.PUBVIS_PUBLICACION = PUB.PUB_CODIGO 
		JOIN LOS_JUS.VISUALIZACION VIS ON VIS.VIS_CODIGO = PV.PUBVIS_VISUALIZACION 
		JOIN LOS_JUS.EMPRESA EMP ON PUB.PUB_EMPRESA = EMP.EMP_ID
	WHERE PUB.PUB_CODIGO NOT IN (SELECT OPE_CODIGO FROM LOS_JUS.OPERACION WHERE OPE_PUBLICACION = PUB.PUB_CODIGO)
		AND VIS.VIS_CODIGO = ISNULL(@vis, VIS.VIS_CODIGO)
		AND PUB.PUB_FECHA_INICIO >= LOS_JUS.inicioTrim(@trimAnio,@trim)
		AND PUB.PUB_FECHA_INICIO <= LOS_JUS.finTrim(@trimAnio,@trim)
		AND PUB.PUB_FECHA_INICIO >= CASE WHEN @anio IS NOT NULL AND @mes IS NOT NULL THEN CONVERT(datetime,@anio + '-01-' + @mes + ' 00:00:00.000') ELSE PUB.PUB_FECHA_INICIO END 
		AND EMP.EMP_HABILITADO = 1
	GROUP BY 
		[EMP_ID]
		,[EMP_RAZON_SOCIAL]
		,[EMP_CUIT]
		,[EMP_CONTACTO]
		,[EMP_FECHA_CREACION]
		,[EMP_MAIL]
		,[EMP_TELEFONO]
		,[EMP_DIRECCION]
		,[EMP_COD_POSTAL]
		,[EMP_PUBLICIDADES_GRATIS]
		,[EMP_CALIFICACION]
		,[EMP_HABILITADO]
	ORDER BY PUB_COUNT DESC
)
GO

------- FUNCION BUSCAR ESTADISTICAS 2 -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[estadisticas2]'))
DROP FUNCTION LOS_JUS.estadisticas2
GO

CREATE FUNCTION LOS_JUS.estadisticas2
(
@trimAnio varchar(4) = NULL,
@trim numeric(18,0) = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT TOP 5
		SUM(FAC.FAC_TOTAL) AS FAC_SUMA
		,[EMP_ID]
		,[EMP_RAZON_SOCIAL]
		,[EMP_CUIT]
		,[EMP_CONTACTO]
		,[EMP_FECHA_CREACION]
		,[EMP_MAIL]
		,[EMP_TELEFONO]
		,[EMP_DIRECCION]
		,[EMP_COD_POSTAL]
		,[EMP_PUBLICIDADES_GRATIS]
		,[EMP_CALIFICACION]
		,[EMP_HABILITADO]
	FROM LOS_JUS.PUBLICACION PUB 
		JOIN LOS_JUS.OPERACION OPE ON PUB.PUB_CODIGO = OPE.OPE_PUBLICACION
		JOIN LOS_JUS.FACTURACION FAC ON OPE.OPE_CODIGO = FAC.FAC_OPERACION
		JOIN LOS_JUS.EMPRESA EMP ON PUB.PUB_EMPRESA = EMP.EMP_ID
	WHERE EMP.EMP_HABILITADO = 1
		AND PUB.PUB_FECHA_INICIO >= LOS_JUS.inicioTrim(@trimAnio,@trim)
		AND PUB.PUB_FECHA_INICIO <= LOS_JUS.finTrim(@trimAnio,@trim)
	GROUP BY 
		[EMP_ID]
		,[EMP_RAZON_SOCIAL]
		,[EMP_CUIT]
		,[EMP_CONTACTO]
		,[EMP_FECHA_CREACION]
		,[EMP_MAIL]
		,[EMP_TELEFONO]
		,[EMP_DIRECCION]
		,[EMP_COD_POSTAL]
		,[EMP_PUBLICIDADES_GRATIS]
		,[EMP_CALIFICACION]
		,[EMP_HABILITADO]
	ORDER BY FAC_SUMA DESC
)
GO

------- FUNCION BUSCAR ESTADISTICAS 3 -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[estadisticas3]'))
DROP FUNCTION LOS_JUS.estadisticas3
GO

CREATE FUNCTION LOS_JUS.estadisticas3
(
@trimAnio varchar(4) = NULL,
@trim numeric(18,0) = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT TOP 5
		SUM(CAL.CAL_ESTRELLAS) AS CAL_SUMA
		,[EMP_ID]
		,[EMP_RAZON_SOCIAL]
		,[EMP_CUIT]
		,[EMP_CONTACTO]
		,[EMP_FECHA_CREACION]
		,[EMP_MAIL]
		,[EMP_TELEFONO]
		,[EMP_DIRECCION]
		,[EMP_COD_POSTAL]
		,[EMP_PUBLICIDADES_GRATIS]
		,[EMP_CALIFICACION]
		,[EMP_HABILITADO]
	FROM LOS_JUS.PUBLICACION PUB 
		JOIN LOS_JUS.OPERACION OPE ON PUB.PUB_CODIGO = OPE.OPE_PUBLICACION
		JOIN LOS_JUS.CALIFICACION CAL ON OPE.OPE_CODIGO = CAL_OPERACION
		JOIN LOS_JUS.EMPRESA EMP ON PUB.PUB_EMPRESA = EMP.EMP_ID
	WHERE EMP.EMP_HABILITADO = 1
		AND PUB.PUB_FECHA_INICIO >= LOS_JUS.inicioTrim(@trimAnio,@trim)
		AND PUB.PUB_FECHA_INICIO <= LOS_JUS.finTrim(@trimAnio,@trim)
	GROUP BY 
		[EMP_ID]
		,[EMP_RAZON_SOCIAL]
		,[EMP_CUIT]
		,[EMP_CONTACTO]
		,[EMP_FECHA_CREACION]
		,[EMP_MAIL]
		,[EMP_TELEFONO]
		,[EMP_DIRECCION]
		,[EMP_COD_POSTAL]
		,[EMP_PUBLICIDADES_GRATIS]
		,[EMP_CALIFICACION]
		,[EMP_HABILITADO]
	ORDER BY CAL_SUMA DESC
)
GO

------- FUNCION BUSCAR ESTADISTICAS 4 -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[estadisticas4]'))
DROP FUNCTION LOS_JUS.estadisticas4
GO

CREATE FUNCTION LOS_JUS.estadisticas4
(
@trimAnio varchar(4) = NULL,
@trim numeric(18,0) = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT TOP 5
		COUNT(CLI.CLI_ID) AS CAL_COUNT
		,[CLI_ID]
		,[CLI_NOMBRE]
		,[CLI_APELLIDO]
		,[CLI_DNI]
		,[CLI_TIPO_DNI]
		,[CLI_FECHA_NACIMIENTO]
		,[CLI_CUIL]
		,[CLI_MAIL]
		,[CLI_TELEFONO]
		,[CLI_DIRECCION]
		,[CLI_COD_POSTAL]
		,[CLI_OPERACIONES_SIN_CALIFICAR]
		,[CLI_HABILITADO]
	FROM LOS_JUS.CLIENTE CLI
		JOIN LOS_JUS.OPERACION OPE ON CLI.CLI_ID = OPE.OPE_CLIENTE
		LEFT JOIN LOS_JUS.CALIFICACION CAL ON OPE.OPE_CODIGO = CAL.CAL_OPERACION
	WHERE CLI.CLI_HABILITADO = 1
		AND CAL.CAL_CODIGO IS NULL
		AND OPE.OPE_FECHA >= LOS_JUS.inicioTrim(@trimAnio,@trim)
		AND OPE.OPE_FECHA <= LOS_JUS.finTrim(@trimAnio,@trim)
		AND CLI_ELIMINADO = 0
	GROUP BY 
		[CLI_ID]
		,[CLI_NOMBRE]
		,[CLI_APELLIDO]
		,[CLI_DNI]
		,[CLI_TIPO_DNI]
		,[CLI_FECHA_NACIMIENTO]
		,[CLI_CUIL]
		,[CLI_MAIL]
		,[CLI_TELEFONO]
		,[CLI_DIRECCION]
		,[CLI_COD_POSTAL]
		,[CLI_OPERACIONES_SIN_CALIFICAR]
		,[CLI_HABILITADO]
	ORDER BY CAL_COUNT DESC
)
GO

------- FUNCION BUSCAR PUBLICACIONES -------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarPublicaciones]'))
DROP FUNCTION LOS_JUS.buscarPublicaciones
GO

CREATE FUNCTION LOS_JUS.buscarPublicaciones
(
@rubros varchar(255) = NULL,
@descripcion nvarchar(255) = NULL
)
RETURNS TABLE
AS
RETURN (
	SELECT PUB.*
	FROM LOS_JUS.PUBLICACION PUB 
		JOIN LOS_JUS.RUBROxPUBLICACION RP ON PUB.PUB_CODIGO = RP.RUBPUB_PUBLICACION
		JOIN LOS_JUS.RUBRO RUB ON RP.RUBPUB_RUBRO = RUB.RUB_CODIGO
		
	WHERE 
	PUB.PUB_DESCRIPCION LIKE ISNULL(@descripcion, PUB.PUB_DESCRIPCION)
	AND RUB.RUB_DESCRIPCION IN (ISNULL(@rubros, RUB.RUB_DESCRIPCION))
	AND PUB.PUB_ESTADO LIKE 'Publicada'
	AND PUB.PUB_ELIMINADO = 0
)
GO

------- FUNCION BUSCAR HISTORIAL COMPRAS CLIENTES-------
IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorial]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorial
GO

IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorialCompraCliente]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorialCompraCliente
GO

CREATE FUNCTION LOS_JUS.buscarHistorialCompraCliente
(
@id numeric(18,0) = NULL
)
RETURNS TABLE
AS 
RETURN (
	SELECT OPE.*, PUB.PUB_DESCRIPCION
	FROM LOS_JUS.OPERACION OPE
		JOIN LOS_JUS.PUBLICACION PUB ON OPE.OPE_PUBLICACION = PUB.PUB_CODIGO
	WHERE OPE.OPE_CLIENTE = ISNULL(@id,OPE.OPE_CLIENTE)
		AND OPE.OPE_TIPO LIKE 'C'
		AND OPE.OPE_ELIMINADO = 0
   )
GO

------- FUNCION BUSCAR HISTORIAL OFERTAS CLIENTES-------

IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorialOfertaCliente]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorialOfertaCliente
GO

CREATE FUNCTION LOS_JUS.buscarHistorialOfertaCliente
(
@id numeric(18,0) = NULL
)
RETURNS TABLE
AS 
RETURN (
	SELECT OPE.*, PUB.PUB_DESCRIPCION, 
		(SELECT CASE WHEN MAX(O.OPE_OFERTA) = OPE.OPE_OFERTA THEN 1 ELSE 0 END 
		 FROM LOS_JUS.OPERACION O 
		 WHERE O.OPE_TIPO LIKE 'S'
			AND O.OPE_ELIMINADO = 0
			AND O.OPE_PUBLICACION = OPE.OPE_PUBLICACION
		) AS GANADOR
	FROM LOS_JUS.OPERACION OPE
		JOIN LOS_JUS.PUBLICACION PUB ON OPE.OPE_PUBLICACION = PUB.PUB_CODIGO
	WHERE OPE.OPE_CLIENTE = ISNULL(@id,OPE.OPE_CLIENTE)
		AND OPE.OPE_TIPO LIKE 'S'
		AND OPE.OPE_ELIMINADO = 0
   )
GO

------- FUNCION BUSCAR HISTORIAL CALIFICACIONES CLIENTES-------
IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorialCalificacionesCliente]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorialCalificacionesCliente
GO

CREATE FUNCTION LOS_JUS.buscarHistorialCalificacionesCliente
(
@id numeric(18,0) = NULL,
@tipo varchar(10) = NULL
)
RETURNS TABLE
AS 
RETURN (
	SELECT OPE.OPE_CODIGO, PUB.PUB_CODIGO, PUB.PUB_DESCRIPCION, CAL.CAL_ESTRELLAS, CAL_DETALLE
	FROM LOS_JUS.OPERACION OPE
		JOIN LOS_JUS.PUBLICACION PUB ON OPE.OPE_PUBLICACION = PUB.PUB_CODIGO
		JOIN LOS_JUS.CALIFICACION CAL ON OPE.OPE_CODIGO = CAL.CAL_OPERACION 
	WHERE OPE.OPE_CLIENTE = 2
		AND OPE.OPE_ELIMINADO = 0
		AND CAL.CAL_TIPO = CASE WHEN @tipo IS NULL OR @tipo LIKE 'Otorgadas' THEN 'E' ELSE 'C' END
   )
GO


------- FUNCION BUSCAR HISTORIAL COMPRAS EMPRESAS-------
IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorialCompraEmpresa]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorialCompraEmpresa
GO

CREATE FUNCTION LOS_JUS.buscarHistorialCompraEmpresa
(
@id numeric(18,0) = NULL
)
RETURNS TABLE
AS 
RETURN (
	SELECT OPE.*, PUB.PUB_DESCRIPCION
	FROM LOS_JUS.OPERACION OPE
		JOIN LOS_JUS.PUBLICACION PUB ON OPE.OPE_PUBLICACION = PUB.PUB_CODIGO
	WHERE PUB.PUB_EMPRESA = ISNULL(@id,PUB.PUB_EMPRESA)
		AND OPE.OPE_TIPO LIKE 'C'
		AND OPE.OPE_ELIMINADO = 0
   )
GO

------- FUNCION BUSCAR HISTORIAL OFERTAS EMPRESAS-------

IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorialOfertaEmpresa]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorialOfertaEmpresa
GO

CREATE FUNCTION LOS_JUS.buscarHistorialOfertaEmpresa
(
@id numeric(18,0) = NULL
)
RETURNS TABLE
AS 
RETURN (
	SELECT OPE.*, PUB.PUB_DESCRIPCION, 
		(SELECT CASE WHEN MAX(O.OPE_OFERTA) = OPE.OPE_OFERTA THEN 1 ELSE 0 END 
		 FROM LOS_JUS.OPERACION O 
		 WHERE O.OPE_TIPO LIKE 'S'
			AND O.OPE_ELIMINADO = 0
			AND O.OPE_PUBLICACION = OPE.OPE_PUBLICACION
		) AS GANADOR
	FROM LOS_JUS.OPERACION OPE
		JOIN LOS_JUS.PUBLICACION PUB ON OPE.OPE_PUBLICACION = PUB.PUB_CODIGO
	WHERE PUB.PUB_EMPRESA = ISNULL(@id,PUB.PUB_EMPRESA)
		AND OPE.OPE_TIPO LIKE 'S'
		AND OPE.OPE_ELIMINADO = 0
   )
GO

------- FUNCION BUSCAR HISTORIAL OFERTAS EMPRESAS-------
IF EXISTS 
(SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID('[LOS_JUS].[buscarHistorialCalificacionesEmpresa]') 
AND type in ('FN', 'IF', 'TF', 'FS', 'FT'))
DROP FUNCTION LOS_JUS.buscarHistorialCalificacionesEmpresa
GO

CREATE FUNCTION LOS_JUS.buscarHistorialCalificacionesEmpresa
(
@id numeric(18,0) = NULL,
@tipo varchar(10) = NULL
)
RETURNS TABLE
AS 
RETURN (
	SELECT OPE.OPE_CODIGO, PUB.PUB_CODIGO, PUB.PUB_DESCRIPCION, CAL.CAL_ESTRELLAS, CAL_DETALLE
	FROM LOS_JUS.OPERACION OPE
		JOIN LOS_JUS.PUBLICACION PUB ON OPE.OPE_PUBLICACION = PUB.PUB_CODIGO
		JOIN LOS_JUS.CALIFICACION CAL ON OPE.OPE_CODIGO = CAL.CAL_OPERACION 
	WHERE PUB.PUB_EMPRESA = ISNULL(@id,PUB.PUB_EMPRESA)
		AND OPE.OPE_ELIMINADO = 0
		AND CAL.CAL_TIPO = CASE WHEN @tipo IS NULL OR @tipo LIKE 'Otorgadas' THEN 'C' ELSE 'E' END
   )
GO


--SELECT * FROM LOS_JUS.buscarClientes(NULL,NULL,NULL,'DNI',NULL);
--SELECT * FROM LOS_JUS.buscarEmpresas(NULL,NULL,NULL);
--SELECT * FROM LOS_JUS.buscarVisibilidad(NULL,NULL,NULL);
--SELECT * FROM LOS_JUS.buscarVendedores(25);
--SELECT * FROM LOS_JUS.buscarPublicaciones('Bebés', NULL);
--SELECT * FROM LOS_JUS.estadisticas1(NULL,NULL,2013,1,NULL);
--SELECT * FROM LOS_JUS.estadisticas2(2013,1);
--SELECT * FROM LOS_JUS.estadisticas3(2013,1);
--SELECT * FROM LOS_JUS.estadisticas4(2013,1);
--select LOS_JUS.finTrim(null,2);
--SELECT * FROM LOS_JUS.buscarHistorialCompraCliente(2);
--SELECT * FROM LOS_JUS.buscarHistorialOfertaCliente(2);
--SELECT * FROM LOS_JUS.buscarHistorialCalificacionesCliente(2,'Otorgadas');
--SELECT * FROM LOS_JUS.buscarHistorialCalificacionesCliente(2,'Recibidas');
--SELECT * FROM LOS_JUS.buscarHistorialCompraEmpresa(45);
--SELECT * FROM LOS_JUS.buscarHistorialOfertaEmpresa(45);
--SELECT * FROM LOS_JUS.buscarHistorialCalificacionesEmpresa(45,'Otorgadas');
--SELECT * FROM LOS_JUS.buscarHistorialCalificacionesEmpresa(45,'Recibidas');






		     
