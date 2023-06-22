using DeviceManagerApp.BUS.BusinessObject;
using DeviceManagerApp.DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceManagerApp
{
    public partial class DeviceDetail : Form
    {
        private DeviceModel device;

        List<DeviceDetailModel> listDetail = null;
        public DeviceDetail(DeviceModel de)
        {
            InitializeComponent();
            device = de;
            //AddSpecsByType(de.DeviceTypeId, de.Id);
            LoadListDetail();
            Load_Form();
            
        }

        #region Load

        public void Load_Form()
        {
            lb_DeviceName.Text = device.Name;
            if(listDetail.Count > 0)
            {
                cb_ListSpecs.SelectedIndex = listDetail[0].Id;
                txt_Description.Text = listDetail[0].Description;
            }
            Load_ComboboxSpecs();
        }

        private List<DeviceDetailModel> GetDetail(int deviceId)
        {
            return DeviceDetailBus.SelectAllDynamicWhere(null, deviceId, null, null, null, null, null, null, null, false, null);
        }

        public void Load_ComboboxSpecs()
        {
            cb_ListSpecs.DataSource = listDetail.ToList();
            cb_ListSpecs.ValueMember = "Id";
            cb_ListSpecs.DisplayMember = "NameSpecs";

            var cbData = (DataGridViewComboBoxColumn)dtgv_ListDetail.Columns["Specs"];
            cbData.DisplayMember = "NameSpecs";
            cbData.ValueMember = "Id";
            cbData.DataSource = listDetail;
        }

        private void LoadListDetail()
        {
            listDetail = GetDetail(device.Id);
        }

        public void Load_DeviceInfo()
        {
            string description = "";
            foreach (DeviceDetailModel dt in listDetail)
            {
                description += dt.NameSpecs + ": " + dt.Description+";";
            }
            //txtDescription.Text = description;
        }
        #endregion

        public void Setting()
        {
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            foreach (DeviceDetailModel dt in listDetail)
            {
                string name = "txt" + dt.NameSpecs;
                dt.Description = ((TextBox)this.Controls.Find(name, true)[0]).Text;
                try
                {
                    DeviceDetailBus.Update(dt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thất bại! Lỗi " + ex.Message);
                    return;
                }
            }
            MessageBox.Show("Thành công");
            Load_DeviceInfo();
        }
    }
}
