using DAL.Model;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPhongKhamNhaKhoa
{
    public partial class frmQLBenhNhan : Form
    {
        private readonly BenhNhanDAO benhNhanService = new BenhNhanDAO();
        public frmQLBenhNhan()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtMaSo.Text = txtHoTen.Text = txtDienThoai.Text = richTextDiaChi.Text = richTextLiDo.Text = "";
            dateNamSinh.Text = dateNgayKham.Text = DateTime.Now.ToString();
            rdbNam.Checked = true;
        }
        private void BindGrid(List<BENHNHAN> lstBenhNhan)
        {
            dgvBenhNhan.Columns["NamSinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBenhNhan.Columns["NgayDauDenKham"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBenhNhan.Rows.Clear();
            foreach (var item in lstBenhNhan)
            {
                int index = dgvBenhNhan.Rows.Add();
                dgvBenhNhan.Rows[index].Cells[0].Value = item.MABENHNHAN;
                dgvBenhNhan.Rows[index].Cells[1].Value = item.HOTEN;
                dgvBenhNhan.Rows[index].Cells[2].Value = item.GIOITINH;
                dgvBenhNhan.Rows[index].Cells[3].Value = item.NAMSINH;
                dgvBenhNhan.Rows[index].Cells[4].Value = item.SDT;
                dgvBenhNhan.Rows[index].Cells[5].Value = item.DIACHI;
                dgvBenhNhan.Rows[index].Cells[6].Value = item.LYDOKHAM;
                dgvBenhNhan.Rows[index].Cells[7].Value = item.NGAYDAUTIENDENKHAM;
            }
        }

        private void frmQLBenhNhan_Load(object sender, EventArgs e)
        {
            try
            {
                var lstBenhNhan = benhNhanService.GetAll();
                BindGrid(lstBenhNhan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool chk = int.TryParse(txtMaSo.Text, out int MS);
            BENHNHAN benhNhan = new BENHNHAN
            {
                MABENHNHAN = MS,
                HOTEN = txtHoTen.Text,
                GIOITINH = rdbNam.Checked ? "Nam" : "Nữ",
                NAMSINH = dateNamSinh.Value,
                SDT = txtDienThoai.Text,
                DIACHI = richTextDiaChi.Text,
                LYDOKHAM = richTextLiDo.Text,
                NGAYDAUTIENDENKHAM = dateNgayKham.Value
            };
            benhNhanService.Add_Update(benhNhan);
            frmQLBenhNhan_Load(sender, e);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xóa Bệnh nhân này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int maBN = int.Parse(txtMaSo.Text);
                    benhNhanService.Delete(maBN);
                    frmQLBenhNhan_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBenhNhan.Rows.Count - 1)
            {
                DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];

                // Lấy dữ liệu từ DataGridViewRow và hiển thị lên các TextBox
                txtMaSo.Text = row.Cells["MaBenhNhan"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();

                // Đặt giá trị của DateTimePicker
                dateNamSinh.Value = Convert.ToDateTime(row.Cells["NamSinh"].Value);
                dateNgayKham.Value = Convert.ToDateTime(row.Cells["NgayDauDenKham"].Value);

                // Đặt giá trị cho RadioButton
                if (row.Cells["GioiTinh"].Value.ToString().Contains("Nam"))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;

                // Đặt giá trị của các RichTextBox
                richTextDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                richTextLiDo.Text = row.Cells["LyDoKham"].Value.ToString();
                txtDienThoai.Text = row.Cells["SDT"].Value.ToString();
            }
            else
                Reset();
        }

        private void txtTimKiemMa_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtTimKiemTen_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtTimKiemSDT_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            string Ma = txtTimKiemMa.Text;
            string Ten = RemoveDiacritics(txtTimKiemTen.Text.ToLower());
            string Sdt = txtTimKiemSDT.Text;
            foreach (DataGridViewRow row in dgvBenhNhan.Rows)
            {
                DataGridViewCell cellMa = row.Cells["MaBenhNhan"];
                DataGridViewCell cellTen = row.Cells["HoTen"];
                DataGridViewCell cellSDT = row.Cells["SDT"];
                if (cellMa.Value != null && cellTen.Value != null && cellSDT.Value != null)
                {
                    string maRow = cellMa.Value.ToString();
                    string tenRow = RemoveDiacritics(cellTen.Value.ToString().ToLower());
                    string SDTRow = cellSDT.Value.ToString();

                    row.Visible = maRow.Contains(Ma) && tenRow.Contains(Ten) && SDTRow.Contains(Sdt);
                }
            }
        }

        //Hàm chuyển chuỗi tiếng Việt CÓ dấu thành KHÔNG dấu
        private string RemoveDiacritics(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLamSan_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text != "")
            {
                int maBenhNhan = Convert.ToInt32(txtMaSo.Text);
                BENHNHAN bn = benhNhanService.FindByID(maBenhNhan);
               // frmLamSan fLamSan = new frmLamSan();
               // fLamSan.ShowForm(bn);
               // fLamSan.ShowDialog();
            }
        }
    }
}
