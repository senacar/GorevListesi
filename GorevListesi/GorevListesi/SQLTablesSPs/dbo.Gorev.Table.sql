USE [reminder]
GO
/****** Object:  Table [dbo].[Gorev]    Script Date: 2/28/2023 4:15:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gorev](
	[GorevID] [int] IDENTITY(1,1) NOT NULL,
	[GorevSahibi] [nvarchar](50) NOT NULL,
	[gorev] [nvarchar](200) NOT NULL,
	[musteri] [nvarchar](50) NOT NULL,
	[PlanlananBitis] [datetime] NOT NULL,
	[GercekBitis] [datetime] NULL,
	[GorevAktiflik] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Gorev] ADD  CONSTRAINT [DF_Gorev_GorevAktifligi]  DEFAULT ((1)) FOR [GorevAktiflik]
GO
