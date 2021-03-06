USE [master]
GO
/****** Object:  Database [QUANLYNHANSU]    Script Date: 11/21/2016 2:44:56 PM ******/
CREATE DATABASE [QUANLYNHANSU]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYNHANSU', FILENAME = N'D:\QUANLYNHANSU.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYNHANSU_log', FILENAME = N'D:\QUANLYNHANSU_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYNHANSU] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNHANSU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNHANSU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYNHANSU] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNHANSU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNHANSU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYNHANSU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYNHANSU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYNHANSU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYNHANSU] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYNHANSU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYNHANSU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYNHANSU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYNHANSU] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QUANLYNHANSU]
GO
/****** Object:  Table [dbo].[tblChiTietHopDong]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHopDong](
	[MaHD] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[GhiChu] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChiTietKhenThuong]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietKhenThuong](
	[MaKT] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[NgayKhenThuong] [date] NULL,
	[TienKhenThuong] [bigint] NULL,
	[GhiChu] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChiTietNgoaiNgu]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietNgoaiNgu](
	[MaNN] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[ThoiGian] [date] NULL,
	[TrinhDo] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChucVu]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucVu](
	[MaChucVu] [nchar](10) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
	[PhuCap] [bigint] NULL,
 CONSTRAINT [PK_tblChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChuyenMon]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChuyenMon](
	[MaChuyenMon] [nchar](10) NOT NULL,
	[TenChuyenMon] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChuyenMon] PRIMARY KEY CLUSTERED 
(
	[MaChuyenMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHopDongLD]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHopDongLD](
	[MaHD] [nchar](10) NOT NULL,
	[TenHD] [nvarchar](50) NULL,
	[LoaiHD] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHopDongLD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhenThuong]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhenThuong](
	[MaKT] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaPB] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblKhenThuong] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNgoaiNgu]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNgoaiNgu](
	[MaNN] [nchar](10) NOT NULL,
	[TenNN] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNgoaiNgu] PRIMARY KEY CLUSTERED 
(
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaPB] [nchar](10) NOT NULL,
	[MaChucVu] [nchar](10) NOT NULL,
	[MaChuyenMon] [nchar](10) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhieuLuong]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuLuong](
	[MaPhieuLuong] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[LuongCoBan] [bigint] NULL,
	[HeSoLuong] [float] NULL,
	[TienThuong] [bigint] NULL,
	[PhuCap] [bigint] NULL,
	[TongLinh] [bigint] NULL,
	[NgayLinh] [nchar](10) NULL,
 CONSTRAINT [PK_tblPhieuLuong] PRIMARY KEY CLUSTERED 
(
	[MaPhieuLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhongBan]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhongBan](
	[MaPB] [nchar](10) NOT NULL,
	[TenPB] [nvarchar](50) NOT NULL,
	[DiaDiem] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_tblPhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 11/21/2016 2:44:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[TaiKhoan] [nchar](10) NOT NULL,
	[MatKhau] [nchar](10) NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHopDong_tblHopDongLD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tblHopDongLD] ([MaHD])
GO
ALTER TABLE [dbo].[tblChiTietHopDong] CHECK CONSTRAINT [FK_tblChiTietHopDong_tblHopDongLD]
GO
ALTER TABLE [dbo].[tblChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHopDong_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblChiTietHopDong] CHECK CONSTRAINT [FK_tblChiTietHopDong_tblNhanVien]
GO
ALTER TABLE [dbo].[tblChiTietKhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietKhenThuong_tblKhenThuong] FOREIGN KEY([MaKT])
REFERENCES [dbo].[tblKhenThuong] ([MaKT])
GO
ALTER TABLE [dbo].[tblChiTietKhenThuong] CHECK CONSTRAINT [FK_tblChiTietKhenThuong_tblKhenThuong]
GO
ALTER TABLE [dbo].[tblChiTietKhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietKhenThuong_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblChiTietKhenThuong] CHECK CONSTRAINT [FK_tblChiTietKhenThuong_tblNhanVien]
GO
ALTER TABLE [dbo].[tblChiTietNgoaiNgu]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNgoaiNgu_tblNgoaiNgu] FOREIGN KEY([MaNN])
REFERENCES [dbo].[tblNgoaiNgu] ([MaNN])
GO
ALTER TABLE [dbo].[tblChiTietNgoaiNgu] CHECK CONSTRAINT [FK_tblChiTietNgoaiNgu_tblNgoaiNgu]
GO
ALTER TABLE [dbo].[tblChiTietNgoaiNgu]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNgoaiNgu_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblChiTietNgoaiNgu] CHECK CONSTRAINT [FK_tblChiTietNgoaiNgu_tblNhanVien]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[tblChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblChucVu]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblChuyenMon] FOREIGN KEY([MaChuyenMon])
REFERENCES [dbo].[tblChuyenMon] ([MaChuyenMon])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblChuyenMon]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblPhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[tblPhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblPhongBan]
GO
ALTER TABLE [dbo].[tblPhieuLuong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuLuong_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblPhieuLuong] CHECK CONSTRAINT [FK_tblPhieuLuong_tblNhanVien]
GO
USE [master]
GO
ALTER DATABASE [QUANLYNHANSU] SET  READ_WRITE 
GO
