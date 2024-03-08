using SchoolManagementSystem.Models.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Interface
{
    public interface ICashierRepositary
    {
        // Approval of Fees
        ApprovalOfFees FindApprovalOfFeesByStudentId(int studentId);
        IEnumerable<ApprovalOfFees> FindApprovalOfFeesByClassId(int classId);
        IEnumerable<ApprovalOfFees> FindApprovalOfFeesBySectionId(int sectionId);
        ApprovalOfFees FindApprovalOfFeesByFeesId(int feesId);
        ApprovalOfFees FindApprovalOfFeesByUTR(string utr);
        void EditApprovalOfFees(ApprovalOfFees approvalOfFees);
        void CreateApprovalOfFees(ApprovalOfFees approvalOfFees);
        void DeleteApprovalOfFees(int feesId);
        IEnumerable<ApprovalOfFees> GetAllApprovalOfFees();

        // Generate Fees
        GenerateFeesForStudent FindGenerateFeesForStudentByClassId(int classId);
        GenerateFeesForStudent FindGenerateFeesForStudentBySectionId(int sectionId);
        GenerateFeesForStudent FindGenerateFeesForStudentByStudentId(int studentId);
        GenerateFeesForStudent FindGenerateFeesForStudentByFeesId(int feesId);
        void CreateUpdateGenerateFeesForStudent(GenerateFeesForStudent generateFeesForStudent);
        void DeleteGenerateFeesForStudent(int feesId);
        IEnumerable<GenerateFeesForStudent> GetAllGenerateFeesForStudent();

        // Revenue
        Revenue FindRevenueByRevenueId(int revenueId);
        void CreateRevenue(Revenue revenue);
        void DeleteRevenue(int revenueId);
        void EditRevenue(Revenue revenue);
        IEnumerable<Revenue> GetAllRevenue();

        // Staff Salary
        StaffSalary FindStaffSalaryByStaffId(int staffId);
        IEnumerable<StaffSalary> FindStaffSalaryByUTR(string utr);
        void CreateStaffSalary(StaffSalary staffSalary);
        IEnumerable<StaffSalary> ReadAllStaffSalary();
        void UpdateStaffSalary(StaffSalary staffSalary);
        void DeleteStaffSalary(int staffSalaryId);
    }

}
