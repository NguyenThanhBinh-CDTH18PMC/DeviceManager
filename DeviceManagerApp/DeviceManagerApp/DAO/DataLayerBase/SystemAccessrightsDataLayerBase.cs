using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataLayerBase
{
     /// <summary>
     /// Base class for SystemAccessrightsDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemAccessrightsDataLayer class
     /// </summary>
     public class SystemAccessrightsDataLayerBase
     {
         // constructor
         public SystemAccessrightsDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemAccessrightsModel SelectByPrimaryKey(int id)
         {
              SystemAccessrightsModel objSystemAccessrights = null;
              string storedProcName = "[dbo].[SystemAccessrights_SelectByPrimaryKey]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // parameters
                      command.Parameters.AddWithValue("@id", id);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrights = CreateSystemAccessrightsFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrights;
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrights table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemAccessrights_GetRecordCount]", null, null, true, null);
         }

         public static int GetRecordCountShared(string storedProcName = null, string param = null, object paramValue = null, bool isUseStoredProc = true, string dynamicSqlScript = null)
         {
              int recordCount = 0;

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  recordCount = (int)dt.Rows[0]["RecordCount"];
                              }
                          }
                      }
                  }
              }

              return recordCount;
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrights table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemAccessrights_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  recordCount = (int)dt.Rows[0]["RecordCount"];
                              }
                          }
                      }
                  }
              }

              return recordCount;
         }

         /// <summary>
         /// Selects SystemAccessrights records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemAccessrights_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemAccessrights records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSkipAndTakeDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemAccessrightsModel> objSystemAccessrightsCol = null;
              string storedProcName = "[dbo].[SystemAccessrights_SelectSkipAndTakeWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // select, skip, take, sort parameters
                      command.Parameters.AddWithValue("@start", startRowIndex);
                      command.Parameters.AddWithValue("@numberOfRows", rows);
                      command.Parameters.AddWithValue("@sortByExpression", sortByExpression);

                      // search parameters
                      AddSearchCommandParamsShared(command, id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsCol = new List<SystemAccessrightsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsModel objSystemAccessrights = CreateSystemAccessrightsFromDataRowShared(dr);
                                      objSystemAccessrightsCol.Add(objSystemAccessrights);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsCol;
         }

         /// <summary>
         /// Selects all SystemAccessrights
         /// </summary>
         public static List<SystemAccessrightsModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemAccessrights_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrights.
         /// </summary>
         public static List<SystemAccessrightsModel> SelectAllDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<SystemAccessrightsModel> objSystemAccessrightsCol = null;
              string storedProcName = "[dbo].[SystemAccessrights_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsCol = new List<SystemAccessrightsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsModel objSystemAccessrights = CreateSystemAccessrightsFromDataRowShared(dr);
                                      objSystemAccessrightsCol.Add(objSystemAccessrights);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSystemAccessrightsDropDownListData()
         {
            List<SystemAccessrightsModel> objSystemAccessrightsCol = null;
              string storedProcName = "[dbo].[SystemAccessrights_SelectDropDownListData]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsCol = new List<SystemAccessrightsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsModel objSystemAccessrights = new SystemAccessrightsModel();
                                      objSystemAccessrights.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objSystemAccessrights.Name = (string)(dr["Name"]);
                                      else
                                          objSystemAccessrights.Name = null;

                                      objSystemAccessrightsCol.Add(objSystemAccessrights);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsCol;
         }

         public static List<SystemAccessrightsModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemAccessrightsModel> objSystemAccessrightsCol = null;

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // select, skip, take, sort parameters
                      if (!String.IsNullOrEmpty(sortByExpression) && startRowIndex != null && rows != null)
                      {
                          command.Parameters.AddWithValue("@start", startRowIndex.Value);
                          command.Parameters.AddWithValue("@numberOfRows", rows.Value);
                          command.Parameters.AddWithValue("@sortByExpression", sortByExpression);
                      }

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsCol = new List<SystemAccessrightsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsModel objSystemAccessrights = CreateSystemAccessrightsFromDataRowShared(dr);
                                      objSystemAccessrightsCol.Add(objSystemAccessrights);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemAccessrightsModel objSystemAccessrights)
         {
             string storedProcName = "[dbo].[SystemAccessrights_Insert]";
             return InsertUpdate(objSystemAccessrights, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemAccessrightsModel objSystemAccessrights)
         {
             string storedProcName = "[dbo].[SystemAccessrights_Update]";
             InsertUpdate(objSystemAccessrights, true, storedProcName);
         }

         private static int InsertUpdate(SystemAccessrightsModel objSystemAccessrights, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemAccessrights.Id;

              object code = objSystemAccessrights.Code;
              object name = objSystemAccessrights.Name;
              object createdDate = objSystemAccessrights.CreatedDate;
              object modifiedDate = objSystemAccessrights.ModifiedDate;
              object createdUserId = objSystemAccessrights.CreatedUserId;
              object modifiedUserId = objSystemAccessrights.ModifiedUserId;
              object status = objSystemAccessrights.Status;

              if (objSystemAccessrights.Code == null)
                  code = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemAccessrights.Name))
                  name = System.DBNull.Value;

              if (objSystemAccessrights.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemAccessrights.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemAccessrights.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemAccessrights.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objSystemAccessrights.Status == null)
                  status = System.DBNull.Value;

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // parameters
                      if (isUpdate)
                      {
                          // for update only
                          command.Parameters.AddWithValue("@id", objSystemAccessrights.Id);
                      }

                      command.Parameters.AddWithValue("@code", code);
                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemAccessrights.IsDeleted);
                      command.Parameters.AddWithValue("@status", status);

                      if (isUpdate)
                          command.ExecuteNonQuery();
                      else
                          newlyCreatedId = (int)command.ExecuteScalar();
                  }
              }

              return newlyCreatedId;
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
              string storedProcName = "[dbo].[SystemAccessrights_Delete]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // parameters
                      command.Parameters.AddWithValue("@id", id);

                      // execute
                      command.ExecuteNonQuery();
                  }
              }
         }

         /// <summary>
         /// Adds search parameters to the Command object
         /// </summary>
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(code != null)
                  command.Parameters.AddWithValue("@code", code);
              else
                  command.Parameters.AddWithValue("@code", System.DBNull.Value);

              if(!String.IsNullOrEmpty(name))
                  command.Parameters.AddWithValue("@name", name);
              else
                  command.Parameters.AddWithValue("@name", System.DBNull.Value);

              if(createdDate != null)
                  command.Parameters.AddWithValue("@createdDate", createdDate);
              else
                  command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

              if(modifiedDate != null)
                  command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
              else
                  command.Parameters.AddWithValue("@modifiedDate", System.DBNull.Value);

              if(createdUserId != null)
                  command.Parameters.AddWithValue("@createdUserId", createdUserId);
              else
                  command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

              if(modifiedUserId != null)
                  command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
              else
                  command.Parameters.AddWithValue("@modifiedUserId", System.DBNull.Value);

              if(isDeleted != null)
                  command.Parameters.AddWithValue("@isDeleted", isDeleted);
              else
                  command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

              if(status != null)
                  command.Parameters.AddWithValue("@status", status);
              else
                  command.Parameters.AddWithValue("@status", System.DBNull.Value);

         }

         /// <summary>
         /// Creates a SystemAccessrights object from the passed data row
         /// </summary>
         private static SystemAccessrightsModel CreateSystemAccessrightsFromDataRowShared(DataRow dr)
         {
             SystemAccessrightsModel objSystemAccessrights = new SystemAccessrightsModel();

             objSystemAccessrights.Id = (int)dr["Id"];

             if (dr["Code"] != System.DBNull.Value)
                 objSystemAccessrights.Code = (int)dr["Code"];
             else
                 objSystemAccessrights.Code = null;

             if (dr["Name"] != System.DBNull.Value)
                 objSystemAccessrights.Name = dr["Name"].ToString();
             else
                 objSystemAccessrights.Name = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemAccessrights.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemAccessrights.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemAccessrights.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemAccessrights.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemAccessrights.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemAccessrights.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemAccessrights.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemAccessrights.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemAccessrights.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemAccessrights.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objSystemAccessrights.Status = (int)dr["Status"];
             else
                 objSystemAccessrights.Status = null;

             return objSystemAccessrights;
         }
     }
}
