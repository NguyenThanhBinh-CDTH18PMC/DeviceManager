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
            txtPrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnDetail = new System.Windows.Forms.Button();
            img_QR_Code = new System.Windows.Forms.PictureBox();
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
            lblMaTB = new System.Windows.Forms.Label();
            dtgvQlThietBi = new System.Windows.Forms.DataGridView();
            Image = new System.Windows.Forms.DataGridViewImageColumn();
            DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WarrantyPeriob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SpecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gbThongtinTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_QR_Code).BeginInit();
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
            lblQLTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblQLTbi.Name = "lblQLTbi";
            lblQLTbi.Size = new System.Drawing.Size(365, 60);
            lblQLTbi.TabIndex = 0;
            lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            gbThongtinTB.Controls.Add(txtPrice);
            gbThongtinTB.Controls.Add(label3);
            gbThongtinTB.Controls.Add(btnDetail);
            gbThongtinTB.Controls.Add(img_QR_Code);
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
            gbThongtinTB.Controls.Add(lblMaTB);
            gbThongtinTB.Dock = System.Windows.Forms.DockStyle.Top;
            gbThongtinTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbThongtinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbThongtinTB.Location = new System.Drawing.Point(0, 60);
            gbThongtinTB.Margin = new System.Windows.Forms.Padding(2);
            gbThongtinTB.Name = "gbThongtinTB";
            gbThongtinTB.Padding = new System.Windows.Forms.Padding(2);
            gbThongtinTB.Size = new System.Drawing.Size(1571, 485);
            gbThongtinTB.TabIndex = 1;
            gbThongtinTB.TabStop = false;
            gbThongtinTB.Text = "Thông tin thiết bị";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(646, 182);
            txtPrice.Margin = new System.Windows.Forms.Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(216, 31);
            txtPrice.TabIndex = 16;
            txtPrice.KeyPress += txt_Price_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(495, 186);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 25);
            label3.TabIndex = 15;
            label3.Text = "Giá :";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = System.Drawing.Color.Lime;
            btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDetail.Location = new System.Drawing.Point(1345, 405);
            btnDetail.Margin = new System.Windows.Forms.Padding(2);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(212, 50);
            btnDetail.TabIndex = 14;
            btnDetail.Text = "Thông số kỹ thuật";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // img_QR_Code
            // 
            img_QR_Code.Location = new System.Drawing.Point(1250, 95);
            img_QR_Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            img_QR_Code.Name = "img_QR_Code";
            img_QR_Code.Size = new System.Drawing.Size(252, 230);
            img_QR_Code.TabIndex = 13;
            img_QR_Code.TabStop = false;
            // 
            // gbTimKiemTbi
            // 
            gbTimKiemTbi.Controls.Add(dtp_DateBuy);
            gbTimKiemTbi.Controls.Add(label2);
            gbTimKiemTbi.Controls.Add(btnTimKiemTbi);
            gbTimKiemTbi.Controls.Add(txtTiemKiemTbi);
            gbTimKiemTbi.Location = new System.Drawing.Point(6, 362);
            gbTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            gbTimKiemTbi.Name = "gbTimKiemTbi";
            gbTimKiemTbi.Padding = new System.Windows.Forms.Padding(2);
            gbTimKiemTbi.Size = new System.Drawing.Size(1205, 108);
            gbTimKiemTbi.TabIndex = 12;
            gbTimKiemTbi.TabStop = false;
            gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // dtp_DateBuy
            // 
            dtp_DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_DateBuy.Location = new System.Drawing.Point(640, 52);
            dtp_DateBuy.Margin = new System.Windows.Forms.Padding(2);
            dtp_DateBuy.Name = "dtp_DateBuy";
            dtp_DateBuy.Size = new System.Drawing.Size(216, 31);
            dtp_DateBuy.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(489, 58);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 25);
            label2.TabIndex = 16;
            label2.Text = "Ngày mua :";
            // 
            // btnTimKiemTbi
            // 
            btnTimKiemTbi.BackColor = System.Drawing.Color.Lime;
            btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemTbi.Location = new System.Drawing.Point(1001, 42);
            btnTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            btnTimKiemTbi.Name = "btnTimKiemTbi";
            btnTimKiemTbi.Size = new System.Drawing.Size(134, 50);
            btnTimKiemTbi.TabIndex = 13;
            btnTimKiemTbi.Text = "Tìm Kiếm";
            btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemTbi.Location = new System.Drawing.Point(171, 52);
            txtTiemKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            txtTiemKiemTbi.Size = new System.Drawing.Size(220, 31);
            txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            btnXoaTbi.BackColor = System.Drawing.Color.Lime;
            btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaTbi.Location = new System.Drawing.Point(1008, 228);
            btnXoaTbi.Margin = new System.Windows.Forms.Padding(2);
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
            btnSuaTbi.Location = new System.Drawing.Point(1008, 129);
            btnSuaTbi.Margin = new System.Windows.Forms.Padding(2);
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
            btnThemTbi.Location = new System.Drawing.Point(1008, 32);
            btnThemTbi.Margin = new System.Windows.Forms.Padding(2);
            btnThemTbi.Name = "btnThemTbi";
            btnThemTbi.Size = new System.Drawing.Size(134, 50);
            btnThemTbi.TabIndex = 9;
            btnThemTbi.Text = "Thêm Mới";
            btnThemTbi.UseVisualStyleBackColor = false;
            btnThemTbi.Click += btnThemTbi_Click;
            // 
            // rtbGhiChuTbi
            // 
            rtbGhiChuTbi.Location = new System.Drawing.Point(646, 249);
            rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(2);
            rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            rtbGhiChuTbi.Size = new System.Drawing.Size(216, 92);
            rtbGhiChuTbi.TabIndex = 8;
            rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            lblGhiChuTbi.AutoSize = true;
            lblGhiChuTbi.Location = new System.Drawing.Point(495, 249);
            lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblGhiChuTbi.Name = "lblGhiChuTbi";
            lblGhiChuTbi.Size = new System.Drawing.Size(89, 25);
            lblGhiChuTbi.TabIndex = 8;
            lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBaoHanh.Location = new System.Drawing.Point(646, 108);
            dtBaoHanh.Margin = new System.Windows.Forms.Padding(2);
            dtBaoHanh.Name = "dtBaoHanh";
            dtBaoHanh.Size = new System.Drawing.Size(216, 31);
            dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(495, 112);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 25);
            label1.TabIndex = 7;
            label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new System.Drawing.Point(646, 32);
            cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new System.Drawing.Size(216, 33);
            cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new System.Drawing.Point(495, 41);
            lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new System.Drawing.Size(66, 25);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa :";
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new System.Drawing.Point(180, 249);
            cbPhong.Margin = new System.Windows.Forms.Padding(2);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new System.Drawing.Size(216, 33);
            cbPhong.TabIndex = 5;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new System.Drawing.Point(35, 252);
            lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new System.Drawing.Size(77, 25);
            lblPhong.TabIndex = 5;
            lblPhong.Text = "Phòng :";
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new System.Drawing.Point(178, 181);
            cbNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new System.Drawing.Size(216, 33);
            cbNhaCungCap.TabIndex = 4;
            // 
            // cbLoaiTbi
            // 
            cbLoaiTbi.FormattingEnabled = true;
            cbLoaiTbi.Location = new System.Drawing.Point(180, 106);
            cbLoaiTbi.Margin = new System.Windows.Forms.Padding(2);
            cbLoaiTbi.Name = "cbLoaiTbi";
            cbLoaiTbi.Size = new System.Drawing.Size(216, 33);
            cbLoaiTbi.TabIndex = 3;
            // 
            // txtTenTbi
            // 
            txtTenTbi.Location = new System.Drawing.Point(178, 38);
            txtTenTbi.Margin = new System.Windows.Forms.Padding(2);
            txtTenTbi.Name = "txtTenTbi";
            txtTenTbi.Size = new System.Drawing.Size(216, 31);
            txtTenTbi.TabIndex = 2;
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Location = new System.Drawing.Point(32, 185);
            lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new System.Drawing.Size(131, 25);
            lblNhaCungCap.TabIndex = 3;
            lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            lblLoaiTbi.AutoSize = true;
            lblLoaiTbi.Location = new System.Drawing.Point(32, 110);
            lblLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblLoaiTbi.Name = "lblLoaiTbi";
            lblLoaiTbi.Size = new System.Drawing.Size(123, 25);
            lblLoaiTbi.TabIndex = 2;
            lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            lblTenTBi.AutoSize = true;
            lblTenTBi.Location = new System.Drawing.Point(32, 44);
            lblTenTBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTenTBi.Name = "lblTenTBi";
            lblTenTBi.Size = new System.Drawing.Size(118, 25);
            lblTenTBi.TabIndex = 1;
            lblTenTBi.Text = "Tên thiết bị :";
            // 
            // lblMaTB
            // 
            lblMaTB.AutoSize = true;
            lblMaTB.Location = new System.Drawing.Point(1250, 32);
            lblMaTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblMaTB.Name = "lblMaTB";
            lblMaTB.Size = new System.Drawing.Size(115, 25);
            lblMaTB.TabIndex = 0;
            lblMaTB.Text = "Mã thiết bị :";
            // 
            // dtgvQlThietBi
            // 
            dtgvQlThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtgvQlThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dtgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvQlThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Image, DeviceName, Note, CreatedDate, WarrantyPeriob, SpecsId, DeviceDetail, Brand, DeviceId });
            dtgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            dtgvQlThietBi.Location = new System.Drawing.Point(0, 545);
            dtgvQlThietBi.Margin = new System.Windows.Forms.Padding(2);
            dtgvQlThietBi.Name = "dtgvQlThietBi";
            dtgvQlThietBi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgvQlThietBi.RowTemplate.Height = 33;
            dtgvQlThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgvQlThietBi.Size = new System.Drawing.Size(1571, 295);
            dtgvQlThietBi.TabIndex = 2;
            dtgvQlThietBi.CellClick += dtgvQlThietBi_CellClick;
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            Image.FillWeight = 79.3672F;
            Image.HeaderText = "Thiết bị";
            Image.MinimumWidth = 6;
            Image.Name = "Image";
            Image.ReadOnly = true;
            Image.Visible = false;
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
            // Note
            // 
            Note.DataPropertyName = "Note";
            Note.FillWeight = 79.3672F;
            Note.HeaderText = "Mô tả";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
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
            // WarrantyPeriob
            // 
            WarrantyPeriob.DataPropertyName = "WarrantyPeriod";
            WarrantyPeriob.FillWeight = 79.3672F;
            WarrantyPeriob.HeaderText = "Hạn bảo hành";
            WarrantyPeriob.MinimumWidth = 6;
            WarrantyPeriob.Name = "WarrantyPeriob";
            WarrantyPeriob.ReadOnly = true;
            // 
            // SpecsId
            // 
            SpecsId.HeaderText = "Thông số";
            SpecsId.MinimumWidth = 6;
            SpecsId.Name = "SpecsId";
            SpecsId.Visible = false;
            // 
            // DeviceDetail
            // 
            DeviceDetail.FillWeight = 79.3672F;
            DeviceDetail.HeaderText = "Thông số chi tiết";
            DeviceDetail.MinimumWidth = 6;
            DeviceDetail.Name = "DeviceDetail";
            // 
            // Brand
            // 
            Brand.HeaderText = "Thương hiệu";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
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
            // frmQuanLyThietBi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1571, 924);
            Controls.Add(dtgvQlThietBi);
            Controls.Add(gbThongtinTB);
            Controls.Add(lblQLTbi);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmQuanLyThietBi";
            Text = "QuanLyThietBi";
            gbThongtinTB.ResumeLayout(false);
            gbThongtinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_QR_Code).EndInit();
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
        private System.Windows.Forms.PictureBox img_QR_Code;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyPeriob;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecsId;
        private System.Windows.Forms.DataGridViewButtonColumn DeviceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceId;
        private System.Windows.Forms.DateTimePicker dtp_DateBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
    }
}