exec sp_XacNhanHopDong 'FTP12345', '22-12-2021'
go
select * from HOPDONG
where id = @HopdongID

