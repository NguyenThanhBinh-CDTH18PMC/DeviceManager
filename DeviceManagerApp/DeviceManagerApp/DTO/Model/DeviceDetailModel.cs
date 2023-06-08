using DeviceManagerApp.DTO.ModelBase;
using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeviceManagerApp.DTO.Model
{
    public class DeviceDetailModel : DeviceDetailModelBase
    {
        public string DataType { get; set; }
        public DeviceDetailModel() { }
    }
}
