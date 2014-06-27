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
	primary key (ROL_NOMBRE)
)
;

-----------TABLA FUNCIONALIDADES-----------


CREATE TABLE LOS_JUS.FUNCIONALIDADES ( 
	FUN_FUNCIONALIDAD varchar(50),
	primary key (FUN_FUNCIONALIDAD)
)
;

-----------TABLA ROLxFUNCIONALIDADES-----------


CREATE TABLE LOS_JUS.ROLxFUNCIONALIDADES ( 
    ROLFUN_ID integer,
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
	USU_HABILITADO integer,
	USU_MAIL nvarchar(255) NOT NULL UNIQUE,
	USU_TELEFONO numeric(18,0),
	USU_DIRECCION varchar(255),
	USU_COD_POSTAL nvarchar(50),
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
	CLI_CUIL nvarchar(50),
	CLI_OPERACIONES_SIN_CALIFICAR integer,
	CLI_HABILITADO integer DEFAULT 1,
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
	EMP_PUBLICIDADES_GRATIS integer,
	EMP_CALIFICACION integer,
	EMP_HABILITADO integer DEFAULT 1,
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
	primary key (PUB_CODIGO),
	foreign key (PUB_EMPRESA) references LOS_JUS.EMPRESA
)
;

-----------TABLA PREGUNTA-----------


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


CREATE TABLE LOS_JUS.VISUALIZACION ( 
	VIS_CODIGO numeric(18),
	VIS_DESCRIPCION nvarchar(255),
	VIS_PRECIO numeric(18,2),
	VIS_PORCENTAJE numeric(18,2),
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
	CAL_DETALLE nvarchar(255)
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
	primary key (COM_CODIGO),
	foreign key (COM_PUBLICACION) references LOS_JUS.PUBLICACION
)
;

-----------TABLA SUBASTA-----------


CREATE TABLE LOS_JUS.SUBASTA ( 
	SUB_CODIGO numeric(18,0),
	SUB_PUBLICACION numeric(18,0),
	SUB_VALOR_INICIAL numeric(18,2),
	primary key (SUB_CODIGO),
	foreign key (SUB_PUBLICACION) references LOS_JUS.PUBLICACION
)
;

 
GO




 
-------- INSERTS ROLES ------------

INSERT INTO LOS_JUS.ROL VALUES('Cliente', 1),('Empresa', 1),('Administrativo', 1);
GO


-------- INSERTS FUNCIONALIDADES ------


-------- INSERT ADMIN USER ------------



-------- MIGRACON CLIENTES EN USUARIOS------------
-- password= gd2014  
CREATE PROCEDURE LOS_JUS.MIGRAR_USUARIOS_cli
as 
declare	
	@username varchar(50),
	@password varchar(100),
	@intentos int,
	@habilitado int,
	@mail nvarchar(255),
	@telefono numeric(18,0),
	@direccion varchar(255),
	@cod_postal nvarchar(50)
BEGIN
	set @password='e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855'
	set @habilitado=1
	set @intentos=0
	set @telefono=44444444
	declare cur_usuarios cursor for
	SELECT DISTINCT [Cli_Dni]
      ,[Cli_Mail]
      ,[Cli_Dom_Calle] + ' ' + Cast([Cli_Nro_Calle] as VARCHAR) 
      + ' Piso ' + Cast([Cli_Piso] as VARCHAR) + ' Dpto ' + [Cli_Depto]
      ,[Cli_Cod_Postal]
    FROM [GD1C2014].[gd_esquema].[Maestra]
	WHERE [Cli_Dni] IS NOT NULL
	OPEN cur_usuarios
	fetch cur_usuarios into @username, @mail, @direccion, @cod_postal
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		insert into LOS_JUS.USUARIO values(@username,@password, @intentos, @habilitado, @mail,@telefono, 
		@direccion, @cod_postal)	
		insert into LOS_JUS.ROLxUSUARIO values( 'Cliente', @@IDENTITY)
		fetch next from cur_usuarios into @username, @mail, @direccion, @cod_postal	
	END
	close cur_usuarios
	deallocate cur_usuarios
END
go

exec LOS_JUS.MIGRAR_USUARIOS_cli
go 

-------- MIGRACON EMPRESAS EN USUARIOS ------------
-- password= gd2014  
CREATE PROCEDURE LOS_JUS.MIGRAR_USUARIOS_emp
as 
declare	
	@username varchar(50),
	@password varchar(100),
	@intentos int,
	@habilitado int,
	@mail nvarchar(255),
	@telefono numeric(18,0),
	@direccion varchar(255),
	@cod_postal nvarchar(50)
BEGIN
	set @password='e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855'
	set @habilitado=1
	set @intentos=0
	set @telefono=44444444
	declare cur_usuarios cursor for
	select distinct Publ_Empresa_Cuit, Publ_Empresa_Mail, Publ_Empresa_Dom_Calle + ' ' + Cast(Publ_Empresa_Nro_Calle as VARCHAR) 
      + ' Piso ' +  ' Dpto ' + Publ_Empresa_Depto, Publ_Empresa_Cod_Postal
	from gd_esquema.Maestra
	where Publ_Empresa_Cuit is not null
	OPEN cur_usuarios
	fetch cur_usuarios into @username, @mail, @direccion, @cod_postal
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		insert into LOS_JUS.USUARIO values(@username,@password, @intentos, @habilitado, @mail,@telefono, 
		@direccion, @cod_postal)	
		insert into LOS_JUS.ROLxUSUARIO values( 'Empresa', @@IDENTITY)
		fetch next from cur_usuarios into @username, @mail, @direccion, @cod_postal	
	END
	close cur_usuarios
	deallocate cur_usuarios
END
go

exec LOS_JUS.MIGRAR_USUARIOS_emp
go

---------------------------------------------------------------
-------- MIGRACON EMPRESAS  ------------
 
CREATE PROCEDURE LOS_JUS.MIGRAR_EMPRESAS
as 
declare	
	@id int,
	@razonsocial nvarchar(255),
	@username nvarchar(50),
	@contacto nvarchar(255),
	@fechaCreacion datetime,
	@publiGratis int,
	@calificacion int
BEGIN
	set @contacto='Director'
	set @publiGratis=0
	set @calificacion=0

	declare cur_empresa cursor for
	
	select  distinct o.USU_ID,
	m.Publ_Empresa_Razon_Social, o.USU_USERNAME, m.Publ_Empresa_Fecha_Creacion
	from LOS_JUS.USUARIO o,gd_esquema.Maestra m where o.USU_USERNAME = m.Publ_Empresa_Cuit


	OPEN cur_empresa
	fetch cur_empresa into @id, @razonsocial, @username, @fechaCreacion
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		insert into LOS_JUS.EMPRESA values(@id,@razonsocial, @username, @contacto, @fechaCreacion, @publiGratis, @calificacion, 1)	
		
		fetch next from cur_empresa into @id, @razonsocial, @username, @fechaCreacion
	END
	close cur_empresa
	deallocate cur_empresa
END
go


exec LOS_JUS.MIGRAR_EMPRESAS
go
-----------------------------------------------------
-------- MIGRACON CLIENTES  ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_CLIENTES
as 
declare	
	@id int,
	@nombre nvarchar(255),
	@apellido nvarchar(50),
	@dni numeric(18,0),
	@tipodni char(1),
	@fechanacimiento nvarchar(50),
	@cuil nvarchar(50),
	@operaciones int
BEGIN
	set @tipodni='DNI'
	set @cuil='0-00000000-0'
	set @operaciones=0

	declare cur_cliente cursor for
	
	select  distinct o.USU_ID,
	M.Cli_Nombre, m.Cli_Apeliido, m.Cli_Dni, m.Cli_Fecha_Nac
	from LOS_JUS.USUARIO o,gd_esquema.Maestra m where o.USU_USERNAME = Cast(m.Cli_Dni as varchar(50))

	OPEN cur_cliente
	fetch cur_cliente into @id, @nombre, @apellido, @dni, @fechanacimiento
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		insert into LOS_JUS.CLIENTE values(@id,@nombre, @apellido, @dni, @tipodni, @fechanacimiento, @cuil, @operaciones, 1)	
		
		fetch next from cur_cliente into @id, @nombre, @apellido, @dni, @fechanacimiento
	END
	close cur_cliente
	deallocate cur_cliente
END
go


exec LOS_JUS.MIGRAR_CLIENTES
go

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
	INSERT INTO LOS_JUS.VISUALIZACION (VIS_CODIGO, VIS_DESCRIPCION, VIS_PRECIO, VIS_PORCENTAJE)
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
DECLARE	
	@id numeric(18,0),
	@tipo nvarchar(255),
	@dni nvarchar(255),
	@compra_fecha datetime,
	@cantidad numeric(18,0),
	@oferta_fecha datetime,
	@monto numeric(18,2),
	@cal_codigo numeric(18,0),
	@cat_estrellas numeric(18,0),
	@cal_detalle nvarchar(255),
	@last_ope_id integer
BEGIN
	DECLARE cur_ope CURSOR FOR
	SELECT [Publicacion_Cod]
		,[Publicacion_Tipo]
		,[Cli_Dni]
		,[Compra_Fecha]
		,[Compra_Cantidad]
		,[Oferta_Fecha]
		,[Oferta_Monto]
		,[Calificacion_Codigo]
		,[Calificacion_Cant_Estrellas]
		,[Calificacion_Descripcion]
    FROM [GD1C2014].[gd_esquema].[Maestra]
	WHERE ([Oferta_Fecha] IS NOT NULL AND [Compra_Fecha] IS NULL) 
		OR ([Oferta_Fecha] IS NULL AND [Compra_Fecha] IS NOT NULL)
	ORDER BY [Publicacion_Cod] ASC


	OPEN cur_ope
	FETCH cur_ope INTO @id,
		@tipo,
		@dni,
		@compra_fecha,
		@cantidad,
		@oferta_fecha,
		@monto,
		@cal_codigo,
		@cat_estrellas,
		@cal_detalle
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		
		IF (@tipo LIKE 'Compra Inmediata')
		BEGIN
			INSERT INTO LOS_JUS.OPERACION
				([OPE_PUBLICACION]
				,[OPE_TIPO]
				,[OPE_CLIENTE]
				,[OPE_CANTIDAD]
				,[OPE_FECHA])
			VALUES (
				@id,
				'C',
				(SELECT LOS_JUS.CLIENTE.CLI_ID
				 FROM LOS_JUS.CLIENTE 
				 WHERE LOS_JUS.CLIENTE.CLI_DNI LIKE @dni),
				@cantidad,
				@compra_fecha
			)
		END
		ELSE
		BEGIN
			INSERT INTO LOS_JUS.OPERACION 
				([OPE_PUBLICACION]
				,[OPE_TIPO]
				,[OPE_CLIENTE]
				,[OPE_OFERTA]
				,[OPE_FECHA])
			VALUES (
				@id,
				'S',
				(SELECT LOS_JUS.CLIENTE.CLI_ID
				 FROM LOS_JUS.CLIENTE 
				 WHERE LOS_JUS.CLIENTE.CLI_DNI LIKE @dni),
				@monto,
				@oferta_fecha
			)
		END
		
		SELECT @last_ope_id = SCOPE_IDENTITY()
		
		IF (@cal_codigo IS NOT NULL) 
		BEGIN
			INSERT INTO LOS_JUS.CALIFICACION 
			VALUES (
				@cal_codigo,
				@last_ope_id,
				@cat_estrellas,
				@cal_detalle
			)
		END
		
		FETCH NEXT FROM cur_ope INTO @id,
			@tipo,
			@dni,
			@compra_fecha,
			@cantidad,
			@oferta_fecha,
			@monto,
			@cal_codigo,
			@cat_estrellas,
			@cal_detalle
	END
	CLOSE cur_ope
	DEALLOCATE cur_ope
END
GO

EXEC LOS_JUS.MIGRAR_OPERACIONES
GO


-----------------------------------------------------
-------- MIGRACION FACTURAS ------------

CREATE PROCEDURE LOS_JUS.MIGRAR_FACTURAS
AS 
DECLARE	
	@id numeric(18,0),
	@tipo nvarchar(255),
	@dni nvarchar(255),
	@item_fact_monto numeric(18,2),
	@item_fact_cant numeric(18,0),
	@factura_nro numeric(18,0),
	@factura_fecha datetime,
	@factura_total numeric(18,2),
	@forma_pago_desc nvarchar(255),
	@last_fact numeric(18,0),
	@cli_id integer

BEGIN
	DECLARE cur_fac CURSOR FOR
	SELECT [Publicacion_Cod]
		,[Publicacion_Tipo]
		,[Cli_Dni]
		,[Item_Factura_Monto]
		,[Item_Factura_Cantidad]
		,[Factura_Nro]
		,[Factura_Fecha]
		,[Factura_Total]
		,[Forma_Pago_Desc]
    FROM [GD1C2014].[gd_esquema].[Maestra]
	WHERE [Factura_Nro] IS NOT NULL
	ORDER BY [Factura_Nro] ASC


	OPEN cur_fac
	FETCH cur_fac INTO @id,
		@tipo,
		@dni,
		@item_fact_monto,
		@item_fact_cant,
		@factura_nro,
		@factura_fecha,
		@factura_total,
		@forma_pago_desc
		
	SET @last_fact = 0
		
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		IF (@factura_nro > @last_fact) ---INSERT FACTURA Y PRIMER ITEM
		BEGIN
		
		SELECT @cli_id = CLIENTE.CLI_ID FROM CLIENTE WHERE CLIENTE.CLI_DNI = @dni
		INSERT INTO LOS_JUS.FACTURACION
		VALUES (
			@factura_nro,
			(SELECT TOP 1 LOS_JUS.OPERACION.OPE_CODIGO
			 FROM LOS_JUS.OPERACION 
			 WHERE LOS_JUS.OPERACION.OPE_PUBLICACION = @id AND LOS_JUS.OPERACION.OPE_CLIENTE = @cli_id),
			@forma_pago_desc,
			@factura_total,
			@factura_fecha
		)
		
		INSERT INTO LOS_JUS.ITEM
		VALUES (
			@factura_nro,
			@item_fact_monto,
			@item_fact_cant
		)
		
		END
		ELSE ---INSERT ITEM
		BEGIN
			INSERT INTO LOS_JUS.ITEM
			VALUES (
				@factura_nro,
				@item_fact_monto,
				@item_fact_cant
			)
		END
		
		SELECT @last_fact = @factura_nro
		
		FETCH NEXT FROM cur_fac INTO @id,
		@tipo,
		@dni,
		@item_fact_monto,
		@item_fact_cant,
		@factura_nro,
		@factura_fecha,
		@factura_total,
		@forma_pago_desc
		
		
		
	END
	CLOSE cur_fac
	DEALLOCATE cur_fac
END
GO

EXEC LOS_JUS.MIGRAR_FACTURAS
GO
