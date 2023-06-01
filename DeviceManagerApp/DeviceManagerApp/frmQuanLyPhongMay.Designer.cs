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
            lblQlPhong.Name = "lblQlPhong";
            lblQlPhong.Size = new System.Drawing.Size(442, 60);
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
            qbPhongMay.Location = new System.Drawing.Point(0, 60);
            qbPhongMay.Name = "qbPhongMay";
            qbPhongMay.Size = new System.Drawing.Size(1394, 314);
            qbPhongMay.TabIndex = 0;
            qbPhongMay.TabStop = false;
            qbPhongMay.Text = "Thông tin phòng máy";
            // 
            // txtSoLuongTB
            // 
            txtSoLuongTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSoLuongTB.Location = new System.Drawing.Point(242, 155);
            txtSoLuongTB.Name = "txtSoLuongTB";
            txtSoLuongTB.Size = new System.Drawing.Size(252, 31);
            txtSoLuongTB.TabIndex = 20;
            // 
            // lblSoLuongTb
            // 
            lblSoLuongTb.AutoSize = true;
            lblSoLuongTb.Location = new System.Drawing.Point(54, 161);
            lblSoLuongTb.Name = "lblSoLuongTb";
            lblSoLuongTb.Size = new System.Drawing.Size(173, 25);
            lblSoLuongTb.TabIndex = 19;
            lblSoLuongTb.Text = "Số Lượng Thiết Bị :";
            // 
            // rtbGhiChuPhong
            // 
            rtbGhiChuPhong.Location = new System.Drawing.Point(242, 203);
            rtbGhiChuPhong.Name = "rtbGhiChuPhong";
            rtbGhiChuPhong.Size = new System.Drawing.Size(252, 95);
            rtbGhiChuPhong.TabIndex = 3;
            rtbGhiChuPhong.Text = "";
            // 
            // lblGhiChuPhong
            // 
            lblGhiChuPhong.AutoSize = true;
            lblGhiChuPhong.Location = new System.Drawing.Point(54, 218);
            lblGhiChuPhong.Name = "lblGhiChuPhong";
            lblGhiChuPhong.Size = new System.Drawing.Size(89, 25);
            lblGhiChuPhong.TabIndex = 18;
            lblGhiChuPhong.Text = "Ghi Chú :";
            // 
            // gbTimKiemPhong
            // 
            gbTimKiemPhong.Controls.Add(btnTimKiemPhong);
            gbTimKiemPhong.Controls.Add(txtTiemKiemPhong);
            gbTimKiemPhong.Location = new System.Drawing.Point(818, 23);
            gbTimKiemPhong.Name = "gbTimKiemPhong";
            gbTimKiemPhong.Size = new System.Drawing.Size(564, 202);
            gbTimKiemPhong.TabIndex = 17;
            gbTimKiemPhong.TabStop = false;
            gbTimKiemPhong.Text = "Tìm Kiếm";
            // 
            // btnTimKiemPhong
            // 
            btnTimKiemPhong.BackColor = System.Drawing.Color.Lime;
            btnTimKiemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemPhong.Location = new System.Drawing.Point(396, 42);
            btnTimKiemPhong.Name = "btnTimKiemPhong";
            btnTimKiemPhong.Size = new System.Drawing.Size(134, 50);
            btnTimKiemPhong.TabIndex = 8;
            btnTimKiemPhong.Text = "Tìm kiếm";
            btnTimKiemPhong.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemPhong
            // 
            txtTiemKiemPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemPhong.Location = new System.Drawing.Point(33, 53);
            txtTiemKiemPhong.Name = "txtTiemKiemPhong";
            txtTiemKiemPhong.Size = new System.Drawing.Size(252, 31);
            txtTiemKiemPhong.TabIndex = 7;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.BackColor = System.Drawing.Color.Lime;
            btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaPhong.Location = new System.Drawing.Point(663, 175);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.Size = new System.Drawing.Size(134, 50);
            btnXoaPhong.TabIndex = 6;
            btnXoaPhong.Text = "Xóa";
            btnXoaPhong.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhong
            // 
            btnSuaPhong.BackColor = System.Drawing.Color.Lime;
            btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaPhong.Location = new System.Drawing.Point(663, 101);
            btnSuaPhong.Name = "btnSuaPhong";
            btnSuaPhong.Size = new System.Drawing.Size(134, 50);
            btnSuaPhong.TabIndex = 5;
            btnSuaPhong.Text = "Cập nhật";
            btnSuaPhong.UseVisualStyleBackColor = false;
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = System.Drawing.Color.Lime;
            btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemPhong.Location = new System.Drawing.Point(663, 23);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new System.Drawing.Size(134, 50);
            btnThemPhong.TabIndex = 4;
            btnThemPhong.Text = "Thêm Mới";
            btnThemPhong.UseVisualStyleBackColor = false;
            // 
            // txtTenPhong
            // 
            txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTenPhong.Location = new System.Drawing.Point(242, 95);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new System.Drawing.Size(252, 31);
            txtTenPhong.TabIndex = 2;
            // 
            // txtMaPhong
            // 
            txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMaPhong.Location = new System.Drawing.Point(242, 34);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new System.Drawing.Size(252, 31);
            txtMaPhong.TabIndex = 1;
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Location = new System.Drawing.Point(54, 101);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new System.Drawing.Size(112, 25);
            lblTenPhong.TabIndex = 1;
            lblTenPhong.Text = "Tên Phòng :";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new System.Drawing.Point(54, 40);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new System.Drawing.Size(109, 25);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã Phòng :";
            // 
            // dgvPhongMay
            // 
            dgvPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongMay.Dock = System.Windows.Forms.DockStyle.Top;
            dgvPhongMay.Location = new System.Drawing.Point(0, 374);
            dgvPhongMay.Name = "dgvPhongMay";
            dgvPhongMay.RowHeadersWidth = 62;
            dgvPhongMay.RowTemplate.Height = 33;
            dgvPhongMay.Size = new System.Drawing.Size(1394, 312);
            dgvPhongMay.TabIndex = 2;
            // 
            // frmQuanLyPhongMay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1394, 589);
            Controls.Add(dgvPhongMay);
            Controls.Add(qbPhongMay);
            Controls.Add(lblQlPhong);
            Name = "frmQuanLyPhongMay";
            Text = "QuanLyPhongMay";
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
    }
}