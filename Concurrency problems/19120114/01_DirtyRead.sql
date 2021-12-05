CREATE PROC sp_CapNhatDonHang @DonHangID CHAR(8), @TinhTrang INT
AS
BEGIN TRAN

IF NOT EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID)
BEGIN
   PRINT (N’Đơn hàng không tồn tại!’)
   ROLLBACK TRAN
END

UPDATE DonHang
SET TinhTrang = @status
WHERE DonHang.DonHangID = 
      @DonHangID

WAITFOR DELAY '00:00:20'
 
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

CREATE PROC sp_TheoDoiDonHang @DonHangID CHAR(8)
AS
BEGIN TRAN

IF EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID)
BEGIN
   SELECT * FROM DonHang DH 
   WHERE DH.DonHangID = 
         @DonHangID
END

IF NOT EXISTS (SELECT * FROM DonHang DH WHERE DH.DonHangID = @DonHangID)
BEGIN
   PRINT (N’Đơn hàng không tồn tại!’)
   ROLLBACK TRAN
END

SELECT *
FROM DonHang DH
WHERE DH.DonHangID = @DonHangID


COMMIT TRAN
