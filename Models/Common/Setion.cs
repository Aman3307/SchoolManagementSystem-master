using SchoolManagementSystem.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Common
{
    public class Section
    {
        public int SectionId { get; set; }
        public int? ClassId { get; set; }
        public string Class { get; set; }
        public string SectionName { get; set; }
        public int? TotalStudents { get; set; }
        public int? SectionTeacherId { get; set; }
        public int? UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime? UpdateOnDate { get; set; }

        // Navigation properties
        public StaffDetails SectionTeacher { get; set; }
    }
}
