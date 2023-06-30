using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO.ModelBase;
using System.Data.SqlClient;
using DAO;
using DeviceManagerApp.DAO.DataLayer;
using ZXing.QrCode.Internal;
using DeviceManagerApp.DTO.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DeviceManagerApp.DAO.DataLayerBase
{
    public class DecentralizationDAOBase
    {
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllDecentralization", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable GetUserByUserName_Pass(string UserName,string Pass)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                
                using (SqlCommand command = new SqlCommand("[dbo].[GetUserByUserName_Pass]", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", UserName);
                    command.Parameters.AddWithValue("@Pass", Pass);
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static DataTable CheckUserId(int UserId)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[dbo].[CheckUserId]", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", UserId);
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static int GetStatusByUserId(int UserId)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("[dbo].[GetStatusByUserId]", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", UserId);
                    conn.Open();
                    object result= command.ExecuteScalar();
                    if(result != null || result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }return -1;
        }

        public static UserModel GetInfoById(int UserId)
        {
            UserModel user = null;
            using(SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd=new SqlCommand("[dbo].[GetInfoByUserId]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read()) {
                            int Id=reader.GetInt32(0);
                            string UserName=reader.GetString(1);
                            string Name=reader.GetString(2);

                            user = new UserModel
                            {
                                Id = Id,
                                UserName = UserName,
                                Name = Name,
                            };
                        }
                    }
                }
            }return user;
        }
    }
}
