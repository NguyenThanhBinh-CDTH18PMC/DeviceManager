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
    public class BrandDAOBase
    {
        public static DataTable getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllBrand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void InsertBrand(BrandModel brand)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertBrand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = brand.Name;
            cmd.Parameters["@Address"].Value = brand.Address;
            //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            //cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateBrand(BrandModel brand)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateBrand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Id"].Value = brand.Id;
            cmd.Parameters["@Name"].Value = brand.Name;
            cmd.Parameters["@Address"].Value = brand.Address;
            //cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            //cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            //cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            //cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteBrand(int id)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("DeleteBrand", conn);
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
