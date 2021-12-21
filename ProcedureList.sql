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

-- Xuất danh sách đơn hàng mà tài xế đó đã tiếp nhận
CREATE PROC getOrderTaken @id CHAR(8)
as
begin
  SELECT t.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng', h.DoiTacID as N'Mã đối tác',
         d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', t.Phivanchuyen as N'Phí vận chuyển', 
         d.TinhTrang as N'Tình trạng'
  FROM TX_DH t, DONHANG d, DATHANG h
  WHERE t.DonhangID = d.DonHangID AND d.DonHangID = h.DonHangID
        and t.TaixeID = @id
end
GO