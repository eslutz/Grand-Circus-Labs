USE [master]
GO
/****** Object:  Database [SlackOverload]    Script Date: 9/17/2020 9:18:58 PM ******/
CREATE DATABASE [SlackOverload]
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
/****** Object:  User [SlackOverloadUser]    Script Date: 9/17/2020 9:18:58 PM ******/
CREATE USER [SlackOverloadUser] FOR LOGIN [SlackOverloadUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SlackOverloadUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [SlackOverloadUser]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 9/17/2020 9:18:58 PM ******/
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
/****** Object:  Table [dbo].[Questions]    Script Date: 9/17/2020 9:18:58 PM ******/
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
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (1, N'testuser', N'L2Troll N00b', 1, CAST(N'2020-09-17T09:32:54.540' AS DateTime), 4)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (2, N'testuser', N'Trolling is bad.  Don''t do that!', 1, CAST(N'2020-09-17T09:46:58.250' AS DateTime), -3)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (5, N'testuser', N'test', 1, CAST(N'2020-09-17T09:47:07.123' AS DateTime), 1)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (6, N'testuser', N'testt answer', 1, CAST(N'2020-09-17T09:54:17.457' AS DateTime), 2)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (7, N'testuser', N'test answer', 4, CAST(N'2020-09-17T09:56:56.720' AS DateTime), 4)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (8, N'testuser', N'test answer', 5, CAST(N'2020-09-17T09:57:47.077' AS DateTime), 6)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (9, N'testuser', N'test a', 4, CAST(N'2020-09-17T10:03:23.360' AS DateTime), 5)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (10, N'testuser', N'test', 5, CAST(N'2020-09-17T10:04:09.287' AS DateTime), 2)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (11, N'testuser', N'test', 8, CAST(N'2020-09-17T10:10:04.903' AS DateTime), 3)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (12, N'testuser', N'test', 9, CAST(N'2020-09-17T10:55:17.840' AS DateTime), 0)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (17, N'ecc', N'Questions?', 5, CAST(N'2020-09-17T18:00:59.957' AS DateTime), 1)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (18, N'eslutz', N'I have the answer, but I''m not sharing.', 5, CAST(N'2020-09-17T19:59:56.180' AS DateTime), 15)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (19, N'eslutz', N'I don''t want to give you the answer', 5, CAST(N'2020-09-17T20:00:15.730' AS DateTime), 11)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (22, N'testingtests', N'I don''t know.', 8, CAST(N'2020-09-17T20:11:09.217' AS DateTime), 0)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (23, N'testingtests', N'False, this is not a test.', 9, CAST(N'2020-09-17T20:13:22.510' AS DateTime), 25)
GO
INSERT [dbo].[Answers] ([id], [Username], [Details], [QuestionID], [Posted], [Upvotes]) VALUES (24, N'eslutz', N'42', 8, CAST(N'2020-09-17T21:15:01.890' AS DateTime), 6)
GO
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 
GO
INSERT [dbo].[Questions] ([id], [Username], [Title], [Details], [Posted], [Category], [Tags], [Status]) VALUES (1, N'testuser', N'How 2 Troll', N'How do I troll like the big dawgs?', CAST(N'2020-09-16T14:15:48.467' AS DateTime), N'Trolling 101', N'Trolling, How 2', 1)
GO
INSERT [dbo].[Questions] ([id], [Username], [Title], [Details], [Posted], [Category], [Tags], [Status]) VALUES (4, N'testuser', N'Updated Question', N'You''re stupid.', CAST(N'2020-09-16T14:16:51.483' AS DateTime), N'answer', N'quest', 1)
GO
INSERT [dbo].[Questions] ([id], [Username], [Title], [Details], [Posted], [Category], [Tags], [Status]) VALUES (5, N'testuser', N'Question', N'What is a question and how do you ask it?', CAST(N'2020-09-17T10:11:22.320' AS DateTime), N'question', N'questions', 0)
GO
INSERT [dbo].[Questions] ([id], [Username], [Title], [Details], [Posted], [Category], [Tags], [Status]) VALUES (8, N'eslutz', N'Question for all', N'What is the meaning of life?', CAST(N'2020-09-17T20:00:59.817' AS DateTime), N'philosophy', NULL, 0)
GO
INSERT [dbo].[Questions] ([id], [Username], [Title], [Details], [Posted], [Category], [Tags], [Status]) VALUES (9, N'testingtests', N'Testing of a Test', N'Test of a test of a test of a test.', CAST(N'2020-09-17T20:13:29.700' AS DateTime), N'Testing', N'Test', 0)
GO
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_Answers_Questions] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_Answers_Questions]
GO
USE [master]
GO
ALTER DATABASE [SlackOverload] SET  READ_WRITE 
GO