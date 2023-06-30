using DeviceManagerApp.DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceManagerApp.DTO.Model
{
    public class ShipmentDetailModel : ShipmentDetailModelBase
    {
        public ShipmentDetailModel() { }

        public string DeviceName { get; set; }
        public string Quantity { get; set; }
        public string DevicePrice { get; set; }
        public string TotalPrice { get; set; }
    }
}
