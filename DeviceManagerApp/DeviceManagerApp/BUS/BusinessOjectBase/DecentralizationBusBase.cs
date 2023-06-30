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
    public class DecentralizationBusBase
    {
        public static DataTable GetAllDecentralization()
        {
            return DecentralizationDAO.GetData();
        }

        public static UserModel GetUserByUserName_Pass(string UserName,string Pass)
        {
            DataTable user=DecentralizationDAO.GetUserByUserName_Pass(UserName, Pass);
            if(user.Rows.Count > 0)
            {
                DataRow userRow = user.Rows[0];
                UserModel userModel = new UserModel
                {
                    Id = Convert.ToInt32(userRow["Id"]),
                    UserName = userRow["UserName"].ToString(),
                    Pass = userRow["Pass"].ToString(),
                    Name = userRow["Name"].ToString(),
                };
                return userModel;
            }return null;
        }
        public static bool CheckUserId(int UserId)
        {
            DataTable userTable=DecentralizationDAO.CheckUserId(UserId);
            return userTable.Rows.Count > 0;
        }
        public static int GetStatusByUserId(int UserId)
        {
            return DecentralizationDAO.GetStatusByUserId(UserId);
        }
        public static UserModel GetInfoById(int UserId)
        {
            return DecentralizationDAO.GetInfoById(UserId);
        }
    }
}
