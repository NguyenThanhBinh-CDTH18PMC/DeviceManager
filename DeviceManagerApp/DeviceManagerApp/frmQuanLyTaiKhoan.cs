using BUS.BusinessObject;
using DeviceManagerApp.BUS.BusinessObject;
using DeviceManagerApp.DTO.Model;
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
            btnCapNhatUser.Enabled = false;
            btnCapNhatUser.BackColor = System.Drawing.Color.LightGray;
            dgvTaiKhoan.AutoGenerateColumns = false;


            dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.CellFormatting += dgvTaiKhoan_CellFormatting;
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";

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
                btnCapNhatUser.Enabled = true;
                btnCapNhatUser.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                txtTenDangNhap.Enabled = false;
                txtMatKhauMoi.Enabled = false;
                lblMatKhauCu.Enabled = false;
                lblMatKhauMoi.Enabled = false;
                btnCapNhatUser.Enabled = false;
                btnCapNhatUser.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cbTeacher.DataSource = TeacherBus.GetTeachersAfterDelete();
            cbTeacher.DisplayMember = "FullName";
            cbTeacher.ValueMember = "Id";

            cbTenTaiKhoan.DataSource = UserBus.SelectAll();
            cbTenTaiKhoan.DisplayMember = "Name";
            cbTenTaiKhoan.ValueMember = "Id";
            dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
        }

        private void btnTaoTk_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frmTaoTaiKhoan = new frmTaoTaiKhoan();
            frmTaoTaiKhoan.Show();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTaiKhoan.Rows[e.RowIndex];
                cbTeacher.Text = row.Cells["TeacherName"].Value.ToString();
                bool currentGender = (bool)dgvTaiKhoan.Rows[e.RowIndex].Cells["TeacherGender"].Value;
                if (currentGender)
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtSDT.Text = row.Cells["TeacherPhone"].Value.ToString();
                dtNgaySinh.Text = row.Cells["TeacherBirth"].Value.ToString();
                cbTenTaiKhoan.Text = row.Cells["NameUser"].Value.ToString();

            }
            catch
            {

            }
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvTaiKhoan.Columns["TeacherGender"].Index)
            {
                if (e.Value != null)
                {
                    string gender = e.Value.ToString();
                    {
                        if (gender == "True")
                        {
                            e.Value = "Nam";
                        }
                        else if (gender == "False")
                        {
                            e.Value = "Nữ";
                        }
                    }
                }
            }
        }

        private void btnThemTk_Click(object sender, EventArgs e)
        {
            DecentralizationModel decentralizationModel = new DecentralizationModel();
            decentralizationModel.TeacherId = (int)cbTeacher.SelectedValue;
            decentralizationModel.UserId = (int)cbTenTaiKhoan.SelectedValue;
            decentralizationModel.CreatedDate = DateTime.Now;
            decentralizationModel.CreatedUserId = 1;
            decentralizationModel.IsDeleted = false;
            try
            {
                DecentralizationBus.InSertDecentralization(decentralizationModel);
                MessageBox.Show("Tạo Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
