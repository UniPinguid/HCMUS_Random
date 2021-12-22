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
  SELECT t.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán'
  FROM TX_DH t, DONHANG d, DATHANG h
  WHERE t.DonhangID = d.DonHangID AND d.DonHangID = h.DonHangID
        AND d.TinhTrang = 0
        AND (t.DonhangID like '%'+@search+'%' OR h.KhachHangID like '%'+@search+'%'
        OR h.DoiTacID like '%'+@search+'%' OR d.DiaChi like N'%'+@search+'%')
end
GO

-- Xuất danh sách đơn hàng mà tài xế đó đã tiếp nhận
CREATE PROC getOrderTaken @id CHAR(8)
as
begin
  SELECT t.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.PhiVanChuyen as N'Phí vận chuyển', 
         d.HinhThucTT as N'Hình thức thanh toán', d.TinhTrang as N'Tình trạng'
  FROM TX_DH t, DONHANG d, DATHANG h
  WHERE t.DonhangID = d.DonHangID AND d.DonHangID = h.DonHangID
        and t.TaixeID = @id
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
	       values (@RandomDonHangID, @DoiTacID, @KhachHangID, NULL)
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

-- Xác nhận tạo một đơn hàng (tức là từ đơn hàng trống cập nhật lại tình trạng về 0
--                            và thiết lập ngày đặt là thời gian hiện tại)
CREATE PROC submitOrder @KhachHangID CHAR(8), @DoiTacID CHAR(8), @RandomDonHangID CHAR(8), @DiaChi NVARCHAR(50), @HinhThucTT BIT, @Tong INT
as
begin
	UPDATE DONHANG
	SET TinhTrang = 0,
	    TongGia = @Tong,
	    HinhThucTT = @HinhThucTT,
	    DiaChi = @DiaChi
	WHERE DonHangID = @RandomDonHangID
	
	UPDATE DATHANG
	SET NgayDat = Getdate()
	WHERE KhachHangID = @KhachHangID and DoiTacID = @DoiTacID
	
end
go

--------------------------------------------------------------------------------
-- Các stored procedure liên quan đến lỗi truy xuất đồng thời
--------------------------------------------------------------------------------

-- Cập nhật đơn hàng (có lỗi đồng thời)
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
	
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH
	
COMMIT TRAN
RETURN 0
GO

-- Theo dõi đơn hàng (có lỗi truy xuất đồng thời)
CREATE PROC trackOrder @KhachHangID CHAR(8)
AS
-- SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM KHACHHANG KH WHERE KH.ID = @KhachHangID)
		BEGIN
		   PRINT (N'Khách hàng không tồn tại!')
		   ROLLBACK TRAN
		END

		EXEC getOrderCustomer @KhachHangID
		WAITFOR DELAY '00:00:10'
		COMMIT TRAN
		RETURN 1
	END TRY
	
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH
	
COMMIT TRAN
GO

-- Theo dõi đơn hàng (đã sửa lỗi truy xuất đồng thời)

CREATE PROC trackOrder_Fixed @KhachHangID CHAR(8)
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM KHACHHANG KH WHERE KH.ID = @KhachHangID)
		BEGIN
		   PRINT (N'Khách hàng không tồn tại!')
		   ROLLBACK TRAN
		END

		EXEC getOrderCustomer @KhachHangID
		WAITFOR DELAY '00:00:10'
		COMMIT TRAN
		RETURN 1
	END TRY
	
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH
	
COMMIT TRAN
GO

-- Tiếp nhận đơn hàng (đã sửa lỗi truy xuất đồng thời)
CREATE PROC takeOrder_Fixed @DonHangID CHAR(8), @TaiXeID CHAR(8), @PhiVanChuyen INT
AS
BEGIN TRAN
	BEGIN TRY
		IF EXISTS (SELECT * FROM DONHANG DH WHERE DH.DonHangID = @DonHangID and TinhTrang = 0)
		BEGIN
		   SELECT * FROM DONHANG DH
		   WHERE DH.DonHangID = @DonHangID and TinhTrang = 0
		END

		IF EXISTS (SELECT * FROM DONHANG DH WHERE DH.DonHangID = @DonHangID and TinhTrang <> 0)
		BEGIN
		   PRINT(N'Đơn hàng đã được xác nhận!')
		   ROLLBACK
		END

		IF NOT EXISTS (SELECT * FROM DONHANG DH WHERE DH.DonHangID = @DonHangID)
		BEGIN
		   PRINT(N'Đơn hàng không tồn tại')
		END

		INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate())

		UPDATE DONHANG
		SET TinhTrang = 1
		WHERE DonHangID = @DonHangID

		-- WAITFOR DELAY '00:00:20'
	END TRY
 
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH	COMMIT TRAN