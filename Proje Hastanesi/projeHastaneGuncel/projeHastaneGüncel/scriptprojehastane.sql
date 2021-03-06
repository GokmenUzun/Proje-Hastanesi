USE [master]
GO
/****** Object:  Database [projeHastanesi]    Script Date: 23.02.2022 16:29:32 ******/
CREATE DATABASE [projeHastanesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'projeHastanesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\projeHastanesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'projeHastanesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\projeHastanesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
EXEC sys.sp_db_vardecimal_storage_format N'projeHastanesi', N'ON'
GO
ALTER DATABASE [projeHastanesi] SET QUERY_STORE = OFF
GO
USE [projeHastanesi]
GO
/****** Object:  Table [dbo].[branslar]    Script Date: 23.02.2022 16:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branslar](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doktorlar]    Script Date: 23.02.2022 16:29:32 ******/
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
/****** Object:  Table [dbo].[duyurular]    Script Date: 23.02.2022 16:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[duyurular](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[icerigi] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hastalar]    Script Date: 23.02.2022 16:29:32 ******/
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
/****** Object:  Table [dbo].[randevular]    Script Date: 23.02.2022 16:29:32 ******/
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
	[TCno] [varchar](50) NULL,
	[durum] [char](1) NULL,
	[sikayet] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sekreterler]    Script Date: 23.02.2022 16:29:32 ******/
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
SET IDENTITY_INSERT [dbo].[branslar] ON 

INSERT [dbo].[branslar] ([id], [ad]) VALUES (1, N'Göz
')
INSERT [dbo].[branslar] ([id], [ad]) VALUES (2, N'KBB')
INSERT [dbo].[branslar] ([id], [ad]) VALUES (3, N'Psikolog')
SET IDENTITY_INSERT [dbo].[branslar] OFF
SET IDENTITY_INSERT [dbo].[doktorlar] ON 

INSERT [dbo].[doktorlar] ([id], [ad], [soyad], [TCno], [brans], [sifre], [cinsiyet]) VALUES (1, N'Gökmen', N'Uzun', N'11111111111', N'KBB', N'1111', N'Erkek')
INSERT [dbo].[doktorlar] ([id], [ad], [soyad], [TCno], [brans], [sifre], [cinsiyet]) VALUES (2, N'Görkem', N'Yel', N'22222222222', N'Psikolog', N'1234', NULL)
INSERT [dbo].[doktorlar] ([id], [ad], [soyad], [TCno], [brans], [sifre], [cinsiyet]) VALUES (3, N'Çağtay', N'Denizhan', N'44444444444', N'Göz
', N'cagtay', NULL)
SET IDENTITY_INSERT [dbo].[doktorlar] OFF
SET IDENTITY_INSERT [dbo].[Hastalar] ON 

INSERT [dbo].[Hastalar] ([id], [ad], [soyad], [TCno], [telefon], [sifre], [cinsiyet]) VALUES (1, N'Görkem', N'Yel', N'99999999999', N'(999) 999-9999', N'9999', N'Erkek')
INSERT [dbo].[Hastalar] ([id], [ad], [soyad], [TCno], [telefon], [sifre], [cinsiyet]) VALUES (2, N'Yahya', N'ECİN', N'99999999998', N'(999) 999-9999', N'9999', N'Erkek')
SET IDENTITY_INSERT [dbo].[Hastalar] OFF
SET IDENTITY_INSERT [dbo].[randevular] ON 

INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (1, N'1111-11-11', N'11:11', N'Gökmen Uzun', N'KBB', N'99999999999', N'1', N'Deneme')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (2, N'3123-12-31', N'12:31', N'Görkem Yel', N'Psikolog', N'99999999999', N'1', N'PSİKOPATIM')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (4, N'2022-12-07', N'18:00', N'Gökmen Uzun', N'KBB', N'99999999999', N'1', N'ONDAN')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (5, N'27.09.2022', N'18:29', N'Görkem Yel', N'Psikolog', N'99999999999', N'1', N'dd')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (6, N'18.09.2022', N'22:22', N'Görkem Yel', N'Psikolog', N'', N'0', NULL)
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (7, N'22.22.2222', N'22:22', N'Görkem Yel', N'Psikolog', N'99999999999', N'1', N'dsada')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (8, N'12.31.2312', N'17:38', N'Görkem Yel', N'Psikolog', N'99999999999', N'1', N'Baş ağrısı')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (9, N'18.09.2022', N'16:30', N'Gökmen Uzun', N'KBB', N'99999999998', N'1', N'sad')
INSERT [dbo].[randevular] ([id], [tarih], [saat], [doktor], [brans], [TCno], [durum], [sikayet]) VALUES (10, N'18.09.2022', N'17:30', N'Çağtay Denizhan', N'Göz
', N'', N'0', NULL)
SET IDENTITY_INSERT [dbo].[randevular] OFF
SET IDENTITY_INSERT [dbo].[sekreterler] ON 

INSERT [dbo].[sekreterler] ([id], [ad], [soyad], [TCno], [sifre], [cinsiyet]) VALUES (1, N'Çağtay', N'Denizhan', N'11111111111', N'111', N'Erkek')
SET IDENTITY_INSERT [dbo].[sekreterler] OFF
USE [master]
GO
ALTER DATABASE [projeHastanesi] SET  READ_WRITE 
GO
