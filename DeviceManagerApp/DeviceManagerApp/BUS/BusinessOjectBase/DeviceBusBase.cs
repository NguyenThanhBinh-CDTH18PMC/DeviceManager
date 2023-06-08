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
    public class DeviceBusBase : DeviceModel
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceModel SelectByPrimaryKey(int id)
        {
            return DeviceDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the PBill table
        /// </summary>
        public static int GetRecordCount()
        {
            return DeviceDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the PBill table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, int? brandId, /*int? shipmentId,*/ string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceDataLayer.GetRecordCountDynamicWhere(id, deviceTypeId, brandId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return DeviceDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? brandId, /*int? shipmentId,*/ string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, deviceTypeId, brandId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, brandId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? brandId, /*int? shipmentId,*/ string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, brandId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of PBill
        /// </summary>
        public static List<DeviceModel> SelectAll()
        {
            return DeviceDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of PBill sorted by the sort expression
        /// </summary>
        public static List<DeviceModel> SelectAll(string sortExpression)
        {
            List<DeviceModel> objPBillCol = DeviceDataLayer.SelectAll();
            return objPBillCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of PBill.
        /// </summary>
        public static List<DeviceModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? brandId, /*int? shipmentId,*/ string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return DeviceDataLayer.SelectAllDynamicWhere(id, deviceTypeId, brandId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of PBill sorted by the sort expression.
        /// </summary>
        public static List<DeviceModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? brandId, /*int? shipmentId,*/ string name, string image, string qr_code, decimal? price, string note, string description, DateTime? warrantyPeriod, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status, string sortExpression)
        {
            List<DeviceModel> objPBillCol = DeviceDataLayer.SelectAllDynamicWhere(id, deviceTypeId, brandId, name, image, qr_code, price, note, description, warrantyPeriod, createdDate, createdUserId, isDeleted, status);
            return objPBillCol;
        }

        /// <summary>
        /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
        /// </summary>
        public static List<DeviceModel> SelectPBillDropDownListData()
        {
            return DeviceDataLayer.SelectSpecsDropDownListData();
        }

        private string generated_BillCode()
        {
            string mahd = "B";
            for (int i = 0; i < 4; i++)
            {
                Random a = new Random();
                mahd += (char)(a.Next(65, 90));

            }
            for (int j = 0; j < 4; j++)
            {
                int numBill = GetRecordCount();
                if (numBill < 10)
                {
                    mahd += "000" + numBill;
                    break;
                }
                if (numBill < 100)
                {
                    mahd += "00" + numBill;
                    break;
                }
                if (numBill < 100)
                {
                    mahd += "0" + numBill;
                    break;
                }
                else mahd += numBill;
                break;
            }
            return "hd";
        }
        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(DeviceModel bill)
        {
            DeviceModel objPBill = bill;
            return DeviceDataLayer.Insert(objPBill);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceModel bill)
        {
            DeviceModel objPBill = bill;
            DeviceDataLayer.Update(objPBill);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            DeviceDataLayer.Delete(id);
        }

        private static string GetSortExpression(string sortByExpression)
        {
            if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                sortByExpression = "Id";
            else if (sortByExpression.Contains(" asc"))
                sortByExpression = sortByExpression.Replace(" asc", "");

            return sortByExpression;
        }

    }
}
