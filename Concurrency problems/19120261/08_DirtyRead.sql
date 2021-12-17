create proc sp_XacNhanHopDong @HopdongID char(8), @endtime datetime
as
begin tran
IF EXISTS (SELECT * FROM Hopdong HD WHERE HD.ID = @HopdongID)
BEGIN
   SELECT * FROM HopDong HD
   WHERE HD.ID = 
         @HopdongID
END

UPDATE Hopdong
SET HieuLuc = @endtime
WHERE HopDong.ID = @HopdongID
WAITFOR DELAY '00:00:20'
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
----------------------------------------------------------------------------
go

create proc sp_XemDanhSachHopDong
as
begin tran

BEGIN
   SELECT * FROM Hopdong   
END

commit tran
