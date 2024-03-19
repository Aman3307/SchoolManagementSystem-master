using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Student;

[Authorize(Policy = "StudentOnly")]
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepositary _studentRepositary;

    public StudentController(IStudentRepositary studentRepositary)
    {
        _studentRepositary = studentRepositary ?? throw new ArgumentNullException(nameof(studentRepositary));
    }

    [HttpPost("CreateComplaint")]
    public async Task<IActionResult> CreateComplaint([FromBody] ComplainByStudent complain)
    {
        try
        {
            var result = await _studentRepositary.CreateComplainByStudent(complain);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPut("EditComplaint/{studentId}")]
    public async Task<IActionResult> EditComplaint(int studentId, [FromBody] ComplainByStudent complain)
    {
        

        try
        {
            var existingComplaint = await _studentRepositary.FindComplainByStudentId(studentId);

            if (existingComplaint == null)
            {
                return NotFound($"Complaint with ID {studentId} not found");
            }

            existingComplaint.ComplainAgainst = complain.ComplainAgainst;

            var result = await _studentRepositary.EditComplainByStudent(existingComplaint);
            return Ok(result);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("GetComplaint/{studentId}")]
    public async Task<IActionResult> GetComplaint(int studentId)
    {
        
        try
        {
            var complaint = await _studentRepositary.FindComplainByStudentId(studentId);

            if (complaint == null)
            {
                return NotFound($"Complaint with ID {studentId} not found");
            }

            return Ok(complaint);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpDelete("DeleteComplaint/{studentId}")]
    public async Task<IActionResult> DeleteComplaint(int studentId)
    {
        try
        {
            var existingComplaint = await _studentRepositary.FindComplainByStudentId(studentId);

            if (existingComplaint == null)
            {
                return NotFound($"Complaint with ID {studentId} not found");
            }

            var result = await _studentRepositary.DeleteComplainByStudentId(studentId);
            return Ok(result);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }
    [HttpPost("CreateFeesUpdate")]
    public async Task<IActionResult> CreateFeesUpdate([FromBody] FeesUpdateByStudent feesUpdate)
    {
        try
        {
            var result = await _studentRepositary.CreateFeesUpdateByStudent(feesUpdate);
            return Ok(result);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPut("EditFeesUpdate/{studentId}")]
    public async Task<IActionResult> EditFeesUpdate(int studentId, [FromBody] FeesUpdateByStudent feesUpdate)
    {
        try
        {
            var existingFeesUpdate = await _studentRepositary.FindFeesUpdateByStudentByStudentId(studentId);

            if (existingFeesUpdate == null)
            {
                return NotFound($"Fees update with ID {studentId} not found");
            }

            existingFeesUpdate.RemainingFees = feesUpdate.RemainingFees;
            existingFeesUpdate.PaidFees = feesUpdate.PaidFees;

            var result = await _studentRepositary.EditFeesUpdateByStudent(existingFeesUpdate);
            return Ok(result);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpDelete("DeleteFeesUpdate/{studentId}")]
    public async Task<IActionResult> DeleteFeesUpdate(int studentId)
    {
        try
        {
            var existingFeesUpdate = await _studentRepositary.FindFeesUpdateByStudentByStudentId(studentId);

            if (existingFeesUpdate == null)
            {
                return NotFound($"Fees update with ID {studentId} not found");
            }

            var result = await _studentRepositary.DeleteFeesUpdateByStudentId(studentId);
            return Ok(result);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }
    [HttpGet("marks/{studentId}")]
    public async Task<IActionResult> GetStudentMarks(int studentId)
    {
        try
        {
            var marks = await _studentRepositary.FindStudentMarksByStudentId(studentId);
            if (marks == null)
            {
                return NotFound($"Marks for student with ID {studentId} not found");
            }

            return Ok(marks);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("hw-cw/{sectionId}")]
    public async Task<IActionResult> GetHwCwBySectionId(int sectionId)
    {
        try
        {
            var hwCwList = await _studentRepositary.FindHwCwBySectionId(sectionId);
            return Ok(hwCwList);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }
    [HttpGet("student-attendance/{studentId}")]
    public async Task<IActionResult> GetStudentAttendance(int studentId)
    {
        try
        {
            var attendanceList = await _studentRepositary.FindStudentAttendanceByStudentId(studentId);
            return Ok(attendanceList);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("student-achievement/{studentId}")]
    public async Task<IActionResult> GetStudentAchievement(int studentId)
    {
        try
        {
            var achievementList = await _studentRepositary.FindStudentAchievementByStudentId(studentId);
            return Ok(achievementList);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("student-remarks/{studentId}")]
    public async Task<IActionResult> GetStudentRemarks(int studentId)
    {
        try
        {
            var remarks = await _studentRepositary.FindStudentRemarksByStudentId(studentId);
            if (remarks == null)
            {
                return NotFound($"Remarks for student with ID {studentId} not found");
            }

            return Ok(remarks);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("generate-fees/{studentId}")]
    public async Task<IActionResult> GetGenerateFeesForStudent(int studentId)
    {
        try
        {
            var fees = await _studentRepositary.FindGenerateFeesForStudentByStudentId(studentId);
            if (fees == null)
            {
                return NotFound($"Fees for student with ID {studentId} not found");
            }

            return Ok(fees);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("approval-of-fees/{studentId}")]
    public async Task<IActionResult> GetApprovalOfFees(int studentId)
    {
        try
        {
            var approval = await _studentRepositary.FindApprovalOfFeesByStudentId(studentId);
            if (approval == null)
            {
                return NotFound($"Approval of fees for student with ID {studentId} not found");
            }

            return Ok(approval);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("student-details/{studentId}")]
    public async Task<IActionResult> GetStudentDetails(int studentId)
    {
        try
        {
            var details = await _studentRepositary.FindStudentDetailsByStudentId(studentId);
            if (details == null)
            {
                return NotFound($"Details for student with ID {studentId} not found");
            }

            return Ok(details);
        }
        catch
        {
            // Log the exception or handle it as needed
            return StatusCode(500, "Internal server error");
        }
    }
}
