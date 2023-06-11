using DAO.DataLayer;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using DTO.Model;
using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagerApp.BUS.BusinessOjectBase
{
    public class Device_TypeBusBase
    {
        public static DataTable getAllDevice_Type()
        {
            return Device_TypeDao.getData();
        }

        public static Device_TypeModel SelectByPrimaryKey(int id)
        {
            return Device_TypeDao.SelectByPrimaryKey(id);
        }

        public static List<Device_TypeModel> SelectSpecsDropDownListData()
        {
            return Device_TypeDao.SelectDeviceTypeDropDownListData();
        }

        public static void InsertDevice_Type(Device_TypeModel device_Type) 
        {
            Device_TypeDao.InsertDevice_Type(device_Type);
        }
        public static void UpdateDevice_Type(Device_TypeModel device_Type)
        {
            Device_TypeDao.UpDateDevice_Type(device_Type);
        }
        public static void DeleteDevice_Type(int id)
        {
            Device_TypeDao.DeleteDevice_Type(id);
        }
    }
}
