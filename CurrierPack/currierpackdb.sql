USE [master]
GO
/****** Object:  Database [currier]    Script Date: 12/3/2018 4:32:45 PM ******/
CREATE DATABASE [currier]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'currier', FILENAME = N'D:\Heroes of the Storm\SQL\MSSQL14.MSSQLSERVER\MSSQL\DATA\currier.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'currier_log', FILENAME = N'D:\Heroes of the Storm\SQL\MSSQL14.MSSQLSERVER\MSSQL\DATA\currier_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [currier] SET COMPATIBILITY_LEVEL = 140
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
EXEC sys.sp_db_vardecimal_storage_format N'currier', N'ON'
GO
ALTER DATABASE [currier] SET QUERY_STORE = OFF
GO
USE [currier]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/3/2018 4:32:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[CodigoUsuario] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[Genero] [nvarchar](1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paquete]    Script Date: 12/3/2018 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paquete](
	[Nombre] [nvarchar](50) NULL,
	[CodigoUsuario] [nvarchar](50) NULL,
	[Contenido] [nvarchar](50) NULL,
	[ID] [nvarchar](50) NULL,
	[Proveedor] [nvarchar](50) NULL,
	[Libras] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaEmpleado]    Script Date: 12/3/2018 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaEmpleado](
	[CodigoEmpleado] [int] NULL,
	[Usuario] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[TipoUsuario] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Cliente] ([Nombre], [Apellido], [Direccion], [CodigoUsuario], [Correo], [Genero]) VALUES (N'Edward', N'Cabrera', N'Calle ostiones', N'C-001', N'e.cabrera99@hotmail.com', N'H')
INSERT [dbo].[Cliente] ([Nombre], [Apellido], [Direccion], [CodigoUsuario], [Correo], [Genero]) VALUES (N'Pedro', N'Rodriguez', N'Calle almejas', N'C-002', N'pepenr12@gmail.com', N'H')
INSERT [dbo].[Paquete] ([Nombre], [CodigoUsuario], [Contenido], [ID], [Proveedor], [Libras], [Estado], [Correo]) VALUES (N'Pedro', N'C-002', N'Comida', N'987656745', N'Hearshis', N'20', N'Disponible', N'pepenr12@gmail.com')
INSERT [dbo].[Paquete] ([Nombre], [CodigoUsuario], [Contenido], [ID], [Proveedor], [Libras], [Estado], [Correo]) VALUES (N'Jose', N'C-003', N'Ropa', N'456789876', N'Amazon', N'1', N'En camino', NULL)
INSERT [dbo].[Paquete] ([Nombre], [CodigoUsuario], [Contenido], [ID], [Proveedor], [Libras], [Estado], [Correo]) VALUES (N'Maria', N'C-004', N'Maquillaje', N'98765432', N'Amazon', N'2', N'En camino', NULL)
INSERT [dbo].[Paquete] ([Nombre], [CodigoUsuario], [Contenido], [ID], [Proveedor], [Libras], [Estado], [Correo]) VALUES (N'Jhoana', N'C-006', N'Libro', N'9876543', N'Boockmania', N'3', N'Disponible', NULL)
INSERT [dbo].[Paquete] ([Nombre], [CodigoUsuario], [Contenido], [ID], [Proveedor], [Libras], [Estado], [Correo]) VALUES (N'Pedro', N'C-002', N'Celular', N'5741252', N'Amazon', N'3', N'En camino', N'pepenr12@gmail.com')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (20175515, N'Edward', N'1234', N'adm')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (4567, N'Jose', N'12345', N'res')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (11111111, N'Jorge', N'12346', N'adm')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (11111111, N'Ricardo', N'12347', N'res')
USE [master]
GO
ALTER DATABASE [currier] SET  READ_WRITE 
GO
