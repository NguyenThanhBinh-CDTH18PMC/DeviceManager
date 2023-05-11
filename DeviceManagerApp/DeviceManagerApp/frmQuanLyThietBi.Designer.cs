namespace DeviceManagerApp
{
    partial class frmQuanLyThietBi
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
            lblQLTbi = new System.Windows.Forms.Label();
            gbThongtinTB = new System.Windows.Forms.GroupBox();
            gbTimKiemTbi = new System.Windows.Forms.GroupBox();
            btnTimKiemTbi = new System.Windows.Forms.Button();
            txtTiemKiemTbi = new System.Windows.Forms.TextBox();
            btnXoaTbi = new System.Windows.Forms.Button();
            btnSuaTbi = new System.Windows.Forms.Button();
            btnThemTbi = new System.Windows.Forms.Button();
            rtbGhiChuTbi = new System.Windows.Forms.RichTextBox();
            lblGhiChuTbi = new System.Windows.Forms.Label();
            dtBaoHanh = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            cbKhoa = new System.Windows.Forms.ComboBox();
            lblKhoa = new System.Windows.Forms.Label();
            cbPhong = new System.Windows.Forms.ComboBox();
            lblPhong = new System.Windows.Forms.Label();
            cbNhaCungCap = new System.Windows.Forms.ComboBox();
            cbLoaiTbi = new System.Windows.Forms.ComboBox();
            txtTenTbi = new System.Windows.Forms.TextBox();
            txtMaTbi = new System.Windows.Forms.TextBox();
            lblNhaCungCap = new System.Windows.Forms.Label();
            lblLoaiTbi = new System.Windows.Forms.Label();
            lblTenTBi = new System.Windows.Forms.Label();
            lblMaTB = new System.Windows.Forms.Label();
            dgvQlThietBi = new System.Windows.Forms.DataGridView();
            gbThongtinTB.SuspendLayout();
            gbTimKiemTbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQlThietBi).BeginInit();
            SuspendLayout();
            // 
            // lblQLTbi
            // 
            lblQLTbi.AutoSize = true;
            lblQLTbi.Dock = System.Windows.Forms.DockStyle.Top;
            lblQLTbi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQLTbi.Location = new System.Drawing.Point(0, 0);
            lblQLTbi.Name = "lblQLTbi";
            lblQLTbi.Size = new System.Drawing.Size(365, 60);
            lblQLTbi.TabIndex = 0;
            lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            gbThongtinTB.Controls.Add(gbTimKiemTbi);
            gbThongtinTB.Controls.Add(btnXoaTbi);
            gbThongtinTB.Controls.Add(btnSuaTbi);
            gbThongtinTB.Controls.Add(btnThemTbi);
            gbThongtinTB.Controls.Add(rtbGhiChuTbi);
            gbThongtinTB.Controls.Add(lblGhiChuTbi);
            gbThongtinTB.Controls.Add(dtBaoHanh);
            gbThongtinTB.Controls.Add(label1);
            gbThongtinTB.Controls.Add(cbKhoa);
            gbThongtinTB.Controls.Add(lblKhoa);
            gbThongtinTB.Controls.Add(cbPhong);
            gbThongtinTB.Controls.Add(lblPhong);
            gbThongtinTB.Controls.Add(cbNhaCungCap);
            gbThongtinTB.Controls.Add(cbLoaiTbi);
            gbThongtinTB.Controls.Add(txtTenTbi);
            gbThongtinTB.Controls.Add(txtMaTbi);
            gbThongtinTB.Controls.Add(lblNhaCungCap);
            gbThongtinTB.Controls.Add(lblLoaiTbi);
            gbThongtinTB.Controls.Add(lblTenTBi);
            gbThongtinTB.Controls.Add(lblMaTB);
            gbThongtinTB.Dock = System.Windows.Forms.DockStyle.Top;
            gbThongtinTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbThongtinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbThongtinTB.Location = new System.Drawing.Point(0, 60);
            gbThongtinTB.Name = "gbThongtinTB";
            gbThongtinTB.Size = new System.Drawing.Size(1211, 485);
            gbThongtinTB.TabIndex = 1;
            gbThongtinTB.TabStop = false;
            gbThongtinTB.Text = "Thông tin thiết bị";
            // 
            // gbTimKiemTbi
            // 
            gbTimKiemTbi.Controls.Add(btnTimKiemTbi);
            gbTimKiemTbi.Controls.Add(txtTiemKiemTbi);
            gbTimKiemTbi.Location = new System.Drawing.Point(6, 326);
            gbTimKiemTbi.Name = "gbTimKiemTbi";
            gbTimKiemTbi.Size = new System.Drawing.Size(1205, 144);
            gbTimKiemTbi.TabIndex = 12;
            gbTimKiemTbi.TabStop = false;
            gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // btnTimKiemTbi
            // 
            btnTimKiemTbi.BackColor = System.Drawing.Color.Lime;
            btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemTbi.Location = new System.Drawing.Point(1001, 43);
            btnTimKiemTbi.Name = "btnTimKiemTbi";
            btnTimKiemTbi.Size = new System.Drawing.Size(134, 50);
            btnTimKiemTbi.TabIndex = 13;
            btnTimKiemTbi.Text = "Tìm Kiếm";
            btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemTbi.Location = new System.Drawing.Point(174, 62);
            txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            txtTiemKiemTbi.Size = new System.Drawing.Size(217, 31);
            txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            btnXoaTbi.BackColor = System.Drawing.Color.Lime;
            btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaTbi.Location = new System.Drawing.Point(1007, 198);
            btnXoaTbi.Name = "btnXoaTbi";
            btnXoaTbi.Size = new System.Drawing.Size(134, 50);
            btnXoaTbi.TabIndex = 11;
            btnXoaTbi.Text = "Xóa";
            btnXoaTbi.UseVisualStyleBackColor = false;
            // 
            // btnSuaTbi
            // 
            btnSuaTbi.BackColor = System.Drawing.Color.Lime;
            btnSuaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaTbi.Location = new System.Drawing.Point(1007, 117);
            btnSuaTbi.Name = "btnSuaTbi";
            btnSuaTbi.Size = new System.Drawing.Size(134, 50);
            btnSuaTbi.TabIndex = 10;
            btnSuaTbi.Text = "Cập Nhật";
            btnSuaTbi.UseVisualStyleBackColor = false;
            // 
            // btnThemTbi
            // 
            btnThemTbi.BackColor = System.Drawing.Color.Lime;
            btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemTbi.Location = new System.Drawing.Point(1007, 33);
            btnThemTbi.Name = "btnThemTbi";
            btnThemTbi.Size = new System.Drawing.Size(134, 50);
            btnThemTbi.TabIndex = 9;
            btnThemTbi.Text = "Thêm Mới";
            btnThemTbi.UseVisualStyleBackColor = false;
            // 
            // rtbGhiChuTbi
            // 
            rtbGhiChuTbi.Location = new System.Drawing.Point(646, 156);
            rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            rtbGhiChuTbi.Size = new System.Drawing.Size(217, 92);
            rtbGhiChuTbi.TabIndex = 8;
            rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            lblGhiChuTbi.AutoSize = true;
            lblGhiChuTbi.Location = new System.Drawing.Point(495, 156);
            lblGhiChuTbi.Name = "lblGhiChuTbi";
            lblGhiChuTbi.Size = new System.Drawing.Size(89, 25);
            lblGhiChuTbi.TabIndex = 8;
            lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBaoHanh.Location = new System.Drawing.Point(646, 95);
            dtBaoHanh.Name = "dtBaoHanh";
            dtBaoHanh.Size = new System.Drawing.Size(217, 31);
            dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(495, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 25);
            label1.TabIndex = 7;
            label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new System.Drawing.Point(646, 33);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new System.Drawing.Size(217, 33);
            cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new System.Drawing.Point(495, 41);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new System.Drawing.Size(66, 25);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa :";
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new System.Drawing.Point(177, 273);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new System.Drawing.Size(217, 33);
            cbPhong.TabIndex = 5;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new System.Drawing.Point(32, 281);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new System.Drawing.Size(77, 25);
            lblPhong.TabIndex = 5;
            lblPhong.Text = "Phòng :";
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new System.Drawing.Point(177, 215);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new System.Drawing.Size(217, 33);
            cbNhaCungCap.TabIndex = 4;
            // 
            // cbLoaiTbi
            // 
            cbLoaiTbi.FormattingEnabled = true;
            cbLoaiTbi.Location = new System.Drawing.Point(177, 148);
            cbLoaiTbi.Name = "cbLoaiTbi";
            cbLoaiTbi.Size = new System.Drawing.Size(217, 33);
            cbLoaiTbi.TabIndex = 3;
            // 
            // txtTenTbi
            // 
            txtTenTbi.Location = new System.Drawing.Point(177, 94);
            txtTenTbi.Name = "txtTenTbi";
            txtTenTbi.Size = new System.Drawing.Size(217, 31);
            txtTenTbi.TabIndex = 2;
            // 
            // txtMaTbi
            // 
            txtMaTbi.Location = new System.Drawing.Point(177, 35);
            txtMaTbi.Name = "txtMaTbi";
            txtMaTbi.Size = new System.Drawing.Size(217, 31);
            txtMaTbi.TabIndex = 1;
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Location = new System.Drawing.Point(32, 223);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new System.Drawing.Size(139, 25);
            lblNhaCungCap.TabIndex = 3;
            lblNhaCungCap.Text = "Nhà cung cấp :";
            // 
            // lblLoaiTbi
            // 
            lblLoaiTbi.AutoSize = true;
            lblLoaiTbi.Location = new System.Drawing.Point(32, 156);
            lblLoaiTbi.Name = "lblLoaiTbi";
            lblLoaiTbi.Size = new System.Drawing.Size(123, 25);
            lblLoaiTbi.TabIndex = 2;
            lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            lblTenTBi.AutoSize = true;
            lblTenTBi.Location = new System.Drawing.Point(32, 100);
            lblTenTBi.Name = "lblTenTBi";
            lblTenTBi.Size = new System.Drawing.Size(118, 25);
            lblTenTBi.TabIndex = 1;
            lblTenTBi.Text = "Tên thiết bị :";
            // 
            // lblMaTB
            // 
            lblMaTB.AutoSize = true;
            lblMaTB.Location = new System.Drawing.Point(32, 41);
            lblMaTB.Name = "lblMaTB";
            lblMaTB.Size = new System.Drawing.Size(115, 25);
            lblMaTB.TabIndex = 0;
            lblMaTB.Text = "Mã thiết bị :";
            // 
            // dgvQlThietBi
            // 
            dgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            dgvQlThietBi.Location = new System.Drawing.Point(0, 545);
            dgvQlThietBi.Name = "dgvQlThietBi";
            dgvQlThietBi.RowHeadersWidth = 62;
            dgvQlThietBi.RowTemplate.Height = 33;
            dgvQlThietBi.Size = new System.Drawing.Size(1211, 295);
            dgvQlThietBi.TabIndex = 2;
            // 
            // QuanLyThietBi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1211, 924);
            Controls.Add(dgvQlThietBi);
            Controls.Add(gbThongtinTB);
            Controls.Add(lblQLTbi);
            Name = "QuanLyThietBi";
            Text = "QuanLyThietBi";
            gbThongtinTB.ResumeLayout(false);
            gbThongtinTB.PerformLayout();
            gbTimKiemTbi.ResumeLayout(false);
            gbTimKiemTbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQlThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQLTbi;
        private System.Windows.Forms.GroupBox gbThongtinTB;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiTbi;
        private System.Windows.Forms.TextBox txtTenTbi;
        private System.Windows.Forms.TextBox txtMaTbi;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblLoaiTbi;
        private System.Windows.Forms.Label lblTenTBi;
        private System.Windows.Forms.Label lblMaTB;
        private System.Windows.Forms.RichTextBox rtbGhiChuTbi;
        private System.Windows.Forms.Label lblGhiChuTbi;
        private System.Windows.Forms.DateTimePicker dtBaoHanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Button btnXoaTbi;
        private System.Windows.Forms.Button btnSuaTbi;
        private System.Windows.Forms.Button btnThemTbi;
        private System.Windows.Forms.GroupBox gbTimKiemTbi;
        private System.Windows.Forms.Button btnTimKiemTbi;
        private System.Windows.Forms.TextBox txtTiemKiemTbi;
        private System.Windows.Forms.DataGridView dgvQlThietBi;
    }
}