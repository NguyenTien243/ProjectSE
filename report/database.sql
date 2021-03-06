CREATE TABLE [QLBaiDoXe]
GO
USE [QLBaiDoXe]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[GiaVe]    Script Date: 4/28/2021 9:31:41 AM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaGiaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[PhieuThanhToan]    Script Date: 4/28/2021 9:31:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuThanhToan](
	[MaPhieu] [char](10) NOT NULL,
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[TheGuiXe]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[ViTri]    Script Date: 4/28/2021 9:31:41 AM ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 4/28/2021 9:31:41 AM ******/
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
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV01      ', N'Vé gửi sáng xe máy', 5000, N'LXM       ', NULL, NULL, NULL)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV02      ', N'Vé gửi tối xe máy', 6000, N'LXM       ', NULL, NULL, NULL)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV03      ', N'Vé gửi sáng ô tô', 10000, N'LXO       ', NULL, NULL, NULL)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV04      ', N'Vé gửi tối ô tô', 15000, N'LXO       ', NULL, NULL, NULL)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV05      ', N'Vé 1 Tháng xe máy', 120000, N'LXM       ', NULL, NULL, NULL)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV06      ', N'Vé tháng ô tô', 250000, N'LXO       ', NULL, NULL, NULL)
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe], [GioToiThieu], [GioToiDa], [UuDai]) VALUES (N'GV07      ', N'Vé 6 tháng', 720000, N'LXM       ', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH01      ', N'Sơn Tùng', CAST(N'1990-01-02' AS Date), N'Nam', NULL, NULL, N'35 Cầu Giấy Hà Nội', CAST(N'2021-05-08 00:00:00.000' AS DateTime), N'MX01      ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH02      ', N'Bảo Trâm', CAST(N'1995-01-20' AS Date), N'Nữ', NULL, NULL, N'2 Võ Văn Ngân', CAST(N'2021-06-08 00:00:00.000' AS DateTime), N'MX02      ')
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
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (N'P1        ', N'MX01      ', NULL, NULL, NULL, NULL, N'NV01      ')
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
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX01      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX02      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX03      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX04      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX05      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX06      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX07      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX08      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX09      ', NULL, NULL)
INSERT [dbo].[TheGuiXe] ([MaTheGuiXe], [MaXe], [GioVao]) VALUES (N'TX10      ', NULL, NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT01      ', N'A1', N'MX01      ')
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT02      ', N'A2', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT03      ', N'A3', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT04      ', N'B1', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT05      ', N'B2', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT06      ', N'B3', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT09      ', N'C3', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT100     ', N'A1', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX01      ', N'47B2-44841          ', N'Sirius', N'Đen', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX02      ', N'47AB-2222           ', N'Grande', N'Xám', N'LXM       ', 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KhachHan__272520CC87FBC967]    Script Date: 4/28/2021 9:31:41 AM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__2725D70BEE72ECFA]    Script Date: 4/28/2021 9:31:41 AM ******/
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
