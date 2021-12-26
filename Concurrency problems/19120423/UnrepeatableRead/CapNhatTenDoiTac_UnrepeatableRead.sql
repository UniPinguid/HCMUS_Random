USE ONLINE_STORE
GO

DECLARE @idDoiTac CHAR(8), @newname NVARCHAR(30)

SET @idDoiTac = 'DT000116'
SET @newname = N'Phan Thị C'
EXEC CapNhatTenDoiTac @idDoiTac, @newname
GO

