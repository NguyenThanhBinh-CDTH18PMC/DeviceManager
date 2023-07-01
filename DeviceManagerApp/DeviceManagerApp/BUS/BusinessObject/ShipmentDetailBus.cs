
﻿using DeviceManagerApp.BUS.BusinessOjectBase;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using System;
using System.Collections.Generic;

namespace DeviceManagerApp.BUS.BusinessObject
{
    public class ShipmentDetailBus : ShipmentDetailBusBase
    {

        public static List<ShipmentDetailModel> SelectDeviceInfoAndCollectByShipmentId(int shipmentId)
        {
            return ShipmentDetailDataLayer.SelectDeviceInfoAndCollectByShipmentId(shipmentId);
        }
    }
}
