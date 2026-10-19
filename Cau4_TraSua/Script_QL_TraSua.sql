USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_TraSua')
BEGIN
    CREATE DATABASE QL_TraSua;
END
GO

USE QL_TraSua;
GO

IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('MonUong', 'U') IS NOT NULL DROP TABLE MonUong;
IF OBJECT_ID('DanhMucMon', 'U') IS NOT NULL DROP TABLE DanhMucMon;
GO

CREATE TABLE DanhMucMon (
    MaDM INT IDENTITY(1,1) PRIMARY KEY,
    TenDM NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE MonUong (
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    GiaBan DECIMAL(18,0) NOT NULL CHECK (GiaBan >= 0),
    DangBan BIT NOT NULL DEFAULT 1,
    MaDM INT NOT NULL FOREIGN KEY REFERENCES DanhMucMon(MaDM) ON DELETE CASCADE
);
GO

CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18,0) NOT NULL DEFAULT 0,
    HinhThucTT NVARCHAR(20) NOT NULL,
    DaThanhToan BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL FOREIGN KEY REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    MaMon INT NOT NULL FOREIGN KEY REFERENCES MonUong(MaMon),
    SoLy INT NOT NULL CHECK (SoLy > 0),
    DonGia DECIMAL(18,0) NOT NULL,
    CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (MaHD, MaMon)
);
GO

SET IDENTITY_INSERT DanhMucMon ON;
INSERT INTO DanhMucMon (MaDM, TenDM) VALUES
(1, N'Trà sữa'),
(2, N'Trà trái cây'),
(3, N'Topping'),
(4, N'Đồ ăn vặt');
SET IDENTITY_INSERT DanhMucMon OFF;
GO

INSERT INTO MonUong (TenMon, GiaBan, DangBan, MaDM) VALUES
(N'Trà sữa trân châu hoàng kim', 35000, 1, 1),
(N'Trà sữa matcha đậu đỏ', 40000, 1, 1),
(N'Hồng trà sữa truyền thống', 32000, 1, 1),
(N'Trà sữa khoai môn', 38000, 1, 1),
(N'Trà đào cam sả', 42000, 1, 2),
(N'Trà ổi hồng hạt chia', 45000, 1, 2),
(N'Trà vải hoa hồng', 40000, 1, 2),
(N'Trà xoài nhiệt đới', 39000, 1, 2),
(N'Trân châu đen', 5000, 1, 3),
(N'Trân châu trắng 3Q', 7000, 1, 3),
(N'Pudding trứng', 8000, 1, 3),
(N'Thạch phô mai', 10000, 1, 3),
(N'Bánh tráng trộn', 25000, 1, 4),
(N'Khoai tây lắc phô mai', 30000, 1, 4);
GO

SET IDENTITY_INSERT HoaDon ON;
INSERT INTO HoaDon (MaHD, NgayLap, TongTien, HinhThucTT, DaThanhToan) VALUES
(1001, '2026-10-18 10:30:00', 80000, N'Tiền mặt', 1),
(1002, '2026-10-18 14:15:00', 122000, N'Chuyển khoản', 1);
SET IDENTITY_INSERT HoaDon OFF;
GO

INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLy, DonGia) VALUES
(1001, 1, 2, 35000),
(1001, 9, 2, 5000),
(1002, 5, 2, 42000),
(1002, 4, 1, 38000);
GO
