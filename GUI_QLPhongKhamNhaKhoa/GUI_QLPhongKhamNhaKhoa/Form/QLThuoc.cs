using DAL.Model;
using DLL;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPhongKhamNhaKhoa
{
    public partial class frmQLThuoc : Form
    {
        private ThuocDAO thuocBLL;
        private LichSuThuocDAO lsThuocBLL;
        public frmQLThuoc()
        {
            InitializeComponent();
            thuocBLL = new ThuocDAO();
            lsThuocBLL = new LichSuThuocDAO();
        }

        private void frmQLThuoc_Load(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = thuocBLL.GetAllThuoc();
        }

        private void btnThem_CapNhat_Click(object sender, EventArgs e)
        {
            string maThuoc = txtMaThuoc.Text;
            string tenThuoc = txtTenThuoc.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            string donViTinh = txtDVT.Text;
            double donGia = double.Parse(txtDonGia.Text);

            THUOC thuoc = thuocBLL.GetThuocByMaThuoc(maThuoc);
            if (thuoc != null)
            {
                string loaiNhapLieuthuoc = "Cập nhật thông tin thuốc";
                // Cập nhật thông tin thuốc
                thuoc.TENTHUOC = tenThuoc;
                thuoc.SOLUONG = soLuong;
                thuoc.DVT = donViTinh;
                thuoc.DONGIA = donGia;

                // Lưu thông tin vừa cập nhật 
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin thuốc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    thuocBLL.Them_UpDate(thuoc);
                    lsThuocBLL.ThemLichSuNhapLieuthuoc(loaiNhapLieuthuoc, maThuoc, tenThuoc, soLuong, donViTinh, donGia);
                    MessageBox.Show("Cập nhật thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string loaiNhapLieuthuoc = "Thêm thuốc mới";
                // Thêm thuốc mới
                thuoc = new THUOC
                {
                    MATHUOC = maThuoc,
                    TENTHUOC = tenThuoc,
                    SOLUONG = soLuong,
                    DVT = donViTinh,
                    DONGIA = donGia

                };

                // Lưu thông tin thuốc mới vào
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm thuốc mới vào kho ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    thuocBLL.Them_UpDate(thuoc);
                    lsThuocBLL.ThemLichSuNhapLieuthuoc(loaiNhapLieuthuoc, maThuoc, tenThuoc, soLuong, donViTinh, donGia);
                    MessageBox.Show("Thêm thuốc mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            dgvThuoc.DataSource = thuocBLL.GetAllThuoc();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtDVT.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string loaiNhapLieuthuoc = "Xóa thuốc";

            string maThuoc = txtMaThuoc.Text;
            THUOC thuoc = thuocBLL.GetThuocByMaThuoc(maThuoc);
            if (thuoc != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    thuocBLL.XoaThuoc(thuoc);
                    //// Lưu thông tin thuốc đã xóa vào table LICHSUNHAPLIEUTHUOC
                    lsThuocBLL.ThemLichSuNhapLieuthuoc(loaiNhapLieuthuoc, maThuoc, thuoc.TENTHUOC, thuoc.SOLUONG, thuoc.DVT, thuoc.DONGIA);
                    MessageBox.Show("Xóa thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvThuoc.DataSource = thuocBLL.GetAllThuoc();
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thuốc có mã " + maThuoc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string loaiNhapLieuthuoc = "Nhập thuốc";

            string maThuoc = txtMaThuoc.Text;
            int soLuongNhap = int.Parse(txtSoLuong.Text);

            THUOC thuoc = thuocBLL.GetThuocByMaThuoc(maThuoc);
            if (thuoc != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Nhập số lượng thuốc này vào kho?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Cập nhật số lượng thuốc
                    thuoc.SOLUONG += soLuongNhap;
                    thuocBLL.Them_UpDate(thuoc);

                    // Lưu thông tin số lượng thuốc đã nhập vào table LICHSUNHAPLIEUTHUOC
                    lsThuocBLL.ThemLichSuNhapLieuthuoc(loaiNhapLieuthuoc, maThuoc, thuoc.TENTHUOC, soLuongNhap, thuoc.DVT, thuoc.DONGIA);
                    MessageBox.Show("Cập nhật số lượng thuốc nhập vào kho thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvThuoc.DataSource = thuocBLL.GetAllThuoc();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Không tìm thấy Mã thuốc " + maThuoc + ". Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string loaiNhapLieuthuoc = "Xuất thuốc";
            string maThuoc = txtMaThuoc.Text;
            int soLuongXuat = int.Parse(txtSoLuong.Text);

            THUOC thuoc = thuocBLL.GetThuocByMaThuoc(maThuoc);
            if (thuoc != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xuất số lượng thuốc này ra khỏi kho?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Cập nhật số lượng thuốc
                    thuoc.SOLUONG -= soLuongXuat;
                    thuocBLL.Them_UpDate(thuoc);

                    // Lưu thông tin số lượng thuốc đã xuất ra vào table LICHSUNHAPLIEUTHUOC
                    lsThuocBLL.ThemLichSuNhapLieuthuoc(loaiNhapLieuthuoc, maThuoc, thuoc.TENTHUOC, soLuongXuat, thuoc.DVT, thuoc.DONGIA);

                    MessageBox.Show("Cập nhật số lượng thuốc xuất ra khỏi kho thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvThuoc.DataSource = thuocBLL.GetAllThuoc();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Không tìm thấy Mã thuốc " + maThuoc + ". Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];
                txtMaThuoc.Text = row.Cells["colMATHUOC"].Value.ToString();
                txtTenThuoc.Text = row.Cells["colTENTHUOC"].Value.ToString();
                txtSoLuong.Text = row.Cells["colSOLUONG"].Value.ToString();
                txtDVT.Text = row.Cells["colDVT"].Value.ToString();
                txtDonGia.Text = row.Cells["colDONGIA"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mathuoc = txtMaThuoc.Text;
            string tenthuoc = txtTenThuoc.Text;
            List<THUOC> listThuoc = new List<THUOC>();
            THUOC thuoc = thuocBLL.GetThuocByMaThuoc(mathuoc);

            if (thuoc != null)
            {
                listThuoc.Add(thuoc);
                dgvThuoc.DataSource = listThuoc;
            }
            else if (tenthuoc != "")
            {
                listThuoc = thuocBLL.GetThuocByTenThuoc(tenthuoc);
                dgvThuoc.DataSource = listThuoc;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Thuốc với tên và mã thuốc đã nhập.");
                dgvThuoc.DataSource = thuocBLL.GetAllThuoc();
            }
        }

        private void toolStripBtnXemLSThuoc_Click(object sender, EventArgs e)
        {
            FrmLichSuNhapLieuThuoc f = new FrmLichSuNhapLieuThuoc();
            f.ShowDialog();
        }

        private void toolStripBtnXuatExcel_Click(object sender, EventArgs e)
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
                worksheet.Cells[1, 1, 1, 5].Merge = true;
                // Thêm dòng title "DANH MỤC THUỐC"
                worksheet.Cells[1, 1].Value = "DANH MỤC THUỐC";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.Font.Size = 16;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Ghi dữ liệu từ DataGridView vào Excel worksheet
                DataTable dataTable = new DataTable();

                // Add cột vào DataTable
                dataTable.Columns.Add("Mã Thuốc");
                dataTable.Columns.Add("Tên Thuốc");
                dataTable.Columns.Add("Số lượng");
                dataTable.Columns.Add("DVT");
                dataTable.Columns.Add("Đơn giá");

                // Add các hàng vào DataTable
                foreach (DataGridViewRow row in dgvThuoc.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();

                    // Set dữ liệu cho từng cột

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
