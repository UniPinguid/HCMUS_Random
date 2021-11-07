CREATE DATABASE ONLINE_STORE
GO

USE ONLINE_STORE
GO

CREATE TABLE DOITAC(
  ID CHAR(8),
  Ten NVARCHAR(30),
  DaiDien NVARCHAR(8),
  ThanhPho NVARCHAR(24),
  SoChiNhanh INT,
  SLDonHang INT,
  LoaiHang NVARCHAR(20),
  DiaChi NVARCHAR(50),
  SoDienThoai CHAR(10),
  Email CHAR(50)
)

ALTER TABLE DOITAC
  ADD CONSTRAINT PK_DOITAC_ID PRIMARY KEY (ID)