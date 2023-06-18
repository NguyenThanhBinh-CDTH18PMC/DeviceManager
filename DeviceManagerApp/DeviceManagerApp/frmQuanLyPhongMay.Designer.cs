namespace DeviceManagerApp
{
    partial class frmQuanLyPhongMay
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
            lblQlPhong = new System.Windows.Forms.Label();
            qbPhongMay = new System.Windows.Forms.GroupBox();
            txtSoLuongTB = new System.Windows.Forms.TextBox();
            lblSoLuongTb = new System.Windows.Forms.Label();
            rtbGhiChuPhong = new System.Windows.Forms.RichTextBox();
            lblGhiChuPhong = new System.Windows.Forms.Label();
            gbTimKiemPhong = new System.Windows.Forms.GroupBox();
            btnTimKiemPhong = new System.Windows.Forms.Button();
            txtTiemKiemPhong = new System.Windows.Forms.TextBox();
            btnXoaPhong = new System.Windows.Forms.Button();
            btnSuaPhong = new System.Windows.Forms.Button();
            btnThemPhong = new System.Windows.Forms.Button();
            txtTenPhong = new System.Windows.Forms.TextBox();
            txtMaPhong = new System.Windows.Forms.TextBox();
            lblTenPhong = new System.Windows.Forms.Label();
            lblMaPhong = new System.Windows.Forms.Label();
            dgvPhongMay = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            qbPhongMay.SuspendLayout();
            gbTimKiemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongMay).BeginInit();
            SuspendLayout();
            // 
            // lblQlPhong
            // 
            lblQlPhong.AutoSize = true;
            lblQlPhong.Dock = System.Windows.Forms.DockStyle.Top;
            lblQlPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQlPhong.Location = new System.Drawing.Point(0, 0);
            lblQlPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblQlPhong.Name = "lblQlPhong";
            lblQlPhong.Size = new System.Drawing.Size(299, 41);
            lblQlPhong.TabIndex = 0;
            lblQlPhong.Text = "Quản Lý Phòng Máy";
            // 
            // qbPhongMay
            // 
            qbPhongMay.Controls.Add(txtSoLuongTB);
            qbPhongMay.Controls.Add(lblSoLuongTb);
            qbPhongMay.Controls.Add(rtbGhiChuPhong);
            qbPhongMay.Controls.Add(lblGhiChuPhong);
            qbPhongMay.Controls.Add(gbTimKiemPhong);
            qbPhongMay.Controls.Add(btnXoaPhong);
            qbPhongMay.Controls.Add(btnSuaPhong);
            qbPhongMay.Controls.Add(btnThemPhong);
            qbPhongMay.Controls.Add(txtTenPhong);
            qbPhongMay.Controls.Add(txtMaPhong);
            qbPhongMay.Controls.Add(lblTenPhong);
            qbPhongMay.Controls.Add(lblMaPhong);
            qbPhongMay.Dock = System.Windows.Forms.DockStyle.Top;
            qbPhongMay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            qbPhongMay.Location = new System.Drawing.Point(0, 41);
            qbPhongMay.Margin = new System.Windows.Forms.Padding(2);
            qbPhongMay.Name = "qbPhongMay";
            qbPhongMay.Padding = new System.Windows.Forms.Padding(2);
            qbPhongMay.Size = new System.Drawing.Size(899, 188);
            qbPhongMay.TabIndex = 0;
            qbPhongMay.TabStop = false;
            qbPhongMay.Text = "Thông tin phòng máy";
            // 
            // txtSoLuongTB
            // 
            txtSoLuongTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSoLuongTB.Location = new System.Drawing.Point(169, 93);
            txtSoLuongTB.Margin = new System.Windows.Forms.Padding(2);
            txtSoLuongTB.Name = "txtSoLuongTB";
            txtSoLuongTB.Size = new System.Drawing.Size(177, 23);
            txtSoLuongTB.TabIndex = 3;
            // 
            // lblSoLuongTb
            // 
            lblSoLuongTb.AutoSize = true;
            lblSoLuongTb.Location = new System.Drawing.Point(38, 97);
            lblSoLuongTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSoLuongTb.Name = "lblSoLuongTb";
            lblSoLuongTb.Size = new System.Drawing.Size(112, 15);
            lblSoLuongTb.TabIndex = 19;
            lblSoLuongTb.Text = "Số Lượng Thiết Bị :";
            // 
            // rtbGhiChuPhong
            // 
            rtbGhiChuPhong.Location = new System.Drawing.Point(169, 122);
            rtbGhiChuPhong.Margin = new System.Windows.Forms.Padding(2);
            rtbGhiChuPhong.Name = "rtbGhiChuPhong";
            rtbGhiChuPhong.Size = new System.Drawing.Size(178, 59);
            rtbGhiChuPhong.TabIndex = 4;
            rtbGhiChuPhong.Text = "";
            // 
            // lblGhiChuPhong
            // 
            lblGhiChuPhong.AutoSize = true;
            lblGhiChuPhong.Location = new System.Drawing.Point(38, 131);
            lblGhiChuPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblGhiChuPhong.Name = "lblGhiChuPhong";
            lblGhiChuPhong.Size = new System.Drawing.Size(56, 15);
            lblGhiChuPhong.TabIndex = 18;
            lblGhiChuPhong.Text = "Ghi Chú :";
            // 
            // gbTimKiemPhong
            // 
            gbTimKiemPhong.Controls.Add(btnTimKiemPhong);
            gbTimKiemPhong.Controls.Add(txtTiemKiemPhong);
            gbTimKiemPhong.Location = new System.Drawing.Point(573, 14);
            gbTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            gbTimKiemPhong.Name = "gbTimKiemPhong";
            gbTimKiemPhong.Padding = new System.Windows.Forms.Padding(2);
            gbTimKiemPhong.Size = new System.Drawing.Size(395, 121);
            gbTimKiemPhong.TabIndex = 17;
            gbTimKiemPhong.TabStop = false;
            gbTimKiemPhong.Text = "Tìm Kiếm";
            // 
            // btnTimKiemPhong
            // 
            btnTimKiemPhong.BackColor = System.Drawing.Color.Lime;
            btnTimKiemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemPhong.Location = new System.Drawing.Point(277, 25);
            btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            btnTimKiemPhong.Name = "btnTimKiemPhong";
            btnTimKiemPhong.Size = new System.Drawing.Size(94, 30);
            btnTimKiemPhong.TabIndex = 9;
            btnTimKiemPhong.Text = "Tìm kiếm";
            btnTimKiemPhong.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemPhong
            // 
            txtTiemKiemPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemPhong.Location = new System.Drawing.Point(23, 32);
            txtTiemKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            txtTiemKiemPhong.Name = "txtTiemKiemPhong";
            txtTiemKiemPhong.Size = new System.Drawing.Size(177, 23);
            txtTiemKiemPhong.TabIndex = 8;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.BackColor = System.Drawing.Color.Lime;
            btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaPhong.Location = new System.Drawing.Point(464, 105);
            btnXoaPhong.Margin = new System.Windows.Forms.Padding(2);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.Size = new System.Drawing.Size(94, 30);
            btnXoaPhong.TabIndex = 7;
            btnXoaPhong.Text = "Xóa";
            btnXoaPhong.UseVisualStyleBackColor = false;
            btnXoaPhong.Click += btnXoaPhong_Click;
            // 
            // btnSuaPhong
            // 
            btnSuaPhong.BackColor = System.Drawing.Color.Lime;
            btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaPhong.Location = new System.Drawing.Point(464, 61);
            btnSuaPhong.Margin = new System.Windows.Forms.Padding(2);
            btnSuaPhong.Name = "btnSuaPhong";
            btnSuaPhong.Size = new System.Drawing.Size(94, 30);
            btnSuaPhong.TabIndex = 6;
            btnSuaPhong.Text = "Cập nhật";
            btnSuaPhong.UseVisualStyleBackColor = false;
            btnSuaPhong.Click += btnSuaPhong_Click;
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = System.Drawing.Color.Lime;
            btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemPhong.Location = new System.Drawing.Point(464, 14);
            btnThemPhong.Margin = new System.Windows.Forms.Padding(2);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new System.Drawing.Size(94, 30);
            btnThemPhong.TabIndex = 5;
            btnThemPhong.Text = "Thêm Mới";
            btnThemPhong.UseVisualStyleBackColor = false;
            btnThemPhong.Click += btnThemPhong_Click;
            // 
            // txtTenPhong
            // 
            txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTenPhong.Location = new System.Drawing.Point(169, 57);
            txtTenPhong.Margin = new System.Windows.Forms.Padding(2);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new System.Drawing.Size(177, 23);
            txtTenPhong.TabIndex = 2;
            // 
            // txtMaPhong
            // 
            txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMaPhong.Location = new System.Drawing.Point(169, 20);
            txtMaPhong.Margin = new System.Windows.Forms.Padding(2);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new System.Drawing.Size(177, 23);
            txtMaPhong.TabIndex = 1;
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Location = new System.Drawing.Point(38, 61);
            lblTenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new System.Drawing.Size(71, 15);
            lblTenPhong.TabIndex = 1;
            lblTenPhong.Text = "Tên Phòng :";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new System.Drawing.Point(38, 24);
            lblMaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new System.Drawing.Size(68, 15);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã Phòng :";
            // 
            // dgvPhongMay
            // 
            dgvPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Column2, Column3, Column4, Column5 });
            dgvPhongMay.Location = new System.Drawing.Point(0, 229);
            dgvPhongMay.Margin = new System.Windows.Forms.Padding(2);
            dgvPhongMay.Name = "dgvPhongMay";
            dgvPhongMay.ReadOnly = true;
            dgvPhongMay.RowHeadersWidth = 62;
            dgvPhongMay.RowTemplate.Height = 33;
            dgvPhongMay.Size = new System.Drawing.Size(439, 150);
            dgvPhongMay.TabIndex = 2;
            dgvPhongMay.CellClick += dgvPhongMay_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Code";
            Column2.HeaderText = "Mã Phòng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Name";
            Column3.HeaderText = "Tên Phòng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Description";
            Column4.HeaderText = "Ghi Chú";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DeviceQuantity";
            Column5.HeaderText = "Số Lượng";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // frmQuanLyPhongMay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(899, 421);
            Controls.Add(dgvPhongMay);
            Controls.Add(qbPhongMay);
            Controls.Add(lblQlPhong);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmQuanLyPhongMay";
            Text = "QuanLyPhongMay";
            Load += frmQuanLyPhongMay_Load;
            qbPhongMay.ResumeLayout(false);
            qbPhongMay.PerformLayout();
            gbTimKiemPhong.ResumeLayout(false);
            gbTimKiemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongMay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQlPhong;
        private System.Windows.Forms.GroupBox qbPhongMay;
        private System.Windows.Forms.DataGridView dgvPhongMay;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.GroupBox gbTimKiemPhong;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.TextBox txtTiemKiemPhong;
        private System.Windows.Forms.RichTextBox rtbGhiChuPhong;
        private System.Windows.Forms.Label lblGhiChuPhong;
        private System.Windows.Forms.TextBox txtSoLuongTB;
        private System.Windows.Forms.Label lblSoLuongTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}