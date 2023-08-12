USE [master]
WHILE EXISTS(select NULL from sys.databases where name = 'LibrarySystemManagement' )
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';' FROM MASTER..SysProcesses WHERE DBId = DB_ID('LibrarySystemManagement') AND SPId <> @@SPId
    EXEC(@SQL)
    EXEC('DROP DATABASE LibrarySystemManagement')
END
EXEC('CREATE DATABASE LibrarySystemManagement')
GO
USE [LibrarySystemManagement]
GO
/****** Object:  Table [dbo].[tblBook]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBook](
	[BookID] [varchar](7) NOT NULL,
	[ISBN] [varchar](6) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK__tblBook__C220CF9C6067927C] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBookInfo]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBookInfo](
	[ISBN] [varchar](6) NOT NULL,
	[CategoryID] [bigint] NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Author] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[BookingPeriod] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[BookIDPrefix] [varchar](3) NOT NULL,
 CONSTRAINT [PK_tblBookInfo] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBorrow]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBorrow](
	[BookingID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[BookingDay] [datetime] NOT NULL,
 CONSTRAINT [PK__tblBooki__35AAE1F800ED2242] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBorrowDetail]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBorrowDetail](
	[BookingID] [bigint] NOT NULL,
	[BookID] [varchar](7) NOT NULL,
	[ExpiredDay] [datetime] NOT NULL,
	[ReturnDay] [datetime] NULL,
	[Fine] [float] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_tblBorrowDetail] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC,
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CategoryID] [bigint] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__tblCateg__6DB28136FE86000C] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRole](
	[RoleID] [bigint] NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
 CONSTRAINT [PK__tblRole__D80BB0931347DF2B] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 11/08/2023 17:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [bigint] NOT NULL,
	[RoleID] [bigint] NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](12) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[DoB] [datetime] NULL,
	[Gender] [nvarchar](5) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK__tblUser__206A9DF84FA32B01] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblBook]  WITH CHECK ADD  CONSTRAINT [FK_tblBook_tblBookInfo] FOREIGN KEY([ISBN])
REFERENCES [dbo].[tblBookInfo] ([ISBN])
GO
ALTER TABLE [dbo].[tblBook] CHECK CONSTRAINT [FK_tblBook_tblBookInfo]
GO
ALTER TABLE [dbo].[tblBookInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblBookInfo_tblCategory] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[tblBookInfo] CHECK CONSTRAINT [FK_tblBookInfo_tblCategory]
GO
ALTER TABLE [dbo].[tblBorrow]  WITH CHECK ADD  CONSTRAINT [FK_tblBooking_tblUser] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUser] ([UserID])
GO
ALTER TABLE [dbo].[tblBorrow] CHECK CONSTRAINT [FK_tblBooking_tblUser]
GO
ALTER TABLE [dbo].[tblBorrowDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblBorrowDetail_tblBook] FOREIGN KEY([BookID])
REFERENCES [dbo].[tblBook] ([BookID])
GO
ALTER TABLE [dbo].[tblBorrowDetail] CHECK CONSTRAINT [FK_tblBorrowDetail_tblBook]
GO
ALTER TABLE [dbo].[tblBorrowDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblBorrowDetail_tblBorrow] FOREIGN KEY([BookingID])
REFERENCES [dbo].[tblBorrow] ([BookingID])
GO
ALTER TABLE [dbo].[tblBorrowDetail] CHECK CONSTRAINT [FK_tblBorrowDetail_tblBorrow]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK__tblUser__Role_id__4BAC3F29] FOREIGN KEY([RoleID])
REFERENCES [dbo].[tblRole] ([RoleID])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK__tblUser__Role_id__4BAC3F29]
GO

