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
    public partial class frmShipment : Form
    {

        public frmShipment()
        {
            InitializeComponent();
            dtgv_Shipment.AutoGenerateColumns = false;
        }
        #region Model

        private List<ShipmentModel> listShipment = null;
        private List<ShipmentDetailModel> listShipmentDetails = null;

        #endregion


        #region Load form

        private void Setting()
        {
            
        }

        private void LoadForm()
        {
            LoadShipmentSource();
            LoadComboboxBrand();
        }

        private void LoadShipmentSource()
        {

        }

        private void LoadComboboxBrand()
        {

        }

        private void LoadShipmentDetailSource()
        {

        }

        #endregion

        #region Create and Update Shipment

        #endregion

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void tab_Shipment_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
