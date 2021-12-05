create procedure sp_CapNhatTinhTrang
@IDDonHang char(10),
@status int
as
BEGIN TRAN
	if not exists (select * from DONHANG where DonHangID = @IDDonHang )
	begin
		print N'Đơn hàng không tồn tại'
		rollback tran
	end
	waitfor delay '00:00:20'
	update DONHANG
	set TinhTrang = @status
	where DonHangID = @IDDonHang
	if (@@ERROR<>0)
	begin
		rollback tran
		print N'Cập nhật thất bại'
	end
	else
	begin
		commit tran 
		print N'Cập nhật thành công'
	end
go


create procedure sp_CapNhatTinhTrang_2
@IDDonHang char(10),
@status int
as
BEGIN TRAN
	if not exists (select * from DONHANG where DonHangID = @IDDonHang )
	begin
		print N'Đơn hàng không tồn tại'
		rollback tran
	end
	update DONHANG
	set TinhTrang = @status
	where DonHangID = @IDDonHang
	if (@@ERROR<>0)
	begin
		rollback tran
		print N'Cập nhật thất bại'
	end
	else
	begin
		commit tran 
		print N'Cập nhật thành công'
	end
go



