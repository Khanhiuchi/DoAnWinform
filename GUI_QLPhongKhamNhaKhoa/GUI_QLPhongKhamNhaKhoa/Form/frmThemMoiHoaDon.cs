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
    public partial class frmThemMoiHoaDon : Form
    {
        private readonly NhanVienDAO nhanVienService = new NhanVienDAO();
        private readonly BenhNhanDAO benhNhanService = new BenhNhanDAO();
        NhaKhoaModel model = new NhaKhoaModel();

        public frmThemMoiHoaDon()
        {
            InitializeComponent();
        }

        private void frmThemMoiHoaDon_Load(object sender, EventArgs e)
        {
            var listNV = nhanVienService.GetDoctor();
            FillComboboxNV(listNV);
            this.cmbMaBN.DataSource = model.BENHNHANs.Select(p => p.MABENHNHAN).ToList();
            this.cmbMaBN.SelectedIndex = 0;
            cmbMaNV.Text = cmbMaBN.Text = txtMaHD.Text = txtTenBN.Text = txtTenNV.Text = txtCV.Text = txtNS.Text = "";
            dtpNgayLap.Text = DateTime.Now.ToString();
        }
        private void FillComboboxNV(List<NHANVIEN> listNV)
        {
            this.cmbMaNV.DataSource = listNV;
            this.cmbMaNV.DisplayMember = "MANV";
            this.cmbMaNV.SelectedIndex = -1;
        }

        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaNV.SelectedItem != null)
            {
                var selectedNV = (NHANVIEN)cmbMaNV.SelectedItem;
                txtTenNV.Text = selectedNV.HOTEN.ToString();
                txtCV.Text = selectedNV.CHUCVU.ToString();
            }
        }

        private void cmbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBN = (int)cmbMaBN.SelectedItem;
            BENHNHAN selectedPatient = model.BENHNHANs.FirstOrDefault(p => p.MABENHNHAN == selectedBN);

            if (selectedPatient != null)
            {
                // Gán thông tin từ bệnh nhân đã chọn vào các TextBox
                txtTenBN.Text = selectedPatient.HOTEN;
                txtNS.Text = selectedPatient.NAMSINH.ToString("dd/MM/yyyy");
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cmbMaNV == null || cmbMaBN == null || txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string mahd = txtMaHD.Text;
            HOADON HoaDonTN = model.HOADONs.FirstOrDefault(p => p.MAHOADON == mahd);
            if (HoaDonTN == null)
            {
                HOADON newHoaDon = new HOADON()
                {
                    THOIGIA = DateTime.Now,
                    MAHOADON = mahd,
                    MANV = cmbMaNV.Text,
                    MABENHNHAN = int.Parse(cmbMaBN.Text),
                    TONGTIEN = 0,
                    TRANGTHAI = "Chưa thanh toán"
                };
                model.HOADONs.Add(newHoaDon);
                model.SaveChanges();
                MessageBox.Show("Lưu hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayLap.Text = cmbMaNV.Text = cmbMaBN.Text = txtMaHD.Text = txtTenBN.Text = txtTenNV.Text = txtCV.Text = txtNS.Text = "";
            }
            else
            {
                MessageBox.Show("Mã hóa đơn bạn vừa nhập trùng với mã hóa đơn trong dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            cmbMaNV.Text = cmbMaBN.Text = txtMaHD.Text = txtTenBN.Text = txtTenNV.Text = txtCV.Text = txtNS.Text = "";
            dtpNgayLap.Text = DateTime.Now.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<HOADON> listHoaDon()
        {
            return model.HOADONs.ToList();
        }

        private void frmThemMoiHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Gọi hàm ReloadDSHD trên form hóa đơn chính
            frmLeTan formletan = Application.OpenForms.OfType<frmLeTan>().FirstOrDefault();
            if (formletan != null)
            {
                formletan.BindGirdHOADON(listHoaDon());
            }
        }
    }
}
