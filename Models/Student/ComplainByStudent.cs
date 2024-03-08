using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Student
{
    public class ComplainByStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public string ComplainAgainst { get; set; }
        public int UpdatedByStudentId { get; set; }
        public string UpdatedByStudentName { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
