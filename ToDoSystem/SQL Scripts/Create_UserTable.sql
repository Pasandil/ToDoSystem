USE [ToDoListMaster]
GO

/****** Object:  Table [dbo].[UserTable]    Script Date: 31/08/2023 14:28:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserTable]') AND type in (N'U'))
DROP TABLE [dbo].[UserTable]
GO

/****** Object:  Table [dbo].[UserTable]    Script Date: 31/08/2023 14:28:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserTable](
	[ID] [bigint] NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NOT NULL,
	[Gender] [int] NOT NULL,
	[Email] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


