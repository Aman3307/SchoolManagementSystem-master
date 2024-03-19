using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Cashier
{
    public class StaffSalary
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public decimal NetSalary { get; set; }
        public decimal PreviousRemaining { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingThisMonth { get; set; }
        public decimal PaidUptoMonth { get; set; }
        public decimal AdvancePaid { get; set; }
        public DateTime PaidOnDate { get; set; }
        public string UTR { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
