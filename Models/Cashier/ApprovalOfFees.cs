using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Cashier
{
    public class ApprovalOfFees
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int FeesId { get; set; }
        public string UTR { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
