USE [ChallengeDevelopment]
GO
/****** Object:  Table [dbo].[User]    Script Date: 21/1/2021 22:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[NameUser] [varchar](50) NULL,
	[Password] [int] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IdUser], [NameUser], [Password], [Active]) VALUES (1, N'AmericanVirtual@gmail.com', 12345678, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
