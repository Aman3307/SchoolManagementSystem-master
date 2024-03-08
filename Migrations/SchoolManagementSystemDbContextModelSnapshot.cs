﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolManagementSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SchoolManagementSystem.Models.ComplainByStudent", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplainAgainst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Post")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("ComplainsByStudent");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.FeeVerificationByCashier", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HostelFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LateFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MiscellaneousFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PaidUpto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RemainingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SchoolFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UtrNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("SId");

                    b.ToTable("FeeVerificationByCashiers");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.FeesUpdateByStudent", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeesUpto")
                        .HasColumnType("int");

                    b.Property<string>("Roll")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UtrNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("FeesUpdateByStudents");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.GrossRevenue", b =>
                {
                    b.Property<decimal>("Invested")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Received")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Week")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("YetToReceive")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("GrossRevenue");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StaffTable", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AbsentDays")
                        .HasColumnType("int");

                    b.Property<decimal>("Paid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PresentDays")
                        .HasColumnType("int");

                    b.Property<decimal>("Remaining")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StaffId");

                    b.ToTable("StaffTable");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Student", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StudentAchievements", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Achievement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AchievementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("StudentAchievements");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StudentAttendance", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DayWiseAttendanceWithStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalOpenedDays")
                        .HasColumnType("int");

                    b.Property<int>("TotalPresentDays")
                        .HasColumnType("int");

                    b.HasKey("SId");

                    b.ToTable("StudentAttendances");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StudentFees", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HostelFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LateFine")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MiscellaneousFess")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PaidUptoMonth")
                        .HasColumnType("int");

                    b.Property<decimal>("RemainingAmmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SchoolFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UtrNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("SId");

                    b.ToTable("StudentFees");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StudentMarks", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AdditionalSub1")
                        .HasColumnType("int");

                    b.Property<int>("AdditionalSub2")
                        .HasColumnType("int");

                    b.Property<int>("AdditionalSub3")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnglishMarks")
                        .HasColumnType("int");

                    b.Property<int>("HindiMarks")
                        .HasColumnType("int");

                    b.Property<int>("MathsMarks")
                        .HasColumnType("int");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SStMarks")
                        .HasColumnType("int");

                    b.Property<int>("ScienceMarks")
                        .HasColumnType("int");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SId");

                    b.ToTable("StudentMarks");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.StudentRemarks", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ByTeacher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ByTeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("StudentRemarks");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("JwtToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
