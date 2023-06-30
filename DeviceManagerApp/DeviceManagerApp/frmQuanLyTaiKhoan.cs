using DeviceManagerApp.BUS.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceManagerApp
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            CkbMatKhau.Checked = false;
            txtTenDangNhap.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            lblMatKhauCu.Enabled = false;
            lblMatKhauMoi.Enabled = false;
            dgvTaiKhoan.AutoGenerateColumns = false;

        }

        private void CkbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbMatKhau.Checked)
            {
                txtMatKhauMoi.Enabled
                    = true;
                txtTenDangNhap.Enabled = true;
                lblMatKhauCu.Enabled = true;
                lblMatKhauMoi.Enabled = true;
            }
            else
            {
                txtTenDangNhap.Enabled = false;
                txtMatKhauMoi.Enabled = false;
                lblMatKhauCu.Enabled = false;
                lblMatKhauMoi.Enabled = false;
            }
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cbTeacher.DataSource = TeacherBus.GetTeachersAfterDelete();
            cbTeacher.DisplayMember = "FullName";
            cbTeacher.ValueMember = "Id";


            dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
        }

        private void btnTaoTk_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frmTaoTaiKhoan = new frmTaoTaiKhoan();
            frmTaoTaiKhoan.Show();
        }


    }
}
