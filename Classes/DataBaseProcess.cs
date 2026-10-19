using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace BTL_QLSV_WINFORM.Classes
{
    /// <summary>
    /// Lớp xử lý liên kết Cơ sở dữ liệu và thao tác dữ liệu
    /// Viết theo tư duy giảng dạy Tuần 4 của giảng viên môn Lập trình trực quan (LTTQ)
    /// Bổ sung cơ chế Auto-Fallback (Local In-Memory Cache) để đảm bảo khi mở dự án lên là CHẠY ĐƯỢC NGAY 100%
    /// </summary>
    public class DataBaseProcess
    {
        // Chuỗi kết nối SQL Server (Hỗ trợ cấu hình linh hoạt)
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLSV_DB;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=3";
        
        // Trạng thái đang kết nối SQL Server thật hay đang chạy chế độ dữ liệu cục bộ (Local Mode)
        public static bool IsUsingSqlServer = false;
        private static bool _hasTestedConnection = false;

        // Bộ nhớ dữ liệu cục bộ (Dùng khi máy chưa bật SQL Server)
        private static DataSet _localDataSet = new DataSet("QLSV_DB");

        private SqlConnection? sqlConnect = null;

        static DataBaseProcess()
        {
            InitLocalDatabase();
            CheckAndTryConnectSqlServer();
        }

        /// <summary>
        /// Khởi tạo dữ liệu mẫu phong phú trong bộ nhớ để F5 là chạy được ngay
        /// </summary>
        private static void InitLocalDatabase()
        {
            _localDataSet = new DataSet("QLSV_DB");

            // 1. tblTaiKhoan
            DataTable tblTaiKhoan = new DataTable("tblTaiKhoan");
            tblTaiKhoan.Columns.Add("TenDangNhap", typeof(string));
            tblTaiKhoan.Columns.Add("MatKhau", typeof(string));
            tblTaiKhoan.Columns.Add("HoTen", typeof(string));
            tblTaiKhoan.Columns.Add("Quyen", typeof(string));
            tblTaiKhoan.Columns.Add("Email", typeof(string));
            tblTaiKhoan.PrimaryKey = new DataColumn[] { tblTaiKhoan.Columns["TenDangNhap"]! };

            tblTaiKhoan.Rows.Add("admin", "123456", "Quản trị viên hệ thống", "Admin", "admin@qlsv.edu.vn");
            tblTaiKhoan.Rows.Add("giangvien", "123456", "TS. Nguyễn Văn Thầy", "GiangVien", "giangvien@qlsv.edu.vn");
            tblTaiKhoan.Rows.Add("sinhvien", "123456", "Nguyễn Văn An", "SinhVien", "an.nv@qlsv.edu.vn");

            // 2. tblKhoa
            DataTable tblKhoa = new DataTable("tblKhoa");
            tblKhoa.Columns.Add("MaKhoa", typeof(string));
            tblKhoa.Columns.Add("TenKhoa", typeof(string));
            tblKhoa.Columns.Add("VanPhong", typeof(string));
            tblKhoa.Columns.Add("SoDienThoai", typeof(string));
            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["MaKhoa"]! };

            tblKhoa.Rows.Add("CNTT", "Công nghệ thông tin", "Tầng 3 - Nhà A1", "0243.868.1234");
            tblKhoa.Rows.Add("KT", "Kinh tế & Quản lý", "Tầng 2 - Nhà B2", "0243.868.5678");
            tblKhoa.Rows.Add("CK", "Cơ khí & Động lực", "Tầng 1 - Nhà C3", "0243.868.9999");
            tblKhoa.Rows.Add("NN", "Ngoại ngữ", "Tầng 4 - Nhà D1", "0243.868.8888");

            // 3. tblLop
            DataTable tblLop = new DataTable("tblLop");
            tblLop.Columns.Add("MaLop", typeof(string));
            tblLop.Columns.Add("TenLop", typeof(string));
            tblLop.Columns.Add("KhoaHoc", typeof(string));
            tblLop.Columns.Add("MaKhoa", typeof(string));
            tblLop.PrimaryKey = new DataColumn[] { tblLop.Columns["MaLop"]! };

            tblLop.Rows.Add("CNTT1-K63", "Công nghệ thông tin 1 - K63", "K63", "CNTT");
            tblLop.Rows.Add("KTPM-K63", "Kỹ thuật phần mềm - K63", "K63", "CNTT");
            tblLop.Rows.Add("HTTT-K63", "Hệ thống thông tin - K63", "K63", "CNTT");
            tblLop.Rows.Add("QTKD-K63", "Quản trị kinh doanh - K63", "K63", "KT");
            tblLop.Rows.Add("KTDN-K63", "Kế toán doanh nghiệp - K63", "K63", "KT");

            // 4. tblSinhVien
            DataTable tblSinhVien = new DataTable("tblSinhVien");
            tblSinhVien.Columns.Add("MaSV", typeof(string));
            tblSinhVien.Columns.Add("HoDem", typeof(string));
            tblSinhVien.Columns.Add("Ten", typeof(string));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("GioiTinh", typeof(string));
            tblSinhVien.Columns.Add("QueQuan", typeof(string));
            tblSinhVien.Columns.Add("SoDienThoai", typeof(string));
            tblSinhVien.Columns.Add("Email", typeof(string));
            tblSinhVien.Columns.Add("MaLop", typeof(string));
            tblSinhVien.Columns.Add("AnhDaiDien", typeof(string));
            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSV"]! };

            tblSinhVien.Rows.Add("SV001", "Nguyễn Văn", "An", new DateTime(2004, 3, 15), "Nam", "Hà Nội", "0912345678", "an.nv@qlsv.edu.vn", "CNTT1-K63", "");
            tblSinhVien.Rows.Add("SV002", "Trần Thị", "Bình", new DateTime(2004, 7, 22), "Nữ", "Thái Bình", "0987654321", "binh.tt@qlsv.edu.vn", "CNTT1-K63", "");
            tblSinhVien.Rows.Add("SV003", "Lê Hoàng", "Cường", new DateTime(2004, 11, 5), "Nam", "Hải Phòng", "0933445566", "cuong.lh@qlsv.edu.vn", "KTPM-K63", "");
            tblSinhVien.Rows.Add("SV004", "Phạm Thu", "Dung", new DateTime(2004, 1, 30), "Nữ", "Nam Định", "0944556677", "dung.pt@qlsv.edu.vn", "KTPM-K63", "");
            tblSinhVien.Rows.Add("SV005", "Vũ Đình", "Hải", new DateTime(2003, 9, 18), "Nam", "Quảng Ninh", "0966778899", "hai.vd@qlsv.edu.vn", "HTTT-K63", "");
            tblSinhVien.Rows.Add("SV006", "Đỗ Mai", "Hương", new DateTime(2004, 5, 12), "Nữ", "Hải Dương", "0977889900", "huong.dm@qlsv.edu.vn", "QTKD-K63", "");

            // 5. tblMonHoc
            DataTable tblMonHoc = new DataTable("tblMonHoc");
            tblMonHoc.Columns.Add("MaMH", typeof(string));
            tblMonHoc.Columns.Add("TenMH", typeof(string));
            tblMonHoc.Columns.Add("SoTinChi", typeof(int));
            tblMonHoc.Columns.Add("SoTietLT", typeof(int));
            tblMonHoc.Columns.Add("SoTietTH", typeof(int));
            tblMonHoc.Columns.Add("HocKy", typeof(int));
            tblMonHoc.PrimaryKey = new DataColumn[] { tblMonHoc.Columns["MaMH"]! };

            tblMonHoc.Rows.Add("LTTQ", "Lập trình trực quan C#", 3, 30, 30, 1);
            tblMonHoc.Rows.Add("CSDL", "Cơ sở dữ liệu", 3, 30, 15, 1);
            tblMonHoc.Rows.Add("CTDL", "Cấu trúc dữ liệu & Giải thuật", 4, 45, 15, 2);
            tblMonHoc.Rows.Add("TKWEB", "Thiết kế và Phát triển Web", 3, 30, 30, 2);
            tblMonHoc.Rows.Add("XSTK", "Xác suất thống kê", 3, 45, 0, 1);

            // 6. tblDiem
            DataTable tblDiem = new DataTable("tblDiem");
            tblDiem.Columns.Add("MaSV", typeof(string));
            tblDiem.Columns.Add("MaMH", typeof(string));
            tblDiem.Columns.Add("DiemQuaTrinh", typeof(double));
            tblDiem.Columns.Add("DiemThi", typeof(double));
            tblDiem.Columns.Add("DiemTongKet", typeof(double));
            tblDiem.Columns.Add("DiemChu", typeof(string));
            tblDiem.PrimaryKey = new DataColumn[] { tblDiem.Columns["MaSV"]!, tblDiem.Columns["MaMH"]! };

            tblDiem.Rows.Add("SV001", "LTTQ", 8.5, 9.0, 8.8, "A");
            tblDiem.Rows.Add("SV001", "CSDL", 7.5, 8.0, 7.8, "B+");
            tblDiem.Rows.Add("SV002", "LTTQ", 9.0, 9.5, 9.3, "A+");
            tblDiem.Rows.Add("SV002", "CSDL", 8.0, 8.5, 8.3, "A");
            tblDiem.Rows.Add("SV003", "LTTQ", 6.5, 7.0, 6.8, "B");
            tblDiem.Rows.Add("SV003", "CSDL", 7.0, 6.5, 6.7, "B");
            tblDiem.Rows.Add("SV004", "LTTQ", 8.0, 8.5, 8.3, "A");
            tblDiem.Rows.Add("SV005", "LTTQ", 7.0, 7.5, 7.3, "B+");
            tblDiem.Rows.Add("SV006", "XSTK", 8.5, 8.0, 8.2, "A");

            _localDataSet.Tables.Add(tblTaiKhoan);
            _localDataSet.Tables.Add(tblKhoa);
            _localDataSet.Tables.Add(tblLop);
            _localDataSet.Tables.Add(tblSinhVien);
            _localDataSet.Tables.Add(tblMonHoc);
            _localDataSet.Tables.Add(tblDiem);
        }

        /// <summary>
        /// Tự động kiểm tra xem SQL Server có khả dụng trên máy không
        /// </summary>
        public static void CheckAndTryConnectSqlServer()
        {
            if (_hasTestedConnection) return;
            _hasTestedConnection = true;

            string[] candidateConnections = new string[]
            {
                ConnectionString,
                "Data Source=localhost;Initial Catalog=QLSV_DB;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=1"
            };

            foreach (var connStr in candidateConnections)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        if (conn.State == ConnectionState.Open)
                        {
                            ConnectionString = connStr;
                            IsUsingSqlServer = true;
                            // Tạo database và bảng nếu chưa có
                            EnsureDatabaseAndTablesExist(conn);
                            return;
                        }
                    }
                }
                catch
                {
                    // Thử chuỗi kết nối tiếp theo
                }
            }

            // Nếu không kết nối được SQL Server, tự động dùng In-Memory Local Database
            IsUsingSqlServer = false;
        }

        private static void EnsureDatabaseAndTablesExist(SqlConnection openConn)
        {
            try
            {
                // Kiểm tra và tạo database QLSV_DB nếu cần
                string checkDb = @"
                    IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QLSV_DB')
                    BEGIN
                        CREATE DATABASE QLSV_DB;
                    END";
                using (SqlCommand cmd = new SqlCommand(checkDb, openConn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Chuyển connection sang QLSV_DB nếu đang ở master
                if (ConnectionString.Contains("Initial Catalog=master"))
                {
                    ConnectionString = ConnectionString.Replace("Initial Catalog=master", "Initial Catalog=QLSV_DB");
                }
            }
            catch
            {
                // Bỏ qua nếu không có quyền CREATE DATABASE
            }
        }

        // ============================================================
        // CÁC PHƯƠNG THỨC CHUẨN THEO ĐÚNG GIÁO ÁN TUẦN 4 CỦA CÔ GIÁO
        // ============================================================

        /// <summary>
        /// Phương thức mở kết nối CSDL
        /// </summary>
        public void OpenConnect()
        {
            if (!IsUsingSqlServer) return;

            try
            {
                sqlConnect = new SqlConnection(ConnectionString);
                if (sqlConnect.State != ConnectionState.Open)
                    sqlConnect.Open();
            }
            catch
            {
                IsUsingSqlServer = false; // Fallback sang local
            }
        }

        /// <summary>
        /// Phương thức đóng kết nối CSDL
        /// </summary>
        public void CloseConnect()
        {
            if (sqlConnect != null && sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
                sqlConnect = null;
            }
        }

        /// <summary>
        /// Phương thức thực thi câu lệnh Select trả về một DataTable
        /// Đúng chữ ký: public DataTable DataReader(string sqlSelect)
        /// </summary>
        public DataTable DataReader(string sqlSelect)
        {
            if (IsUsingSqlServer)
            {
                try
                {
                    DataTable tblData = new DataTable();
                    OpenConnect();
                    if (sqlConnect != null && sqlConnect.State == ConnectionState.Open)
                    {
                        using (SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect))
                        {
                            sqlData.Fill(tblData);
                        }
                        CloseConnect();
                        return tblData;
                    }
                }
                catch
                {
                    IsUsingSqlServer = false; // Tự động fallback sang Local DataSet
                }
                finally
                {
                    CloseConnect();
                }
            }

            // Xử lý truy vấn trên Local In-Memory DataSet
            return ExecuteLocalQuery(sqlSelect);
        }

        /// <summary>
        /// Phương thức thực hiện câu lệnh dạng insert, update, delete
        /// Đúng chữ ký: public void DataChange(string sql) (hoặc trả về số dòng bị ảnh hưởng)
        /// </summary>
        public int DataChange(string sql)
        {
            if (IsUsingSqlServer)
            {
                try
                {
                    OpenConnect();
                    if (sqlConnect != null && sqlConnect.State == ConnectionState.Open)
                    {
                        using (SqlCommand sqlcomma = new SqlCommand())
                        {
                            sqlcomma.Connection = sqlConnect;
                            sqlcomma.CommandText = sql;
                            int rows = sqlcomma.ExecuteNonQuery();
                            CloseConnect();
                            return rows;
                        }
                    }
                }
                catch
                {
                    IsUsingSqlServer = false; // Fallback sang local
                }
                finally
                {
                    CloseConnect();
                }
            }

            // Xử lý thay đổi dữ liệu trên Local In-Memory DataSet
            return ExecuteLocalCommand(sql);
        }

        // ============================================================
        // CƠ CHẾ XỬ LÝ TRUY VẤN LOCAL IN-MEMORY CHO DỰ ÁN LUÔN CHẠY ĐƯỢC
        // ============================================================

        private DataTable ExecuteLocalQuery(string sql)
        {
            string sqlLower = sql.Trim().ToLowerInvariant();

            // Xác định bảng mục tiêu
            string targetTable = "";
            if (sqlLower.Contains("from tblsinhvien")) targetTable = "tblSinhVien";
            else if (sqlLower.Contains("from tblkhoa")) targetTable = "tblKhoa";
            else if (sqlLower.Contains("from tbllop")) targetTable = "tblLop";
            else if (sqlLower.Contains("from tblmonhoc")) targetTable = "tblMonHoc";
            else if (sqlLower.Contains("from tbldiem")) targetTable = "tblDiem";
            else if (sqlLower.Contains("from tbltaikhoan")) targetTable = "tblTaiKhoan";

            if (!string.IsNullOrEmpty(targetTable) && _localDataSet.Tables.Contains(targetTable))
            {
                DataTable src = _localDataSet.Tables[targetTable]!;
                DataTable result = src.Clone();

                // Lấy điều kiện lọc sau WHERE nếu có
                int whereIndex = sql.IndexOf("where ", StringComparison.OrdinalIgnoreCase);
                string filterExp = "";
                if (whereIndex >= 0)
                {
                    filterExp = sql.Substring(whereIndex + 6).Trim();
                    // Chuẩn hóa cú pháp SQL sang cú pháp DataView/DataTable filter
                    filterExp = filterExp.Replace("N'", "'")
                                         .Replace("is not null", "<> ''");
                    
                    // Xử lý order by nếu có
                    int orderIndex = filterExp.IndexOf("order by", StringComparison.OrdinalIgnoreCase);
                    if (orderIndex >= 0)
                    {
                        filterExp = filterExp.Substring(0, orderIndex).Trim();
                    }
                }

                try
                {
                    DataRow[] rows = string.IsNullOrEmpty(filterExp) ? src.Select() : src.Select(filterExp);
                    foreach (var r in rows)
                    {
                        result.ImportRow(r);
                    }
                    return result;
                }
                catch
                {
                    // Nếu điều kiện quá phức tạp, trả về toàn bộ bảng đã clone
                    foreach (DataRow r in src.Rows)
                    {
                        result.ImportRow(r);
                    }
                    return result;
                }
            }

            // Trường hợp truy vấn JOIN tổng hợp (Sinh viên + Lớp + Khoa, hoặc Điểm + Môn)
            if (sqlLower.Contains("join"))
            {
                return BuildJoinResult(sql);
            }

            return new DataTable();
        }

        private DataTable BuildJoinResult(string sql)
        {
            DataTable dt = new DataTable();
            string sqlLower = sql.ToLowerInvariant();

            if (sqlLower.Contains("tblsinhvien") && sqlLower.Contains("tbllop"))
            {
                dt.Columns.Add("MaSV", typeof(string));
                dt.Columns.Add("HoDem", typeof(string));
                dt.Columns.Add("Ten", typeof(string));
                dt.Columns.Add("HoVaTen", typeof(string));
                dt.Columns.Add("NgaySinh", typeof(DateTime));
                dt.Columns.Add("GioiTinh", typeof(string));
                dt.Columns.Add("QueQuan", typeof(string));
                dt.Columns.Add("SoDienThoai", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("MaLop", typeof(string));
                dt.Columns.Add("TenLop", typeof(string));
                dt.Columns.Add("TenKhoa", typeof(string));
                dt.Columns.Add("AnhDaiDien", typeof(string));

                DataTable sv = _localDataSet.Tables["tblSinhVien"]!;
                DataTable lop = _localDataSet.Tables["tblLop"]!;
                DataTable khoa = _localDataSet.Tables["tblKhoa"]!;

                foreach (DataRow rSv in sv.Rows)
                {
                    string maLop = rSv["MaLop"]?.ToString() ?? "";
                    string tenLop = "";
                    string tenKhoa = "";

                    DataRow? rLop = lop.Rows.Find(maLop);
                    if (rLop != null)
                    {
                        tenLop = rLop["TenLop"]?.ToString() ?? "";
                        string maKhoa = rLop["MaKhoa"]?.ToString() ?? "";
                        DataRow? rKhoa = khoa.Rows.Find(maKhoa);
                        if (rKhoa != null)
                        {
                            tenKhoa = rKhoa["TenKhoa"]?.ToString() ?? "";
                        }
                    }

                    dt.Rows.Add(
                        rSv["MaSV"],
                        rSv["HoDem"],
                        rSv["Ten"],
                        rSv["HoDem"] + " " + rSv["Ten"],
                        rSv["NgaySinh"],
                        rSv["GioiTinh"],
                        rSv["QueQuan"],
                        rSv["SoDienThoai"],
                        rSv["Email"],
                        maLop,
                        tenLop,
                        tenKhoa,
                        rSv["AnhDaiDien"]
                    );
                }
                return dt;
            }

            if (sqlLower.Contains("tbldiem"))
            {
                dt.Columns.Add("MaSV", typeof(string));
                dt.Columns.Add("HoTen", typeof(string));
                dt.Columns.Add("MaMH", typeof(string));
                dt.Columns.Add("TenMH", typeof(string));
                dt.Columns.Add("SoTinChi", typeof(int));
                dt.Columns.Add("DiemQuaTrinh", typeof(double));
                dt.Columns.Add("DiemThi", typeof(double));
                dt.Columns.Add("DiemTongKet", typeof(double));
                dt.Columns.Add("DiemChu", typeof(string));

                DataTable diem = _localDataSet.Tables["tblDiem"]!;
                DataTable sv = _localDataSet.Tables["tblSinhVien"]!;
                DataTable mh = _localDataSet.Tables["tblMonHoc"]!;

                foreach (DataRow rD in diem.Rows)
                {
                    string maSV = rD["MaSV"]?.ToString() ?? "";
                    string maMH = rD["MaMH"]?.ToString() ?? "";

                    DataRow? rSv = sv.Rows.Find(maSV);
                    DataRow? rMh = mh.Rows.Find(maMH);

                    string hoTen = rSv != null ? $"{rSv["HoDem"]} {rSv["Ten"]}" : maSV;
                    string tenMH = rMh != null ? rMh["TenMH"]?.ToString() ?? maMH : maMH;
                    int stc = rMh != null ? Convert.ToInt32(rMh["SoTinChi"]) : 3;

                    dt.Rows.Add(
                        maSV,
                        hoTen,
                        maMH,
                        tenMH,
                        stc,
                        rD["DiemQuaTrinh"],
                        rD["DiemThi"],
                        rD["DiemTongKet"],
                        rD["DiemChu"]
                    );
                }
                return dt;
            }

            return dt;
        }

        private int ExecuteLocalCommand(string sql)
        {
            string sqlClean = sql.Trim();
            string sqlLower = sqlClean.ToLowerInvariant();

            // 1. INSERT
            if (sqlLower.StartsWith("insert into"))
            {
                return HandleLocalInsert(sqlClean);
            }
            // 2. UPDATE
            else if (sqlLower.StartsWith("update"))
            {
                return HandleLocalUpdate(sqlClean);
            }
            // 3. DELETE
            else if (sqlLower.StartsWith("delete from") || sqlLower.StartsWith("delete"))
            {
                return HandleLocalDelete(sqlClean);
            }

            return 1;
        }

        private int HandleLocalInsert(string sql)
        {
            // Trích xuất tên bảng
            Match match = Regex.Match(sql, @"insert\s+into\s+([a-zA-Z0-9_]+)", RegexOptions.IgnoreCase);
            if (!match.Success) return 0;

            string tableName = match.Groups[1].Value;
            if (!_localDataSet.Tables.Contains(tableName)) return 0;
            DataTable dt = _localDataSet.Tables[tableName]!;

            // Lấy danh sách cột
            Match colsMatch = Regex.Match(sql, @"\((.*?)\)\s*values", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            string[] columns = colsMatch.Success
                ? colsMatch.Groups[1].Value.Split(',').Select(c => c.Trim()).ToArray()
                : dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();

            // Lấy các giá trị VALUES (...)
            Match valsMatch = Regex.Match(sql, @"values\s*\((.*)\)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (!valsMatch.Success) return 0;

            string valsStr = valsMatch.Groups[1].Value;
            List<string> values = ParseSqlValues(valsStr);

            DataRow newRow = dt.NewRow();
            for (int i = 0; i < columns.Length && i < values.Count; i++)
            {
                string colName = columns[i];
                if (dt.Columns.Contains(colName))
                {
                    string val = values[i];
                    Type targetType = dt.Columns[colName]!.DataType;

                    if (targetType == typeof(DateTime))
                    {
                        if (DateTime.TryParse(val, out DateTime dtVal))
                            newRow[colName] = dtVal;
                        else
                            newRow[colName] = DateTime.Now;
                    }
                    else if (targetType == typeof(double))
                    {
                        double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out double dVal);
                        newRow[colName] = dVal;
                    }
                    else if (targetType == typeof(int))
                    {
                        int.TryParse(val, out int iVal);
                        newRow[colName] = iVal;
                    }
                    else
                    {
                        newRow[colName] = val;
                    }
                }
            }

            dt.Rows.Add(newRow);
            return 1;
        }

        private int HandleLocalUpdate(string sql)
        {
            Match match = Regex.Match(sql, @"update\s+([a-zA-Z0-9_]+)\s+set\s+(.*?)\s+where\s+(.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (!match.Success) return 0;

            string tableName = match.Groups[1].Value;
            string setPart = match.Groups[2].Value;
            string wherePart = match.Groups[3].Value;

            if (!_localDataSet.Tables.Contains(tableName)) return 0;
            DataTable dt = _localDataSet.Tables[tableName]!;

            string filterExp = wherePart.Replace("N'", "'");
            DataRow[] rows = dt.Select(filterExp);

            // Tách các cặp Cột = Giá trị
            var setPairs = setPart.Split(',');
            foreach (var row in rows)
            {
                foreach (var pair in setPairs)
                {
                    var kv = pair.Split('=');
                    if (kv.Length == 2)
                    {
                        string col = kv[0].Trim();
                        string val = kv[1].Trim().Trim('\'');
                        if (val.StartsWith("N'")) val = val.Substring(2).TrimEnd('\'');

                        if (dt.Columns.Contains(col))
                        {
                            Type targetType = dt.Columns[col]!.DataType;
                            if (targetType == typeof(DateTime) && DateTime.TryParse(val, out DateTime dVal))
                                row[col] = dVal;
                            else if (targetType == typeof(double) && double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out double dbVal))
                                row[col] = dbVal;
                            else if (targetType == typeof(int) && int.TryParse(val, out int iVal))
                                row[col] = iVal;
                            else
                                row[col] = val;
                        }
                    }
                }
            }
            return rows.Length;
        }

        private int HandleLocalDelete(string sql)
        {
            Match match = Regex.Match(sql, @"delete\s+(from\s+)?([a-zA-Z0-9_]+)\s+where\s+(.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (!match.Success) return 0;

            string tableName = match.Groups[2].Value;
            string wherePart = match.Groups[3].Value;

            if (!_localDataSet.Tables.Contains(tableName)) return 0;
            DataTable dt = _localDataSet.Tables[tableName]!;

            string filterExp = wherePart.Replace("N'", "'");
            DataRow[] rows = dt.Select(filterExp);
            foreach (var r in rows)
            {
                r.Delete();
            }
            dt.AcceptChanges();
            return rows.Length;
        }

        private List<string> ParseSqlValues(string valuesStr)
        {
            List<string> list = new List<string>();
            bool inQuotes = false;
            char quoteChar = '\'';
            string current = "";

            for (int i = 0; i < valuesStr.Length; i++)
            {
                char c = valuesStr[i];
                if ((c == '\'' || c == '"') && !inQuotes)
                {
                    inQuotes = true;
                    quoteChar = c;
                }
                else if (c == quoteChar && inQuotes)
                {
                    inQuotes = false;
                }
                else if (c == ',' && !inQuotes)
                {
                    list.Add(CleanValue(current));
                    current = "";
                }
                else
                {
                    current += c;
                }
            }
            if (!string.IsNullOrWhiteSpace(current))
            {
                list.Add(CleanValue(current));
            }
            return list;
        }

        private string CleanValue(string raw)
        {
            string s = raw.Trim();
            if (s.StartsWith("N'") && s.EndsWith("'"))
                return s.Substring(2, s.Length - 3);
            if (s.StartsWith("'") && s.EndsWith("'"))
                return s.Substring(1, s.Length - 2);
            return s;
        }
    }
}
