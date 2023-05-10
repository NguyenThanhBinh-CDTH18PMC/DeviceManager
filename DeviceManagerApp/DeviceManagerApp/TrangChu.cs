using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceManagerApp
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan());
            lbl_text.Text = btnQLTaiKhoan.Text;
        }

        private void btnQLPhongMay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhongMay());
            lbl_text.Text = btnQLPhongMay.Text;
        }

        private void pictureBox1_Logo_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_text.Text = "QUẢN LÝ THIẾT BỊ PHÒNG MÁY";
        }
    }
}
