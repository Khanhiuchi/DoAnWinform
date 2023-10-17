using DAL.Model;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPhongKhamNhaKhoa
{

    public partial class frmLeTan : Form
    {
        private readonly PhieuKhamBenhDAO phieuKhamBenhService = new PhieuKhamBenhDAO();
        private readonly HoaDonDAO hoaDonService = new HoaDonDAO();
        private NhaKhoaModel model = new NhaKhoaModel();
        private frmThemMoiHoaDon frmThemMoiHoaDon;
        private frmThemMoiCTHD frmThemMoiCTHD;
        public frmLeTan()
        {
            InitializeComponent();
        }

        private void frmLeTan_Load(object sender, EventArgs e)
        {
            try
            {
                var listPKB = phieuKhamBenhService.GetAll();
                BindGirdPKB(listPKB);
                var listHD = hoaDonService.GetAll();
                BindGirdHOADON(listHD);
                int maxSTT = model.PHIEUKHAMBENHs.Max(p => p.STT);
                int newSTT = maxSTT + 1;

                // Gán số thứ tự mới cho textbox
                txtSTT.Text = newSTT.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<PHIEUKHAMBENH> listPhieuKhamBenh()
        {
            return model.PHIEUKHAMBENHs.ToList();
        }
        private void BindGirdPKB(List<PHIEUKHAMBENH> listPKB)
        {
            dgvPKB.Rows.Clear();
            foreach (var item in listPKB)
            {
                int index = dgvPKB.Rows.Add();
                dgvPKB.Rows[index].Cells[0].Value = item.STT;
                dgvPKB.Rows[index].Cells[1].Value = item.HOTEN;
                dgvPKB.Rows[index].Cells[2].Value = item.GIOITINH;
                dgvPKB.Rows[index].Cells[3].Value = item.NAMSINH;
                dgvPKB.Rows[index].Cells[4].Value = item.SDT;
                dgvPKB.Rows[index].Cells[5].Value = item.DIACHI;
                dgvPKB.Rows[index].Cells[6].Value = item.LYDOKHAM;
            }
        }
        public void BindGirdHOADON(List<HOADON> listHD)
        {
            dgvHoaDon.Rows.Clear();
            foreach (var hoadon in listHD)
            {
                int selected = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[selected].Cells[0].Value = hoadon.THOIGIA;
                dgvHoaDon.Rows[selected].Cells[1].Value = hoadon.MAHOADON;
                dgvHoaDon.Rows[selected].Cells[2].Value = hoadon.NHANVIEN.HOTEN;
                dgvHoaDon.Rows[selected].Cells[3].Value = hoadon.BENHNHAN.HOTEN;
                dgvHoaDon.Rows[selected].Cells[4].Value = hoadon.TONGTIEN;
                dgvHoaDon.Rows[selected].Cells[5].Value = hoadon.TRANGTHAI;
            }
        }



        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtHOTEN.Text == "" || txtDC.Text == "" || txtSDT.Text == "" || rtbLYDO.Text == "" || cmbGIOITINH == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu!", "Thông báo");
            }
            var newPKB = new PHIEUKHAMBENH()
            {
                HOTEN = txtHOTEN.Text,
                GIOITINH = cmbGIOITINH.Text,
                NAMSINH = dateTimePickerNS.Value,
                SDT = txtSDT.Text,
                DIACHI = txtDC.Text,
                LYDOKHAM = rtbLYDO.Text,
            };

            model.PHIEUKHAMBENHs.Add(newPKB);
            model.SaveChanges();
            BindGirdPKB(listPhieuKhamBenh());
            txtHOTEN.Text = txtDC.Text = txtSDT.Text = rtbLYDO.Text = "";
            cmbGIOITINH.SelectedIndex = -1;
            dateTimePickerNS.Text = DateTime.Now.ToString();
            int maxSTT = model.PHIEUKHAMBENHs.Max(p => p.STT);
            int newSTT = maxSTT + 1;

            // Gán số thứ tự mới cho textbox
            txtSTT.Text = newSTT.ToString();
        }


        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtHOTEN.Text = txtDC.Text = txtSDT.Text = rtbLYDO.Text = "";
            cmbGIOITINH.SelectedIndex = -1;
            dateTimePickerNS.Text = DateTime.Now.ToString();
            int maxSTT = model.PHIEUKHAMBENHs.Max(p => p.STT);
            int newSTT = maxSTT + 1;

            // Gán số thứ tự mới cho textbox
            txtSTT.Text = newSTT.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaTimKiem.Text != "")
            {
                string id = txtMaTimKiem.Text;
                var listTimKiem = hoaDonService.FindID(id);
                BindGirdHOADON(listTimKiem);
                txtMaTimKiem.Text = "";
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoaDon.Rows[e.RowIndex];
            txtMaHienThi.Text = (row.Cells[1].Value).ToString();
            if (row.Cells[5].Value.ToString().ToLower() == "Đã thanh toán")
            {
                rtbDaThanhToan.Checked = true;
            }
            else
            {
                rtbChuaThanhToan.Checked = true;
            }
        }

        private void chkChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkChuaThanhToan.Checked)
            {
                var listhd = hoaDonService.GetNoTrangThai();
                BindGirdHOADON(listhd);
            }
            else
            {
                var listhd = hoaDonService.GetAll();
                BindGirdHOADON(listhd);
            }
        }

        private List<HOADON> listHOADON()
        {
            return model.HOADONs.ToList();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MHD = txtMaHienThi.Text;
            HOADON HoaDonUpDate = model.HOADONs.FirstOrDefault(p => p.MAHOADON == MHD);
            if (HoaDonUpDate != null)
            {
                HoaDonUpDate.TRANGTHAI = rtbChuaThanhToan.Checked ? "Chưa thanh toán" : "Đã thanh toán";
                model.SaveChanges();
                BindGirdHOADON(listHOADON());
                MessageBox.Show("Sửa thông tin trạng thái hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtMaHienThi.Text = "";
            txtMaTimKiem.Text = "";
            rtbChuaThanhToan.Checked = rtbDaThanhToan.Checked = false;
            BindGirdHOADON(listHOADON());
        }

        private void dgvPKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvPKB.Rows[e.RowIndex];
            txtSTT.Text = (row.Cells[0].Value).ToString();
            txtHOTEN.Text = (row.Cells[1].Value).ToString();
            cmbGIOITINH.Text = (row.Cells[2].Value).ToString();
            dateTimePickerNS.Text = (row.Cells[3].Value).ToString();
            txtSDT.Text = (row.Cells[4].Value).ToString();
            txtDC.Text = (row.Cells[5].Value).ToString();
            rtbLYDO.Text = (row.Cells[6].Value).ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int stt = int.Parse(txtSTT.Text);
            var SuaThongTin = model.PHIEUKHAMBENHs.FirstOrDefault(p => p.STT == stt);
            if (SuaThongTin != null)
            {
                SuaThongTin.HOTEN = txtHOTEN.Text;
                SuaThongTin.GIOITINH = cmbGIOITINH.Text;
                SuaThongTin.NAMSINH = dateTimePickerNS.Value;
                SuaThongTin.SDT = txtSDT.Text;
                SuaThongTin.DIACHI = txtDC.Text;
                SuaThongTin.LYDOKHAM = rtbLYDO.Text;
                model.SaveChanges();
                BindGirdPKB(listPhieuKhamBenh());
                MessageBox.Show("Sửa Thông tin lịch hẹn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHOTEN.Text = txtDC.Text = txtSDT.Text = rtbLYDO.Text = "";
                cmbGIOITINH.SelectedIndex = -1;
                dateTimePickerNS.Text = DateTime.Now.ToString();
                int maxSTT = model.PHIEUKHAMBENHs.Max(p => p.STT);
                int newSTT = maxSTT + 1;

                // Gán số thứ tự mới cho textbox
                txtSTT.Text = newSTT.ToString();
            }
        }

        private void btnThemMoiHoaDon_Click(object sender, EventArgs e)
        {
            frmThemMoiHoaDon = new frmThemMoiHoaDon();
            frmThemMoiHoaDon.FormClosing += frmThemMoiHoaDon_FormClosing;
            frmThemMoiHoaDon.Show();
            Hide();
        }
        private void frmThemMoiHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmThemMoiHoaDon.Dispose();
            frmThemMoiHoaDon = null;
            Show();
        }

        private void btnThemMoiCTTHD_Click(object sender, EventArgs e)
        {
            frmThemMoiCTHD = new frmThemMoiCTHD();
            frmThemMoiCTHD.FormClosing += frmThemMoiCTHD_FormClosing;
            frmThemMoiCTHD.Show();
            Hide();
        }

        private void frmThemMoiCTHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmThemMoiCTHD.Dispose();
            frmThemMoiCTHD = null;
            Show();
        }
        
        bool IsThoat = true;

        private void btnDangSuat_Click(object sender, EventArgs e)
        {
            IsThoat = false;
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            //this.Close();
        }
    }
}
