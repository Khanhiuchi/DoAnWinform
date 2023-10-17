using DAL.Model;
using DLL;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLPhongKhamNhaKhoa
{
    public partial class FrmLichSuNhapLieuThuoc : Form
    {
        private LichSuThuocDAO lsThuocBLL;
        public FrmLichSuNhapLieuThuoc()
        {
            InitializeComponent();
            lsThuocBLL = new LichSuThuocDAO();
        }

        private void FrmLichSuNhapLieuThuoc_Load(object sender, EventArgs e)
        {
            dgvLichSuThuoc.DataSource = lsThuocBLL.GetLichSuNhapLieuthuoc();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;

            List<LICHSUNHAPLIEUTHUOC> listLSThuoc = new List<LICHSUNHAPLIEUTHUOC>();
            LICHSUNHAPLIEUTHUOC lsthuoc = lsThuocBLL.GetLSThuocByMaThuoc(timkiem);

            if (lsthuoc != null)
            {
                listLSThuoc.Add(lsthuoc);
                dgvLichSuThuoc.DataSource = listLSThuoc;
            }
            else if (timkiem != "")
            {
                listLSThuoc = lsThuocBLL.GetLSThuocByTenThuoc(timkiem);
                dgvLichSuThuoc.DataSource = listLSThuoc;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Lịch sử nhập liệu của Thuốc với tên và mã thuốc đã nhập.");
                dgvLichSuThuoc.DataSource = lsThuocBLL.GetLichSuNhapLieuthuoc();
            }
        }

        private void toolStripButtonXuatExcel_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại SaveFileDialog để chọn vị trí và tên file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Chọn vị trí và tên file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OfficeOpenXml.LicenseContext licenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage.LicenseContext = licenseContext;
                // Tạo một package Excel mới
                ExcelPackage excelPackage = new ExcelPackage();

                // Tạo một worksheet trong Excel
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                worksheet.Cells[1, 1, 1, 8].Merge = true;
                // Thêm dòng title "DANH MỤC THUỐC"
                worksheet.Cells[1, 1].Value = "LỊCH SỬ NHẬP LIỆU THUỐC";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.Font.Size = 16;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Ghi dữ liệu từ DataGridView vào Excel worksheet
                DataTable dataTable = new DataTable();

                // Add columns to DataTable
                dataTable.Columns.Add("STT");
                dataTable.Columns.Add("Loại nhập liệu");
                dataTable.Columns.Add("Thời Gian");
                dataTable.Columns.Add("Mã Thuốc");
                dataTable.Columns.Add("Tên Thuốc");
                dataTable.Columns.Add("Số lượng");
                dataTable.Columns.Add("DVT");
                dataTable.Columns.Add("Đơn giá");

                // Add rows to DataTable
                foreach (DataGridViewRow row in dgvLichSuThuoc.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();

                    // Set values for each column
                    dataRow["STT"] = row.Cells["colSTT"].Value;
                    dataRow["Loại nhập liệu"] = row.Cells["colLOAINHAPLIEU"].Value;

                    // Chuyển đổi giá trị ngày tháng từ DataGridView sang kiểu DateTime
                    if (DateTime.TryParse(row.Cells["colTHOIGIAN"].Value.ToString(), out DateTime thoiGian))
                    {
                        dataRow["Thời Gian"] = thoiGian;
                    }

                    dataRow["Mã Thuốc"] = row.Cells["colMATHUOC"].Value;
                    dataRow["Tên Thuốc"] = row.Cells["colTENTHUOC"].Value;
                    dataRow["Số lượng"] = row.Cells["colSOLUONG"].Value;
                    dataRow["DVT"] = row.Cells["colDVT"].Value;
                    dataRow["Đơn giá"] = row.Cells["colDONGIA"].Value;

                    dataTable.Rows.Add(dataRow);
                }

                worksheet.Cells["A2"].LoadFromDataTable(dataTable, true);
                worksheet.Cells.AutoFitColumns();
                // Lưu file Excel
                FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                excelPackage.SaveAs(excelFile);

                // Đóng package Excel
                excelPackage.Dispose();

                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
