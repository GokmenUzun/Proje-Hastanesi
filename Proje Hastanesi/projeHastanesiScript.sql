USE [master]
GO
/****** Object:  Database [ProjeHastanesi]    Script Date: 2.03.2022 11:55:19 ******/
CREATE DATABASE [ProjeHastanesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjeHastanesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ProjeHastanesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjeHastanesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ProjeHastanesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProjeHastanesi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjeHastanesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjeHastanesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjeHastanesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjeHastanesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjeHastanesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjeHastanesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjeHastanesi] SET  MULTI_USER 
GO
ALTER DATABASE [ProjeHastanesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjeHastanesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjeHastanesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjeHastanesi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjeHastanesi] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjeHastanesi', N'ON'
GO
ALTER DATABASE [ProjeHastanesi] SET QUERY_STORE = OFF
GO
USE [ProjeHastanesi]
GO
/****** Object:  Table [dbo].[branslar]    Script Date: 2.03.2022 11:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branslar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doktorlar]    Script Date: 2.03.2022 11:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktorlar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[TCno] [varchar](50) NULL,
	[brans] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[cinsiyet] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[duyurular]    Script Date: 2.03.2022 11:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[duyurular](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[baslik] [varchar](30) NULL,
	[icerigi] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hastalar]    Script Date: 2.03.2022 11:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hastalar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[TCno] [varchar](50) NULL,
	[telefon] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[cinsiyet] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevular]    Script Date: 2.03.2022 11:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevular](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[tarih] [varchar](50) NULL,
	[saat] [varchar](50) NULL,
	[doktor] [varchar](50) NULL,
	[brans] [varchar](50) NULL,
	[sikayet] [varchar](50) NULL,
	[TCno] [varchar](50) NULL,
	[durum] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sekreterler]    Script Date: 2.03.2022 11:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sekreterler](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[TCno] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[cinsiyet] [varchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ProjeHastanesi] SET  READ_WRITE 
GO
