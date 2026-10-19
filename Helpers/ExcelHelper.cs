using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace BTL_QLSV_WINFORM.Helpers
{
    public static class ExcelHelper
    {
        static ExcelHelper()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        /// <summary>
        /// Xuất dữ liệu từ DataGridView ra file Excel (.xlsx) với định dạng chuẩn đẹp
        /// </summary>
        public static bool ExportDataGridViewToExcel(DataGridView dgv, string title, string defaultFileName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                sfd.FileName = defaultFileName;
                sfd.Title = "Chọn nơi lưu file Excel";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            var ws = package.Workbook.Worksheets.Add("DanhSach");

                            // 1. Tiêu đề chính
                            ws.Cells[1, 1].Value = title.ToUpper();
                            ws.Cells[1, 1].Style.Font.Size = 16;
                            ws.Cells[1, 1].Style.Font.Bold = true;
                            ws.Cells[1, 1].Style.Font.Color.SetColor(System.Drawing.Color.DarkBlue);
                            ws.Cells[1, 1, 1, Math.Max(dgv.Columns.Count, 1)].Merge = true;
                            ws.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // 2. Thời gian xuất
                            ws.Cells[2, 1].Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
                            ws.Cells[2, 1].Style.Font.Italic = true;
                            ws.Cells[2, 1, 2, Math.Max(dgv.Columns.Count, 1)].Merge = true;
                            ws.Cells[2, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // 3. Header cột
                            int colIndex = 1;
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                if (dgv.Columns[i].Visible)
                                {
                                    ws.Cells[4, colIndex].Value = dgv.Columns[i].HeaderText;
                                    ws.Cells[4, colIndex].Style.Font.Bold = true;
                                    ws.Cells[4, colIndex].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                    ws.Cells[4, colIndex].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightSteelBlue);
                                    ws.Cells[4, colIndex].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                    ws.Cells[4, colIndex].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    colIndex++;
                                }
                            }

                            // 4. Dữ liệu dòng
                            int rowIndex = 5;
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (row.IsNewRow) continue;

                                colIndex = 1;
                                for (int i = 0; i < dgv.Columns.Count; i++)
                                {
                                    if (dgv.Columns[i].Visible)
                                    {
                                        object val = row.Cells[i].Value;
                                        if (val is DateTime dt)
                                        {
                                            ws.Cells[rowIndex, colIndex].Value = dt.ToString("dd/MM/yyyy");
                                        }
                                        else
                                        {
                                            ws.Cells[rowIndex, colIndex].Value = val?.ToString() ?? "";
                                        }
                                        ws.Cells[rowIndex, colIndex].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                        colIndex++;
                                    }
                                }
                                rowIndex++;
                            }

                            // Tự động căn chỉnh độ rộng cột
                            ws.Cells[4, 1, rowIndex, colIndex - 1].AutoFitColumns();

                            // Lưu file
                            FileInfo fi = new FileInfo(sfd.FileName);
                            package.SaveAs(fi);
                        }

                        MessageBox.Show("Xuất file Excel thành công!\nĐường dẫn: " + sfd.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return false;
        }
    }
}
