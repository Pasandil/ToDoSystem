USE [ToDoListMaster]
GO

/****** Object:  Table [dbo].[TaskTable]    Script Date: 31/08/2023 14:27:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskTable]') AND type in (N'U'))
DROP TABLE [dbo].[TaskTable]
GO

/****** Object:  Table [dbo].[TaskTable]    Script Date: 31/08/2023 14:27:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaskTable](
	[ID] [bigint] NOT NULL,
	[Name] [nchar](50) NULL,
	[Description] [nchar](100) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Status] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_TaskTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


