using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SchoolManagementSystem.Models.Student;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Teacher;
using System.Linq;


namespace SchoolManagementSystem.Repositary
{
    public class StudentRepositary : IStudentRepositary
    {
        private readonly IConfiguration _configuration;
        private readonly string ConnectionString;

        public StudentRepositary(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("SchoolDbContext");
        }

        private IDbConnection DbConnection
        {
            get
            {
                return new SqlConnection(ConnectionString);
            }
        }


        // Complain methods
        public async Task<int> CreateComplainByStudent(ComplainByStudent complain)
        {
            using (var dbConnection = DbConnection)
            {
                dbConnection.Open();
                var result = await dbConnection.ExecuteAsync("sp_CreateComplainByStudent", complain, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<bool> EditComplainByStudent(ComplainByStudent complain)
        {
            using (var dbConnection = DbConnection)
            {
                dbConnection.Open();
                var result = await dbConnection.ExecuteAsync("sp_EditComplainByStudent", complain, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<ComplainByStudent> FindComplainByStudentId(int studentId)
        {
            using (var dbConnection = DbConnection)
            {
                dbConnection.Open();
                var result = await dbConnection.QueryFirstOrDefaultAsync<ComplainByStudent>("sp_FindComplainByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<bool> DeleteComplainByStudentId(int studentId)
        {
            using (var dbConnection = DbConnection)
            {
                dbConnection.Open();
                var result = await dbConnection.ExecuteAsync("sp_DeleteComplainByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }


        // FeesUpdateByStudent methods

        public async Task<int> CreateFeesUpdateByStudent(FeesUpdateByStudent feesUpdate)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync("sp_CreateFeesUpdateByStudent", feesUpdate, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> EditFeesUpdateByStudent(FeesUpdateByStudent feesUpdate)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync("sp_EditFeesUpdateByStudent", feesUpdate, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public async Task<bool> DeleteFeesUpdateByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync("sp_DeleteFeesUpdateByStudent", new { StudentId = studentId }, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public async Task<FeesUpdateByStudent> FindFeesUpdateByStudentByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<FeesUpdateByStudent> FindFeesUpdateByStudentByUTRNo(string utrNo)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByUTR", new { UTRNo = utrNo }, commandType: CommandType.StoredProcedure);
            }
        }

        // Student Marks methods

        public async Task<StudentMarks> FindStudentMarksByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentMarks>("sp_FindStudentMarksByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure);
            }
        }

        // HwCw methods

        public async Task<List<HwCw>> FindHwCwBySectionId(int sectionId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return (await dbConnection.QueryAsync<HwCw>("sp_FindHwCwBySectionId", new { SectionId = sectionId },
                    commandType: CommandType.StoredProcedure)).ToList();
            }
        }

        // Student Achievement methods

        public async Task<StudentAchievement> FindStudentAchievementByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentAchievement>("sp_FindStudentAchievementByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure);
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


        // Student Remarks methods
        public async Task<StudentRemarks> FindStudentRemarksByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentRemarks>("sp_FindStudentRemarksByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure);
            }
        }


        // GenerateFeesForStudent methods

        public async Task<GenerateFeesForStudent> FindGenerateFeesForStudentByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure);
            }
        }



        // ApprovalOfFees methods
        public async Task<ApprovalOfFees> FindApprovalOfFeesByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<ApprovalOfFees>("sp_FindApprovalOfFeesByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure);
            }
        }



        // StudentDetails methods

        public async Task<StudentDetails> FindStudentDetailsByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return await dbConnection.QueryFirstOrDefaultAsync<StudentDetails>("sp_FindStudentDetailsByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
