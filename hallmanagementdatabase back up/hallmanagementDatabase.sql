USE [hallmanagement]
GO
/****** Object:  Table [dbo].[tbl_allot]    Script Date: 30-Jul-16 7:10:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_allot](
	[allot_id] [int] IDENTITY(1,1) NOT NULL,
	[allot_room_no] [int] NOT NULL,
	[student_id] [int] NOT NULL,
	[in_date] [varchar](25) NOT NULL,
 CONSTRAINT [PK_tbl_allot] PRIMARY KEY CLUSTERED 
(
	[allot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_complain]    Script Date: 30-Jul-16 7:10:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_complain](
	[C_id] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[tbl_login]    Script Date: 30-Jul-16 7:10:12 AM ******/
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
/****** Object:  Table [dbo].[tbl_roomEntry]    Script Date: 30-Jul-16 7:10:12 AM ******/
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
/****** Object:  Table [dbo].[tbl_student]    Script Date: 30-Jul-16 7:10:12 AM ******/
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
