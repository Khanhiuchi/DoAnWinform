namespace GUI_QLPhongKhamNhaKhoa
{
    partial class frmQLAccount
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
            this.gvQLAccount = new System.Windows.Forms.DataGridView();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDisplayname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDisplayname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gvQLAccount
            // 
            this.gvQLAccount.AllowUserToAddRows = false;
            this.gvQLAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQLAccount.Location = new System.Drawing.Point(12, 12);
            this.gvQLAccount.Name = "gvQLAccount";
            this.gvQLAccount.RowHeadersWidth = 51;
            this.gvQLAccount.RowTemplate.Height = 24;
            this.gvQLAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvQLAccount.Size = new System.Drawing.Size(776, 324);
            this.gvQLAccount.TabIndex = 1;
            this.gvQLAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQLAccount_CellClick);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(565, 400);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(152, 22);
            this.txtType.TabIndex = 14;
            // 
            // txtDisplayname
            // 
            this.txtDisplayname.Location = new System.Drawing.Point(565, 357);
            this.txtDisplayname.Name = "txtDisplayname";
            this.txtDisplayname.Size = new System.Drawing.Size(152, 22);
            this.txtDisplayname.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 403);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 22);
            this.txtPassword.TabIndex = 16;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(478, 406);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 16);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "TYPE:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(176, 354);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 22);
            this.txtUsername.TabIndex = 13;
            // 
            // lblDisplayname
            // 
            this.lblDisplayname.AutoSize = true;
            this.lblDisplayname.Location = new System.Drawing.Point(454, 360);
            this.lblDisplayname.Name = "lblDisplayname";
            this.lblDisplayname.Size = new System.Drawing.Size(105, 16);
            this.lblDisplayname.TabIndex = 10;
            this.lblDisplayname.Text = "DISPLAYNAME:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(80, 403);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 16);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(80, 357);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 16);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "USERNAME: ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(586, 437);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 38);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(364, 437);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(171, 437);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 38);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQLAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtDisplayname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblDisplayname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gvQLAccount);
            this.Name = "frmQLAccount";
            this.Text = "QLAccount";
            this.Load += new System.EventHandler(this.frmQLAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvQLAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvQLAccount;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDisplayname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDisplayname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}