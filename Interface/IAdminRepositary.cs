using SchoolManagementSystem.Models.Admin;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Interface
{
    public interface IAdminRepositary
    {
        // Class Attendance
        IEnumerable<Models.Admin.ClassAttendance> GetClassAttendanceList();
        ClassAttendance FindClassAttendanceByClassId(int classId);
        ClassAttendance CreateClassAttendance(ClassAttendance classAttendance);
        ClassAttendance EditClassAttendance(ClassAttendance classAttendance);

        // Class Teacher
        ClassTeacher FindClassTeacherByClassTeacherId(int classTeacherId);
        ClassTeacher FindClassTeacherByStaffId(int staffId);
        IEnumerable<ClassTeacher> FindClassTeacherByClassId(int classId);
        void CreateClassTeacher(ClassTeacher classTeacher);
        IEnumerable<ClassTeacher> ListAllClassTeachers();
        void EditClassTeacher(ClassTeacher classTeacher);
        void DeleteClassTeacher(int classTeacherId);

        // Section Attendance
        IEnumerable<SectionAttendance> GetSectionAttendanceList();
        SectionAttendance FindSectionAttendanceBySectionId(int sectionId);
        SectionAttendance CreateSectionAttendance(SectionAttendance sectionAttendance);
        SectionAttendance EditSectionAttendance(SectionAttendance sectionAttendance);

        // Section Teacher
        SectionTeacher FindSectionTeacherBySectionTeacherId(int sectionTeacherId);
        SectionTeacher FindSectionTeacherByStaffId(int staffId);
        IEnumerable<SectionTeacher> FindSectionTeacherBySectionId(int sectionId);
        void CreateSectionTeacher(SectionTeacher sectionTeacher);
        IEnumerable<SectionTeacher> ListAllSectionTeachers();
        void EditSectionTeacher(SectionTeacher sectionTeacher);
        void DeleteSectionTeacher(int sectionTeacherId);

        // Staff Attendance
        IEnumerable<StaffAttendance> GetStaffAttendanceList();
        StaffAttendance FindStaffAttendanceByStaffId(int staffId);

        // Staff Details
        void CreateStaffDetails(StaffDetails staffDetails);
        void EditStaffDetails(StaffDetails staffDetails);
        void DeleteStaffDetails(int staffId);
        IEnumerable<StaffDetails> GetAllStaffDetails();
        StaffDetails FindStaffByStaffId(int staffId);

        // Subject Teacher
        SubjectTeacher FindSubjectTeacherByStaffId(int staffId);
        IEnumerable<SubjectTeacher> FindSubjectTeacherByClassId(int classId);
        IEnumerable<SubjectTeacher> FindSubjectTeacherBySectionId(int sectionId);
        SubjectTeacher FindSubjectTeacherBySubjectName(string subjectName);
        void CreateSubjectTeacher(SubjectTeacher subjectTeacher);
        void EditSubjectTeacher(SubjectTeacher subjectTeacher);
        void DeleteSubjectTeacher(int subjectTeacherId);


        //Staff Salary

        StaffSalary FindStaffSalaryByStaffId(int staffId);

        // Generate Fees
        GenerateFeesForStudent FindGenerateFeesForStudentByClassId(int classId);
        GenerateFeesForStudent FindGenerateFeesForStudentBySectionId(int sectionId);
        GenerateFeesForStudent FindGenerateFeesForStudentByStudentId(int studentId);
        GenerateFeesForStudent FindGenerateFeesForStudentByFeesId(int feesId);


        //Approval of fees
        ApprovalOfFees FindApprovalOfFeesByStudentId(int studentId);
        IEnumerable<ApprovalOfFees> FindApprovalOfFeesByClassId(int classId);
        IEnumerable<ApprovalOfFees> FindApprovalOfFeesBySectionId(int sectionId);
        ApprovalOfFees FindApprovalOfFeesByFeesId(int feesId);
        ApprovalOfFees FindApprovalOfFeesByUTR(string utr);

        // Class methods
        Task<int> CreateClass(Class classObj);
        Task<Class> FindClassByClassId(int classId);
        Task<bool> UpdateClass(Class classObj);
        Task<bool> DeleteClass(int classId);
        Task<List<Class>> ListAllClasses();

        // Section methods
        Task<int> CreateSection(Section section);
        Task<Section> FindSectionBySectionId(int sectionId);
        Task<Section> FindSectionByClassId(int classId);
        Task<bool> UpdateSection(Section section);
        Task<bool> DeleteSection(int sectionId);
        Task<List<Section>> GetAllSections();

        // StudentDetails methods
        Task<int> CreateStudentDetails(StudentDetails studentDetails);
        Task<StudentDetails> FindStudentDetailsById(int studentId);
        Task<StudentDetails> FindStudentDetailsByClassId(int classId);
        Task<StudentDetails> FindStudentDetailsBySectionId(int sectionId);
        Task<bool> UpdateStudentDetails(StudentDetails studentDetails);
        Task<bool> DeleteStudentDetails(int studentId, int classId, int sectionId);
        Task<List<StudentDetails>> GetAllStudentDetails();
    }

}
