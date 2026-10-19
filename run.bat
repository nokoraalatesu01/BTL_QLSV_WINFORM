@echo off
title Quan Ly Sinh Vien - BTL LTTQ
cd /d "%~dp0"

echo ===================================================================
echo             HE THONG QUAN LY SINH VIEN - C# WINFORMS
echo             Mon hoc: Lap trinh truc quan (LTTQ)
echo ===================================================================
echo.
echo [*] Tai khoan dang nhap:
echo     - Admin:      admin / 123456
echo     - Giang vien: giangvien / 123456
echo.
echo [*] Dang khoi dong ung dung, vui long cho trong giay lat...
echo.

dotnet run --project BTL_QLSV_WINFORM.csproj

echo.
echo ===================================================================
echo [*] Ung dung da ket thuc.
echo ===================================================================
pause
