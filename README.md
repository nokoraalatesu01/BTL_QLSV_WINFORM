# QLDSV_HTC – Hướng dẫn cài đặt & chạy thử

Phần mềm quản lý điểm sinh viên hệ tín chỉ: C# WinForms, .NET 8, SQL Server local, ADO.NET (`Microsoft.Data.SqlClient`).

## 1. Cấu trúc project

| Thư mục / file | Vai trò |
|---|---|
| `Database/QLDSV_HTC.sql` | **Một file SQL duy nhất**: tạo DB, bảng, ràng buộc + dữ liệu mẫu 2 khoa CNTT & VT |
| `Models/` | Lớp dữ liệu (Khoa, Lop, SinhVien, MonHoc, GiangVien, LopTinChi, DiemSinhVien, TaiKhoan…) |
| `DAL/` | Truy cập dữ liệu: thực thi câu lệnh SQL qua `DataBaseProcess` (`DataReader`, `DataChange`) |
| `BLL/` | Nghiệp vụ + **phân quyền** (`Quyen.cs`) + kiểm tra dữ liệu |
| `Forms/` | Giao diện WinForms, mỗi form gồm `FrmX.cs` (xử lý) + `FrmX.Designer.cs` (bố cục, **mở được bằng Designer kéo thả**) |
| `Helpers/` | `DataBaseProcess` (chuẩn giáo trình LTTQ: `OpenConnect`, `CloseConnect`, `DataReader`, `DataChange`), `Validator`, `DiemHelper`, `PasswordHelper`, `UiHelper`… |
| `Program.cs` | Vòng lặp Đăng nhập → Form chính → (Đăng xuất → Đăng nhập lại) |
| `appsettings.json` | Chuỗi kết nối SQL Server |

## 2. Cấu hình SQL Server local

1. Cài **SQL Server Express** (hoặc Developer) + **SSMS**. Đảm bảo service `SQL Server (SQLEXPRESS)` đang chạy.
2. Mở SSMS, kết nối `.\SQLEXPRESS` (Windows Authentication).
3. Mở `Database/QLDSV_HTC.sql` → Execute (F5) **một lần**.
   (File này **xóa và tạo lại** DB `QLDSV_HTC` – chỉ chạy khi chấp nhận mất dữ liệu cũ.)
4. Sửa `appsettings.json` nếu instance khác:

| Trường hợp | `Data Source` |
|---|---|
| SQL Express mặc định | `.\SQLEXPRESS` |
| SQL Developer (default instance) | `.` hoặc `localhost` |
| LocalDB | `(localdb)\MSSQLLocalDB` |
| Dùng SQL login | bỏ `Integrated Security=True`, thêm `User Id=...;Password=...` |

## 3. Chạy trên Visual Studio 2022

1. Mở `QLDSV_HTC.sln` (cần workload **.NET desktop development**, SDK .NET 8).
2. Chuột phải solution → *Restore NuGet Packages* (tự tải `Microsoft.Data.SqlClient`).
3. `F5` để chạy. `appsettings.json` được copy sang thư mục output (`PreserveNewest`).

## 4. Tài khoản mẫu (mật khẩu `123456`)

| Tên đăng nhập | Vai trò | Phạm vi |
|---|---|---|
| `pgv` | PGV | Toàn trường |
| `khoa_cntt` | KHOA | Chỉ khoa CNTT |
| `khoa_vt` | KHOA | Chỉ khoa VT |
| `GV001`…`GV005` (mã GV) | GV | Khoa của mình; chỉ lớp tín chỉ do mình phụ trách |
| `241230001`, `241230008`… (mã SV) | SV | Chỉ xem điểm của chính mình |

Thêm khoa mới → tự tạo `khoa_<mã khoa>`; thêm giảng viên mới → tự tạo tài khoản (tên = mã GV); thêm sinh viên mới → tự tạo tài khoản (tên = mã SV). Mật khẩu mặc định `123456`, đổi ở *Hệ thống → Đổi mật khẩu*.

## 5. Ma trận phân quyền

Kiểm tra ở **hai lớp**: Form ẩn menu/nút theo `Quyen.CoQuyen`, còn mọi hàm BLL gọi `Quyen.Yeu` (chức năng) và `Quyen.YeuKhoa` (phạm vi khoa) trước khi chạm dữ liệu.

| Chức năng | PGV | KHOA | GV | SV |
|---|---|---|---|---|
| Khoa | Xem + Thêm/Sửa/Xóa | Chỉ xem khoa mình | – | – |
| Lớp | Toàn quyền | Toàn quyền trong khoa mình | – | – |
| Sinh viên | Toàn quyền | Toàn quyền (SV thuộc lớp của khoa mình) | – | – |
| Môn học | Toàn quyền | Chỉ xem | – | – |
| Giảng viên | Toàn quyền (tự tạo tài khoản GV) | Toàn quyền trong khoa mình | – | – |
| Lớp tín chỉ | Toàn quyền | Toàn quyền trong khoa mình | – | – |
| Nhập điểm (chấm + xem điểm) | Mọi lớp tín chỉ | Lớp tín chỉ của khoa mình | **Chỉ lớp tín chỉ mình phụ trách** | – |
| Bảng điểm cá nhân | – | – | – | Chỉ của mình |
| Đổi mật khẩu | ✔ | ✔ | ✔ | ✔ |

## 6. Quy tắc nghiệp vụ đáng chú ý

| Mục | Quy tắc |
|---|---|
| Điểm | `TK = CC×0.1 + GK×0.3 + CK×0.6`; CC nguyên 0–10 (cột `INT`), GK/CK 0–10 bước 0.5; để trống = chưa nhập, TK chỉ có khi đủ 3 điểm |
| Lưu điểm | Kiểm tra ở lưới → kiểm tra lại ở BLL → lưu cả lớp trong **1 transaction** |
| Lớp tín chỉ | Giảng viên phải thuộc khoa mở lớp; đã có SV/điểm thì không đổi niên khóa/học kỳ/môn/nhóm/khoa; không xóa được, chỉ **Hủy lớp** |
| Xóa | Chặn khi còn dữ liệu tham chiếu (khoa còn lớp/GV/LTC, lớp còn SV, SV đã có điểm, môn/GV đã dùng trong LTC) kèm thông báo rõ |
| Không làm | Đăng ký tín chỉ, học phí, nhiều server (đúng đề) |

## 6b. Tính năng bổ sung

| Tính năng | Cách dùng |
|---|---|
| Enter nhảy ô | Ở mọi ô nhập (đăng nhập, đổi mật khẩu, thêm/sửa Khoa, Lớp, SV, GV, Môn học, Lớp tín chỉ) bấm **Enter** để sang ô kế tiếp; ở ô cuối thì Enter thực hiện nút mặc định (Đăng nhập / Đổi mật khẩu). Ô *Tìm kiếm* vẫn dùng Enter để tìm. |
| Enter trong lưới nhập điểm | Gõ điểm xong bấm **Enter** → sang ô bên phải (CC → GK → CK), hết hàng thì xuống CC của sinh viên kế tiếp. |
| Xuất Excel bảng điểm | *Đào tạo → Nhập điểm* → tải danh sách lớp tín chỉ → nút **📊 Xuất Excel** (PGV, KHOA, GV; GV chỉ xuất được lớp mình phụ trách). Xuất ra `.xlsx` gồm STT, Mã SV, Họ tên, Lớp, CC, GK, CK, Tổng kết. |

Xuất Excel dùng thư viện NuGet **ClosedXML** (tự tải khi *Restore NuGet Packages*, cần Internet lần đầu).

## 7. Danh sách kiểm thử (làm lần lượt)

| # | Kịch bản | Kết quả mong đợi |
|---|---|---|
| 1 | Đăng nhập sai mật khẩu | Báo "Tên đăng nhập hoặc mật khẩu không đúng." |
| 2 | Đăng nhập `pgv` | Thấy đủ menu Danh mục + Đào tạo |
| 3 | Đăng nhập `khoa_cntt` | Form Khoa & Môn học chỉ-xem; Lớp/SV/GV/LTC chỉ hiện dữ liệu CNTT; combo Khoa chỉ có CNTT |
| 4 | Đăng nhập `241230001` | Chỉ có menu *Sinh viên → Bảng điểm cá nhân*, thấy điểm của mình |
| 5 | Khoa: thêm `DTVT` | Thêm được, thông báo tài khoản `khoa_dtvt` |
| 6 | Khoa: xóa `CNTT` | Bị chặn vì còn lớp/GV/LTC |
| 7 | Lớp: thêm trùng mã | "Mã lớp đã tồn tại" |
| 8 | SV: thêm mới rồi đăng nhập bằng mã SV vừa tạo | Đăng nhập được với `123456` |
| 9 | SV: xóa `241230001` | Bị chặn (đã có điểm) |
| 10 | SV: tìm "Hà" / "24123000" / lọc theo lớp | Kết quả đúng |
| 11 | Môn học: tìm "dữ liệu" | Ra *Cơ sở dữ liệu*, *Cấu trúc dữ liệu…* |
| 12 | LTC: tạo lớp với GV khác khoa | Bị chặn |
| 13 | LTC: niên khóa `2023-2025` | Báo lỗi định dạng |
| 14 | Nhập điểm: chọn LTC 1 (CSDL) | 5 SV; SV `241230005` thiếu CK nên chưa có TK |
| 15 | Nhập CK `241230005` = 7.5, CC 9, GK 8.5 | TK hiện `7.95`; Lưu → mở lại vẫn đúng |
| 16 | Gõ GK = 7.3 hoặc 11 hoặc `abc` | Ô báo lỗi đỏ, không lưu được |
| 17 | Sửa điểm rồi đổi lớp/đóng form | Combo bị khóa / hỏi xác nhận bỏ thay đổi |
| 18 | `khoa_vt` thử nhập điểm LTC 1 | Không có trong danh sách (khác khoa); gọi thẳng BLL cũng bị chặn |
| 20 | Đăng nhập `GV001` | Chỉ có menu *Đào tạo → Nhập điểm* (không có Danh mục, Lớp tín chỉ) |
| 21 | `GV001` mở Nhập điểm | Chỉ thấy lớp tín chỉ 1 (CSDL), không thấy lớp của GV002/GV003; gọi thẳng BLL lớp khác cũng bị chặn |
| 22 | Giảng viên: thêm `GV006` rồi đăng nhập `GV006` | Đăng nhập được với `123456` |
| 19 | Đổi mật khẩu → đăng xuất → đăng nhập lại | Mật khẩu mới có hiệu lực |

## 8. Xử lý lỗi thường gặp

| Lỗi | Nguyên nhân / cách xử lý |
|---|---|
| "Lỗi cơ sở dữ liệu (mã 53/-1)…" | SQL Server chưa chạy hoặc sai `Data Source` trong `appsettings.json` |
| "Cannot open database QLDSV_HTC" | Chưa chạy `Database/QLDSV_HTC.sql` |
| "Không tìm thấy appsettings.json" | Kiểm tra *Copy to Output Directory* = *Copy if newer* |
| Đăng nhập seed không được | Chạy lại file `Database/QLDSV_HTC.sql` (hash tạo bằng `HASHBYTES`, khớp `PasswordHelper`) |
