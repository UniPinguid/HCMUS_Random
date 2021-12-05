EXEC sp_TiepNhanDonHang 'DHA00241', 'TXDT0100', 45000

SELECT *
FROM TX_DH t
WHERE t.DonHangID = @DonHangID and t.TaiXeID = @TaiXeID