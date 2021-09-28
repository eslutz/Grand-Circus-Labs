USE [master]
GO
/****** Object:  Database [CoffeeShop]    Script Date: 9/10/2020 9:49:23 PM ******/
CREATE DATABASE [CoffeeShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoffeeShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoffeeShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CoffeeShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE = OFF
GO
USE [CoffeeShop]
GO
/****** Object:  User [CoffeeShopUser]    Script Date: 9/10/2020 9:49:23 PM ******/
CREATE USER [CoffeeShopUser] FOR LOGIN [CoffeeShopUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [CoffeeShopUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [CoffeeShopUser]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/10/2020 9:49:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Description] [varchar](50) NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Product2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (1, N'Coffee', N'Drink', N'Hot liquid', 2.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (2, N'Latte', N'Drink', N'Hot frothy liquid', 4.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (3, N'Tea', N'Drink', N'Hot liquid with leaves', 1.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (4, N'Cake Pop', N'Food', N'Yummy on a stick', 3)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (5, N'Muffin', N'Food', N'Round bread', 5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (7, N'Esspresso', N'Drink', N'Hot liquid of energy', 2.75)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (8, N'Water', N'Drink', N'Boring liquid', 1.25)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (9, N'Cermaic Mug', N'Cup', N'Holds hot liquid', 6.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (10, N'Glass', N'Cup', N'Holds cold liquid', 6)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (11, N'Vanilla', N'Extra', N'Vanilla flavor', 0.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (12, N'Hazelnut', N'Extra', N'Hazelnut flavor', 0.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (13, N'Cream', N'Extra', N'Creamy dilution for drink', 0.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (14, N'Soy Milk', N'Extra', N'Alternative creamy dilution for drink', 0.5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Category], [Description], [Price]) VALUES (15, N'Brownie', N'Food', N'Chocolate yummy square', 3.5)
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
USE [master]
GO
ALTER DATABASE [CoffeeShop] SET  READ_WRITE 
GO