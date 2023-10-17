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
    public partial class frmQLHoaDon : Form
    {
        public frmQLHoaDon()
        {
            InitializeComponent();
        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    var kq = from c in dbContext.HOADONs
                             select new { ThoiGian = c.THOIGIA, MaHoaDon = c.MAHOADON, MaBenhNhan = c.MABENHNHAN, MaNV = c.MANV, TongTien = c.TONGTIEN, TRANGTHAI = c.TRANGTHAI };

                    dataGridViewQLHoaDon.DataSource = kq.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
