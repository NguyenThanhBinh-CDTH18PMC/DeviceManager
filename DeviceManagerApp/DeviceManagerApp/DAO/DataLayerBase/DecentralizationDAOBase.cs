﻿using DTO.Model;
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
        public static List<DecentralizationModel> GetData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("Decentralization_GetAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return CreateDecentralizationfromDataTable(dt);
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

        public static List<DecentralizationModel> CreateDecentralizationfromDataTable(DataTable dt)
        {
            List<DecentralizationModel> decentralizations = new List<DecentralizationModel>();
            if(dt != null )
            {
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        DecentralizationModel decentralizationModel = new DecentralizationModel();
                        decentralizationModel.Id = (int)dr["Id"];

                        if (dr["TeacherId"] != DBNull.Value)
                            decentralizationModel.TeacherId = (int)dr["TeacherId"];

                        if (dr["TeacherName"] != DBNull.Value)
                            decentralizationModel.TeacherName = dr["TeacherName"].ToString();
                        else decentralizationModel.TeacherName = null;

                        if (dr["TeacherGender"] != DBNull.Value)
                            decentralizationModel.TeacherGender = (bool)dr["TeacherGender"];
                        else decentralizationModel.TeacherGender = false;

                        if (dr["TeacherPhone"] != DBNull.Value)
                            decentralizationModel.TeacherPhone = dr["TeacherPhone"].ToString();
                        else decentralizationModel.TeacherPhone = null;

                        if (dr["TeacherBirth"] != DBNull.Value)
                            decentralizationModel.TeacherBirth = (DateTime)dr["TeacherBirth"];

                        if (dr["UserId"] != DBNull.Value)
                            decentralizationModel.UserId = (int)dr["UserId"];

                        if (dr["NameUser"] != DBNull.Value)
                            decentralizationModel.NameUser = dr["NameUser"].ToString();
                        else decentralizationModel.NameUser = null;

                        if (dr["CreatedDate"] != DBNull.Value)
                            decentralizationModel.CreatedDate = (DateTime)dr["CreatedDate"];
                        else decentralizationModel.CreatedDate = null;

                        if (dr["CreatedUserId"] != DBNull.Value)
                            decentralizationModel.CreatedUserId = (int)dr["CreatedUserId"];
                        else decentralizationModel.CreatedUserId = null;

                        if (dr["IsDeleted"] != DBNull.Value)
                            decentralizationModel.IsDeleted = (bool)dr["IsDeleted"];
                        else decentralizationModel.IsDeleted = false;
                        
                        decentralizations.Add(decentralizationModel);
                    }
                }
            }return decentralizations;
        }

        public static void InSertDecentralization(DecentralizationModel decentralizationModel)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("Insert_Decentralization", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId",decentralizationModel.UserId);
            cmd.Parameters.AddWithValue("@TeacherId",decentralizationModel.TeacherId);
            cmd.Parameters.AddWithValue("@CreatedDate", decentralizationModel.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", decentralizationModel.CreatedUserId);
            cmd.Parameters.AddWithValue("@IsDelete", decentralizationModel.IsDeleted);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool CheckTeacherId(int TeacherId)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from [System_Decentralization] where [TeacherId] = @TeacherId and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TeacherId", TeacherId);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                //kiểm tra
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool CheckIdUser(int UserId)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from [System_Decentralization] where [UserId] = @UserId and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserId", UserId);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                //kiểm tra
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
