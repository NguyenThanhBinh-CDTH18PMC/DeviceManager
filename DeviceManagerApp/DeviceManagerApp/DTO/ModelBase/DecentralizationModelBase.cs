using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeviceManagerApp.DTO.ModelBase
{
    public class DecentralizationModelBase
    {
        public static int Id { get; set; }
        public static int UserId { get; set; }
        public static int TeacherId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
