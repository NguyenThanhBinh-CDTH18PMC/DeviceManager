
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO.Model;
using BUS.BusinessObject;
using DeviceManagerApp.DTO.Model;
using DeviceManagerApp.BUS.BusinessObject;
using System.Drawing.Imaging;
using QRCoder;

namespace DeviceManagerApp
{
    public partial class frmQuanLyThietBi : Form
    {
        public frmQuanLyThietBi()
        {
            InitializeComponent();
            //tkql = tkdn;
            Setting();
            Load_Source();
            Load_Form();
        }

        private UserModel tkql;
        //Các cài đặt mặt định của form


        //Khai báo các class lấy dl cho form
        List<DeviceModel> listDevice = null;
        DeviceModel currentDevice = null;

        ////Khai báo biến lưu trữ tạm cho form
        BindingSource bs = new BindingSource();


        #region Load

        private void Setting()
        {
            dtgvQlThietBi.AutoGenerateColumns = false;
            dtgvQlThietBi.AllowUserToAddRows = false;
            txtPrice.Text = "0.0";
        }


        public void ActionReset(int req)
        {
            if (req == 1)
            {
                Load_Source();
            }
            if (req == 2)
            {

            }
        }

        private void Load_Form()
        {
            LoadDataGridView();
            Load_Source();
        }

        private void Load_Source()
        {
            cbLoaiTbi.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();
            cbLoaiTbi.DisplayMember = "Name";
            cbLoaiTbi.ValueMember = "Id";

            cbKhoa.DataSource = FacultyBus.SelectAllDynamicWhere(null, null, null, null, null, null,false);
            cbKhoa.DisplayMember = "Name";
            cbKhoa.ValueMember = "Id";

            cbPhong.DataSource = RoomBus.GetRoomAfterDelete();
            cbPhong.DisplayMember = "Name";
            cbPhong.ValueMember = "Id";

            //cbNhaCungCap.DataSource = BrandBus.GetAllBrand();
            cbNhaCungCap.DataSource = BrandBus.GetBrandAfterDelete();

            cbNhaCungCap.DisplayMember = "Name";
            cbNhaCungCap.ValueMember = "Id";
        }

        private void LoadDataGridView()
        {

            listDevice = DeviceBus.SelectSkipAndTakeDynamicWhere(null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, 10, 0, "Id desc");
            if (listDevice != null)
            {
                foreach (DeviceModel device in listDevice)
                {
                    device.deviceDetail = DeviceDetailBus.SelectAllDynamicWhere(null, device.Id, null, null, null, null, null, null, null, false, null);
                    if (device.deviceDetail == null)
                    {
                        device.deviceDetail = new List<DeviceDetailModel>();
                    }

                }
            }
            else
                listDevice = new List<DeviceModel>();
            ReLoadDataGridView(listDevice);
        }

        private void ReLoadDataGridView(List<DeviceModel> listData)
        {
            bs.DataSource = listData.ToList();
            dtgvQlThietBi.DataSource = bs;
        }

        public void UploadImage()
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            //Khoi tao thiet lap cho dialog
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = open.OpenFile()) != null)
                {
                    ptb_Device.Image = Image.FromStream(stream);
                }
                stream.Close();
                stream.Dispose();
                GC.Collect();

            }
        }


        #endregion

        #region Event




        private void btOrder_Click(object sender, EventArgs e)
        {
            //Order od = new Order(nvBUS.LayNV(tkql.maTK));
            //od.actiondevices += Od_actiondevices;
            //od.ShowDialog();
        }

        //private void Od_actiondevices(object sender, ActiondevicesSuccessEventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    Load_Source();
        //    Load_Form();
        //}

        //Xử lý trong form - tab Quản lý bàn
        //BanBUS tables = new BanBUS();
        //List<BanDTO> dsBan = new List<BanDTO>();






        private void QuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (constans.TB_Close())
            //{
            //    this.Dispose();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
            this.Dispose();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            //ResetDS();
            //Reset();
        }

        private void btn_Xem_Click_1(object sender, EventArgs e)
        {

        }


        private void dtgvQlThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvQlThietBi.SelectedCells.Count > 0)
            {
                int deviceId = (int)dtgvQlThietBi.SelectedCells[0].OwningRow.Cells["DeviceId"].Value;
                foreach (DeviceModel de in listDevice)
                {
                    if (de.Id == deviceId)
                    {
                        cbLoaiTbi.SelectedValue = de.DeviceTypeId;
                        //cbPhong.SelectedValue = de.Room;
                        cbNhaCungCap.SelectedValue = de.BrandId;
                        dtBaoHanh.Value = de.WarrantyPeriod.HasValue ? de.WarrantyPeriod.Value : DateTime.Now;
                        dtp_DateBuy.Value = de.CreatedDate.Value;
                        txtPrice.Text = de.Price.ToString();
                        txtTenTbi.Text = de.Name;
                        //img_QR_Code.Image = de.QR_Code;

                        currentDevice = de;
                        return;
                    }
                }

            }
        }


        #endregion

        #region Create Device

        private void btnThemTbi_Click(object sender, EventArgs e)
        {
            if (Check_Null())
                return;

            DeviceModel device = new DeviceModel();
            device.Name = txtTenTbi.Text;
            device.DeviceTypeId = (int)cbLoaiTbi.SelectedValue;
            device.BrandId = (int)cbNhaCungCap.SelectedValue;
            device.ShipmentId = 1; // test
            device.FacultyId = (int)cbKhoa.SelectedValue;
            device.Note = rtbGhiChuTbi.Text;
            device.IsDeleted = false;
            device.Price = Convert.ToDecimal(txtPrice.Text);
            device.Status = 0;
            device.WarrantyPeriod = dtBaoHanh.Value;
            device.CreatedDate = DateTime.Now;
            device.CreatedUserId = 1;

            try
            {
                device.Image = SaveImage(device.Name, SettingClass.path_Folder_Image_Device, device.CreatedDate.Value);
                device.Id = DeviceBus.Insert(device);
                //device.QR_Code = SaveQR_Code(SettingClass.path_Folder_QR_Image, device);
                //DeviceBus.Update(device);
                AddSpecsByType(device.DeviceTypeId, device.Id);
                MessageBox.Show("Thành công! Vui lòng cập nhật thông số chi tiết thiết bị sớm!", "Thông Báo", MessageBoxButtons.OK);
                listDevice.Add(DeviceBus.SelectByPrimaryKey(device.Id));
                ReLoadDataGridView(listDevice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại! Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }

        }

        private string SaveImage(string fileName, string path, DateTime createdDate)
        {
            string fileSaveName = ((createdDate.ToString().Replace("/", "-")).Replace(":", "")).Replace(" ", "_") + "_" + fileName;
            ptb_Device.Image.Save(path + fileSaveName, ImageFormat.Jpeg);

            return fileSaveName;
        }

        private string SaveQR_Code(string path, DeviceModel device)
        {
            string fileSaveName = ((device.CreatedDate.ToString().Replace("/", "-")).Replace(":", "")).Replace(" ", "_") + "_QR_" + device.Id + "_" + device.Name;
            Image imageSave = Create_QR(DeviceInfo(device));
            imageSave.Save(path + fileSaveName, ImageFormat.Jpeg);
            return fileSaveName;
        }

        private string DeviceInfo(DeviceModel device)
        {
            string detail = "\n ";
            List<DeviceDetailModel> listDeviceDetail = DeviceDetailBus.SelectAllDynamicWhere(null, device.Id, null, null, null, null, null, null, null, null, null);
            foreach (DeviceDetailModel deviceDetail in listDeviceDetail)
            {
                detail += deviceDetail.NameSpecs + ": " + deviceDetail.Description + "\n";
            }
            string info = "Ngày tạo:" + device.CreatedDate.ToString() + "\n  Thiet bi: " + device.Name + detail;

            return info;
        }

        private Image Create_QR(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4);
            Image img = qrCodeImage;

            return img;
        }

        

        public void AddSpecsByType(int deviveTypeId, int deviceId)
        {
            List<DeviceType_SpecsModel> listSpecs = DeviceType_SpecsBus.SelectAllDynamicWhere(null, deviveTypeId, null, null, null, null, false);
            foreach (DeviceType_SpecsModel dtp in listSpecs)
            {
                DeviceDetailModel dtl = new DeviceDetailModel();
                dtl.DeviceId = deviceId;
                dtl.DeviceTypeSpecsId = dtp.Id;
                dtl.NameSpecs = SpecsBus.SelectByPrimaryKey(dtp.SpecsId).Name;
                dtl.CreatedDate = DateTime.Now;
                dtl.CreatedUserId = 1;
                dtl.Description = "";
                dtl.IsDeleted = false;
                dtl.Status = 0;
                try
                {
                    int kq = DeviceDetailBus.Insert(dtl);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thất bại! Lỗi " + e.Message, "Thông Báo", MessageBoxButtons.OK);
                    return;
                }

            }
        }

        #endregion


        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                Form f = new DeviceDetail(currentDevice);
                f.Show();
            }
        }

        

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private bool Check_Null()
        {
            if (txtTenTbi.Text.Trim() == "")
                return true;
            if (cbLoaiTbi.SelectedItem == null)
                return true;
            if (cbNhaCungCap.SelectedItem == null)
                return true;
            //if (cbKhoa.SelectedItem == null)
            //    return true;

            return false;
        }

        private void ptb_Device_DoubleClick(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            //Khoi tao thiet lap cho dialog
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = open.OpenFile()) != null)
                {
                    ptb_Device.Image = Image.FromStream(stream);
                }
                stream.Close();
                stream.Dispose();
                GC.Collect();

            }
        }

        
    }
}
