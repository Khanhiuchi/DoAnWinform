namespace GUI_QLPhongKhamNhaKhoa
{
    partial class frmQLThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem_CapNhat = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.colMATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhap = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNhapExcel = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.toolStripBtnXemLSThuoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXuatExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(445, 180);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(100, 28);
            this.btnXuat.TabIndex = 82;
            this.btnXuat.Text = "Xuất thuốc";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(173, 180);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 80;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem_CapNhat
            // 
            this.btnThem_CapNhat.Location = new System.Drawing.Point(23, 180);
            this.btnThem_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem_CapNhat.Name = "btnThem_CapNhat";
            this.btnThem_CapNhat.Size = new System.Drawing.Size(119, 28);
            this.btnThem_CapNhat.TabIndex = 78;
            this.btnThem_CapNhat.Text = "Thêm/Cập nhật";
            this.btnThem_CapNhat.UseVisualStyleBackColor = true;
            this.btnThem_CapNhat.Click += new System.EventHandler(this.btnThem_CapNhat_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(654, 82);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(109, 22);
            this.txtDonGia.TabIndex = 77;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(421, 132);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(109, 22);
            this.txtSoLuong.TabIndex = 76;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(421, 83);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(109, 22);
            this.txtDVT.TabIndex = 75;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(149, 128);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(164, 22);
            this.txtTenThuoc.TabIndex = 74;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(149, 83);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(109, 22);
            this.txtMaThuoc.TabIndex = 73;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(578, 83);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(59, 18);
            this.lblDonGia.TabIndex = 72;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVT.Location = new System.Drawing.Point(341, 87);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(37, 18);
            this.lblDVT.TabIndex = 71;
            this.lblDVT.Text = "DVT";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(341, 132);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(67, 18);
            this.lblSoLuong.TabIndex = 70;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(318, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 36);
            this.label3.TabIndex = 69;
            this.label3.Text = "Danh Mục Thuốc";
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenThuoc.Location = new System.Drawing.Point(46, 128);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(74, 18);
            this.lblTenThuoc.TabIndex = 68;
            this.lblTenThuoc.Text = "Tên thuốc";
            // 
            // lblMaThuoc
            // 
            this.lblMaThuoc.AutoSize = true;
            this.lblMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThuoc.Location = new System.Drawing.Point(50, 87);
            this.lblMaThuoc.Name = "lblMaThuoc";
            this.lblMaThuoc.Size = new System.Drawing.Size(70, 18);
            this.lblMaThuoc.TabIndex = 67;
            this.lblMaThuoc.Text = "Mã thuốc";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMATHUOC,
            this.colTENTHUOC,
            this.colSOLUONG,
            this.colDVT,
            this.colDONGIA});
            this.dgvThuoc.Location = new System.Drawing.Point(12, 226);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(774, 224);
            this.dgvThuoc.TabIndex = 66;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // colMATHUOC
            // 
            this.colMATHUOC.DataPropertyName = "MATHUOC";
            this.colMATHUOC.HeaderText = "Mã Thuốc";
            this.colMATHUOC.MinimumWidth = 6;
            this.colMATHUOC.Name = "colMATHUOC";
            this.colMATHUOC.Width = 90;
            // 
            // colTENTHUOC
            // 
            this.colTENTHUOC.DataPropertyName = "TENTHUOC";
            this.colTENTHUOC.HeaderText = "Tên thuốc";
            this.colTENTHUOC.MinimumWidth = 6;
            this.colTENTHUOC.Name = "colTENTHUOC";
            this.colTENTHUOC.Width = 125;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.DataPropertyName = "SOLUONG";
            this.colSOLUONG.HeaderText = "Số lượng";
            this.colSOLUONG.MinimumWidth = 6;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Width = 80;
            // 
            // colDVT
            // 
            this.colDVT.DataPropertyName = "DVT";
            this.colDVT.HeaderText = "DVT";
            this.colDVT.MinimumWidth = 6;
            this.colDVT.Name = "colDVT";
            this.colDVT.Width = 120;
            // 
            // colDONGIA
            // 
            this.colDONGIA.DataPropertyName = "DONGIA";
            this.colDONGIA.HeaderText = "Đơn giá";
            this.colDONGIA.MinimumWidth = 6;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Width = 150;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(308, 180);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(100, 28);
            this.btnNhap.TabIndex = 84;
            this.btnNhap.Text = "Nhập Thuốc";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnXemLSThuoc,
            this.toolStripBtnXuatExcel,
            this.toolStripButtonNhapExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1262, 31);
            this.toolStrip1.TabIndex = 86;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNhapExcel
            // 
            this.toolStripButtonNhapExcel.BackColor = System.Drawing.Color.Ivory;
            this.toolStripButtonNhapExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonNhapExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButtonNhapExcel.Image = global::GUI_QLPhongKhamNhaKhoa.Properties.Resources.Nhập_Excel;
            this.toolStripButtonNhapExcel.ImageTransparentColor = System.Drawing.Color.MediumSlateBlue;
            this.toolStripButtonNhapExcel.Name = "toolStripButtonNhapExcel";
            this.toolStripButtonNhapExcel.Size = new System.Drawing.Size(150, 28);
            this.toolStripButtonNhapExcel.Text = "Nhập từ file Excel";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(581, 180);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 28);
            this.btnTimKiem.TabIndex = 87;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // toolStripBtnXemLSThuoc
            // 
            this.toolStripBtnXemLSThuoc.BackColor = System.Drawing.Color.Ivory;
            this.toolStripBtnXemLSThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripBtnXemLSThuoc.Image = global::GUI_QLPhongKhamNhaKhoa.Properties.Resources.lích_Sử_Icon;
            this.toolStripBtnXemLSThuoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnXemLSThuoc.Name = "toolStripBtnXemLSThuoc";
            this.toolStripBtnXemLSThuoc.Size = new System.Drawing.Size(174, 28);
            this.toolStripBtnXemLSThuoc.Text = "Xem lịch sử nhập liệu";
            this.toolStripBtnXemLSThuoc.Click += new System.EventHandler(this.toolStripBtnXemLSThuoc_Click);
            // 
            // toolStripBtnXuatExcel
            // 
            this.toolStripBtnXuatExcel.BackColor = System.Drawing.Color.Ivory;
            this.toolStripBtnXuatExcel.Image = global::GUI_QLPhongKhamNhaKhoa.Properties.Resources.Xuất_excel;
            this.toolStripBtnXuatExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnXuatExcel.Name = "toolStripBtnXuatExcel";
            this.toolStripBtnXuatExcel.Size = new System.Drawing.Size(126, 28);
            this.toolStripBtnXuatExcel.Text = "Xuất file Excel";
            this.toolStripBtnXuatExcel.Click += new System.EventHandler(this.toolStripBtnXuatExcel_Click);
            // 
            // frmQLThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 470);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem_CapNhat);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenThuoc);
            this.Controls.Add(this.lblMaThuoc);
            this.Controls.Add(this.dgvThuoc);
            this.Name = "frmQLThuoc";
            this.Text = "Danh Mục Thuốc";
            this.Load += new System.EventHandler(this.frmQLThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem_CapNhat;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.Label lblMaThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDONGIA;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnXemLSThuoc;
        private System.Windows.Forms.ToolStripButton toolStripBtnXuatExcel;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNhapExcel;
    }
}