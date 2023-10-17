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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void quảnLýAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLAccount f1 = new frmQLAccount();
            lblHome.Text = quảnLýAcToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void btnQLtaikhoan_Click(object sender, EventArgs e)
        {
            frmQLAccount f1 = new frmQLAccount();
            lblHome.Text = quảnLýAcToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f2 = new frmQLNhanVien();
            lblHome.Text = quảnLýNhânViênToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f2.MdiParent = this;
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f2.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f2);
            f2.Show();
        }

        private void btnQLnhanvien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f2 = new frmQLNhanVien();
            lblHome.Text = quảnLýNhânViênToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f2.MdiParent = this;
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f2.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f2);
            f2.Show();
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLbenhnhan_Click(object sender, EventArgs e)
        {
            frmQLBenhNhan f1 = new frmQLBenhNhan();
            lblHome.Text = quảnLýBệnhNhânToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void quảnLýVậtLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLVatLieu f1 = new frmQLVatLieu();
            lblHome.Text = quảnLýVậtLiệuToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void btnQLvatlieu_Click(object sender, EventArgs e)
        {
            frmQLVatLieu f1 = new frmQLVatLieu();
            lblHome.Text = quảnLýVậtLiệuToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThuoc f1 = new frmQLThuoc();
            lblHome.Text = quảnLýThuốcToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void btnQLthuoc_Click(object sender, EventArgs e)
        {
            frmQLThuoc f1 = new frmQLThuoc();
            lblHome.Text = quảnLýThuốcToolStripMenuItem.Text;
            panel_Body.Controls.Clear();
            f1.MdiParent = this;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHoaDon f1 = new frmQLHoaDon();
            lblHome.Text = quảnLýHóaĐơnToolStripMenuItem.Text;
            f1.MdiParent = this;
            panel_Body.Controls.Clear();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void btnQLhoadon_Click(object sender, EventArgs e)
        {
            frmQLHoaDon f1 = new frmQLHoaDon();
            lblHome.Text = quảnLýHóaĐơnToolStripMenuItem.Text;
            f1.MdiParent = this;
            panel_Body.Controls.Clear();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None; //bỏ khung viền
            f1.Dock = DockStyle.Fill; //lam cho đầy pain
            panel_Body.Controls.Add(f1);
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_Body.Controls.Clear();
            lblHome.Text = "Home";
        }
        bool IsThoat = true;

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            IsThoat = false;
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            //this.Close();
        }

        //hiển thị giữa nàn hình

        private void frmadmin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
    }
}
