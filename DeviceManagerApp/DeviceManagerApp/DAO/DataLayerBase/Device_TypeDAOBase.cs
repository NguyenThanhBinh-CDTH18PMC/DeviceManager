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

namespace DeviceManagerApp.DAO.DataLayerBase
{
    public class Device_TypeDAOBase
    {
        public static DataTable getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllDevice_Type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertDevice_Type(Device_TypeModel device_Type)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertDevice_type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Id"].Value = device_Type.Id;
            cmd.Parameters["@Name"].Value = device_Type.Name;
            cmd.Parameters["@Description"].Value = device_Type.Description;
            //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            //cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpDateDevice_Type(Device_TypeModel device_Type)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateDevice_Type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Id"].Value = device_Type.Id;
            cmd.Parameters["@Name"].Value = device_Type.Name;
            cmd.Parameters["@Description"].Value = device_Type.Description;
            //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            //cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteDevice_Type(int id)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("DeleteDevice_Type", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters["@Id"].Value = id;
            //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            //cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
