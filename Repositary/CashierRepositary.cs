using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Cashier;
using SchoolManagementSystem.Models.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repositary
{
    public class CashierRepositary : ICashierRepositary
    {
        private readonly IConfiguration _configuration;
        private readonly string ConnectionString;

        public CashierRepositary(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("SchoolDbContext");
        }


        // Approval of Fees
        public ApprovalOfFees FindApprovalOfFeesByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<ApprovalOfFees> FindApprovalOfFeesByClassId(int classId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesByClassId", new { ClassId = classId },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<ApprovalOfFees> FindApprovalOfFeesBySectionId(int sectionId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesBySectionId", new { SectionId = sectionId },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public ApprovalOfFees FindApprovalOfFeesByFeesId(int feesId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesByFeesId", new { FeesId = feesId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public ApprovalOfFees FindApprovalOfFeesByUTR(string utr)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ApprovalOfFees>("sp_FindApprovalOfFeesByUTR", new { UTR = utr },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void EditApprovalOfFees(ApprovalOfFees approvalOfFees)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_EditApprovalOfFees", approvalOfFees, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateApprovalOfFees(ApprovalOfFees approvalOfFees)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_CreateApprovalOfFees", approvalOfFees, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteApprovalOfFees(int feesId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_DeleteApprovalOfFees", new { FeesId = feesId }, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<ApprovalOfFees> GetAllApprovalOfFees()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ApprovalOfFees>("sp_ListAllApprovalOfFees", commandType: CommandType.StoredProcedure);
            }
        }

        // Generate Fees
        public GenerateFeesForStudent FindGenerateFeesForStudentByClassId(int classId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByClassId", new { ClassId = classId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentBySectionId(int sectionId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentBySectionId", new { SectionId = sectionId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentByStudentId(int studentId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByStudentId", new { StudentId = studentId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public GenerateFeesForStudent FindGenerateFeesForStudentByFeesId(int feesId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<GenerateFeesForStudent>("sp_FindGenerateFeesForStudentByFeesId", new { FeesId = feesId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void CreateUpdateGenerateFeesForStudent(GenerateFeesForStudent generateFeesForStudent)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_CreateUpdateGenerateFeesForStudent", generateFeesForStudent, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteGenerateFeesForStudent(int feesId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_DeleteGenerateFeesForStudent", new { FeesId = feesId }, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<GenerateFeesForStudent> GetAllGenerateFeesForStudent()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<GenerateFeesForStudent>("sp_ListAllGenerateFeesForStudents", commandType: CommandType.StoredProcedure);
            }
        }

        // Revenue
        public Revenue FindRevenueByRevenueId(int revenueId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Revenue>("sp_FindRevenueByRevenueId", new { RevenueId = revenueId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void CreateRevenue(Revenue revenue)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_CreateRevenue", revenue, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteRevenue(int revenueId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_DeleteRevenue", new { RevenueId = revenueId }, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditRevenue(Revenue revenue)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_EditRevenue", revenue, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Revenue> GetAllRevenue()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Revenue>("sp_ListAllRevenues", commandType: CommandType.StoredProcedure);
            }
        }

        // Staff Salary
        public StaffSalary FindStaffSalaryByStaffId(int staffId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<StaffSalary>("sp_FindStaffSalaryByStaffId", new { StaffId = staffId },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<StaffSalary> FindStaffSalaryByUTR(string utr)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<StaffSalary>("sp_FindStaffSalaryByUTR", new { UTR = utr },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateStaffSalary(StaffSalary staffSalary)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_CreateStaffSalary", staffSalary, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<StaffSalary> ReadAllStaffSalary()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<StaffSalary>("sp_ListAllStaffSalaries", commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateStaffSalary(StaffSalary staffSalary)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_EditStaffSalary", staffSalary, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteStaffSalary(int staffSalaryId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                dbConnection.Execute("sp_DeleteStaffSalary", new { StaffSalaryId = staffSalaryId }, commandType: CommandType.StoredProcedure);
            }
        }

        // Fees update by students methods
        public async Task<List<FeesUpdateByStudent>> GetAllFeesUpdateByStudent()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_ListAllFeesUpdateByStudents", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<FeesUpdateByStudent> FindFeesUpdateByStudentByStudentId(int studentId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryFirstOrDefaultAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByStudentId", new { StudentId = studentId }, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentByClassId(int classId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByClassId", new { ClassId = classId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentBySectionId(int sectionId)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentBySectionId", new { SectionId = sectionId }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<FeesUpdateByStudent>> FindFeesUpdateByStudentByUTR(string utr)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();
                var result = await connection.QueryAsync<FeesUpdateByStudent>("sp_FindFeesUpdateByStudentByUTR", new { UTR = utr }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
