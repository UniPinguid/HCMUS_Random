USE ONLINE_STORE
GO

-- Mỗi hợp đồng có thời gian hiệu lực tối đa 4 năm từ ngày lập.

CREATE TRIGGER VALIDATION_TIME_INSERT ON HOPDONG
AFTER INSERT AS
BEGIN
  Declare @valid INT
  SET @valid = (SELECT YEAR(h.NgayLap) - YEAR(i.HieuLuc)
                    FROM HOPDONG h, INSERTED i
                    WHERE h.ID = i.ID);
  IF (@valid > 4)
    BEGIN
      ROLLBACK
      RAISERROR(N'Hợp đồng chỉ có thời hạn tối đa 4 năm!', 16, 1)
      RETURN
    END
END
GO

CREATE TRIGGER VALIDATION_TIME_UPDATE ON HOPDONG
AFTER UPDATE AS
BEGIN
  IF EXISTS(SELECT * FROM inserted i JOIN deleted d ON i.ID = d.ID WHERE YEAR(i.HieuLuc) - YEAR(d.NgayLap) > 4)
    BEGIN
        ROLLBACK
        RAISERROR(N'Hợp đồng chỉ có thời hạn tối đa 4 năm!', 16, 1)
        RETURN
    END
END
GO

-- Ngày giao hàng của đơn hàng phải lớn hơn ngày đặt hàng của khách hàng không quá 3 tháng.
CREATE TRIGGER CHECK_NGAYGIAO ON TX_DH
AFTER INSERT, UPDATE AS
BEGIN
  IF EXISTS(SELECT * FROM INSERTED i, TX_DH t, DATHANG d
            WHERE i.DonhangID = t.DonhangID AND i.NgayGiaoHang - d.NgayDat >= 3)
    BEGIN
      ROLLBACK
      RAISERROR(N'Ngày giao hàng vượt quá 3 tháng so với ngày đặt hàng',16,1)
      RETURN
    END
END
GO

-- Trong mỗi đơn hàng, phải có ít nhất 1 chi tiết đơn hàng.
CREATE TRIGGER CHECK_CTDH ON DONHANG
AFTER DELETE AS
BEGIN
  IF (SELECT COUNT(*)
      FROM DELETED d, DONHANG dh
      WHERE d.DonHangID = dh.DonHangID) < 1
    BEGIN
      ROLLBACK
      RAISERROR(N'Không thể xóa chi tiết', 16, 1)
      RETURN
    END
END
GO

-- Hình thức thanh toán của đơn hàng chỉ nên là 0 ‘Tiền mặt’ và 1 ‘Thẻ tín dụng’.
CREATE TRIGGER CHECK_HTTT ON DONHANG
AFTER INSERT, UPDATE AS
BEGIN
  IF EXISTS(SELECT i.HinhThucTT
            FROM INSERTED i
            WHERE i.HinhThucTT NOT IN (0,1))
    BEGIN
      ROLLBACK
      RAISERROR(N'Hình thức thanh toán không hợp lệ',16,1)
      RETURN
    END
END

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

-- Khi tái ký hợp đồng, thời gian hiệu lực của hợp đồng phải lớn hơn hiệu lực cũ.
CREATE TRIGGER EXTEND_HOPDONG ON HOPDONG
AFTER UPDATE AS
BEGIN
    IF EXISTS(SELECT * FROM inserted i JOIN deleted d ON i.ID = d.ID WHERE YEAR(i.HieuLuc) < YEAR(d.HieuLuc))
    BEGIN
        ROLLBACK
        RAISERROR(N'Hiệu lực mới phải sau hiệu lực cũ!', 16, 1)
        RETURN
    END
    ELSE
        PRINT('Cập nhật hợp đồng thành công!')
END
GO