namespace GUI_QLPhongKhamNhaKhoa
{
    partial class FrmLichSuNhapLieuThuoc
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
            this.dgvLichSuThuoc = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAINHAPLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTHOIGIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLichSuNhapLieu = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonXuatExcel = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuThuoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLichSuThuoc
            // 
            this.dgvLichSuThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colLOAINHAPLIEU,
            this.colTHOIGIAN,
            this.colMATHUOC,
            this.colTENTHUOC,
            this.colSOLUONG,
            this.colDVT,
            this.colDONGIA});
            this.dgvLichSuThuoc.Location = new System.Drawing.Point(5, 124);
            this.dgvLichSuThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichSuThuoc.Name = "dgvLichSuThuoc";
            this.dgvLichSuThuoc.RowHeadersWidth = 51;
            this.dgvLichSuThuoc.RowTemplate.Height = 24;
            this.dgvLichSuThuoc.Size = new System.Drawing.Size(845, 297);
            this.dgvLichSuThuoc.TabIndex = 67;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colLOAINHAPLIEU
            // 
            this.colLOAINHAPLIEU.DataPropertyName = "LOAINHAPLIEU";
            this.colLOAINHAPLIEU.HeaderText = "Loại nhập liệu";
            this.colLOAINHAPLIEU.MinimumWidth = 6;
            this.colLOAINHAPLIEU.Name = "colLOAINHAPLIEU";
            this.colLOAINHAPLIEU.Width = 125;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.DataPropertyName = "THOIGIAN";
            this.colTHOIGIAN.HeaderText = "Thời Gian";
            this.colTHOIGIAN.MinimumWidth = 6;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Width = 125;
            // 
            // colMATHUOC
            // 
            this.colMATHUOC.DataPropertyName = "MATHUOC";
            this.colMATHUOC.HeaderText = "Mã thuốc";
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
            // lblLichSuNhapLieu
            // 
            this.lblLichSuNhapLieu.AutoSize = true;
            this.lblLichSuNhapLieu.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSuNhapLieu.ForeColor = System.Drawing.Color.Red;
            this.lblLichSuNhapLieu.Location = new System.Drawing.Point(249, 26);
            this.lblLichSuNhapLieu.Name = "lblLichSuNhapLieu";
            this.lblLichSuNhapLieu.Size = new System.Drawing.Size(333, 38);
            this.lblLichSuNhapLieu.TabIndex = 68;
            this.lblLichSuNhapLieu.Text = "LỊCH SỬ NHẬP LIỆU";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(25, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 30);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(124, 80);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(155, 22);
            this.txtTimKiem.TabIndex = 70;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonXuatExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 31);
            this.toolStrip1.TabIndex = 71;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonXuatExcel
            // 
            this.toolStripButtonXuatExcel.BackColor = System.Drawing.Color.Ivory;
            this.toolStripButtonXuatExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonXuatExcel.Image = global::GUI_QLPhongKhamNhaKhoa.Properties.Resources.Xuất_excel;
            this.toolStripButtonXuatExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonXuatExcel.Name = "toolStripButtonXuatExcel";
            this.toolStripButtonXuatExcel.Size = new System.Drawing.Size(126, 28);
            this.toolStripButtonXuatExcel.Text = "Xuất file Excel";
            this.toolStripButtonXuatExcel.Click += new System.EventHandler(this.toolStripButtonXuatExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(766, 426);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmLichSuNhapLieuThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 460);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblLichSuNhapLieu);
            this.Controls.Add(this.dgvLichSuThuoc);
            this.Name = "FrmLichSuNhapLieuThuoc";
            this.Text = "FrmLichSuNhapLieuThuoc";
            this.Load += new System.EventHandler(this.FrmLichSuNhapLieuThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuThuoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLichSuThuoc;
        private System.Windows.Forms.Label lblLichSuNhapLieu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonXuatExcel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOAINHAPLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTHOIGIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDONGIA;
    }
}