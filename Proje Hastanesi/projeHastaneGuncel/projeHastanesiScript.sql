USE [master]
GO
/****** Object:  Database [projeHastanesi]    Script Date: 23.02.2022 02:03:22 ******/
CREATE DATABASE [projeHastanesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'projeHastanesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\projeHastanesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'projeHastanesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\projeHastanesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [projeHastanesi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [projeHastanesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [projeHastanesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [projeHastanesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [projeHastanesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [projeHastanesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [projeHastanesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [projeHastanesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [projeHastanesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [projeHastanesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [projeHastanesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [projeHastanesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [projeHastanesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [projeHastanesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [projeHastanesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [projeHastanesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [projeHastanesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [projeHastanesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [projeHastanesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [projeHastanesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [projeHastanesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [projeHastanesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [projeHastanesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [projeHastanesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [projeHastanesi] SET RECOVERY FULL 
GO
ALTER DATABASE [projeHastanesi] SET  MULTI_USER 
GO
ALTER DATABASE [projeHastanesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [projeHastanesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [projeHastanesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [projeHastanesi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [projeHastanesi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [projeHastanesi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [projeHastanesi] SET QUERY_STORE = OFF
GO
USE [projeHastanesi]
GO
/****** Object:  Table [dbo].[branslar]    Script Date: 23.02.2022 02:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branslar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doktorlar]    Script Date: 23.02.2022 02:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktorlar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](30) NULL,
	[soyad] [varchar](30) NULL,
	[TCno] [varchar](50) NULL,
	[brans] [varchar](30) NULL,
	[sifre] [varchar](6) NULL,
	[cinsiyet] [nchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[duyurular]    Script Date: 23.02.2022 02:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[duyurular](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[icerigi] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hastalar]    Script Date: 23.02.2022 02:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hastalar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](30) NULL,
	[soyad] [varchar](30) NULL,
	[TCno] [varchar](30) NULL,
	[telefon] [varchar](30) NULL,
	[sifre] [varchar](8) NULL,
	[cinsiyet] [nchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevular]    Script Date: 23.02.2022 02:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevular](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[tarih] [varchar](10) NULL,
	[saat] [varchar](5) NULL,
	[doktor] [varchar](30) NULL,
	[brans] [varchar](30) NULL,
	[TCno] [varchar](50) NULL,
	[durum] [char](1) NULL,
	[sikayet] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sekreterler]    Script Date: 23.02.2022 02:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sekreterler](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](30) NULL,
	[soyad] [varchar](30) NULL,
	[TCno] [varchar](30) NULL,
	[sifre] [varchar](6) NULL,
	[cinsiyet] [nchar](5) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [projeHastanesi] SET  READ_WRITE 
GO
