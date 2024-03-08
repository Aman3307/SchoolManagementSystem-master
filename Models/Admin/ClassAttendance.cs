using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Admin
{
    public class ClassAttendance
    {
        public int AttendanceId { get; set; }
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
        public int TotalStudents { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOnDate { get; set; }
    }
}
