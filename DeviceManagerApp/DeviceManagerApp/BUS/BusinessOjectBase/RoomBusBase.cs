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
    public class RoomBusBase
    {
        public static DataTable GetAllRoom()
        {
            return RoomDAO.getData();
        }
        public static void InSertRoom(RoomModel room)
        {
            RoomDAO.InsertRoom(room);
        }
        public static void UpdateRoom(RoomModel room)
        {
            RoomDAO.UpdateRoom(room);
        }
        public static void DeleteRoom(string code)
        {
            RoomDAO.DeleteRoom(code);
        }
    }
}
