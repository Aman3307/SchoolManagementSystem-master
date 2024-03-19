using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Teacher
{
    public class StudentMarks
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int English { get; set; }
        public int Hindi { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int SocialStudies { get; set; }
        public int Computer { get; set; }
        public int Additional { get; set; }
        public int TotalMarks { get; set; }
        public int MarksScored { get; set; }
        public decimal Percentage { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOnDate { get; set; }
    }
}
