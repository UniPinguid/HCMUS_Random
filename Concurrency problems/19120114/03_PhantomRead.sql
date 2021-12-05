CREATE PROC sp_TiepNhanDonHang @DoiTacID CHAR(8)
AS
BEGIN TRAN

SELECT * 
FROM DatHang
WHERE @DoiTacID = DoiTacID

WAITFOR DELAY '00:00:20'

SELECT * 
FROM DatHang
WHERE @DoiTacID = DoiTacID
 
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

CREATE PROC sp_DatHang @KhachHangID CHAR(8), @DoiTacID CHAR(8), @DonHangID CHAR(8)
AS
BEGIN TRAN

IF NOT EXISTS (SELECT * FROM DatHang DH WHERE DH.DoiTacID = @DoiTacID and DH.KhachHangID = @KhachHangID and DH.DonHangID = @DonHangID)
BEGIN
   PRINT(N’Đơn hàng không tồn tại!’)
   ROLLBACK
END

INSERT INTO DatHang VALUES (@KhachHangID, @DoiTacID, @DonHangID, getdate())
 
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