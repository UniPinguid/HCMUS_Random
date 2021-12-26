﻿-- Tiếp nhận đơn hàng (đã sửa lỗi truy xuất đồng thời)
CREATE PROC takeOrder_Fixed @DonHangID CHAR(8), @TaiXeID CHAR(8)
AS
BEGIN TRAN
	BEGIN TRY
		IF EXISTS (SELECT * FROM TX_DH t WHERE t.DonHangID = @DonHangID)
		BEGIN
		   RAISERROR(N'Đơn hàng đã được xác nhận!',16,1);
		   ROLLBACK TRAN
		   RETURN 1
		END

		INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate())

		UPDATE DONHANG
		SET TinhTrang = 1
		WHERE DonHangID = @DonHangID

		WAITFOR DELAY '00:00:10'
	END TRY
 
	BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
GO

-- Tiếp nhận đơn hàng (đã sửa lỗi truy xuất đồng thời)
CREATE PROC takeOrder_Fixed @DonHangID CHAR(8), @TaiXeID CHAR(8)
AS
BEGIN TRAN
	BEGIN TRY
		IF EXISTS (SELECT * FROM TX_DH t WHERE t.DonHangID = @DonHangID)
		BEGIN
		   RAISERROR(N'Đơn hàng đã được xác nhận!',16,1);
		   ROLLBACK TRAN
		   RETURN 1
		END

		INSERT INTO TX_DH VALUES (@TaiXeID, @DonHangID, getdate())

		UPDATE DONHANG
		SET TinhTrang = 1
		WHERE DonHangID = @DonHangID

		WAITFOR DELAY '00:00:10'
	END TRY
 
	BEGIN CATCH
		RAISERROR(N'LỖI HỆ THỐNG',16,1);
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	
COMMIT TRAN
GO