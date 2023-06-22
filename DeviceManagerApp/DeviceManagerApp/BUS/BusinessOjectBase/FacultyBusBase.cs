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
    public class FacultyBusBase
    {
        public static DataTable GetAllFaculty()
        {
            return FacultyDAO.getData();
        }
        public static void InsertFaculty(FacultyModel faculty)
        {
            if(FacultyDAO.CheckNameFaculty(faculty.Name))
            {
                throw new Exception("Tên Khoa Đã Tồn Tại");
            }
            else
            {
                FacultyDAO.InsertFaculty(faculty);
            }
        }
        public static void UpdateFaculty(FacultyModel facultyModel)
        {
            if (FacultyDAO.IsDuplicateFaculty(facultyModel, facultyModel.Id))
            {
                throw new Exception("Tên Khoa Đã Tồn Tại");
            }
            FacultyDAO.UpdateFaculty(facultyModel);
        }

        public static DataTable GetFacultyAfterDelete()
        {
            return FacultyDAO.GetFacultyAfterDelete();
        }
        public static void DeleteFaculty(int Id)
        {
            FacultyDAO.DeleteFaculty(Id);
        }
    }
}
