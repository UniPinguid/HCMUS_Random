USE ONLINE_STORE
GO

-------------------------------------------------------------------------------
-- Phân hệ Ðối tác

-- Thêm nhóm DOITAC
CREATE ROLE DOITAC_ROLE 
GO

-- Thêm đăng nhập người dùng
CREATE LOGIN doitac WITH PASSWORD = '123'
GO

CREATE USER doitac FOR LOGIN doitac
GO

-- Thên người dùng vào nhóm DOITAC
EXEC sp_addrolemember DOITAC_ROLE, doitac

GRANT SELECT, INSERT ON DOITAC TO DOITAC_ROLE
GRANT INSERT ON HOPDONG TO DOITAC_ROLE
GRANT SELECT, UPDATE ON DONHANG TO DOITAC_ROLE
GRANT SELECT, INSERT, UPDATE, DELETE ON CHINHANH TO DOITAC_ROLE
GRANT SELECT, INSERT, UPDATE, DELETE ON SANPHAM TO DOITAC_ROLE
GO

-------------------------------------------------------------------------------
-- Phân hệ Khách hàng

-- Thêm nhóm KHACHHANG
CREATE ROLE KHACHHANG_ROLE 
GO

-- Thêm đăng nhập người dùng
CREATE LOGIN khachhang WITH PASSWORD = '123'
GO

CREATE USER khachhang FOR LOGIN khachhang
GO

-- Thên người dùng vào nhóm DOITAC
EXEC sp_addrolemember KHACHHANG_ROLE, khachhang

GRANT SELECT ON DoiTac TO KHACHHANG_ROLE
GRANT SELECT ON DonHang TO KHACHHANG_ROLE
GRANT SELECT ON SanPham TO KHACHHANG_ROLE
GRANT SELECT, INSERT ON KhachHang TO KHACHHANG_ROLE
GO

-------------------------------------------------------------------------------
-- Phân hệ Tài xế

-- Thêm nhóm TAIXE
CREATE ROLE TAIXE_ROLE 
GO

-- Thêm đăng nhập người dùng
CREATE LOGIN taixe WITH PASSWORD = '123'
GO

CREATE USER taixe FOR LOGIN taixe
GO

-- Thên người dùng vào nhóm DOITAC
EXEC sp_addrolemember TAIXE_ROLE, taixe

GRANT SELECT ON DoiTac TO TAIXE_ROLE
GRANT SELECT, UPDATE ON DonHang TO TAIXE_ROLE
GRANT SELECT, INSERT ON TaiXe TO TAIXE_ROLE
GRANT SELECT ON KhachHang TO TAIXE_ROLE
GO

-------------------------------------------------------------------------------
-- Phân hệ Nhân viên

-- Thêm nhóm NHANVIEN
CREATE ROLE NHANVIEN_ROLE 
GO

-- Thêm đăng nhập người dùng
CREATE LOGIN nhanvien WITH PASSWORD = '123'
GO

CREATE USER nhanvien FOR LOGIN nhanvien
GO

-- Thên người dùng vào nhóm DOITAC
EXEC sp_addrolemember NHANVIEN_ROLE, nhanvien

GRANT SELECT ON DoiTac TO NHANVIEN_ROLE
GRANT SELECT ON HopDong TO NHANVIEN_ROLE
GO

-------------------------------------------------------------------------------
-- Phân hệ Quản trị

-- Thêm nhóm NHANVIEN
CREATE ROLE ADMIN_ROLE 
GO

-- Thêm đăng nhập người dùng
CREATE LOGIN quantrivien WITH PASSWORD = 'admin'
GO

CREATE USER quantrivien FOR LOGIN quantrivien
GO

-- Thên người dùng vào nhóm DOITAC
EXEC sp_addrolemember ADMIN_ROLE, quantrivien

GRANT CONTROL ON DoiTac TO ADMIN_ROLE
GRANT CONTROL ON KhachHang TO ADMIN_ROLE
GRANT CONTROL ON TaiXe TO ADMIN_ROLE
GRANT CONTROL ON NhanVien TO ADMIN_ROLE
GRANT CONTROL ON QuanTri TO ADMIN_ROLE

GO