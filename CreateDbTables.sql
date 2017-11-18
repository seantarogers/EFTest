USE [EFTest]
GO

/****** Object:  Table [dbo].[Session]    Script Date: 11/16/2017 9:37:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Session](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuotingName] [nvarchar](50) NULL,
	[BackOfficeName] [nvarchar](50) NULL,
	[SessionType] [int] NOT NULL,
 CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[Policy]    Script Date: 11/16/2017 9:37:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Policy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SessionId] [int] NOT NULL,
	[QuotingPolicyName] [nvarchar](50) NULL,
	[BackOfficePolicyName] [nvarchar](50) NULL,
	[SessionType] [int] NOT NULL,
 CONSTRAINT [PK_Policy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Policy]  WITH CHECK ADD  CONSTRAINT [FK_Policy_Session] FOREIGN KEY([SessionId])
REFERENCES [dbo].[Session] ([Id])
GO

ALTER TABLE [dbo].[Policy] CHECK CONSTRAINT [FK_Policy_Session]
GO

