using DeviceManagerApp.BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceManagerApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btbDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == ""||txtMatKhau.Text=="")
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Trống");
            }
            else
            {
                string UserName = txtTenDangNhap.Text;
                string Pass =SettingClass.GetMD5 (txtMatKhau.Text);
                UserModel user = DecentralizationBus.GetUserByUserName_Pass(UserName, Pass);
                if (user != null)
                {
                    int UserId=user.Id;
                    if(DecentralizationBus.CheckUserId(UserId))
                    {
                        int Status = DecentralizationBus.GetStatusByUserId(UserId);
                        if (Status == 1) {
                            //là admin
                            MessageBox.Show("Đăng Nhập Thành Công");
                            UserModel userModel=DecentralizationBus.GetInfoById(UserId);
                            frmTrangChu frmTrangChu = new frmTrangChu(user);
                            frmTrangChu.ShowDialog();
                            this.Close();
                        }else if(Status==0) 
                        {
                            MessageBox.Show("Đăng Nhập Thành Công");
                            //giáo viên
                            frmTeacher frmTrangChuGiaoVien=new frmTeacher();
                            frmTrangChuGiaoVien.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn Không Có Quyền Đăng Nhập");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
        }
    }
}
