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
    public class DeviceType_SpecsBusBase : DeviceType_SpecsModel
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceType_SpecsBusBase()
        {
        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static DeviceType_SpecsModel SelectByPrimaryKey(int id)
        {
            return DeviceType_SpecsDataLayer.SelectByPrimaryKey(id);
        }

        /// <summary>
        /// Gets the total number of records in the PBill table
        /// </summary>
        public static int GetRecordCount()
        {
            return DeviceType_SpecsDataLayer.GetRecordCount();
        }

        /// <summary>
        /// Gets the total number of records in the PBill table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/)
        {
            return DeviceType_SpecsDataLayer.GetRecordCountDynamicWhere(id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCount();
            sortByExpression = GetSortExpression(sortByExpression);

            return DeviceType_SpecsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression starting from the startRowIndex.
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceType_SpecsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
        {
            totalRowCount = GetRecordCountDynamicWhere(id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted);
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceType_SpecsDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects records as a collection (List) of PBill sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectSkipAndTakeDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/, int rows, int startRowIndex, string sortByExpression)
        {
            sortByExpression = GetSortExpression(sortByExpression);
            return DeviceType_SpecsDataLayer.SelectSkipAndTakeDynamicWhere(id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects all records as a collection (List) of PBill
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAll()
        {
            return DeviceType_SpecsDataLayer.SelectAll();
        }

        /// <summary>
        /// Selects all records as a collection (List) of PBill sorted by the sort expression
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAll(string sortExpression)
        {
            List<DeviceType_SpecsModel> objPBillCol = DeviceType_SpecsDataLayer.SelectAll();
            return objPBillCol;
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of PBill.
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/)
        {
            return DeviceType_SpecsDataLayer.SelectAllDynamicWhere(id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted);
        }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of PBill sorted by the sort expression.
        /// </summary>
        public static List<DeviceType_SpecsModel> SelectAllDynamicWhere(int? id, int? deviceTypeId, int? deviceSpecsId, string description, DateTime? createdDate, int? createdUserId, bool? isDeleted/*, int? status*/, string sortExpression)
        {
            List<DeviceType_SpecsModel> objPBillCol = DeviceType_SpecsDataLayer.SelectAllDynamicWhere(id, deviceTypeId, deviceSpecsId, description, createdDate, createdUserId, isDeleted);
            return objPBillCol;
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
        public static int Insert(DeviceType_SpecsModel bill)
        {
            DeviceType_SpecsModel objPBill = bill;
            return DeviceType_SpecsDataLayer.Insert(objPBill);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(DeviceType_SpecsModel bill)
        {
            DeviceType_SpecsModel objPBill = bill;
            DeviceType_SpecsDataLayer.Update(objPBill);
        }

        /// <summary>
        /// Deletes a record based on primary key(s)
        /// </summary>
        public static void Delete(int id)
        {
            DeviceType_SpecsDataLayer.Delete(id);
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
