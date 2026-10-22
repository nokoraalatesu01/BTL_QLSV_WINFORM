namespace QLDSV_HTC.Helpers;

/// <summary>Lỗi nghiệp vụ / dữ liệu không hợp lệ - thông điệp an toàn để hiển thị cho người dùng.</summary>
public class BusinessException : Exception
{
    public BusinessException(string message) : base(message) { }

    public BusinessException(string message, Exception inner) : base(message, inner) { }
}
