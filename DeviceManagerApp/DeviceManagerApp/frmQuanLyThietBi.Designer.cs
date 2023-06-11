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
            this.lblQLTbi = new System.Windows.Forms.Label();
            this.gbThongtinTB = new System.Windows.Forms.GroupBox();
            this.QR_Code = new System.Windows.Forms.PictureBox();
            this.gbTimKiemTbi = new System.Windows.Forms.GroupBox();
            this.btnTimKiemTbi = new System.Windows.Forms.Button();
            this.txtTiemKiemTbi = new System.Windows.Forms.TextBox();
            this.btnXoaTbi = new System.Windows.Forms.Button();
            this.btnSuaTbi = new System.Windows.Forms.Button();
            this.btnThemTbi = new System.Windows.Forms.Button();
            this.rtbGhiChuTbi = new System.Windows.Forms.RichTextBox();
            this.lblGhiChuTbi = new System.Windows.Forms.Label();
            this.dtBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cbLoaiTbi = new System.Windows.Forms.ComboBox();
            this.txtTenTbi = new System.Windows.Forms.TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblLoaiTbi = new System.Windows.Forms.Label();
            this.lblTenTBi = new System.Windows.Forms.Label();
            this.lblMaTB = new System.Windows.Forms.Label();
            this.dtgvQlThietBi = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrantyPeriob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbThongtinTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR_Code)).BeginInit();
            this.gbTimKiemTbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQlThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLTbi
            // 
            this.lblQLTbi.AutoSize = true;
            this.lblQLTbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLTbi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLTbi.Location = new System.Drawing.Point(0, 0);
            this.lblQLTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQLTbi.Name = "lblQLTbi";
            this.lblQLTbi.Size = new System.Drawing.Size(306, 50);
            this.lblQLTbi.TabIndex = 0;
            this.lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            this.gbThongtinTB.Controls.Add(this.QR_Code);
            this.gbThongtinTB.Controls.Add(this.gbTimKiemTbi);
            this.gbThongtinTB.Controls.Add(this.btnXoaTbi);
            this.gbThongtinTB.Controls.Add(this.btnSuaTbi);
            this.gbThongtinTB.Controls.Add(this.btnThemTbi);
            this.gbThongtinTB.Controls.Add(this.rtbGhiChuTbi);
            this.gbThongtinTB.Controls.Add(this.lblGhiChuTbi);
            this.gbThongtinTB.Controls.Add(this.dtBaoHanh);
            this.gbThongtinTB.Controls.Add(this.label1);
            this.gbThongtinTB.Controls.Add(this.cbKhoa);
            this.gbThongtinTB.Controls.Add(this.lblKhoa);
            this.gbThongtinTB.Controls.Add(this.cbPhong);
            this.gbThongtinTB.Controls.Add(this.lblPhong);
            this.gbThongtinTB.Controls.Add(this.cbNhaCungCap);
            this.gbThongtinTB.Controls.Add(this.cbLoaiTbi);
            this.gbThongtinTB.Controls.Add(this.txtTenTbi);
            this.gbThongtinTB.Controls.Add(this.lblNhaCungCap);
            this.gbThongtinTB.Controls.Add(this.lblLoaiTbi);
            this.gbThongtinTB.Controls.Add(this.lblTenTBi);
            this.gbThongtinTB.Controls.Add(this.lblMaTB);
            this.gbThongtinTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongtinTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongtinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbThongtinTB.Location = new System.Drawing.Point(0, 50);
            this.gbThongtinTB.Margin = new System.Windows.Forms.Padding(2);
            this.gbThongtinTB.Name = "gbThongtinTB";
            this.gbThongtinTB.Padding = new System.Windows.Forms.Padding(2);
            this.gbThongtinTB.Size = new System.Drawing.Size(1257, 388);
            this.gbThongtinTB.TabIndex = 1;
            this.gbThongtinTB.TabStop = false;
            this.gbThongtinTB.Text = "Thông tin thiết bị";
            // 
            // QR_Code
            // 
            this.QR_Code.Location = new System.Drawing.Point(1000, 76);
            this.QR_Code.Name = "QR_Code";
            this.QR_Code.Size = new System.Drawing.Size(202, 184);
            this.QR_Code.TabIndex = 13;
            this.QR_Code.TabStop = false;
            // 
            // gbTimKiemTbi
            // 
            this.gbTimKiemTbi.Controls.Add(this.btnTimKiemTbi);
            this.gbTimKiemTbi.Controls.Add(this.txtTiemKiemTbi);
            this.gbTimKiemTbi.Location = new System.Drawing.Point(5, 261);
            this.gbTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.gbTimKiemTbi.Name = "gbTimKiemTbi";
            this.gbTimKiemTbi.Padding = new System.Windows.Forms.Padding(2);
            this.gbTimKiemTbi.Size = new System.Drawing.Size(964, 115);
            this.gbTimKiemTbi.TabIndex = 12;
            this.gbTimKiemTbi.TabStop = false;
            this.gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // btnTimKiemTbi
            // 
            this.btnTimKiemTbi.BackColor = System.Drawing.Color.Lime;
            this.btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemTbi.Location = new System.Drawing.Point(801, 34);
            this.btnTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemTbi.Name = "btnTimKiemTbi";
            this.btnTimKiemTbi.Size = new System.Drawing.Size(107, 40);
            this.btnTimKiemTbi.TabIndex = 13;
            this.btnTimKiemTbi.Text = "Tìm Kiếm";
            this.btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            this.txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemTbi.Location = new System.Drawing.Point(139, 50);
            this.txtTiemKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            this.txtTiemKiemTbi.Size = new System.Drawing.Size(174, 27);
            this.txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            this.btnXoaTbi.BackColor = System.Drawing.Color.Lime;
            this.btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaTbi.Location = new System.Drawing.Point(806, 182);
            this.btnXoaTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTbi.Name = "btnXoaTbi";
            this.btnXoaTbi.Size = new System.Drawing.Size(107, 40);
            this.btnXoaTbi.TabIndex = 11;
            this.btnXoaTbi.Text = "Xóa";
            this.btnXoaTbi.UseVisualStyleBackColor = false;
            // 
            // btnSuaTbi
            // 
            this.btnSuaTbi.BackColor = System.Drawing.Color.Lime;
            this.btnSuaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaTbi.Location = new System.Drawing.Point(806, 103);
            this.btnSuaTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTbi.Name = "btnSuaTbi";
            this.btnSuaTbi.Size = new System.Drawing.Size(107, 40);
            this.btnSuaTbi.TabIndex = 10;
            this.btnSuaTbi.Text = "Cập Nhật";
            this.btnSuaTbi.UseVisualStyleBackColor = false;
            // 
            // btnThemTbi
            // 
            this.btnThemTbi.BackColor = System.Drawing.Color.Lime;
            this.btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemTbi.Location = new System.Drawing.Point(806, 26);
            this.btnThemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTbi.Name = "btnThemTbi";
            this.btnThemTbi.Size = new System.Drawing.Size(107, 40);
            this.btnThemTbi.TabIndex = 9;
            this.btnThemTbi.Text = "Thêm Mới";
            this.btnThemTbi.UseVisualStyleBackColor = false;
            // 
            // rtbGhiChuTbi
            // 
            this.rtbGhiChuTbi.Location = new System.Drawing.Point(517, 151);
            this.rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(2);
            this.rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            this.rtbGhiChuTbi.Size = new System.Drawing.Size(174, 74);
            this.rtbGhiChuTbi.TabIndex = 8;
            this.rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            this.lblGhiChuTbi.AutoSize = true;
            this.lblGhiChuTbi.Location = new System.Drawing.Point(396, 151);
            this.lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChuTbi.Name = "lblGhiChuTbi";
            this.lblGhiChuTbi.Size = new System.Drawing.Size(72, 20);
            this.lblGhiChuTbi.TabIndex = 8;
            this.lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            this.dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaoHanh.Location = new System.Drawing.Point(517, 86);
            this.dtBaoHanh.Margin = new System.Windows.Forms.Padding(2);
            this.dtBaoHanh.Name = "dtBaoHanh";
            this.dtBaoHanh.Size = new System.Drawing.Size(174, 27);
            this.dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(517, 26);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(174, 28);
            this.cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(396, 33);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(53, 20);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa :";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(144, 199);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(174, 28);
            this.cbPhong.TabIndex = 5;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(28, 202);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(62, 20);
            this.lblPhong.TabIndex = 5;
            this.lblPhong.Text = "Phòng :";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(142, 145);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(174, 28);
            this.cbNhaCungCap.TabIndex = 4;
            // 
            // cbLoaiTbi
            // 
            this.cbLoaiTbi.FormattingEnabled = true;
            this.cbLoaiTbi.Location = new System.Drawing.Point(144, 85);
            this.cbLoaiTbi.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiTbi.Name = "cbLoaiTbi";
            this.cbLoaiTbi.Size = new System.Drawing.Size(174, 28);
            this.cbLoaiTbi.TabIndex = 3;
            // 
            // txtTenTbi
            // 
            this.txtTenTbi.Location = new System.Drawing.Point(142, 30);
            this.txtTenTbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTbi.Name = "txtTenTbi";
            this.txtTenTbi.Size = new System.Drawing.Size(174, 27);
            this.txtTenTbi.TabIndex = 2;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Location = new System.Drawing.Point(26, 148);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(106, 20);
            this.lblNhaCungCap.TabIndex = 3;
            this.lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            this.lblLoaiTbi.AutoSize = true;
            this.lblLoaiTbi.Location = new System.Drawing.Point(26, 88);
            this.lblLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiTbi.Name = "lblLoaiTbi";
            this.lblLoaiTbi.Size = new System.Drawing.Size(100, 20);
            this.lblLoaiTbi.TabIndex = 2;
            this.lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            this.lblTenTBi.AutoSize = true;
            this.lblTenTBi.Location = new System.Drawing.Point(26, 35);
            this.lblTenTBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTBi.Name = "lblTenTBi";
            this.lblTenTBi.Size = new System.Drawing.Size(96, 20);
            this.lblTenTBi.TabIndex = 1;
            this.lblTenTBi.Text = "Tên thiết bị :";
            // 
            // lblMaTB
            // 
            this.lblMaTB.AutoSize = true;
            this.lblMaTB.Location = new System.Drawing.Point(1000, 26);
            this.lblMaTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTB.Name = "lblMaTB";
            this.lblMaTB.Size = new System.Drawing.Size(93, 20);
            this.lblMaTB.TabIndex = 0;
            this.lblMaTB.Text = "Mã thiết bị :";
            // 
            // dtgvQlThietBi
            // 
            this.dtgvQlThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQlThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQlThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.DeviceName,
            this.Note,
            this.CreatedDate,
            this.WarrantyPeriob,
            this.SpecsId,
            this.DeviceDetail});
            this.dtgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvQlThietBi.Location = new System.Drawing.Point(0, 438);
            this.dtgvQlThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQlThietBi.Name = "dtgvQlThietBi";
            this.dtgvQlThietBi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvQlThietBi.RowTemplate.Height = 33;
            this.dtgvQlThietBi.Size = new System.Drawing.Size(1257, 236);
            this.dtgvQlThietBi.TabIndex = 2;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.FillWeight = 79.3672F;
            this.Image.HeaderText = "Thiết bị";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "Name";
            this.DeviceName.FillWeight = 79.3672F;
            this.DeviceName.HeaderText = "Tên thiết bị";
            this.DeviceName.MinimumWidth = 6;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 79.3672F;
            this.Note.HeaderText = "Mô tả";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.FillWeight = 79.3672F;
            this.CreatedDate.HeaderText = "Ngày mua";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // WarrantyPeriob
            // 
            this.WarrantyPeriob.DataPropertyName = "WarrantyPeriod";
            this.WarrantyPeriob.FillWeight = 79.3672F;
            this.WarrantyPeriob.HeaderText = "Hạn bảo hành";
            this.WarrantyPeriob.MinimumWidth = 6;
            this.WarrantyPeriob.Name = "WarrantyPeriob";
            this.WarrantyPeriob.ReadOnly = true;
            // 
            // SpecsId
            // 
            this.SpecsId.HeaderText = "Thông số";
            this.SpecsId.MinimumWidth = 6;
            this.SpecsId.Name = "SpecsId";
            this.SpecsId.Visible = false;
            // 
            // DeviceDetail
            // 
            this.DeviceDetail.FillWeight = 79.3672F;
            this.DeviceDetail.HeaderText = "Thông số chi tiết";
            this.DeviceDetail.MinimumWidth = 6;
            this.DeviceDetail.Name = "DeviceDetail";
            // 
            // frmQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 739);
            this.Controls.Add(this.dtgvQlThietBi);
            this.Controls.Add(this.gbThongtinTB);
            this.Controls.Add(this.lblQLTbi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyThietBi";
            this.Text = "QuanLyThietBi";
            this.gbThongtinTB.ResumeLayout(false);
            this.gbThongtinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR_Code)).EndInit();
            this.gbTimKiemTbi.ResumeLayout(false);
            this.gbTimKiemTbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQlThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLTbi;
        private System.Windows.Forms.GroupBox gbThongtinTB;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiTbi;
        private System.Windows.Forms.TextBox txtTenTbi;
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
        private System.Windows.Forms.DataGridView dtgvQlThietBi;
        private System.Windows.Forms.PictureBox QR_Code;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyPeriob;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecsId;
        private System.Windows.Forms.DataGridViewButtonColumn DeviceDetail;
    }
}