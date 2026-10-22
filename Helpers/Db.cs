using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace QLDSV_HTC.Helpers;

/// <summary>
/// Kết nối và thực thi SQL bằng ADO.NET. Mọi câu lệnh đều dùng tham số (SqlParameter).
/// </summary>
public static class Db
{
    private static string? _connectionString;

    public static string ConnectionString => _connectionString ??= LoadConnectionString();

    private static string LoadConnectionString()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        if (!File.Exists(path))
            throw new BusinessException("Không tìm thấy file appsettings.json cạnh file chạy chương trình.");

        using var doc = JsonDocument.Parse(File.ReadAllText(path));
        if (doc.RootElement.TryGetProperty("ConnectionStrings", out var section)
            && section.TryGetProperty("QLDSV_HTC", out var value)
            && !string.IsNullOrWhiteSpace(value.GetString()))
        {
            return value.GetString()!;
        }

        throw new BusinessException("appsettings.json thiếu mục ConnectionStrings:QLDSV_HTC.");
    }

    public static SqlConnection Open()
    {
        var conn = new SqlConnection(ConnectionString);
        conn.Open();
        return conn;
    }

    // ------------------------------------------------------------------
    // Thực thi
    // ------------------------------------------------------------------

    public static List<T> Query<T>(string sql, Func<SqlDataReader, T> map, params SqlParameter[] parameters)
    {
        try
        {
            using var conn = Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            using var reader = cmd.ExecuteReader();
            var list = new List<T>();
            while (reader.Read())
                list.Add(map(reader));
            return list;
        }
        catch (SqlException ex) when (IsConstraintError(ex))
        {
            throw ToBusiness(ex);
        }
    }

    public static int Execute(string sql, params SqlParameter[] parameters)
    {
        try
        {
            using var conn = Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteNonQuery();
        }
        catch (SqlException ex) when (IsConstraintError(ex))
        {
            throw ToBusiness(ex);
        }
    }

    public static object? Scalar(string sql, params SqlParameter[] parameters)
    {
        try
        {
            using var conn = Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            var result = cmd.ExecuteScalar();
            return result == DBNull.Value ? null : result;
        }
        catch (SqlException ex) when (IsConstraintError(ex))
        {
            throw ToBusiness(ex);
        }
    }

    /// <summary>Chạy nhiều lệnh trong 1 transaction; lỗi bất kỳ sẽ rollback toàn bộ.</summary>
    public static void InTransaction(Action<SqlConnection, SqlTransaction> work)
    {
        try
        {
            using var conn = Open();
            using var tx = conn.BeginTransaction();
            try
            {
                work(conn, tx);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }
        catch (SqlException ex) when (IsConstraintError(ex))
        {
            throw ToBusiness(ex);
        }
    }

    // ------------------------------------------------------------------
    // Tham số
    // ------------------------------------------------------------------

    public static SqlParameter P(string name, object? value) => new(name, value ?? DBNull.Value);

    /// <summary>Tạo mẫu LIKE an toàn (escape % _ [ ]); trả về null nếu từ khóa rỗng.</summary>
    public static string? Like(string? keyword)
    {
        var s = (keyword ?? "").Trim();
        if (s.Length == 0) return null;
        s = s.Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]");
        return "%" + s + "%";
    }

    // ------------------------------------------------------------------
    // Đọc dữ liệu (NCHAR có khoảng trắng đệm nên luôn Trim)
    // ------------------------------------------------------------------

    public static string Str(SqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? "" : r.GetString(i).Trim();
    }

    public static string? StrN(SqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : r.GetString(i).Trim();
    }

    public static int Int(SqlDataReader r, string col) => Convert.ToInt32(r.GetValue(r.GetOrdinal(col)));

    public static int? IntN(SqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : Convert.ToInt32(r.GetValue(i));
    }

    public static decimal? DecN(SqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : r.GetDecimal(i);
    }

    public static bool Bool(SqlDataReader r, string col) => r.GetBoolean(r.GetOrdinal(col));

    public static DateTime? DateN(SqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : r.GetDateTime(i);
    }

    // ------------------------------------------------------------------
    // Chuyển lỗi ràng buộc SQL thành thông báo dễ hiểu
    // ------------------------------------------------------------------

    private static bool IsConstraintError(SqlException ex) => ex.Number is 2627 or 2601 or 547;

    private static BusinessException ToBusiness(SqlException ex) => ex.Number switch
    {
        2627 or 2601 => new BusinessException(
            "Dữ liệu bị trùng: mã hoặc giá trị duy nhất đã tồn tại.", ex),
        _ => new BusinessException(
            "Thao tác vi phạm ràng buộc dữ liệu: bản ghi đang được sử dụng ở nơi khác hoặc có giá trị không hợp lệ.", ex),
    };
}
