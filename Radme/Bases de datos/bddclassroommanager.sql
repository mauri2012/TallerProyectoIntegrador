USE [master]
GO
/****** Object:  Database [classroom_manager]    Script Date: 14/11/2023 23:52:55 ******/
CREATE DATABASE [classroom_manager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'classroom_manager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\classroom_manager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'classroom_manager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\classroom_manager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [classroom_manager] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [classroom_manager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [classroom_manager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [classroom_manager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [classroom_manager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [classroom_manager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [classroom_manager] SET ARITHABORT OFF 
GO
ALTER DATABASE [classroom_manager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [classroom_manager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [classroom_manager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [classroom_manager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [classroom_manager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [classroom_manager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [classroom_manager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [classroom_manager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [classroom_manager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [classroom_manager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [classroom_manager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [classroom_manager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [classroom_manager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [classroom_manager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [classroom_manager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [classroom_manager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [classroom_manager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [classroom_manager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [classroom_manager] SET  MULTI_USER 
GO
ALTER DATABASE [classroom_manager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [classroom_manager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [classroom_manager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [classroom_manager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [classroom_manager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [classroom_manager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [classroom_manager] SET QUERY_STORE = ON
GO
ALTER DATABASE [classroom_manager] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [classroom_manager]
GO
/****** Object:  Table [dbo].[aula]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[capacidad] [int] NOT NULL,
	[id_ubicacion] [int] NOT NULL,
	[id_tipo] [int] NOT NULL,
	[activa] [varchar](2) NOT NULL,
	[cantComputadoras] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[aula_equipamiento]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula_equipamiento](
	[id_aula] [int] NOT NULL,
	[id_equipamiento] [int] NOT NULL,
	[disponible] [varchar](2) NOT NULL,
 CONSTRAINT [PKaula_equipamiento] PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC,
	[id_equipamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dias_semana]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dias_semana](
	[id_dias] [int] NOT NULL,
	[dias] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[equipamiento]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[equipamiento](
	[id_equipamiento] [int] IDENTITY(1,1) NOT NULL,
	[recurso] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_equipamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horas]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horas](
	[id_hora] [int] NOT NULL,
	[horario] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[materia] [varchar](30) NOT NULL,
	[activo] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodo](
	[id_periodo] [int] IDENTITY(1,1) NOT NULL,
	[periodo_nombre] [varchar](20) NOT NULL,
	[fecha_desde] [datetime] NOT NULL,
	[fecha_hasta] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_periodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reserva]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_hora] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_aula] [int] NOT NULL,
	[id_dia] [int] NOT NULL,
	[id_materia] [int] NOT NULL,
	[activo] [varchar](2) NOT NULL,
	[id_periodo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoSala]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoSala](
	[id_sala] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoUsuario]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoUsuario](
	[id_tipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ubicacion]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ubicacion](
	[id_ubicacion] [int] IDENTITY(1,1) NOT NULL,
	[lugar] [varchar](20) NOT NULL,
	[activo] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ubicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 14/11/2023 23:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[id_tipoUsuario] [int] NOT NULL,
	[desactivar] [varchar](2) NOT NULL,
	[password] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[aula] ON 

INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (6, N'Aula 4', 200, 2, 1, N'SI', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (8, N'promif', 70, 1, 2, N'NO', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (9, N'emeroteca', 80, 1, 2, N'NO', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (10, N'Aula 4', 40, 1, 1, N'NO', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (11, N'Aula 5', 150, 1, 1, N'NO', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (12, N'Aula 3', 70, 2, 1, N'NO', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (13, N'aula 3', 79, 1, 1, N'NO', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (14, N'aula 3', 70, 1, 1, N'SI', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (15, N'Aula 7', 20, 3, 1, N'SI', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (16, N'Promif', 50, 1, 2, N'SI', 250)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (17, N'laborio 2', 30, 3, 2, N'SI', 15)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (18, N'prueba', 20, 1, 1, N'SI', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (19, N'prueba2', 30, 6, 1, N'SI', 0)
INSERT [dbo].[aula] ([id_aula], [nombre], [capacidad], [id_ubicacion], [id_tipo], [activa], [cantComputadoras]) VALUES (20, N'aula 10', 150, 3, 1, N'SI', 0)
SET IDENTITY_INSERT [dbo].[aula] OFF
GO
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (6, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (6, 2, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (6, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (6, 4, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (8, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (8, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (8, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (8, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (9, 1, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (9, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (9, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (9, 4, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (10, 1, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (10, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (10, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (10, 4, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (11, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (11, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (11, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (11, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (12, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (12, 2, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (12, 3, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (12, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (13, 1, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (13, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (13, 3, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (13, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (14, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (14, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (14, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (14, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (15, 1, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (15, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (15, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (15, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (16, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (16, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (16, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (16, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (17, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (17, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (17, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (17, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (18, 1, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (18, 2, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (18, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (18, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (19, 1, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (19, 2, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (19, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (19, 4, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (20, 1, N'NO')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (20, 2, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (20, 3, N'SI')
INSERT [dbo].[aula_equipamiento] ([id_aula], [id_equipamiento], [disponible]) VALUES (20, 4, N'NO')
GO
INSERT [dbo].[dias_semana] ([id_dias], [dias]) VALUES (1, N'lunes')
INSERT [dbo].[dias_semana] ([id_dias], [dias]) VALUES (2, N'martes')
INSERT [dbo].[dias_semana] ([id_dias], [dias]) VALUES (3, N'miercoles')
INSERT [dbo].[dias_semana] ([id_dias], [dias]) VALUES (4, N'jueves')
INSERT [dbo].[dias_semana] ([id_dias], [dias]) VALUES (5, N'viernes')
INSERT [dbo].[dias_semana] ([id_dias], [dias]) VALUES (6, N'sabado')
GO
SET IDENTITY_INSERT [dbo].[equipamiento] ON 

INSERT [dbo].[equipamiento] ([id_equipamiento], [recurso]) VALUES (1, N'Televisor')
INSERT [dbo].[equipamiento] ([id_equipamiento], [recurso]) VALUES (2, N'Aire Acondicionado')
INSERT [dbo].[equipamiento] ([id_equipamiento], [recurso]) VALUES (3, N'Proyector')
INSERT [dbo].[equipamiento] ([id_equipamiento], [recurso]) VALUES (4, N'Wifi')
SET IDENTITY_INSERT [dbo].[equipamiento] OFF
GO
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (0, N'8:00-10:00')
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (1, N'10:00-12:00')
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (2, N'12:00-14:00')
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (3, N'14:00-16:00')
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (4, N'16:00-18:00')
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (5, N'18:00-20:00')
INSERT [dbo].[horas] ([id_hora], [horario]) VALUES (6, N'20:00-22:00')
GO
SET IDENTITY_INSERT [dbo].[materias] ON 

INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (1, N'ingenieria de software 1', N'SI')
INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (2, N'taller de programacion i', N'SI')
INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (4, N'Taller de Programacion 2', N'NO')
INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (5, N'Taller de programacion 2', N'SI')
INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (6, N'Algebra 1 (LSI)', N'SI')
INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (7, N'Calculo', N'SI')
INSERT [dbo].[materias] ([id_materia], [materia], [activo]) VALUES (8, N'Estadistica y porbabilidad', N'NO')
SET IDENTITY_INSERT [dbo].[materias] OFF
GO
SET IDENTITY_INSERT [dbo].[Periodo] ON 

INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (1, N'Primer Cuatrimestre', CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (2, N'Segundo Cuatrimestre', CAST(N'2023-07-02T00:00:00.000' AS DateTime), CAST(N'2023-11-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (3, N'Primer Trimestre', CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (4, N'Segundo Trimestre', CAST(N'2023-05-31T00:00:00.000' AS DateTime), CAST(N'2023-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (5, N'Tercer Trimestre', CAST(N'2023-08-11T00:00:00.000' AS DateTime), CAST(N'2023-11-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (6, N'Primer bimestre', CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-04-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (7, N'Segundo biimestre', CAST(N'2023-04-30T00:00:00.000' AS DateTime), CAST(N'2023-06-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (8, N'Tercer bimestre', CAST(N'2023-07-02T00:00:00.000' AS DateTime), CAST(N'2023-08-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (9, N'Cuarto bimestre', CAST(N'2023-09-15T00:00:00.000' AS DateTime), CAST(N'2023-11-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Periodo] ([id_periodo], [periodo_nombre], [fecha_desde], [fecha_hasta]) VALUES (10, N'Anual', CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-11-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Periodo] OFF
GO
SET IDENTITY_INSERT [dbo].[reserva] ON 

INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (6, 3, 8, 6, 4, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (7, 3, 8, 6, 2, 1, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (8, 2, 8, 10, 4, 1, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (9, 1, 13, 6, 3, 4, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (10, 1, 14, 6, 3, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (11, 1, 13, 6, 3, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (12, 3, 13, 10, 3, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (13, 5, 13, 6, 6, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (14, 4, 14, 6, 5, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (16, 5, 14, 6, 1, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (18, 3, 15, 11, 2, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (19, 3, 14, 11, 5, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (20, 5, 14, 11, 6, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (21, 4, 14, 11, 3, 1, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (22, 3, 14, 6, 4, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (24, 6, 14, 11, 5, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (25, 1, 14, 11, 1, 1, N'SI', 2)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (26, 1, 15, 6, 1, 6, N'SI', 7)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (27, 1, 14, 6, 6, 4, N'SI', 6)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (28, 3, 15, 6, 2, 6, N'SI', 2)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (29, 1, 14, 11, 1, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (30, 6, 14, 6, 5, 2, N'SI', 3)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (31, 6, 14, 6, 1, 2, N'SI', 8)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (32, 5, 14, 6, 6, 4, N'SI', 9)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (33, 5, 14, 6, 6, 4, N'SI', 2)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (34, 2, 14, 6, 5, 6, N'SI', 9)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (35, 6, 15, 11, 6, 4, N'NO', 9)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (36, 3, 15, 11, 1, 1, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (37, 6, 15, 6, 3, 6, N'SI', 4)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (39, 3, 14, 16, 2, 1, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (40, 4, 15, 16, 3, 4, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (41, 5, 15, 6, 4, 4, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (42, 3, 19, 6, 2, 4, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (43, 6, 15, 6, 2, 4, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (45, 0, 14, 6, 2, 7, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (46, 3, 15, 20, 1, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (47, 0, 15, 20, 6, 2, N'SI', 6)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (48, 4, 14, 19, 2, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (49, 1, 15, 6, 4, 7, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (50, 6, 15, 6, 6, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (51, 4, 14, 18, 4, 2, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (52, 4, 14, 20, 3, 2, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (53, 3, 14, 20, 3, 2, N'NO', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (54, 2, 15, 14, 5, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (55, 4, 19, 18, 4, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (56, 4, 15, 14, 4, 2, N'SI', 1)
INSERT [dbo].[reserva] ([id_reserva], [id_hora], [id_usuario], [id_aula], [id_dia], [id_materia], [activo], [id_periodo]) VALUES (57, 4, 14, 15, 4, 2, N'NO', 1)
SET IDENTITY_INSERT [dbo].[reserva] OFF
GO
SET IDENTITY_INSERT [dbo].[tipoSala] ON 

INSERT [dbo].[tipoSala] ([id_sala], [tipo]) VALUES (1, N'aula')
INSERT [dbo].[tipoSala] ([id_sala], [tipo]) VALUES (2, N'laboratorio')
SET IDENTITY_INSERT [dbo].[tipoSala] OFF
GO
SET IDENTITY_INSERT [dbo].[tipoUsuario] ON 

INSERT [dbo].[tipoUsuario] ([id_tipoUsuario], [tipo]) VALUES (1, N'Admin')
INSERT [dbo].[tipoUsuario] ([id_tipoUsuario], [tipo]) VALUES (3, N'bedel')
INSERT [dbo].[tipoUsuario] ([id_tipoUsuario], [tipo]) VALUES (4, N'profesor')
SET IDENTITY_INSERT [dbo].[tipoUsuario] OFF
GO
SET IDENTITY_INSERT [dbo].[ubicacion] ON 

INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (1, N'primer piso', N'SI')
INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (2, N'segundo piso', N'SI')
INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (3, N'tercer piso', N'SI')
INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (4, N'cuarto piso', N'NO')
INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (5, N'quinto piso', N'NO')
INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (6, N'sexto piso', N'NO')
INSERT [dbo].[ubicacion] ([id_ubicacion], [lugar], [activo]) VALUES (7, N'sexto piso', N'NO')
SET IDENTITY_INSERT [dbo].[ubicacion] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (1, 44806651, N'Mauricio', N'Lezana', N'lezanamauricio86@gmail.com', 1, N'NO', N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (8, 40232902, N'rodrigo', N'gonzalez', N'gonzalez@gmail.com', 3, N'NO', N'5cd9ad9e51220a50f42990c8a1bd04bb3a727c4c500d1e7c4f3a0c0c5d407187')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (9, 30490212, N'manuel', N'garcia', N'garcia80@gmail.com', 1, N'NO', N'd27a044bd7d54223f639f985b2fe0f331b5b7b6d1dbbad4049035098e015a67c')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (10, 34704244, N'Lucio', N'Ramirez', N'ramirezLucio@gmail.com', 1, N'SI', N'a8e1cc76d1a2a52676e35c99040ce1cb0610b938eccd7759d8527f4e17228fc2')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (11, 20390212, N'Mario', N'ledezma', N'ledezma203@gmail.com', 1, N'SI', N'01537206d828e8b35f4166c3806b60fef0af0fffa837923027c562d5037b3d4b')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (12, 999999999, N'nombre1', N'apellido1', N'apellido1nom@gmail.com', 3, N'SI', N'bb421fa35db885ce507b0ef5c3f23cb09c62eb378fae3641c165bdf4c0272949')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (13, 99999999, N'nombre2', N'apellido2', N'mailgenerico@gmail.com', 3, N'NO', N'3f08d8fadb4b67fb056623565edbbc2c788091d78fd24cbc473fce3043ce3473')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (14, 33333333, N'juan', N'gomez', N'apellido3nom@gmail.com', 4, N'NO', N'afb47e00531153e93808589e43d02c11f6398c5bc877f7924cebca8211c8dd18')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (15, 55555555, N'nom5', N'apell', N'55nombre@gmail.com', 4, N'NO', N'01c02776d7290e999c60af8413927df1d389690aab8cac12503066cf62e899f6')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (18, 111111111, N'juan', N'alfonzo', N'alfonzo@gmail.com', 1, N'NO', N'1a5376ad727d65213a79f3108541cf95012969a0d3064f108b5dd6e7f8c19b89')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (19, 111111, N'profesornom', N'apellidoprofesor', N'profesornom@gmail.com', 4, N'NO', N'bcb15f821479b4d5772bd0ca866c00ad5f926e3580720659cc80d39c9d09802a')
INSERT [dbo].[usuario] ([id_usuario], [dni], [nombre], [apellido], [correo], [id_tipoUsuario], [desactivar], [password]) VALUES (20, 32905124, N'Luis', N'Damonte', N'Damonte23@gmail.com', 4, N'NO', N'ab173829a4fce89cfd810fc7bca9fd3670e7112b24c0579008360cebe3169877')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__usuario__2A586E0B7D9AF651]    Script Date: 14/11/2023 23:52:55 ******/
ALTER TABLE [dbo].[usuario] ADD UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aula] ADD  DEFAULT ('NO') FOR [activa]
GO
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [DF_usuario_desactivar]  DEFAULT ('NO') FOR [desactivar]
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipoSala] ([id_sala])
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_ubicacion])
REFERENCES [dbo].[ubicacion] ([id_ubicacion])
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_ubicacion])
REFERENCES [dbo].[ubicacion] ([id_ubicacion])
GO
ALTER TABLE [dbo].[aula_equipamiento]  WITH CHECK ADD  CONSTRAINT [fk_aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[aula_equipamiento] CHECK CONSTRAINT [fk_aula]
GO
ALTER TABLE [dbo].[aula_equipamiento]  WITH CHECK ADD  CONSTRAINT [fk_equipamiento] FOREIGN KEY([id_equipamiento])
REFERENCES [dbo].[equipamiento] ([id_equipamiento])
GO
ALTER TABLE [dbo].[aula_equipamiento] CHECK CONSTRAINT [fk_equipamiento]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_dia])
REFERENCES [dbo].[dias_semana] ([id_dias])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_hora])
REFERENCES [dbo].[horas] ([id_hora])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_materia])
REFERENCES [dbo].[materias] ([id_materia])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [reserva_FK_id_periodo] FOREIGN KEY([id_periodo])
REFERENCES [dbo].[Periodo] ([id_periodo])
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [reserva_FK_id_periodo]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_tipoUsuario])
REFERENCES [dbo].[tipoUsuario] ([id_tipoUsuario])
GO
USE [master]
GO
ALTER DATABASE [classroom_manager] SET  READ_WRITE 
GO
