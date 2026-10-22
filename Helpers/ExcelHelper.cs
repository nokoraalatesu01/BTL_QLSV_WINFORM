using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Helpers;

/// <summary>Tiện ích xuất dữ liệu ra file Excel (.xls / .csv) tương thích 100% Microsoft Excel.</summary>
public static class ExcelHelper
{
    /// <summary>Xuất danh sách sinh viên ra file Excel có định dạng bảng biểu chuyên nghiệp.</summary>
    public static void XuatSinhVien(IEnumerable<SinhVien> danhSach, string tieuDe = "DANH SÁCH SINH VIÊN")
    {
        using var sfd = new SaveFileDialog
        {
            Filter = "Excel 97-2003 Workbook (*.xls)|*.xls|CSV (Phân cách dấu phẩy) (*.csv)|*.csv",
            FileName = $"DanhSachSinhVien_{DateTime.Now:yyyyMMdd_HHmmss}.xls",
            Title = "Chọn nơi lưu file Excel danh sách sinh viên"
        };

        if (sfd.ShowDialog() != DialogResult.OK) return;

        try
        {
            string ext = Path.GetExtension(sfd.FileName).ToLower();
            if (ext == ".csv")
            {
                XuatCsv(danhSach, sfd.FileName);
            }
            else
            {
                XuatHtmlXls(danhSach, tieuDe, sfd.FileName);
            }

            var traloi = MessageBox.Show(
                $"Xuất Excel thành công!\nĐường dẫn: {sfd.FileName}\n\nBạn có muốn mở file ngay không?",
                "Xuất Excel thành công",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (traloi == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static void XuatHtmlXls(IEnumerable<SinhVien> danhSach, string tieuDe, string duongDan)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<!DOCTYPE html>");
        sb.AppendLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
        sb.AppendLine("<style>");
        sb.AppendLine("body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 13px; }");
        sb.AppendLine(".title { font-size: 18px; font-weight: bold; color: #1E3A8A; text-align: center; margin-bottom: 4px; }");
        sb.AppendLine(".sub { font-size: 12px; color: #475569; text-align: center; margin-bottom: 12px; }");
        sb.AppendLine("table { border-collapse: collapse; width: 100%; }");
        sb.AppendLine("th { background-color: #1E3A8A; color: #FFFFFF; font-weight: bold; border: 1px solid #0F172A; padding: 8px; text-align: center; }");
        sb.AppendLine("td { border: 1px solid #CBD5E1; padding: 6px 8px; }");
        sb.AppendLine("tr:nth-child(even) { background-color: #F8FAFC; }");
        sb.AppendLine(".center { text-align: center; }");
        sb.AppendLine(".badge-active { color: #059669; font-weight: bold; }");
        sb.AppendLine(".badge-inactive { color: #DC2626; font-style: italic; }");
        sb.AppendLine("</style></head><body>");

        sb.AppendLine($"<div class=\"title\">{tieuDe}</div>");
        sb.AppendLine($"<div class=\"sub\">Thời gian xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | Trường Đại học Giao thông vận tải (UTC)</div>");

        sb.AppendLine("<table>");
        sb.AppendLine("<thead><tr>");
        sb.AppendLine("<th>STT</th>");
        sb.AppendLine("<th>Mã sinh viên</th>");
        sb.AppendLine("<th>Họ đệm</th>");
        sb.AppendLine("<th>Tên</th>");
        sb.AppendLine("<th>Họ và tên</th>");
        sb.AppendLine("<th>Lớp</th>");
        sb.AppendLine("<th>Giới tính</th>");
        sb.AppendLine("<th>Ngày sinh</th>");
        sb.AppendLine("<th>Địa chỉ</th>");
        sb.AppendLine("<th>Trạng thái</th>");
        sb.AppendLine("</tr></thead><tbody>");

        int stt = 1;
        foreach (var sv in danhSach)
        {
            string ngaySinhStr = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "";
            string classTrangThai = sv.DaNghiHoc ? "badge-inactive" : "badge-active";

            sb.AppendLine("<tr>");
            sb.AppendLine($"<td class=\"center\">{stt++}</td>");
            sb.AppendLine($"<td class=\"center\"><b>{sv.MaSV}</b></td>");
            sb.AppendLine($"<td>{sv.Ho}</td>");
            sb.AppendLine($"<td>{sv.Ten}</td>");
            sb.AppendLine($"<td><b>{sv.HoTen}</b></td>");
            sb.AppendLine($"<td class=\"center\">{sv.TenLop}</td>");
            sb.AppendLine($"<td class=\"center\">{sv.GioiTinh}</td>");
            sb.AppendLine($"<td class=\"center\">{ngaySinhStr}</td>");
            sb.AppendLine($"<td>{sv.DiaChi ?? ""}</td>");
            sb.AppendLine($"<td class=\"center {classTrangThai}\">{sv.TrangThai}</td>");
            sb.AppendLine("</tr>");
        }

        sb.AppendLine("</tbody></table>");
        sb.AppendLine("</body></html>");

        File.WriteAllText(duongDan, sb.ToString(), Encoding.UTF8);
    }

    private static void XuatCsv(IEnumerable<SinhVien> danhSach, string duongDan)
    {
        var sb = new StringBuilder();
        sb.AppendLine("STT,MaSV,Ho,Ten,HoTen,Lop,GioiTinh,NgaySinh,DiaChi,TrangThai");

        int stt = 1;
        foreach (var sv in danhSach)
        {
            string ngaySinhStr = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "";
            sb.AppendLine(string.Join(",",
                stt++,
                EscapeCsv(sv.MaSV),
                EscapeCsv(sv.Ho),
                EscapeCsv(sv.Ten),
                EscapeCsv(sv.HoTen),
                EscapeCsv(sv.TenLop),
                EscapeCsv(sv.GioiTinh),
                EscapeCsv(ngaySinhStr),
                EscapeCsv(sv.DiaChi ?? ""),
                EscapeCsv(sv.TrangThai)
            ));
        }

        File.WriteAllText(duongDan, sb.ToString(), new UTF8Encoding(true));
    }

    private static string EscapeCsv(string text)
    {
        if (text.Contains(",") || text.Contains("\"") || text.Contains("\n") || text.Contains("\r"))
        {
            return "\"" + text.Replace("\"", "\"\"") + "\"";
        }
        return text;
    }
}
