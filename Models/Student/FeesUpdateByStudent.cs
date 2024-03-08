using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Student
{
    public class FeesUpdateByStudent
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public string StudentName { get; set; }
        public decimal RemainingFees { get; set; }
        public decimal PaidFees { get; set; }
        public string UTRNo { get; set; }
        public int UpdatedByStudentId { get; set; }
        public string UpdatedByStudentName { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
