using DeviceManagerApp.BUS.BusinessObject;
using DeviceManagerApp.DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace DeviceManagerApp
{
    public partial class frmQuanLyLoaiThietBi : Form
    {
        int currentDeviceType = 0;
        public frmQuanLyLoaiThietBi()
        {
            InitializeComponent();
            QuanLyLoaiThietBi_Load();
        }

        private void QuanLyLoaiThietBi_Load()
        {
            dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();
        }

        private void frmQuanLyLoaiThietBi_Load(object sender, EventArgs e)
        {
            dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();
        }

        private void btnThemLoaiTB_Click(object sender, EventArgs e)
        {
            try
            {
                Device_TypeModel _TypeModel = new Device_TypeModel();
                _TypeModel.Id = int.Parse(txtMaLoaiTb.Text);
                _TypeModel.Name = txtTenLoaiTB.Text;
                _TypeModel.Description = rtbMotaLoaiTB.Text;
                Device_TypeBus.InsertDevice_Type(_TypeModel);
                MessageBox.Show("Thêm Thành Công");
                dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLoaiTb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLoaiTb.Rows[e.RowIndex];
                txtMaLoaiTb.Text = row.Cells[0].Value.ToString();
                txtTenLoaiTB.Text = row.Cells[1].Value.ToString();
                rtbMotaLoaiTB.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void dtgvListDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiTb.SelectedCells.Count > 0)
            {
                    currentDeviceType = (int)dgvLoaiTb.SelectedCells[0].OwningRow.Cells["DeviceTypeId"].Value;
            }

        }

        private void btnSuaLoaiTb_Click(object sender, EventArgs e)
        {
            try
            {
                Device_TypeModel _TypeModel = new Device_TypeModel();
                _TypeModel.Id = int.Parse(txtMaLoaiTb.Text);
                _TypeModel.Name = txtTenLoaiTB.Text;
                _TypeModel.Description = rtbMotaLoaiTB.Text;
                Device_TypeBus.UpdateDevice_Type(_TypeModel);
                MessageBox.Show("Cập Nhật Thành Công");
                dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaLoaiTb_Click(object sender, EventArgs e)
        {
            try
            {
                Device_TypeModel device_Type = new Device_TypeModel();
                device_Type.Id = int.Parse(txtMaLoaiTb.Text);
                device_Type.Name = txtTenLoaiTB.Text;
                device_Type.Description = rtbMotaLoaiTB.Text;
                Device_TypeBus.DeleteDevice_Type(device_Type.Id);
                MessageBox.Show("Xóa Thành Công");
                dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSpecs_Click(object sender, EventArgs e)
        {
            if(currentDeviceType!=0)
            {
                Form addSpecs = new frmSetSpecsForDeviceType(Device_TypeBus.SelectByPrimaryKey(currentDeviceType));
                addSpecs.Show();
            }
        }
    }
}
