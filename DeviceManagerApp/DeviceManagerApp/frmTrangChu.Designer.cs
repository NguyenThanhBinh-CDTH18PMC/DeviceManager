﻿namespace DeviceManagerApp
{
    partial class frmTrangChu
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
            panel_Left = new System.Windows.Forms.Panel();
            btnQlThuongHieu = new System.Windows.Forms.Button();
            btnQlKhoa = new System.Windows.Forms.Button();
            btnQlThietBi = new System.Windows.Forms.Button();
            btnQLPhongMay = new System.Windows.Forms.Button();
            btnQLTaiKhoan = new System.Windows.Forms.Button();
            pictureBox1_Logo = new System.Windows.Forms.PictureBox();
            panel_Top = new System.Windows.Forms.Panel();
            lbl_text = new System.Windows.Forms.Label();
            panel_Body = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnQlThanhLy = new System.Windows.Forms.Button();
            panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Logo).BeginInit();
            panel_Top.SuspendLayout();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = System.Drawing.Color.Blue;
            panel_Left.Controls.Add(btnQlThanhLy);
            panel_Left.Controls.Add(btnQlThuongHieu);
            panel_Left.Controls.Add(btnQlKhoa);
            panel_Left.Controls.Add(btnQlThietBi);
            panel_Left.Controls.Add(btnQLPhongMay);
            panel_Left.Controls.Add(btnQLTaiKhoan);
            panel_Left.Controls.Add(pictureBox1_Logo);
            panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            panel_Left.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel_Left.ForeColor = System.Drawing.Color.DarkBlue;
            panel_Left.Location = new System.Drawing.Point(0, 0);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new System.Drawing.Size(347, 989);
            panel_Left.TabIndex = 0;
            // 
            // btnQlThuongHieu
            // 
            btnQlThuongHieu.BackColor = System.Drawing.Color.Blue;
            btnQlThuongHieu.Dock = System.Windows.Forms.DockStyle.Top;
            btnQlThuongHieu.ForeColor = System.Drawing.Color.White;
            btnQlThuongHieu.Location = new System.Drawing.Point(0, 514);
            btnQlThuongHieu.Name = "btnQlThuongHieu";
            btnQlThuongHieu.Size = new System.Drawing.Size(347, 60);
            btnQlThuongHieu.TabIndex = 5;
            btnQlThuongHieu.Text = "Quản Lý Thương Hiệu";
            btnQlThuongHieu.UseVisualStyleBackColor = false;
            btnQlThuongHieu.Click += btnQlThuongHieu_Click;
            // 
            // btnQlKhoa
            // 
            btnQlKhoa.BackColor = System.Drawing.Color.Blue;
            btnQlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            btnQlKhoa.ForeColor = System.Drawing.Color.White;
            btnQlKhoa.Location = new System.Drawing.Point(0, 454);
            btnQlKhoa.Name = "btnQlKhoa";
            btnQlKhoa.Size = new System.Drawing.Size(347, 60);
            btnQlKhoa.TabIndex = 4;
            btnQlKhoa.Text = "Quản Lý Khoa";
            btnQlKhoa.UseVisualStyleBackColor = false;
            btnQlKhoa.Click += btnQlKhoa_Click;
            // 
            // btnQlThietBi
            // 
            btnQlThietBi.BackColor = System.Drawing.Color.Blue;
            btnQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            btnQlThietBi.ForeColor = System.Drawing.Color.White;
            btnQlThietBi.Location = new System.Drawing.Point(0, 394);
            btnQlThietBi.Name = "btnQlThietBi";
            btnQlThietBi.Size = new System.Drawing.Size(347, 60);
            btnQlThietBi.TabIndex = 3;
            btnQlThietBi.Text = "Quản Lý Thiết Bị";
            btnQlThietBi.UseVisualStyleBackColor = false;
            btnQlThietBi.Click += btnQlThietBi_Click;
            // 
            // btnQLPhongMay
            // 
            btnQLPhongMay.BackColor = System.Drawing.Color.Blue;
            btnQLPhongMay.Dock = System.Windows.Forms.DockStyle.Top;
            btnQLPhongMay.ForeColor = System.Drawing.Color.White;
            btnQLPhongMay.Location = new System.Drawing.Point(0, 334);
            btnQLPhongMay.Name = "btnQLPhongMay";
            btnQLPhongMay.Size = new System.Drawing.Size(347, 60);
            btnQLPhongMay.TabIndex = 2;
            btnQLPhongMay.Text = "Quản lý Phòng Máy";
            btnQLPhongMay.UseVisualStyleBackColor = false;
            btnQLPhongMay.Click += btnQLPhongMay_Click;
            // 
            // btnQLTaiKhoan
            // 
            btnQLTaiKhoan.BackColor = System.Drawing.Color.Blue;
            btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            btnQLTaiKhoan.ForeColor = System.Drawing.Color.White;
            btnQLTaiKhoan.Location = new System.Drawing.Point(0, 274);
            btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            btnQLTaiKhoan.Size = new System.Drawing.Size(347, 60);
            btnQLTaiKhoan.TabIndex = 1;
            btnQLTaiKhoan.Text = "Quản lý Tài Khoản";
            btnQLTaiKhoan.UseVisualStyleBackColor = false;
            btnQLTaiKhoan.Click += btnQLTaiKhoan_Click;
            // 
            // pictureBox1_Logo
            // 
            pictureBox1_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1_Logo.Image = Properties.Resources.Logo;
            pictureBox1_Logo.Location = new System.Drawing.Point(0, 0);
            pictureBox1_Logo.Name = "pictureBox1_Logo";
            pictureBox1_Logo.Size = new System.Drawing.Size(347, 274);
            pictureBox1_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1_Logo.TabIndex = 0;
            pictureBox1_Logo.TabStop = false;
            pictureBox1_Logo.Click += pictureBox1_Logo_Click;
            // 
            // panel_Top
            // 
            panel_Top.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel_Top.Controls.Add(lbl_text);
            panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            panel_Top.Location = new System.Drawing.Point(347, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new System.Drawing.Size(741, 76);
            panel_Top.TabIndex = 1;
            // 
            // lbl_text
            // 
            lbl_text.AutoSize = true;
            lbl_text.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl_text.Location = new System.Drawing.Point(18, 25);
            lbl_text.Name = "lbl_text";
            lbl_text.Size = new System.Drawing.Size(394, 32);
            lbl_text.TabIndex = 0;
            lbl_text.Text = "QUẢN LÝ THIẾT BỊ PHÒNG MÁY";
            lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Body
            // 
            panel_Body.Controls.Add(pictureBox1);
            panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Body.Location = new System.Drawing.Point(347, 76);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new System.Drawing.Size(741, 913);
            panel_Body.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(741, 913);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnQlThanhLy
            // 
            btnQlThanhLy.BackColor = System.Drawing.Color.Blue;
            btnQlThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            btnQlThanhLy.ForeColor = System.Drawing.Color.White;
            btnQlThanhLy.Location = new System.Drawing.Point(0, 574);
            btnQlThanhLy.Name = "btnQlThanhLy";
            btnQlThanhLy.Size = new System.Drawing.Size(347, 60);
            btnQlThanhLy.TabIndex = 6;
            btnQlThanhLy.Text = "Quản Lý Thanh Lý";
            btnQlThanhLy.UseVisualStyleBackColor = false;
            btnQlThanhLy.Click += btnQlThanhLy_Click;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1088, 989);
            Controls.Add(panel_Body);
            Controls.Add(panel_Top);
            Controls.Add(panel_Left);
            Name = "frmTrangChu";
            Text = "Trang Chủ";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += TrangChu_Load;
            panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Logo).EndInit();
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pictureBox1_Logo;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnQLPhongMay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQlThietBi;
        private System.Windows.Forms.Button btnQlKhoa;
        private System.Windows.Forms.Button btnQlThuongHieu;
        private System.Windows.Forms.Button btnQlThanhLy;
    }
}