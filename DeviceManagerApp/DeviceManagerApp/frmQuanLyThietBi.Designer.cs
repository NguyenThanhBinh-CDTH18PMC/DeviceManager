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
            components = new System.ComponentModel.Container();
            lblQLTbi = new System.Windows.Forms.Label();
            gbThongtinTB = new System.Windows.Forms.GroupBox();
            txtPrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnDetail = new System.Windows.Forms.Button();
            ptb_Device = new System.Windows.Forms.PictureBox();
            gbTimKiemTbi = new System.Windows.Forms.GroupBox();
            dtp_DateBuy = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
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
            lblNhaCungCap = new System.Windows.Forms.Label();
            lblLoaiTbi = new System.Windows.Forms.Label();
            lblTenTBi = new System.Windows.Forms.Label();
            lb_Image = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            DeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            SpecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WarrantyPeriob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceImage = new System.Windows.Forms.DataGridViewImageColumn();
            dtgvQlThietBi = new System.Windows.Forms.DataGridView();
            gbThongtinTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Device).BeginInit();
            gbTimKiemTbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvQlThietBi).BeginInit();
            SuspendLayout();
            // 
            // lblQLTbi
            // 
            lblQLTbi.AutoSize = true;
            lblQLTbi.Dock = System.Windows.Forms.DockStyle.Top;
            lblQLTbi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQLTbi.Location = new System.Drawing.Point(0, 0);
            lblQLTbi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblQLTbi.Name = "lblQLTbi";
            lblQLTbi.Size = new System.Drawing.Size(248, 41);
            lblQLTbi.TabIndex = 0;
            lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            gbThongtinTB.Controls.Add(txtPrice);
            gbThongtinTB.Controls.Add(label3);
            gbThongtinTB.Controls.Add(btnDetail);
            gbThongtinTB.Controls.Add(ptb_Device);
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
            gbThongtinTB.Controls.Add(lblNhaCungCap);
            gbThongtinTB.Controls.Add(lblLoaiTbi);
            gbThongtinTB.Controls.Add(lblTenTBi);
            gbThongtinTB.Controls.Add(lb_Image);
            gbThongtinTB.Dock = System.Windows.Forms.DockStyle.Top;
            gbThongtinTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbThongtinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbThongtinTB.Location = new System.Drawing.Point(0, 41);
            gbThongtinTB.Margin = new System.Windows.Forms.Padding(1);
            gbThongtinTB.Name = "gbThongtinTB";
            gbThongtinTB.Padding = new System.Windows.Forms.Padding(1);
            gbThongtinTB.Size = new System.Drawing.Size(899, 288);
            gbThongtinTB.TabIndex = 1;
            gbThongtinTB.TabStop = false;
            gbThongtinTB.Text = "Thông tin thiết bị";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(452, 109);
            txtPrice.Margin = new System.Windows.Forms.Padding(1);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(152, 23);
            txtPrice.TabIndex = 16;
            txtPrice.KeyPress += txt_Price_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(346, 112);
            label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 15;
            label3.Text = "Giá :";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = System.Drawing.Color.Lime;
            btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDetail.Location = new System.Drawing.Point(942, 243);
            btnDetail.Margin = new System.Windows.Forms.Padding(1);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(148, 30);
            btnDetail.TabIndex = 14;
            btnDetail.Text = "Thông số kỹ thuật";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // ptb_Device
            // 
            ptb_Device.Location = new System.Drawing.Point(875, 57);
            ptb_Device.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ptb_Device.Name = "ptb_Device";
            ptb_Device.Size = new System.Drawing.Size(175, 150);
            ptb_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptb_Device.TabIndex = 13;
            ptb_Device.TabStop = false;
            toolTip1.SetToolTip(ptb_Device, "Nhấn đúp để tải ảnh");
            // 
            // gbTimKiemTbi
            // 
            gbTimKiemTbi.Controls.Add(dtp_DateBuy);
            gbTimKiemTbi.Controls.Add(label2);
            gbTimKiemTbi.Controls.Add(btnTimKiemTbi);
            gbTimKiemTbi.Controls.Add(txtTiemKiemTbi);
            gbTimKiemTbi.Location = new System.Drawing.Point(4, 217);
            gbTimKiemTbi.Margin = new System.Windows.Forms.Padding(1);
            gbTimKiemTbi.Name = "gbTimKiemTbi";
            gbTimKiemTbi.Padding = new System.Windows.Forms.Padding(1);
            gbTimKiemTbi.Size = new System.Drawing.Size(844, 65);
            gbTimKiemTbi.TabIndex = 12;
            gbTimKiemTbi.TabStop = false;
            gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // dtp_DateBuy
            // 
            dtp_DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_DateBuy.Location = new System.Drawing.Point(448, 31);
            dtp_DateBuy.Margin = new System.Windows.Forms.Padding(1);
            dtp_DateBuy.Name = "dtp_DateBuy";
            dtp_DateBuy.Size = new System.Drawing.Size(152, 23);
            dtp_DateBuy.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(342, 35);
            label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 15);
            label2.TabIndex = 16;
            label2.Text = "Ngày mua :";
            // 
            // btnTimKiemTbi
            // 
            btnTimKiemTbi.BackColor = System.Drawing.Color.Lime;
            btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemTbi.Location = new System.Drawing.Point(701, 25);
            btnTimKiemTbi.Margin = new System.Windows.Forms.Padding(1);
            btnTimKiemTbi.Name = "btnTimKiemTbi";
            btnTimKiemTbi.Size = new System.Drawing.Size(94, 30);
            btnTimKiemTbi.TabIndex = 13;
            btnTimKiemTbi.Text = "Tìm Kiếm";
            btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemTbi.Location = new System.Drawing.Point(120, 31);
            txtTiemKiemTbi.Margin = new System.Windows.Forms.Padding(1);
            txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            txtTiemKiemTbi.Size = new System.Drawing.Size(155, 23);
            txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            btnXoaTbi.BackColor = System.Drawing.Color.Lime;
            btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaTbi.Location = new System.Drawing.Point(706, 137);
            btnXoaTbi.Margin = new System.Windows.Forms.Padding(1);
            btnXoaTbi.Name = "btnXoaTbi";
            btnXoaTbi.Size = new System.Drawing.Size(94, 30);
            btnXoaTbi.TabIndex = 11;
            btnXoaTbi.Text = "Xóa";
            btnXoaTbi.UseVisualStyleBackColor = false;
            // 
            // btnSuaTbi
            // 
            btnSuaTbi.BackColor = System.Drawing.Color.Lime;
            btnSuaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaTbi.Location = new System.Drawing.Point(706, 77);
            btnSuaTbi.Margin = new System.Windows.Forms.Padding(1);
            btnSuaTbi.Name = "btnSuaTbi";
            btnSuaTbi.Size = new System.Drawing.Size(94, 30);
            btnSuaTbi.TabIndex = 10;
            btnSuaTbi.Text = "Cập Nhật";
            btnSuaTbi.UseVisualStyleBackColor = false;
            // 
            // btnThemTbi
            // 
            btnThemTbi.BackColor = System.Drawing.Color.Lime;
            btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemTbi.Location = new System.Drawing.Point(706, 19);
            btnThemTbi.Margin = new System.Windows.Forms.Padding(1);
            btnThemTbi.Name = "btnThemTbi";
            btnThemTbi.Size = new System.Drawing.Size(94, 30);
            btnThemTbi.TabIndex = 9;
            btnThemTbi.Text = "Thêm Mới";
            btnThemTbi.UseVisualStyleBackColor = false;
            btnThemTbi.Click += btnThemTbi_Click;
            // 
            // rtbGhiChuTbi
            // 
            rtbGhiChuTbi.Location = new System.Drawing.Point(452, 149);
            rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(1);
            rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            rtbGhiChuTbi.Size = new System.Drawing.Size(152, 57);
            rtbGhiChuTbi.TabIndex = 8;
            rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            lblGhiChuTbi.AutoSize = true;
            lblGhiChuTbi.Location = new System.Drawing.Point(346, 149);
            lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblGhiChuTbi.Name = "lblGhiChuTbi";
            lblGhiChuTbi.Size = new System.Drawing.Size(56, 15);
            lblGhiChuTbi.TabIndex = 8;
            lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBaoHanh.Location = new System.Drawing.Point(452, 65);
            dtBaoHanh.Margin = new System.Windows.Forms.Padding(1);
            dtBaoHanh.Name = "dtBaoHanh";
            dtBaoHanh.Size = new System.Drawing.Size(152, 23);
            dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(346, 67);
            label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 15);
            label1.TabIndex = 7;
            label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new System.Drawing.Point(452, 19);
            cbKhoa.Margin = new System.Windows.Forms.Padding(1);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new System.Drawing.Size(152, 23);
            cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new System.Drawing.Point(346, 25);
            lblKhoa.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new System.Drawing.Size(41, 15);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa :";
            // 
            // cbPhong
            // 
            cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new System.Drawing.Point(126, 149);
            cbPhong.Margin = new System.Windows.Forms.Padding(1);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new System.Drawing.Size(152, 23);
            cbPhong.TabIndex = 5;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new System.Drawing.Point(24, 151);
            lblPhong.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new System.Drawing.Size(48, 15);
            lblPhong.TabIndex = 5;
            lblPhong.Text = "Phòng :";
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new System.Drawing.Point(125, 109);
            cbNhaCungCap.Margin = new System.Windows.Forms.Padding(1);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new System.Drawing.Size(152, 23);
            cbNhaCungCap.TabIndex = 4;
            // 
            // cbLoaiTbi
            // 
            cbLoaiTbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbLoaiTbi.FormattingEnabled = true;
            cbLoaiTbi.Location = new System.Drawing.Point(126, 64);
            cbLoaiTbi.Margin = new System.Windows.Forms.Padding(1);
            cbLoaiTbi.Name = "cbLoaiTbi";
            cbLoaiTbi.Size = new System.Drawing.Size(152, 23);
            cbLoaiTbi.TabIndex = 3;
            // 
            // txtTenTbi
            // 
            txtTenTbi.Location = new System.Drawing.Point(125, 23);
            txtTenTbi.Margin = new System.Windows.Forms.Padding(1);
            txtTenTbi.Name = "txtTenTbi";
            txtTenTbi.Size = new System.Drawing.Size(152, 23);
            txtTenTbi.TabIndex = 2;
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Location = new System.Drawing.Point(22, 111);
            lblNhaCungCap.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new System.Drawing.Size(84, 15);
            lblNhaCungCap.TabIndex = 3;
            lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            lblLoaiTbi.AutoSize = true;
            lblLoaiTbi.Location = new System.Drawing.Point(22, 66);
            lblLoaiTbi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblLoaiTbi.Name = "lblLoaiTbi";
            lblLoaiTbi.Size = new System.Drawing.Size(78, 15);
            lblLoaiTbi.TabIndex = 2;
            lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            lblTenTBi.AutoSize = true;
            lblTenTBi.Location = new System.Drawing.Point(22, 26);
            lblTenTBi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblTenTBi.Name = "lblTenTBi";
            lblTenTBi.Size = new System.Drawing.Size(76, 15);
            lblTenTBi.TabIndex = 1;
            lblTenTBi.Text = "Tên thiết bị :";
            // 
            // lb_Image
            // 
            lb_Image.AutoSize = true;
            lb_Image.Location = new System.Drawing.Point(875, 19);
            lb_Image.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lb_Image.Name = "lb_Image";
            lb_Image.Size = new System.Drawing.Size(75, 15);
            lb_Image.TabIndex = 0;
            lb_Image.Text = "Ảnh thiết bị:";
            // 
            // DeviceId
            // 
            DeviceId.DataPropertyName = "Id";
            DeviceId.HeaderText = "Id";
            DeviceId.MinimumWidth = 6;
            DeviceId.Name = "DeviceId";
            DeviceId.ReadOnly = true;
            DeviceId.Visible = false;
            // 
            // Brand
            // 
            Brand.HeaderText = "Thương hiệu";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // DeviceDetail
            // 
            DeviceDetail.FillWeight = 79.3672F;
            DeviceDetail.HeaderText = "Thông số chi tiết";
            DeviceDetail.MinimumWidth = 6;
            DeviceDetail.Name = "DeviceDetail";
            // 
            // SpecsId
            // 
            SpecsId.HeaderText = "Thông số";
            SpecsId.MinimumWidth = 6;
            SpecsId.Name = "SpecsId";
            SpecsId.Visible = false;
            // 
            // WarrantyPeriob
            // 
            WarrantyPeriob.DataPropertyName = "WarrantyPeriod";
            WarrantyPeriob.FillWeight = 79.3672F;
            WarrantyPeriob.HeaderText = "Hạn bảo hành";
            WarrantyPeriob.MinimumWidth = 6;
            WarrantyPeriob.Name = "WarrantyPeriob";
            WarrantyPeriob.ReadOnly = true;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.FillWeight = 79.3672F;
            CreatedDate.HeaderText = "Ngày mua";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            // 
            // Note
            // 
            Note.DataPropertyName = "Note";
            Note.FillWeight = 79.3672F;
            Note.HeaderText = "Mô tả";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
            // 
            // DeviceName
            // 
            DeviceName.DataPropertyName = "Name";
            DeviceName.FillWeight = 79.3672F;
            DeviceName.HeaderText = "Tên thiết bị";
            DeviceName.MinimumWidth = 6;
            DeviceName.Name = "DeviceName";
            DeviceName.ReadOnly = true;
            // 
            // DeviceImage
            // 
            DeviceImage.DataPropertyName = "Image";
            DeviceImage.FillWeight = 79.3672F;
            DeviceImage.HeaderText = "Thiết bị";
            DeviceImage.MinimumWidth = 6;
            DeviceImage.Name = "DeviceImage";
            DeviceImage.ReadOnly = true;
            DeviceImage.Visible = false;
            // 
            // dtgvQlThietBi
            // 
            dtgvQlThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtgvQlThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dtgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvQlThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DeviceImage, DeviceName, Note, CreatedDate, WarrantyPeriob, SpecsId, DeviceDetail, Brand, DeviceId });
            dtgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            dtgvQlThietBi.Location = new System.Drawing.Point(0, 329);
            dtgvQlThietBi.Margin = new System.Windows.Forms.Padding(1);
            dtgvQlThietBi.Name = "dtgvQlThietBi";
            dtgvQlThietBi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgvQlThietBi.RowTemplate.Height = 33;
            dtgvQlThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgvQlThietBi.Size = new System.Drawing.Size(899, 227);
            dtgvQlThietBi.TabIndex = 2;
            dtgvQlThietBi.CellClick += dtgvQlThietBi_CellClick;
            // 
            // frmQuanLyThietBi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(899, 421);
            Controls.Add(dtgvQlThietBi);
            Controls.Add(gbThongtinTB);
            Controls.Add(lblQLTbi);
            Margin = new System.Windows.Forms.Padding(1);
            Name = "frmQuanLyThietBi";
            Text = "QuanLyThietBi";
            gbThongtinTB.ResumeLayout(false);
            gbThongtinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Device).EndInit();
            gbTimKiemTbi.ResumeLayout(false);
            gbTimKiemTbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvQlThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label lb_Image;
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
        private System.Windows.Forms.PictureBox ptb_Device;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DateTimePicker dtp_DateBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewButtonColumn DeviceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyPeriob;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewImageColumn DeviceImage;
        private System.Windows.Forms.DataGridView dtgvQlThietBi;
    }
}