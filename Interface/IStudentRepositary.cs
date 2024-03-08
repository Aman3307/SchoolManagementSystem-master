using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Models.Student;
using SchoolManagementSystem.Models.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Interface
{
    public interface IStudentRepositary
    {
        // Complain methods
        Task<int> CreateComplainByStudent(ComplainByStudent complain);
        Task<bool> EditComplainByStudent(ComplainByStudent complain);
        Task<ComplainByStudent> FindComplainByStudentId(int studentId);
        Task<bool> DeleteComplainByStudentId(int studentId);

        // FeesUpdateByStudent methods
        Task<int> CreateFeesUpdateByStudent(FeesUpdateByStudent feesUpdate);
        Task<bool> EditFeesUpdateByStudent(FeesUpdateByStudent feesUpdate);
        Task<bool> DeleteFeesUpdateByStudentId(int studentId);
        Task<FeesUpdateByStudent> FindFeesUpdateByStudentByStudentId(int studentId);
        Task<FeesUpdateByStudent> FindFeesUpdateByStudentByUTRNo(string utrNo);

        // Student Marks methods
        Task<StudentMarks> FindStudentMarksByStudentId(int studentId);

        // HwCw methods
        Task<List<HwCw>> FindHwCwBySectionId(int sectionId);

        // Student Achievement methods
        Task<StudentAchievement> FindStudentAchievementByStudentId(int studentId);

        // Student Attendance methods
        Task<List<StudentAttendance>> FindStudentAttendanceByStudentId(int studentId);

        // Student Remarks methods
        Task<StudentRemarks> FindStudentRemarksByStudentId(int studentId);

        // GenerateFeesForStudent methods
        Task<GenerateFeesForStudent> FindGenerateFeesForStudentByStudentId(int studentId);

        // ApprovalOfFees methods
        Task<ApprovalOfFees> FindApprovalOfFeesByStudentId(int studentId);

        // StudentDetails methods
        Task<StudentDetails> FindStudentDetailsByStudentId(int studentId);
    }
}
