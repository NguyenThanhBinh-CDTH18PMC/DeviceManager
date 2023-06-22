using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagerApp.DTO.ModelBase
{
    public class FacultyModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Image { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
       // public int? Status { get; set; }
    }
}
