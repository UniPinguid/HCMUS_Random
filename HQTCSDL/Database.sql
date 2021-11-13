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
  NgayLap DATETIME
  HieuLuc DATETIME
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
)

CREATE TABLE DONHANG (
  ID CHAR(8) not null,
  TongGia int,
  HinhThucTT BIT,
  DiaChi NVARCHAR(50)
)

CREATE TABLE CT_DONHANG (
	ID char(8) not null,
	SanPhamID CHAR(8) not null,
	SoLuong INT,
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
	Phivanchuyen int,
)
go

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
add constraint DHID_SPID_PK primary key (ID, sanphamID)
go

alter table donhang
add constraint DHID_PK primary key (ID)
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
add constraint DH_DHID_FK foreign key (DonHangID) references DonHang(ID)
go



alter table tx_dh
add constraint txdh_txid_FK foreign key (taixeID) references taixe(ID)
go

alter table tx_dh
add constraint txdh_dhid_FK foreign key (donhangID) references Donhang(ID)
go

alter table ct_donhang
add constraint ctdh_dhid_FK foreign key (ID) references Donhang(ID)
go

alter table ct_donhang
add constraint ctdh_spid_FK foreign key (ID) references sanpham(ID)
go


alter table sanpham
add constraint sp_cnID_FK foreign key (chinhanhid) references chinhanh(ID)
go
