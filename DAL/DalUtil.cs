using Microsoft.Data.SqlClient;

namespace QLDSV_HTC.DAL;

/// <summary>Hàm dùng chung cho các lệnh chạy bên trong transaction.</summary>
public static class DalUtil
{
    public static int Exec(SqlConnection conn, SqlTransaction tx, string sql, params SqlParameter[] parameters)
    {
        using var cmd = new SqlCommand(sql, conn, tx);
        cmd.Parameters.AddRange(parameters);
        return cmd.ExecuteNonQuery();
    }

    public static object? Scalar(SqlConnection conn, SqlTransaction tx, string sql, params SqlParameter[] parameters)
    {
        using var cmd = new SqlCommand(sql, conn, tx);
        cmd.Parameters.AddRange(parameters);
        var result = cmd.ExecuteScalar();
        return result == DBNull.Value ? null : result;
    }
}
