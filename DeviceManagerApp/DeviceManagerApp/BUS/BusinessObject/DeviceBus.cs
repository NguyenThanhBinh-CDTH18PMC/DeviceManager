using BUS.BusinessObjectBase;
using DAO.DataLayer;
using DeviceManagerApp.BUS.BusinessOjectBase;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagerApp.BUS.BusinessObject
{
    public class DeviceBus : DeviceBusBase
    {
        public static List<DeviceModel> GetAllDeviceUnUsing(int quantity)
        {
            return DeviceDataLayer.GetAllDeviceUnUsing(quantity);
        }

        public static List<DeviceModel> GetAllDeviceInRoom(int roomId)
        {
            List<DeviceModel> list = DeviceDataLayer.GetAllDeviceInRoom(roomId);
            if(list.Count > 0)
            {
                foreach(DeviceModel d in list)
                {
                    try
                    {
                        LocationModel lm = LocationBus.SelectByPrimaryKey(d.LocationId.Value);
                        d.LocationName = lm.Name;
                    }
                    catch(Exception ex)
                    {
                        d.LocationName = "Trong";
                    }
                }
            }
            return list;
        }

    }
}
