using Dapper;
using Microsoft.Extensions.Configuration;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Teacher;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repositary
{
    public class TeacherRepositary : ITeacherRepositary
    {
        private readonly IConfiguration _configuration;
        private readonly string ConnectionString;

        public TeacherRepositary(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("SchoolDbContext");
        }


        // HwCw methods
        public async Task<List<HwCw>> FindHwCwByClassId(int classId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<HwCw>("sp_FindHwCwByClassId", new { ClassId = classId },
                    commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<List<HwCw>> FindHwCwBySectionId(int sectionId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<HwCw>("sp_FindHwCwBySectionId", new { SectionId = sectionId },
                    commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<int> CreateHwCw(HwCw hwCw)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync("sp_CreateHwCw", hwCw, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> EditHwCw(HwCw hwCw)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                int rowsAffected = await dbConnection.ExecuteAsync("sp_EditHwCw", hwCw, commandType: CommandType.StoredProcedure);
                return rowsAffected > 0;
            }
        }


        // Student Achievement methods
        public async Task<StudentAchievement> FindStudentAchievementByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentAchievement>("sp_FindStudentAchievementByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<StudentAchievement> FindStudentAchievementByClassId(int classId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentAchievement>("sp_FindStudentAchievementByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<StudentAchievement> FindStudentAchievementBySectionId(int sectionId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentAchievement>("sp_FindStudentAchievementBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<int> CreateStudentAchievement(StudentAchievement studentAchievement)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync("sp_CreateStudentAchievement", studentAchievement, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<List<StudentAchievement>> GetAllStudentAchievements()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<StudentAchievement>("sp_ListAllStudentAchievements", commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<bool> EditStudentAchievement(StudentAchievement studentAchievement)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                int rowsAffected = await dbConnection.ExecuteAsync("sp_EditStudentAchievement", studentAchievement, commandType: CommandType.StoredProcedure);
                return rowsAffected > 0;
            }
        }


        // Student Attendance methods
        public async Task<List<StudentAttendance>> FindStudentAttendanceByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<StudentAttendance>("sp_FindStudentAttendanceByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<List<StudentAttendance>> FindStudentAttendanceByClassId(int classId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<StudentAttendance>("sp_FindStudentAttendanceByClassId", new { ClassId = classId },
                    commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<List<StudentAttendance>> FindStudentAttendanceBySectionId(int sectionId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<StudentAttendance>("sp_FindStudentAttendanceBySectionId", new { SectionId = sectionId },
                    commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<int> CreateStudentAttendance(StudentAttendance studentAttendance)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync("sp_CreateStudentAttendance", studentAttendance, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<List<StudentAttendance>> GetAllStudentAttendance()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<StudentAttendance>("sp_ListAllStudentAttendances", commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        public async Task<bool> EditStudentAttendance(StudentAttendance studentAttendance)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var affectedRows = await dbConnection.ExecuteAsync("sp_EditStudentAttendance", studentAttendance, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }


        // Student Marks methods
        public async Task<StudentMarks> FindStudentMarksByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var parameters = new { StudentId = studentId };
                var result = await connection.QueryFirstOrDefaultAsync<StudentMarks>("sp_FindStudentMarksByStudentId", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentMarks> FindStudentMarksByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var parameters = new { ClassId = classId };
                var result = await connection.QueryFirstOrDefaultAsync<StudentMarks>("sp_FindStudentMarksByClassId", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentMarks> FindStudentMarksBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var parameters = new { SectionId = sectionId };
                var result = await connection.QueryFirstOrDefaultAsync<StudentMarks>("sp_FindStudentMarksBySectionId", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<int> CreateStudentMarks(StudentMarks studentMarks)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var parameters = new
                {
                    StudentId = studentMarks.StudentId,
                    StudentName = studentMarks.StudentName,
                    ClassId = studentMarks.ClassId,
                    SectionId = studentMarks.SectionId,
                    English = studentMarks.English,
                    Hindi = studentMarks.Hindi,
                    Maths = studentMarks.Maths,
                    Science = studentMarks.Science,
                    SocialStudies = studentMarks.SocialStudies,
                    Computer = studentMarks.Computer,
                    Additional = studentMarks.Additional,
                    TotalMarks = studentMarks.TotalMarks,
                    MarksScored = studentMarks.MarksScored,
                    Percentage = studentMarks.Percentage,
                    UpdatedByStaffId = studentMarks.UpdatedByStaffId,
                    UpdatedByStaffName = studentMarks.UpdatedByStaffName,
                    UpdateOnDate = studentMarks.UpdateOnDate
                };

                var result = await connection.ExecuteScalarAsync<int>("sp_CreateStudentMarks", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<StudentMarks>> GetAllStudentMarks()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var result = await connection.QueryAsync<StudentMarks>("sp_ListAllStudentMarks", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<bool> EditStudentMarks(StudentMarks studentMarks)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var parameters = new
                {
                    StudentId = studentMarks.StudentId,
                    English = studentMarks.English,
                    Hindi = studentMarks.Hindi,
                    Maths = studentMarks.Maths,
                    Science = studentMarks.Science,
                    SocialStudies = studentMarks.SocialStudies,
                    Computer = studentMarks.Computer,
                    Additional = studentMarks.Additional,
                    TotalMarks = studentMarks.TotalMarks,
                    MarksScored = studentMarks.MarksScored,
                    Percentage = studentMarks.Percentage
                };

                var result = await connection.ExecuteAsync("sp_EditStudentMarks", parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }


        // Student Remarks methods
        public async Task<StudentRemarks> FindStudentRemarksByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<StudentRemarks>("sp_FindStudentRemarksByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentRemarks> FindStudentRemarksByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<StudentRemarks>("sp_FindStudentRemarksByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<StudentRemarks> FindStudentRemarksBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<StudentRemarks>("sp_FindStudentRemarksBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<int> CreateStudentRemarks(StudentRemarks studentRemarks)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    StudentId = studentRemarks.StudentId,
                    StudentName = studentRemarks.StudentName,
                    ClassId = studentRemarks.ClassId,
                    SectionId = studentRemarks.SectionId,
                    Remarks = studentRemarks.Remarks,
                    UpdatedByStaffId = studentRemarks.UpdatedByStaffId,
                    UpdatedByStaffName = studentRemarks.UpdatedByStaffName,
                    UpdateOnDate = studentRemarks.UpdateOnDate
                };

                var result = await connection.ExecuteScalarAsync<int>("sp_CreateStudentRemarks", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<StudentRemarks>> GetAllStudentRemarks()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<StudentRemarks>("sp_ListAllStudentRemarks", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<bool> EditStudentRemarks(StudentRemarks studentRemarks)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    StudentId = studentRemarks.StudentId,
                    Remarks = studentRemarks.Remarks
                };

                var result = await connection.ExecuteAsync("sp_EditStudentRemarks", parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
    }
}
