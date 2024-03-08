using Dapper;
using Microsoft.Extensions.Configuration;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Admin;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Common;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repositary
{
    public class AdminRepositary : IAdminRepositary
    {
        private readonly IConfiguration _configuration;
        private readonly string ConnectionString;

        public AdminRepositary(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("SchoolDbContext");
        }

        public IEnumerable<ClassAttendance> GetClassAttendanceList()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<ClassAttendance>("sp_GetClassAttendanceList", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public ClassAttendance FindClassAttendanceByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<ClassAttendance>("sp_FindClassAttendanceByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public ClassTeacher FindClassTeacherByClassTeacherId(int classTeacherId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<ClassTeacher>("sp_FindClassTeacherByClassTeacherId", new { ClassTeacherId = classTeacherId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public ClassTeacher FindClassTeacherByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<ClassTeacher>("sp_FindClassTeacherByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<ClassTeacher> FindClassTeacherByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<ClassTeacher>("sp_FindClassTeacherByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void CreateClassTeacher(ClassTeacher classTeacher)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Use Dapper to execute the stored procedure for creating class teacher
                connection.Execute("sp_CreateClassTeacher",
                    new
                    {
                        StaffId = classTeacher.StaffId,
                        ClassId = classTeacher.ClassId,
                        UpdatedByStaffId = classTeacher.UpdatedByStaffId,
                        UpdatedByStaffName = classTeacher.UpdatedByStaffName,
                        UpdateOnDate = classTeacher.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }


        public IEnumerable<ClassTeacher> ListAllClassTeachers()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<ClassTeacher>("sp_ListAllClassTeachers", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void EditClassTeacher(ClassTeacher classTeacher)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Use Dapper to execute the stored procedure for editing class teacher
                connection.Execute("sp_EditClassTeacher",
                    new
                    {
                        ClassTeacherId = classTeacher.ClassTeacherId,
                        StaffId = classTeacher.StaffId,
                        ClassId = classTeacher.ClassId,
                        UpdatedByStaffId = classTeacher.UpdatedByStaffId,
                        UpdatedByStaffName = classTeacher.UpdatedByStaffName,
                        UpdateOnDate = classTeacher.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteClassTeacher(int classTeacherId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Use Dapper to execute the stored procedure for deleting class teacher
                connection.Execute("sp_DeleteClassTeacher",
                    new
                    {
                        ClassTeacherId = classTeacherId
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }


        IEnumerable<ClassAttendance> IAdminRepositary.GetClassAttendanceList()
        {
            throw new System.NotImplementedException();
        }

        ClassAttendance IAdminRepositary.FindClassAttendanceByClassId(int classId)
        {
            throw new System.NotImplementedException();
        }

        ClassTeacher IAdminRepositary.FindClassTeacherByClassTeacherId(int classTeacherId)
        {
            throw new System.NotImplementedException();
        }

        ClassTeacher IAdminRepositary.FindClassTeacherByStaffId(int staffId)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<ClassTeacher> IAdminRepositary.FindClassTeacherByClassId(int classId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SectionAttendance> GetSectionAttendanceList()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<SectionAttendance>("sp_GetSectionAttendanceList", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public SectionAttendance FindSectionAttendanceBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<SectionAttendance>("sp_FindSectionAttendanceBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public SectionTeacher FindSectionTeacherBySectionTeacherId(int sectionTeacherId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<SectionTeacher>("sp_FindSectionTeacherBySectionTeacherId", new { SectionTeacherId = sectionTeacherId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public SectionTeacher FindSectionTeacherByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<SectionTeacher>("sp_FindSectionTeacherByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<SectionTeacher> FindSectionTeacherBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<SectionTeacher>("sp_FindSectionTeacherBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void CreateSectionTeacher(SectionTeacher sectionTeacher)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Implement the procedure call to create section teacher
                connection.Execute("sp_CreateSectionTeacher",
                    new
                    {
                        StaffId = sectionTeacher.StaffId,
                        SectionId = sectionTeacher.SectionId,
                        UpdatedByStaffId = sectionTeacher.UpdatedByStaffId,
                        UpdatedByStaffName = sectionTeacher.UpdatedByStaffName,
                        UpdateOnDate = sectionTeacher.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<SectionTeacher> ListAllSectionTeachers()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<SectionTeacher>("sp_ListAllSectionTeachers", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void EditSectionTeacher(SectionTeacher sectionTeacher)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Implement the procedure call to edit section teacher
                connection.Execute("sp_EditSectionTeacher",
                    new
                    {
                        SectionTeacherId = sectionTeacher.SectionTeacherId,
                        StaffId = sectionTeacher.StaffId,
                        SectionId = sectionTeacher.SectionId,
                        UpdatedByStaffId = sectionTeacher.UpdatedByStaffId,
                        UpdatedByStaffName = sectionTeacher.UpdatedByStaffName,
                        UpdateOnDate = sectionTeacher.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSectionTeacher(int sectionTeacherId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Implement the procedure call to delete section teacher
                connection.Execute("sp_DeleteSectionTeacher",
                    new
                    {
                        SectionTeacherId = sectionTeacherId
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public IEnumerable<StaffAttendance> GetStaffAttendanceList()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<StaffAttendance>("sp_GetStaffAttendanceList", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public StaffAttendance FindStaffAttendanceByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<StaffAttendance>("sp_FindStaffAttendanceByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void CreateStaffDetails(StaffDetails staffDetails)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("sp_CreateStaffDetails", staffDetails, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditStaffDetails(StaffDetails staffDetails)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("sp_EditStaffDetails", staffDetails, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteStaffDetails(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("sp_DeleteStaffDetails", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<StaffDetails> GetAllStaffDetails()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<StaffDetails>("sp_GetAllStaffDetails", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public StaffDetails FindStaffByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<StaffDetails>("sp_FindStaffByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public SubjectTeacher FindSubjectTeacherByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<SubjectTeacher>("sp_FindSubjectTeacherByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<SubjectTeacher> FindSubjectTeacherByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<SubjectTeacher>("sp_FindSubjectTeacherByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<SubjectTeacher> FindSubjectTeacherBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<SubjectTeacher>("sp_FindSubjectTeacherBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public SubjectTeacher FindSubjectTeacherBySubjectName(string subjectName)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<SubjectTeacher>("sp_FindSubjectTeacherBySubjectName", new { SubjectName = subjectName }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void CreateSubjectTeacher(SubjectTeacher subjectTeacher)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("sp_CreateSubjectTeacher",
                    new
                    {
                        StaffId = subjectTeacher.StaffId,
                        SubjectId = subjectTeacher.TeacherName,
                        UpdatedByStaffId = subjectTeacher.UpdatedByStaffId,
                        UpdatedByStaffName = subjectTeacher.UpdatedByStaffName,
                        UpdateOnDate = subjectTeacher.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void EditSubjectTeacher(SubjectTeacher subjectTeacher)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("sp_EditSubjectTeacher",
                    new
                    {
                        SubjectTeacherId = subjectTeacher.TeacherName,
                        StaffId = subjectTeacher.StaffId,
                        SubjectId = subjectTeacher.TeacherName,
                        UpdatedByStaffId = subjectTeacher.UpdatedByStaffId,
                        UpdatedByStaffName = subjectTeacher.UpdatedByStaffName,
                        UpdateOnDate = subjectTeacher.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteSubjectTeacher(int subjectTeacherId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("sp_DeleteSubjectTeacher",
                    new
                    {
                        SubjectTeacherId = subjectTeacherId
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public StaffSalary FindStaffSalaryByStaffId(int staffId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<StaffSalary>("sp_FindStaffSalaryByStaffId", new { StaffId = staffId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentByFeesId(int feesId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByFeesId", new { FeesId = feesId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public ApprovalOfFees FindApprovalOfFeesByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<ApprovalOfFees>("sp_FindApprovalOfFeesByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<ApprovalOfFees> FindApprovalOfFeesByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<ApprovalOfFees> FindApprovalOfFeesBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public ApprovalOfFees FindApprovalOfFeesByFeesId(int feesId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<ApprovalOfFees>("sp_FindApprovalOfFeesByFeesId", new { FeesId = feesId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public ApprovalOfFees FindApprovalOfFeesByUTR(string utr)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<ApprovalOfFees>("sp_FindApprovalOfFeesByUTR", new { UTR = utr }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<int> CreateClass(Class classObj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                return await connection.ExecuteAsync("sp_CreateClass",
                    new
                    {
                        ClassName = classObj.ClassName,
                        ClassTeacherId = classObj.ClassTeacherId,
                        NumberOfSections = classObj.NumberOfSections,
                        UpdatedByStaffId = classObj.UpdatedByStaffId,
                        UpdatedByStaffName = classObj.UpdatedByStaffName,
                        UpdateOnDate = classObj.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<Class> FindClassById(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<Class>("sp_FindClassById", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<bool> UpdateClass(Class classObj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync("sp_UpdateClass",
                    new
                    {
                        ClassId = classObj.ClassId,
                        ClassName = classObj.ClassName,
                        ClassTeacherId = classObj.ClassTeacherId,
                        NumberOfSections = classObj.NumberOfSections,
                        UpdatedByStaffId = classObj.UpdatedByStaffId,
                        UpdatedByStaffName = classObj.UpdatedByStaffName,
                        UpdateOnDate = classObj.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public async Task<bool> DeleteClass(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync("sp_DeleteClass", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }

        public async Task<List<Class>> GetAllClasses()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<Class>("sp_GetAllClasses", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<int> CreateSection(Section section)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("sp_CreateSection",
                    new
                    {
                        ClassId = section.ClassId,
                        SectionName = section.SectionName,
                        UpdatedByStaffId = section.UpdatedByStaffId,
                        UpdatedByStaffName = section.UpdatedByStaffName,
                        UpdateOnDate = section.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<Section> FindSectionById(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<Section>("sp_FindSectionById", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<bool> UpdateSection(Section section)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("sp_UpdateSection",
                    new
                    {
                        SectionId = section.SectionId,
                        ClassId = section.ClassId,
                        SectionName = section.SectionName,
                        UpdatedByStaffId = section.UpdatedByStaffId,
                        UpdatedByStaffName = section.UpdatedByStaffName,
                        UpdateOnDate = section.UpdateOnDate
                    },
                    commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> DeleteSection(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("sp_DeleteSection", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<List<Section>> GetAllSections()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<Section>("sp_GetAllSections", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<int> CreateStudentDetails(StudentDetails studentDetails)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("sp_CreateStudentDetails",
                    new
                    {
                        StudentName = studentDetails.StudentName,
                        FatherName = studentDetails.FatherName,
                        MotherName = studentDetails.MotherName,
                        LocalGuardianName = studentDetails.LocalGuardianName,
                        LocalGuardianRelation = studentDetails.LocalGuardianRelation,
                        FatherContactDetails = studentDetails.FatherContactDetails,
                        MotherContactDetails = studentDetails.MotherContactDetails,
                        LocalGuardianContactDetails = studentDetails.LocalGuardianContactDetails,
                        LocalAddress = studentDetails.LocalAddress,
                        PermanentAddress = studentDetails.PermanentAddress,
                        ClassId = studentDetails.ClassId,
                        SectionId = studentDetails.SectionId,
                        UpdatedByStaffId = studentDetails.UpdatedByStaffId,
                        UpdatedByStaffName = studentDetails.UpdatedByStaffName,
                        Date = studentDetails.Date
                    },
                    commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentDetails> FindStudentDetailsById(int studentId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<StudentDetails>("sp_FindStudentDetailsById", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentDetails> FindStudentDetailsByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<StudentDetails>("sp_FindStudentDetailsByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentDetails> FindStudentDetailsBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<StudentDetails>("sp_FindStudentDetailsBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<bool> UpdateStudentDetails(StudentDetails studentDetails)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("sp_UpdateStudentDetails",
                    new
                    {
                        StudentId = studentDetails.StudentId,
                        StudentName = studentDetails.StudentName,
                        FatherName = studentDetails.FatherName,
                        MotherName = studentDetails.MotherName,
                        LocalGuardianName = studentDetails.LocalGuardianName,
                        LocalGuardianRelation = studentDetails.LocalGuardianRelation,
                        FatherContactDetails = studentDetails.FatherContactDetails,
                        MotherContactDetails = studentDetails.MotherContactDetails,
                        LocalGuardianContactDetails = studentDetails.LocalGuardianContactDetails,
                        LocalAddress = studentDetails.LocalAddress,
                        PermanentAddress = studentDetails.PermanentAddress,
                        ClassId = studentDetails.ClassId,
                        SectionId = studentDetails.SectionId,
                        UpdatedByStaffId = studentDetails.UpdatedByStaffId,
                        UpdatedByStaffName = studentDetails.UpdatedByStaffName,
                        Date = studentDetails.Date
                    },
                    commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> DeleteStudentDetails(int studentId, int classId, int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("sp_DeleteStudentDetails", new { StudentId = studentId, ClassId = classId, SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<List<StudentDetails>> GetAllStudentDetails()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<StudentDetails>("sp_GetAllStudentDetails", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}