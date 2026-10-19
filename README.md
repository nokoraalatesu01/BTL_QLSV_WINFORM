# BÀI TẬP LỚN: HỆ THỐNG QUẢN LÝ SINH VIÊN (C# WINFORMS)
**Môn học:** Lập trình trực quan (LTTQ)  
**Nhánh Git:** `DaiKaThaiBinh`  
**Công nghệ:** C# .NET Windows Forms, ADO.NET SQL Server / Auto-Fallback Local Store, EPPlus Excel Export.

---

## 1. TỔNG QUAN VÀ TƯ DUY THIẾT KẾ ÁP DỤNG TỪ 4 TUẦN HỌC

Dự án được xây dựng dựa trên việc nghiên cứu kĩ lưỡng và chắt lọc tư duy code từ 4 tài liệu giảng dạy của giảng viên:

### 📌 Tuần 1: Tư duy Hướng đối tượng & Nền tảng WinForms
- Xây dựng mô hình lớp thực thể rõ ràng với các thuộc tính (`Properties`), phương thức nhập/xuất/tính toán.
- Thiết kế giao diện WinForms chuẩn: Button, TextBox, Label với phím tắt truy cập nhanh (`&` trong Text như `&Tính`, `T&hêm`, `&Sửa`, `&Xóa`, `Th&oát`).
- Hộp thoại cảnh báo và xác nhận người dùng: `MessageBox.Show("...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)`.

### 📌 Tuần 2: Nâng cao điều khiển & Ràng buộc toàn vẹn dữ liệu
- Sử dụng đa dạng các Control: `ComboBox` (chọn giá trị, `DropDownList`), `DateTimePicker` (định dạng ngày tháng chuẩn), `RadioButton` (chọn giới tính, loại hình).
- Ràng buộc nhập liệu chặt chẽ: Sự kiện `KeyPress` chỉ cho phép nhập số nguyên vào các ô số điện thoại, tín chỉ.
- Truyền dữ liệu và trạng thái giữa các Form thông qua lớp tĩnh (`SessionManager`) và hàm tạo (`Constructor`).

### 📌 Tuần 3: Tổ chức ứng dụng đa biểu mẫu với MenuStrip
- Thiết kế Form chính (`frmMain`) làm trung tâm điều hướng với thanh thực đơn `MenuStrip` chuyên nghiệp:
  * Thực đơn **Hệ thống**: Đổi mật khẩu, Đăng xuất, Thoát.
  * Thực đơn **Danh mục**: Quản lý Sinh viên, Lớp - Khoa, Môn học.
  * Thực đơn **Học tập**: Bảng điểm học phần & Kết quả.
  * Thực đơn **Báo cáo Thống kê**: Thống kê tổng hợp & xếp loại.
  * Thực đơn **Trợ giúp**: Thông tin bài tập lớn.
- Thanh công cụ nhanh (`ToolStrip`), thanh trạng thái (`StatusStrip`) hiển thị người đăng nhập và thời gian thực bằng `Timer`.

### 📌 Tuần 4: Lập trình CSDL & Giao diện chuẩn phân khu (Dock & Splitter Layout)
- **Lớp `DataBaseProcess` trong thư mục `Classes`**:
  * `OpenConnect()`: Mở kết nối CSDL.
  * `CloseConnect()`: Đóng và giải phóng kết nối.
  * `DataReader(string sqlSelect)`: Đọc dữ liệu trả về `DataTable`.
  * `DataChange(string sql)`: Thực thi câu lệnh Insert, Update, Delete.
- **Bố cục giao diện chuẩn theo từng phân vùng (Chuẩn giáo án Tuần 4)**:
  * `(1) Panel Top`: Tiêu đề chức năng (`lblTieuDe`), đổi tên tương ứng với hành động đang làm.
  * `(2) Panel Bottom`: Thanh nút chức năng (`btnTimKiem`, `btnThem`, `btnSua`, `btnXoa`, `btnLamMoi`, `btnXuatExcel`, `btnThoat`).
  * `(3) GroupBox Right`: Chi tiết đối tượng (`grbChiTiet`), chứa các ô nhập liệu cùng 2 nút lệnh `btnLuu` và `btnHuy`. Kèm `Splitter Dock = Left` để co giãn độ rộng.
  * `(4) GroupBox Top`: Tìm kiếm và bộ lọc (`grbTimKiem`). Kèm `Splitter Dock = Top`.
  * `(5) GroupBox Fill`: Kết quả hiển thị (`grbKetQua`), chứa `DataGridView` chiếm trọn không gian còn lại.
- **Điều khiển trạng thái nút bấm (State Machine chuẩn mực của cô)**:
  * Khi Form Load: Khóa GroupBox Chi tiết (`HienChiTiet(false)`), vô hiệu hóa nút Sửa, Xóa (`btnSua.Enabled = false`, `btnXoa.Enabled = false`), kích hoạt nút Thêm.
  * Khi Click vào dòng trên DataGridView: Đổ dữ liệu lên các ô chi tiết, kích hoạt `btnSua.Enabled = true`, `btnXoa.Enabled = true`, vô hiệu hóa `btnThem.Enabled = false`.
  * Khi bấm Thêm: Đổi tiêu đề thành "THÊM MỚI", xóa trắng chi tiết (`XoaTrangChiTiet()`), cấm nút Sửa/Xóa, mở khóa chi tiết `HienChiTiet(true)`.
  * Khi bấm Sửa: Đổi tiêu đề thành "CẬP NHẬT", khóa ô Khóa chính không cho sửa, mở khóa các ô còn lại.
  * Khi bấm Xóa: Bật cảnh báo xác nhận `MessageBoxButtons.YesNo`.
  * Khi bấm Lưu: Kiểm tra trạng thái bằng `btnThem.Enabled` (INSERT) hoặc `btnSua.Enabled` (UPDATE), validate dữ liệu bằng `ErrorProvider` (`errChiTiet`).
  * Khi bấm Hủy: Đưa giao diện về trạng thái ban đầu.

---

## 2. KIẾN TRÚC 3 LỚP (THAM KHẢO TỪ LIBRARYMANAGERAPP)

Dự án được phân tầng chuẩn mực theo mô hình 3 lớp:
```
BTL_QLSV_WINFORM/
├── Classes/
│   └── DataBaseProcess.cs         # Lớp kết nối CSDL chuẩn của cô giáo + Auto-Fallback
├── DTO/                            # Data Transfer Objects (Các lớp thực thể dữ liệu)
│   ├── SinhVienDTO.cs
│   ├── LopDTO.cs
│   ├── KhoaDTO.cs
│   ├── MonHocDTO.cs
│   ├── DiemDTO.cs
│   └── TaiKhoanDTO.cs
├── DAL/                            # Data Access Layer (Truy xuất CSDL bằng DataBaseProcess)
│   ├── SinhVienDAL.cs
│   ├── LopDAL.cs
│   ├── KhoaDAL.cs
│   ├── MonHocDAL.cs
│   ├── DiemDAL.cs
│   └── TaiKhoanDAL.cs
├── BLL/                            # Business Logic Layer (Xử lý nghiệp vụ & kiểm tra logic)
│   ├── AuthBLL.cs
│   ├── SinhVienBLL.cs
│   └── DiemBLL.cs
├── GUI/                            # Graphical User Interface (Giao diện người dùng)
│   ├── frmDangNhap.cs             # Form Đăng nhập
│   ├── frmMain.cs                 # Form Chính - MenuStrip & Dashboard tổng quan
│   ├── frmSinhVien.cs             # Form Quản lý Sinh viên (Chuẩn tuần 4)
│   ├── frmLopKhoa.cs              # Form Quản lý Lớp & Khoa
│   ├── frmMonHoc.cs               # Form Quản lý Môn học & Tín chỉ
│   ├── frmDiem.cs                 # Form Nhập điểm, Tính điểm tự động & Tra cứu
│   ├── frmThongKe.cs              # Form Báo cáo, Thống kê sinh viên & Xếp loại
│   ├── frmDoiMatKhau.cs           # Form Đổi mật khẩu
│   └── frmThongTinNhom.cs         # Form Giới thiệu Bài tập lớn
├── Helpers/                        # Các tiện ích bổ trợ
│   ├── ExcelHelper.cs             # Xuất dữ liệu DataGridView ra file Excel (.xlsx) chuẩn đẹp
│   └── SessionManager.cs          # Quản lý phiên làm việc người dùng
├── Database_QLSV.sql               # File Script tạo Database & Bảng cho SQL Server
├── BTL_QLSV_WINFORM.sln            # Solution mở trên Visual Studio
├── BTL_QLSV_WINFORM.slnx           # Solution định dạng XML hiện đại
└── BTL_QLSV_WINFORM.csproj         # Project file .NET
```

---

## 3. ĐẢM BẢO "BẬT LÊN LÀ CHẠY ĐƯỢC NGAY 100%"

Để đảm bảo yêu cầu của bạn: **"khi code thì t vào vs bật lên phải chạy đc nhé"**:
1. `DataBaseProcess` được tích hợp cơ chế **Auto-Detect & Fallback**:
   - Nếu máy tính có SQL Server chạy: Ứng dụng tự động kết nối và nạp cơ sở dữ liệu.
   - Nếu máy tính chưa cài / chưa bật dịch vụ SQL Server: Ứng dụng **tự động chuyển sang chế độ Local In-Memory Data Store** với bộ dữ liệu mẫu đầy đủ sẵn có. Bạn chỉ cần bấm `F5` / `Start` trong Visual Studio là chương trình chạy mượt mà ngay lập tức, không bao giờ gặp lỗi crash do CSDL!
2. Đã kèm sẵn file `Database_QLSV.sql` chuẩn để bạn có thể import vào SQL Server Management Studio (SSMS) bất cứ lúc nào.

### Tài khoản đăng nhập mẫu:
- **Tài khoản Quản trị (Admin):**  
  * Tên đăng nhập: `admin`  
  * Mật khẩu: `123456`
- **Tài khoản Giảng viên:**  
  * Tên đăng nhập: `giangvien`  
  * Mật khẩu: `123456`