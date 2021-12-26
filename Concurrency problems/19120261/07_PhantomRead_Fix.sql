create proc sp_XemDanhSachTaiKhoanfix
as
begin tran
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
waitfor delay '00:00:10'
select * from NGUOIDUNG
commit tran
go
--------------------------------
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
   end
   end
   go
   



