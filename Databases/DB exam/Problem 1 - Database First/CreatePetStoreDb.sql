USE [master]
GO
/****** Object:  Database [PetStore]    Script Date: 23/10/2015 11:49:32 ******/
CREATE DATABASE [PetStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PetStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PetStore.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PetStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PetStore_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PetStore] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PetStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PetStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetStore] SET  MULTI_USER 
GO
ALTER DATABASE [PetStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PetStore] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PetStore]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 23/10/2015 11:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Colors]    Script Date: 23/10/2015 11:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 23/10/2015 11:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pets]    Script Date: 23/10/2015 11:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Price] [money] NOT NULL,
	[Breed] [nvarchar](30) NULL,
	[ColorId] [int] NOT NULL,
	[SpecieId] [int] NULL,
 CONSTRAINT [PK_Pets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 23/10/2015 11:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Price] [money] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductsSpecies]    Script Date: 23/10/2015 11:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsSpecies](
	[ProductId] [int] NOT NULL,
	[SpecieId] [int] NOT NULL,
 CONSTRAINT [PK_ProductsSpecies] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[SpecieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Species]    Script Date: 23/10/2015 11:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Species](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Species] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Colors]    Script Date: 23/10/2015 11:49:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Colors] ON [dbo].[Colors]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Countries]    Script Date: 23/10/2015 11:49:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Countries] ON [dbo].[Countries]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Species]    Script Date: 23/10/2015 11:49:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Species] ON [dbo].[Species]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pets]  WITH CHECK ADD  CONSTRAINT [FK_Pets_Colors] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Pets] CHECK CONSTRAINT [FK_Pets_Colors]
GO
ALTER TABLE [dbo].[Pets]  WITH CHECK ADD  CONSTRAINT [FK_Pets_Species] FOREIGN KEY([SpecieId])
REFERENCES [dbo].[Species] ([Id])
GO
ALTER TABLE [dbo].[Pets] CHECK CONSTRAINT [FK_Pets_Species]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[ProductsSpecies]  WITH CHECK ADD  CONSTRAINT [FK_ProductsSpecies_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductsSpecies] CHECK CONSTRAINT [FK_ProductsSpecies_Products]
GO
ALTER TABLE [dbo].[ProductsSpecies]  WITH CHECK ADD  CONSTRAINT [FK_ProductsSpecies_Species] FOREIGN KEY([SpecieId])
REFERENCES [dbo].[Species] ([Id])
GO
ALTER TABLE [dbo].[ProductsSpecies] CHECK CONSTRAINT [FK_ProductsSpecies_Species]
GO
ALTER TABLE [dbo].[Species]  WITH CHECK ADD  CONSTRAINT [FK_Species_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Species] CHECK CONSTRAINT [FK_Species_Countries]
GO
USE [master]
GO
ALTER DATABASE [PetStore] SET  READ_WRITE 
GO
