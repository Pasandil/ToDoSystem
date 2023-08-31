USE [ToDoListMaster]
GO

/****** Object:  Table [dbo].[ToDoListTable]    Script Date: 31/08/2023 14:28:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ToDoListTable]') AND type in (N'U'))
DROP TABLE [dbo].[ToDoListTable]
GO

/****** Object:  Table [dbo].[ToDoListTable]    Script Date: 31/08/2023 14:28:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ToDoListTable](
	[ID] [bigint] NOT NULL,
	[Name] [nchar](50) NULL,
	[Description] [nchar](100) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_ToDoListTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


