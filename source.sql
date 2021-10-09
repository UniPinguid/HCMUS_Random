CREATE DATABASE QuanLyBanHang
GO
USE QuanLyBanHang
GO

CREATE TABLE KhachHang (
	MaKH         CHAR(7) NOT NULL,
	Ho           NVARCHAR(15),
	Ten          NVARCHAR(6),
	Ngsinh       DATETIME,
	SoNha        NVARCHAR(8),
	Duong        NVARCHAR(24),
	Phuong       NVARCHAR(24),
	Quan         NVARCHAR(24),
	Tpho     NVARCHAR(24),
	DienThoai    CHAR(11)
)
GO

CREATE TABLE CT_HoaDon (
	MaHD         CHAR(7) not null,
	MaSP         CHAR(5) not null,
	SoLuong      INT,
	GiaBan       FLOAT,
	GiaGiam      FLOAT,
	ThanhTien    FLOAT
)
GO

CREATE TABLE HoaDon (
	MaHD         CHAR(7) not null,
	MaKH         CHAR(7),
	NgayLap      DATETIME,
	TongTien     FLOAT
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
go

-- Triggers --

-- Tính thành tiền ở mỗi chi tiết hóa đơn
create trigger TinhThanhTien
on CT_HoaDon
after insert as
begin 
    update CT_HoaDon
	set ThanhTien = SoLuong * (GiaBan - GiaGiam);
end
GO

-- Tính tổng tiền ở trên hóa đơn khi thêm một chi tiết hóa đơn
create trigger TinhTongHoaDon
on CT_HoaDon
after insert as
begin 
    update HoaDon
	set TongTien = (select sum(a.ThanhTien)
	               from CT_HoaDon as a)
end
GO

-- Insert KhachHang
insert into KhachHang (MaKH, Ho, Ten, Ngsinh, SoNha, Duong, Phuong, Quan, Tpho, DienThoai)
       values ('NVA', N'Nguyễn Văn', N'Mười', '01/24/2001', N'81', N'Ngô Thì Nhậm', N'Mỹ Phú', '1', N'Hồ Chí Minh', '0912445662')

-- Insert SanPham
insert into SanPham (MaSP, TenSP, SoLuongTon, Mota, Gia)
	   values ('ABCD', 'Thùng kem', 23, 'To bự', 20000)
insert into SanPham (MaSP, TenSP, SoLuongTon, Mota, Gia)
	   values ('EBDA', 'Hộp thịt bò', 55, 'Hộp hình tròn', 50000)
	   
-- Insert HoaDon
insert into HoaDon (MaHD, MaKH, NgayLap, TongTien)
       values ('0123', 'NVA', '12/23/1999', NULL)

-- Insert CT_HoaDon
insert into CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien)
       values ('0123', 'ABCD', 2, 5000, 1, NULL) 
insert into CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien)
       values ('0123', 'EBDA', 3, 1250, 2, NULL)
      
       
       
 -- Truy  vấn --
 
-- a. Cho danh sách các hoá đơn lập trong năm 2020--
select * 
from HoaDon 
where (select year(NgayLap)) = 2020

--b. Cho danh sách các khách hàng ở TPHCM--
select * 
from KhachHang 
where Tpho = 'TPHCM'

--c. Cho danh sách các sản phẩm có giá trong một khoảng từ 1000000 đến 2000000 --
select *
from SanPham
where Gia >= 1000000 and Gia <= 2000000

--d. Cho danh sách các sản phẩm có số lượng tồn <100 --
select *
from SanPham
where SoLuongTon < 100

--e. Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất) --
select *
from CT_HoaDon
where SoLuong >= all( select SoLuong from CT_HoaDon  )

--f. Cho danh sách các sản phẩm có doanh thu cao nhất--
select *
from CT_HoaDon
where ThanhTien >= all( select ThanhTien from CT_HoaDon)

-- CHANGES HISTORY
--
-- 8:57AM 7/10/2021 (UniPinguid)
--   + Line 11: changes from "SoNha NVARCHAR(20)," to "SoNha NVARCHAR(8),"
--
--   + Reformatted database tables creation for enhanced visual view
--   + Small adjustment in attribute's naming 
--
--
-- 10:28AM 8/10/2021 (UniPinguid)
--   + Changes data type [Ho] in KhachHang table into a 15-character-long string.
--   + Creates receipt total cost triggers
