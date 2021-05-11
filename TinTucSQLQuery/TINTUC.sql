USE [TinTuc]
GO

/****** Object:  Table [dbo].[TINTUC]    Script Date: 04/25/2021 21:40:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TINTUC](
	[MaTinTuc] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](200) NULL,
	[MoTa] [nvarchar](200) NULL,
	[File_Link] [nvarchar](max) NULL,
	[Hinh_Link] [nvarchar](max) NULL,
	[TacGia] [nvarchar](50) NULL,
	[Ngay_TinTuc] [date] NULL,
	[MaTheLoai] [nvarchar](50) NULL,
	[MaLoaiTin] [nvarchar](50) NULL,
 CONSTRAINT [PK_TINTUC] PRIMARY KEY CLUSTERED 
(
	[MaTinTuc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[TINTUC]  WITH CHECK ADD  CONSTRAINT [FK_TINTUC_LOAITIN] FOREIGN KEY([MaLoaiTin])
REFERENCES [dbo].[LOAITIN] ([MaLoaiTin])
GO

ALTER TABLE [dbo].[TINTUC] CHECK CONSTRAINT [FK_TINTUC_LOAITIN]
GO

ALTER TABLE [dbo].[TINTUC]  WITH CHECK ADD  CONSTRAINT [FK_TINTUC_THELOAI] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO

ALTER TABLE [dbo].[TINTUC] CHECK CONSTRAINT [FK_TINTUC_THELOAI]
GO

