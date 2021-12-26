﻿USE ONLINE_STORE
GO

CREATE PROCEDURE CapNhatTenDoiTac_FIX @idDoiTac CHAR(8), @newname NVARCHAR(30)
AS

SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE ID = @idDoiTac))
		BEGIN
			PRINT (N'Đối tác không tồn tại')
			COMMIT TRAN
			RETURN
		END

		DECLARE @currentname CHAR(8)
		
		SELECT @currentname=Ten FROM DOITAC WHERE ID = @idDoiTac
		IF(@currentname = @newname)
		BEGIN
			PRINT (N'Tên không thay đổi')
			COMMIT TRAN
		END

		UPDATE DOITAC
		SET Ten = @newname
		WHERE ID=@idDoiTac

		PRINT(N'Cập nhật thành công')
	END TRY

	BEGIN CATCH
		PRINT(N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
RETURN 0
GO

CREATE PROCEDURE XemDSDoiTac_FIX
AS

SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

BEGIN TRAN
	BEGIN TRY
		IF (NOT EXISTS (SELECT * FROM DOITAC))
		BEGIN
			PRINT (N'Không có danh sách đối tác')
			COMMIT TRAN
			RETURN
		END

		SELECT * FROM DOITAC

		WAITFOR DELAY '0:0:20'
		SELECT * FROM DOITAC
	END TRY
	BEGIN CATCH
		PRINT (N'Lỗi hệ thống')
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
RETURN 0
GO