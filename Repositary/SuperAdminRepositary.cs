﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Models.Admin;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Models.Student;
using SchoolManagementSystem.Models.Teacher;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repositary
{
    public class SuperAdminRepositary : ISuperAdminRepositary
    {
        private readonly SchoolDbContext _dbContext;
        private readonly string _connectionString;

        public SuperAdminRepositary(SchoolDbContext dbContext, string connectionString)
        {
            _dbContext = dbContext;
            _connectionString = connectionString;
        }

        public async Task<ClassAttendance> FindClassAttendanceByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<ClassAttendance>("sp_FindClassAttendanceByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<ClassAttendance>> GetAllClassAttendance()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ClassAttendance>("sp_GetAllClassAttendance", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<SectionAttendance> FindSectionAttendanceBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<SectionAttendance>("sp_FindSectionAttendanceBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<SectionAttendance>> GetAllSectionAttendance()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<SectionAttendance>("sp_GetAllSectionAttendance", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<ClassTeacher> FindClassTeacherByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<ClassTeacher>("sp_FindClassTeacherByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<ClassTeacher> FindClassTeacherByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<ClassTeacher>("sp_FindClassTeacherByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<SectionTeacher> FindSectionTeacherBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<SectionTeacher>("sp_FindSectionTeacherBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<SectionTeacher> FindSectionTeacherByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<SectionTeacher>("sp_FindSectionTeacherByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<SectionTeacher> FindSectionTeacherByClassId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<SectionTeacher>("sp_FindSectionTeacherBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<StaffAttendance>> GetAllStaffAttendance()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StaffAttendance>("sp_GetAllStaffAttendance", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<StaffAttendance> FindStaffAttendanceByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<StaffAttendance>("sp_FindStaffAttendanceByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<StaffDetails>> GetAllStaffDetails()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StaffDetails>("sp_GetAllStaffDetails", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<StaffDetails> FindStaffDetailsByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<StaffDetails>("sp_FindStaffDetailsByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<SubjectTeacher>> GetAllSubjectTeachers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<SubjectTeacher>("sp_GetAllSubjectTeachers", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<SubjectTeacher> FindSubjectTeacherByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<SubjectTeacher>("sp_FindSubjectTeacherByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<SubjectTeacher>> FindSubjectTeacherByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<SubjectTeacher>("sp_FindSubjectTeacherByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<SubjectTeacher>> FindSubjectTeacherBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<SubjectTeacher>("sp_FindSubjectTeacherBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<ApprovalOfFees>> GetAllApprovalOfFees()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ApprovalOfFees>("sp_GetAllApprovalOfFees", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<ApprovalOfFees> FindApprovalOfFeesByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<ApprovalOfFees>("sp_FindApprovalOfFeesByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<ApprovalOfFees>> FindApprovalOfFeesByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ApprovalOfFees>("sp_FindApprovalOfFeesByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<ApprovalOfFees>> FindApprovalOfFeesBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ApprovalOfFees>("sp_FindApprovalOfFeesBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<ApprovalOfFees>> FindApprovalOfFeesByUTR(string utr)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ApprovalOfFees>("sp_FindApprovalOfFeesByUTR", new { UTR = utr }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<GenerateFeesForStudent>> GetAllGenerateFeesForStudent()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<GenerateFeesForStudent>("sp_GetAllGenerateFeesForStudent", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<GenerateFeesForStudent> FindGenerateFeesForStudentByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<GenerateFeesForStudent>> FindGenerateFeesForStudentByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<GenerateFeesForStudent>> FindGenerateFeesForStudentBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<Revenue>> GetAllRevenue()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<Revenue>("sp_GetAllRevenue", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<Revenue> FindRevenueByRevenueId(int revenueId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<Revenue>("sp_FindRevenueByRevenueId", new { RevenueId = revenueId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<Class>> GetAllClasses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<Class>("sp_GetAllClasses", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<Class> FindClassByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<Class>("sp_FindClassByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        // Section methods
        public async Task<List<Section>> GetAllSections()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<Section>("sp_GetAllSections", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<Section>> FindSectionByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<Section>("sp_FindSectionByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<Section> FindSectionBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<Section>("sp_FindSectionBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        // Student details methods
        public async Task<List<StudentDetails>> GetAllStudentDetails()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentDetails>("sp_GetAllStudentDetails", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<StudentDetails> FindStudentByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<StudentDetails>("sp_FindStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<StudentDetails>> FindStudentByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentDetails>("sp_FindStudentByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentDetails>> FindStudentBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentDetails>("sp_FindStudentBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // Complain by student methods
        public async Task<List<ComplainByStudent>> GetAllComplainByStudent()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ComplainByStudent>("sp_GetAllComplainByStudent", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<ComplainByStudent> FindComplainByStudentByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<ComplainByStudent>("sp_FindComplainByStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<ComplainByStudent>> FindComplainByStudentByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ComplainByStudent>("sp_FindComplainByStudentByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<ComplainByStudent>> FindComplainByStudentBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<ComplainByStudent>("sp_FindComplainByStudentBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // Fees update by students methods
        public async Task<List<FeesUpdateByStudent>> GetAllFeesUpdateByStudent()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_GetAllFeesUpdateByStudent", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<FeesUpdateByStudent> FindFeesUpdateByStudentByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentByUTR(string utr)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByUTR", new { UTR = utr }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // HwCw methods
        public async Task<List<HwCw>> GetAllHwCw()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HwCw>("sp_GetAllHwCw", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<HwCw>> FindHwCwByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HwCw>("sp_FindHwCwByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<HwCw>> FindHwCwBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<HwCw>("sp_FindHwCwBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // Student achievement methods
        public async Task<List<StudentAchievement>> GetAllStudentAchievements()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAchievement>("sp_GetAllStudentAchievements", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<StudentAchievement> FindStudentAchievementByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<StudentAchievement>("sp_FindStudentAchievementByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<StudentAchievement>> FindStudentAchievementByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAchievement>("sp_FindStudentAchievementByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentAchievement>> FindStudentAchievementBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAchievement>("sp_FindStudentAchievementBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // Student remarks methods
        public async Task<List<StudentRemarks>> GetAllStudentRemarks()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentRemarks>("sp_GetAllStudentRemarks", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentRemarks>> FindStudentRemarksByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentRemarks>("sp_FindStudentRemarksByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentRemarks>> FindStudentRemarksByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentRemarks>("sp_FindStudentRemarksByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentRemarks>> FindStudentRemarksBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentRemarks>("sp_FindStudentRemarksBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // Student attendance methods
        public async Task<List<StudentAttendance>> GetAllStudentAttendance()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAttendance>("sp_GetAllStudentAttendance", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentAttendance>> FindStudentAttendanceByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAttendance>("sp_FindStudentAttendanceByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentAttendance>> FindStudentAttendanceByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAttendance>("sp_FindStudentAttendanceByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentAttendance>> FindStudentAttendanceBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentAttendance>("sp_FindStudentAttendanceBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        // Student marks methods
        public async Task<List<StudentMarks>> GetAllStudentMarks()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentMarks>("sp_GetAllStudentMarks", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentMarks>> FindStudentMarksByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentMarks>("sp_FindStudentMarksByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentMarks>> FindStudentMarksByClassId(int classId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentMarks>("sp_FindStudentMarksByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<StudentMarks>> FindStudentMarksBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentMarks>("sp_FindStudentMarksBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}