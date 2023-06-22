using BUS.BusinessObjectBase;
using DAO.DataLayer;
using DeviceManagerApp.BUS.BusinessOjectBase;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagerApp.BUS.BusinessObject
{
    public class SpecsBus : SpecsBusBase
    {
        public static List<SpecsModel> SelectAllSpecs_By_DeviceTypeId(int deviceTypeId, bool? isDeleted)
        {

            List<SpecsModel> listSpecs = SpecsDataLayer.SelectAllSpecs_By_DeviceTypeId(deviceTypeId, isDeleted);
            if (listSpecs == null)
                return new List<SpecsModel>();
            else
                return listSpecs;
        }
    }
}
