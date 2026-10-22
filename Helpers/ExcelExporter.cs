using ClosedXML.Excel;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Helpers;

/// <summary>Xuất bảng điểm một lớp tín chỉ ra file Excel (.xlsx).</summary>
public static class ExcelExporter
{
    private const int SoCot = 8;

    /// <summary>Tên file gợi ý, ví dụ BangDiem_CSDL_N1_2023-2024_HK1.xlsx</summary>
    public static string TenFileGoiY(LopTinChi ltc)
    {
        var ten = $"BangDiem_{ltc.MaMH.Trim()}_N{ltc.Nhom}_{ltc.NienKhoa.Trim()}_HK{ltc.HocKy}.xlsx";
        foreach (var ch in Path.GetInvalidFileNameChars())
            ten = ten.Replace(ch, '_');
        return ten.Replace(' ', '_');
    }

    public static void XuatBangDiem(string duongDan, LopTinChi ltc, IReadOnlyList<DiemSinhVien> ds)
    {
        using var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("Bảng điểm");

        // ---- Tiêu đề ----
        var tieuDe = ws.Range(1, 1, 1, SoCot).Merge();
        tieuDe.Value = "BẢNG ĐIỂM LỚP TÍN CHỈ";
        tieuDe.Style.Font.Bold = true;
        tieuDe.Style.Font.FontSize = 16;
        tieuDe.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

        GhiDongThongTin(ws, 2, $"Môn học: {ltc.TenMH.Trim()}   |   Nhóm: {ltc.Nhom}");
        GhiDongThongTin(ws, 3, $"Giảng viên: {ltc.TenGV.Trim()}   |   Niên khóa: {ltc.NienKhoa.Trim()}   |   Học kỳ: {ltc.HocKy}");
        GhiDongThongTin(ws, 4, $"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}");

        // ---- Dòng tiêu đề cột ----
        const int hangTieuDeCot = 6;
        string[] tenCot = { "STT", "Mã SV", "Họ và tên", "Lớp", "Chuyên cần", "Giữa kỳ", "Cuối kỳ", "Tổng kết" };
        for (int i = 0; i < tenCot.Length; i++)
            ws.Cell(hangTieuDeCot, i + 1).Value = tenCot[i];

        var hang = ws.Range(hangTieuDeCot, 1, hangTieuDeCot, SoCot);
        hang.Style.Font.Bold = true;
        hang.Style.Font.FontColor = XLColor.White;
        hang.Style.Fill.BackgroundColor = XLColor.FromHtml("#1F3A6E");
        hang.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        hang.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        ws.Row(hangTieuDeCot).Height = 24;

        // ---- Dữ liệu ----
        int r = hangTieuDeCot + 1;
        int stt = 1;
        int daCoTongKet = 0;
        foreach (var d in ds)
        {
            ws.Cell(r, 1).Value = stt++;
            ws.Cell(r, 2).Value = d.MaSV.Trim();
            ws.Cell(r, 3).Value = d.HoTen.Trim();
            ws.Cell(r, 4).Value = d.MaLop.Trim();
            if (d.DiemCC.HasValue) ws.Cell(r, 5).Value = d.DiemCC.Value;
            if (d.DiemGK.HasValue) ws.Cell(r, 6).Value = d.DiemGK.Value;
            if (d.DiemCK.HasValue) ws.Cell(r, 7).Value = d.DiemCK.Value;
            if (d.DiemTK.HasValue)
            {
                ws.Cell(r, 8).Value = d.DiemTK.Value;
                daCoTongKet++;
            }
            r++;
        }

        int hangCuoi = r - 1;
        if (hangCuoi >= hangTieuDeCot + 1)
        {
            var bang = ws.Range(hangTieuDeCot + 1, 1, hangCuoi, SoCot);
            bang.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range(hangTieuDeCot + 1, 3, hangCuoi, 3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            ws.Range(hangTieuDeCot + 1, 5, hangCuoi, 7).Style.NumberFormat.Format = "0.0";
            ws.Range(hangTieuDeCot + 1, 8, hangCuoi, 8).Style.NumberFormat.Format = "0.00";
            ws.Range(hangTieuDeCot + 1, 8, hangCuoi, 8).Style.Font.Bold = true;
        }

        var toanBang = ws.Range(hangTieuDeCot, 1, Math.Max(hangCuoi, hangTieuDeCot), SoCot);
        toanBang.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        toanBang.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

        // ---- Tổng hợp ----
        GhiDongThongTin(ws, hangCuoi + 2,
            $"Tổng số sinh viên: {ds.Count}   |   Đã có điểm tổng kết: {daCoTongKet}   |   Chưa đủ điểm: {ds.Count - daCoTongKet}");
        ws.Row(hangCuoi + 2).Style.Font.Italic = true;

        // ---- Độ rộng cột ----
        double[] doRong = { 6, 14, 28, 14, 12, 10, 10, 11 };
        for (int i = 0; i < doRong.Length; i++)
            ws.Column(i + 1).Width = doRong[i];

        ws.SheetView.FreezeRows(hangTieuDeCot);
        wb.SaveAs(duongDan);
    }

    private static void GhiDongThongTin(IXLWorksheet ws, int hang, string noiDung)
    {
        var o = ws.Range(hang, 1, hang, SoCot).Merge();
        o.Value = noiDung;
        o.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
    }
}
