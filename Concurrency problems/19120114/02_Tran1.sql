DECLARE @DonHangID CHAR(8)
DECLARE @TaiXeID CHAR(8)
DECLARE @PhiVanChuyen INT

EXEC sp_TiepNhanDonHang 'DHA00241', 'TXDT0100', 45000

SELECT *
FROM TX_DH t
WHERE t.DonHangID = @DonHangID and t.TaiXeID = @TaiXeID