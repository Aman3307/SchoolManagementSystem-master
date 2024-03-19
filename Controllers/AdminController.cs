using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Admin;
using SchoolManagementSystem.Models.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepositary _adminRepositary;

        public AdminController(IAdminRepositary adminRepositary)
        {
            _adminRepositary = adminRepositary;
        }

        [HttpGet("getClassAttendanceList")]
        public ActionResult<IEnumerable<ClassAttendance>> GetClassAttendanceList()
        {
            var result = _adminRepositary.GetClassAttendanceList();
            return Ok(result);
        }

        [HttpGet("findClassAttendanceByClassId")]
        public ActionResult<ClassAttendance> FindClassAttendanceByClassId(int classId)
        {
            var result = _adminRepositary.FindClassAttendanceByClassId(classId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpGet("findClassTeacherByClassTeacherId")]
        public ActionResult<ClassTeacher> FindClassTeacherByClassTeacherId(int classTeacherId)
        {
            var result = _adminRepositary.FindClassTeacherByClassTeacherId(classTeacherId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpGet("findClassTeacherByStaffId")]
        public ActionResult<ClassTeacher> FindClassTeacherByStaffId(int staffId)
        {
            var result = _adminRepositary.FindClassTeacherByStaffId(staffId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpGet("findClassTeacherByClassId")]
        public ActionResult<IEnumerable<ClassTeacher>> FindClassTeacherByClassId(int classId)
        {
            var result = _adminRepositary.FindClassTeacherByClassId(classId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result); // Use Ok(result) to return a 200 OK response
        }

        [HttpPost("createClassTeacher")]
        public ActionResult CreateClassTeacher(ClassTeacher classTeacher)
        {
            _adminRepositary.CreateClassTeacher(classTeacher);
            return Ok();
        }

        [HttpGet("listAllClassTeachers")]
        public ActionResult<IEnumerable<ClassTeacher>> ListAllClassTeachers()
        {
            var result = _adminRepositary.ListAllClassTeachers();
            return Ok(result);
        }

        [HttpPut("editClassTeacher")]
        public ActionResult EditClassTeacher(ClassTeacher classTeacher)
        {
            _adminRepositary.EditClassTeacher(classTeacher);
            return Ok();
        }

        [HttpDelete("deleteClassTeacher")]
        public ActionResult DeleteClassTeacher(int classTeacherId)
        {
            _adminRepositary.DeleteClassTeacher(classTeacherId);
            return Ok();
        }
        // Section Attendance
        [HttpGet("sectionattendance")]
        public ActionResult<IEnumerable<SectionAttendance>> GetSectionAttendanceList()
        {
            var sectionAttendanceList = _adminRepositary.GetSectionAttendanceList();
            return Ok(sectionAttendanceList);
        }

        [HttpGet("sectionattendance/{sectionId}")]
        public ActionResult<SectionAttendance> FindSectionAttendanceBySectionId(int sectionId)
        {
            var sectionAttendance = _adminRepositary.FindSectionAttendanceBySectionId(sectionId);
            if (sectionAttendance == null)
            {
                return NotFound();
            }
            return Ok(sectionAttendance);
        }

        // Section Teacher
        [HttpGet("sectionteacher/{sectionTeacherId}")]
        public ActionResult<SectionTeacher> FindSectionTeacherBySectionTeacherId(int sectionTeacherId)
        {
            var sectionTeacher = _adminRepositary.FindSectionTeacherBySectionTeacherId(sectionTeacherId);
            if (sectionTeacher == null)
            {
                return NotFound();
            }
            return Ok(sectionTeacher);
        }

        [HttpGet("sectionteacher/bystaff/{staffId}")]
        public ActionResult<SectionTeacher> FindSectionTeacherByStaffId(int staffId)
        {
            var sectionTeacher = _adminRepositary.FindSectionTeacherByStaffId(staffId);
            if (sectionTeacher == null)
            {
                return NotFound();
            }
            return Ok(sectionTeacher);
        }

        [HttpGet("sectionteacher/bysection/{sectionId}")]
        public ActionResult<IEnumerable<SectionTeacher>> FindSectionTeacherBySectionId(int sectionId)
        {
            var sectionTeachers = _adminRepositary.FindSectionTeacherBySectionId(sectionId);
            return Ok(sectionTeachers);
        }

        [HttpPost("sectionteacher")]
        public ActionResult CreateSectionTeacher([FromBody] SectionTeacher sectionTeacher)
        {
            _adminRepositary.CreateSectionTeacher(sectionTeacher);
            return Ok();
        }

        [HttpGet("sectionteacher")]
        public ActionResult<IEnumerable<SectionTeacher>> ListAllSectionTeachers()
        {
            var sectionTeachers = _adminRepositary.ListAllSectionTeachers();
            return Ok(sectionTeachers);
        }

        [HttpPut("sectionteacher")]
        public ActionResult EditSectionTeacher([FromBody] SectionTeacher sectionTeacher)
        {
            _adminRepositary.EditSectionTeacher(sectionTeacher);
            return Ok();
        }

        [HttpDelete("sectionteacher/{sectionTeacherId}")]
        public ActionResult DeleteSectionTeacher(int sectionTeacherId)
        {
            _adminRepositary.DeleteSectionTeacher(sectionTeacherId);
            return Ok();
        }
        [HttpGet("getStaffAttendanceList")]
        public ActionResult<IEnumerable<StaffAttendance>> GetStaffAttendanceList()
        {
            var result = _adminRepositary.GetStaffAttendanceList();
            return Ok(result.ToList());
        }

        [HttpGet("findStaffAttendanceByStaffId")]
        public ActionResult<StaffAttendance> FindStaffAttendanceByStaffId(int staffId)
        {
            var result = _adminRepositary.FindStaffAttendanceByStaffId(staffId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("createStaffDetails")]
        public IActionResult CreateStaffDetails([FromBody] StaffDetails staffDetails)
        {
            _adminRepositary.CreateStaffDetails(staffDetails);
            return Ok();
        }

        [HttpPost("editStaffDetails")]
        public IActionResult EditStaffDetails([FromBody] StaffDetails staffDetails)
        {
            _adminRepositary.EditStaffDetails(staffDetails);
            return Ok();
        }

        [HttpDelete("deleteStaffDetails")]
        public IActionResult DeleteStaffDetails(int staffId)
        {
            _adminRepositary.DeleteStaffDetails(staffId);
            return Ok();
        }

        [HttpGet("getAllStaffDetails")]
        public ActionResult<IEnumerable<StaffDetails>> GetAllStaffDetails()
        {
            var result = _adminRepositary.GetAllStaffDetails();
            return Ok(result.ToList());
        }

        [HttpGet("findStaffByStaffId")]
        public ActionResult<StaffDetails> FindStaffByStaffId(int staffId)
        {
            var result = _adminRepositary.FindStaffByStaffId(staffId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("subject-teacher/{staffId}")]
        public IActionResult FindSubjectTeacherByStaffId(int staffId)
        {
            var subjectTeacher = _adminRepositary.FindSubjectTeacherByStaffId(staffId);
            if (subjectTeacher == null)
            {
                return NotFound();
            }
            return Ok(subjectTeacher);
        }

        [HttpGet("subject-teacher/class/{classId}")]
        public IActionResult FindSubjectTeacherByClassId(int classId)
        {
            var subjectTeachers = _adminRepositary.FindSubjectTeacherByClassId(classId);
            if (subjectTeachers == null)
            {
                return NotFound();
            }
            return Ok(subjectTeachers);
        }

        [HttpGet("subject-teacher/section/{sectionId}")]
        public IActionResult FindSubjectTeacherBySectionId(int sectionId)
        {
            var subjectTeachers = _adminRepositary.FindSubjectTeacherBySectionId(sectionId);
            if (subjectTeachers == null)
            {
                return NotFound();
            }
            return Ok(subjectTeachers);
        }

        [HttpGet("subject-teacher/subject/{subjectName}")]
        public IActionResult FindSubjectTeacherBySubjectName(string subjectName)
        {
            var subjectTeacher = _adminRepositary.FindSubjectTeacherBySubjectName(subjectName);
            if (subjectTeacher == null)
            {
                return NotFound();
            }
            return Ok(subjectTeacher);
        }

        [HttpPost("subject-teacher")]
        public IActionResult CreateSubjectTeacher(SubjectTeacher subjectTeacher)
        {
            _adminRepositary.CreateSubjectTeacher(subjectTeacher);
            return CreatedAtAction(nameof(FindSubjectTeacherByStaffId), new { staffId = subjectTeacher.StaffId }, subjectTeacher);
        }

        [HttpPut("subject-teacher")]
        public IActionResult EditSubjectTeacher(SubjectTeacher subjectTeacher)
        {
            _adminRepositary.EditSubjectTeacher(subjectTeacher);
            return NoContent();
        }

        [HttpDelete("subject-teacher/{subjectTeacherId}")]
        public IActionResult DeleteSubjectTeacher(int subjectTeacherId)
        {
            _adminRepositary.DeleteSubjectTeacher(subjectTeacherId);
            return NoContent();
        }

        [HttpGet("staff-salary/{staffId}")]
        public IActionResult FindStaffSalaryByStaffId(int staffId)
        {
            var staffSalary = _adminRepositary.FindStaffSalaryByStaffId(staffId);
            if (staffSalary == null)
            {
                return NotFound();
            }
            return Ok(staffSalary);
        }

        [HttpGet("generate-fees/class/{classId}")]
        public IActionResult FindGenerateFeesForStudentByClassId(int classId)
        {
            var generateFees = _adminRepositary.FindGenerateFeesForStudentByClassId(classId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("generate-fees/section/{sectionId}")]
        public IActionResult FindGenerateFeesForStudentBySectionId(int sectionId)
        {
            var generateFees = _adminRepositary.FindGenerateFeesForStudentBySectionId(sectionId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("generate-fees/student/{studentId}")]
        public IActionResult FindGenerateFeesForStudentByStudentId(int studentId)
        {
            var generateFees = _adminRepositary.FindGenerateFeesForStudentByStudentId(studentId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("generate-fees/fees/{feesId}")]
        public IActionResult FindGenerateFeesForStudentByFeesId(int feesId)
        {
            var generateFees = _adminRepositary.FindGenerateFeesForStudentByFeesId(feesId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("approval-fees/student/{studentId}")]
        public IActionResult FindApprovalOfFeesByStudentId(int studentId)
        {
            var approvalFees = _adminRepositary.FindApprovalOfFeesByStudentId(studentId);
            if (approvalFees == null)
            {
                return NotFound();
            }
            return Ok(approvalFees);
        }

        [HttpGet("approval-fees/class/{classId}")]
        public IActionResult FindApprovalOfFeesByClassId(int classId)
        {
            var approvalFees = _adminRepositary.FindApprovalOfFeesByClassId(classId);
            if (approvalFees == null || !approvalFees.Any())
            {
                return NotFound();
            }
            return Ok(approvalFees);
        }

        [HttpGet("approval-fees/section/{sectionId}")]
        public IActionResult FindApprovalOfFeesBySectionId(int sectionId)
        {
            var approvalFees = _adminRepositary.FindApprovalOfFeesBySectionId(sectionId);
            if (approvalFees == null || !approvalFees.Any())
            {
                return NotFound();
            }
            return Ok(approvalFees);
        }

        [HttpGet("approval-fees/fees/{feesId}")]
        public IActionResult FindApprovalOfFeesByFeesId(int feesId)
        {
            var approvalFees = _adminRepositary.FindApprovalOfFeesByFeesId(feesId);
            if (approvalFees == null)
            {
                return NotFound();
            }
            return Ok(approvalFees);
        }

        [HttpGet("approval-fees/utr/{utr}")]
        public IActionResult FindApprovalOfFeesByUTR(string utr)
        {
            var approvalFees = _adminRepositary.FindApprovalOfFeesByUTR(utr);
            if (approvalFees == null)
            {
                return NotFound();
            }
            return Ok(approvalFees);
        }

        [HttpPost("class")]
        public async Task<IActionResult> CreateClass([FromBody] Class classObj)
        {
            var result = await _adminRepositary.CreateClass(classObj);
            return Ok(result);
        }

        [HttpGet("class/{classId}")]
        public async Task<IActionResult> FindClassByClassId(int classId)
        {
            var classObj = await _adminRepositary.FindClassByClassId(classId);
            if (classObj == null)
            {
                return NotFound();
            }
            return Ok(classObj);
        }

        [HttpPut("class")]
        public async Task<IActionResult> UpdateClass([FromBody] Class classObj)
        {
            var result = await _adminRepositary.UpdateClass(classObj);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("class/{classId}")]
        public async Task<IActionResult> DeleteClass(int classId)
        {
            var result = await _adminRepositary.DeleteClass(classId);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("classes")]
        public async Task<IActionResult> ListAllClasses()
        {
            var classes = await _adminRepositary.ListAllClasses();
            return Ok(classes);
        }

        [HttpPost("sections")]
        public async Task<IActionResult> CreateSection([FromBody] Section section)
        {
            var result = await _adminRepositary.CreateSection(section);
            return Ok(result);
        }

        [HttpGet("sections/{sectionId}")]
        public async Task<IActionResult> FindSectionBySectionId(int sectionId)
        {
            var section = await _adminRepositary.FindSectionBySectionId(sectionId);
            if (section == null)
            {
                return NotFound();
            }
            return Ok(section);
        }

        [HttpPut("sections/{sectionId}")]
        public async Task<IActionResult> UpdateSection(int sectionId, [FromBody] Section section)
        {
            if (sectionId != section.SectionId)
            {
                return BadRequest();
            }

            var result = await _adminRepositary.UpdateSection(section);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("sections/{sectionId}")]
        public async Task<IActionResult> DeleteSection(int sectionId)
        {
            var result = await _adminRepositary.DeleteSection(sectionId);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet("sections")]
        public async Task<IActionResult> GetAllSections()
        {
            var sections = await _adminRepositary.GetAllSections();
            return Ok(sections);
        }

        [HttpPost("student-details")]
        public async Task<IActionResult> CreateStudentDetails([FromBody] StudentDetails studentDetails)
        {
            var result = await _adminRepositary.CreateStudentDetails(studentDetails);
            return Ok(result);
        }

        [HttpGet("student-details/{studentId}")]
        public async Task<IActionResult> FindStudentDetailsById(int studentId)
        {
            var studentDetails = await _adminRepositary.FindStudentDetailsById(studentId);
            if (studentDetails == null)
            {
                return NotFound();
            }
            return Ok(studentDetails);
        }

        [HttpGet("student-details/class/{classId}")]
        public async Task<IActionResult> FindStudentDetailsByClassId(int classId)
        {
            var studentDetails = await _adminRepositary.FindStudentDetailsByClassId(classId);
            if (studentDetails == null)
            {
                return NotFound();
            }
            return Ok(studentDetails);
        }

        [HttpGet("student-details/section/{sectionId}")]
        public async Task<IActionResult> FindStudentDetailsBySectionId(int sectionId)
        {
            var studentDetails = await _adminRepositary.FindStudentDetailsBySectionId(sectionId);
            if (studentDetails == null)
            {
                return NotFound();
            }
            return Ok(studentDetails);
        }

        [HttpPut("student-details/{studentId}")]
        public async Task<IActionResult> UpdateStudentDetails(int studentId, [FromBody] StudentDetails studentDetails)
        {
            if (studentId != studentDetails.StudentId)
            {
                return BadRequest();
            }

            var result = await _adminRepositary.UpdateStudentDetails(studentDetails);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("student-details/{studentId}/{classId}/{sectionId}")]
        public async Task<IActionResult> DeleteStudentDetails(int studentId, int classId, int sectionId)
        {
            var result = await _adminRepositary.DeleteStudentDetails(studentId, classId, sectionId);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet("student-details")]
        public async Task<IActionResult> GetAllStudentDetails()
        {
            var studentDetails = await _adminRepositary.GetAllStudentDetails();
            return Ok(studentDetails);
        }
    }

}
