USE [K11TestDb]
GO
/****** Object:  Schema [trsobj]    Script Date: 1/07/2022 19:03:00 ******/
CREATE SCHEMA [trsobj]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/07/2022 19:03:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [trsobj].[Encuestas]    Script Date: 1/07/2022 19:03:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [trsobj].[Encuestas](
	[IdEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](250) NULL,
	[Estado] [int] NOT NULL,
	[UsuarioCrea] [int] NOT NULL,
	[FechaCrea] [datetime2](7) NOT NULL,
	[UsuarioModifica] [int] NOT NULL,
	[FechaModifica] [datetime2](7) NULL,
 CONSTRAINT [PK_Encuestas] PRIMARY KEY CLUSTERED 
(
	[IdEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [trsobj].[PreguntasEncuestas]    Script Date: 1/07/2022 19:03:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [trsobj].[PreguntasEncuestas](
	[IdPreguntaEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[IdEncuesta] [int] NOT NULL,
	[Descripcion] [nvarchar](250) NULL,
	[Estado] [int] NOT NULL,
	[UsuarioCrea] [int] NOT NULL,
	[FechaCrea] [datetime2](7) NOT NULL,
	[UsuarioModifica] [int] NOT NULL,
	[FechaModifica] [datetime2](7) NULL,
 CONSTRAINT [PK_PreguntasEncuestas] PRIMARY KEY CLUSTERED 
(
	[IdPreguntaEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [trsobj].[RespuestasEncuestas]    Script Date: 1/07/2022 19:03:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [trsobj].[RespuestasEncuestas](
	[IdRespuestaEncuenta] [int] IDENTITY(1,1) NOT NULL,
	[IdPreguntaEncuesta] [int] NOT NULL,
	[DescripcionRespuesta] [nvarchar](250) NULL,
	[Estado] [int] NOT NULL,
	[UsuarioCrea] [int] NOT NULL,
	[FechaCrea] [datetime2](7) NOT NULL,
	[UsuarioModifica] [int] NOT NULL,
	[FechaModifica] [datetime2](7) NULL,
 CONSTRAINT [PK_RespuestasEncuestas] PRIMARY KEY CLUSTERED 
(
	[IdRespuestaEncuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [trsobj].[PreguntasEncuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasEncuestas_Encuestas_IdEncuesta] FOREIGN KEY([IdEncuesta])
REFERENCES [trsobj].[Encuestas] ([IdEncuesta])
GO
ALTER TABLE [trsobj].[PreguntasEncuestas] CHECK CONSTRAINT [FK_PreguntasEncuestas_Encuestas_IdEncuesta]
GO
ALTER TABLE [trsobj].[RespuestasEncuestas]  WITH CHECK ADD  CONSTRAINT [FK_RespuestasEncuestas_PreguntasEncuestas_IdPreguntaEncuesta] FOREIGN KEY([IdPreguntaEncuesta])
REFERENCES [trsobj].[PreguntasEncuestas] ([IdPreguntaEncuesta])
GO
ALTER TABLE [trsobj].[RespuestasEncuestas] CHECK CONSTRAINT [FK_RespuestasEncuestas_PreguntasEncuestas_IdPreguntaEncuesta]
GO
