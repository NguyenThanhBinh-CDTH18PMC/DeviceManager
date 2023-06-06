using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DeviceManagerApp.BUS.BusinessObject;
using DeviceManagerApp.DTO.Model;
using DTO;

namespace DeviceManagerApp
{
    public partial class frmQuanLyPhongMay : Form
    {
        public frmQuanLyPhongMay()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhongMay_Load(object sender, EventArgs e)
        {
            dgvPhongMay.DataSource = RoomBus.GetAllRoom();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                RoomModel roomModel = new RoomModel();
                roomModel.Code = txtMaPhong.Text;
                roomModel.Name = txtTenPhong.Text;
                roomModel.Description = rtbGhiChuPhong.Text;
                roomModel.DeviceQuantity = int.Parse(txtSoLuongTB.Text);
                RoomBus.InSertRoom(roomModel);
                MessageBox.Show("Thêm Thành Công");
                dgvPhongMay.DataSource = RoomBus.GetAllRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvPhongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvPhongMay.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[1].Value.ToString();
                txtTenPhong.Text = row.Cells[2].Value.ToString();
                txtSoLuongTB.Text = row.Cells[4].Value.ToString();
                rtbGhiChuPhong.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                RoomModel roomModel = new RoomModel();
                roomModel.Code = txtMaPhong.Text;
                roomModel.Name = txtTenPhong.Text;
                roomModel.Description = rtbGhiChuPhong.Text;
                roomModel.DeviceQuantity = int.Parse(txtSoLuongTB.Text);
                RoomBus.UpdateRoom(roomModel);
                MessageBox.Show("Cập Nhật Thành Công");
                dgvPhongMay.DataSource = RoomBus.GetAllRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                RoomModel roomModel = new RoomModel();
                roomModel.Code = txtMaPhong.Text;
                roomModel.Name = txtTenPhong.Text;
                roomModel.Description = rtbGhiChuPhong.Text;
                roomModel.DeviceQuantity = int.Parse(txtSoLuongTB.Text);
                RoomBus.DeleteRoom(roomModel.Code);
                MessageBox.Show("Xóa Thành Công");
                dgvPhongMay.DataSource = RoomBus.GetAllRoom();
                txtMaPhong = null;
                txtTenPhong = null;
                rtbGhiChuPhong = null;
                txtSoLuongTB = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
