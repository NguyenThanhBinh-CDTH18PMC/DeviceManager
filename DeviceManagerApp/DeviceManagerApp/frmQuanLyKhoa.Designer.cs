namespace DeviceManagerApp
{
    partial class frmQuanLyKhoa
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
            lblQlKhoa = new System.Windows.Forms.Label();
            gbTTKhoa = new System.Windows.Forms.GroupBox();
            gbTimKiemKhoa = new System.Windows.Forms.GroupBox();
            btnTimKiemKhoa = new System.Windows.Forms.Button();
            txtTimKiemKhoa = new System.Windows.Forms.TextBox();
            btnXoaKhoa = new System.Windows.Forms.Button();
            btnSuaKhoa = new System.Windows.Forms.Button();
            btnThemKhoa = new System.Windows.Forms.Button();
            txtTenKhoa = new System.Windows.Forms.TextBox();
            lblTenKhoa = new System.Windows.Forms.Label();
            txtMaKhoa = new System.Windows.Forms.TextBox();
            lblMaKhoa = new System.Windows.Forms.Label();
            dgvQlKhoa = new System.Windows.Forms.DataGridView();
            gbTTKhoa.SuspendLayout();
            gbTimKiemKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQlKhoa).BeginInit();
            SuspendLayout();
            // 
            // lblQlKhoa
            // 
            lblQlKhoa.AutoSize = true;
            lblQlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            lblQlKhoa.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQlKhoa.Location = new System.Drawing.Point(0, 0);
            lblQlKhoa.Name = "lblQlKhoa";
            lblQlKhoa.Size = new System.Drawing.Size(312, 60);
            lblQlKhoa.TabIndex = 0;
            lblQlKhoa.Text = "Quản Lý Khoa";
            // 
            // gbTTKhoa
            // 
            gbTTKhoa.Controls.Add(gbTimKiemKhoa);
            gbTTKhoa.Controls.Add(btnXoaKhoa);
            gbTTKhoa.Controls.Add(btnSuaKhoa);
            gbTTKhoa.Controls.Add(btnThemKhoa);
            gbTTKhoa.Controls.Add(txtTenKhoa);
            gbTTKhoa.Controls.Add(lblTenKhoa);
            gbTTKhoa.Controls.Add(txtMaKhoa);
            gbTTKhoa.Controls.Add(lblMaKhoa);
            gbTTKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            gbTTKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTTKhoa.Location = new System.Drawing.Point(0, 60);
            gbTTKhoa.Name = "gbTTKhoa";
            gbTTKhoa.Size = new System.Drawing.Size(1496, 254);
            gbTTKhoa.TabIndex = 1;
            gbTTKhoa.TabStop = false;
            gbTTKhoa.Text = "Thông tin khoa";
            // 
            // gbTimKiemKhoa
            // 
            gbTimKiemKhoa.Controls.Add(btnTimKiemKhoa);
            gbTimKiemKhoa.Controls.Add(txtTimKiemKhoa);
            gbTimKiemKhoa.Location = new System.Drawing.Point(800, 62);
            gbTimKiemKhoa.Name = "gbTimKiemKhoa";
            gbTimKiemKhoa.Size = new System.Drawing.Size(645, 145);
            gbTimKiemKhoa.TabIndex = 6;
            gbTimKiemKhoa.TabStop = false;
            gbTimKiemKhoa.Text = "Tìm Kiếm Khoa";
            // 
            // btnTimKiemKhoa
            // 
            btnTimKiemKhoa.BackColor = System.Drawing.Color.Lime;
            btnTimKiemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemKhoa.Location = new System.Drawing.Point(446, 40);
            btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            btnTimKiemKhoa.Size = new System.Drawing.Size(134, 50);
            btnTimKiemKhoa.TabIndex = 7;
            btnTimKiemKhoa.Text = "Tìm Kiếm";
            btnTimKiemKhoa.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemKhoa
            // 
            txtTimKiemKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTimKiemKhoa.Location = new System.Drawing.Point(58, 59);
            txtTimKiemKhoa.Name = "txtTimKiemKhoa";
            txtTimKiemKhoa.Size = new System.Drawing.Size(273, 31);
            txtTimKiemKhoa.TabIndex = 0;
            // 
            // btnXoaKhoa
            // 
            btnXoaKhoa.BackColor = System.Drawing.Color.Lime;
            btnXoaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaKhoa.Location = new System.Drawing.Point(578, 176);
            btnXoaKhoa.Name = "btnXoaKhoa";
            btnXoaKhoa.Size = new System.Drawing.Size(134, 50);
            btnXoaKhoa.TabIndex = 5;
            btnXoaKhoa.Text = "Xóa";
            btnXoaKhoa.UseVisualStyleBackColor = false;
            // 
            // btnSuaKhoa
            // 
            btnSuaKhoa.BackColor = System.Drawing.Color.Lime;
            btnSuaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaKhoa.Location = new System.Drawing.Point(578, 100);
            btnSuaKhoa.Name = "btnSuaKhoa";
            btnSuaKhoa.Size = new System.Drawing.Size(134, 50);
            btnSuaKhoa.TabIndex = 4;
            btnSuaKhoa.Text = "Cập Nhật";
            btnSuaKhoa.UseVisualStyleBackColor = false;
            // 
            // btnThemKhoa
            // 
            btnThemKhoa.BackColor = System.Drawing.Color.Lime;
            btnThemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemKhoa.Location = new System.Drawing.Point(578, 23);
            btnThemKhoa.Name = "btnThemKhoa";
            btnThemKhoa.Size = new System.Drawing.Size(134, 50);
            btnThemKhoa.TabIndex = 3;
            btnThemKhoa.Text = "Thêm Mới";
            btnThemKhoa.UseVisualStyleBackColor = false;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new System.Drawing.Point(162, 100);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new System.Drawing.Size(226, 31);
            txtTenKhoa.TabIndex = 2;
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new System.Drawing.Point(12, 106);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new System.Drawing.Size(101, 25);
            lblTenKhoa.TabIndex = 2;
            lblTenKhoa.Text = "Tên Khoa :";
            lblTenKhoa.Click += label1_Click;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new System.Drawing.Point(162, 42);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new System.Drawing.Size(226, 31);
            txtMaKhoa.TabIndex = 1;
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new System.Drawing.Point(12, 48);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(98, 25);
            lblMaKhoa.TabIndex = 0;
            lblMaKhoa.Text = "Mã Khoa :";
            // 
            // dgvQlKhoa
            // 
            dgvQlKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            dgvQlKhoa.Location = new System.Drawing.Point(0, 314);
            dgvQlKhoa.Name = "dgvQlKhoa";
            dgvQlKhoa.RowHeadersWidth = 62;
            dgvQlKhoa.RowTemplate.Height = 33;
            dgvQlKhoa.Size = new System.Drawing.Size(1496, 283);
            dgvQlKhoa.TabIndex = 2;
            // 
            // frmQuanLyKhoa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1496, 624);
            Controls.Add(dgvQlKhoa);
            Controls.Add(gbTTKhoa);
            Controls.Add(lblQlKhoa);
            Name = "frmQuanLyKhoa";
            Text = "QuanLyKhoa";
            gbTTKhoa.ResumeLayout(false);
            gbTTKhoa.PerformLayout();
            gbTimKiemKhoa.ResumeLayout(false);
            gbTimKiemKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQlKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQlKhoa;
        private System.Windows.Forms.GroupBox gbTTKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.GroupBox gbTimKiemKhoa;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.TextBox txtTimKiemKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.DataGridView dgvQlKhoa;
    }
}