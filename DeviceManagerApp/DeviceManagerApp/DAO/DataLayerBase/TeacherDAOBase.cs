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
using System.Text.RegularExpressions;

namespace DeviceManagerApp.DAO.DataLayerBase
{
    public class TeacherDAOBase
    {
        public static List<TeacherModel> GetData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllTeachers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            conn.Close();
            return CreateTeachersModelfromDataTable(dt);
        }
        public static void InsertTeacher(TeacherModel teacher) 
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", teacher.FirstName);
            cmd.Parameters.AddWithValue("@LastName", teacher.LastName);
            cmd.Parameters.AddWithValue("@FullName", teacher.FullName);
            cmd.Parameters.AddWithValue("@Birth", teacher.Birth);
            cmd.Parameters.AddWithValue("@Gender", teacher.Gender);
            cmd.Parameters.AddWithValue("@Address", teacher.Address);
            cmd.Parameters.AddWithValue("@Phone", teacher.Phone);
            cmd.Parameters.AddWithValue("@Email", teacher.Email);
            cmd.Parameters.AddWithValue("@CreatedDate", teacher.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", teacher.CreatedUserId);
            cmd.Parameters.AddWithValue("@PositionId", teacher.PositionId);
            cmd.Parameters.AddWithValue("@IsDeleted", teacher.IsDeleted);
            cmd.Parameters.AddWithValue("@Status", teacher.Status);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateTeacher(TeacherModel teacher)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", teacher.Id);
            cmd.Parameters.AddWithValue("@FirstName", teacher.FirstName);
            cmd.Parameters.AddWithValue("@LastName", teacher.LastName);
            cmd.Parameters.AddWithValue("@FullName", teacher.FullName);
            cmd.Parameters.AddWithValue("@Birth", teacher.Birth);
            cmd.Parameters.AddWithValue("@Gender", teacher.Gender);
            cmd.Parameters.AddWithValue("@Address", teacher.Address);
            cmd.Parameters.AddWithValue("@Phone", teacher.Phone);
            cmd.Parameters.AddWithValue("@Email", teacher.Email);
            cmd.Parameters.AddWithValue("@CreatedDate", teacher.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", teacher.CreatedUserId);
            cmd.Parameters.AddWithValue("@PositionId", teacher.PositionId);
            cmd.Parameters.AddWithValue("@IsDeleted", teacher.IsDeleted);
            cmd.Parameters.AddWithValue("@Status", teacher.Status);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //kiểm tra họ Giáo viên có nhập số và không rỗng
        public static bool IsValidFirstName(string firstName)
            {
                if(string.IsNullOrEmpty(firstName)) return false;
                foreach(char c in firstName) 
                {
                    if (char.IsDigit(c))
                        return false;
                }
                return true;
            }
        //kiểm tra tên giáo viên có  nhập số và không rỗng
        public static bool IsValidLastName(string lastName)
        {
            if(string.IsNullOrEmpty(lastName)) return false;
            foreach (char c in lastName)
            {
                if (char.IsDigit(c))
                    return false;
            }
            return true;
        }
        //kiểm tra ngày sinh không được lớn hơn ngày hiện tại
        public static bool IsValidBirth(DateTime birth)
        {
            return birth <= DateTime.Now;
        }
        //kiểm tra nhập đúng định dạng email và không rỗng
        public static bool IsValidEmail(string email)
        {
            if(string.IsNullOrEmpty(email)) return false;
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        //kiểm tra số điện thoại phải nhập số và không rỗng
        public static bool IsValidPhone(string phone)
        {
            if(string.IsNullOrEmpty(phone)) return false;
            return Regex.IsMatch(phone, @"^[0-9]{10,10}$");
        }

        public static List<TeacherModel> GetTeachersAfterDelete()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetTeachersAfterDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return CreateTeachersModelfromDataTable(dt);
        }
        public static void DeleteTeacher(int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update S_Teacher set IsDeleted=1 where Id=@Id", conn);
                //cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static List<TeacherModel> CreateTeachersModelfromDataTable(DataTable dt)
        {
            List<TeacherModel> teacher = new List<TeacherModel>();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    
                    foreach (DataRow dr in dt.Rows)
                    {
                        TeacherModel teacherModel = new TeacherModel();
                        teacherModel.Id = (int)dr["Id"];
                        if (dr["FirstName"] != System.DBNull.Value)
                            teacherModel.FirstName = dr["FirstName"].ToString();
                        else teacherModel.FirstName = null;

                        if (dr["LastName"] != System.DBNull.Value)
                            teacherModel.LastName = dr["LastName"].ToString();
                        else teacherModel.LastName = null;
                        if (dr["FullName"] != System.DBNull.Value)
                            teacherModel.FullName = dr["FullName"].ToString();
                        else teacherModel.FullName = null;
                        if (dr["Birth"] != System.DBNull.Value)
                            teacherModel.Birth = (DateTime)dr["Birth"];
                        if (dr["Gender"] != System.DBNull.Value)
                            teacherModel.Gender = (bool)dr["Gender"];
                        else teacherModel.Gender = false;
                        if (dr["Address"] != System.DBNull.Value)
                            teacherModel.Address = dr["Address"].ToString();
                        else teacherModel.Address = null;
                        //if (dr["Image"] != System.DBNull.Value)
                        //    teacherModel.Image = dr["Image"].ToString();
                        //else teacherModel.Image = null;
                        if (dr["Phone"] != System.DBNull.Value)
                            teacherModel.Phone = dr["Phone"].ToString();
                        else teacherModel.Phone = null;

                        if (dr["Email"] != System.DBNull.Value)
                            teacherModel.Email = dr["Email"].ToString();
                        else teacherModel.Email = null;

                        if (dr["CreatedDate"] != System.DBNull.Value)
                            teacherModel.CreatedDate = (DateTime)dr["CreatedDate"];
                        else teacherModel.CreatedDate = null;

                        if (dr["CreatedUserId"] != System.DBNull.Value)
                            teacherModel.CreatedUserId = (int)dr["CreatedUserId"];
                        else teacherModel.CreatedUserId = null;

                        if (dr["PositionId"] != System.DBNull.Value)
                            teacherModel.PositionId = (int)dr["PositionId"];

                        if (dr["PositionName"] != System.DBNull.Value)
                            teacherModel.PositionName = dr["PositionName"].ToString();
                        else teacherModel.PositionName = null;

                        if (dr["IsDeleted"] != System.DBNull.Value)
                            teacherModel.IsDeleted = (bool)dr["IsDeleted"];
                        else teacherModel.IsDeleted = false;

                        if (dr["Status"] != System.DBNull.Value)
                            teacherModel.Status = (int)dr["Status"];
                        else teacherModel.Status = null;

                        teacher.Add(teacherModel);
                    }
                    
                }
            }
            return teacher;
        }

        public static DataTable SearchTeacherByFirstName(string FirstName) {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchTeacherByFirstName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        public static DataTable SearchTeacherByLastName(string LastName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchTeacherByLastName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LastName", LastName);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        public static DataTable SearchTeacherByPhone(string Phone)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchTeacherByPhone", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Phone", Phone);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
    }
}
