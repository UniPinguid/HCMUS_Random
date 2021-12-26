-- Xuất danh sách đơn hàng thuộc về đối tác (có lỗi truy xuất đồng thời)
CREATE PROC getOrderPartner @id CHAR(8)
as
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng',
		   d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
		   d.TinhTrang as N'Tình trạng'
	FROM DONHANG d, DATHANG h
	WHERE d.DonHangID = h.DonHangID
		  and h.DoiTacID = @id and d.TinhTrang <> -1
	        
	WAITFOR DELAY '0:0:10'
		
	SELECT d.DonHangID as N'Mã đơn hàng', h.KhachHangID as N'Mã khách hàng',
			 d.DiaChi as N'Địa chỉ', h.NgayDat as N'Ngày đặt', d.HinhThucTT as N'Hình thức thanh toán', 
			 d.TinhTrang as N'Tình trạng'
	  FROM DONHANG d, DATHANG h
	  WHERE d.DonHangID = h.DonHangID
			and h.DoiTacID = @id and d.TinhTrang <> -1
	
COMMIT TRAN
RETURN 0;
GO

-- Xác nhận tạo một đơn hàng (tức là từ đơn hàng trống cập nhật lại tình trạng về 0
--                            và thiết lập ngày đặt là thời gian hiện tại)
-- Do đó lỗi Phantom Read sẽ dẫn đến đọc thiếu 1 dòng trên DONHANG
CREATE PROC submitOrder @KhachHangID CHAR(8), @DoiTacID CHAR(8), @RandomDonHangID CHAR(8), @DiaChi NVARCHAR(50), @HinhThucTT BIT, @Tong INT, @PhiVanChuyen INT
as
BEGIN TRAN
	UPDATE DONHANG
	SET TinhTrang = 0,
	    TongGia = @Tong,
	    PhiVanChuyen = @PhiVanChuyen,
	    HinhThucTT = @HinhThucTT,
	    DiaChi = @DiaChi
	WHERE DonHangID = @RandomDonHangID
	
	UPDATE DATHANG
	SET NgayDat = GETDATE()
	WHERE DoiTacID = @DoiTacID and DonHangID = @RandomDonHangID
	
COMMIT TRAN
RETURN 0;
go