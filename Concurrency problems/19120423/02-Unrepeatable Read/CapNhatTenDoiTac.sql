USE ONLINE_STORE
GO

DECLARE @idDoiTac CHAR(8), @newname NVARCHAR(30)

SET @idDoiTac='DT0001'
SET @newname = N'Lạc Hồng'

EXEC CapNhatTenDoiTac @idDoiTac, @newname

