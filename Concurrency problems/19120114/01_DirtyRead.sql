-- Cập nhật đơn hàng
CREATE PROC updateOrder @DonHangID CHAR(8), @TinhTrang INT
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

-- Theo dõi đơn hàng (có lỗi truy xuất đồng thời)
CREATE PROC trackOrder @KhachHangID CHAR(8)
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
BEGIN TRAN
	BEGIN TRY
	
		EXEC getOrderCustomer @KhachHangID
		WAITFOR DELAY '00:00:10'
		EXEC getOrderCustomer @KhachHangID
		COMMIT TRAN
		RETURN 0
	END TRY
	
	BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
GO