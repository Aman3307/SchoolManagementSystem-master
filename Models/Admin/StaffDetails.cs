using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Admin
{
    public class StaffDetails
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string ContactNumber { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public decimal NetSalary { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
