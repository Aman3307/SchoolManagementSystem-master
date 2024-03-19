using SchoolManagementSystem.Models.Admin;
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
    public interface ISuperAdminRepositary
    {
        // Class Attendance methods
        Task<ClassAttendance> FindClassAttendanceByClassId(int classId);
        Task<List<ClassAttendance>> GetAllClassAttendance();

        // Section Attendance methods
        Task<SectionAttendance> FindSectionAttendanceBySectionId(int sectionId);
        Task<List<SectionAttendance>> GetAllSectionAttendance();

        // Class Teacher methods
        Task<ClassTeacher> FindClassTeacherByStaffId(int staffId);
        Task<ClassTeacher> FindClassTeacherByClassId(int classId);
        IEnumerable<ClassTeacher> ListAllClassTeachers();

        // Section Teacher methods
        Task<SectionTeacher> FindSectionTeacherByStaffId(int staffId);
        Task<SectionTeacher> FindSectionTeacherBySectionId(int sectionId);
        IEnumerable<SectionTeacher> ListAllSectionTeachers();

        //Staff Attendance methods
        Task<List<StaffAttendance>> GetAllStaffAttendance();
        Task<StaffAttendance> FindStaffAttendanceByStaffId(int staffId);

        //staff details method
        Task<List<StaffDetails>> GetAllStaffDetails();
        Task<StaffDetails> FindStaffDetailsByStaffId(int staffId);

        //subject teacher methods
        Task<List<SubjectTeacher>> GetAllSubjectTeachers();
        Task<SubjectTeacher> FindSubjectTeacherByStaffId(int staffId);
        Task<List<SubjectTeacher>> FindSubjectTeacherByClassId(int classId);
        Task<List<SubjectTeacher>> FindSubjectTeacherBySectionId(int sectionId);

        //approval of fees method
        Task<List<ApprovalOfFees>> GetAllApprovalOfFees();
        Task<ApprovalOfFees> FindApprovalOfFeesByStudentId(int studentId);
        Task<List<ApprovalOfFees>> FindApprovalOfFeesByClassId(int classId);
        Task<List<ApprovalOfFees>> FindApprovalOfFeesBySectionId(int sectionId);
        Task<List<ApprovalOfFees>> FindApprovalOfFeesByUTR(string utr);

        //Generate Fee For students method
        Task<List<GenerateFeesForStudent>> GetAllGenerateFeesForStudent();
        Task<GenerateFeesForStudent> FindGenerateFeesForStudentByStudentId(int studentId);
        Task<List<GenerateFeesForStudent>> FindGenerateFeesForStudentByClassId(int classId);
        Task<List<GenerateFeesForStudent>> FindGenerateFeesForStudentBySectionId(int sectionId);

        //revenue method
        Task<List<Revenue>> GetAllRevenue();
        Task<Revenue> FindRevenueByRevenueId(int revenueId);

        //class methods
        Task<List<Class>> GetAllClasses();
        Task<Class> FindClassByClassId(int classId);

        
        //section methods
        Task<List<Section>> GetAllSections();
        Task<List<Section>> FindSectionByClassId(int classId);
        Task<Section> FindSectionBySectionId(int sectionId);

        //students details methods
        Task<List<StudentDetails>> GetAllStudentDetails();
        Task<StudentDetails> FindStudentByStudentId(int studentId);
        Task<List<StudentDetails>> FindStudentByClassId(int classId);
        Task<List<StudentDetails>> FindStudentBySectionId(int sectionId);

        //complain by student method
        Task<List<ComplainByStudent>> GetAllComplainByStudent();
        Task<ComplainByStudent> FindComplainByStudentByStudentId(int studentId);
        Task<List<ComplainByStudent>> FindComplainByStudentByClassId(int classId);
        Task<List<ComplainByStudent>> FindComplainByStudentBySectionId(int sectionId);

        //fees update by students methods
        Task<List<FeesUpdateByStudent>> GetAllFeesUpdateByStudent();
        Task<FeesUpdateByStudent> FindFeesUpdateByStudentByStudentId(int studentId);
        Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentByClassId(int classId);
        Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentBySectionId(int sectionId);
        Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentByUTR(string utr);

        //hwcw methods
        Task<List<HwCw>> GetAllHwCw();
        Task<List<HwCw>> FindHwCwByClassId(int classId);
        Task<List<HwCw>> FindHwCwBySectionId(int sectionId);

        //student achievment methods
        Task<List<StudentAchievement>> GetAllStudentAchievements();
        Task<StudentAchievement> FindStudentAchievementByStudentId(int studentId);
        Task<List<StudentAchievement>> FindStudentAchievementByClassId(int classId);
        Task<List<StudentAchievement>> FindStudentAchievementBySectionId(int sectionId);

        //student remarks methods
        Task<List<StudentRemarks>> GetAllStudentRemarks();
        Task<List<StudentRemarks>> FindStudentRemarksByStudentId(int studentId);
        Task<List<StudentRemarks>> FindStudentRemarksByClassId(int classId);
        Task<List<StudentRemarks>> FindStudentRemarksBySectionId(int sectionId);

        //student attendance methods
        Task<List<StudentAttendance>> GetAllStudentAttendance();
        Task<List<StudentAttendance>> FindStudentAttendanceByStudentId(int studentId);
        Task<List<StudentAttendance>> FindStudentAttendanceByClassId(int classId);
        Task<List<StudentAttendance>> FindStudentAttendanceBySectionId(int sectionId);

        //student marks methods
        Task<List<StudentMarks>> GetAllStudentMarks();
        Task<List<StudentMarks>> FindStudentMarksByStudentId(int studentId);
        Task<List<StudentMarks>> FindStudentMarksByClassId(int classId);
        Task<List<StudentMarks>> FindStudentMarksBySectionId(int sectionId);
    }
}
