USE [currier]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/2/2018 12:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[CodigoUsuario] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 12/2/2018 12:18:03 PM ******/
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
/****** Object:  Table [dbo].[IDProveedores]    Script Date: 12/2/2018 12:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IDProveedores](
	[Proveedores] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Paquete]    Script Date: 12/2/2018 12:18:03 PM ******/
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
	[Estado] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TablaEmpleado]    Script Date: 12/2/2018 12:18:03 PM ******/
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
/****** Object:  Table [dbo].[tipoEmpleado]    Script Date: 12/2/2018 12:18:03 PM ******/
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
/****** Object:  Table [dbo].[TipoPaquete]    Script Date: 12/2/2018 12:18:03 PM ******/
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
INSERT [dbo].[Cliente] ([Nombre], [Apellido], [Direccion], [CodigoUsuario], [Correo]) VALUES (N'Edward', N'Cabrera', N'CalleX', N'C001', N'e.cabrera99@hotmail.com')
INSERT [dbo].[Cliente] ([Nombre], [Apellido], [Direccion], [CodigoUsuario], [Correo]) VALUES (N'Hernan', N'Melo', N'Calle #27', N'C006', N'hernan@hotmail.com')
INSERT [dbo].[Cliente] ([Nombre], [Apellido], [Direccion], [CodigoUsuario], [Correo]) VALUES (N'manuel', N'perez', N'Calle #23', N'C004', N'manuel@hotmail.com')
INSERT [dbo].[Cliente] ([Nombre], [Apellido], [Direccion], [CodigoUsuario], [Correo]) VALUES (N'ricardo', N'isc', N'calle #24', N'C003', N'ricardo@hotmail.com')
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id], [usuario], [contrasena], [tipo_empleado]) VALUES (3, N'alberto', N'1234', N'Administrador')
INSERT [dbo].[Empleado] ([id], [usuario], [contrasena], [tipo_empleado]) VALUES (2, N'jorge', N'1234', N'admin')
INSERT [dbo].[Empleado] ([id], [usuario], [contrasena], [tipo_empleado]) VALUES (4, N'wilis', N'1234', N'Receptor')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'Amazon')
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'Aliexpress')
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'Mercado libre')
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'eBay')
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'Alibaba')
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'Bestbuy')
INSERT [dbo].[IDProveedores] ([Proveedores]) VALUES (N'Otros')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (20175515, N'Edward', N'1234', N'admi      ')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (4567, N'Jose', N'12345', N'resept    ')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (11111111, N'Jorge', N'12346', N'admi      ')
INSERT [dbo].[TablaEmpleado] ([CodigoEmpleado], [Usuario], [Password], [TipoUsuario]) VALUES (11111111, N'Ricardo', N'12347', N'resept    ')
SET IDENTITY_INSERT [dbo].[tipoEmpleado] ON 

INSERT [dbo].[tipoEmpleado] ([id], [tipo]) VALUES (3, N' Administrador')
INSERT [dbo].[tipoEmpleado] ([id], [tipo]) VALUES (1, N'admin')
INSERT [dbo].[tipoEmpleado] ([id], [tipo]) VALUES (4, N'Administrador')
INSERT [dbo].[tipoEmpleado] ([id], [tipo]) VALUES (2, N'Receptor')
SET IDENTITY_INSERT [dbo].[tipoEmpleado] OFF
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([tipo_empleado])
REFERENCES [dbo].[tipoEmpleado] ([tipo])
GO
