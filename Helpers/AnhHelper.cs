using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Helpers;

/// <summary>Xử lý ảnh đại diện: kiểm tra tệp, thu nhỏ, chuyển từ/ra mảng byte, ảnh mặc định chung.</summary>
public static class AnhHelper
{
    public const long DungLuongToiDaTep = 5L * 1024 * 1024;   // tệp người dùng chọn
    public const int DungLuongToiDaLuu = 2 * 1024 * 1024;     // sau khi thu nhỏ, trước khi ghi CSDL
    public const int CanhToiDa = 512;                         // px, cạnh dài nhất sau khi thu nhỏ

    /// <summary>Đọc tệp JPG/JPEG/PNG, kiểm tra hợp lệ, thu nhỏ (nếu lớn) và trả về mảng byte để lưu.</summary>
    public static byte[] ChuanHoaTuTep(string duongDan)
    {
        var duoi = Path.GetExtension(duongDan).ToLowerInvariant();
        if (duoi is not (".jpg" or ".jpeg" or ".png"))
            throw new BusinessException("Chỉ hỗ trợ ảnh định dạng JPG, JPEG hoặc PNG.");

        var fi = new FileInfo(duongDan);
        if (!fi.Exists)
            throw new BusinessException("Không tìm thấy tệp ảnh đã chọn.");
        if (fi.Length > DungLuongToiDaTep)
            throw new BusinessException("Dung lượng ảnh tối đa là 5 MB. Hãy chọn ảnh nhỏ hơn.");

        try
        {
            using var fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var goc = Image.FromStream(fs, false, true);

            bool laPng = goc.RawFormat.Equals(ImageFormat.Png);
            if (!laPng && !goc.RawFormat.Equals(ImageFormat.Jpeg))
                throw new BusinessException("Tệp được chọn không phải ảnh JPG hoặc PNG hợp lệ.");

            double tyLe = Math.Min(1.0, (double)CanhToiDa / Math.Max(goc.Width, goc.Height));
            int rong = Math.Max(1, (int)Math.Round(goc.Width * tyLe));
            int cao = Math.Max(1, (int)Math.Round(goc.Height * tyLe));

            using var bmp = new Bitmap(rong, cao);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(laPng ? Color.Transparent : Color.White);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(goc, 0, 0, rong, cao);
            }

            using var ms = new MemoryStream();
            bmp.Save(ms, laPng ? ImageFormat.Png : ImageFormat.Jpeg);
            var data = ms.ToArray();
            KiemTraDuLieuAnh(data);
            return data;
        }
        catch (BusinessException)
        {
            throw;
        }
        catch (Exception)
        {
            throw new BusinessException("Không đọc được tệp ảnh. Tệp có thể bị hỏng hoặc không đúng định dạng.");
        }
    }

    /// <summary>Kiểm tra mảng byte thật sự là ảnh JPEG/PNG và không vượt dung lượng cho phép.</summary>
    public static void KiemTraDuLieuAnh(byte[] data)
    {
        if (data.Length == 0)
            throw new BusinessException("Dữ liệu ảnh rỗng.");
        if (data.Length > DungLuongToiDaLuu)
            throw new BusinessException("Ảnh sau khi xử lý vẫn vượt quá 2 MB. Hãy chọn ảnh khác.");

        bool jpeg = data.Length > 3 && data[0] == 0xFF && data[1] == 0xD8 && data[2] == 0xFF;
        bool png = data.Length > 8 && data[0] == 0x89 && data[1] == 0x50 && data[2] == 0x4E && data[3] == 0x47;
        if (!jpeg && !png)
            throw new BusinessException("Dữ liệu ảnh không phải JPG hoặc PNG hợp lệ.");
    }

    /// <summary>Tạo Image từ mảng byte (bản sao độc lập, không giữ khóa luồng).</summary>
    public static Image TuBytes(byte[] data)
    {
        using var ms = new MemoryStream(data);
        using var tam = Image.FromStream(ms);
        return new Bitmap(tam);
    }

    /// <summary>Ảnh đại diện mặc định CHUNG (hình người cách điệu), không phải ảnh cá nhân.</summary>
    public static Bitmap TaoAnhMacDinh(int canh)
    {
        var bmp = new Bitmap(canh, canh);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Palette.PrimarySoft);
        using var co = new SolidBrush(Palette.PrimaryMid);
        g.FillEllipse(co, canh * 0.31f, canh * 0.18f, canh * 0.38f, canh * 0.38f);   // đầu
        g.FillEllipse(co, canh * 0.14f, canh * 0.62f, canh * 0.72f, canh * 0.80f);   // vai
        return bmp;
    }

    /// <summary>Cắt control thành hình tròn (dùng cho ảnh nhỏ trên header và nút camera).</summary>
    public static void CatTron(Control control)
    {
        using var path = new GraphicsPath();
        path.AddEllipse(0, 0, control.Width, control.Height);
        control.Region = new Region(path);
    }
}
