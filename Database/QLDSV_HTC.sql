/* =====================================================================
   QLDSV_HTC - Quản lý điểm sinh viên hệ tín chỉ (SQL Server local)
   File SQL DUY NHẤT: chạy 1 lần là xong (PHẦN 1: tạo database + bảng; PHẦN 2: dữ liệu mẫu).
   CẢNH BÁO: script sẽ XÓA database QLDSV_HTC cũ (nếu có) rồi tạo lại.
   ===================================================================== */
USE master;
GO
IF DB_ID(N'QLDSV_HTC') IS NOT NULL
BEGIN
    ALTER DATABASE QLDSV_HTC SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QLDSV_HTC;
END
GO
CREATE DATABASE QLDSV_HTC;
GO
USE QLDSV_HTC;
GO
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

/* ---------------------------------------------------------------------
   1. KHOA
   --------------------------------------------------------------------- */
CREATE TABLE Khoa
(
    MAKHOA  NCHAR(10)    NOT NULL,
    TENKHOA NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Khoa PRIMARY KEY (MAKHOA),
    CONSTRAINT UQ_Khoa_TENKHOA UNIQUE (TENKHOA)
);
GO

/* ---------------------------------------------------------------------
   2. LOP
   --------------------------------------------------------------------- */
CREATE TABLE Lop
(
    MALOP   NCHAR(10)    NOT NULL,
    TENLOP  NVARCHAR(50) NOT NULL,
    KHOAHOC NCHAR(4)     NOT NULL,           -- năm nhập học, ví dụ 2021
    MAKHOA  NCHAR(10)    NOT NULL,
    CONSTRAINT PK_Lop PRIMARY KEY (MALOP),
    CONSTRAINT UQ_Lop_TENLOP UNIQUE (TENLOP),
    CONSTRAINT FK_Lop_Khoa FOREIGN KEY (MAKHOA) REFERENCES Khoa (MAKHOA),
    CONSTRAINT CK_Lop_KHOAHOC CHECK (KHOAHOC LIKE '[0-9][0-9][0-9][0-9]')
);
GO

/* ---------------------------------------------------------------------
   3. SINHVIEN   (GIOITINH: N'Nam' hoặc N'Nữ')
   --------------------------------------------------------------------- */
CREATE TABLE Sinhvien
(
    MASV      NCHAR(10)     NOT NULL,
    HO        NVARCHAR(50)  NOT NULL,
    TEN       NVARCHAR(20)  NOT NULL,
    MALOP     NCHAR(10)     NOT NULL,
    GIOITINH  NVARCHAR(3)   NOT NULL CONSTRAINT DF_Sinhvien_GIOITINH DEFAULT (N'Nam'),
    DIACHI    NVARCHAR(100) NULL,
    NGAYSINH  DATE          NULL,
    DANGHIHOC BIT           NOT NULL CONSTRAINT DF_Sinhvien_DANGHIHOC DEFAULT (0),
    CONSTRAINT PK_Sinhvien PRIMARY KEY (MASV),
    CONSTRAINT FK_Sinhvien_Lop FOREIGN KEY (MALOP) REFERENCES Lop (MALOP),
    CONSTRAINT CK_Sinhvien_GIOITINH CHECK (GIOITINH IN (N'Nam', N'Nữ'))
);
GO

/* ---------------------------------------------------------------------
   4. MONHOC
   --------------------------------------------------------------------- */
CREATE TABLE Monhoc
(
    MAMH       NCHAR(10)    NOT NULL,
    TENMH      NVARCHAR(50) NOT NULL,
    SOTIET_LT  INT          NOT NULL,
    SOTIET_TH  INT          NOT NULL,
    CONSTRAINT PK_Monhoc PRIMARY KEY (MAMH),
    CONSTRAINT UQ_Monhoc_TENMH UNIQUE (TENMH),
    CONSTRAINT CK_Monhoc_SOTIET CHECK (SOTIET_LT >= 0 AND SOTIET_TH >= 0 AND SOTIET_LT + SOTIET_TH > 0)
);
GO

/* ---------------------------------------------------------------------
   5. GIANGVIEN
   --------------------------------------------------------------------- */
CREATE TABLE GIANGVIEN
(
    MAGV      NCHAR(10)    NOT NULL,
    HO        NVARCHAR(50) NOT NULL,
    TEN       NVARCHAR(20) NOT NULL,
    HOCVI     NVARCHAR(20) NULL,
    HOCHAM    NVARCHAR(20) NULL,
    CHUYENMON NVARCHAR(50) NULL,
    MAKHOA    NCHAR(10)    NOT NULL,
    CONSTRAINT PK_GIANGVIEN PRIMARY KEY (MAGV),
    CONSTRAINT FK_GIANGVIEN_Khoa FOREIGN KEY (MAKHOA) REFERENCES Khoa (MAKHOA)
);
GO

/* ---------------------------------------------------------------------
   6. LOPTINCHI
   --------------------------------------------------------------------- */
CREATE TABLE LOPTINCHI
(
    MALTC        INT IDENTITY(1,1) NOT NULL,
    NIENKHOA     NCHAR(9)          NOT NULL,   -- ví dụ 2023-2024
    HOCKY        INT               NOT NULL,
    MAMH         NCHAR(10)         NOT NULL,
    NHOM         INT               NOT NULL,
    MAGV         NCHAR(10)         NOT NULL,
    MAKHOA       NCHAR(10)         NOT NULL,   -- khoa mở lớp
    SOSVTOITHIEU SMALLINT          NOT NULL,
    HUYLOP       BIT               NOT NULL CONSTRAINT DF_LOPTINCHI_HUYLOP DEFAULT (0),
    CONSTRAINT PK_LOPTINCHI PRIMARY KEY (MALTC),
    CONSTRAINT UQ_LOPTINCHI UNIQUE (NIENKHOA, HOCKY, MAMH, NHOM),
    CONSTRAINT FK_LOPTINCHI_Monhoc FOREIGN KEY (MAMH) REFERENCES Monhoc (MAMH),
    CONSTRAINT FK_LOPTINCHI_GIANGVIEN FOREIGN KEY (MAGV) REFERENCES GIANGVIEN (MAGV),
    CONSTRAINT FK_LOPTINCHI_Khoa FOREIGN KEY (MAKHOA) REFERENCES Khoa (MAKHOA),
    CONSTRAINT CK_LOPTINCHI_NIENKHOA CHECK (NIENKHOA LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
    CONSTRAINT CK_LOPTINCHI_HOCKY CHECK (HOCKY BETWEEN 1 AND 3),
    CONSTRAINT CK_LOPTINCHI_NHOM CHECK (NHOM >= 1),
    CONSTRAINT CK_LOPTINCHI_SOSV CHECK (SOSVTOITHIEU >= 0)
);
GO

/* ---------------------------------------------------------------------
   7. DANGKY  (sinh viên thuộc lớp tín chỉ + điểm)
   Điểm tổng kết (DIEM_TK) = CC*0.1 + GK*0.3 + CK*0.6, tính tự động,
   chỉ có giá trị khi đã nhập đủ cả 3 điểm.
   --------------------------------------------------------------------- */
CREATE TABLE DANGKY
(
    MALTC     INT          NOT NULL,
    MASV      NCHAR(10)    NOT NULL,
    DIEM_CC   INT          NULL,               -- chuyên cần, số nguyên 0..10
    DIEM_GK   DECIMAL(3,1) NULL,               -- giữa kỳ, 0..10, bước 0.5
    DIEM_CK   DECIMAL(3,1) NULL,               -- cuối kỳ, 0..10, bước 0.5
    DIEM_TK   AS (CASE WHEN DIEM_CC IS NULL OR DIEM_GK IS NULL OR DIEM_CK IS NULL THEN NULL
                       ELSE CAST(DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6 AS DECIMAL(4,2)) END),
    HUYDANGKY BIT          NOT NULL CONSTRAINT DF_DANGKY_HUYDANGKY DEFAULT (0),
    CONSTRAINT PK_DANGKY PRIMARY KEY (MALTC, MASV),
    CONSTRAINT FK_DANGKY_LOPTINCHI FOREIGN KEY (MALTC) REFERENCES LOPTINCHI (MALTC),
    CONSTRAINT FK_DANGKY_Sinhvien FOREIGN KEY (MASV) REFERENCES Sinhvien (MASV),
    CONSTRAINT CK_DANGKY_CC CHECK (DIEM_CC IS NULL OR DIEM_CC BETWEEN 0 AND 10),
    CONSTRAINT CK_DANGKY_GK CHECK (DIEM_GK IS NULL OR (DIEM_GK BETWEEN 0 AND 10 AND CAST(DIEM_GK * 10 AS INT) % 5 = 0)),
    CONSTRAINT CK_DANGKY_CK CHECK (DIEM_CK IS NULL OR (DIEM_CK BETWEEN 0 AND 10 AND CAST(DIEM_CK * 10 AS INT) % 5 = 0))
);
GO

/* ---------------------------------------------------------------------
   8. TAIKHOAN (đăng nhập + phân quyền)
   VAITRO: PGV (phòng giáo vụ - toàn quyền) > KHOA (theo MAKHOA) > GV (theo MAGV) > SV (theo MASV)
   MATKHAUHASH = SHA-256( SALT + mật khẩu ) dạng HEX viết hoa.
   --------------------------------------------------------------------- */
CREATE TABLE TaiKhoan
(
    TENDANGNHAP NVARCHAR(50) NOT NULL,
    MATKHAUHASH CHAR(64)     NOT NULL,
    SALT        VARCHAR(16)  NOT NULL,
    VAITRO      VARCHAR(4)   NOT NULL,
    MAKHOA      NCHAR(10)    NULL,
    MAGV        NCHAR(10)    NULL,
    MASV        NCHAR(10)    NULL,
    HOATDONG    BIT          NOT NULL CONSTRAINT DF_TaiKhoan_HOATDONG DEFAULT (1),
    CONSTRAINT PK_TaiKhoan PRIMARY KEY (TENDANGNHAP),
    CONSTRAINT FK_TaiKhoan_Khoa FOREIGN KEY (MAKHOA) REFERENCES Khoa (MAKHOA),
    CONSTRAINT FK_TaiKhoan_GIANGVIEN FOREIGN KEY (MAGV) REFERENCES GIANGVIEN (MAGV) ON DELETE CASCADE,
    CONSTRAINT FK_TaiKhoan_Sinhvien FOREIGN KEY (MASV) REFERENCES Sinhvien (MASV) ON DELETE CASCADE,
    CONSTRAINT CK_TaiKhoan_VAITRO CHECK (VAITRO IN ('PGV', 'KHOA', 'GV', 'SV')),
    CONSTRAINT CK_TaiKhoan_PHAMVI CHECK (
           (VAITRO = 'PGV'  AND MAKHOA IS NULL     AND MAGV IS NULL     AND MASV IS NULL)
        OR (VAITRO = 'KHOA' AND MAKHOA IS NOT NULL AND MAGV IS NULL     AND MASV IS NULL)
        OR (VAITRO = 'GV'   AND MAKHOA IS NULL     AND MAGV IS NOT NULL AND MASV IS NULL)
        OR (VAITRO = 'SV'   AND MAKHOA IS NULL     AND MAGV IS NULL     AND MASV IS NOT NULL))
);
GO

/* ---------------------------------------------------------------------
   Index hỗ trợ tra cứu
   --------------------------------------------------------------------- */
CREATE INDEX IX_Lop_MAKHOA          ON Lop (MAKHOA);
CREATE INDEX IX_Sinhvien_MALOP      ON Sinhvien (MALOP);
CREATE INDEX IX_GIANGVIEN_MAKHOA    ON GIANGVIEN (MAKHOA);
CREATE INDEX IX_LOPTINCHI_MAKHOA    ON LOPTINCHI (MAKHOA);
CREATE INDEX IX_DANGKY_MASV         ON DANGKY (MASV);
GO

PRINT N'Đã tạo xong cấu trúc database QLDSV_HTC. Đang nạp dữ liệu mẫu...';
GO


/* ======================== PHẦN 2: DỮ LIỆU MẪU ======================== */
/* =====================================================================
   QLDSV_HTC - Dữ liệu mẫu cho 2 khoa CNTT và VT
   Tài khoản mẫu (mật khẩu đều là 123456):
     pgv        -> Phòng giáo vụ (PGV)
     khoa_cntt  -> Khoa CNTT (KHOA)
     khoa_vt    -> Khoa VT   (KHOA)
     GV001 ... GV005 (mã giảng viên) -> Giảng viên (GV)
     241230001, 241230008, ... (mã sinh viên) -> Sinh viên (SV)
   ===================================================================== */
USE QLDSV_HTC;
GO
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET NOCOUNT ON;
GO

/* ---------------------------- KHOA ---------------------------- */
INSERT INTO Khoa (MAKHOA, TENKHOA) VALUES
(N'CNTT', N'Công nghệ thông tin'),
(N'VT',   N'Viễn thông');

/* ---------------------------- LOP ----------------------------- */
INSERT INTO Lop (MALOP, TENLOP, KHOAHOC, MAKHOA) VALUES
(N'D21CNPM1', N'Công nghệ phần mềm 1 - K2021',    N'2021', N'CNTT'),
(N'D21HTTT1', N'Hệ thống thông tin 1 - K2021',    N'2021', N'CNTT'),
(N'D22CNPM1', N'Công nghệ phần mềm 1 - K2022',    N'2022', N'CNTT'),
(N'D21VT01',  N'Viễn thông 1 - K2021',            N'2021', N'VT'),
(N'D22VT01',  N'Viễn thông 1 - K2022',            N'2022', N'VT'),
(N'D22DTVT1', N'Điện tử viễn thông 1 - K2022',    N'2022', N'VT');

/* -------------------------- SINHVIEN -------------------------- */
-- GIOITINH: N'Nam' hoặc N'Nữ'
INSERT INTO Sinhvien (MASV, HO, TEN, MALOP, GIOITINH, DIACHI, NGAYSINH, DANGHIHOC) VALUES
(N'241230001', N'Nguyễn Văn', N'An',     N'D21CNPM1', N'Nam', N'Hà Nội',     '2003-02-14', 0),
(N'241230002', N'Trần Thị',   N'Bình',   N'D21CNPM1', N'Nữ', N'Hải Phòng',  '2003-05-21', 0),
(N'241230003', N'Lê Hoàng',   N'Cường',  N'D21CNPM1', N'Nam', N'Nam Định',   '2003-09-03', 0),
(N'241230004', N'Phạm Minh',  N'Dũng',   N'D21HTTT1', N'Nam', N'Thái Bình',  '2003-11-30', 0),
(N'241230005', N'Hoàng Thị',  N'Hà',     N'D21HTTT1', N'Nữ', N'Hà Nam',     '2003-01-17', 0),
(N'241230006', N'Vũ Đức',     N'Huy',    N'D22CNPM1', N'Nam', N'Bắc Ninh',   '2004-04-08', 0),
(N'241230007', N'Đặng Thu',   N'Hương',  N'D22CNPM1', N'Nữ', N'Hưng Yên',   '2004-07-25', 0),
(N'241230008', N'Bùi Quang',  N'Khải',   N'D21VT01',  N'Nam', N'Hà Nội',     '2003-03-12', 0),
(N'241230009', N'Đỗ Thị',     N'Lan',    N'D21VT01',  N'Nữ', N'Vĩnh Phúc',  '2003-06-19', 0),
(N'241230010', N'Ngô Văn',    N'Long',   N'D21VT01',  N'Nam', N'Thanh Hóa',  '2003-10-05', 0),
(N'241230011', N'Phan Thanh', N'Mai',    N'D22VT01',  N'Nữ', N'Nghệ An',    '2004-02-28', 0),
(N'241230012', N'Lý Gia',     N'Nam',    N'D22VT01',  N'Nam', N'Quảng Ninh', '2004-08-16', 0),
(N'241230013', N'Trương Hải', N'Phong',  N'D22DTVT1', N'Nam', N'Hà Tĩnh',    '2004-12-01', 0),
(N'241230014', N'Dương Thị',  N'Quỳnh',  N'D22DTVT1', N'Nữ', N'Hà Nội',     '2004-09-09', 0);

/* -------------------------- MONHOC ---------------------------- */
INSERT INTO Monhoc (MAMH, TENMH, SOTIET_LT, SOTIET_TH) VALUES
(N'CSDL',  N'Cơ sở dữ liệu',                     45, 30),
(N'LTHDT', N'Lập trình hướng đối tượng',         45, 30),
(N'CTDL',  N'Cấu trúc dữ liệu và giải thuật',    45, 15),
(N'MMT',   N'Mạng máy tính',                     45, 15),
(N'XLTHS', N'Xử lý tín hiệu số',                 45, 15),
(N'HTVT',  N'Hệ thống viễn thông',               45, 0),
(N'GT1',   N'Giải tích 1',                       45, 0);

/* ------------------------- GIANGVIEN -------------------------- */
INSERT INTO GIANGVIEN (MAGV, HO, TEN, HOCVI, HOCHAM, CHUYENMON, MAKHOA) VALUES
(N'GV001', N'Nguyễn Văn',  N'Hùng',  N'Tiến sĩ',  N'PGS', N'Cơ sở dữ liệu',        N'CNTT'),
(N'GV002', N'Lê Thị',      N'Mai',   N'Thạc sĩ',  NULL,   N'Lập trình',           N'CNTT'),
(N'GV003', N'Trần Quốc',   N'Bảo',   N'Thạc sĩ',  NULL,   N'Mạng máy tính',       N'CNTT'),
(N'GV004', N'Phạm Hoàng',  N'Nam',   N'Tiến sĩ',  NULL,   N'Xử lý tín hiệu',      N'VT'),
(N'GV005', N'Đào Thị',     N'Lan',   N'Thạc sĩ',  NULL,   N'Hệ thống viễn thông', N'VT');

/* ------------------------- LOPTINCHI -------------------------- */
SET IDENTITY_INSERT LOPTINCHI ON;
INSERT INTO LOPTINCHI (MALTC, NIENKHOA, HOCKY, MAMH, NHOM, MAGV, MAKHOA, SOSVTOITHIEU, HUYLOP) VALUES
(1, N'2023-2024', 1, N'CSDL',  1, N'GV001', N'CNTT', 3, 0),
(2, N'2023-2024', 1, N'LTHDT', 1, N'GV002', N'CNTT', 3, 0),
(3, N'2023-2024', 2, N'CTDL',  1, N'GV002', N'CNTT', 3, 0),
(4, N'2023-2024', 2, N'MMT',   1, N'GV003', N'CNTT', 3, 0),
(5, N'2023-2024', 1, N'XLTHS', 1, N'GV004', N'VT',   3, 0),
(6, N'2023-2024', 2, N'HTVT',  1, N'GV005', N'VT',   3, 0),
(7, N'2023-2024', 1, N'GT1',   1, N'GV004', N'VT',   2, 0);
SET IDENTITY_INSERT LOPTINCHI OFF;

/* --------------- DANGKY (sinh viên + điểm CC/GK/CK) ----------- */
-- DIEM_TK là cột tính tự động nên không insert.
-- Một số dòng để NULL để mô phỏng chưa nhập điểm.
INSERT INTO DANGKY (MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK) VALUES
(1, N'241230001',  9, 8.0, 8.5),
(1, N'241230002', 10, 9.0, 9.5),
(1, N'241230003',  8, 7.0, 6.5),
(1, N'241230004',  7, 6.5, 7.0),
(1, N'241230005',  9, 8.5, NULL),
(2, N'241230001', 10, 8.5, 9.0),
(2, N'241230002',  9, 7.5, 8.0),
(2, N'241230004',  8, 7.0, 7.5),
(3, N'241230003',  9, 8.0, 7.5),
(3, N'241230006', 10, 9.5, 9.0),
(3, N'241230007', NULL, NULL, NULL),
(4, N'241230001',  8, 7.5, 8.0),
(4, N'241230006',  9, 8.0, 8.5),
(5, N'241230008',  9, 8.0, 8.0),
(5, N'241230009', 10, 9.0, 9.0),
(5, N'241230010',  7, 6.0, 6.5),
(6, N'241230011',  9, 8.5, 9.0),
(6, N'241230012',  8, 7.0, 7.5),
(6, N'241230013', NULL, NULL, NULL),
(7, N'241230008', 10, 9.0, 9.5),
(7, N'241230014',  8, 7.5, 7.0);

/* ------------------------- TAIKHOAN --------------------------- */
-- Bước 1: tạo tài khoản với salt ngẫu nhiên (mỗi dòng 1 salt riêng)
INSERT INTO TaiKhoan (TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAKHOA, MASV) VALUES
(N'pgv',       REPLICATE('0', 64), LEFT(REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 16), 'PGV',  NULL,    NULL),
(N'khoa_cntt', REPLICATE('0', 64), LEFT(REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 16), 'KHOA', N'CNTT', NULL),
(N'khoa_vt',   REPLICATE('0', 64), LEFT(REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 16), 'KHOA', N'VT',   NULL);

INSERT INTO TaiKhoan (TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAGV)
SELECT RTRIM(MAGV), REPLICATE('0', 64),
       LEFT(REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 16),
       'GV', MAGV
FROM GIANGVIEN;

INSERT INTO TaiKhoan (TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAKHOA, MASV)
SELECT RTRIM(MASV), REPLICATE('0', 64),
       LEFT(REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 16),
       'SV', NULL, MASV
FROM Sinhvien;

-- Bước 2: băm mật khẩu "123456" = SHA-256(SALT + mật khẩu), HEX viết hoa
-- (khớp với PasswordHelper.Hash trong C#: SHA256(UTF8(salt + password)))
UPDATE TaiKhoan
SET MATKHAUHASH = CONVERT(CHAR(64), HASHBYTES('SHA2_256', CONCAT(SALT, '123456')), 2);
GO

/* ------------------------ Kiểm tra nhanh ---------------------- */
SELECT N'Khoa' AS Bang, COUNT(*) AS SoDong FROM Khoa
UNION ALL SELECT N'Lop',        COUNT(*) FROM Lop
UNION ALL SELECT N'Sinhvien',   COUNT(*) FROM Sinhvien
UNION ALL SELECT N'Monhoc',     COUNT(*) FROM Monhoc
UNION ALL SELECT N'GIANGVIEN',  COUNT(*) FROM GIANGVIEN
UNION ALL SELECT N'LOPTINCHI',  COUNT(*) FROM LOPTINCHI
UNION ALL SELECT N'DANGKY',     COUNT(*) FROM DANGKY
UNION ALL SELECT N'TaiKhoan',   COUNT(*) FROM TaiKhoan;
GO
