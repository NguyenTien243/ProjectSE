create database [QLBaiDoXe]
go
USE [QLBaiDoXe]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[GiaVe]    Script Date: 4/14/2021 4:08:38 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaGiaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[PhieuThanhToan]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[TheGuiXe]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[ViTri]    Script Date: 4/14/2021 4:08:38 PM ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 4/14/2021 4:08:38 PM ******/
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
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV01      ', N'Ng?????i qu???n l??')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV02      ', N'Nh??n vi??n gi??? xe')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe]) VALUES (N'GV01      ', N'V?? g???i s??ng xe m??y', 5000, N'LXM       ')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe]) VALUES (N'GV02      ', N'V?? g???i t???i xe m??y', 6000, N'LXM       ')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe]) VALUES (N'GV03      ', N'V?? g???i s??ng ?? t??', 10000, N'LXO       ')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe]) VALUES (N'GV04      ', N'V?? g???i t???i ?? t??', 15000, N'LXO       ')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe]) VALUES (N'GV05      ', N'V?? Th??ng xe m??y', 120000, N'LXM       ')
INSERT [dbo].[GiaVe] ([MaGiaVe], [TenGiaVe], [GiaTien], [MaLoaiXe]) VALUES (N'GV06      ', N'V?? Th??ng ?? t??', 250000, N'LXO       ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH01      ', N'S??n T??ng', CAST(N'1990-01-02' AS Date), N'Nam', NULL, NULL, N'35 C???u Gi???y H?? N???i', CAST(N'2021-05-08 00:00:00.000' AS DateTime), N'MX01      ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [NgayHetHanVeThang], [MaXe]) VALUES (N'KH02      ', N'B???o Tr??m', CAST(N'1995-01-20' AS Date), N'N???', NULL, NULL, N'2 V?? V??n Ng??n', CAST(N'2021-06-08 00:00:00.000' AS DateTime), N'MX02      ')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'LXM       ', N'Xe m??y')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'LXO       ', N'Xe ?? t??')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV01      ', N'Nguy???n Qu???c Ti???n', CAST(N'2000-03-24' AS Date), N'Nam', NULL, N'0982427541     ', N'36C/41 ???????ng 16', N'CV01      ', 10000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV02      ', N'Nguy???n Nh?? B???o Ph????ng', CAST(N'2000-02-20' AS Date), N'N???', NULL, N'0908527066     ', N'??? ???????ng Lam S??n', N'CV02      ', 9000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV03      ', N'Ho??ng Minh Quang', CAST(N'2000-12-26' AS Date), N'Nam', NULL, N'0363084288     ', N'01 V?? V??n Ng??n', N'CV02      ', 8000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV04      ', N'Nguy???n ?????c Ch??nh', CAST(N'2000-03-10' AS Date), N'Nam', NULL, N'0975724427     ', N'01 V?? V??n Ng??n', N'CV02      ', 8000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV09      ', N'phuong', NULL, NULL, NULL, NULL, NULL, N'CV02      ', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV13      ', N'T3', NULL, NULL, NULL, NULL, NULL, N'CV02      ', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV14      ', N'T4', NULL, NULL, NULL, NULL, NULL, N'CV02      ', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'NV15      ', N'Rota', CAST(N'2021-04-14' AS Date), N'N???', N'1                   ', N'1              ', N'1', N'CV02      ', 9000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'R2        ', N'R2', CAST(N'2021-04-14' AS Date), N'Nam', N'1                   ', N'1              ', N'1', N'CV02      ', 60000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [SDT], [DiaChi], [MaCV], [Luong]) VALUES (N'R3        ', N'R1', CAST(N'2021-04-14' AS Date), N'N???', N'1                   ', N'1              ', N'1', N'CV02      ', 9000)
INSERT [dbo].[PhieuThanhToan] ([MaPhieu], [MaXe], [GioVao], [GioRa], [TienThu], [TraTheoThang], [MaNV]) VALUES (N'P1        ', N'MX01      ', NULL, NULL, NULL, NULL, N'NV01      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'chanhdethuong                 ', N'1                             ', N'NV04      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'phuongcute                    ', N'1                             ', N'NV02      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'quangpro                      ', N'1                             ', N'NV03      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'R2                            ', N'1                             ', N'R2        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'R3                            ', N'R3                            ', N'R3        ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'Rota                          ', N'1                             ', N'NV15      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T3                            ', N'1                             ', N'NV13      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'T4                            ', N'1                             ', N'NV14      ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNV]) VALUES (N'tiendeptrai                   ', N'1                             ', N'NV01      ')
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
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT07      ', N'C1', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT08      ', N'C2', NULL)
INSERT [dbo].[ViTri] ([MaViTri], [TenViTri], [MaXe]) VALUES (N'VT09      ', N'C3', NULL)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX01      ', N'47B2-44841          ', N'Sirius', N'??en', N'LXM       ', 1)
INSERT [dbo].[Xe] ([MaXe], [BienSo], [TenXe], [MauSac], [MaLoaiXe], [DangKyThang]) VALUES (N'MX02      ', N'47AB-2222           ', N'Grande', N'X??m', N'LXM       ', 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KhachHan__272520CC87FBC967]    Script Date: 4/14/2021 4:08:38 PM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TaiKhoan__2725D70BEE72ECFA]    Script Date: 4/14/2021 4:08:38 PM ******/
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
