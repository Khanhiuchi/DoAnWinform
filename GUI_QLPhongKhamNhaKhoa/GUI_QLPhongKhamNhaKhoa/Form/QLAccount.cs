using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;

namespace GUI_QLPhongKhamNhaKhoa
{
    public partial class frmQLAccount : Form
    {
        public frmQLAccount()
        {
            InitializeComponent();
        }

        NhaKhoaModel conTexDB = new NhaKhoaModel();

        private void frmQLAccount_Load(object sender, EventArgs e)
        {
            try
            {
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    var data = dbContext.ACCOUNTs.ToList();

                    // Gán dữ liệu cho DataGridView
                    gvQLAccount.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String userName = txtUsername.Text;
                String password = txtPassword.Text;
                String displayName = txtDisplayname.Text;
                String type = txtType.Text;
                // Tạo một đối tượng mới của ACCOUNT
                ACCOUNT newEntity = new ACCOUNT();
                {
                    // Thiết lập các thuộc tính của đối tượng mới
                    newEntity.USERNAME = userName;
                    newEntity.PASSWORD = password;
                    newEntity.DISPLAYNAME = displayName;
                    newEntity.TYPE = type;

                };
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    // Thêm đối tượng mới vào account
                    dbContext.ACCOUNTs.Add(newEntity);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();

                    // Tải lại dữ liệu từ cơ sở dữ liệu
                    var data = dbContext.ACCOUNTs.ToList();

                    // Gán lại dữ liệu cho DataGridView
                    gvQLAccount.DataSource = data;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    foreach (DataGridViewRow selectedRow in gvQLAccount.SelectedRows)
                    {
                        // Lấy giá trị khóa chính của dòng đang được chọn
                        String userName = selectedRow.Cells[0].Value.ToString();

                        // Tìm đối tượng cần xóa trong cơ sở dữ liệu
                        ACCOUNT entityToDelete = dbContext.ACCOUNTs.Find(userName);


                        if (entityToDelete != null)
                        {
                            // Xóa đối tượng khỏi DbSet
                            DialogResult dr = MessageBox.Show("Ban co muon xoa??", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                dbContext.ACCOUNTs.Remove(entityToDelete);
                            }
                            else return;
                        }
                    }

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();
                    // Tải lại dữ liệu từ cơ sở dữ liệu
                    var data = dbContext.ACCOUNTs.ToList();

                    // Gán lại dữ liệu cho DataGridView
                    gvQLAccount.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (NhaKhoaModel dbContext = new NhaKhoaModel())
                {
                    if (gvQLAccount.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = gvQLAccount.SelectedRows[0];
                        // Lấy giá trị khóa chính của dòng đầu tiên được chọn
                        String userName = selectedRow.Cells[0].Value.ToString();
                        // Tìm đối tượng cần sửa đổi trong cơ sở dữ liệu
                        ACCOUNT entityToUpdate = dbContext.ACCOUNTs.Find(userName);
                        if (entityToUpdate != null)
                        {
                            // Lấy dữ liệu từ TextBox
                            string userNameValue = txtUsername.Text;
                            string passwordValue = txtPassword.Text;
                            String disPlayNameValue = txtDisplayname.Text;
                            String typeValue = txtType.Text;

                            // Cập nhật thuộc tính của đối tượng từ TextBox
                            entityToUpdate.USERNAME = userNameValue;
                            entityToUpdate.PASSWORD = passwordValue;
                            entityToUpdate.DISPLAYNAME = disPlayNameValue;
                            entityToUpdate.TYPE = typeValue;

                            // Lưu thay đổi vào cơ sở dữ liệu
                            dbContext.SaveChanges();
                            // Tải lại dữ liệu từ cơ sở dữ liệu
                            var data = dbContext.ACCOUNTs.ToList();

                            // Gán lại dữ liệu cho DataGridView
                            gvQLAccount.DataSource = data;
                        }
                    }

                }

            }
            catch (Exception ex) { MessageBox.Show(e.ToString()); }
        }

        private void gvQLAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvQLAccount.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gvQLAccount.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gvQLAccount.Rows[selectedRowIndex];

                //Hiển thị
                txtUsername.Text = selectedRow.Cells[0].Value.ToString();
                txtPassword.Text = selectedRow.Cells[1].Value.ToString();
                txtDisplayname.Text = selectedRow.Cells[2].Value.ToString();
                txtType.Text = selectedRow.Cells[3].Value.ToString();
            }
        }
    }
}
