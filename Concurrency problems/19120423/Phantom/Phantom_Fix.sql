USE ONLINE_STORE
GO

CREATE PROC TimKiem_DoiTac_FIX @id CHAR(8)
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE ID = @id))
		BEGIN
			PRINT (N'Đối tác không tồn tại.')
			COMMIT TRAN
			RETURN
		END
		WAITFOR DELAY '0:0:15'
		SELECT * FROM DOITAC WHERE ID = @id
	END TRY
	BEGIN CATCH
		PRINT (N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
GO

CREATE PROCEDURE Xoa_DoiTac_FIX @id CHAR(8)
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	BEGIN TRY
		SELECT * FROM DOITAC WHERE @id=ID
		IF(NOT EXISTS (SELECT * FROM DOITAC WHERE @id=ID))
		BEGIN
			PRINT(N'Đối tác không tồn tại')
			COMMIT TRAN
			RETURN
		END
		DELETE DOITAC WHERE ID=@id
			PRINT (N'Xóa đối tác thành công')
		
	END TRY

	BEGIN CATCH
		PRINT (N'Lỗi hệ thống')
	END CATCH
COMMIT TRAN
GO