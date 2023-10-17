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
    public partial class frmThemMoiCTHD : Form
    {
        private readonly CTHDDAO cTHDService = new CTHDDAO();
        private readonly HoaDonDAO hoaDonService = new HoaDonDAO();
        private readonly DieuTriDAO dieuTriService = new DieuTriDAO();
        NhaKhoaModel model = new NhaKhoaModel();
        public frmThemMoiCTHD()
        {
            InitializeComponent();
        }

        private void frmThemMoiCTHD_Load(object sender, EventArgs e)
        {
            try
            {
                var listCTHD = cTHDService.GetAll();
                BindGirdCTHD(listCTHD);
                var listHD = hoaDonService.GetAll();
                FillComboboxHD(listHD);
                var listDT = dieuTriService.GetAll();
                FillComboboxDT(listDT);
                txtTenDT.Text = txtDVT.Text = txtDonGia.Text = txtThanhTien.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGirdCTHD(List<CTHD> listCTHD)
        {
            dgvCTHD.Rows.Clear();
            foreach (var cthd in listCTHD)
            {
                int selected = dgvCTHD.Rows.Add();
                dgvCTHD.Rows[selected].Cells[0].Value = cthd.MAHOADON;
                dgvCTHD.Rows[selected].Cells[1].Value = cthd.MADIEUTRI;
                dgvCTHD.Rows[selected].Cells[2].Value = cthd.TENDIEUTRI;
                dgvCTHD.Rows[selected].Cells[3].Value = cthd.SOLUONG;
                dgvCTHD.Rows[selected].Cells[4].Value = cthd.THANHTIEN;
            }
        }
        private void FillComboboxHD(List<HOADON> listHD)
        {
            this.cmbMaHD.DataSource = listHD;
            this.cmbMaHD.DisplayMember = "MAHOADON";
            this.cmbMaHD.SelectedIndex = -1;
        }
        private void FillComboboxDT(List<DIEUTRI> listDT)
        {
            this.cmbMaDT.DataSource = listDT;
            this.cmbMaDT.DisplayMember = "MADIEUTRI";
            this.cmbMaDT.SelectedIndex = -1;
        }

        private void cmbMaDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaDT.SelectedItem != null)
            {
                var selectedDT = (DIEUTRI)cmbMaDT.SelectedItem;
                txtTenDT.Text = selectedDT.TENDIEUTRI.ToString();
                txtDVT.Text = selectedDT.DVT.ToString();
                txtDonGia.Text = selectedDT.DONGIA.ToString();
                txtThanhTien.Text = ((float)selectedDT.DONGIA * (float)numericUpDownSL.Value).ToString(); ;
            }
        }

        private void numericUpDownSL_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ NumericUpDown
            decimal quantity = numericUpDownSL.Value;

            // Kiểm tra giá trị hợp lệ cho đơn giá (giả sử là kiểu decimal)
            decimal unitPrice;
            if (decimal.TryParse(txtDonGia.Text, out unitPrice))
            {
                // Tính toán giá tiền
                decimal totalPrice = quantity * unitPrice;

                // Cập nhật giá trị trong TextBox
                txtThanhTien.Text = totalPrice.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuChiTietHoaDon();
        }

        private List<CTHD> listCTHD()
        {
            return model.CTHDs.ToList();
        }

        private void LuuChiTietHoaDon()
        {
            if (cmbMaDT.SelectedItem == null || cmbMaHD.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soluong = (int)numericUpDownSL.Value;
            CTHD newCTHD = new CTHD()
            {
                MAHOADON = cmbMaHD.Text,
                MADIEUTRI = cmbMaDT.Text,
                TENDIEUTRI = txtTenDT.Text,
                SOLUONG = soluong,
                THANHTIEN = float.Parse(txtThanhTien.Text),
            };
            model.CTHDs.Add(newCTHD);
            model.SaveChanges();
            BindGirdCTHD(listCTHD());
            MessageBox.Show("Lưu chi tiết hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbMaDT.SelectedIndex = -1;
            txtTenDT.Text = txtDVT.Text = txtDonGia.Text = txtThanhTien.Text = "";
            numericUpDownSL.Value = 1;

            // Cập nhật tổng tiền trên hóa đơn
            UpdateTongTienHoaDon(newCTHD.MAHOADON);
        }

        private void UpdateTongTienHoaDon(string maHoaDon)
        {
            var hoaDon = model.HOADONs.FirstOrDefault(hd => hd.MAHOADON == maHoaDon);

            if (hoaDon != null)
            {
                hoaDon.TONGTIEN = model.CTHDs.Where(cthd => cthd.MAHOADON == maHoaDon).Sum(cthd => cthd.THANHTIEN);
                model.SaveChanges();
            }
        }
        private List<HOADON> listHoaDon()
        {
            return model.HOADONs.ToList();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtTenDT.Text = txtDVT.Text = txtDonGia.Text = txtThanhTien.Text = "";
            cmbMaHD.SelectedIndex = -1;
            cmbMaDT.SelectedIndex = -1;
            numericUpDownSL.Value = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemMoiCTHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Gọi hàm ReloadDSHD trên form hóa đơn chính
            frmLeTan formHoaDon = Application.OpenForms.OfType<frmLeTan>().FirstOrDefault();
            if (formHoaDon != null)
            {
                formHoaDon.BindGirdHOADON(listHoaDon());
            }
        }
    }
}
