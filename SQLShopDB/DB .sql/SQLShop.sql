USE [master]
GO
/****** Object:  Database [TestingDatabase]    Script Date: 2020-07-06 09:30:54 ******/
CREATE DATABASE [TestingDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestingDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TestingDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestingDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TestingDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TestingDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestingDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestingDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestingDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestingDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestingDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestingDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestingDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestingDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestingDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestingDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestingDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestingDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestingDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestingDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestingDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestingDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TestingDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestingDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestingDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestingDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestingDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestingDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestingDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestingDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [TestingDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [TestingDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestingDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestingDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestingDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TestingDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TestingDatabase', N'ON'
GO
ALTER DATABASE [TestingDatabase] SET QUERY_STORE = OFF
GO
USE [TestingDatabase]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 2020-07-06 09:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[adminid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[surname] [varchar](50) NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2020-07-06 09:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[clientid] [int] IDENTITY(1,1) NOT NULL,
	[balance] [int] NULL,
	[name] [varchar](50) NULL,
	[surname] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[street] [varchar](50) NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2020-07-06 09:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[price] [int] NULL,
	[count] [int] NULL,
	[maxcount] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([adminid], [name], [surname], [login], [password]) VALUES (1, N'Radoslaw', N'Mical', N'radoslaw626', N'admin123')
INSERT [dbo].[Admins] ([adminid], [name], [surname], [login], [password]) VALUES (2, N'testadmin', N'testadmin', N'1', N'1')
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([clientid], [balance], [name], [surname], [city], [street], [login], [password]) VALUES (1, 10, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Clients] ([clientid], [balance], [name], [surname], [city], [street], [login], [password]) VALUES (8, 0, N'', N'', N'asdads', N'', N'', N'')
INSERT [dbo].[Clients] ([clientid], [balance], [name], [surname], [city], [street], [login], [password]) VALUES (9, 0, N'Radek', N'Mical', N'Rzeszow', N'Nosowka', N'login123', N'haslo123')
INSERT [dbo].[Clients] ([clientid], [balance], [name], [surname], [city], [street], [login], [password]) VALUES (10, 985, N'Robert', N'', N'', N'', N'2', N'2')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (1, N'jaja', N'nabial', 5, 47, 50)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (2, N'chleb', N'pieczywo', 4, 10, 20)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (3, N'szynka', N'mieso', 20, 3, 5)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (4, N'ogorki', N'warzywa', 3, 20, 20)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (5, N'salata', N'warzywa', 5, 5, 10)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (6, N'ziemniaki', N'warzywa', 2, 40, 50)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (7, N'cebula', N'warzywa', 2, 30, 40)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (8, N'schab', N'mieso', 15, 8, 10)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (9, N'karkowka', N'mieso', 20, 10, 10)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (10, N'bagietki', N'pieczywo', 2, 20, 20)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (11, N'jogurt', N'nabial', 2, 20, 20)
INSERT [dbo].[Products] ([id], [name], [category], [price], [count], [maxcount]) VALUES (12, N'ser', N'nabial', 14, 10, 10)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
USE [master]
GO
ALTER DATABASE [TestingDatabase] SET  READ_WRITE 
GO
