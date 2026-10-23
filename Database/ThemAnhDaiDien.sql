/* =====================================================================
   ThemAnhDaiDien.sql - Bổ sung cột lưu ảnh đại diện cho sinh viên.
   AN TOÀN: KHÔNG xóa database, KHÔNG xóa/sửa dữ liệu hiện có.
   Chạy lại nhiều lần cũng không sao (chỉ thêm cột nếu chưa có).
   Lưu ý: file Database/QLDSV_HTC.sql sẽ XÓA và tạo lại database -> nếu chạy lại file đó
          thì phải chạy lại script này (ảnh đã lưu trước đó sẽ mất cùng toàn bộ dữ liệu).
   ===================================================================== */
USE QLDSV_HTC;
GO
IF COL_LENGTH('dbo.Sinhvien', 'ANHDAIDIEN') IS NULL
BEGIN
    ALTER TABLE dbo.Sinhvien ADD ANHDAIDIEN VARBINARY(MAX) NULL;   -- ảnh JPG/PNG đã thu nhỏ (<= 2 MB)
    PRINT N'Đã thêm cột Sinhvien.ANHDAIDIEN.';
END
ELSE
    PRINT N'Cột Sinhvien.ANHDAIDIEN đã tồn tại - không thay đổi gì.';
GO
