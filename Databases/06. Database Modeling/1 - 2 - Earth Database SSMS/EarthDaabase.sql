USE [master]
GO
/****** Object:  Database [EarthDatabase]    Script Date: 08/10/2015 22:28:39 ******/
CREATE DATABASE [EarthDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EarthDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EarthDatabase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EarthDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EarthDatabase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EarthDatabase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EarthDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EarthDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EarthDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EarthDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EarthDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EarthDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EarthDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EarthDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EarthDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EarthDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EarthDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EarthDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EarthDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EarthDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EarthDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EarthDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EarthDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EarthDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EarthDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EarthDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EarthDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [EarthDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EarthDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EarthDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EarthDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EarthDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
USE [EarthDatabase]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 08/10/2015 22:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[address_text] [nvarchar](50) NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 08/10/2015 22:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 08/10/2015 22:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[contitnent_id] [int] NOT NULL,
 CONSTRAINT [PK_Counties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 08/10/2015 22:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 08/10/2015 22:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[county_id] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([ID], [address_text], [town_id]) VALUES (6, N'aaa', 4)
INSERT [dbo].[Addresses] ([ID], [address_text], [town_id]) VALUES (7, N'bbb', 1)
INSERT [dbo].[Addresses] ([ID], [address_text], [town_id]) VALUES (8, N'ccc', 8)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ID], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (2, N'Asia')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (3, N'Africa')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (4, N'America')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (5, N'Oceania')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (7, N'')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([ID], [name], [contitnent_id]) VALUES (1, N'Italy', 1)
INSERT [dbo].[Countries] ([ID], [name], [contitnent_id]) VALUES (2, N'France', 1)
INSERT [dbo].[Countries] ([ID], [name], [contitnent_id]) VALUES (3, N'USA', 4)
INSERT [dbo].[Countries] ([ID], [name], [contitnent_id]) VALUES (4, N'Japan', 2)
INSERT [dbo].[Countries] ([ID], [name], [contitnent_id]) VALUES (6, N'Kenya', 3)
INSERT [dbo].[Countries] ([ID], [name], [contitnent_id]) VALUES (8, N'Germany', 1)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([ID], [first_name], [last_name], [address_id]) VALUES (2, N'Evlogi', N'Minchev', 6)
INSERT [dbo].[Persons] ([ID], [first_name], [last_name], [address_id]) VALUES (3, N'Mincho', N'Ivanov', 6)
INSERT [dbo].[Persons] ([ID], [first_name], [last_name], [address_id]) VALUES (4, N'Pesho', N'Peshev', 7)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (1, N'Rome', 1)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (2, N'Paris', 2)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (3, N'New York', 3)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (4, N'Hong Kong', 4)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (6, N'Nairobi', 6)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (7, N'Perugia', 1)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (8, N'Milano', 1)
INSERT [dbo].[Towns] ([ID], [name], [county_id]) VALUES (9, N'Florence', 1)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([town_id])
REFERENCES [dbo].[Towns] ([ID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Counties_Continents] FOREIGN KEY([contitnent_id])
REFERENCES [dbo].[Continents] ([ID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Counties_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Addresses] FOREIGN KEY([address_id])
REFERENCES [dbo].[Addresses] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Counties] FOREIGN KEY([county_id])
REFERENCES [dbo].[Countries] ([ID])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Counties]
GO
USE [master]
GO
ALTER DATABASE [EarthDatabase] SET  READ_WRITE 
GO
