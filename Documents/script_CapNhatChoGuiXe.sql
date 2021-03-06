CREATE DATABASE [QLBaiDoXe]
GO
USE [QLBaiDoXe]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [char](10) NOT NULL,
	[TenCV] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaVe]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaVe](
	[MaGiaVe] [char](10) NOT NULL,
	[TenGiaVe] [nvarchar](30) NULL,
	[GiaTien] [float] NULL,
	[MaLoaiXe] [char](10) NULL,
	[GioToiThieu] [int] NULL,
	[GioToiDa] [int] NULL,
	[UuDai] [int] NULL,
	[VeThang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[CMND] [char](20) NULL,
	[SDT] [char](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayHetHanVeThang] [datetime] NULL,
	[MaXe] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[MaLoaiXe] [char](10) NOT NULL,
	[TenLoaiXe] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[CMND] [char](20) NULL,
	[SDT] [char](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaCV] [char](10) NULL,
	[Luong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuThanhToan]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuThanhToan](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaXe] [char](10) NULL,
	[GioVao] [datetime] NULL,
	[GioRa] [datetime] NULL,
	[TienThu] [float] NULL,
	[TraTheoThang] [bit] NULL,
	[MaNV] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [char](30) NOT NULL,
	[MatKhau] [char](30) NULL,
	[MaNV] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheGuiXe]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheGuiXe](
	[MaTheGuiXe] [char](10) NOT NULL,
	[MaXe] [char](10) NULL,
	[GioVao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheGuiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ViTri]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ViTri](
	[MaViTri] [char](10) NOT NULL,
	[TenViTri] [nvarchar](30) NULL,
	[MaXe] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [char](10) NOT NULL,
	[BienSo] [char](20) NULL,
	[TenXe] [nvarchar](30) NULL,
	[MauSac] [nvarchar](20) NULL,
	[MaLoaiXe] [char](10) NULL,
	[DangKyThang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV01      ', N'Người quản lý')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV02      ', N'Nhân viên giữ xe')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV01      ', N'Vé gửi xe máy L1', 5000, N'LXM       ', 0, 4, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV02      ', N'Vé gửi xe máy L2', 8000, N'LXM       ', 4, 8, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV03      ', N'Vé gửi xe ô tô L1', 10000, N'LXO       ', 0, 4, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV04      ', N'Vé gửi xe ô tô L2', 15000, N'LXO       ', 4, 8, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV05      ', N'Vé 1 Tháng xe máy', 120000, N'LXM       ', 0, 0, 0, 1)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV06      ', N'Vé tháng ô tô', 250000, N'LXO       ', 0, 0, 0, 1)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV07      ', N'Vé 6 tháng', 720000, N'LXM       ', 0, 0, 10, 1)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV11      ', N'Vé ô tô L3', 25000, N'LXO       ', 8, 24, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang]) VALUES (N'GV13      ', N'Vé gửi xe máy L3', 15000, N'LXM       ', 8, 24, 0, 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH01      ', N'Sơn Tùng', CAST(N'1990-01-02' AS Date), N'Nam', NULL, NULL, N'35 Cầu Giấy Hà Nội', CAST(N'2021-05-08 00:00:00.000' AS DateTime), N'MX01      ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH02      ', N'Bảo Trâm', CAST(N'1995-01-20' AS Date), N'Nữ', NULL, NULL, N'2 Võ Văn Ngân', CAST(N'2021-06-08 00:00:00.000' AS DateTime), N'MX02      ')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'LXM       ', N'Xe máy')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'LXO       ', N'Xe ô tô')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'Ihaveyou  ', N'Tien', CAST(N'2021-04-28' AS Date), N'Nam', N'                    ', N'               ', N'', N'CV02      ', 9000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'KK01      ', N'T', CAST(N'2003-05-01' AS Date), N'Nam', N'1233                ', N'33221          ', N'T', N'CV02      ', 200)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'MN02      ', N'TienvaCHanh', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV01      ', N'Nguyễn Quốc Tiến', CAST(N'2000-03-24' AS Date), N'Nam', NULL, N'0982427541     ', N'36C/41 Đường 16', N'CV01      ', 10000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV02      ', N'Nguyễn Như Bảo Phương', CAST(N'2000-02-20' AS Date), N'Nữ', NULL, N'0908527066     ', N'ở đường Lam Sơn', N'CV02      ', 9000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV03      ', N'Hoàng Minh Quang', CAST(N'2000-12-26' AS Date), N'Nam', NULL, N'0363084288     ', N'01 Võ Văn Ngân', N'CV02      ', 8000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV04      ', N'Nguyễn Đức Chánh', CAST(N'2000-03-10' AS Date), N'Nam', N'13                  ', N'0975724427     ', N'01 Võ Văn Ngân', N'CV02      ', 8000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV09      ', N'phuong', NULL, NULL, NULL, NULL, NULL, N'CV02      ', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV15      ', N'Rota', CAST(N'2021-04-15' AS Date), N'Nam', N'1                   ', N'1              ', N'1', N'CV02      ', 9000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV99      ', N'Tienp', CAST(N'2021-04-14' AS Date), N'Nam', N'888                 ', N'092            ', N'92 pnl', N'CV02      ', 6000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'T1        ', N'T1', CAST(N'2021-04-21' AS Date), N'Nam', N'1                   ', N'1              ', N'1', N'CV02      ', 1111)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'T2        ', N'T2', CAST(N'2021-04-22' AS Date), N'Nam', N'1                   ', N'1              ', N'1', N'CV02      ', 2222)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'T3        ', N'T3', CAST(N'2021-04-22' AS Date), N'Nam', N'2                   ', N'2              ', N'3', N'CV02      ', 2222)
SET IDENTITY_INSERT [dbo].[PhieuThanhToan] ON 

INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (2, N'MX01      ', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (3, N'MX02      ', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (4, N'A1        ', CAST(N'2021-05-14 19:22:28.000' AS DateTime), CAST(N'2021-05-15 12:57:37.000' AS DateTime), 5000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (5, N'XXSH      ', CAST(N'2021-05-15 03:51:12.000' AS DateTime), CAST(N'2021-05-15 13:08:18.000' AS DateTime), 0, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (6, N'XYZ       ', CAST(N'2021-05-14 22:52:27.000' AS DateTime), CAST(N'2021-05-15 13:18:54.000' AS DateTime), 0, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (7, N'XM994     ', CAST(N'2021-05-14 19:35:44.000' AS DateTime), CAST(N'2021-05-15 13:43:57.000' AS DateTime), 10000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (8, N'XXSH      ', CAST(N'2021-05-15 14:14:51.000' AS DateTime), CAST(N'2021-05-15 17:16:46.000' AS DateTime), 0, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (9, N'Phuong01  ', CAST(N'2021-05-14 19:38:55.000' AS DateTime), CAST(N'2021-05-15 20:43:16.000' AS DateTime), 20000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (10, N'MX01      ', CAST(N'2021-05-14 17:15:03.000' AS DateTime), CAST(N'2021-05-15 21:09:10.000' AS DateTime), 0, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (11, N'XMS01     ', CAST(N'2021-05-15 20:55:52.000' AS DateTime), CAST(N'2021-05-15 21:09:46.000' AS DateTime), 5000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (12, N'XM03      ', CAST(N'2021-05-14 20:13:33.000' AS DateTime), CAST(N'2021-05-15 21:16:46.000' AS DateTime), 20000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (13, N'XXSH      ', CAST(N'2021-05-15 20:54:36.000' AS DateTime), CAST(N'2021-05-15 22:28:20.000' AS DateTime), 0, 1, N'NV01      ')
SET IDENTITY_INSERT [dbo].[PhieuThanhToan] OFF
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'                              ', NULL, NULL)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'chanhdethuong                 ', N'1                             ', N'NV04      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'kk01                          ', N'1                             ', N'KK01      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'minhquang                     ', N'quang2k                       ', N'NV03      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'phuongcute                    ', N'1                             ', N'NV02      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'quoctien                      ', N'tien123                       ', N'NV01      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'Rota                          ', N'1                             ', N'NV15      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T1                            ', N'1                             ', N'T1        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T123                          ', N'T123                          ', N'Ihaveyou  ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T2                            ', N'1                             ', N'T2        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T3                            ', N'1                             ', N'T3        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'taikhoan1                     ', N'1                             ', N'NV99      ')
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX01      ', N'MX01      ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX02      ', N'XXSH      ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX03      ', N'MX02      ', CAST(N'2021-05-15 17:16:05.073' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX04      ', N'XM01      ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX05      ', N'XYZ       ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX06      ', N'XM09      ', CAST(N'2021-05-15 23:12:01.863' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX07      ', N'MX60      ', CAST(N'2021-05-15 20:46:30.407' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX08      ', N'XXSH      ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX09      ', N'XM15      ', CAST(N'2021-05-15 23:17:18.600' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX10      ', N'XM16      ', CAST(N'2021-05-15 23:18:59.143' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX11      ', N'OT01      ', CAST(N'2021-05-15 23:19:55.990' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX12      ', N'OT02      ', CAST(N'2021-05-15 23:23:27.357' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX13      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX14      ', N'OT03      ', CAST(N'2021-05-15 23:28:28.100' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX15      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX16      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX17      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX18      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX19      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX20      ', NULL, NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT01      ', N'A1', N'XM09      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT02      ', N'A2', N'MX02      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT03      ', N'A3', N'XM15      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT04      ', N'B1', N'MX60      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT05      ', N'B2', N'XM16      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT06      ', N'B3', N'OT01      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT09      ', N'C3', N'OT02      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT100     ', N'A7', N'OT03      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'Vt111     ', N'C7', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'A1        ', N'47B2                ', N'A11', N'red', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX01      ', N'47B2-44841          ', N'Sirius', N'Đen', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX02      ', N'47AB-2222           ', N'Grande', N'Xám', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX60      ', N'60V6                ', N'Xe Chánh', N'vàng', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'OT01      ', N'59OTO-01            ', N'Ô tô huynh đai ', N'đen', N'LXO       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'OT02      ', N'59OTO-02            ', N'Xe Vinfast', N'Black', N'LXO       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'OT03      ', N'59OTO-03            ', N'Ô tô Victory', N'Green', N'LXO       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'Phuong01  ', N'XecuaPhuong         ', N'Phương rider', N'red', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM01      ', N'47B2-88481          ', N'Sirius', N'Black', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM03      ', N'47G                 ', N'Bòr', N'red', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM09      ', N'47B2-01681          ', N'Grande', N'gray', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM15      ', N'59AB-01             ', N'Venus', N'Red', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM16      ', N'59AB-02             ', N'Exciter', N'Yello', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM994     ', N'47B2                ', N'A11', N'red', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XMS01     ', N'BSM01               ', N'Xe của Quang', N'red', N'LXM       ', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XXSH      ', N'59E5                ', N'Bò', N'vàng', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XYZ       ', N'ABC                 ', N'VF', N'red', N'LXM       ', 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KhachHan__272520CCBA62504A]    Script Date: 5/15/2021 11:47:36 PM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__2725D70B726BED2B]    Script Date: 5/15/2021 11:47:36 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__ViTri__93028419C614FB16]    Script Date: 5/15/2021 11:47:36 PM ******/
ALTER TABLE [dbo].[ViTri] ADD UNIQUE NONCLUSTERED 
(
	[TenViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__ViTri__B08B247E4CF76BDD]    Script Date: 5/15/2021 11:47:36 PM ******/
ALTER TABLE [dbo].[ViTri] ADD UNIQUE NONCLUSTERED 
(
	[MaViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GiaVe]  WITH CHECK ADD FOREIGN KEY([MaLoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoaiXe])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[PhieuThanhToan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuThanhToan]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TheGuiXe]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ViTri]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([MaLoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoaiXe])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 5/15/2021 11:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn varchar(100), @checkOut varchar(100)
AS
BEGIN
	SELECT TenKH, GioVao, GioRa, TienThu
	FROM dbo.PhieuThanhToan, dbo.KhachHang
	WHERE GioVao >= @checkIn AND GioRa <= @checkOut AND PhieuThanhToan.MaXe = KhachHang.MaXe
END
GO
