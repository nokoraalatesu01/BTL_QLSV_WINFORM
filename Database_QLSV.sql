-- ============================================================
-- SCRIPT KHỞI TẠO CƠ SỞ DỮ LIỆU BÀI TẬP LỚN QUẢN LÝ SINH VIÊN
-- MÔN HỌC: LẬP TRÌNH TRỰC QUAN (LTTQ) - C# WINFORMS
-- ============================================================

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QLSV_DB')
BEGIN
    CREATE DATABASE QLSV_DB;
END
GO

USE QLSV_DB;
GO

-- 1. BẢNG TÀI KHOẢN (ĐĂNG NHẬP & PHÂN QUYỀN)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tblTaiKhoan')
BEGIN
    CREATE TABLE tblTaiKhoan (
        TenDangNhap NVARCHAR(50) PRIMARY KEY,
        MatKhau NVARCHAR(100) NOT NULL,
        HoTen NVARCHAR(100) NOT NULL,
        Quyen NVARCHAR(20) NOT NULL DEFAULT N'User', -- 'Admin', 'GiangVien'
        Email NVARCHAR(100)
    );
END
GO

-- 2. BẢNG KHOA
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tblKhoa')
BEGIN
    CREATE TABLE tblKhoa (
        MaKhoa NVARCHAR(20) PRIMARY KEY,
        TenKhoa NVARCHAR(100) NOT NULL,
        VanPhong NVARCHAR(100),
        SoDienThoai NVARCHAR(20)
    );
END
GO

-- 3. BẢNG LỚP
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tblLop')
BEGIN
    CREATE TABLE tblLop (
        MaLop NVARCHAR(20) PRIMARY KEY,
        TenLop NVARCHAR(100) NOT NULL,
        KhoaHoc NVARCHAR(20),
        MaKhoa NVARCHAR(20) FOREIGN KEY REFERENCES tblKhoa(MaKhoa) ON UPDATE CASCADE ON DELETE SET NULL
    );
END
GO

-- 4. BẢNG SINH VIÊN
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tblSinhVien')
BEGIN
    CREATE TABLE tblSinhVien (
        MaSV NVARCHAR(20) PRIMARY KEY,
        HoDem NVARCHAR(50) NOT NULL,
        Ten NVARCHAR(30) NOT NULL,
        NgaySinh DATE NOT NULL,
        GioiTinh NVARCHAR(10) NOT NULL, -- N'Nam' hoặc N'Nữ'
        QueQuan NVARCHAR(100),
        SoDienThoai NVARCHAR(20),
        Email NVARCHAR(100),
        MaLop NVARCHAR(20) FOREIGN KEY REFERENCES tblLop(MaLop) ON UPDATE CASCADE ON DELETE SET NULL,
        AnhDaiDien NVARCHAR(255)
    );
END
GO

-- 5. BẢNG MÔN HỌC
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tblMonHoc')
BEGIN
    CREATE TABLE tblMonHoc (
        MaMH NVARCHAR(20) PRIMARY KEY,
        TenMH NVARCHAR(100) NOT NULL,
        SoTinChi INT NOT NULL DEFAULT 3,
        SoTietLT INT DEFAULT 30,
        SoTietTH INT DEFAULT 15,
        HocKy INT DEFAULT 1
    );
END
GO

-- 6. BẢNG ĐIỂM
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tblDiem')
BEGIN
    CREATE TABLE tblDiem (
        MaSV NVARCHAR(20) NOT NULL,
        MaMH NVARCHAR(20) NOT NULL,
        DiemQuaTrinh FLOAT CHECK (DiemQuaTrinh >= 0 AND DiemQuaTrinh <= 10),
        DiemThi FLOAT CHECK (DiemThi >= 0 AND DiemThi <= 10),
        DiemTongKet FLOAT,
        DiemChu NVARCHAR(5),
        PRIMARY KEY (MaSV, MaMH),
        FOREIGN KEY (MaSV) REFERENCES tblSinhVien(MaSV) ON UPDATE CASCADE ON DELETE CASCADE,
        FOREIGN KEY (MaMH) REFERENCES tblMonHoc(MaMH) ON UPDATE CASCADE ON DELETE CASCADE
    );
END
GO

-- ============================================================
-- DỮ LIỆU MẪU BAN ĐẦU
-- ============================================================

-- Thêm tài khoản
IF NOT EXISTS (SELECT * FROM tblTaiKhoan WHERE TenDangNhap = 'admin')
BEGIN
    INSERT INTO tblTaiKhoan (TenDangNhap, MatKhau, HoTen, Quyen, Email)
    VALUES 
    ('admin', '123456', N'Quản trị viên hệ thống', 'Admin', 'admin@qlsv.edu.vn'),
    ('giangvien', '123456', N'TS. Nguyễn Văn Thầy', 'GiangVien', 'giangvien@qlsv.edu.vn');
END
GO

-- Thêm Khoa
IF NOT EXISTS (SELECT * FROM tblKhoa WHERE MaKhoa = 'CNTT')
BEGIN
    INSERT INTO tblKhoa (MaKhoa, TenKhoa, VanPhong, SoDienThoai)
    VALUES 
    ('CNTT', N'Công nghệ thông tin', N'Tầng 3 - Nhà A1', '0243.868.1234'),
    ('KT', N'Kinh tế & Quản lý', N'Tầng 2 - Nhà B2', '0243.868.5678'),
    ('CK', N'Cơ khí & Động lực', N'Tầng 1 - Nhà C3', '0243.868.9999'),
    ('NN', N'Ngoại ngữ', N'Tầng 4 - Nhà D1', '0243.868.8888');
END
GO

-- Thêm Lớp
IF NOT EXISTS (SELECT * FROM tblLop WHERE MaLop = 'CNTT1-K63')
BEGIN
    INSERT INTO tblLop (MaLop, TenLop, KhoaHoc, MaKhoa)
    VALUES 
    ('CNTT1-K63', N'Công nghệ thông tin 1 - K63', 'K63', 'CNTT'),
    ('KTPM-K63', N'Kỹ thuật phần mềm - K63', 'K63', 'CNTT'),
    ('HTTT-K63', N'Hệ thống thông tin - K63', 'K63', 'CNTT'),
    ('QTKD-K63', N'Quản trị kinh doanh - K63', 'K63', 'KT'),
    ('KTDN-K63', N'Kế toán doanh nghiệp - K63', 'K63', 'KT');
END
GO

-- Thêm Môn học
IF NOT EXISTS (SELECT * FROM tblMonHoc WHERE MaMH = 'LTTQ')
BEGIN
    INSERT INTO tblMonHoc (MaMH, TenMH, SoTinChi, SoTietLT, SoTietTH, HocKy)
    VALUES 
    ('LTTQ', N'Lập trình trực quan C#', 3, 30, 30, 1),
    ('CSDL', N'Cơ sở dữ liệu', 3, 30, 15, 1),
    ('CTDL', N'Cấu trúc dữ liệu & Giải thuật', 4, 45, 15, 2),
    ('TKWEB', N'Thiết kế và Phát triển Web', 3, 30, 30, 2),
    ('XSTK', N'Xác suất thống kê', 3, 45, 0, 1);
END
GO

-- Thêm Sinh viên
IF NOT EXISTS (SELECT * FROM tblSinhVien WHERE MaSV = 'SV001')
BEGIN
    INSERT INTO tblSinhVien (MaSV, HoDem, Ten, NgaySinh, GioiTinh, QueQuan, SoDienThoai, Email, MaLop, AnhDaiDien)
    VALUES 
    ('SV001', N'Nguyễn Văn', N'An', '2004-03-15', N'Nam', N'Hà Nội', '0912345678', 'an.nv@qlsv.edu.vn', 'CNTT1-K63', ''),
    ('SV002', N'Trần Thị', N'Bình', '2004-07-22', N'Nữ', N'Thái Bình', '0987654321', 'binh.tt@qlsv.edu.vn', 'CNTT1-K63', ''),
    ('SV003', N'Lê Hoàng', N'Cường', '2004-11-05', N'Nam', N'Hải Phòng', '0933445566', 'cuong.lh@qlsv.edu.vn', 'KTPM-K63', ''),
    ('SV004', N'Phạm Thu', N'Dung', '2004-01-30', N'Nữ', N'Nam Định', '0944556677', 'dung.pt@qlsv.edu.vn', 'KTPM-K63', ''),
    ('SV005', N'Vũ Đình', N'Hải', '2003-09-18', N'Nam', N'Quảng Ninh', '0966778899', 'hai.vd@qlsv.edu.vn', 'HTTT-K63', ''),
    ('SV006', N'Đỗ Mai', N'Hương', '2004-05-12', N'Nữ', N'Hải Dương', '0977889900', 'huong.dm@qlsv.edu.vn', 'QTKD-K63', '');
END
GO

-- Thêm Điểm
IF NOT EXISTS (SELECT * FROM tblDiem WHERE MaSV = 'SV001' AND MaMH = 'LTTQ')
BEGIN
    INSERT INTO tblDiem (MaSV, MaMH, DiemQuaTrinh, DiemThi, DiemTongKet, DiemChu)
    VALUES 
    ('SV001', 'LTTQ', 8.5, 9.0, 8.8, 'A'),
    ('SV001', 'CSDL', 7.5, 8.0, 7.8, 'B+'),
    ('SV002', 'LTTQ', 9.0, 9.5, 9.3, 'A+'),
    ('SV002', 'CSDL', 8.0, 8.5, 8.3, 'A'),
    ('SV003', 'LTTQ', 6.5, 7.0, 6.8, 'B'),
    ('SV003', 'CSDL', 7.0, 6.5, 6.7, 'B'),
    ('SV004', 'LTTQ', 8.0, 8.5, 8.3, 'A'),
    ('SV005', 'LTTQ', 7.0, 7.5, 7.3, 'B+'),
    ('SV006', 'XSTK', 8.5, 8.0, 8.2, 'A');
END
GO
