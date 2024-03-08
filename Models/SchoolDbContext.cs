using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Models.Teacher;
using SchoolManagementSystem.Models.Admin;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Student;

namespace SchoolManagementSystem.Data
{
    public class SchoolDbContext : DbContext
    {
        // Admin
        public DbSet<StaffAttendance> StaffAttendances { get; set; }
        public DbSet<SubjectTeacher> SubjectTeacher { get; set; }
        public DbSet<ClassTeacher> ClassTeacher { get; set; }
        public DbSet<SectionTeacher> SectionTeacher { get; set; }

        //Common
        public DbSet<User> Users { get; set; }
        public DbSet<StaffDetails> StaffDetails { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }
        public DbSet<SubjectTeacher> SubjectTeachers { get; set; }
        public DbSet<ClassTeacher> ClassTeachers { get; set; }
        public DbSet<SectionTeacher> SectionTeachers { get; set; }

        //Teacher
        public DbSet<StudentAttendance> Attendances { get; set; }
        public DbSet<HwCw> HwCws { get; set; }
        public DbSet<StudentAchievement> Achievements { get; set; }
        public DbSet<StudentRemarks> Remarks { get; set; }
        public DbSet<StudentMarks> StudentMarks { get; set; }

        // Cashier
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<StaffSalary> StaffSalary { get; set; } 

        public DbSet<GenerateFeesForStudent> GenerateFeesForStudents { get; set; }
        public DbSet<ApprovalOfFees> ApprovalOfFees { get; set; }

        //Student
        public DbSet<ComplainByStudent> ComplainByStudent { get; set; }
        public DbSet<FeesUpdateByStudent> FeesUpdateByStudent { get; set; }
        //

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("YourConnectionString");
        }
    }
}
