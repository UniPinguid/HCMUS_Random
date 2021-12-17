create proc sp_XemDanhSachHopDong
as
begin tran
select * from HOPDONG
commit tran
go
--------------------------------
create proc sp_DangKiHopDong @HopdongID char(8), @DoiTacID char(8), @name nvarchar(30), @SochinhanhDK int, @diachi nvarchar(50), @phihoahong float
as
begin tran
IF EXISTS (SELECT * FROM Hopdong HD WHERE HD.ID = @HopdongID)
BEGIN
   SELECT * FROM Hopdong HD
   WHERE HD.ID = @HopdongID
         END

INSERT INTO Hopdong VALUES (@HopdongID, @DoiTacID, @name, @SochinhanhDK, @diachi, getdate(), null, @phihoahong)

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


