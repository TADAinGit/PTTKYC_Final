USE [master]
GO
/****** Object:  Database [QuanLyBanHoa]    Script Date: 4/29/2021 9:35:41 PM ******/
CREATE DATABASE [QuanLyBanHoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHoa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyBanHoa.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBanHoa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyBanHoa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyBanHoa] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyBanHoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanHoa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHoa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBanHoa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyBanHoa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyBanHoa] SET QUERY_STORE = OFF
GO
USE [QuanLyBanHoa]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhapHang]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhapHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNH] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
	[GiaNhap] [int] NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[MaLoai] [char](10) NULL,
	[GiaNhap] [int] NULL,
	[GiaBan] [int] NULL,
	[activated] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoaIMG]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoaIMG](
	[MaHH] [int] NOT NULL,
	[IMG] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
	[DateCheckIn] [date] NULL,
	[TongTien] [int] NOT NULL,
	[TienGiam] [int] NOT NULL,
	[ThanhToan] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[sdt] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaHH] [int] NOT NULL,
	[KhuyenMai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[MaLoai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[sdt] [char](11) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GT] [bit] NOT NULL,
	[CMND] [char](20) NOT NULL,
	[sdt] [char](11) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[NgayVaoLam] [date] NULL,
	[Luong] [int] NULL,
	[ChucVu] [nvarchar](100) NULL,
	[activated] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapHang]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapHang](
	[MaNH] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[DateCheckIn] [date] NULL,
	[MaNCC] [int] NULL,
	[TongTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[TenDangNhap] [char](20) NOT NULL,
	[permission] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyHangHoa]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyHangHoa](
	[MaHH] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyKHThanThiet]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyKHThanThiet](
	[MaKH] [int] NOT NULL,
	[Discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [char](20) NOT NULL,
	[MatKhau] [char](20) NOT NULL,
	[TenHienThi] [nvarchar](100) NOT NULL,
	[MaNV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((1)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[HangHoa] ADD  DEFAULT ((0)) FOR [GiaNhap]
GO
ALTER TABLE [dbo].[HangHoa] ADD  DEFAULT ((1000)) FOR [GiaBan]
GO
ALTER TABLE [dbo].[HangHoa] ADD  DEFAULT ((1)) FOR [activated]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[KhuyenMai] ADD  DEFAULT ((0)) FOR [KhuyenMai]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [GT]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (getdate()) FOR [NgayVaoLam]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((2800000)) FOR [Luong]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (N'Nhân viên') FOR [ChucVu]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((1)) FOR [activated]
GO
ALTER TABLE [dbo].[NhapHang] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietNhapHang]  WITH CHECK ADD FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHangHoa] ([MaLoai])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoaIMG]  WITH CHECK ADD FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[QuanLyKHThanThiet]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD CHECK  (([soluong]>=(0)))
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD CHECK  (([Thanhtien]>(0)))
GO
ALTER TABLE [dbo].[ChiTietNhapHang]  WITH CHECK ADD CHECK  (([soluong]>=(0)))
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD CHECK  (([giaban]>(0)))
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD CHECK  (([gianhap]>(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([thanhtoan]>(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([tiengiam]>=(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([tongtien]>(0)))
GO
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD CHECK  (([khuyenmai]>=(0)))
GO
ALTER TABLE [dbo].[QuanLyHangHoa]  WITH CHECK ADD CHECK  (([soluong]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[CapNhatIMGHangHoa]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------cap nhat img
create Proc [dbo].[CapNhatIMGHangHoa]
(@MaHH int,@img image)
as
begin
	if not exists(select * from HangHoaIMG where @MaHH = MaHH)
	 begin
		insert into HangHoaIMG values(@MaHH,@img);
	 end
	 else
	 begin
		update HangHoaIMG
		set IMG = @img
		from HangHoaIMG
		where Mahh = @MaHH
	 end
end;

GO
/****** Object:  StoredProcedure [dbo].[CapNhatSanPham]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------
create PROC [dbo].[CapNhatSanPham] 
(@ID int,@tenhh nvarchar(100),@maloai char(20),@gianhap int,@giaban int,@img image)
AS
BEGIN
	update HangHoa
	set HangHoa.Ten = @tenhh, HangHoa.MaLoai = @maloai,GiaNhap =@gianhap,GiaBan = @giaban
	from HangHoa
	where HangHoa.MaHH = @ID;
	exec CapNhatIMGHangHoa @ID, @img;

END;

GO
/****** Object:  StoredProcedure [dbo].[CapNhatSoLuong]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------Cap nhat so luong
create PROC [dbo].[CapNhatSoLuong] 
(@MaHH int,@Soluong int)
AS
BEGIN
	 if not exists(select * from QuanLyHangHoa where @MaHH = MaHH)
	 begin
		insert into QuanLyHangHoa(MaHH,SoLuong)
		values(@MaHH,@Soluong);
	 end
	 else
	 begin
		update QuanLyHangHoa
		set SoLuong = @Soluong
		from QuanLyHangHoa
		where Mahh = @MaHH
	 end

END;

GO
/****** Object:  StoredProcedure [dbo].[CheckAccount]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------Kiem tra tai khoan co ton tai trong he thong khong, neu co thi lay thong tin
create proc [dbo].[CheckAccount](@username char(100),@password char(20))
as
begin
	select TenHienThi,NgaySinh,GT,CMND,sdt,diachi,NgayVaoLam, TaiKhoan.TenDangNhap,MatKhau,NhanVien.MaNV, TenNV,permission  from TaiKhoan inner join NhanVien on TaiKhoan.MaNV = NhanVien.MaNV inner join PhanQuyen on PhanQuyen.TenDangNhap = TaiKhoan.TenDangNhap
	where taikhoan.TenDangNhap = @username and MatKhau = @password;
end

GO
/****** Object:  StoredProcedure [dbo].[DanhMucSanPham]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------Danh muc san pham
create PROC	[dbo].[DanhMucSanPham]
as
	select HangHoa.MaHH,Ten,LoaiHangHoa.MaLoai,TenLoai,GiaNhap,GiaBan,SoLuong from HangHoa inner join LoaiHangHoa on HangHoa.MaLoai = LoaiHangHoa.MaLoai 
	inner join QuanLyHangHoa on QuanLyHangHoa.MaHH = HangHoa.MaHH where HangHoa.activated = 1;

GO
/****** Object:  StoredProcedure [dbo].[DanhMucSanPhamKemAnh]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------Danh muc san pham kem img
create PROC	[dbo].[DanhMucSanPhamKemAnh]
(@ID int,@name nvarchar(100),@MaLoai char(20),@Gia1 int,@Gia2 int)
as
	if @name ='All'
	Begin
		select HangHoa.MaHH,Ten,IMG,GiaNhap,GiaBan from HangHoa left Join HangHoaIMG on HangHoa.MaHH = HangHoaIMG.MaHH where HangHoa.activated = 1;
	end
	else
	Begin
		select HangHoa.MaHH,Ten,IMG,GiaNhap,GiaBan from HangHoa left Join HangHoaIMG on HangHoa.MaHH = HangHoaIMG.MaHH where HangHoa.activated = 1 and(HangHoa.MaLoai = @MaLoai or HangHoa.Ten like concat('%',@name,'%') or HangHoa.MaHH = @ID); 
	end

GO
/****** Object:  StoredProcedure [dbo].[GetAllUser]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------Lấy toạn bộ thông tin các tài khoản
create Proc [dbo].[GetAllUser]
as
BEGIN
	select NhanVien.MaNV,TenNV,TenHienThi,TaiKhoan.TenDangNhap, MatKhau,permission from NhanVien left join TaiKhoan on NhanVien.MaNV = TaiKhoan.MaNV left join PhanQuyen on TaiKhoan.TenDangNhap = PhanQuyen.TenDangNhap;
END;

GO
/****** Object:  StoredProcedure [dbo].[KhachHangTiemNang]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------
create proc [dbo].[KhachHangTiemNang]
(@month int, @year int)
as
Begin
	select top 10 KhachHang.MaKH,TenKH,Sdt, sum(ThanhToan) as tieuthu,count(KhachHang.MaKH) as solanden from
	KhachHang inner join HoaDon on KhachHang.MaKH = HoaDon.MaKH where month(HoaDon.DateCheckIn)=@month and year(HoaDon.DateCheckIn) = @year group by KhachHang.MaKH,TenKH,sdt
	order by tieuthu desc;
end

GO
/****** Object:  StoredProcedure [dbo].[LichSuNhapHang]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------
----------------------------Lich su nhap hang
create PROC [dbo].[LichSuNhapHang]
(@thoigian date)
AS
BEGIN
	select Ten,TenNV,NhapHang.MaNH,ChiTietNhapHang.GiaNhap,SoLuong,ThanhTien,TongTien  From ChiTietNhapHang inner join NhapHang on NhapHang.MaNH = ChiTietNhapHang.MaNH inner join HangHoa on HangHoa.MaHH = ChiTietNhapHang.MaHH 
	inner join NhanVien on NhanVien.MaNV = NhapHang.MaNV where NhapHang.DateCheckIn = @thoigian
END;

GO
/****** Object:  StoredProcedure [dbo].[LoadIMG]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------Load img
create Proc [dbo].[LoadIMG]
(@MaHH int)
as
begin
	if not exists(select * from HangHoaIMG where @MaHH = MaHH)
	 begin
		select * from HangHoaIMG where @MaHH = MaHH;
	 end
	 else
	 begin
		select * from HangHoaIMG where @MaHH = MaHH;
	 end
end;

GO
/****** Object:  StoredProcedure [dbo].[LoaiSanPham]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------Hien thi loai san pham
create PROC [dbo].[LoaiSanPham] 
AS
BEGIN
	select * from LoaiHangHoa;
END;

GO
/****** Object:  StoredProcedure [dbo].[NhaCC]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------Hien thi nha cung cap
create PROC [dbo].[NhaCC] 
AS
BEGIN
	select * from NhaCungCap;
END;

GO
/****** Object:  StoredProcedure [dbo].[NhapHangVaoKho]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------
----------------------------Nhap Hang
create PROC [dbo].[NhapHangVaoKho]
(@manv int,  @mancc int, @tongtien int)
AS
BEGIN
	insert into NhapHang(MaNV,MaNCC,TongTien) 
	values(@manv,@mancc,@tongtien);
	SELECT TOP 1 MaNH from NhapHang ORDER BY MaNH DESC;
	
END;

GO
/****** Object:  StoredProcedure [dbo].[NhapHangVaoKho_ChiTiet]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------
----------------------------Nhap Hang chi tiet
create PROC [dbo].[NhapHangVaoKho_ChiTiet]
(@manh int,  @mahh int,@gianhap int,@soluong int, @thanhtien int)
AS
BEGIN
	insert into ChiTietNhapHang
	values(@manh,@mahh,@gianhap,@soluong, @thanhtien);
END;

GO
/****** Object:  StoredProcedure [dbo].[NhapHoaDon]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------Nhập hóa đơn
create PROC [dbo].[NhapHoaDon]
(@makh int, @manv int, @tongtien int ,@tiengiam int,@pay int)
AS
BEGIN
	insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan) 
	values(@makh, @manv , @tongtien ,@tiengiam ,@pay);
	SELECT TOP 1 MaHD from HoaDon ORDER BY MaHD DESC;
	
END;

GO
/****** Object:  StoredProcedure [dbo].[NhapHoaDon_ChiTiet]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------Nhập hóa đơn chi tiết
create PROC [dbo].[NhapHoaDon_ChiTiet]
(@mahd int,  @mahh int, @soluong int, @thanhtien int)
AS
BEGIN
	insert into ChiTietHoaDon
	values(@mahd,  @mahh, @soluong, @thanhtien);
END;

GO
/****** Object:  StoredProcedure [dbo].[NhapKhachHang]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------Nhập thông tin khách hàng

create PROC [dbo].[NhapKhachHang]
(@name nvarchar(100),  @sdt char(11))
AS
BEGIN
	if not exists(select MaKH from KhachHang where sdt = @sdt and TenKH = @name)
		begin
			insert into KhachHang
			values(@name, @sdt);
			SELECT TOP 1 MaKH from KhachHang ORDER BY MaKH DESC;
		end
	else
		select MaKH from KhachHang where sdt = @sdt and TenKH = @name
END;

GO
/****** Object:  StoredProcedure [dbo].[QuanLyTaiKhoan]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-------------------------------QuanLyTaiKhoan
create PROC	[dbo].[QuanLyTaiKhoan]
as
select * from TaiKhoan

GO
/****** Object:  StoredProcedure [dbo].[ThemSanPham]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-----------------------------------them hang hoa
create PROC [dbo].[ThemSanPham] 
(@MANCC int,@tenhh nvarchar(100),@maloai char(20),@gianhap int,@giaban int,@soluong int,@img image)
AS
BEGIN
	declare @id int;
	insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
	(@MANCC,@tenhh,@maloai,@giaban,@giaban);
	select MaHH from HangHoa where MaNCC = @MANCC and Ten = @tenhh and MaLoai = @maloai and GiaNhap = @gianhap and GiaBan = @giaban
	set @id = (SELECT TOP 1 MaHH FROM HangHoa ORDER BY MaHH DESC );
	exec CapNhatSoLuong @id,@soluong;
	exec CapNhatIMGHangHoa @id, @img;
END;

GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------Them tai khoan
create PROC [dbo].[ThemTaiKhoan] 
(@user char(20), @pass char(20), @permision nvarchar(20), @hienthi nvarchar(100),@ID int)
AS
BEGIN
	if not exists(select * from TaiKhoan where TenDangNhap = @user)
	begin
		insert into TaiKhoan(TenDangNhap,MatKhau,TenHienThi,MaNV) 
		values(@user,@pass,@hienthi,@ID);
		insert into PhanQuyen(TenDangNhap,permission) values(@user,@permision);
	end
	else
	begin
		update TaiKhoan set MatKhau = @pass , TenHienThi = @hienthi where TenDangNhap = @user;
		update PhanQuyen set permission = @permision where TenDangNhap = @user;
	end
END;

GO
/****** Object:  StoredProcedure [dbo].[TimSanPham]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Drop proc DanhMucSanPhamKemAnh

------------------------------Tim san pham
create PROC	[dbo].[TimSanPham](@ID int, @Ten nvarchar(100))
as
	select HangHoa.MaHH,Ten,LoaiHangHoa.MaLoai,TenLoai,GiaNhap,GiaBan,SoLuong from HangHoa inner join LoaiHangHoa on HangHoa.MaLoai = LoaiHangHoa.MaLoai 
	inner join QuanLyHangHoa on QuanLyHangHoa.MaHH = HangHoa.MaHH where HangHoa.activated = 1 and (HangHoa.MaHH = @ID or HangHoa.Ten like ConCat('%',@Ten,'%'))

GO
/****** Object:  StoredProcedure [dbo].[XoaSanPham]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------Xoa san pham
create PROC [dbo].[XoaSanPham] 
(@ID int)
AS
BEGIN
	delete from HangHoaIMG where MaHH = @ID;
	update HangHoa set activated = 0 where MaHH = @ID;
END;

GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 4/29/2021 9:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop proc TimSanPham
-------------------------------XoaTaiKhoan
create PROC [dbo].[XoaTaiKhoan] 
(@user char(100))
AS
BEGIN
	if not exists(select * from TaiKhoan inner join PhanQuyen on TaiKhoan.TenDangNhap = PhanQuyen.TenDangNhap
	where TaiKhoan.TenDangNhap = @user and permission = N'Admin')
		delete from TaiKhoan where TenDangNhap = @user;
END;

GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHoa] SET  READ_WRITE 
GO
