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
    public partial class frmSetSpecsForDeviceType : Form
    {
        #region  model
        List<SpecsModel> listSpecs = null;
        Device_TypeModel currentType = null;
        int currentSpecsId = 0;
        BindingSource specsBS = new BindingSource();

        #endregion
        public frmSetSpecsForDeviceType()
        {
            InitializeComponent();
            Setting();
            currentType = new Device_TypeModel();
            currentType.Id = 1;
            listSpecs = SpecsBus.SelectAllSpecs_By_DeviceTypeId(currentType.Id, false);
            LoadForm();
        }

        public frmSetSpecsForDeviceType(Device_TypeModel deviceType)
        {
            InitializeComponent();
            currentType = deviceType;
            listSpecs = SpecsBus.SelectAllSpecs_By_DeviceTypeId(currentType.Id, false);
            LoadForm();
        }

        public void Setting()
        {
            dtgvListSpecs.AutoGenerateColumns = false;
            dtgvListSpecs.AllowUserToAddRows = false;
        }

        #region Load

        public void LoadForm()
        {
            LoadListSpecs();
            LoadDataSource(listSpecs);
        }

        public void LoadListSpecs()
        {
            List<SpecsModel> ds = SpecsBus.SelectAllDynamicWhere(null, null, null, null, null, null, null, false, null);
            cb_Specs.DataSource = ds;
            cb_Specs.DisplayMember = "Name";
            cb_Specs.ValueMember = "Id";
        }

        public void LoadDataSource(List<SpecsModel> list)
        {
            
            specsBS.DataSource = list.ToList();
            dtgvListSpecs.DataSource = specsBS;
        }

        #endregion

        #region Event Change form
        #endregion

        #region Add or Update Device Type Specs
        #endregion

        private void ckb_AddOther_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_AddOther.Checked)
            {
                cb_Specs.Enabled = false;
                txtNewSpecs.ReadOnly = false;
            }
            else
            {
                cb_Specs.Enabled = true;
                txtNewSpecs.ReadOnly = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (listSpecs == null)
                listSpecs = new List<SpecsModel>();
            if (ckb_AddOther.Checked)
            {
                if(txtNewSpecs.Text == "" || txtNewSpecs.Text.Replace(" ","") == "")
                {
                    return;
                }

                SpecsModel newSpecs = new SpecsModel();
                newSpecs.Name = txtNewSpecs.Text.Trim();
                newSpecs.CreatedDate = DateTime.Now;
                newSpecs.CreatedUserId = 1;
                int newSpecsId = SpecsBus.Insert(newSpecs);
                newSpecs.Id = newSpecsId;
                LoadListSpecs();
                listSpecs.Add(newSpecs);
                LoadDataSource(listSpecs);

            }
            else
            {
                SpecsModel objSpecs = ((SpecsModel)cb_Specs.SelectedItem);
                listSpecs.Add(objSpecs);
                LoadDataSource(listSpecs);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (listSpecs.Count > 0)
            {
                List<DeviceType_SpecsModel> listAdd = new List<DeviceType_SpecsModel>();
                foreach (SpecsModel spe in listSpecs)
                {
                    DeviceType_SpecsModel dsm = new DeviceType_SpecsModel();
                    dsm.DeviceTypeId = currentType.Id;
                    dsm.SpecsId = spe.Id;
                    dsm.SpecsName = spe.Name;
                    dsm.Ordinal = spe.Ordinal.Value;
                    dsm.IsDeleted = false;
                    dsm.Description = spe.Description;
                    dsm.CreatedDate = DateTime.Now;
                    dsm.CreatedUserId = 1; // dùng tạm
                    listAdd.Add(dsm);
                }
                DeviceType_SpecsBus.InsertOrUpdate(listAdd, false);
                listSpecs.Clear();
                LoadDataSource(listSpecs);
                return;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if(listSpecs.Count > 0)
            {
                foreach(SpecsModel spe in listSpecs)
                {
                    if(spe.Id == currentSpecsId)
                    {
                        listSpecs.Remove(spe);
                        LoadDataSource(listSpecs);
                        return;
                    }
                }
            }
        }

        private void dtgvListSpecs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListSpecs.SelectedCells.Count > 0 && listSpecs.Count() > 0)
            {
                if (dtgvListSpecs.SelectedCells[0].RowIndex < listSpecs.Count())
                {
                    int specsId = (int) dtgvListSpecs.SelectedCells[0].OwningRow.Cells["SpecsId"].Value;

                    currentSpecsId = specsId;
                }

            }

        }
    }
}
