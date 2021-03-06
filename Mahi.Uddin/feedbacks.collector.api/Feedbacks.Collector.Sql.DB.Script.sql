USE [master]
GO
/****** Object:  Database [Feedbacks.Collector]    Script Date: 1/2/2021 8:52:11 PM ******/
CREATE DATABASE [Feedbacks.Collector]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Feedbacks.Collector', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Feedbacks.Collector.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Feedbacks.Collector_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Feedbacks.Collector_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Feedbacks.Collector] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Feedbacks.Collector].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Feedbacks.Collector] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET ARITHABORT OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Feedbacks.Collector] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Feedbacks.Collector] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Feedbacks.Collector] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Feedbacks.Collector] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Feedbacks.Collector] SET  MULTI_USER 
GO
ALTER DATABASE [Feedbacks.Collector] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Feedbacks.Collector] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Feedbacks.Collector] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Feedbacks.Collector] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Feedbacks.Collector] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Feedbacks.Collector] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Feedbacks.Collector] SET QUERY_STORE = OFF
GO
USE [Feedbacks.Collector]
GO
/****** Object:  Table [dbo].[Activities]    Script Date: 1/2/2021 8:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[Id] [varchar](50) NOT NULL,
	[ActivityType] [varchar](50) NOT NULL,
	[FeelingsType] [varchar](50) NULL,
	[Comments] [text] NULL,
	[ActivityById] [varchar](50) NOT NULL,
	[ActivityBlogsRefId] [varchar](50) NOT NULL,
	[ActivityDate] [datetime] NOT NULL,
	[ModifyDate] [datetime] NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_Activities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 1/2/2021 8:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[Id] [varchar](50) NOT NULL,
	[Title] [varchar](200) NOT NULL,
	[BlogsDetails] [text] NOT NULL,
	[Types] [varchar](50) NOT NULL,
	[Tags] [varchar](100) NOT NULL,
	[CreatedById] [varchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModifyDate] [datetime] NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 1/2/2021 8:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](100) NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/2/2021 8:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [varchar](50) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Address] [varchar](200) NULL,
	[MobileNumber] [varchar](50) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[RoleId] [varchar](50) NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
	[IsPasswordResetRequired] [int] NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_CreatedById] FOREIGN KEY([CreatedById])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_CreatedById]
GO
USE [master]
GO
ALTER DATABASE [Feedbacks.Collector] SET  READ_WRITE 
GO
