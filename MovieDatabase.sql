USE [master]
GO
/****** Object:  Database [Movie]    Script Date: 9/22/2020 4:55:03 PM ******/
CREATE DATABASE [Movie]
GO
ALTER DATABASE [Movie] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Movie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Movie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Movie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Movie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Movie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Movie] SET ARITHABORT OFF 
GO
ALTER DATABASE [Movie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Movie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Movie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Movie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Movie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Movie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Movie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Movie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Movie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Movie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Movie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Movie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Movie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Movie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Movie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Movie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Movie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Movie] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Movie] SET  MULTI_USER 
GO
ALTER DATABASE [Movie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Movie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Movie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Movie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Movie] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Movie] SET QUERY_STORE = OFF
GO
USE [Movie]
GO
/****** Object:  User [MovieUser]    Script Date: 9/22/2020 4:55:03 PM ******/
CREATE USER [MovieUser] FOR LOGIN [MovieUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [MovieUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [MovieUser]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 9/22/2020 4:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Category] [nchar](10) NOT NULL,
	[ReleaseYear] [int] NOT NULL,
	[Runtime] [int] NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (1, N'Aliens', N'SciFi     ', 1986, 137)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (2, N'The Matrix', N'SciFi     ', 1999, 136)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (3, N'Die Hard', N'Action    ', 1988, 132)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (4, N'Evil Dead', N'Horror    ', 1982, 85)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (5, N'Back to the Future', N'Comedy    ', 1985, 116)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (6, N'Bad Boys', N'Action    ', 1995, 118)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (7, N'Bad Santa', N'Comedy    ', 2003, 99)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (8, N'Blade Runner', N'SciFi     ', 1982, 117)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (9, N'Caddychack', N'Comedy    ', 1980, 98)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (10, N'A Chirstmas Story', N'Comedy    ', 1983, 93)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (11, N'Dawn of the Dead', N'Horror    ', 1978, 127)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (12, N'Day of the Dead', N'Horror    ', 1985, 96)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (13, N'Night of the Living Dead', N'Horror    ', 1968, 88)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (14, N'Dirty Harry', N'Thirller  ', 1971, 102)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (15, N'The Fifth Element', N'SciFi     ', 1997, 125)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (16, N'Fury', N'Action    ', 2014, 134)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (17, N'Gladiator', N'Drama     ', 2000, 155)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (18, N'Hidden Figures', N'Drama     ', 2016, 127)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (19, N'Harold and Kumar Go to White Castle', N'Comedy    ', 2004, 88)
GO
INSERT [dbo].[Movie] ([id], [Title], [Category], [ReleaseYear], [Runtime]) VALUES (21, N'Idiocracy', N'Document  ', 2007, 84)
GO
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
USE [master]
GO
ALTER DATABASE [Movie] SET  READ_WRITE 
GO