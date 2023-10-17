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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QLPhongKhamNhaKhoa
{
    public partial class frmDangNhap : Form
    {
        private ACCOUNTDAO aCCOUNTDAO  =  new ACCOUNTDAO();  
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát!", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try 
            {
                errorProvider1.SetError(txtTenDangNhap, "");
                if (txtTenDangNhap.Text == "" && txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Tên Đăng Nhập Và Mật Khẩu", "Thông Báo");
                }
                else if (txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Tên Đăng Nhập", "Thông Báo");
                }
                else if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Mật Khẩu", "Thông Báo");
                }

                

                ShowLoadingForm(); // Hiển thị form chờ

                // Bắt đầu quá trình đăng nhập
                Task.Run(() =>
                {
                    try
                    {
                        string userName = txtTenDangNhap.Text;
                        string password = txtMatKhau.Text;
                        bool isAuthenticated = aCCOUNTDAO.AuthenticateUser(userName, password);

                        if (isAuthenticated)
                        {
                            string role = aCCOUNTDAO.GetUserRole(userName);

                            // Đóng form chờ và tiếp tục xử lý tùy theo vai trò
                            Invoke(new Action(() =>
                            {
                                CloseLoadingForm();
                                ProcessUserRole(role);
                            }));
                        }
                        else
                        {
                            // Đăng nhập thất bại
                            Invoke(new Action(() =>
                            {
                                CloseLoadingForm();
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi và đóng form chờ
                        Invoke(new Action(() =>
                        {
                            CloseLoadingForm();
                            MessageBox.Show(ex.Message);
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProcessUserRole(string role)
        {
            if (role == "Quản trị viên")
            {
                this.Hide();
                frmadmin f = new frmadmin();
                f.ShowDialog();
            }
            else if (role == "Lễ tân")
            {
                this.Hide();
                frmLeTan f = new frmLeTan();
                f.ShowDialog();
            }
            else
            {
                // Xử lý cho các vai trò khác (nếu có)
            }
        }

        private void ShowLoadingForm()
        {
            frmLoading loadingForm = new frmLoading();
            loadingForm.Show();
        }

        private void CloseLoadingForm()
        {
            frmLoading loadingForm = Application.OpenForms.OfType<frmLoading>().FirstOrDefault();
            loadingForm?.Close();
        }

        private void lkbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Hiển thị form khôi phục mật khẩu (frmKhoiPhucMatKhau)
            frmKhoiPhucMatKhau khoiPhucMatKhauForm = new frmKhoiPhucMatKhau();
            khoiPhucMatKhauForm.ShowDialog();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtMatKhau.PasswordChar == '*')
                {
                    txtMatKhau.PasswordChar = '\0';
                }
                else
                {
                    txtMatKhau.PasswordChar = '*';
                }
            }catch (Exception ex) { }
        }
    }
}
