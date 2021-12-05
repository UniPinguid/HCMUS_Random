CREATE PROC sp_TiepNhanDonHang @DonHangID CHAR(8), @TaiXeID CHAR(8), @PhiVanChuyen INT
AS
BEGIN TRAN

IF EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID and TinhTrang = 0)
BEGIN
   SELECT * FROM DonHang DH
   WHERE DH.DonHangID = 
         @DonHangID and 
         TinhTrang = 0
END

IF EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID and TinhTrang <> 0)
BEGIN
   PRINT(N’Đơn hàng đã được xác nhận!’)
   ROLLBACK
END

IF NOT EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID)
BEGIN
   PRINT(N’Đơn hàng không tồn tại’)
END

INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate(), @PhiVanChuyen)

WAITFOR DELAY '00:00:20'

UPDATE DonHang
SET TinhTrang = 1
WHERE DonHangID = @DonHangID
 
IF(@@ERROR <> 0)
  BEGIN
   ROLLBACK TRAN
   PRINT ‘Transaction had been rollbacked.’
  END
 ELSE
  BEGIN
   COMMIT TRAN
   PRINT ‘Transaction successfully commited.’
  END

-------------------------------------------------------------------------

CREATE PROC sp_TiepNhanDonHang_1 @DonHangID CHAR(8), @TaiXeID CHAR(8), @PhiVanChuyen INT
AS
BEGIN TRAN

IF EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID and TinhTrang = 0)
BEGIN
   SELECT * FROM DonHang DH
   WHERE DH.DonHangID = 
         @DonHangID and 
         TinhTrang = 0
END

IF EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID and TinhTrang <> 0)
BEGIN
   PRINT(N’Đơn hàng đã được xác nhận!’)
   ROLLBACK
END

IF NOT EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID)
BEGIN
   PRINT(N’Đơn hàng không tồn tại’)
END

INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate(), @PhiVanChuyen)

UPDATE DonHang
SET TinhTrang = 1
WHERE DonHangID = @DonHangID
 
IF(@@ERROR <> 0)
  BEGIN
   ROLLBACK TRAN
   PRINT ‘Transaction had been rollbacked.’
  END
 ELSE
  BEGIN
   COMMIT TRAN
   PRINT ‘Transaction successfully commited.’
  END