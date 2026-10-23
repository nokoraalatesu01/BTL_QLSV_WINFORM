using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using System.Data;

namespace QLDSV_HTC.DAL;

/// <summary>
/// Truy cập hồ sơ cá nhân của sinh viên. Mọi truy vấn đều dùng tham số.
/// Cấu trúc bảng Sinhvien được đọc từ INFORMATION_SCHEMA lúc chạy: cột nào không tồn tại thì bị bỏ qua hoàn toàn,
/// tên cột đưa vào câu lệnh SQL luôn lấy từ CSDL (danh sách trắng), không bao giờ lấy từ người dùng.
/// </summary>
public static class HoSoSinhVienDAL
{
    /// <summary>Tên cột lưu ảnh đại diện (VARBINARY) – do script Database/ThemAnhDaiDien.sql tạo.</summary>
    public const string CotAnh = "ANHDAIDIEN";

    private sealed record DinhNghiaTruong(
        string Nhom, string Ten, bool CoTheSua, int DoDaiMacDinh, KieuTruong Kieu, string[] CotUngVien);

    private sealed record CotSql(string Ten, string KieuDuLieu, int DoDai);

    public const string NhomCaNhan = "Thông tin cá nhân";
    public const string NhomLienHe = "Thông tin liên hệ";
    public const string NhomNganHang = "Thông tin ngân hàng";
    public const string NhomHocTap = "Thông tin học tập";

    // Danh mục các trường CÓ THỂ hiển thị/chỉnh sửa. Trường nào không có cột trong CSDL sẽ không xuất hiện.
    private static readonly DinhNghiaTruong[] DanhMuc =
    {
        new(NhomCaNhan,   "Địa chỉ",                  true, 100, KieuTruong.VanBan,    new[] { "DIACHI" }),
        new(NhomLienHe,   "Số điện thoại cá nhân",    true, 15,  KieuTruong.DienThoai, new[] { "SODIENTHOAI", "SDT", "DIENTHOAI" }),
        new(NhomLienHe,   "Email",                    true, 100, KieuTruong.Email,     new[] { "EMAIL" }),
        new(NhomNganHang, "Số tài khoản ngân hàng",   true, 30,  KieuTruong.VanBan,    new[] { "SOTAIKHOAN", "STK", "SOTK" }),
        new(NhomNganHang, "Tên ngân hàng",            true, 100, KieuTruong.VanBan,    new[] { "TENNGANHANG", "NGANHANG" }),
    };

    private static readonly string[] CotSoGiayTo = { "CCCD", "CMND", "SOCCCD", "SOCMND" };
    private static readonly string[] KieuChuoi = { "nvarchar", "varchar", "nchar", "char" };

    private static SqlConnection MoKetNoi()
    {
        var cn = new SqlConnection(DataBaseProcess.ChuoiKetNoi);
        cn.Open();
        return cn;
    }

    private static string Cot(string ten) => "s.[" + ten.Replace("]", "]]") + "]";

    private static string Chuoi(object v) => v == DBNull.Value ? "" : (Convert.ToString(v) ?? "").Trim();

    private static Dictionary<string, CotSql> LayCacCot(SqlConnection cn)
    {
        var kq = new Dictionary<string, CotSql>(StringComparer.OrdinalIgnoreCase);
        using var cmd = new SqlCommand(
            @"SELECT COLUMN_NAME, DATA_TYPE, ISNULL(CHARACTER_MAXIMUM_LENGTH, 0)
              FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Sinhvien'", cn);
        using var rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            var ten = rd.GetString(0);
            kq[ten] = new CotSql(ten, rd.GetString(1).ToLowerInvariant(), rd.GetInt32(2));
        }
        return kq;
    }

    private static CotSql? TimCotChuoi(Dictionary<string, CotSql> cacCot, string[] ungVien)
    {
        foreach (var ten in ungVien)
            if (cacCot.TryGetValue(ten, out var c) && KieuChuoi.Contains(c.KieuDuLieu))
                return c;
        return null;
    }

    private static CotSql? TimCotAnh(Dictionary<string, CotSql> cacCot) =>
        cacCot.TryGetValue(CotAnh, out var c) && c.KieuDuLieu == "varbinary" ? c : null;

    /// <summary>Các trường có cột thật trong CSDL, theo danh mục.</summary>
    private static List<(DinhNghiaTruong Dn, CotSql Cot)> TruongTonTai(Dictionary<string, CotSql> cacCot)
    {
        var ds = new List<(DinhNghiaTruong, CotSql)>();
        foreach (var dn in DanhMuc)
        {
            var c = TimCotChuoi(cacCot, dn.CotUngVien);
            if (c != null) ds.Add((dn, c));
        }
        return ds;
    }

    public static HoSoSinhVien? LayHoSo(string maSV)
    {
        using var cn = MoKetNoi();
        var cacCot = LayCacCot(cn);
        var truongCoSan = TruongTonTai(cacCot);
        var cotGiayTo = TimCotChuoi(cacCot, CotSoGiayTo);
        var cotAnh = TimCotAnh(cacCot);

        var extra = new List<string>();
        foreach (var (_, c) in truongCoSan) extra.Add(Cot(c.Ten));
        if (cotGiayTo != null) extra.Add(Cot(cotGiayTo.Ten));
        if (cotAnh != null) extra.Add(Cot(cotAnh.Ten));

        var sql = @"SELECT s.MASV, s.HO, s.TEN, s.MALOP, l.TENLOP, l.KHOAHOC, k.TENKHOA,
                           s.GIOITINH, s.NGAYSINH, s.DANGHIHOC"
                  + (extra.Count > 0 ? ", " + string.Join(", ", extra) : "") + @"
                    FROM Sinhvien s
                    JOIN Lop l ON l.MALOP = s.MALOP
                    JOIN Khoa k ON k.MAKHOA = l.MAKHOA
                    WHERE s.MASV = @maSV";

        using var cmd = new SqlCommand(sql, cn);
        cmd.Parameters.Add("@maSV", SqlDbType.NChar, 10).Value = maSV.Trim();
        using var rd = cmd.ExecuteReader();
        if (!rd.Read()) return null;

        var hs = new HoSoSinhVien
        {
            MaSV = Chuoi(rd["MASV"]),
            Ho = Chuoi(rd["HO"]),
            Ten = Chuoi(rd["TEN"]),
            MaLop = Chuoi(rd["MALOP"]),
            TenLop = Chuoi(rd["TENLOP"]),
            TenKhoa = Chuoi(rd["TENKHOA"]),
            NgaySinh = rd["NGAYSINH"] == DBNull.Value ? null : Convert.ToDateTime(rd["NGAYSINH"]),
            CoCotAnh = cotAnh != null,
        };

        if (cotGiayTo != null)
        {
            var so = Chuoi(rd[cotGiayTo.Ten]);
            if (so.Length > 0)
            {
                hs.SoGiayTo = so;
                hs.NhanSoGiayTo = cotGiayTo.Ten.Contains("CMND", StringComparison.OrdinalIgnoreCase) ? "CMND" : "CCCD";
            }
        }

        if (cotAnh != null && rd[cotAnh.Ten] is byte[] anh && anh.Length > 0)
            hs.Anh = anh;

        // Dữ liệu chỉ-xem suy ra từ các bảng/cột luôn có.
        hs.Truong.Add(new TruongHoSo { Nhom = NhomCaNhan, Ten = "Giới tính", GiaTri = Chuoi(rd["GIOITINH"]) });
        hs.Truong.Add(new TruongHoSo { Nhom = NhomHocTap, Ten = "Khóa học", GiaTri = Chuoi(rd["KHOAHOC"]) });
        hs.Truong.Add(new TruongHoSo
        {
            Nhom = NhomHocTap,
            Ten = "Trạng thái",
            GiaTri = Convert.ToBoolean(rd["DANGHIHOC"]) ? "Đã nghỉ học" : "Đang học"
        });

        // Trường có cột thật trong CSDL (chỉnh sửa được).
        foreach (var (dn, c) in truongCoSan)
        {
            hs.Truong.Add(new TruongHoSo
            {
                Nhom = dn.Nhom,
                Ten = dn.Ten,
                TenCot = c.Ten,
                CoTheSua = dn.CoTheSua,
                Kieu = dn.Kieu,
                DoDaiToiDa = c.DoDai > 0 ? Math.Min(c.DoDai, dn.DoDaiMacDinh) : dn.DoDaiMacDinh,
                GiaTri = Chuoi(rd[c.Ten]),
            });
        }
        return hs;
    }

    /// <summary>Chỉ đọc ảnh đại diện; trả về null nếu CSDL chưa có cột ảnh hoặc chưa có ảnh.</summary>
    public static byte[]? LayAnh(string maSV)
    {
        using var cn = MoKetNoi();
        var cotAnh = TimCotAnh(LayCacCot(cn));
        if (cotAnh == null) return null;

        using var cmd = new SqlCommand("SELECT " + Cot(cotAnh.Ten) + " FROM Sinhvien s WHERE s.MASV = @maSV", cn);
        cmd.Parameters.Add("@maSV", SqlDbType.NChar, 10).Value = maSV.Trim();
        var v = cmd.ExecuteScalar();
        return v is byte[] b && b.Length > 0 ? b : null;
    }

    /// <summary>
    /// Cập nhật hồ sơ của đúng sinh viên <paramref name="maSV"/>. Chỉ các cột nằm trong danh mục cho phép sửa
    /// (và thực sự tồn tại) mới được ghi. Ném BusinessException nếu không có nơi lưu hoặc không có dòng nào được cập nhật.
    /// </summary>
    public static void Luu(string maSV, IReadOnlyDictionary<string, string?> giaTri, byte[]? anhMoi)
    {
        using var cn = MoKetNoi();
        var cacCot = LayCacCot(cn);
        var choPhep = TruongTonTai(cacCot)
            .Where(x => x.Dn.CoTheSua)
            .ToDictionary(x => x.Cot.Ten, x => x.Cot, StringComparer.OrdinalIgnoreCase);

        using var cmd = new SqlCommand { Connection = cn };
        var gan = new List<string>();
        int i = 0;

        foreach (var (tenCot, v) in giaTri)
        {
            if (!choPhep.TryGetValue(tenCot, out var c))
                throw new BusinessException("Có trường thông tin không tồn tại trong CSDL hoặc không được phép chỉnh sửa.");

            var p = cmd.Parameters.Add("@p" + i, SqlDbType.NVarChar, c.DoDai > 0 ? c.DoDai : -1);
            p.Value = (object?)v ?? DBNull.Value;
            gan.Add("[" + c.Ten.Replace("]", "]]") + "] = @p" + i);
            i++;
        }

        if (anhMoi != null)
        {
            var cotAnh = TimCotAnh(cacCot)
                ?? throw new BusinessException(
                    "CSDL chưa có cột lưu ảnh đại diện (Sinhvien.ANHDAIDIEN). Hãy chạy script Database/ThemAnhDaiDien.sql trước.");
            cmd.Parameters.Add("@anh", SqlDbType.VarBinary, -1).Value = anhMoi;
            gan.Add("[" + cotAnh.Ten.Replace("]", "]]") + "] = @anh");
        }

        if (gan.Count == 0)
            throw new BusinessException("Không có dữ liệu nào có nơi lưu trong cơ sở dữ liệu để cập nhật.");

        cmd.CommandText = "UPDATE Sinhvien SET " + string.Join(", ", gan) + " WHERE MASV = @maSV";
        cmd.Parameters.Add("@maSV", SqlDbType.NChar, 10).Value = maSV.Trim();

        if (cmd.ExecuteNonQuery() != 1)
            throw new BusinessException("Không cập nhật được hồ sơ (không tìm thấy sinh viên).");
    }
}
