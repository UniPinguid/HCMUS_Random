DECLARE @DonHangID CHAR(8)
DECLARE @TinhTrang INT

SELECT *
FROM DonHang DH
WHERE DH.DonHangID = @DonHangID

EXEC sp_CapNhatDonHang 'DHA00241', 2
-- Tình trạng 2 là Đang vận chuyển

EXEC sp_TheoDoiDonHang 'DHA00241'

SELECT *
FROM DonHang DH
WHERE DH.DonHangID = @DonHangID