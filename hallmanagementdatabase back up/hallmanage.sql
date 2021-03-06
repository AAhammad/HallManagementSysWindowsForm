USE [master]
GO
/****** Object:  Database [hallmanagement]    Script Date: 25-Oct-16 10:34:42 AM ******/
CREATE DATABASE [hallmanagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hallmanagement', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\hallmanagement.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hallmanagement_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\hallmanagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [hallmanagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hallmanagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hallmanagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hallmanagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hallmanagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hallmanagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hallmanagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [hallmanagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hallmanagement] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [hallmanagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hallmanagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hallmanagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hallmanagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hallmanagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hallmanagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hallmanagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hallmanagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hallmanagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hallmanagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hallmanagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hallmanagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hallmanagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hallmanagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hallmanagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hallmanagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hallmanagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hallmanagement] SET  MULTI_USER 
GO
ALTER DATABASE [hallmanagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hallmanagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hallmanagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hallmanagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [hallmanagement]
GO
/****** Object:  Table [dbo].[tbl_allot]    Script Date: 25-Oct-16 10:34:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_allot](
	[allot_id] [int] IDENTITY(1,1) NOT NULL,
	[allot_room_no] [int] NOT NULL,
	[stu_id] [int] NOT NULL,
	[in_date] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_allot] PRIMARY KEY CLUSTERED 
(
	[allot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_complain]    Script Date: 25-Oct-16 10:34:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_complain](
	[C_id] [int] IDENTITY(1,1) NOT NULL,
	[C_allot_id] [int] NOT NULL,
	[C_name] [nvarchar](100) NOT NULL,
	[C_roll] [nvarchar](50) NOT NULL,
	[C_mobile] [nvarchar](50) NULL,
	[C_date] [nvarchar](30) NOT NULL,
	[Complain] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_tbl_complain] PRIMARY KEY CLUSTERED 
(
	[C_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_login]    Script Date: 25-Oct-16 10:34:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_roomEntry]    Script Date: 25-Oct-16 10:34:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_roomEntry](
	[room_no] [int] NOT NULL,
	[block_no] [nvarchar](50) NOT NULL,
	[floor_no] [nvarchar](50) NOT NULL,
	[available_seat] [int] NOT NULL,
 CONSTRAINT [PK_tbl_roomEntry] PRIMARY KEY CLUSTERED 
(
	[room_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_student]    Script Date: 25-Oct-16 10:34:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_student](
	[stu_id] [int] IDENTITY(1,1) NOT NULL,
	[stu_name] [nvarchar](50) NOT NULL,
	[stu_father_name] [nvarchar](50) NOT NULL,
	[stu_mother_name] [nvarchar](50) NOT NULL,
	[stu_address] [nvarchar](250) NOT NULL,
	[stu_phone] [nvarchar](50) NULL,
	[stu_email] [nvarchar](50) NULL,
	[stu_dept] [nvarchar](50) NOT NULL,
	[stu_roll] [nvarchar](20) NOT NULL,
	[stu_CGPA] [decimal](18, 2) NOT NULL,
	[stu_session] [nvarchar](20) NOT NULL,
	[stu_blood] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_student] PRIMARY KEY CLUSTERED 
(
	[stu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_allot] ON 

INSERT [dbo].[tbl_allot] ([allot_id], [allot_room_no], [stu_id], [in_date]) VALUES (18, 125, 71, N'fdfsdf')
INSERT [dbo].[tbl_allot] ([allot_id], [allot_room_no], [stu_id], [in_date]) VALUES (19, 420, 74, N'4324324')
SET IDENTITY_INSERT [dbo].[tbl_allot] OFF
SET IDENTITY_INSERT [dbo].[tbl_complain] ON 

INSERT [dbo].[tbl_complain] ([C_id], [C_allot_id], [C_name], [C_roll], [C_mobile], [C_date], [Complain]) VALUES (5, 12, N'ali', N'ash1301024m', N'32542352', N'5235235', N'cxvsvsdv')
INSERT [dbo].[tbl_complain] ([C_id], [C_allot_id], [C_name], [C_roll], [C_mobile], [C_date], [Complain]) VALUES (6, 13, N'najmul', N'ash1301056m', N'43525542', N'52345345', N'vcxbxvx')
INSERT [dbo].[tbl_complain] ([C_id], [C_allot_id], [C_name], [C_roll], [C_mobile], [C_date], [Complain]) VALUES (7, 13, N'najmul', N'ash1301056m', N'43525542', N'52345345', N'vcxbxvx')
SET IDENTITY_INSERT [dbo].[tbl_complain] OFF
SET IDENTITY_INSERT [dbo].[tbl_login] ON 

INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (1, N'ali ahammad', N'ali')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (2, N'ali ahammad abeg', N'ali')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (3, N'abeg', N'ali')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (6, N'ali ahammad', N'aliddd')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (7, N'h', N'h')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (8, N'ali ', N'ali')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (9, N'aaa', N'aaa')
INSERT [dbo].[tbl_login] ([id], [username], [password]) VALUES (11, N' ', N' ')
SET IDENTITY_INSERT [dbo].[tbl_login] OFF
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (125, N'a', N'3', 4)
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (321, N'b', N'4', 4)
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (323, N'a', N'3', 4)
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (324, N'a', N'3', 4)
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (325, N'b', N'3', 4)
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (326, N'b', N'3', 4)
INSERT [dbo].[tbl_roomEntry] ([room_no], [block_no], [floor_no], [available_seat]) VALUES (420, N'b', N'4', 4)
SET IDENTITY_INSERT [dbo].[tbl_student] ON 

INSERT [dbo].[tbl_student] ([stu_id], [stu_name], [stu_father_name], [stu_mother_name], [stu_address], [stu_phone], [stu_email], [stu_dept], [stu_roll], [stu_CGPA], [stu_session], [stu_blood]) VALUES (69, N'ali', N'fasdf', N'sadasdff', N'dasfas', N'sadfa', N'sdaf', N'ACCE', N'ash1301024m', CAST(4.00 AS Decimal(18, 2)), N'2009-10', N'm')
INSERT [dbo].[tbl_student] ([stu_id], [stu_name], [stu_father_name], [stu_mother_name], [stu_address], [stu_phone], [stu_email], [stu_dept], [stu_roll], [stu_CGPA], [stu_session], [stu_blood]) VALUES (70, N'ahammad', N'fasdf', N'sadasdff', N'dasfas', N'sadfa', N'sdaf', N'ACCE', N'1301024m', CAST(3.00 AS Decimal(18, 2)), N'2009-10', N'm')
INSERT [dbo].[tbl_student] ([stu_id], [stu_name], [stu_father_name], [stu_mother_name], [stu_address], [stu_phone], [stu_email], [stu_dept], [stu_roll], [stu_CGPA], [stu_session], [stu_blood]) VALUES (72, N'najmul', N'fasdf', N'sadasdff', N'dasfas', N'sadfa', N'sdaf', N'ACCE', N'ash1301056m', CAST(8.00 AS Decimal(18, 2)), N'2009-10', N'm')
INSERT [dbo].[tbl_student] ([stu_id], [stu_name], [stu_father_name], [stu_mother_name], [stu_address], [stu_phone], [stu_email], [stu_dept], [stu_roll], [stu_CGPA], [stu_session], [stu_blood]) VALUES (73, N'fads', N'fasdf', N'sadasdff', N'dasfas', N'sadfa', N'sdaf', N'ACCE', N'fsdaf', CAST(8.00 AS Decimal(18, 2)), N'2009-10', N'm')
SET IDENTITY_INSERT [dbo].[tbl_student] OFF
USE [master]
GO
ALTER DATABASE [hallmanagement] SET  READ_WRITE 
GO
