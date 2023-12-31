USE [master]
GO
/****** Object:  Database [QuanLiThuVien]    Script Date: 5/12/2023 1:40:08 PM ******/
CREATE DATABASE [QuanLiThuVien]
 CONTAINMENT = NONE
 
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLiThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLiThuVien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLiThuVien] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLiThuVien] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLiThuVien]
GO
/****** Object:  Table [dbo].[BanDoc]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanDoc](
	[MaBanDoc] [nchar](10) NOT NULL,
	[TenBanDoc] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_BanDoc] PRIMARY KEY CLUSTERED 
(
	[MaBanDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuonTra]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonTra](
	[MaPhieu] [nchar](10) NOT NULL,
	[MaBanDoc] [nchar](10) NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_PhieuMuonTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuonTraSach]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonTraSach](
	[MaPhieu] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_PhieuMuonTraSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [nchar](10) NOT NULL,
	[MaNhaCungCap] [nchar](10) NULL,
	[MaNhanVien] [nchar](10) NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapSach]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapSach](
	[MaPhieuNhap] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_PhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 5/12/2023 1:40:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[phanquyen] [bit] NULL,
 CONSTRAINT [PK_tblDangNhap] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BanDoc] ([MaBanDoc], [TenBanDoc], [DiaChi]) VALUES (N'ltnga12   ', N'Lê Thị Ngaa', N'Thành phố Hà Nội ')
INSERT [dbo].[BanDoc] ([MaBanDoc], [TenBanDoc], [DiaChi]) VALUES (N'ndphuc11  ', N'Nguyễn Đình Phúcc', N'Bắc Ninh')
INSERT [dbo].[BanDoc] ([MaBanDoc], [TenBanDoc], [DiaChi]) VALUES (N'PhucBua   ', N'Nguyễn Đình Phúc', N'Thành phố Cần Thơ  ')
INSERT [dbo].[BanDoc] ([MaBanDoc], [TenBanDoc], [DiaChi]) VALUES (N'PhucBua1  ', N'Nguyễn Đình Phúc', N'Thành phố Cần Thơ  ')
INSERT [dbo].[BanDoc] ([MaBanDoc], [TenBanDoc], [DiaChi]) VALUES (N'PhucBua13 ', N'Nguyễn Đình Phúcc', N'Thành phố Cần Thơ  ')
INSERT [dbo].[BanDoc] ([MaBanDoc], [TenBanDoc], [DiaChi]) VALUES (N'qlinh16   ', N'Vũ Quang Linh', N'Hòa Bình')
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'bk        ', N'Trường Đại học Bách Khoa Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'Neu       ', N'Trường Đại học Kinh Tế Quốc Dân')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'nono      ', N'Nhà sách Thùy tiên')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap]) VALUES (N'Uneti     ', N'Trường Đại học Kinh tế Kỹ thuật - Công nghiệp')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien]) VALUES (N'NV5       ', N'Bùi Nhật Minh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien]) VALUES (N'NV6       ', N'Nguyễn Minh Nhật')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien]) VALUES (N'NV7       ', N'Nguyễn Anh Minh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien]) VALUES (N'NV8       ', N'Nguyễn Minh Trung')
GO
INSERT [dbo].[PhieuMuonTra] ([MaPhieu], [MaBanDoc], [NgayMuon], [NgayTra]) VALUES (N'MP1       ', N'ltnga12   ', CAST(N'2023-05-12' AS Date), CAST(N'2023-05-12' AS Date))
GO
INSERT [dbo].[PhieuMuonTraSach] ([MaPhieu], [MaSach], [SoLuong]) VALUES (N'MP1       ', N'S12       ', 2)
GO
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN1      ', N'Neu       ', N'NV5       ', CAST(N'2023-01-11' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN2      ', N'Neu       ', N'NV8       ', CAST(N'2023-01-11' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN3      ', N'Neu       ', N'NV8       ', CAST(N'2023-01-09' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN5      ', N'Uneti     ', N'NV6       ', CAST(N'2023-05-11' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN6      ', N'nono      ', N'NV7       ', CAST(N'2023-05-11' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN7      ', N'Neu       ', N'NV7       ', CAST(N'2022-03-08' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap]) VALUES (N'MPN8      ', N'nono      ', N'NV5       ', CAST(N'2023-01-11' AS Date))
GO
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (N'MPN1      ', N'S2        ', 4)
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (N'MPN1      ', N'S20       ', 8)
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhap], [MaSach], [SoLuong]) VALUES (N'MPN2      ', N'S20       ', 4)
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S1        ', N'Học lập trình không khó')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S12       ', N'Thủ thuật Word')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S2        ', N'Khéo ăn khéo nói sẽ có được thiên hạ')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S20       ', N'Truyện DoreMonn')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S3        ', N'Thám tử lừng danh Conan')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S4        ', N'Bác Hồ sống mãi')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S5        ', N'Toán rời rạc')
INSERT [dbo].[Sach] ([MaSach], [TenSach]) VALUES (N'S6        ', N'Đại số tuyến tính')
GO
INSERT [dbo].[tblDangNhap] ([username], [password], [phanquyen]) VALUES (N'admin', N'admin123456', 1)
GO
ALTER TABLE [dbo].[PhieuMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonTra_BanDoc] FOREIGN KEY([MaBanDoc])
REFERENCES [dbo].[BanDoc] ([MaBanDoc])
GO
ALTER TABLE [dbo].[PhieuMuonTra] CHECK CONSTRAINT [FK_PhieuMuonTra_BanDoc]
GO
ALTER TABLE [dbo].[PhieuMuonTraSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonTraSach_PhieuMuonTra] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuMuonTra] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuMuonTraSach] CHECK CONSTRAINT [FK_PhieuMuonTraSach_PhieuMuonTra]
GO
ALTER TABLE [dbo].[PhieuMuonTraSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonTraSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[PhieuMuonTraSach] CHECK CONSTRAINT [FK_PhieuMuonTraSach_Sach]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapSach_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[PhieuNhapSach] CHECK CONSTRAINT [FK_PhieuNhapSach_PhieuNhap]
GO
ALTER TABLE [dbo].[PhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[PhieuNhapSach] CHECK CONSTRAINT [FK_PhieuNhapSach_Sach]
GO
USE [master]
GO
ALTER DATABASE [QuanLiThuVien] SET  READ_WRITE 
GO
