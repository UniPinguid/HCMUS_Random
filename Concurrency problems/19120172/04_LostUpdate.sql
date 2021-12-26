CREATE PROC updateOrder_LostUpdate @DonHangID CHAR(8), @TinhTrang INT
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
	
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
RETURN 0;
GO


CREATE PROC updateOrder_LostUpdate2 @DonHangID CHAR(8), @TinhTrang INT
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
		WAITFOR DELAY '00:00:20'
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
RETURN 0;
GO



