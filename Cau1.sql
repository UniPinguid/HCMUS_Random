CREATE DATABASE QuanLyBanHang
GO
USE QuanLyBanHang
GO

CREATE TABLE KhachHang (
	makH CHAR(7) NOT NULL,
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
	MaHD CHAR(7) not null,
	MaKH CHAR(7),
	NgayLap DATETIME,
	TongTien FLOAT,
)
GO
CREATE TABLE CT_HoaDon (
	MaHD CHAR(7) not null,
	MaSP CHAR(5) not null,
	SoLuong INT,
	GiaBan FLOAT,
	GiaGiam FLOAT,
	ThanhTien FLOAT,
)
GO
CREATE TABLE SanPham (
	MaSP CHAR(5) not null,
	TenSP NVARCHAR(50),
	SoLuongTon INT, 
	Mota NVARCHAR(50),
	Gia FLOAT
)


go
alter table KhachHang
add constraint makH_pk primary key (makH)

go
alter table Hoadon
add constraint mahd_pk primary key (mahd)

go
alter table ct_hoadon
add constraint hdsp_pk primary key(mahd,masp)

go
alter table sanpham
add constraint masp_pk primary key (masp)

go
alter table Hoadon
add constraint hd_makh_fk foreign key (makh) references khachhang(makh)

go
alter table ct_hoadon
add constraint ct_hoadon_hoadon_fk foreign key (mahd) references hoadon(mahd)

go
alter table ct_hoadon
add constraint ct_hoadon_sp_fk foreign key (masp) references sanpham(masp)
