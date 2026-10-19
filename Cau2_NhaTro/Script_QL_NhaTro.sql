USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_NhaTro')
BEGIN
    CREATE DATABASE QL_NhaTro;
END
GO

USE QL_NhaTro;
GO

IF OBJECT_ID('KhachThue', 'U') IS NOT NULL DROP TABLE KhachThue;
IF OBJECT_ID('PhongTro', 'U') IS NOT NULL DROP TABLE PhongTro;
GO

CREATE TABLE PhongTro (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(20) NOT NULL,
    GiaThue DECIMAL(18,0) NOT NULL CHECK (GiaThue >= 0),
    TinhTrang NVARCHAR(20) NOT NULL DEFAULT N'Trống'
);
GO

CREATE TABLE KhachThue (
    MaKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
    NgaySinh DATE NOT NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    MaTinh INT NOT NULL,
    TenTinh NVARCHAR(100) NOT NULL,
    MaPhuongXa INT NOT NULL,
    TenPhuongXa NVARCHAR(100) NOT NULL,
    DaDangKyTamTru BIT NOT NULL DEFAULT 0,
    MaPhong INT NOT NULL FOREIGN KEY REFERENCES PhongTro(MaPhong) ON DELETE CASCADE
);
GO

SET IDENTITY_INSERT PhongTro ON;
INSERT INTO PhongTro (MaPhong, TenPhong, GiaThue, TinhTrang) VALUES
(1, N'P01', 1500000, N'Đang thuê'),
(2, N'P02', 1600000, N'Đang thuê'),
(3, N'P03', 1800000, N'Đang thuê'),
(4, N'P04', 2000000, N'Đang thuê'),
(5, N'P05', 1700000, N'Đang thuê'),
(6, N'P06', 1900000, N'Trống');
SET IDENTITY_INSERT PhongTro OFF;
GO

INSERT INTO KhachThue (HoTen, GioiTinh, NgaySinh, SoDienThoai, MaTinh, TenTinh, MaPhuongXa, TenPhuongXa, DaDangKyTamTru, MaPhong) VALUES
(N'Nguyễn Văn An', N'Nam', '2004-05-12', '0912345678', 1, N'Thành phố Hà Nội', 1, N'Phường Phúc Xá', 1, 3),
(N'Trần Thị Bình', N'Nữ', '2003-08-20', '0876543210', 36, N'Tỉnh Nam Định', 1234, N'Phường Trần Tế Xương', 0, 1),
(N'Lê Văn Cường', N'Nam', '2002-11-15', '0901234567', 38, N'Tỉnh Thanh Hóa', 2345, N'Phường Ba Đình', 0, 2),
(N'Phạm Minh Đức', N'Nam', '2001-03-10', '0987654321', 38, N'Tỉnh Thanh Hóa', 2346, N'Phường Điện Biên', 1, 4),
(N'Hoàng Thị Dung', N'Nữ', '2005-09-25', '0765432109', 27, N'Tỉnh Bắc Ninh', 3456, N'Phường Suối Hoa', 0, 5);
GO
