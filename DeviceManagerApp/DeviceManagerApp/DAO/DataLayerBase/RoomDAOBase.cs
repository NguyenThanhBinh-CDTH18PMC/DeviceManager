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
    public class RoomDAOBase
    {
        public static DataTable getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllRoom",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da= new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt=new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
     
       
        
        public static void InsertRoom(RoomModel room)
        {
                SqlConnection conn = new SqlConnection(PathString.ConnectionString);
                SqlCommand cmd = new SqlCommand("InsertRoom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@DeviceQuantity", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
                cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
                cmd.Parameters["@Code"].Value = room.Code;
                cmd.Parameters["@Name"].Value = room.Name;
                cmd.Parameters["@Description"].Value = room.Description;
                cmd.Parameters["@DeviceQuantity"].Value = room.DeviceQuantity;
                //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
                //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
                //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
                //cmd.Parameters["@Status"].Value = room.Status;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        public static void UpdateRoom(RoomModel room)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateRoom", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@DeviceQuantity", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Code"].Value = room.Code;
            cmd.Parameters["@Name"].Value = room.Name;
            cmd.Parameters["@Description"].Value = room.Description;
            cmd.Parameters["@DeviceQuantity"].Value = room.DeviceQuantity;
            //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            //cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteRoom(string Code)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("DeleteRoom", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar,50);
            cmd.Parameters["@Code"].Value = Code;   
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
