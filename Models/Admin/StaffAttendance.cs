using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Admin
{
    public class StaffAttendance
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime Date { get; set; }
        public string StatusOnDate { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
