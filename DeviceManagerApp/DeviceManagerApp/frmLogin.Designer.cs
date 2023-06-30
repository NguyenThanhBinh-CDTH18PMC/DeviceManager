namespace DeviceManagerApp
{
    partial class frmLogin
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
            picLogo = new System.Windows.Forms.PictureBox();
            lblTen = new System.Windows.Forms.Label();
            lblDangNhap = new System.Windows.Forms.Label();
            lblTenDangNhap = new System.Windows.Forms.Label();
            lblMatKhau = new System.Windows.Forms.Label();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            btbDangNhap = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new System.Drawing.Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(299, 436);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTen.ForeColor = System.Drawing.Color.White;
            lblTen.Location = new System.Drawing.Point(305, 23);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(483, 32);
            lblTen.TabIndex = 1;
            lblTen.Text = "QUẢN LÝ TRANG THIẾT BỊ PHÒNG MÁY";
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDangNhap.ForeColor = System.Drawing.Color.White;
            lblDangNhap.Location = new System.Drawing.Point(497, 87);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new System.Drawing.Size(139, 28);
            lblDangNhap.TabIndex = 2;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.ForeColor = System.Drawing.Color.White;
            lblTenDangNhap.Location = new System.Drawing.Point(322, 154);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new System.Drawing.Size(134, 25);
            lblTenDangNhap.TabIndex = 3;
            lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.ForeColor = System.Drawing.Color.White;
            lblMatKhau.Location = new System.Drawing.Point(322, 239);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new System.Drawing.Size(87, 25);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new System.Drawing.Point(462, 148);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(238, 31);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(462, 233);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new System.Drawing.Size(238, 31);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btbDangNhap
            // 
            btbDangNhap.Location = new System.Drawing.Point(322, 336);
            btbDangNhap.Name = "btbDangNhap";
            btbDangNhap.Size = new System.Drawing.Size(161, 44);
            btbDangNhap.TabIndex = 7;
            btbDangNhap.Text = "Đăng Nhập";
            btbDangNhap.UseVisualStyleBackColor = true;
            btbDangNhap.Click += btbDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new System.Drawing.Point(577, 336);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(161, 44);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            ClientSize = new System.Drawing.Size(800, 436);
            Controls.Add(btnThoat);
            Controls.Add(btbDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblDangNhap);
            Controls.Add(lblTen);
            Controls.Add(picLogo);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btbDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}