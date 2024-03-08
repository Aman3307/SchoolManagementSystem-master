using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SchoolManagementSystem.Models.Cashier
{
    public class Revenue
    {
        public int RevenueId { get; set; }
        public decimal RevenueGenerated { get; set; }
        public decimal RevenueReceived { get; set; }
        public decimal RevenueYetToReceived { get; set; }
        public decimal RevenueSpent { get; set; }
        public decimal LoanTaken { get; set; }
        public decimal LoanPaid { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int RevenueUptoWeek { get; set; } // Use 0 for Monthly entries
        public string MonthName { get; set; } // Use null for Weekly entries
    }
}
