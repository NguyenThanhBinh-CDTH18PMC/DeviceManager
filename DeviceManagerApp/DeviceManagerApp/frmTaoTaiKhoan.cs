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
            if (Check())
            {
                UserModel user = new UserModel();
                user.CreatedDate = DateTime.Now;
                user.CreatedUserId = 1;
                user.IsDeleted = false;
                user.Status = 0;
                user.UserName = txtTenDangNhap.Text;
                user.Pass = GetMD5(txtMatKhau.Text);
                user.Name = txtTenHienThi.Text;
                UserBus.InsertUser(user);
                MessageBox.Show("Thành Công");
            }
            else MessageBox.Show("Không hợp lệ");
            

            
        }
        private static string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");//Nếu là "X2" thì kết quả sẽ tự chuyển sang ký tự in Hoa
            }

            return str_md5;
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
