using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Common
{
    public class StudentDetails
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string LocalGuardianName { get; set; }
        public string LocalGuardianRelation { get; set; }
        public string FatherContactDetails { get; set; }
        public string MotherContactDetails { get; set; }
        public string LocalGuardianContactDetails { get; set; }
        public string LocalAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Class { get; set; }
        public int ClassId { get; set; }
        public string Section { get; set; }
        public int SectionId { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime Date { get; set; }
    }
}
