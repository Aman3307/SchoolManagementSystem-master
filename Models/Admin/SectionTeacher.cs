using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Admin
{
    public class SectionTeacher
    {
        public int SectionTeacherId { get; set; }
        public int StaffId { get; set; }
        public int SectionId { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOnDate { get; set; }
    }
}
