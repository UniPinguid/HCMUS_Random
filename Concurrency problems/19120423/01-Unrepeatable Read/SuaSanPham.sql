DECLARE @idSanPham CHAR(8), @gia INT

SET @idSanPham = 'SP00001'
SET @gia = 100000


EXEC SuaSanPham @idSanPham, @gia