using DeviceManagerApp.DTO.ModelBase;
using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeviceManagerApp.DTO.Model
{
    public class DeviceType_SpecsModel : DeviceType_SpecsModelBase
    {
        public string BrandName { get; set; }
        public string DeviceName { get; set; }
        public DeviceType_SpecsModel() { }
    }
}
