using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Cashier;
using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Roles = "1")]
    [ApiController]
    [Route("api/[controller]")]
    public class CashierManagementController : ControllerBase
    {
        private readonly ICashierRepositary _cashierRepositary;

        public CashierManagementController(ICashierRepositary cashierRepositary)
        {
            _cashierRepositary = cashierRepositary;
        }
        // Approval of Fees

        [HttpGet("FindApprovalOfFeesByStudentId/{studentId}")]
        public ActionResult<ApprovalOfFees> FindApprovalOfFeesByStudentId(int studentId)
        {
            var approvalOfFees = _cashierRepositary.FindApprovalOfFeesByStudentId(studentId);
            if (approvalOfFees == null)
            {
                return NotFound();
            }
            return Ok(approvalOfFees);
        }

        [HttpGet("FindApprovalOfFeesByClassId/{classId}")]
        public ActionResult<IEnumerable<ApprovalOfFees>> FindApprovalOfFeesByClassId(int classId)
        {
            var approvalOfFeesList = _cashierRepositary.FindApprovalOfFeesByClassId(classId);
            return Ok(approvalOfFeesList);
        }

        [HttpGet("FindApprovalOfFeesBySectionId/{sectionId}")]
        public ActionResult<IEnumerable<ApprovalOfFees>> FindApprovalOfFeesBySectionId(int sectionId)
        {
            var approvalOfFeesList = _cashierRepositary.FindApprovalOfFeesBySectionId(sectionId);
            return Ok(approvalOfFeesList);
        }

        [HttpGet("FindApprovalOfFeesByFeesId/{feesId}")]
        public ActionResult<ApprovalOfFees> FindApprovalOfFeesByFeesId(int feesId)
        {
            var approvalOfFees = _cashierRepositary.FindApprovalOfFeesByFeesId(feesId);
            if (approvalOfFees == null)
            {
                return NotFound();
            }
            return Ok(approvalOfFees);
        }

        [HttpGet("FindApprovalOfFeesByUTR/{utr}")]
        public ActionResult<ApprovalOfFees> FindApprovalOfFeesByUTR(string utr)
        {
            var approvalOfFees = _cashierRepositary.FindApprovalOfFeesByUTR(utr);
            if (approvalOfFees == null)
            {
                return NotFound();
            }
            return Ok(approvalOfFees);
        }

        [HttpPut("EditApprovalOfFees")]
        public IActionResult EditApprovalOfFees([FromBody] ApprovalOfFees approvalOfFees)
        {
            _cashierRepositary.EditApprovalOfFees(approvalOfFees);
            return NoContent();
        }

        [HttpPost("CreateApprovalOfFees")]
        public IActionResult CreateApprovalOfFees([FromBody] ApprovalOfFees approvalOfFees)
        {
            _cashierRepositary.CreateApprovalOfFees(approvalOfFees);
            return CreatedAtAction(nameof(FindApprovalOfFeesByFeesId), new { feesId = approvalOfFees.FeesId }, approvalOfFees);
        }

        [HttpDelete("DeleteApprovalOfFees/{feesId}")]
        public IActionResult DeleteApprovalOfFees(int feesId)
        {
            var existingApprovalOfFees = _cashierRepositary.FindApprovalOfFeesByFeesId(feesId);
            if (existingApprovalOfFees == null)
            {
                return NotFound();
            }
            _cashierRepositary.DeleteApprovalOfFees(feesId);
            return NoContent();
        }

        [HttpGet("GetAllApprovalOfFees")]
        public ActionResult<IEnumerable<ApprovalOfFees>> GetAllApprovalOfFees()
        {
            var approvalOfFeesList = _cashierRepositary.GetAllApprovalOfFees();
            return Ok(approvalOfFeesList);
        }

        // Generate Fees For Student

        [HttpGet("FindGenerateFeesForStudentByClassId/{classId}")]
        public ActionResult<GenerateFeesForStudent> FindGenerateFeesForStudentByClassId(int classId)
        {
            var generateFees = _cashierRepositary.FindGenerateFeesForStudentByClassId(classId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("FindGenerateFeesForStudentBySectionId/{sectionId}")]
        public ActionResult<GenerateFeesForStudent> FindGenerateFeesForStudentBySectionId(int sectionId)
        {
            var generateFees = _cashierRepositary.FindGenerateFeesForStudentBySectionId(sectionId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("FindGenerateFeesForStudentByStudentId/{studentId}")]
        public ActionResult<GenerateFeesForStudent> FindGenerateFeesForStudentByStudentId(int studentId)
        {
            var generateFees = _cashierRepositary.FindGenerateFeesForStudentByStudentId(studentId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpPost("CreateUpdateGenerateFeesForStudent")]
        public IActionResult CreateUpdateGenerateFeesForStudent(GenerateFeesForStudent generateFees)
        {
            _cashierRepositary.CreateUpdateGenerateFeesForStudent(generateFees);
            return CreatedAtAction(nameof(FindGenerateFeesForStudentByStudentId), new { studentId = generateFees.StudentId }, generateFees);
        }

        [HttpGet("GetAllGenerateFeesForStudent")]
        public ActionResult<IEnumerable<GenerateFeesForStudent>> GetAllGenerateFeesForStudent()
        {
            var generateFeesList = _cashierRepositary.GetAllGenerateFeesForStudent();
            return Ok(generateFeesList);
        }

        // Revenue methods

        [HttpGet("FindRevenueByRevenueId/{revenueId}")]
        public ActionResult<Revenue> FindRevenueByRevenueId(int revenueId)
        {
            var revenue = _cashierRepositary.FindRevenueByRevenueId(revenueId);
            if (revenue == null)
            {
                return NotFound();
            }
            return Ok(revenue);
        }

        [HttpPost("CreateRevenue")]
        public IActionResult CreateRevenue(Revenue revenue)
        {
            _cashierRepositary.CreateRevenue(revenue);
            return CreatedAtAction(nameof(FindRevenueByRevenueId), new { revenueId = revenue.RevenueId }, revenue);
        }

        [HttpDelete("DeleteRevenue/{revenueId}")]
        public IActionResult DeleteRevenue(int revenueId)
        {
            var existingRevenue = _cashierRepositary.FindRevenueByRevenueId(revenueId);
            if (existingRevenue == null)
            {
                return NotFound();
            }
            _cashierRepositary.DeleteRevenue(revenueId);
            return NoContent();
        }

        [HttpPut("EditRevenue")]
        public IActionResult EditRevenue(Revenue revenue)
        {
            _cashierRepositary.EditRevenue(revenue);
            return NoContent();
        }

        [HttpGet("GetAllRevenue")]
        public ActionResult<IEnumerable<Revenue>> GetAllRevenue()
        {
            var revenueList = _cashierRepositary.GetAllRevenue();
            return Ok(revenueList);
        }

        // Staff Salary Controller

        [HttpGet("FindStaffSalaryByStaffId/{staffId}")]
        public ActionResult<StaffSalary> FindStaffSalaryByStaffId(int staffId)
        {
            var staffSalary = _cashierRepositary.FindStaffSalaryByStaffId(staffId);
            if (staffSalary == null)
            {
                return NotFound();
            }
            return Ok(staffSalary);
        }

        [HttpGet("FindStaffSalaryByUTR/{utr}")]
        public ActionResult<IEnumerable<StaffSalary>> FindStaffSalaryByUTR(string utr)
        {
            var staffSalaryList = _cashierRepositary.FindStaffSalaryByUTR(utr);
            return Ok(staffSalaryList);
        }

        [HttpPost("CreateStaffSalary")]
        public IActionResult CreateStaffSalary(StaffSalary staffSalary)
        {
            _cashierRepositary.CreateStaffSalary(staffSalary);
            return CreatedAtAction(nameof(FindStaffSalaryByStaffId), new { staffId = staffSalary.StaffId }, staffSalary);
        }

        [HttpGet("ReadAllStaffSalary")]
        public ActionResult<IEnumerable<StaffSalary>> ReadAllStaffSalary()
        {
            var staffSalaryList = _cashierRepositary.ReadAllStaffSalary();
            return Ok(staffSalaryList);
        }

        [HttpPut("UpdateStaffSalary")]
        public IActionResult UpdateStaffSalary(StaffSalary staffSalary)
        {
            _cashierRepositary.UpdateStaffSalary(staffSalary);
            return NoContent();
        }

        [HttpDelete("DeleteStaffSalary/{staffSalaryId}")]
        public IActionResult DeleteStaffSalary(int staffSalaryId)
        {
            var existingStaffSalary = _cashierRepositary.FindStaffSalaryByStaffId(staffSalaryId);
            if (existingStaffSalary == null)
            {
                return NotFound();
            }
            _cashierRepositary.DeleteStaffSalary(staffSalaryId);
            return NoContent();
        }

    }
}
