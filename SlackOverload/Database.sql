﻿USE [master]
GO
/****** Object:  Database [SlackOverload]    Script Date: 9/15/2020 9:20:52 PM ******/
CREATE DATABASE [SlackOverload]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SlackOverload', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SlackOverload.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SlackOverload_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SlackOverload_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SlackOverload] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SlackOverload].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SlackOverload] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SlackOverload] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SlackOverload] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SlackOverload] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SlackOverload] SET ARITHABORT OFF 
GO
ALTER DATABASE [SlackOverload] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SlackOverload] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SlackOverload] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SlackOverload] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SlackOverload] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SlackOverload] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SlackOverload] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SlackOverload] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SlackOverload] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SlackOverload] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SlackOverload] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SlackOverload] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SlackOverload] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SlackOverload] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SlackOverload] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SlackOverload] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SlackOverload] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SlackOverload] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SlackOverload] SET  MULTI_USER 
GO
ALTER DATABASE [SlackOverload] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SlackOverload] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SlackOverload] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SlackOverload] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SlackOverload] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SlackOverload] SET QUERY_STORE = OFF
GO
USE [SlackOverload]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 9/15/2020 9:20:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[QuestionID] [int] NOT NULL,
	[Posted] [datetime] NOT NULL,
	[Upvotes] [int] NULL,
 CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 9/15/2020 9:20:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[Posted] [datetime] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Tags] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (1, N'KingTroll', N'L2Troll N00b', 1, CAST(N'2008-10-29T15:56:59.000' AS DateTime), 1000)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (2, N'NotTroll', N'Trolling is bad.  Don''t do that!', 1, CAST(N'2008-10-29T18:56:59.000' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 
GO
INSERT [dbo].[Questions] ([id], [Username], [Title], [Details], [Posted], [Category], [Tags], [Status]) VALUES (1, N'TrollFarmer', N'How 2 Troll', N'How do I troll like the big dawgs?', CAST(N'2008-10-29T14:56:59.000' AS DateTime), N'Trolling 101', N'Trolling, How 2', 1)
GO
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_Answers_Answers] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([id])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_Answers_Answers]
GO
USE [master]
GO
ALTER DATABASE [SlackOverload] SET  READ_WRITE 
GO
