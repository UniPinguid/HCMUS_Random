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
CREATE PROC loginProcess @username CHAR(8), @password CHAR(32)
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
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', t.Phivanchuyen as N'Phí vận chuyển', 
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
  SELECT t.DonHangID as N'Mã đơn hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', t.Phivanchuyen as N'Phí vận chuyển', 
         d.HinhThucTT as N'Hình thức thanh toán', d.TinhTrang as N'Tình trạng'
  FROM TX_DH t, DONHANG d, DATHANG h
  WHERE t.DonhangID = d.DonHangID AND d.DonHangID = h.DonHangID
        and h.KhachHangID = @id
end
GO

-- Xuất ra danh sách chi tiết hóa đơn trong hóa đơn đặt hàng
CREATE PROC getDetailsFromOrder @id CHAR(8)
as
begin
	SELECT ct.SanPhamID as N'Mã sản phẩm', s.Gia as 'Đơn giá', ct.SoLuong as 'Số lượng', ThanhTien = s.Gia * ct.SoLuong
	FROM DONHANG d, CT_DONHANG ct, SANPHAM s
	WHERE d.DonHangID = @id and d.DonHangID = ct.DonHangID
	      and s.ID = ct.SanPhamID
end
go

-- In ra tổng tiền hóa đơn, phí vận chuyển, tổng tiền đơn hàng, tổng số lượng
CREATE PROC getOrderTotal @id CHAR(8)
as
begin
	SELECT d.TongGia, t.Phivanchuyen, TongHoaDon = d.TongGia + t.Phivanchuyen, TongSL = COUNT(ct.SanPhamID)
	FROM DONHANG d, CT_DONHANG ct, TX_DH t
	WHERE d.DonHangID = ct.DonHangID and t.DonhangID = d.DonHangID
	      and d.DonHangID = @id
	GROUP BY d.TongGia, t.Phivanchuyen
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
		IF NOT EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID)
		BEGIN
		   PRINT (N'Đơn hàng không tồn tại!')
		   ROLLBACK TRAN
		END

	UPDATE DONHANG
	SET TinhTrang = @TinhTrang
	WHERE DONHANG.DonHangID = @DonHangID

	WAITFOR DELAY '00:00:10'
	ROLLBACK TRAN
	RETURN 1
	
	END TRY
	
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH

GO

-- Theo dõi đơn hàng (có lỗi truy xuất đồng thời)
CREATE PROC trackOrder @DonHangID CHAR(8)
AS
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM DONHANG DH WHERE DH.DonHangID = @DonHangID)
		BEGIN
		   PRINT (N'Đơn hàng không tồn tại!')
		   ROLLBACK TRAN
		END

		DECLARE @TinhTrang INT
		SET @TinhTrang = (SELECT TinhTrang FROM DONHANG WHERE DonHangID = @DonHangID)
		PRINT(@TinhTrang)
	END TRY
	
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH
	
COMMIT TRAN
GO

-- Theo dõi đơn hàng (đã sửa lỗi truy xuất đồng thời)

CREATE PROC trackOrder_Fixed @DonHangID CHAR(8)
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM DONHANG DH WHERE DH.DonHangID = @DonHangID)
		BEGIN
		   PRINT (N'Đơn hàng không tồn tại!')
		   ROLLBACK TRAN
		END

		DECLARE @TinhTrang INT
		SET @TinhTrang = (SELECT TinhTrang FROM DONHANG WHERE DonHangID = @DonHangID)
		PRINT(@TinhTrang)
	END TRY
	
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH
	
COMMIT TRAN

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

		INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate(), @PhiVanChuyen)

		UPDATE DONHANG
		SET TinhTrang = 1
		WHERE DonHangID = @DonHangID

		-- WAITFOR DELAY '00:00:20'
	END TRY
 
	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1	END CATCH	COMMIT TRAN