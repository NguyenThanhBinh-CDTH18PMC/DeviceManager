
﻿using DeviceManagerApp.BUS.BusinessOjectBase;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using System;
using System.Collections.Generic;

namespace DeviceManagerApp.BUS.BusinessObject
{
    public class LocationBus : LocationBusBase
    {
         public static List<LocationModel> GetAllLocationUnUsing(int roomId)
        {
            return LocationDataLayer.GetAllLocationUnUsing(roomId);
        }
    }
}
