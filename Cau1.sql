CREATE DATABASE QuanLyBanHang
GO
USE QuanLyBanHang
GO

CREATE TABLE KhachHang (
	MaKH         CHAR(7) NOT NULL,
	Ho           NVARCHAR(6),
	Ten          NVARCHAR(6),
	Ngsinh       DATETIME,
	SoNha        NVARCHAR(8),
	Duong        NVARCHAR(24),
	Phuong       NVARCHAR(24),
	QUAN         NVARCHAR(24),
	ThanhPho     NVARCHAR(24),
	DienThoai    CHAR(11),
)
GO

CREATE TABLE HoaDon (
	MaHD         CHAR(7) not null,
	MaKH         CHAR(7),
	NgayLap      DATETIME,
	TongTien     FLOAT,
)
GO

CREATE TABLE CT_HoaDon (
	MaHD         CHAR(7) not null,
	MaSP         CHAR(5) not null,
	SoLuong      INT,
	GiaBan       FLOAT,
	GiaGiam      FLOAT,
	ThanhTien    FLOAT,
)
GO

CREATE TABLE SanPham (
	MaSP         CHAR(5) not null,
	TenSP        NVARCHAR(50),
	SoLuongTon   INT, 
	Mota         NVARCHAR(50),
	Gia          FLOAT
)

go
alter table KhachHang
add constraint MaKH_PK primary key (MaKH)

go
alter table HoaDon
add constraint MaHD_PK primary key (MaHD)

go
alter table CT_HoaDon
add constraint HDSP_PK primary key(MaHD, MaSP)

go
alter table SanPham
add constraint MaSP_PK primary key (MaSP)

go
alter table HoaDon
add constraint HD_MaKH_FK foreign key (MaKH) references KhachHang(MaKH)

go
alter table CT_HoaDon
add constraint CT_HoaDon_HoaDon_FK foreign key (MaHD) references HoaDon(MaHD)

go
alter table CT_HoaDon
add constraint CT_HoaDon_SP_FK foreign key (MaSP) references SanPham(MaSP)

-- 8:57AM 7/10/2021 (UniPinguid)
--   + Line 11: changes from "SoNha NVARCHAR(20)," to "SoNha NVARCHAR(8),"
--   + Line 15: changes Tpho to ThanhPho
--
--   + Reformatted database tables creation for enhanced visual view
--   + Small adjustment in attribute's naming 
