
exec sp_CapNhatTinhTrang 'DH000009', -1

select * 
from DONHANG 
where DonHangID = 'DH000009' 
