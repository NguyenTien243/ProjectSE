USE [QLBaiDoXe]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[GiaVe]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[SoThang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[PhieuThanhToan]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[TheGuiXe]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[ViTri]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Xe]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV01      ', N'Người quản lý')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV02      ', N'Nhân viên giữ xe')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV01      ', N'Vé gửi xe máy L1', 5000, N'LXM       ', 0, 4, 0, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV02      ', N'Vé gửi xe máy L2', 8000, N'LXM       ', 4, 8, 0, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV03      ', N'Vé gửi ô tô L1', 10000, N'LXO       ', 0, 4, 0, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV04      ', N'Vé gửi ô tô L2', 15000, N'LXO       ', 4, 8, 0, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV05      ', N'Vé 1 Tháng xe máy', 120000, N'LXM       ', 0, 0, 0, 1, 1)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV06      ', N'Vé 1 tháng ô tô', 250000, N'LXO       ', 0, 0, 0, 1, 1)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV07      ', N'Vé 6 tháng xe máy', 720000, N'LXM       ', 0, 0, 10, 1, 6)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV08      ', N'Vé 6 tháng ô tô', 1500000, N'LXO       ', 0, 0, 10, 1, 6)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV09      ', N'Vé 12 tháng ô tô', 3000000, N'LXO       ', 0, 0, 20, 1, 12)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV10      ', N'Vé 12 tháng xe máy', 1440000, N'LXM       ', 0, 0, 20, 1, 12)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV11      ', N'Vé ô tô L3', 25000, N'LXO       ', 8, 24, 0, 0, 0)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai], [VeThang], [SoThang]) VALUES (N'GV12      ', N'Vé xe máy L3', 15000, N'LXM       ', 8, 24, 0, 0, 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH01      ', N'Phạm Văn Bách', CAST(N'1994-06-15' AS Date), N'Nữ', N'123456789           ', N'0928373310     ', N'7/2B Quang Trung2', CAST(N'2022-01-15T00:00:00.000' AS DateTime), N'XO01      ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH02      ', N'Minh Tâm', CAST(N'1993-07-20' AS Date), N'Nữ', N'2923845654          ', N'0903726299     ', N'11/2 Trịnh Hoài Đức', CAST(N'2021-06-22T11:34:57.000' AS DateTime), N'XM123     ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH022     ', N'2', CAST(N'1994-08-04' AS Date), N'Nam', N'3534                ', N'0984726475     ', N'4', CAST(N'2022-05-22T12:02:40.000' AS DateTime), N'45        ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH11      ', N'Hoàng', CAST(N'1994-08-18' AS Date), N'Nam', N'123456788           ', N'0908374647     ', N'76 Ngô Quyền', CAST(N'2022-05-15T18:40:31.000' AS DateTime), N'MX11      ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH12      ', N'BP', CAST(N'1994-10-05' AS Date), N'Nữ', N'464576457           ', N'0904857387     ', N'110 Khổng Tử', CAST(N'2022-02-15T00:00:00.000' AS DateTime), N'XM11      ')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'LXM       ', N'Xe máy')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'LXO       ', N'Xe ô tô')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'Ihaveyou  ', N'Tien', CAST(N'2021-04-28' AS Date), N'Nam', N'                    ', N'               ', N'', N'CV02      ', 9000)
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

INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (1, N'XM11      ', CAST(N'2021-05-10T08:50:00.000' AS DateTime), CAST(N'2021-05-10T08:50:00.000' AS DateTime), 114000, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (8, N'XO01      ', CAST(N'2021-05-12T12:01:00.000' AS DateTime), CAST(N'2021-05-12T12:01:00.000' AS DateTime), 2400000, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (17, N'MX11      ', CAST(N'2021-05-17T09:10:00.000' AS DateTime), CAST(N'2021-05-17T09:10:00.000' AS DateTime), 1152000, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (24, N'XO02      ', NULL, NULL, 1350000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (26, N'XO01      ', NULL, NULL, 250000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (27, N'XM14      ', CAST(N'2021-05-21T12:38:11.000' AS DateTime), CAST(N'2021-05-21T13:20:37.000' AS DateTime), 0, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (28, N'XM123     ', CAST(N'2021-05-22T11:35:01.207' AS DateTime), CAST(N'2021-05-22T11:35:01.207' AS DateTime), 120000, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (29, N'XO01      ', CAST(N'2021-05-21T10:47:40.000' AS DateTime), CAST(N'2021-05-22T11:49:56.000' AS DateTime), 35000, 0, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (30, N'XO01      ', NULL, NULL, 2400000, 1, N'NV01      ')
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (31, N'45        ', CAST(N'2021-05-22T12:02:53.770' AS DateTime), CAST(N'2021-05-22T12:02:53.770' AS DateTime), 2400000, 1, N'NV01      ')
SET IDENTITY_INSERT [dbo].[PhieuThanhToan] OFF
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'                              ', NULL, NULL)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'chanhdethuong                 ', N'1                             ', N'NV04      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'minhquang                     ', N'quang2k                       ', N'NV03      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'phuongcute                    ', N'1                             ', N'NV02      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'quoctien                      ', N'tien123                       ', N'NV01      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'Rota                          ', N'1                             ', N'NV15      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T1                            ', N'1                             ', N'T1        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T123                          ', N'T123                          ', N'Ihaveyou  ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T2                            ', N'1                             ', N'T2        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T3                            ', N'1                             ', N'T3        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'taikhoan1                     ', N'1                             ', N'NV99      ')
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX01      ', N'45        ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX03      ', N'XM14      ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX04      ', N'XM123     ', NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX05      ', N'XM12      ', CAST(N'2021-05-22T11:44:52.123' AS DateTime))
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX06      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX07      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX08      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX09      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX10      ', NULL, NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT01      ', N'A4', N'MX01      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT02      ', N'A2', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT03      ', N'A3', N'XM12      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT04      ', N'B1', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT05      ', N'B2', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT06      ', N'B3', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT09      ', N'C3', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT100     ', N'A1', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'45        ', N'23234               ', N'3', N'1234', N'LXO       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX01      ', N'47B2-44841          ', N'Sirius', N'Đen3', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX11      ', N'HH-34655            ', N'Honda', N'Đen', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM11      ', N'HH-3465             ', N'Honda', N'Đen', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM12      ', N'XM-12345            ', N'Vision', N'Trắng', N'LXM       ', 0)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM123     ', N'XM-12               ', N'Vision', N'Trắng', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM13      ', N'XM-1234             ', N'Vision', N'Trắng', N'LXM       ', 0)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XM14      ', N'hhfhg               ', N'Vision', N'Trắng', N'LXM       ', 0)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XO01      ', N'X2-1234             ', N'Oto', N'Hồng', N'LXO       ', 0)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XO02      ', N'HH-1234             ', N'Oto', N'Vàng', N'LXO       ', 0)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'XO03      ', N'HF-2041             ', N'Oto', N'Trắng', N'LXO       ', 0)
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhachHan__272520CC8DCE2E1B]    Script Date: 22/05/2021 12:04:26 PM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__2725D70B04C3A694]    Script Date: 22/05/2021 12:04:26 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[MaNV] ASC
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
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn varchar(100), @checkOut varchar(100)
AS
BEGIN
	SELECT TenKH, GioVao, GioRa, TienThu, TenNV 
	FROM dbo.PhieuThanhToan, dbo.KhachHang, dbo.NhanVien
	WHERE GioVao >= @checkIn AND GioRa <= @checkOut AND PhieuThanhToan.MaXe = KhachHang.MaXe AND NhanVien.MaNV = PhieuThanhToan.MaNV
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetSumBillByDate]    Script Date: 22/05/2021 12:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetSumBillByDate]
@checkIn varchar(100), @checkOut varchar(100)
AS
BEGIN
	SELECT Sum(TienThu) as TongThu
	FROM PhieuThanhToan
	WHERE GioVao >= @checkIn AND GioRa <= @checkOut 
END
GO
