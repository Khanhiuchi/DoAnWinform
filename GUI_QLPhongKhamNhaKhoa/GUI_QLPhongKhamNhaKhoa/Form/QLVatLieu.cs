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
    public partial class frmQLVatLieu : Form
    {
        public frmQLVatLieu()
        {
            InitializeComponent();
        }

        private void frmQLVatLieu_Load(object sender, EventArgs e)
        {
            try
            {
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    var kq = from c in dbContext.VATLIEUDUNGCUNHAKHOAs
                             select new { MaDungCu = c.MADUNGCU, TenDungCu = c.TENDUNGCU, SoLuong = c.SOLUONG, DonGia = c.DONGIA, DVT = c.DVT, ThanhTien = c.DONGIA };

                    dataGridView1.DataSource = kq.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
