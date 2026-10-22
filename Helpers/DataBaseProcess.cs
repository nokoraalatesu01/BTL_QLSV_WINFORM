using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLDSV_HTC.Helpers
{
    public class DataBaseProcess
    {
        // Khai báo biến toàn cục, bạn phải thay đổi chuỗi kết nối phù hợp
        string strConnect = "Data Source=DESKTOP-RLGANMR;Initial Catalog=QLDSV_HTC;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Connect Timeout=10";
        SqlConnection sqlConnect = null!;

        // Phương thức mở kết nối
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        // Phương thức đóng kết nối
        void CloseConnect()
        {
            if (sqlConnect != null && sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }

        // Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable DataReader(string sqlSelect)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }

        // Phương thức thực hiện câu lệnh dạng insert, update, delete
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            CloseConnect();
        }
    }
}
