exec sp_DanhKiHopDong 'FTP13579', 'ABC12345', 'Nguyen Van A', 15, 'ThuDuc, HCM', 158000

select * from HOPDONG where id = @HopdongID