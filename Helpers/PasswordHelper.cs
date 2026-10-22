using System.Security.Cryptography;
using System.Text;

namespace QLDSV_HTC.Helpers;

/// <summary>
/// Băm mật khẩu: SHA-256(salt + mật khẩu), HEX viết hoa.
/// Khớp với cách file QLDSV_HTC.sql (phần dữ liệu mẫu) tạo hash bằng HASHBYTES('SHA2_256', CONCAT(SALT, mật khẩu)).
/// </summary>
public static class PasswordHelper
{
    public static string NewSalt() => Convert.ToHexString(RandomNumberGenerator.GetBytes(8)); // 16 ký tự HEX

    public static string Hash(string salt, string password) =>
        Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(salt + password)));

    public static bool Verify(string salt, string password, string expectedHash)
    {
        var actual = Encoding.ASCII.GetBytes(Hash(salt, password));
        var expected = Encoding.ASCII.GetBytes((expectedHash ?? "").Trim().ToUpperInvariant());
        return CryptographicOperations.FixedTimeEquals(actual, expected);
    }
}
