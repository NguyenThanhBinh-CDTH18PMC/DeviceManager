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
    public partial class frmQuanLyThuongHieu : Form
    {
        public frmQuanLyThuongHieu()
        {
            InitializeComponent();
        }

        private void frmQuanLyThuongHieu_Load(object sender, EventArgs e)
        {
            dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
        }

        private void btnThemThuongHieu_Click(object sender, EventArgs e)
        {
            try
            {
                BrandModel brandModel = new BrandModel();
                brandModel.Id = int.Parse(txtMaThuongHieu.Text);
                brandModel.Name = txtTenThuongHieu.Text;
                brandModel.Address = rtbDiaChi.Text;
                BrandBus.InsertBrand(brandModel);
                MessageBox.Show("Thêm Thành Công");
                dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvThuongHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvThuongHieu.Rows[e.RowIndex];
                txtMaThuongHieu.Text = row.Cells[0].Value.ToString();
                txtTenThuongHieu.Text = row.Cells[1].Value.ToString();
                rtbDiaChi.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSuaThuongHieu_Click(object sender, EventArgs e)
        {
            try
            {
                BrandModel brandModel = new BrandModel();
                brandModel.Id = int.Parse(txtMaThuongHieu.Text);
                brandModel.Name = txtTenThuongHieu.Text;
                brandModel.Address = rtbDiaChi.Text;
                BrandBus.UpdateBrand(brandModel);
                MessageBox.Show("Cập nhật Thành Công");
                dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaThuongHieu_Click(object sender, EventArgs e)
        {
            try
            {
                BrandModel brandModel = new BrandModel();
                brandModel.Id = int.Parse(txtMaThuongHieu.Text);
                brandModel.Name = txtTenThuongHieu.Text;
                brandModel.Address = rtbDiaChi.Text;
                BrandBus.DeleteBrand(brandModel.Id);
                MessageBox.Show("Xóa Thành Công");
                dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
