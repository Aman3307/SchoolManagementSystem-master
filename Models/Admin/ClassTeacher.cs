using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Admin
{
    public class ClassTeacher
    {
        public int ClassTeacherId { get; set; }
        public int StaffId { get; set; }
        public int ClassId { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOnDate { get; set; }
    }
}
