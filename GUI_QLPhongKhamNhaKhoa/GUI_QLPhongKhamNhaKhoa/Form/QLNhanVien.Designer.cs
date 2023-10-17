namespace GUI_QLPhongKhamNhaKhoa
{
    partial class frmQLNhanVien
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
            this.dataGridViewQLNhanvien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQLNhanvien
            // 
            this.dataGridViewQLNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLNhanvien.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewQLNhanvien.Name = "dataGridViewQLNhanvien";
            this.dataGridViewQLNhanvien.RowHeadersWidth = 51;
            this.dataGridViewQLNhanvien.RowTemplate.Height = 24;
            this.dataGridViewQLNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQLNhanvien.Size = new System.Drawing.Size(1005, 435);
            this.dataGridViewQLNhanvien.TabIndex = 1;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.dataGridViewQLNhanvien);
            this.Name = "frmQLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLNhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQLNhanvien;
    }
}