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
    public partial class DeviceDetail : Form
    {
        private DeviceModel device;

        List<DeviceDetailModel> listDetail = null;
        public DeviceDetail(DeviceModel de)
        {
            InitializeComponent();
            device = de;
            lb_DeviceName.Text = de.Name;
            //AddSpecsByType(de.DeviceTypeId, de.Id);
            listDetail = DeviceDetailBus.SelectAllDynamicWhere(null, de.Id, null, null, null, null, null, null, null, null, null);

            Load_Form();
            
        }

        #region Load

        public void Load_Form()
        {
            Load_Specs();
        }

        public void Load_Specs()
        {
            string description = "";
            foreach (DeviceDetailModel detail in listDetail)
            {
                description += detail.NameSpecs + ": " + detail.Description + ";";
                Label lb = new Label();
                lb.Font = new Font("Arial", 12f, FontStyle.Bold);
                lb.Text = detail.NameSpecs + ":";
                flp_ListSpecs.Controls.Add(lb);

                TextBox tbValue = new TextBox();
                tbValue.Name = "txt" + detail.NameSpecs;
                tbValue.Text = detail.Description;
                tbValue.Left = 50;
                tbValue.Font = new Font("Arial", 12f, FontStyle.Bold);
                tbValue.Width = 220;
                flp_ListSpecs.Controls.Add(tbValue);
            }
            txtDescription.Text = description;
        }

        public void Load_DeviceInfo()
        {
            string description = "";
            foreach (DeviceDetailModel dt in listDetail)
            {
                description += dt.NameSpecs + ": " + dt.Description+";";
            }
            txtDescription.Text = description;
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
