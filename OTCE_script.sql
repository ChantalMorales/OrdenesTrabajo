USE [master]
GO
/****** Object:  Database [OrdenesTrabajo]    Script Date: 17/2/2020 21:32:59 ******/
CREATE DATABASE [OrdenesTrabajo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OrdenesTrabajo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OrdenesTrabajo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OrdenesTrabajo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OrdenesTrabajo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OrdenesTrabajo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OrdenesTrabajo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OrdenesTrabajo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET ARITHABORT OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OrdenesTrabajo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OrdenesTrabajo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OrdenesTrabajo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OrdenesTrabajo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET RECOVERY FULL 
GO
ALTER DATABASE [OrdenesTrabajo] SET  MULTI_USER 
GO
ALTER DATABASE [OrdenesTrabajo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OrdenesTrabajo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OrdenesTrabajo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OrdenesTrabajo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OrdenesTrabajo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OrdenesTrabajo', N'ON'
GO
ALTER DATABASE [OrdenesTrabajo] SET QUERY_STORE = OFF
GO
USE [OrdenesTrabajo]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[telefono] [varchar](10) NOT NULL,
	[direccion] [varchar](100) NULL,
	[correo] [varchar](50) NOT NULL,
	[ci] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK__Cliente__677F38F5E498F5F6] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipo]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipo](
	[id_equipo] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
	[modelo] [varchar](25) NOT NULL,
	[discoduro] [varchar](30) NULL,
	[estadoHDD] [varchar](20) NULL,
	[observaciones] [varchar](200) NULL,
	[estadoequipo] [varchar](20) NULL,
	[id_orden_FK] [numeric](10, 0) NOT NULL,
	[serie_equipo] [varchar](20) NULL,
	[serialRAM1] [varchar](20) NULL,
	[serialRAM2] [varchar](20) NULL,
	[serialCargador] [varchar](20) NULL,
	[serialBateria] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Orden]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Orden](
	[estado_orden] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[estado_orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[id_orden] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[observacionesrecibido] [varchar](200) NULL,
	[diagnostico] [varchar](200) NOT NULL,
	[observacionesfinal] [varchar](200) NULL,
	[estado_order_FK] [varchar](20) NOT NULL,
	[prioridad_or] [varchar](20) NOT NULL,
	[nombre_us] [varchar](50) NOT NULL,
	[cliente_FK] [varchar](50) NOT NULL,
	[fecha_ingreso] [varchar](20) NULL,
	[fecha_salida] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden_Seguimiento]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden_Seguimiento](
	[id_seguimiento] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[fecharevision] [date] NULL,
	[id_orden_FK] [numeric](10, 0) NOT NULL,
	[id_usuario_FK] [numeric](10, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_seguimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prioridad]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prioridad](
	[desc_prioridad] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[desc_prioridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/2/2020 21:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](30) NOT NULL,
	[rol] [varchar](20) NULL,
 CONSTRAINT [PK__Usuario__4E3E04AD85353EBF] PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD FOREIGN KEY([id_orden_FK])
REFERENCES [dbo].[Orden] ([id_orden])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([cliente_FK])
REFERENCES [dbo].[Cliente] ([nombre])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([estado_order_FK])
REFERENCES [dbo].[Estado_Orden] ([estado_orden])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([nombre_us])
REFERENCES [dbo].[Usuario] ([nombre_usuario])
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD FOREIGN KEY([prioridad_or])
REFERENCES [dbo].[Prioridad] ([desc_prioridad])
GO
ALTER TABLE [dbo].[Orden_Seguimiento]  WITH CHECK ADD FOREIGN KEY([id_orden_FK])
REFERENCES [dbo].[Orden] ([id_orden])
GO
USE [master]
GO
ALTER DATABASE [OrdenesTrabajo] SET  READ_WRITE 
GO
