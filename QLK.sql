USE [QLK]
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[SOPN] [int] NULL,
	[MAHH] [int] NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUXUAT]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUXUAT](
	[SOPX] [int] NULL,
	[MAHH] [int] NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MAHH] [int] IDENTITY(1,1) NOT NULL,
	[TENHH] [nvarchar](50) NULL,
	[SLTONKHO] [int] NULL,
	[GIA] [float] NULL,
	[DONVI] [char](10) NULL,
	[MALHH] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[MASOTHUE] [varchar](20) NULL,
	[EMAIL] [varchar](50) NULL,
	[FAX] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIHH]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIHH](
	[MALHH] [char](20) NOT NULL,
	[TENLHH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[MASOTHUE] [varchar](20) NULL,
	[EMAIL] [varchar](50) NULL,
	[FAX] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[QUEQUAN] [nvarchar](50) NULL,
	[GIOITINH] [bit] NULL,
	[HSLUONG] [float] NULL,
	[USERNAME] [char](20) NULL,
	[TYPEOF] [int] NULL,
	[PASS] [char](20) NULL,
	[SDT] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[SOPN] [int] IDENTITY(1,1) NOT NULL,
	[NGAYNHAP] [datetime] NULL,
	[MANCC] [int] NULL,
	[NGUOIGIAO] [nvarchar](50) NULL,
	[MANV] [int] NULL,
	[TONGTIEN] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SOPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[SOPX] [int] IDENTITY(1,1) NOT NULL,
	[NGAYXUAT] [datetime] NULL,
	[MAKH] [int] NULL,
	[NGUOINHAN] [nvarchar](50) NULL,
	[MANV] [int] NULL,
	[TONGTIEN] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SOPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (1, 8, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (1, 9, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (2, 10, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (2, 11, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (2, 12, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (3, 4, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (3, 5, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (4, 6, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (4, 7, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (5, 1, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (5, 2, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (5, 3, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (50, 1, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (50, 3, 1, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (50, 1, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (50, 3, 1, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (50, 1, 5, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([SOPN], [MAHH], [SOLUONG], [DONGIA]) VALUES (50, 3, 1, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (1, 4, 10, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (1, 5, 10, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (2, 1, 5, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (2, 2, 1, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (2, 3, 5, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (3, 8, 4, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (3, 9, 6, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (4, 6, 15, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (4, 7, 7, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (5, 10, 5, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (5, 12, 1, NULL)
INSERT [dbo].[CT_PHIEUXUAT] ([SOPX], [MAHH], [SOLUONG], [DONGIA]) VALUES (5, 4, 3, NULL)
SET IDENTITY_INSERT [dbo].[HANGHOA] ON 

INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (1, N'TIÊU ĐEN', 20, 50000, N'DONG/KG   ', N'TIEU                ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (2, N'TIÊU SỌ', 10, 50000, N'DONG/KG   ', N'TIEU                ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (3, N'TIÊU XANH', 10, 50000, N'DONG/KG   ', N'TIEU                ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (4, N'CÀ PHÊ ROBUSTA', 20, 50000, N'DONG/KG   ', N'CAPHE               ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (5, N'CÀ PHÊ ARABICA', 50, 50000, N'DONG/KG   ', N'CAPHE               ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (6, N'CÀ PHÊ CHERRY', 40, 50000, N'DONG/KG   ', N'CAPHE               ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (7, N'CÀ PHÊ CULI', 40, 50000, N'DONG/KG   ', N'CAPHE               ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (8, N'ĐẬU PHỘNG', 15, 30000, N'DONG/KG   ', N'HATDINHDUONG        ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (9, N'HẠT DẺ', 20, 50000, N'DONG/KG   ', N'HATDINHDUONG        ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (10, N'HẠT HẠNH NHÂN', 17, 50000, N'DONG/KG   ', N'HATDINHDUONG        ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (11, N'HẠT ÓC CHÓ', 15, 50000, N'DONG/KG   ', N'HATDINHDUONG        ')
INSERT [dbo].[HANGHOA] ([MAHH], [TENHH], [SLTONKHO], [GIA], [DONVI], [MALHH]) VALUES (12, N'HẠT THÔNG', 10, 50000, N'DONG/KG   ', N'HATDINHDUONG        ')
SET IDENTITY_INSERT [dbo].[HANGHOA] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (1, N'QUÁN CÀ PHÊ DINGDONG', N'DAKLAK', N'01691234565', N'7777799999', N'CPDINGDONG@GMAIL.COM', N'77545599')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (2, N'NHÀ HÀNG BUÔN MÊ THUỘT', N'DAKLAK', N'01691234566', N'7000000009', N'NHAHANGBMT@GMAIL.COM', N'72334549')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (3, N'NHÀ HÀNG ISUM', N'GIALAI', N'01691234567', N'7111111119', N'CPISUM@GMAIL.COM', N'74346889')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (4, N'QUÁN CÀ PHÊ MÈO', N'DAKLAK', N'01691234568', N'7222222229', N'CPMEO@GMAIL.COM', N'72222229')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (5, N'TIỆM BÁNH OEN', N'GIALAI', N'01691234569', N'7555555559', N'CPOEN@GMAIL.COM', N'71223239')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
INSERT [dbo].[LOAIHH] ([MALHH], [TENLHH]) VALUES (N'CAPHE               ', N'CÀ PHÊ')
INSERT [dbo].[LOAIHH] ([MALHH], [TENLHH]) VALUES (N'HATDINHDUONG        ', N'HẠT DINH DƯỠNG')
INSERT [dbo].[LOAIHH] ([MALHH], [TENLHH]) VALUES (N'TIEU                ', N'TIÊU')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (1, N'NÔNG TRẠI HẠT DD', N'GIALAI', N'01691234567', N'77779977', N'HATHOAPHAT@GMAIL.COM', N'7777799998')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (2, N'NÔNG TRẠI THUẬN AN', N'DAKLAK', N'01265790009', N'7000000009', N'HTXTHUANAN@GMAIL.COM', N'34665322')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (3, N'NÔNG TRẠI CÀ PHÊ BUÔN HỒ', N'DAKLAK', N'07123456789', N'7545666479', N'CAPHEBH@GMAIL.COM', N'34655679')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (4, N'NÔNG TRẠI XANH DK', N'DAKLAK', N'01659704012', N'7578855329', N'NONGTRAIX@GMAIL.COM', N'75778784')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [MASOTHUE], [EMAIL], [FAX]) VALUES (5, N'NÔNG TRẠI HẠT KT', N'KONTUM', N'01659704019', N'7499090942', N'NTHATKT@GMAIL.COM', N'72579909')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (1, N'LÊ THỊ MAI', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'NAM ĐỊNH', 0, 7.1999998092651367, N'MAI                 ', 0, N'0                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (2, N'LÊ THỊ THẢO', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'NGHE AN', 0, 7.2, N'THAO                ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (3, N'ĐINH THỊ PHƯƠNG', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'LÂM ĐỒNG', 0, 7.2, N'PHUONG              ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (4, N'MAI THỊ HẰNG', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'THANH HÓA', 0, 7.2, N'HANG                ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (5, N'HÀ VIỆT HÙNG', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'THÁI BÌNH', 1, 5.5, N'HUNG                ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (6, N'LƯU HỮU THÁI', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'THANH HÓA', 1, 5.5, N'THAI                ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (7, N'LÊ THỊ THANH', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'BẮC GIANG', 1, 5.5, N'THANH               ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (8, N'TRẦN VĂN TUẤN', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'THANH HÓA', 1, 5.5, N'TUAN                ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (9, N'TRẦN CÔNG LUẬN', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'NINH BÌNH', 1, 5.5, N'LUAN                ', 1, N'1                   ', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [QUEQUAN], [GIOITINH], [HSLUONG], [USERNAME], [TYPEOF], [PASS], [SDT]) VALUES (10, N'NGUYỄN THÁI HỌC', CAST(N'1905-06-19 00:00:00.000' AS DateTime), N'HÀ NAM', 1, 5.5, N'HOC                 ', 1, N'1                   ', NULL)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([SOPN], [NGAYNHAP], [MANCC], [NGUOIGIAO], [MANV], [TONGTIEN]) VALUES (1, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 1, N'Bùi Anh Quân', 1, 15000000)
INSERT [dbo].[PHIEUNHAP] ([SOPN], [NGAYNHAP], [MANCC], [NGUOIGIAO], [MANV], [TONGTIEN]) VALUES (2, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 2, N'Nguyễn Danh Minh', 2, 15000000)
INSERT [dbo].[PHIEUNHAP] ([SOPN], [NGAYNHAP], [MANCC], [NGUOIGIAO], [MANV], [TONGTIEN]) VALUES (3, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 3, N'Đắc Tùng Dương', 3, 15000000)
INSERT [dbo].[PHIEUNHAP] ([SOPN], [NGAYNHAP], [MANCC], [NGUOIGIAO], [MANV], [TONGTIEN]) VALUES (4, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 4, N'Cao Minh Hiền', 4, 15000000)
INSERT [dbo].[PHIEUNHAP] ([SOPN], [NGAYNHAP], [MANCC], [NGUOIGIAO], [MANV], [TONGTIEN]) VALUES (5, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 5, N'Điêu Diễm Quỳnh', 5, 15000000)
INSERT [dbo].[PHIEUNHAP] ([SOPN], [NGAYNHAP], [MANCC], [NGUOIGIAO], [MANV], [TONGTIEN]) VALUES (50, CAST(N'2018-09-10 15:31:50.553' AS DateTime), 5, NULL, 5, 300000)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUXUAT] ON 

INSERT [dbo].[PHIEUXUAT] ([SOPX], [NGAYXUAT], [MAKH], [NGUOINHAN], [MANV], [TONGTIEN]) VALUES (1, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 1, N'Bùi Anh Quân', 6, 15000000)
INSERT [dbo].[PHIEUXUAT] ([SOPX], [NGAYXUAT], [MAKH], [NGUOINHAN], [MANV], [TONGTIEN]) VALUES (2, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 2, N'Nguyễn Danh Minh', 7, 15000000)
INSERT [dbo].[PHIEUXUAT] ([SOPX], [NGAYXUAT], [MAKH], [NGUOINHAN], [MANV], [TONGTIEN]) VALUES (3, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 3, N'Đắc Tùng Dương', 8, 15000000)
INSERT [dbo].[PHIEUXUAT] ([SOPX], [NGAYXUAT], [MAKH], [NGUOINHAN], [MANV], [TONGTIEN]) VALUES (4, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 4, N'Cao Minh Hiền', 9, 15000000)
INSERT [dbo].[PHIEUXUAT] ([SOPX], [NGAYXUAT], [MAKH], [NGUOINHAN], [MANV], [TONGTIEN]) VALUES (5, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 5, N'Điêu Diễm Quỳnh', 10, 15000000)
INSERT [dbo].[PHIEUXUAT] ([SOPX], [NGAYXUAT], [MAKH], [NGUOINHAN], [MANV], [TONGTIEN]) VALUES (12, CAST(N'2018-09-10 16:46:18.173' AS DateTime), 1, NULL, 5, 300000)
SET IDENTITY_INSERT [dbo].[PHIEUXUAT] OFF
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([SOPN])
REFERENCES [dbo].[PHIEUNHAP] ([SOPN])
GO
ALTER TABLE [dbo].[CT_PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
GO
ALTER TABLE [dbo].[CT_PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([SOPX])
REFERENCES [dbo].[PHIEUNHAP] ([SOPN])
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD FOREIGN KEY([MALHH])
REFERENCES [dbo].[LOAIHH] ([MALHH])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
/****** Object:  StoredProcedure [dbo].[SP_ChangeAcountInfo]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ChangeAcountInfo]( @id INT, @dateOfBirth DATETIME, @sex BIT, @userName CHAR(20), @country NVARCHAR(50), @telephonNunber CHAR(20))
AS
BEGIN
	UPDATE NHANVIEN
	SET NGAYSINH=@dateOfBirth, GIOITINH=@sex, USERNAME=@userName, QUEQUAN=@country, SDT=@telephonNunber
	WHERE MANV=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChangePass]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ChangePass](@ID INT, @NEWPASS CHAR(20))
AS
BEGIN
	UPDATE NHANVIEN
	SET PASS = @NEWPASS
	WHERE MANV = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_deleteBill]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_deleteBill](@billId INT)
as
begin
	delete PHIEUXUAT where SOPX=@billId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_deleteBillIn]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_deleteBillIn](@billId INT)
as
begin
	delete PHIEUNHAP where SOPN=@billId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteEmployees]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DeleteEmployees](@EmployeesID int )
as
begin
	delete nhanvien
	where manv=@EmployeesID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSupplier]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DeleteSupplier](@SupplierName nvarchar(50))
as
begin
	DELETE NHACUNGCAP WHERE TENNCC = @SupplierName
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getBillDetail]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getBillDetail](@id INT)
AS
BEGIN
	select HH.MAHH as 'Mã mặt hàng', HH.TENHH as 'Tên mặt hàng',  GIA as 'Giá hàng', ct.SOLUONG as 'Số lượng', ( GIA * SOLUONG) as 'Tổng' 
	from CT_PHIEUXUAT ct, PHIEUXUAT PX, HANGHOA as Hh 
	where ct.SOPX=PX.SOPX and HH.MAHH=ct.MAHH and ct.SOPX=@id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getBillInDetail]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getBillInDetail](@id INT)
AS
BEGIN
	select HH.MAHH as 'Mã hàng', HH.TENHH as 'Tên',  GIA as 'Giá', ct.SOLUONG as 'Số lượng', ( GIA * SOLUONG) as 'Tổng' 
	from CT_PHIEUNHAP ct, PHIEUNHAP PN, HANGHOA as Hh 
	where ct.SOPN=PN.SOPN and HH.MAHH=ct.MAHH and ct.SOPN=@id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getCustomer]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getCustomer]
as 
begin
	select MAKH as N'Mã khách hàng', TENKH as N'Tên khách hàng', DIACHI AS N'địa chỉ',SDT AS N'Số điện thoại',MASOTHUE AS N'Mã số thuế', EMAIL AS N'Email',FAX AS N'Fax'
	FROM KHACHHANG
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getCustomerByIdCus]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_getCustomerByIdCus](@id INT)
as 
begin
	select MAKH as 'Mã khách hàng', TENKH as 'Tên khách hàng'
	 from KHACHHANG
	  where MAKH=@id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEmployees]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetEmployees]
AS
	BEGIN
	SELECT MANV AS N'Mã', PASS as'Pass', TENNV AS N'Tên',NGAYSINH AS N'Ngày sinh', HSLUONG AS N'HS lương', Case GIOITINH when 1 then'Nam' else N'Nữ' end  as 'Giới tính', USERNAME AS N'UserName', QUEQUAN AS N'Quê quán', SDT as 'Số điện thoại' 
	from NHANVIEN 
	 
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetInfoByUsername]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetInfoByUsername](@USERNAME CHAR(20), @PASS CHAR(20))
AS
	BEGIN
	SELECT MANV AS N'Mã', PASS as'Pass', TENNV AS N'Tên', USERNAME as N'UserName', TYPEOF as 'Loại nhân viên' 
	FROM NHANVIEN
	WHERE USERNAME=@USERNAME AND PASS=@PASS
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_getItem]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getItem]
as
begin
	SELECT MAHH as N'Mã', TENHH as N'Tên', GIA as 'Giá', SLTONKHO as N'Tồn kho', DONVI as N'Đơn vị' 
	FROM HANGHOA
END

GO
/****** Object:  StoredProcedure [dbo].[SP_getItemByIdItem]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getItemByIdItem](@ID INT)
as
begin
	SELECT MAHH as N'Mã', TENHH as N'Tên', GIA as N'Giá hàng', SLTONKHO as N'Tồn kho', DONVI as N'Đơn vị'
	FROM HANGHOA
	where MAHH=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getItemByName]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_getItemByName](@name nvarchar(50))
as
begin
	SELECT MAHH as N'Mã', TENHH as N'Tên', GIA as 'Giá ', SLTONKHO as N'Tồn kho', DONVI as N'Đơn vị'
	FROM HANGHOA
	where TENHH=@name
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getItemForBuy]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_getItemForBuy]
as
begin
	select TENHH AS 'TENHH' from HANGHOA HH where   HH.SLTONKHO<15
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getListBill]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getListBill]
as
begin
	select SOPX as'Số phiếu xuất', NGAYXUAT as 'Ngày xuất',NGUOINHAN AS 'Người nhận', PX.TONGTIEN as 'Tổng tiền', PX.MANV as 'Mã nhân viên', nv.TENNV as 'Tên nhân viên', PX.MAKH as 'Mã khách hàng', kh.TENKH as 'Tên khách hàng'
	from PHIEUXUAT PX,  NHANVIEN nv, KHACHHANG kh 
	where PX.MANV=NV.MANV and PX.MAKH=kh.MAKH  
	order by  NGAYXUAT DESC
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getListBillIn]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getListBillIn]
as
begin
	select SOPN as'Số phiếu nhập', NGAYNHAP as 'Ngày nhập',NGUOIGIAO AS 'Người giao', PN.TONGTIEN as 'Tổng tiền', PN.MANV as 'Mã nhân viên', nv.TENNV as 'Tên nhân viên', PN.MANCC as 'Mã nhà cung cấp', NCC.TENNCC as 'Tên nhà cung cấp'
	from PHIEUNHAP PN,  NHANVIEN nv, NHACUNGCAP NCC 
	where PN.MANV=NV.MANV and PN.MANCC=NCC.MANCC  
	order by  NGAYNHAP DESC
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getMaxBillForEmp]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_getMaxBillForEmp](@employeesId INT)
as
begin
	select MAX(SOPX) as'Số hóa đơn MAX' from PHIEUXUAT PX,  NHANVIEN NV where PX.MANV=NV.MANV and  NV.MANV=@employeesId 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getMaxBillInForEmp]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_getMaxBillInForEmp](@employeesId INT)
as
begin
	select MAX(SOPN) as'Số hóa đơn MAX' from PHIEUNHAP PN,  NHANVIEN NV where PN.MANV=NV.MANV and  NV.MANV=@employeesId 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getMaxStored]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_getMaxStored]
as
begin
	select top 1 TENHH from HANGHOA HH where  HH.SLTONKHO=(select MAX(SLTONKHO) from HANGHOA)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getMinStored]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_getMinStored]
as
begin
	select top 1 TENHH from HANGHOA HH where  HH.SLTONKHO=(select MIN(SLTONKHO) from HANGHOA)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_getSupplier]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getSupplier]
as
begin
	SELECT MANCC as N'Mã', TENNCC as N'Tên', DIACHI AS N'Địa chỉ',SDT AS N'Số điện thoại',MASOTHUE AS N'Mã số thuế', EMAIL AS N'Email',FAX AS N'Fax'
	FROM NHACUNGCAP
END

GO
/****** Object:  StoredProcedure [dbo].[SP_getSupplierByIdSup]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getSupplierByIdSup](@id int)
as
begin
	SELECT MANCC as N'Mã', TENNCC as N'Tên', DIACHI AS N'Địa chỉ',SDT AS N'Số điện thoại',MASOTHUE AS N'Mã số thuế', EMAIL AS N'Email',FAX AS N'Fax'
	FROM NHACUNGCAP
	where MANCC=@id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getSupplierByName]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_getSupplierByName](@name NVARCHAR(50))
AS
BEGIN
	SELECT MANCC as N'Mã', TENNCC as N'Tên'
	FROM NHACUNGCAP
	where TENNCC=@name
END
GO
/****** Object:  StoredProcedure [dbo].[SP_getTotalPriceStored]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_getTotalPriceStored]
as
begin
	select SUM(GIA*SLTONKHO) as 'Total' from HANGHOA 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_insertBill]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_insertBill](@employeesId int, @customerId int, @totalPrice int)
as
begin
	insert into PHIEUXUAT(MANV,MAKH,TONGTIEN) values
	(
		 @employeesId,@customerId, @totalPrice
	)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_insertBillDetail]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_insertBillDetail](@itemId INT, @billId INT, @numOfItem int)
as
begin
	insert into CT_PHIEUXUAT(MAHH,SOPX,SOLUONG) values
	(
		@itemId, @billId, @numOfItem
	)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_insertBillIn]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_insertBillIn](@employeesId int, @SupplierId int, @totalPrice int)
as
begin
	insert into PHIEUNHAP(MANV,MANCC,TONGTIEN) values
	(
		 @employeesId,@SupplierId, @totalPrice
	)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_insertBillInDetail]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_insertBillInDetail](@itemId INT, @billId INT, @numOfItem int)
as
begin
	insert into CT_PHIEUNHAP(MAHH,SOPN,SOLUONG) values
	(
		@itemId, @billId, @numOfItem
	)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertEmployees]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[SP_InsertEmployees] (@EmployeesName nvarchar(50),@UserName char(20),@Phone char(20),@Country nvarchar(50),@DateOfBirth datetime,@Salary float)
AS
BEGIN
	INSERT INTO NHANVIEN(TENNV,USERNAME,SDT,QUEQUAN,NGAYSINH,HSLUONG)
	VALUES (@EmployeesName,@UserName,@Phone,@Country,@DateOfBirth,@Salary)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertItem]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_InsertItem](@itemName nvarchar(50), @numberOfStored int, @once char(10), @price float)
as
begin
INSERT INTO HANGHOA(TENHH,SLTONKHO,DONVI,GIA) VALUES
(@itemName , @numberOfStored , @once , @price)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSupplier]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_InsertSupplier](@SupplierName nvarchar(50), @Address nvarchar(50), @Phone varchar(20), @Fax varchar(20), @Email varchar(50), @Tax_Ident_Num varchar(20))
as
begin
	insert into NHACUNGCAP(TENNCC,DIACHI,SDT,FAX,EMAIL,MASOTHUE)
	VALUES (@SupplierName, @Address, @Phone, @Fax, @Email, @Tax_Ident_Num)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SP_getItemByName]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SP_getItemByName](@name nvarchar(50))
as
begin
	SELECT MAHH as N'Mã', TENHH as N'Tên', GIA as 'Giá ', SLTONKHO as N'Tồn kho', DONVI as N'Đơn vị'
	FROM HANGHOA
	where TENHH=@name
END
GO
/****** Object:  StoredProcedure [dbo].[SP_updateBill]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_updateBill](@billId INT, @totalPrice int )
as
begin
	update PHIEUXUAT set TONGTIEN=@totalPrice, NGAYXUAT=getdate() where SOPX=@billId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_updateBillIn]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_updateBillIn](@billId INT, @totalPrice int )
as
begin
	update PHIEUNHAP set TONGTIEN=@totalPrice, NGAYNHAP=getdate() where SOPN=@billId
end
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateEmployees]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UpdateEmployees](@EmployeesID int,@Salary float)
as
BEGIN
	UPDATE NHANVIEN
	SET HSLUONG = @Salary
	WHERE MANV = @EmployeesID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_updateItem]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_updateItem] (@itemName nvarchar(50), @numberOfStored int)
AS
BEGIN
	UPDATE HANGHOA 
	SET SLTONKHO = SLTONKHO + @numberOfStored
	WHERE TENHH = @itemName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSupplier]    Script Date: 11/28/2019 10:43:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UpdateSupplier](@SupplierName nvarchar(50), @Address nvarchar(50), @Phone varchar(20), @Fax varchar(20), @Email varchar(50), @Tax_Ident_Num varchar(20))
as
begin
	UPDATE NHACUNGCAP
	SET DIACHI = @Address , SDT = @Phone , FAX = @Fax , EMAIL = @Email , MASOTHUE = @Tax_Ident_Num
	WHERE TENNCC=@SupplierName
END
GO
