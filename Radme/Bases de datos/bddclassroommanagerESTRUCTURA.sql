USE [master]
GO
/****** Object:  Database [classroom_manager]    Script Date: 15/11/2023 22:40:58 ******/
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
/****** Object:  Table [dbo].[aula]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[aula_equipamiento]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[dias_semana]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[equipamiento]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[horas]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[materias]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[Periodo]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[reserva]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[tipoSala]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[tipoUsuario]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[ubicacion]    Script Date: 15/11/2023 22:40:59 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 15/11/2023 22:40:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
