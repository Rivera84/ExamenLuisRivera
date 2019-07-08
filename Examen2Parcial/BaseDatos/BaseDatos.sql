use tempdb
GO

CREATE DATABASE ERP
GO

use ERP
GO

CREATE SCHEMA Usuario
GO

CREATE TABLE Usuario.usuario(		
nombre NVARCHAR(20) NOT NULL,
apellido NVARCHAR(20) NOT NULL,
nombreUsuario NVARCHAR(20) NOT NULL
		CONSTRAINT PK_UsuarioUSER PRIMARY KEY CLUSTERED,
contraseņa NVARCHAR (20) NOT NULL,
correoElectronico NVARCHAR(20) NOT NULL,
fechaCreacion DATETIME NOT NULL,
ultimoIngreso DATETIME NOT NULL,
tipoUsuario VARCHAR(20) NOT NULL,
estado VARCHAR(20) NOT NULL
)
GO
