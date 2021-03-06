USE ONLINE_STORE
GO

-- Hằng tháng đối tác phải trả phí hoa hồng bằng 10% doanh số bán tháng trước đó.
CREATE PROCEDURE CAPNHATHOAHONG @doitacid CHAR(8)
AS
BEGIN
  DECLARE @thismonth INT
  SET @thismonth = MONTH(GETDATE())

  DECLARE @thisyear INT
  SET @thisyear = YEAR(GETDATE())

  DECLARE @previousyear INT
  DECLARE @previousmonth INT

  IF (@previousmonth < 1) 
    BEGIN
      SET @previousmonth = 12
      SET @previousyear = @thisyear - 1
    END
  ELSE 
    BEGIN
      SET @previousmonth = @thismonth - 1
      SET @previousyear = @thisyear
    END

  DECLARE @phh FLOAT
  SET @phh = (SELECT SUM(d.TongGia)
              FROM DONHANG d, DATHANG dh, TX_DH tx
              WHERE d.DonHangID = dh.DonHangID AND dh.DoiTacID = @doitacid AND tx.DonhangID = dh.DonHangID AND
                    MONTH(tx.NgayGiaoHang) = @previousmonth AND YEAR(tx.NgayGiaoHang) = @previousyear
              GROUP BY dh.DoiTacID)

  UPDATE HOPDONG
  SET HOPDONG.PhiHoaHong = @phh * 10 / 100
  WHERE HOPDONG.DoiTacID = @doitacid
END
GO

-- Đăng nhập
CREATE PROC loginProcess @username CHAR(32), @password CHAR(32)
AS
begin
  SELECT *
  FROM NGUOIDUNG u
  WHERE u.Username = @username AND u.Password = @password
end
GO

-- Xuất thông tin đối tác
CREATE PROC getPartner @id CHAR(8)
as
begin
  SELECT *
  FROM DOITAC d
  WHERE d.ID = @id
end
GO

-- Xuất thông tin khách hàng
CREATE PROC getCustomer @id CHAR(8)
as
begin
  SELECT *
  FROM KHACHHANG k
  WHERE k.ID = @id
end
GO

-- Xuất thông tin tài xế
CREATE PROC getShipper @id CHAR(8)
as
begin
  SELECT *
  FROM TAIXE t
  WHERE t.ID = @id
end
GO

-- Xuất thông tin nhân viên
CREATE PROC getEmployee @id CHAR(8)
as
begin
  SELECT *
  FROM NHANVIEN n
  WHERE n.NhanVienID = @id
end
GO

-- Xuất thông tin quản trị viên
CREATE PROC getAdmin @id CHAR(8)
as
begin
  SELECT *
  FROM QUANTRI q
  WHERE q.QuanTriID = @id
end
GO

-- Xuất danh sách đơn hàng chưa được tiếp nhận
CREATE PROC getOrderPending @search NVARCHAR(50)
as
begin
  SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán'
  FROM DONHANG d, DATHANG h
  WHERE d.DonHangID = h.DonHangID
        AND d.TinhTrang = 0
        AND (h.KhachHangID like '%'+@search+'%'
        OR h.DoiTacID like '%'+@search+'%' OR d.DiaChi like N'%'+@search+'%')
end
GO

-- Xuất danh sách đơn hàng mà tài xế đó đã tiếp nhận
CREATE PROC getOrderTaken @id CHAR(8), @search NVARCHAR(50)
as
begin
  SELECT t.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.PhiVanChuyen as N'Phí vận chuyển', 
         d.HinhThucTT as N'Hình thức thanh toán', d.TinhTrang as N'Tình trạng'
  FROM TX_DH t, DONHANG d, DATHANG h
  WHERE t.DonhangID = d.DonHangID AND d.DonHangID = h.DonHangID
        and t.TaixeID = @id and (t.DonhangID like '%'+@search+'%' or t.TaixeID like '%'+@search+'%'
        or d.DiaChi like '%'+@search+'%' or h.KhachHangID like '%'+@search+'%')
end
GO

-- Xuất danh sách đơn hàng mà khách hàng đã đặt
CREATE PROC getOrderCustomer @id CHAR(8)
as
begin
  SELECT d.DonHangID as N'Mã đơn hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
         d.TinhTrang as N'Tình trạng'
  FROM DONHANG d, DATHANG h
  WHERE d.DonHangID = h.DonHangID
        and h.KhachHangID = @id and d.TinhTrang <> -1
end
GO

-- Xuất ra danh sách chi tiết hóa đơn trong hóa đơn đặt hàng
CREATE PROC getDetailsFromOrder @id CHAR(8)
as
begin
	SELECT ct.SanPhamID as N'Mã sản phẩm', s.TenSP as 'Tên sản phẩm', s.Gia as 'Đơn giá', ct.SoLuong as 'Số lượng', ThanhTien = s.Gia * ct.SoLuong
	FROM DONHANG d, CT_DONHANG ct, SANPHAM s
	WHERE d.DonHangID = @id and d.DonHangID = ct.DonHangID
	      and s.ID = ct.SanPhamID
end
go

-- In ra tổng tiền hóa đơn, phí vận chuyển, tổng tiền đơn hàng, tổng số lượng
CREATE PROC getOrderTotal @id CHAR(8)
as
begin
	SELECT d.TongGia, d.PhiVanChuyen, TongHoaDon = d.TongGia + d.Phivanchuyen, TongSL = COUNT(ct.SanPhamID)
	FROM DONHANG d, CT_DONHANG ct
	WHERE d.DonHangID = ct.DonHangID
	      and d.DonHangID = @id
	GROUP BY d.TongGia, d.PhiVanChuyen
end
go



-- Xuất ra danh sách các đôi tác
CREATE PROC getPartnerList @search NVARCHAR(50)
as
begin
	SELECT d.ID as N'Mã đối tác', d.Ten as N'Tên', d.TenNguoiDD as 'Mã người đại diện', d.ThanhPho as N'Tỉnh thành',
	       d.DiaChi as N'Địa chỉ', d.SoChiNhanh as N'Số chi nhánh', d.SoDienThoai as N'Số điện thoại',
	       d.Email, d.LoaiHang as N'Loại hàng', d.SLDonHang as N'Số lượng đơn hàng mỗi ngày'
	FROM DOITAC d
	WHERE d.ID like '%'+@search+'%' OR d.Ten like N'%'+@search+'%'
        OR d.TenNguoiDD like N'%'+@search+'%' OR d.ThanhPho like N'%'+@search+N'%'
        OR d.DiaChi like N'%'+@search+N'%' OR d.SoChiNhanh like '%'+@search+'%'
        OR d.Email like '%'+@search+'%' OR d.LoaiHang like N'%'+@search+N'%'
end
go

-- Xuất ra danh sách hợp đồng
create PROC getContractList @id CHAR(8), @search NVARCHAR(50)
as
begin
	SELECT h.ID as N'Mã hợp đồng', h.TenNguoiDD as N'Tên người đại diện',
	       h.DiaChi as N'Địa chỉ', h.NgayLap as N'Ngày lập', h.HieuLuc as N'Hiệu lực', h.PhiHoaHong as N'Phí hoa hồng'
	FROM HOPDONG h, DOITAC d
	WHERE h.DoiTacID = d.ID and h.DoiTacID = @id and
	      (h.DoiTacID like '%'+@search+'%' OR h.TenNguoiDD like '%'+@search+'%' OR h.SoChiNhanhDK like '%'+@search+'%'
	       OR h.NgayLap like '%'+@search+'%' or h.HieuLuc like '%'+@search+'%' or h.PhiHoaHong like '%'+@search+'%')
end
go

update HOPDONG
set HieuLuc = NULL
where DoiTacID = 'DT925312'

-- Xuất ra danh sách tài khoản
CREATE PROC getUserList @search NVARCHAR(50), @role int
as
begin
	IF (@role = 0) 
	   SELECT u.Username as N'Tên đăng nhập', u.Password as N'Mật khẩu', u.DoiTacID as N'Mã đối tác' , d.SoDienThoai as N'Số điện thoại', d.Email as N'Email'
	   FROM NGUOIDUNG u, DOITAC d
	   WHERE @role = u.Role and u.DoiTacID = d.ID
	         and (u.Username like '%'+@search+'%' or u.Password like '%'+@search+'%' or u.DoiTacID like '%'+@search+'%')
	
	IF (@role = 1) 
	   SELECT u.Username as N'Tên đăng nhập', u.Password as N'Mật khẩu', u.KhachHangID as N'Mã khách hàng', k.DienThoai as N'Số điện thoại', k.Email as N'Email'
	   FROM NGUOIDUNG u, KHACHHANG k
	   WHERE @role = u.Role and u.KhachHangID = k.ID
	         and (u.Username like '%'+@search+'%' or u.Password like '%'+@search+'%' or u.KhachHangID like '%'+@search+'%')

	IF (@role = 2) 
	   SELECT u.Username as N'Tên đăng nhập', u.Password as N'Mật khẩu', u.TaiXeID as N'Mã tài xế', t.Dienthoai as N'Số điện thoại', t.Soxe as N'Biển số xe'
	   FROM NGUOIDUNG u, TAIXE t
	   WHERE @role = u.Role and u.TaiXeID = t.ID
	         and (u.Username like '%'+@search+'%' or u.Password like '%'+@search+'%' or u.TaiXeID like '%'+@search+'%')

	IF (@role = 3) 
	   SELECT u.Username as N'Tên đăng nhập', u.Password as N'Mật khẩu', u.NhanVienID as N'Mã nhân viên', n.SoDienThoai as N'Số điện thoại', n.Email as N'Email'
	   FROM NGUOIDUNG u, NHANVIEN n
	   WHERE @role = u.Role and u.NhanVienID = n.NhanVienID
	         and (u.Username like '%'+@search+'%' or u.Password like '%'+@search+'%' or u.NhanVienID like '%'+@search+'%')

	IF (@role = 4) 
	   SELECT u.Username as N'Tên đăng nhập', u.Password as N'Mật khẩu', u.QuanTriID as N'Mã quản trị viên', q.SoDienThoai as N'Số điện thoại', q.Email as N'Email'
	   FROM NGUOIDUNG u, QUANTRI q
	   WHERE @role = u.Role and u.QuanTriID = q.QuanTriID
	         and (u.Username like '%'+@search+'%' or u.Password like '%'+@search+'%' or u.QuanTriID like '%'+@search+'%')
end
go

-- Xuất ra danh sách sản phẩm thuộc đối tác
CREATE PROC getProductPartner @partnerID CHAR(8), @search NVARCHAR(50)
as
begin
	SELECT distinct sp.ID as 'Mã sản phẩm', sp.TenSP as 'Tên sản phẩm', sp.Gia as 'Đơn giá'
	FROM SANPHAM sp, CHINHANH c, DOITAC d
	WHERE (sp.ChiNhanhID = c.ID and c.ID = d.SoChiNhanh and d.ID = @partnerID)
	      AND (sp.ID like '%'+@search+'%' or sp.TenSP like N'%'+@search+N'%' or sp.Gia like '%'+@search+'%')
end
go

-- Tạo đơn hàng rỗng
CREATE PROC createEmptyOrder @KhachHangID CHAR(8), @DoiTacID CHAR(8), @RandomDonHangID CHAR(8)
as
begin
	INSERT INTO DONHANG(DonHangID,DiaChi,HinhThucTT,TongGia,TinhTrang)
	       values (@RandomDonHangID, NULL, 0, 0, -1)
	INSERT INTO DATHANG(DonHangID, DoiTacID, KhachHangID, NgayDat)
	       values (@RandomDonHangID, @DoiTacID, @KhachHangID, GETDATE())
end
go

-- Xóa đơn hàng
CREATE PROC removeOrder @DonHangID CHAR(8)
as
begin
	DELETE FROM CT_DONHANG
	WHERE DonHangID = @DonHangID
	
	DELETE FROM DATHANG
	WHERE DonHangID = @DonHangID
	
	DELETE FROM DONHANG
	WHERE DonHangID = @DonHangID
end
go

-- Thêm sản phẩm vào đơn hàng
CREATE PROC addProductToCart @KhachHangID CHAR(8), @DoiTacID CHAR(8), @DonHangID CHAR(8), @SPID CHAR(8), @SoLuong INT
as
begin
	INSERT INTO CT_DONHANG(DonHangID, SanPhamID, SoLuong)
	       values (@DonHangID, @SPID, @SoLuong)
end
go

-- Xóa một sản phẩm ra khỏi đơn hàng
CREATE PROC removeProductFromCart @DonHangID CHAR(8), @SanPhamID CHAR(8)
as
begin
	DELETE FROM CT_DONHANG
	WHERE DonHangID = @DonHangID and SanPhamID = @SanPhamID
end
go

-- Tạo người dùng mới với tư cách là đối tác
CREATE PROC addPartner @DoiTacID CHAR(8), @Ten NVARCHAR(30), @TenDD NVARCHAR(50), @ThanhPho NVARCHAR(24),
                       @SoChiNhanh CHAR(8), @SLDonHang INT, @LoaiHang NVARCHAR(20), @DiaChi NVARCHAR(50),
                       @SDT CHAR(10), @email CHAR(50), @username CHAR(32), @password CHAR(32)
as
begin
	INSERT INTO DOITAC(ID, Ten, TenNguoiDD, ThanhPho, SoChiNhanh, SLDonHang, LoaiHang, DiaChi, SoDienThoai, Email)
	       values (@DoiTacID, @Ten, @TenDD, @ThanhPho, @SoChiNhanh, @SLDonHang, @LoaiHang, @DiaChi, @SDT, @email)
	       
	INSERT INTO NGUOIDUNG(Username, Password, DoiTacID, KhachHangID, TaiXeID, NhanVienID, QuanTriID, Role)
	       values (@username, @password, @DoiTacID, NULL, NULL, NULL, NULL, 0)
end
go

-- Tạo người dùng mới với tư cách là khách hàng
CREATE PROC addCustomer @KhachHangID CHAR(8), @Ten NVARCHAR(50), @SDT CHAR(10), @email varchar(30),
                        @DiaChi NVARCHAR(50), @username CHAR(32), @password CHAR(32)
as
begin
	INSERT INTO KHACHHANG(ID, HoTen, DienThoai, Email, DiaChi)
	       VALUES (@KhachHangID, @Ten, @SDT, @email, @DiaChi)
	       
	INSERT INTO NGUOIDUNG(Username, Password, DoiTacID, KhachHangID, TaiXeID, NhanVienID, QuanTriID, Role)
	       values (@username, @password, NULL, @KhachHangID, NULL, NULL, NULL, 1)
end
go

-- Tạo người dùng mới với tư cách là tài xế
CREATE PROC addShipper @TaiXeID CHAR(8), @Ten NVARCHAR(50), @CMND CHAR(10), @SDT CHAR(10),
                       @DiaChi NVARCHAR(50), @BienSo CHAR(12), @KhuVuc CHAR(20), @STK CHAR(20),
                       @username CHAR(32), @password CHAR(32)
as                      
begin
	INSERT INTO TAIXE(ID, hoten, CMND, Dienthoai, Diachi, Soxe, Khuvuc, Taikhoan)
	       VALUES (@TaiXeID, @Ten, @CMND, @SDT, @DiaChi, @BienSo, @KhuVuc, @STK)
	
	INSERT INTO NGUOIDUNG(Username, Password, DoiTacID, KhachHangID, TaiXeID, NhanVienID, QuanTriID, Role)
	       values (@username, @password, NULL, NULL, @TaiXeID, NULL, NULL, 2)
end
go

-- Tạo hợp đồng mới
CREATE PROC addContract @RandomID CHAR(8), @PartnerID CHAR(8), @representative NVARCHAR(50),
                        @BranchID CHAR(8), @DiaChi NVARCHAR(50)
as
begin
	INSERT INTO HOPDONG(ID, DoiTacID, TenNguoiDD, SoChiNhanhDK, DiaChi, NgayLap, HieuLuc, PhiHoaHong)
	       VALUES (@RandomID, @PartnerID, @representative, @BranchID, @DiaChi, GETDATE(), NULL, 100000)
end
go

--------------------------------------------------------------------------------
-- Các stored procedure liên quan đến lỗi truy xuất đồng thời
--------------------------------------------------------------------------------

-- Cập nhật đơn hàng
CREATE PROC updateOrder @DonHangID CHAR(8), @TinhTrang INT
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM DONHANG DH WHERE DH.DonHangID = @DonHangID)
		BEGIN
		   PRINT (N'Đơn hàng không tồn tại!')
		   ROLLBACK TRAN
		   RETURN 1
		END

		UPDATE DONHANG
		SET TinhTrang = @TinhTrang
		WHERE DONHANG.DonHangID = @DonHangID
	
	END TRY
	
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
RETURN 0;
GO

-- Theo dõi đơn hàng (có lỗi truy xuất đồng thời)
CREATE PROC trackOrder @KhachHangID CHAR(8)
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
BEGIN TRAN
	BEGIN TRY
	
		EXEC getOrderCustomer @KhachHangID
		WAITFOR DELAY '00:00:10'
		--EXEC getOrderCustomer @KhachHangID
		COMMIT TRAN
		RETURN 0
	END TRY
	
	BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
GO

-- Theo dõi đơn hàng (đã sửa lỗi truy xuất đồng thời)

CREATE PROC trackOrder_Fixed @KhachHangID CHAR(8)
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
	
		--EXEC getOrderCustomer @KhachHangID
		WAITFOR DELAY '00:00:10'
		EXEC getOrderCustomer @KhachHangID
		
		COMMIT TRAN
		RETURN 0
	END TRY
	
	BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
GO

-- Tiếp nhận đơn hàng (có lỗi truy xuất đồng thời)
CREATE PROC takeOrder @DonHangID CHAR(8), @TaiXeID CHAR(8)
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	--BEGIN TRY
		/*IF EXISTS (SELECT * FROM TX_DH t WHERE t.DonHangID = @DonHangID)
		BEGIN
		   RAISERROR(N'Đơn hàng đã được xác nhận!',16,1);
		   ROLLBACK TRAN
		   RETURN 1
		END*/

		INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate())

		UPDATE DONHANG
		SET TinhTrang = 1
		WHERE DonHangID = @DonHangID

		WAITFOR DELAY '00:00:10'
		COMMIT TRAN
		RETURN 0
	--END TRY
 
	/*BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH*/
	
COMMIT TRAN
GO

-- Tiếp nhận đơn hàng (đã sửa lỗi truy xuất đồng thời)
CREATE PROC takeOrder_Fixed @DonHangID CHAR(8), @TaiXeID CHAR(8)
AS
BEGIN TRAN
	--BEGIN TRY
		IF EXISTS (SELECT * FROM TX_DH t WHERE t.DonHangID = @DonHangID)
		BEGIN
		   RAISERROR(N'Đơn hàng đã được xác nhận!',16,1);
		   ROLLBACK TRAN
		   RETURN 1
		END

		INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate())

		UPDATE DONHANG
		SET TinhTrang = 1
		WHERE DonHangID = @DonHangID

		WAITFOR DELAY '00:00:10'
	--END TRY
 
	/*BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH*/
	
COMMIT TRAN
GO

-- Xác nhận tạo một đơn hàng (tức là từ đơn hàng trống cập nhật lại tình trạng về 0
--                            và thiết lập ngày đặt là thời gian hiện tại)
CREATE PROC submitOrder @KhachHangID CHAR(8), @DoiTacID CHAR(8), @RandomDonHangID CHAR(8), @DiaChi NVARCHAR(50), @HinhThucTT BIT, @Tong INT, @PhiVanChuyen INT
as
BEGIN TRAN
	UPDATE DONHANG
	SET TinhTrang = 0,
	    TongGia = @Tong,
	    PhiVanChuyen = @PhiVanChuyen,
	    HinhThucTT = @HinhThucTT,
	    DiaChi = @DiaChi
	WHERE DonHangID = @RandomDonHangID
	
	UPDATE DATHANG
	SET NgayDat = GETDATE()
	WHERE DoiTacID = @DoiTacID and DonHangID = @RandomDonHangID
	
COMMIT TRAN
RETURN 0;
go

-- Xuất danh sách đơn hàng thuộc về đối tác (có lỗi truy xuất đồng thời)
CREATE PROC getOrderPartner @id CHAR(8)
as
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng',
		   d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
		   d.TinhTrang as N'Tình trạng'
	FROM DONHANG d, DATHANG h
	WHERE d.DonHangID = h.DonHangID
		  and h.DoiTacID = @id and d.TinhTrang <> -1
	        
	WAITFOR DELAY '0:0:10'
		
	/*SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng',
			 d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
			 d.TinhTrang as N'Tình trạng'
	  FROM DONHANG d, DATHANG h
	  WHERE d.DonHangID = h.DonHangID
			and h.DoiTacID = @id and d.TinhTrang <> -1*/
	
COMMIT TRAN
RETURN 0;
GO

-- Xuất danh sách đơn hàng thuộc về đối tác (đã sửa lỗi truy xuất đồng thời)
CREATE PROC getOrderPartner_Fixed @id CHAR(8)
as
-- SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN

  /*SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
         d.TinhTrang as N'Tình trạng'
  FROM DONHANG d, DATHANG h
  WHERE d.DonHangID = h.DonHangID
        and h.DoiTacID = @id and d.TinhTrang <> -1*/

  WAITFOR DELAY '0:0:10'
	
  SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
         d.TinhTrang as N'Tình trạng'
  FROM DONHANG d, DATHANG h
  WHERE d.DonHangID = h.DonHangID
        and h.DoiTacID = @id and d.TinhTrang <> -1
	
COMMIT TRAN
RETURN 0;
GO

-- Xem danh sách hợp đồng (có lỗi truy xuất đồng thời)
create proc sp_XemDanhSachHopDong @id CHAR(8), @search NVARCHAR(50)
as
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
begin tran
   exec getContractList @id, @search
   waitfor delay '00:00:10'
   --exec getContractList @id, @search
commit tran
go

-- Xem danh sách hợp đồng
create proc sp_XemDanhSachHopDong_Fixed @id CHAR(8), @search NVARCHAR(50)
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin tran
   --exec getContractList @id, @search
   waitfor delay '00:00:10'
   exec getContractList @id, @search
commit tran
go

-- Đăng ký hợp đồng
create proc sp_DangKiHopDong @DoiTacID char(8), @name nvarchar(30), @SochinhanhDK char(8), @diachi nvarchar(50), @phihoahong float
as
begin tran
BEGIN
   
	declare @ID table
	(
		ID char(8)
	)
	declare @NewID char(8)
	insert into @ID (ID)
	select ID from HOPDONG
	UPDATE @ID SET ID = REPLACE(ID, 'HD', '')
	

	declare @IDint table
	(
		ID int
	)
	insert into @IDint (ID)	select cast(ID as int) from @ID 
	declare @num int
	select @num =( select top 1 ID from @IDint order by ID desc) + 1
	set @NewID = (Select concat('HD', (select cast(@num as char(8)))))
		 
INSERT INTO Hopdong VALUES (@NewID, @DoiTacID, @name, @SochinhanhDK, @diachi, getdate(), null, @phihoahong)

IF(@@ERROR <> 0)
  BEGIN
   ROLLBACK TRAN
   PRINT 'Transaction had been rollbacked.'
  END
 ELSE
  BEGIN
   COMMIT TRAN
   PRINT 'Transaction successfully commited.'
   end
   end
   go

--DKTaiKhoan cung luc Xem danh sach tai khoan
create proc sp_DKTaiKhoan @Username char(32), @Password char(32), @HoTen NVARCHAR(50),  @DienThoai CHAR(10),  @DiaChi NVARCHAR(50),  @Email VARCHAR(30)
as
begin tran
   BEGIN
   
   IF EXISTS (SELECT * FROM nguoidung WHERE Username = @Username)
      BEGIN
         SELECT * FROM NGUOIDUNG
         WHERE Username = @Username
      END
      
   declare @CustomerID char(8) = concat('KH',(select cast ((SELECT REPLACE((select TOP 1 ID FROM KHACHHANG ORDER BY ID DESC), 'KH','')) as int) + 1))
   insert into KHACHHANG values (@CustomerID, @HoTen, @DienThoai, @DiaChi, @Email)
   insert into NGUOIDUNG values (@Username, @Password, null, @CustomerID, null, null, null, 1)
		 
   IF(@@ERROR <> 0)
      BEGIN
         ROLLBACK TRAN
         PRINT 'Transaction had been rollbacked.'
      END
   ELSE
      BEGIN
         COMMIT TRAN
         PRINT 'Transaction successfully commited.'
      END
      
   END
go

-- Xem danh sách tài khoản (có lỗi truy xuất đồng thời)
create proc sp_XemDanhSachTaiKhoan @search NVARCHAR(50), @role int
as
begin tran
	exec getUserList @search, @role
	waitfor delay '00:00:10'
	--exec getUserList @search, @role
commit tran
go
   
-- Xem danh sách tài khoản (đã sửa lỗi)
create proc sp_XemDanhSachTaiKhoan_Fixed @search NVARCHAR(50), @role int
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin tran
	--exec getUserList @search, @role
	waitfor delay '00:00:10'
	exec getUserList @search, @role
commit tran
go

-- Cập nhật tên đối tác (có lỗi truy xuất đồng thời)
CREATE PROCEDURE CapNhatTenDoiTac @idDoiTac CHAR(8), @newname NVARCHAR(30)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE ID = @idDoiTac))
		BEGIN
			PRINT (N'Đối tác không tồn tại')
			COMMIT TRAN
			RETURN
		END

		DECLARE @currentname CHAR(8)
		
		SELECT @currentname=Ten FROM DOITAC WHERE ID = @idDoiTac
		IF(@currentname = @newname)
		BEGIN
			PRINT (N'Tên không thay đổi')
			COMMIT TRAN
		END

		UPDATE DOITAC
		SET Ten = @newname
		WHERE ID=@idDoiTac

		PRINT(N'Cập nhật thành công')
	END TRY

	BEGIN CATCH
		PRINT(N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
RETURN 0
GO

-- Cập nhật tên đối tác (đã sửa lỗi truy xuất đồng thời)
CREATE PROCEDURE CapNhatTenDoiTac_FIX @idDoiTac CHAR(8), @newname NVARCHAR(30)
AS

SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE ID = @idDoiTac))
		BEGIN
			PRINT (N'Đối tác không tồn tại')
			COMMIT TRAN
			RETURN
		END

		DECLARE @currentname CHAR(8)
		
		SELECT @currentname=Ten FROM DOITAC WHERE ID = @idDoiTac
		IF(@currentname = @newname)
		BEGIN
			PRINT (N'Tên không thay đổi')
			COMMIT TRAN
		END

		UPDATE DOITAC
		SET Ten = @newname
		WHERE ID=@idDoiTac

		PRINT(N'Cập nhật thành công')
	END TRY

	BEGIN CATCH
		PRINT(N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
RETURN 0
GO

-- Xem danh sách đối tác (có lỗi truy xuất đồng thời)
CREATE PROCEDURE XemDSDoiTac @search NVARCHAR(50)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

BEGIN TRAN
		IF (NOT EXISTS (SELECT * FROM DOITAC))
		BEGIN
			PRINT (N'Không có danh sách đối tác')
			COMMIT TRAN
			RETURN
		END

	EXEC getPartnerList @search
	WAITFOR DELAY '0:0:10'
	--EXEC getPartnerList @search

COMMIT TRAN
RETURN 0
GO

-- Xem danh sách đối tác (đã sửa lỗi truy xuất đồng thời)
CREATE PROCEDURE XemDSDoiTac_FIX @search NVARCHAR(50)
AS

SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

BEGIN TRAN
	IF (NOT EXISTS (SELECT * FROM DOITAC))
		BEGIN
			RAISERROR('Không tìm thấy đối tác',16,1)
			COMMIT TRAN
			RETURN
		END
		
	--EXEC getPartnerList @search
	WAITFOR DELAY '0:0:10'
	EXEC getPartnerList @search
COMMIT TRAN
RETURN 0
GO

-- Tìm kiếm đối tác (có lỗi truy xuất đồng thời)
CREATE PROC TimKiem_DoiTac @id CHAR(8)
AS
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE ID = @id))
		BEGIN
			PRINT (N'Đối tác không tồn tại.')
			COMMIT TRAN
			RETURN
		END
		WAITFOR DELAY '0:0:08'
		SELECT * FROM DOITAC WHERE ID = @id
	END TRY
	BEGIN CATCH
		PRINT (N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
GO

-- Tìm kiếm đối tác (đã sửa lỗi truy xuất đồng thời)
ALTER PROC TimKiem_DoiTac_FIX @id CHAR(8)
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE ID = @id))
		BEGIN
			PRINT (N'Đối tác không tồn tại.')
			COMMIT TRAN
			RETURN
		END
		WAITFOR DELAY '0:0:08'
		SELECT * FROM DOITAC WHERE ID = @id
	END TRY
	BEGIN CATCH
		PRINT (N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
GO

-- Xóa đối tác
CREATE PROCEDURE Xoa_DoiTac @id CHAR(8)
AS
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN
	IF(NOT EXISTS (SELECT * FROM DOITAC WHERE @id=ID))
	BEGIN
		PRINT(N'Đối tác không tồn tại')
		COMMIT TRAN
		RETURN
	END
	
	DELETE NGUOIDUNG WHERE DoiTacID = @id
	DELETE DATHANG WHERE DoiTacID = @id
	DELETE HOPDONG WHERE DoiTacID = @id
	DELETE DOITAC WHERE ID=@id
	
COMMIT TRAN
GO

-- Xóa đối tác (đã sửa lỗi truy xuất đồng thời)
CREATE PROCEDURE Xoa_DoiTac_FIX @id CHAR(8)
AS
SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	IF(NOT EXISTS (SELECT * FROM DOITAC WHERE @id=ID))
	BEGIN
		PRINT(N'Đối tác không tồn tại')
		COMMIT TRAN
		RETURN
	END
	
	DELETE NGUOIDUNG WHERE DoiTacID = @id
	DELETE DATHANG WHERE DoiTacID = @id
	DELETE HOPDONG WHERE DoiTacID = @id
	DELETE DOITAC WHERE ID=@id
	
COMMIT TRAN
GO

-- Xác nhận hợp đồng
create proc sp_XacNhanHopDong @HopdongID char(8)
as
begin tran
IF EXISTS (SELECT * FROM Hopdong HD WHERE HD.ID = @HopdongID)
BEGIN
   SELECT * FROM HopDong HD
   WHERE HD.ID = @HopdongID
END

-- Hợp đồng xác nhận thì có thời hạn
UPDATE HOPDONG
SET HieuLuc = GETDATE()
WHERE HOPDONG.ID = @HopdongID

-- Cộng thời hạn thêm 2 năm kể từ ngày hôm nay
UPDATE HOPDONG
SET HieuLuc = DATEADD(yyyy,2,HieuLuc)
WHERE HOPDONG.ID = @HopdongID

WAITFOR DELAY '00:00:10'
IF(@@ERROR <> 0)
  BEGIN
   ROLLBACK TRAN
   PRINT 'Transaction had been rollbacked.'
  END
 ELSE
  BEGIN
   COMMIT TRAN
   PRINT 'Transaction successfully commited.'
  END
GO
