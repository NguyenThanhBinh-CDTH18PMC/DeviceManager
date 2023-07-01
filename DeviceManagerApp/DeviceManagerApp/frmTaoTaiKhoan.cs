using BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DeviceManagerApp
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.CreatedDate = DateTime.Now;
            user.CreatedUserId = 1;
            user.IsDeleted = false;
            user.Status = 0;
            user.UserName = txtTenDangNhap.Text;
            user.Pass = SettingClass.GetMD5(txtMatKhau.Text);
            user.Name = txtTenHienThi.Text;
            try
            {
                if (!Check())
                {

                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    UserBus.InsertUser(user);
                    MessageBox.Show("Tạo Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private  bool Check()
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                return false;
            }
            if(txtMatKhau.Text.Trim()=="" || txtMatKhau.Text.Length <= 6)
            {
                return false;
            }
            if (txtTenHienThi.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
    }
}
