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
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('LOS_JUS.FUNICONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
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

CREATE TABLE LOS_JUS.ROL ( 
	ROLFUN_ROL varchar(15),
	ROLFUN_FUNCIONALIDADES integer,
	primary key (ROLFUN_ROL,ROLFUN_FUNCIONALIDADES),
	foreign key (ROLFUN_ROL) references LOS_JUS.ROL,
	foreign key (ROLFUN_FUNCIONALIDADES) references LOS_JUS.FUNCIONALIDADES,

)
;







