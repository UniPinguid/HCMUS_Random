CREATE DATABASE ONLINE_STORE
GO

USE ONLINE_STORE
GO

CREATE TABLE DOITAC(
  ID CHAR(8) not null,
  Ten NVARCHAR(30),
  DaiDien NVARCHAR(8),
  ThanhPho NVARCHAR(24),
  SoChiNhanh INT,
  SLDonHang INT,
  LoaiHang NVARCHAR(20),
  DiaChi NVARCHAR(50),
  SoDienThoai CHAR(10),
  Email CHAR(50)
)

CREATE TABLE HOPDONG (
  ID char(8) not null,
  DoiTacID CHAR(8) not null,
  TenNguoiDD NVARCHAR(30),
  SoChiNhanhDK INT,
  DiaChi NVARCHAR(50),
  NgayLap DATETIME,
  HieuLuc DATETIME,
  PhiHoaHong FLOAT
)

CREATE TABLE SANPHAM (
  ID CHAR(8) not null,
  TenSP NVARCHAR(30),
  ChiNhanhID CHAR(8) not null,
  Gia INT
)

CREATE TABLE CHINHANH (
  ID CHAR(8) not null,
  DiaChi NVARCHAR(50)
)

CREATE TABLE KHACHHANG (
  ID CHAR(8) not null,
  HoTen NVARCHAR(50),
  DienThoai CHAR(10),
  DiaChi NVARCHAR(50),
  Email VARCHAR(30)
)

CREATE TABLE DATHANG (
  KhachHangID CHAR(8) not null,
  DoiTacID CHAR(8) not null,
  DonHangID CHAR(8) not null,
  NgayDat DATETIME
)

CREATE TABLE DONHANG (
  DonHangID CHAR(8) not null,
  TongGia int,
  HinhThucTT BIT,
  DiaChi NVARCHAR(50),
  TinhTrang int
)

CREATE TABLE CT_DONHANG (
	SanPhamID CHAR(8) not null,
	DonHangID char(8) not null,
	SoLuong INT
)

CREATE TABLE TAIXE (
	ID char(8) not null,
	hoten nvarchar(50),
	CMND char(10),
	Dienthoai char(10),
	Diachi nvarchar(50),
	Soxe char(10),
	Khuvuc char(20),
	Taikhoan char(20),
)

CREATE TABLE TX_DH (
	TaixeID char(8) not null,
	DonhangID char(8) not null,
	NgayGiaoHang DATETIME,
	Phivanchuyen int,
)
go

CREATE TABLE NGUOIDUNG (
  Username char(8) not null,
  Password char(32) not null,
  DoiTacID char(8),
  KhachHangID char(8),
  TaiXeID char(8),
  NhanVienID char(8),
  QuanTriID char(8),
  Role int not null
)

CREATE TABLE NHANVIEN (
	NhanVienID char(8) not null,
	TenNV nvarchar(50) not null,
)
go

CREATE TABLE QUANTRI (
	QuanTriID char(8) not null,
	TenQTV nvarchar(50) not null,
)
go

-------------------------------------------------------PK
alter table doitac
add constraint DTID_PK primary key (ID)
go

alter table hopdong
add constraint HDID_IDDT_PK primary key (ID,DoitacID)
go

alter table sanpham
add constraint SPID_PK primary key (ID)
go

alter table chinhanh
add constraint CNID_PK primary key (ID)
go

alter table khachhang
add constraint KHID_PK primary key (ID)
go

alter table dathang
add constraint DatHangInfo_PK primary key (KhachHangID, DoiTacID, DonHangID)
go

alter table ct_donhang
add constraint DHID_SPID_PK primary key (DonHangID, sanphamID)
go

alter table donhang
add constraint DHID_PK primary key (DonHangID)
go


alter table taixe
add constraint TXID_PK primary key (ID)
go

alter table tx_dh
add constraint TXDH_PK primary key (TaixeID, DonhangID)
go

alter table nhanvien
add constraint NVID_PK primary key (NhanVienID)

alter table quantri
add constraint QTID_PK primary key (QuanTriID)

alter table NGUOIDUNG
add constraint USERID_PK primary key (Username)

------------------------------------------------------------------------------------FK

alter table hopdong
add constraint HD_DTID_FK foreign key (DoitacID) references Doitac(ID)
go


alter table dathang
add constraint DH_KHID_FK foreign key (KhachhangID) references KhachHang(ID)
go
alter table dathang
add constraint DH_DTID_FK foreign key (DoitacID) references Doitac(ID)
go
alter table dathang
add constraint DH_DHID_FK foreign key (DonHangID) references DonHang(DonHangID)
go

alter table tx_dh
add constraint txdh_txid_FK foreign key (taixeID) references taixe(ID)
go

alter table tx_dh
add constraint txdh_dhid_FK foreign key (donhangID) references Donhang(DonHangID)
go

alter table ct_donhang
add constraint ctdh_dhid_FK foreign key (DonHangID) references Donhang(DonHangID)
go

alter table ct_donhang
add constraint ctdh_spid_FK foreign key (SanPhamID) references sanpham(ID)
go

alter table sanpham
add constraint sp_cnID_FK foreign key (chinhanhid) references chinhanh(ID)
go

alter table NGUOIDUNG
add constraint userID_doitacID_FK foreign key (DoiTacID) references DoiTac(ID)
go

alter table NGUOIDUNG
add constraint userID_khachhangID_FK foreign key (KhachHangID) references KhachHang(ID)
go

alter table NGUOIDUNG
add constraint userID_taixeID_FK foreign key (TaiXeID) references TaiXe(ID)
go

alter table NGUOIDUNG
add constraint userID_NhanvienID_FK foreign key (NhanVienID) references NhanVien(NhanVienID)
go

alter table NGUOIDUNG
add constraint userID_QuanTriID_FK foreign key (QuanTriID) references QuanTri(QuanTriID)
go

-- Chỉnh sửa lại bảng NGUOIDUNG
	-- Nếu là đối tác
		update NGUOIDUNG
		set KhachHangID = NULL, 
		    TaiXeID = NULL,
		    NhanVienID = NULL,
		    QuanTriID = NULL
		where NguoiDung.Role = 0
		go
		
	-- Nếu là khách hàng
		update NGUOIDUNG
		set DoiTacID = NULL, 
		    TaiXeID = NULL,
		    NhanVienID = NULL,
		    QuanTriID = NULL
		where NguoiDung.Role = 1
		go
	
	-- Nếu là tài xế
		update NGUOIDUNG
		set DoiTacID = NULL, 
		    KhachHangID = NULL,
		    NhanVienID = NULL,
		    QuanTriID = NULL
		where NguoiDung.Role = 2
		go
	
	-- Nếu là nhân viên
		update NGUOIDUNG
		set DoiTacID = NULL, 
		    KhachHangID = NULL,
		    TaiXeID = NULL,
		    QuanTriID = NULL
		where NguoiDung.Role = 3
		go
	
	-- Nếu là quản trị
		update NGUOIDUNG
		set DoiTacID = NULL, 
		    KhachHangID = NULL,
		    TaiXeID = NULL,
		    NhanVienID = NULL
		where NguoiDung.Role = 4
		go
