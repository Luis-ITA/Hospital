USE [master]
GO
/****** Object:  Database [Clinica]    Script Date: 26/05/2019 01:13:19 p.m. ******/
CREATE DATABASE [Clinica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Clinica.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Clinica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Clinica_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Clinica] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Clinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Clinica] SET  MULTI_USER 
GO
ALTER DATABASE [Clinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Clinica] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Clinica]
GO
/****** Object:  Table [dbo].[Consulta]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[Num_Consulta] [nvarchar](3) NOT NULL,
	[Paciente] [nvarchar](35) NOT NULL,
	[Medico_Cedula] [nvarchar](8) NOT NULL,
	[Padecimiento] [nvarchar](20) NOT NULL,
	[Peso] [smallint] NOT NULL,
	[Estatura] [tinyint] NOT NULL,
	[Alergias] [nvarchar](50) NOT NULL,
	[Presion_Arterial] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK__Consulta__9C72540C22521096] PRIMARY KEY CLUSTERED 
(
	[Num_Consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[Clave_Medicamento] [nvarchar](10) NOT NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Fecha_Caducidad] [date] NOT NULL,
	[Precio] [money] NOT NULL,
	[Via_Administracion] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Clave_Medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medico]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[Cedula_Profesional] [nvarchar](8) NOT NULL,
	[Nombre] [nvarchar](35) NOT NULL,
	[Especialidad] [nvarchar](30) NOT NULL,
	[Telefono] [nvarchar](13) NOT NULL,
	[Sueldo] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula_Profesional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[Expediente] [nvarchar](8) NOT NULL,
	[Nombre] [nvarchar](35) NOT NULL,
	[Edad] [tinyint] NOT NULL,
	[Padecimiento] [nvarchar](20) NOT NULL,
	[Observaciones] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Expediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Receta]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[Folio] [nvarchar](10) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Temperatura_Corporal] [tinyint] NOT NULL,
	[Medico_Cedula] [nvarchar](8) NOT NULL,
	[Paciente_Expediente] [nvarchar](8) NOT NULL,
	[Medicamento_Clave] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK__Receta__BAB84EF6E0923839] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[MedicoPaciente]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MedicoPaciente]
AS
SELECT        dbo.Medico.Nombre, dbo.Paciente.Nombre AS EXPR1, dbo.Paciente.Expediente, dbo.Medico.Cedula_Profesional, dbo.Paciente.Padecimiento
FROM            dbo.Medico INNER JOIN
                         dbo.Receta ON dbo.Medico.Cedula_Profesional = dbo.Receta.Medico_Cedula INNER JOIN
                         dbo.Paciente ON dbo.Receta.Paciente_Expediente = dbo.Paciente.Expediente

GO
/****** Object:  View [dbo].[VistaConsulta]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaConsulta]
AS
SELECT        dbo.Consulta.Num_Consulta, dbo.Consulta.Paciente, dbo.Consulta.Medico_Cedula, dbo.Medico.Nombre, dbo.Consulta.Padecimiento, 
                         dbo.Paciente.Observaciones
FROM            dbo.Consulta INNER JOIN
                         dbo.Medico ON dbo.Consulta.Medico_Cedula = dbo.Medico.Cedula_Profesional INNER JOIN
                         dbo.Paciente ON dbo.Consulta.Paciente = dbo.Paciente.Nombre

GO
/****** Object:  View [dbo].[VistaMedicamento]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaMedicamento]
AS
SELECT        dbo.Medicamento.Clave_Medicamento, dbo.Medicamento.Nombre, dbo.Paciente.Nombre AS EXPR1, dbo.Receta.Folio
FROM            dbo.Medicamento INNER JOIN
                         dbo.Receta ON dbo.Medicamento.Clave_Medicamento = dbo.Receta.Medicamento_Clave INNER JOIN
                         dbo.Paciente ON dbo.Receta.Paciente_Expediente = dbo.Paciente.Expediente

GO
/****** Object:  View [dbo].[VistaPaciente]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaPaciente]
AS
SELECT        dbo.Medico.Nombre, dbo.Paciente.Nombre AS EXPR1, dbo.Receta.Folio, dbo.Receta.Medicamento_Clave
FROM            dbo.Receta INNER JOIN
                         dbo.Medico ON dbo.Receta.Medico_Cedula = dbo.Medico.Cedula_Profesional INNER JOIN
                         dbo.Paciente ON dbo.Receta.Paciente_Expediente = dbo.Paciente.Expediente

GO
/****** Object:  View [dbo].[VistaReceta]    Script Date: 26/05/2019 01:13:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaReceta]
AS
SELECT        dbo.Medico.Nombre, dbo.Paciente.Nombre AS EXPR1, dbo.Receta.Folio, dbo.Receta.Fecha
FROM            dbo.Medico INNER JOIN
                         dbo.Receta ON dbo.Medico.Cedula_Profesional = dbo.Receta.Medico_Cedula INNER JOIN
                         dbo.Paciente ON dbo.Receta.Paciente_Expediente = dbo.Paciente.Expediente

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Medico"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paciente"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Receta"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 135
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MedicoPaciente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MedicoPaciente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Consulta"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Medico"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paciente"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 135
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaConsulta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaConsulta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Medicamento"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paciente"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Receta"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 135
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaMedicamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaMedicamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Medico"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Paciente"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 135
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Receta"
            Begin Extent = 
               Top = 6
               Left = 779
               Bottom = 135
               Right = 988
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaPaciente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaPaciente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Medico"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paciente"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Receta"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 135
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaReceta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaReceta'
GO
USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
