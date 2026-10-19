USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_DaNgoai')
BEGIN
    CREATE DATABASE QL_DaNgoai;
END
GO

USE QL_DaNgoai;
GO

IF OBJECT_ID('ChuyenDi', 'U') IS NOT NULL DROP TABLE ChuyenDi;
GO

CREATE TABLE ChuyenDi (
    MaChuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenChuyen NVARCHAR(100) NOT NULL,
    DiaDiem NVARCHAR(100) NOT NULL,
    NgayDi DATE NOT NULL,
    SoNguoi INT NOT NULL CHECK (SoNguoi >= 1),
    NganSach DECIMAL(18,0) NOT NULL CHECK (NganSach >= 0),
    PhuongTien NVARCHAR(30) NOT NULL,
    DaHoanThanh BIT NOT NULL DEFAULT 0,
    GhiChu NVARCHAR(200) NULL
);
GO

INSERT INTO ChuyenDi (TenChuyen, DiaDiem, NgayDi, SoNguoi, NganSach, PhuongTien, DaHoanThanh, GhiChu) VALUES
(N'Cắm trại đồi chè', N'Đà Lạt', DATEADD(DAY, 3, GETDATE()), 6, 3500000, N'Ô tô', 0, N'Mang theo lều'),
(N'Khám phá nóc nhà Đông Dương', N'Sa Pa', DATEADD(DAY, 7, GETDATE()), 4, 6000000, N'Tàu hỏa', 0, N'Đi cáp treo Fansipan'),
(N'Nghỉ dưỡng cuối tuần', N'Vũng Tàu', DATEADD(DAY, 5, GETDATE()), 8, 4000000, N'Xe khách', 0, N'Tắm biển Bãi Sau'),
(N'Dạo phố cổ đêm rằm', N'Hội An', DATEADD(DAY, 10, GETDATE()), 5, 5500000, N'Máy bay', 0, N'Ăn cao lầu và thả hoa đăng'),
(N'Tắm biển và lặn ngắm san hô', N'Nha Trang', DATEADD(DAY, 14, GETDATE()), 10, 8000000, N'Ô tô', 0, N'Đi cano ra đảo'),
(N'Khám phá hang động', N'Phong Nha', DATEADD(DAY, 20, GETDATE()), 4, 4500000, N'Tàu hỏa', 0, N'Tour động Thiên Đường'),
(N'Chinh phục cực Đông', N'Phú Yên', DATEADD(DAY, 2, GETDATE()), 3, 2800000, N'Xe máy', 0, N'Đón bình minh Mũi Điện'),
(N'Tham quan cố đô', N'Huế', DATEADD(DAY, -5, GETDATE()), 6, 3200000, N'Xe khách', 1, N'Đã hoàn thành chuyến đi');
GO
