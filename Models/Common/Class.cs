﻿using SchoolManagementSystem.Models.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Common
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int? ClassTeacherId { get; set; }
        public int? NumberOfSections { get; set; }
        public int? TotalStudents { get; set; }
        public int? UpdatedByStaffId { get; set; }
        public string UpdatedByStaffName { get; set; }
        public DateTime? UpdateOnDate { get; set; }

        
    }
}
