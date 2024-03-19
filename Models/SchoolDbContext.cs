using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Models.Teacher;
using SchoolManagementSystem.Models.Admin;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Student;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace SchoolManagementSystem.Data
{
    public class SchoolDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        // Admin

        public DbSet<ClassAttendance> ClassAttendance { get; set; }
        public DbSet<ClassTeacher> ClassTeacher { get; set; }
        public DbSet<SectionAttendance> SectionAttendance { get; set; }
        public DbSet<SectionTeacher> SectionTeacher { get; set; }
        public DbSet<StaffAttendance> StaffAttendance { get; set; }
        public DbSet<StaffDetails> StaffDetails { get; set; }
        public DbSet<SubjectTeacher> SubjectTeacher { get; set; }



        // Cashier

        public DbSet<ApprovalOfFees> ApprovalOfFees { get; set; }
        public DbSet<GenerateFeesForStudent> GenerateFeesForStudent { get; set; }
        public DbSet<Revenue> Revenue { get; set; }
        public DbSet<StaffSalary> StaffSalary { get; set; }



        //Common

        public DbSet<Class> Class { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }



        //Student
        public DbSet<ComplainByStudent> ComplainByStudent { get; set; }
        public DbSet<FeesUpdateByStudent> FeesUpdateByStudent { get; set; }
        


        //Teacher
        public DbSet<StudentAttendance> StudentAttendance { get; set; }
        public DbSet<HwCw> HwCw { get; set; }
        public DbSet<StudentAchievement> StudentAchievement { get; set; }
        public DbSet<StudentRemarks> StudentRemark { get; set; }
        public DbSet<StudentMarks> StudentMarks { get; set; }





        public DbSet<User> User { get; set; }








        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SchoolDbContext"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Other configurations...

            modelBuilder.Entity<StaffDetails>()
                .Property(p => p.NetSalary)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ApprovalOfFees>()
                .Property(p => p.PaidAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ApprovalOfFees>()
                .Property(p => p.RemainingAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<GenerateFeesForStudent>()
                .Property(p => p.CurrentMonthFees)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<GenerateFeesForStudent>()
                .Property(p => p.LastRemaining)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<GenerateFeesForStudent>()
                .Property(p => p.TotalFees)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.NetSalary)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.PreviousRemaining)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.PaidAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.RemainingThisMonth)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.PaidUptoMonth)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StaffSalary>()
                .Property(p => p.AdvancePaid)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Revenue>()
                .Property(p => p.LoanPaid)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Revenue>()
                .Property(p => p.LoanTaken)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Revenue>()
                .Property(p => p.RevenueSpent)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Revenue>()
                .Property(p => p.RevenueYetToReceived)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Revenue>()
                .Property(p => p.RevenueReceived)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Revenue>()
                .Property(p => p.RevenueGenerated)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<FeesUpdateByStudent>()
                .Property(p => p.RemainingFees)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<FeesUpdateByStudent>()
                .Property(p => p.PaidFees)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<StudentMarks>()
                .Property(p => p.Percentage)
                .HasColumnType("decimal(18,2)");



            // Call the base OnModelCreating method to apply other configurations
            base.OnModelCreating(modelBuilder);
        }
    }
}
