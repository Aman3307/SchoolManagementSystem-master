using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Admin
{
    public class SubjectTeacher
    {
        public int StaffId { get; set; }
        public string TeacherName { get; set; }
        public string Subject { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOnDate { get; set; }
    }
}

