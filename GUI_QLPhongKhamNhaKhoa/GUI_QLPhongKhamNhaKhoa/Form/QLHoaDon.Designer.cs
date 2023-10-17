namespace GUI_QLPhongKhamNhaKhoa
{
    partial class frmQLHoaDon
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
            this.dataGridViewQLHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQLHoaDon
            // 
            this.dataGridViewQLHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLHoaDon.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewQLHoaDon.Name = "dataGridViewQLHoaDon";
            this.dataGridViewQLHoaDon.RowHeadersWidth = 51;
            this.dataGridViewQLHoaDon.RowTemplate.Height = 24;
            this.dataGridViewQLHoaDon.Size = new System.Drawing.Size(843, 435);
            this.dataGridViewQLHoaDon.TabIndex = 1;
            // 
            // frmQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.dataGridViewQLHoaDon);
            this.Name = "frmQLHoaDon";
            this.Text = "QLHoaDon";
            this.Load += new System.EventHandler(this.frmQLHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQLHoaDon;
    }
}