using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Cashier
{
    public class GenerateFeesForStudent
    {
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        [Key]
        public int StudentId { get; set; }
        public int FeesId { get; set; }
        public decimal LastRemaining { get; set; }
        public decimal CurrentMonthFees { get; set; }
        public decimal TotalFees { get; set; }
        public int UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
