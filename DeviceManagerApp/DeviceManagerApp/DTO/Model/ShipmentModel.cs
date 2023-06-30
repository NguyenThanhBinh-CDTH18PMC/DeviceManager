using DeviceManagerApp.DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceManagerApp.DTO.Model
{
    public class ShipmentModel : ShipmentModelBase
    {
        public ShipmentModel() { }

        public string Person { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
