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
	Tpho         NVARCHAR(24),
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
create trigger TinhThanhTien_Insert
on CT_HoaDon
after INSERT as
begin 
    update CT_HoaDon
	  set CT_HoaDon.ThanhTien = round(a.SoLuong * (a.GiaBan - a.GiaGiam),-3)
    FROM CT_HoaDon a INNER JOIN INSERTED i
    ON i.MaHD = a.MaHD

    update HoaDon
	  set HoaDon.TongTien += round(i.SoLuong * (i.GiaBan - i.GiaGiam), -3)
    FROM HoaDon b inner JOIN inserted i
    ON i.MaHD = b.MaHD
end
GO

-- Test data --
--
--INSERT INTO SanPham (MaSP, TenSP, SoLuongTon, Mota, Gia) VALUES ('123', 'Tôm', 3, 'Sống', 75000)
--INSERT INTO SanPham (MaSP, TenSP, SoLuongTon, Mota, Gia) VALUES ('234', 'Cua', 7, 'Sống', 50000)
--GO
--
--INSERT INTO KhachHang (MaKH, Ho, Ten, Ngsinh, SoNha, Duong, Phuong, Quan, Tpho, DienThoai) VALUES ('ABCD', N'Lê', N'Khai', '01/24/2001', '82', N'Trần Nhuận', N'Mỹ Phú', NULL, N'Đồng Tháp', '091231231')
--GO
--
--INSERT INTO HoaDon (MaHD, MaKH, NgayLap, TongTien) VALUES ('BUH123', 'ABCD', '01/01/2020', 0)
--INSERT INTO HoaDon (MaHD, MaKH, NgayLap, TongTien) VALUES ('FFF111', 'ABCD', '01/02/2020', 0)
--GO
--
--INSERT INTO CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien) VALUES ('BUH123', '123', 2, 75000, 3000, 0)
--INSERT INTO CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien) VALUES ('BUH123', '234', 2, 50000, 5000, 0)
--GO
--
--INSERT INTO CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien) VALUES ('FFF111', '123', 5, 75000, 3000, 0)
--INSERT INTO CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien) VALUES ('FFF111', '234', 3, 50000, 8000, 0)
--GO
--
--DELETE CT_HoaDon WHERE MaSP = '123' AND MaHD = 'BUH123'

-- Truy vấn --
 
-- a. Cho danh sách các hoá đơn lập trong năm 2020--
select * 
from HoaDon 
where (select year(NgayLap)) = 2020

--b. Cho danh sách các khách hàng ở TPHCM--
select * 
from KhachHang 
where Tpho = 'Thành phố Hồ Chí Minh'

--c. Cho danh sách các sản phẩm có giá trong một khoảng từ 1000000 đến 2000000 --
select *
from SanPham
where Gia >= 1000000 and Gia <= 2000000

--d. Cho danh sách các sản phẩm có số lượng tồn <100 --
select *
from SanPham
where SoLuongTon < 100

--e. Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất) --

select a.MaSP, sp.TenSP, a.SoLuong
from CT_HoaDon a, SanPham sp
where a.MaSP = sp.MaSP AND a.SoLuong >= all( select b.SoLuong 
                                             from CT_HoaDon b
                                             WHERE b.MaSP = a.MaSP)
ORDER BY a.SoLuong DESC



select SP.MaSP, SP.TenSP ,sum(CT.SoLuong) as SoLuongBanHang
from SanPham SP, CT_HoaDon CT
where SP.MaSP = CT.MaSP
group by SP.MaSP, SP.TenSP
having sum(SoLuong) >= all( select sum(SoLuong) 
			    from CT_HoaDon 
			    group by MaSP )
			    
			    
			    
SELECT ct.MaSP, sp.TenSP, SUM(ct.SoLuong) as N'Tổng số lượng bán'
FROM CT_HoaDon ct, SanPham sp
WHERE ct.MaSP=sp.MaSP
GROUP BY ct.MaSP, ct.SoLuong,sp.TenSP
HAVING SUM(ct.SoLuong) >= ALL (SELECT SUM(ct1.SoLuong)
								FROM CT_HoaDon ct1
								GROUP BY ct1.MaSP,ct1.SoLuong)

			  
			  
			  
			  
--f. Cho danh sách các sản phẩm có doanh thu cao nhất--

select a.MaSP, sp.TenSP, a.ThanhTien
from CT_HoaDon a, SanPham sp
where a.MaSP = sp.MaSP AND a.ThanhTien >= all( select ThanhTien 
                                               from CT_HoaDon b
                                               WHERE b.MaSP = a.MaSP)
ORDER BY a.ThanhTien DESC





select SP.MaSP, SP.TenSP ,sum(CT.ThanhTien) as DoanhThu
from SanPham SP, CT_HoaDon CT
where SP.MaSP = CT.MaSP
group by SP.MaSP, SP.TenSP
having sum(CT.ThanhTien) >= all( select sum(ThanhTien) 
				 from CT_HoaDon 
				 group by MaSP )



SELECT ct.MaSP, sp.TenSP, SUM(ct.ThanhTien) as N'Doanh thu'
FROM CT_HoaDon ct, SanPham sp
WHERE ct.MaSP=sp.MaSP
GROUP BY ct.MaSP, sp.TenSP,ct.ThanhTien
HAVING SUM(ct.ThanhTien)>=ALL(SELECT SUM(ct1.ThanhTien)
								FROM CT_HoaDon ct1
								GROUP BY ct1.MaSP,ct1.ThanhTien)

-- CHANGES HISTORY
--
-- 8:57AM 7/10/2021 (UniPinguid)
--   + Line 11: changed from "SoNha NVARCHAR(20)," to "SoNha NVARCHAR(8),"
--   + Reformatted database tables creation for enhanced visual view
--   + Small adjustment in attribute's naming 
--
--
-- 10:28AM 8/10/2021 (UniPinguid)
--   + Changed data type [Ho] in KhachHang table into a 15-character-long string.
--   + Created receipt total cost triggers
--
-- 6:10PM 9/10/2021 (UniPinguid)
--   + Renamed TinhTongHoaDon trigger to TinhTongHoaDon_Insert, for additional option in optimizing database.
--     + Specifically, created a new delete trigger TinhTongHoaDon_Delete
--   + Fixed up conditional expressions in TinhTongHoaDon_Insert
--
-- 8:29PM 9/10/2021 (UniPinguid)
--   + Aggregated all triggers into a single trigger "TinhTongTien" including all possible insert, update, and delete calls.
--
-- 7:41AM 11/10/2021 (UniPinguid)
--   + Added alternatives for the last two queries for optimal finalization.
--
-- 12:21PM 11/10/2021 (UniPinguid)
--   + Resolved an issue where insert cases cause runtime drop for every set of value inserted.
