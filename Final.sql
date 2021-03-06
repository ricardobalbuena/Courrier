USE [master]
GO
/****** Object:  Database [currier]    Script Date: 12/6/2018 1:15:59 AM ******/
CREATE DATABASE [currier]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'currier', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\currier.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'currier_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\currier_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [currier] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [currier].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [currier] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [currier] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [currier] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [currier] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [currier] SET ARITHABORT OFF 
GO
ALTER DATABASE [currier] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [currier] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [currier] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [currier] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [currier] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [currier] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [currier] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [currier] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [currier] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [currier] SET  DISABLE_BROKER 
GO
ALTER DATABASE [currier] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [currier] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [currier] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [currier] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [currier] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [currier] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [currier] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [currier] SET RECOVERY FULL 
GO
ALTER DATABASE [currier] SET  MULTI_USER 
GO
ALTER DATABASE [currier] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [currier] SET DB_CHAINING OFF 
GO
ALTER DATABASE [currier] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [currier] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [currier] SET DELAYED_DURABILITY = DISABLED 
GO
USE [currier]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/6/2018 1:15:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[CodigoUsuario] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NULL,
	[Sexo] [varchar](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 12/6/2018 1:15:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[contrasena] [varchar](30) NULL,
	[tipo_empleado] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IDProveedores]    Script Date: 12/6/2018 1:15:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IDProveedores](
	[Proveedores] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Paquete]    Script Date: 12/6/2018 1:15:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paquete](
	[Nombre] [nvarchar](50) NULL,
	[CodigoUsuario] [nvarchar](50) NULL,
	[Contenido] [nvarchar](50) NULL,
	[ID] [int] NULL,
	[Proveedor] [nvarchar](50) NULL,
	[Libras] [int] NULL,
	[Estado] [nvarchar](50) NULL,
	[Fecha] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TablaEmpleado]    Script Date: 12/6/2018 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TablaEmpleado](
	[CodigoEmpleado] [int] NULL,
	[Usuario] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[TipoUsuario] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoEmpleado]    Script Date: 12/6/2018 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoEmpleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoPaquete]    Script Date: 12/6/2018 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPaquete](
	[Colonia] [nvarchar](50) NULL,
	[Audifono] [nvarchar](50) NULL,
	[Tegnologia] [nvarchar](50) NULL,
	[Medicina] [nvarchar](50) NULL,
	[Comida] [nvarchar](50) NULL,
	[Juegos] [nvarchar](50) NULL,
	[Juguetes] [nvarchar](50) NULL,
	[Otros] [nvarchar](50) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([tipo_empleado])
REFERENCES [dbo].[tipoEmpleado] ([tipo])
GO
ALTER TABLE [dbo].[Paquete]  WITH CHECK ADD FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[Cliente] ([CodigoUsuario])
GO
USE [master]
GO
ALTER DATABASE [currier] SET  READ_WRITE 
GO
