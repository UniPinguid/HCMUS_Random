CREATE DATABASE QuanLyBanHang
GO
USE QuanLyBanHang
GO

CREATE TABLE KhachHang (
	makH CHAR(7),
	Ho NVARCHAR(6),
	Ten NVARCHAR(6),
	Ngsinh DATETIME,
	SoNha NVARCHAR(20),
	Duong NVARCHAR(24),
	Phuong NVARCHAR(24),
	QUAN NVARCHAR(24),
	Tpho NVARCHAR(24),
	DienThoai CHAR(11),
)
GO
CREATE TABLE HoaDon (
	MaHD CHAR(7),
	MaKH CHAR(7),
	NgayLap DATETIME,
	TongTien FLOAT,
)
GO
CREATE TABLE CT_HoaDon (
	MaHD CHAR(7),
	MaSP CHAR(5),
	SoLuong INT,
	GiaBan FLOAT,
	GiaGiam FLOAT,
	ThanhTien FLOAT,
)
GO
CREATE TABLE SanPham (
	MaSP CHAR(5),
	TenSP NVARCHAR(50),
	SoLuongTon INT,
	Mota NVARCHAR(50),
	Gia FLOAT
)

