using DAL.Model;
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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    var kq = from c in dbContext.NHANVIENs
                             select new { MaNV = c.MANV, HoTen = c.HOTEN, GioiTinh = c.GIOITINH, ChucVu = c.CHUCVU, NamSinh = c.NAMSINH, KinhNgiem = c.KINHNGHIEM, BangCap = c.BANGCAP, SDT = c.SDT, DiaChi = c.DIACHI };

                    dataGridViewQLNhanvien.DataSource = kq.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
