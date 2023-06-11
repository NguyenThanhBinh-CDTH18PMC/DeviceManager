using BUS.BusinessObjectBase;
using DAO.DataLayer;
using DeviceManagerApp.BUS.BusinessOjectBase;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagerApp.BUS.BusinessObject
{
    public class DeviceType_SpecsBus : DeviceType_SpecsBusBase
    {
        public static bool InsertOrUpdate(List<DeviceType_SpecsModel> listDeviceType_Specs, bool isUpdate)
        {
            foreach (DeviceType_SpecsModel dp in listDeviceType_Specs)
            {
                try
                {
                    if (isUpdate)
                    {
                        DeviceType_SpecsDataLayer.Update(dp);
                    }
                    else
                    {
                        DeviceType_SpecsDataLayer.Insert(dp);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi Insert/Update/n" + e.Message);
                    return false;
                }
            }
            MessageBox.Show("Thành Công");
            return true;
        }
    }
}
