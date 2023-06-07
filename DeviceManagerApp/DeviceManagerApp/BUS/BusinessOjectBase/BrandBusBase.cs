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
    public class BrandBusBase
    {
        public static DataTable GetAllBrand()
        {
            return BrandDAO.getData();
        }
        public static void InsertBrand(BrandModel brand)
        {
            BrandDAO.InsertBrand(brand);
        }
        public static void UpdateBrand(BrandModel brand)
        {
            BrandDAO.UpdateBrand(brand);
        }
        public static void DeleteBrand(int id) { 
            BrandDAO.DeleteBrand(id);
        }
    }
}
