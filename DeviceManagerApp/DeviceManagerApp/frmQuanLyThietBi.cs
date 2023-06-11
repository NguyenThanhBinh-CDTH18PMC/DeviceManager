
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

        ////Khai báo biến lưu trữ tạm cho form
        BindingSource bs = new BindingSource();


        #region Load

        private void Setting()
        {
            dtgvQlThietBi.AutoGenerateColumns = false;
            dtgvQlThietBi.AllowUserToAddRows = false;
            //tb_mahd.ReadOnly = true;
            //tb_ngayLap.ReadOnly = true;
            //tb_sdt.ReadOnly = true;
            //tb_tenkh.ReadOnly = true;
            //tb_TT.ReadOnly = true;
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



        private void ResetDS()
        {
            int loai = 0;
            

            //Load_DSTB(DateTime.Now, loai);
        }

        private void Reset()
        {
            //tb_mahd.Text = "";
            //tb_ngayLap.Text = DateTime.Now + "";
            //tb_sdt.Text = "";
            //tb_tenkh.Text = "";
            //tb_nvl.Text = "";
            //tb_TT.Text = "";
            //ckb_khv.Checked = true;
        }

        private void Load_Form()
        {
            //DeviceModel b = Device.SelectByPrimaryKey(1);
            listDevice = DeviceBus.SelectSkipAndTakeDynamicWhere(null, null, null, null, null, null, null, null, null, null, null, null, false, null, 10, 0, "Id desc");
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
            bs.DataSource = listDevice.ToList();
            dtgvQlThietBi.DataSource = bs;
        }

        private void Load_Source()
        {
            cbLoaiTbi.DataSource = Device_TypeBus.getAllDevice_Type();
            cbLoaiTbi.DisplayMember = "Name";
            cbLoaiTbi.ValueMember = "Id";

            cbPhong.DataSource = RoomBus.GetAllRoom();
            cbPhong.DisplayMember = "Name";
            cbPhong.ValueMember = "Id";
            
            cbNhaCungCap.DataSource = BrandBus.GetAllBrand();
            cbNhaCungCap.DisplayMember = "Name";
            cbNhaCungCap.ValueMember = "Id";
        }


        #endregion

        #region Event

        //Xử lý trong form

        /*string path = "../../TRASUA";
        private void LoadImgList()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] fileInfo = dirInfo.GetFiles("*.jpg");

            foreach (FileInfo fInFo in fileInfo)
            {
                //Đọc tập tin hình -> byte
                byte[] bytes = File.ReadAllBytes(fInFo.FullName);
                MemoryStream mms = new MemoryStream(bytes);

                imgLargeIcon.Images.Add(fInFo.Name, Image.FromStream(mms));
                imgSmallIcon.Images.Add(fInFo.Name, Image.FromStream(mms));

            }
        }
        private void loadList1()
        {


                ListViewItem li = new ListViewItem(imgLargeIcon.Images.ToString());
                //listView1.Items.Add(li);

        }*/


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
            ResetDS();
            Reset();
        }

        private void btn_Xem_Click_1(object sender, EventArgs e)
        {
            //foreach (HoaDonDTO hd in dshd)
            //{
            //    if (hd.maHD == tb_mahd.Text)
            //    {
            //        Order od = new Order(hd, hd.nv_LapHD);
            //        od.ShowDialog();
            //    }
            //}
        }


        private void datgv_HD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (datgv_HD.SelectedCells.Count > 0 && dshd.Count() > 0)
            //{
            //    if (datgv_HD.SelectedCells[0].RowIndex < dshd.Count())
            //    {
            //        string mahd = datgv_HD.SelectedCells[0].OwningRow.Cells["col_mahd"].Value.ToString();
            //        foreach (HoaDonDTO hdD in dshd)
            //        {
            //            if (hdD.maHD == mahd)
            //            {
            //                tb_mahd.Text = hdD.maHD;
            //                tb_tenkh.Text = hdD.khachHang.tenKH;
            //                if (hdD.maKH.StartsWith("KHV"))
            //                    ckb_khv.Checked = true;
            //                else
            //                    ckb_khv.Checked = false;
            //                tb_sdt.Text = hdD.khachHang.sdt;
            //                tb_ngayLap.Text = hdD.ngayLap + "";
            //                tb_nvl.Text = NV.hoNV + " " + NV.tenNV;
            //                tb_TT.Text = hdD.tongThanhToan + "";
            //                break;
            //            }
            //        }
            //    }

            //}
        }


        #endregion
    }
}
