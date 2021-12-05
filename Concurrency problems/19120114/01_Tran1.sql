DECLARE @DonHangID CHAR(8)
DECLARE @TinhTrang INT

EXEC sp_CapNhatDonHang 'DHA00241' 2
-- Tình trạng 2 là Đang vận chuyển

SELECT *
FROM DonHang DH
WHERE DH.DonHangID = @DonHangID