namespace DeviceManagerApp
{
    partial class frmQuanLyTaiKhoan
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
            components = new System.ComponentModel.Container();
            gbTaiKhoan = new System.Windows.Forms.GroupBox();
            cbTenTaiKhoan = new System.Windows.Forms.ComboBox();
            btnThuHoiTK = new System.Windows.Forms.Button();
            cbTeacher = new System.Windows.Forms.ComboBox();
            CkbMatKhau = new System.Windows.Forms.CheckBox();
            txtMatKhauMoi = new System.Windows.Forms.TextBox();
            lblMatKhauMoi = new System.Windows.Forms.Label();
            gbTiemKim = new System.Windows.Forms.GroupBox();
            btnTimKiemTk = new System.Windows.Forms.Button();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnXoaTk = new System.Windows.Forms.Button();
            btnSuaTk = new System.Windows.Forms.Button();
            btnThemTk = new System.Windows.Forms.Button();
            txtMatKhauCu = new System.Windows.Forms.TextBox();
            lblMatKhauCu = new System.Windows.Forms.Label();
            lblTenTK = new System.Windows.Forms.Label();
            txtDiaChi = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            lblNgaysinh = new System.Windows.Forms.Label();
            txtSDT = new System.Windows.Forms.TextBox();
            lblSdt = new System.Windows.Forms.Label();
            rdNu = new System.Windows.Forms.RadioButton();
            rdNam = new System.Windows.Forms.RadioButton();
            lblGioitinh = new System.Windows.Forms.Label();
            lblTenTaiKhoan = new System.Windows.Forms.Label();
            dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gbTaiKhoan.SuspendLayout();
            gbTiemKim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // gbTaiKhoan
            // 
            gbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            gbTaiKhoan.Controls.Add(cbTenTaiKhoan);
            gbTaiKhoan.Controls.Add(btnThuHoiTK);
            gbTaiKhoan.Controls.Add(cbTeacher);
            gbTaiKhoan.Controls.Add(CkbMatKhau);
            gbTaiKhoan.Controls.Add(txtMatKhauMoi);
            gbTaiKhoan.Controls.Add(lblMatKhauMoi);
            gbTaiKhoan.Controls.Add(gbTiemKim);
            gbTaiKhoan.Controls.Add(btnXoaTk);
            gbTaiKhoan.Controls.Add(btnSuaTk);
            gbTaiKhoan.Controls.Add(btnThemTk);
            gbTaiKhoan.Controls.Add(txtMatKhauCu);
            gbTaiKhoan.Controls.Add(lblMatKhauCu);
            gbTaiKhoan.Controls.Add(lblTenTK);
            gbTaiKhoan.Controls.Add(txtDiaChi);
            gbTaiKhoan.Controls.Add(label1);
            gbTaiKhoan.Controls.Add(dtNgaySinh);
            gbTaiKhoan.Controls.Add(lblNgaysinh);
            gbTaiKhoan.Controls.Add(txtSDT);
            gbTaiKhoan.Controls.Add(lblSdt);
            gbTaiKhoan.Controls.Add(rdNu);
            gbTaiKhoan.Controls.Add(rdNam);
            gbTaiKhoan.Controls.Add(lblGioitinh);
            gbTaiKhoan.Controls.Add(lblTenTaiKhoan);
            gbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            gbTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTaiKhoan.Location = new System.Drawing.Point(0, 0);
            gbTaiKhoan.Name = "gbTaiKhoan";
            gbTaiKhoan.Size = new System.Drawing.Size(1234, 495);
            gbTaiKhoan.TabIndex = 0;
            gbTaiKhoan.TabStop = false;
            gbTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // cbTenTaiKhoan
            // 
            cbTenTaiKhoan.FormattingEnabled = true;
            cbTenTaiKhoan.Location = new System.Drawing.Point(721, 145);
            cbTenTaiKhoan.Name = "cbTenTaiKhoan";
            cbTenTaiKhoan.Size = new System.Drawing.Size(216, 33);
            cbTenTaiKhoan.TabIndex = 22;
            // 
            // btnThuHoiTK
            // 
            btnThuHoiTK.BackColor = System.Drawing.Color.Transparent;
            btnThuHoiTK.BackgroundImage = Properties.Resources.delete_x;
            btnThuHoiTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThuHoiTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThuHoiTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThuHoiTK.Location = new System.Drawing.Point(1088, 288);
            btnThuHoiTK.Name = "btnThuHoiTK";
            btnThuHoiTK.Size = new System.Drawing.Size(134, 50);
            btnThuHoiTK.TabIndex = 21;
            toolTip1.SetToolTip(btnThuHoiTK, "Thu Hồi Tài Khoản");
            btnThuHoiTK.UseVisualStyleBackColor = false;
            // 
            // cbTeacher
            // 
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new System.Drawing.Point(160, 42);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new System.Drawing.Size(207, 33);
            cbTeacher.TabIndex = 20;
            // 
            // CkbMatKhau
            // 
            CkbMatKhau.AutoSize = true;
            CkbMatKhau.Location = new System.Drawing.Point(589, 202);
            CkbMatKhau.Name = "CkbMatKhau";
            CkbMatKhau.Size = new System.Drawing.Size(164, 29);
            CkbMatKhau.TabIndex = 19;
            CkbMatKhau.Text = "Đổi Mật Khẩu ?";
            CkbMatKhau.UseVisualStyleBackColor = true;
            CkbMatKhau.CheckedChanged += CkbMatKhau_CheckedChanged;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new System.Drawing.Point(721, 298);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new System.Drawing.Size(216, 31);
            txtMatKhauMoi.TabIndex = 18;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Location = new System.Drawing.Point(589, 301);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new System.Drawing.Size(138, 25);
            lblMatKhauMoi.TabIndex = 17;
            lblMatKhauMoi.Text = "Mật Khẩu Mới :";
            // 
            // gbTiemKim
            // 
            gbTiemKim.BackColor = System.Drawing.Color.Transparent;
            gbTiemKim.Controls.Add(btnTimKiemTk);
            gbTiemKim.Controls.Add(txtTimKiem);
            gbTiemKim.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbTiemKim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbTiemKim.Location = new System.Drawing.Point(3, 341);
            gbTiemKim.Name = "gbTiemKim";
            gbTiemKim.Size = new System.Drawing.Size(1228, 151);
            gbTiemKim.TabIndex = 16;
            gbTiemKim.TabStop = false;
            gbTiemKim.Text = "Tìm Kiếm";
            // 
            // btnTimKiemTk
            // 
            btnTimKiemTk.BackColor = System.Drawing.Color.Lime;
            btnTimKiemTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemTk.Location = new System.Drawing.Point(1085, 30);
            btnTimKiemTk.Name = "btnTimKiemTk";
            btnTimKiemTk.Size = new System.Drawing.Size(134, 50);
            btnTimKiemTk.TabIndex = 17;
            btnTimKiemTk.Text = "Tìm Kiếm";
            btnTimKiemTk.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTimKiem.Location = new System.Drawing.Point(22, 64);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(342, 31);
            txtTimKiem.TabIndex = 0;
            // 
            // btnXoaTk
            // 
            btnXoaTk.BackColor = System.Drawing.Color.Lime;
            btnXoaTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaTk.Location = new System.Drawing.Point(1088, 202);
            btnXoaTk.Name = "btnXoaTk";
            btnXoaTk.Size = new System.Drawing.Size(134, 50);
            btnXoaTk.TabIndex = 15;
            btnXoaTk.Text = "Xóa";
            btnXoaTk.UseVisualStyleBackColor = false;
            // 
            // btnSuaTk
            // 
            btnSuaTk.BackColor = System.Drawing.Color.Lime;
            btnSuaTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaTk.Location = new System.Drawing.Point(1088, 126);
            btnSuaTk.Name = "btnSuaTk";
            btnSuaTk.Size = new System.Drawing.Size(134, 50);
            btnSuaTk.TabIndex = 14;
            btnSuaTk.Text = "Cập Nhật";
            btnSuaTk.UseVisualStyleBackColor = false;
            // 
            // btnThemTk
            // 
            btnThemTk.BackColor = System.Drawing.Color.Lime;
            btnThemTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemTk.Location = new System.Drawing.Point(1088, 45);
            btnThemTk.Name = "btnThemTk";
            btnThemTk.Size = new System.Drawing.Size(134, 50);
            btnThemTk.TabIndex = 13;
            btnThemTk.Text = "Thêm Mới";
            btnThemTk.UseVisualStyleBackColor = false;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new System.Drawing.Point(721, 245);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new System.Drawing.Size(216, 31);
            txtMatKhauCu.TabIndex = 12;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Location = new System.Drawing.Point(589, 251);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new System.Drawing.Size(127, 25);
            lblMatKhauCu.TabIndex = 11;
            lblMatKhauCu.Text = "Mật Khẩu Cũ :";
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Location = new System.Drawing.Point(589, 151);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new System.Drawing.Size(134, 25);
            lblTenTK.TabIndex = 9;
            lblTenTK.Text = "Tên Tài Khoản :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(721, 92);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(216, 31);
            txtDiaChi.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(589, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 25);
            label1.TabIndex = 8;
            label1.Text = "Địa chỉ :";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtNgaySinh.Location = new System.Drawing.Point(721, 45);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new System.Drawing.Size(216, 31);
            dtNgaySinh.TabIndex = 5;
            // 
            // lblNgaysinh
            // 
            lblNgaysinh.AutoSize = true;
            lblNgaysinh.Location = new System.Drawing.Point(589, 51);
            lblNgaysinh.Name = "lblNgaysinh";
            lblNgaysinh.Size = new System.Drawing.Size(105, 25);
            lblNgaysinh.TabIndex = 7;
            lblNgaysinh.Text = "Ngày Sinh :";
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(151, 145);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(216, 31);
            txtSDT.TabIndex = 4;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new System.Drawing.Point(12, 151);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new System.Drawing.Size(131, 25);
            lblSdt.TabIndex = 5;
            lblSdt.Text = "Số điện thoại :";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new System.Drawing.Point(274, 98);
            rdNu.Name = "rdNu";
            rdNu.Size = new System.Drawing.Size(62, 29);
            rdNu.TabIndex = 3;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new System.Drawing.Point(151, 98);
            rdNam.Name = "rdNam";
            rdNam.Size = new System.Drawing.Size(76, 29);
            rdNam.TabIndex = 2;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // lblGioitinh
            // 
            lblGioitinh.AutoSize = true;
            lblGioitinh.Location = new System.Drawing.Point(12, 98);
            lblGioitinh.Name = "lblGioitinh";
            lblGioitinh.Size = new System.Drawing.Size(93, 25);
            lblGioitinh.TabIndex = 2;
            lblGioitinh.Text = "Giới tính :";
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Location = new System.Drawing.Point(12, 50);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new System.Drawing.Size(142, 25);
            lblTenTaiKhoan.TabIndex = 0;
            lblTenTaiKhoan.Text = "Tên Nhân Viên :";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, UserId, UserName, TeacherId, TeacherName });
            dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTaiKhoan.Location = new System.Drawing.Point(0, 495);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 62;
            dgvTaiKhoan.RowTemplate.Height = 33;
            dgvTaiKhoan.Size = new System.Drawing.Size(1234, 324);
            dgvTaiKhoan.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "UserId";
            UserId.MinimumWidth = 8;
            UserId.Name = "UserId";
            UserId.Width = 150;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "Tên Tài Khoản";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 150;
            // 
            // TeacherId
            // 
            TeacherId.DataPropertyName = "TeacherId";
            TeacherId.HeaderText = "Mã Giáo VIên";
            TeacherId.MinimumWidth = 8;
            TeacherId.Name = "TeacherId";
            TeacherId.Width = 150;
            // 
            // TeacherName
            // 
            TeacherName.DataPropertyName = "TeacherName";
            TeacherName.HeaderText = "Tên Giáo Viên";
            TeacherName.MinimumWidth = 8;
            TeacherName.Name = "TeacherName";
            TeacherName.Width = 150;
            // 
            // frmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1234, 819);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(gbTaiKhoan);
            Name = "frmQuanLyTaiKhoan";
            Text = "QuanLyTaiKhoan";
            Load += frmQuanLyTaiKhoan_Load;
            gbTaiKhoan.ResumeLayout(false);
            gbTaiKhoan.PerformLayout();
            gbTiemKim.ResumeLayout(false);
            gbTiemKim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaiKhoan;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemTk;
        private System.Windows.Forms.Button btnXoaTk;
        private System.Windows.Forms.Button btnSuaTk;
        private System.Windows.Forms.GroupBox gbTiemKim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemTk;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.CheckBox CkbMatKhau;
        private System.Windows.Forms.Button btnThuHoiTK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ComboBox cbTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
    }
}