using SchoolManagementSystem.Models.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Interface
{
    public interface ITeacherRepositary
    {
        // HwCw methods
        Task<List<HwCw>> FindHwCwByClassId(int classId);
        Task<List<HwCw>> FindHwCwBySectionId(int sectionId);
        Task<int> CreateHwCw(HwCw hwCw);
        Task<bool> EditHwCw(HwCw hwCw);

        // Student Achievement methods
        Task<StudentAchievement> FindStudentAchievementByStudentId(int studentId);
        Task<StudentAchievement> FindStudentAchievementByClassId(int classId);
        Task<StudentAchievement> FindStudentAchievementBySectionId(int sectionId);
        Task<int> CreateStudentAchievement(StudentAchievement studentAchievement);
        Task<List<StudentAchievement>> GetAllStudentAchievements( );
        Task<bool> EditStudentAchievement(StudentAchievement studentAchievement);

        // Student Attendance methods
        Task<List<StudentAttendance>> FindStudentAttendanceByStudentId(int studentId);
        Task<List<StudentAttendance>> FindStudentAttendanceByClassId(int classId);
        Task<List<StudentAttendance>> FindStudentAttendanceBySectionId(int sectionId);
        Task<int> CreateStudentAttendance(StudentAttendance studentAttendance);
        Task<List<StudentAttendance>> GetAllStudentAttendance( );
        Task<bool> EditStudentAttendance(StudentAttendance studentAttendance);

        // Student Marks methods
        Task<StudentMarks> FindStudentMarksByStudentId(int studentId);
        Task<StudentMarks> FindStudentMarksByClassId(int classId);
        Task<StudentMarks> FindStudentMarksBySectionId(int sectionId);
        Task<int> CreateStudentMarks(StudentMarks studentMarks);
        Task<List<StudentMarks>> GetAllStudentMarks();
        Task<bool> EditStudentMarks(StudentMarks studentMarks);

        // Student Remarks methods
        Task<StudentRemarks> FindStudentRemarksByStudentId(int studentId);
        Task<StudentRemarks> FindStudentRemarksByClassId(int classId);
        Task<StudentRemarks> FindStudentRemarksBySectionId(int sectionId);
        Task<int> CreateStudentRemarks(StudentRemarks studentRemarks);
        Task<List<StudentRemarks>> GetAllStudentRemarks();
        Task<bool> EditStudentRemarks(StudentRemarks studentRemarks);
    }
}
