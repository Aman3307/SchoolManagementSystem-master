using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Policy = "SuperAdminOnly")]
    [ApiController]
    [Route("api/[controller]")]

    public class SuperAdminController : ControllerBase
    {
        private readonly ISuperAdminRepositary _superAdminRepositary;

        public SuperAdminController(ISuperAdminRepositary superAdminRepositary)
        {
            _superAdminRepositary = superAdminRepositary;
        }

        [HttpGet("class-attendance/{classId}")]
        public async Task<IActionResult> FindClassAttendanceByClassId(int classId)
        {
            var classAttendance = await _superAdminRepositary.FindClassAttendanceByClassId(classId);
            if (classAttendance == null)
            {
                return NotFound();
            }
            return Ok(classAttendance);
        }

        [HttpGet("class-attendance")]
        public async Task<IActionResult> GetAllClassAttendance()
        {
            var classAttendance = await _superAdminRepositary.GetAllClassAttendance();
            return Ok(classAttendance);
        }

        [HttpGet("section-attendance/{sectionId}")]
        public async Task<IActionResult> FindSectionAttendanceBySectionId(int sectionId)
        {
            var sectionAttendance = await _superAdminRepositary.FindSectionAttendanceBySectionId(sectionId);
            if (sectionAttendance == null)
            {
                return NotFound();
            }
            return Ok(sectionAttendance);
        }

        [HttpGet("section-attendance")]
        public async Task<IActionResult> GetAllSectionAttendance()
        {
            var sectionAttendance = await _superAdminRepositary.GetAllSectionAttendance();
            return Ok(sectionAttendance);
        }

        [HttpGet("class-teacher/staff/{staffId}")]
        public async Task<IActionResult> FindClassTeacherByStaffId(int staffId)
        {
            var classTeacher = await _superAdminRepositary.FindClassTeacherByStaffId(staffId);
            if (classTeacher == null)
            {
                return NotFound();
            }
            return Ok(classTeacher);
        }

        [HttpGet("class-teacher/class/{classId}")]
        public async Task<IActionResult> FindClassTeacherByClassId(int classId)
        {
            var classTeacher = await _superAdminRepositary.FindClassTeacherByClassId(classId);
            if (classTeacher == null)
            {
                return NotFound();
            }
            return Ok(classTeacher);
        }



        [HttpGet("section-teacher/staff/{staffId}")]
        public async Task<IActionResult> FindSectionTeacherByStaffId(int staffId)
        {
            var sectionTeacher = await _superAdminRepositary.FindSectionTeacherByStaffId(staffId);
            if (sectionTeacher == null)
            {
                return NotFound();
            }
            return Ok(sectionTeacher);
        }

        [HttpGet("section-teacher/section/{sectionId}")]
        public async Task<IActionResult> FindSectionTeacherBySectionId(int sectionId)
        {
            var sectionTeacher = await _superAdminRepositary.FindSectionTeacherBySectionId(sectionId);
            if (sectionTeacher == null)
            {
                return NotFound();
            }
            return Ok(sectionTeacher);
        }

        [HttpGet("staff-attendance")]
        public async Task<IActionResult> GetAllStaffAttendance()
        {
            var staffAttendance = await _superAdminRepositary.GetAllStaffAttendance();
            return Ok(staffAttendance);
        }

        [HttpGet("staff-attendance/{staffId}")]
        public async Task<IActionResult> FindStaffAttendanceByStaffId(int staffId)
        {
            var staffAttendance = await _superAdminRepositary.FindStaffAttendanceByStaffId(staffId);
            if (staffAttendance == null)
            {
                return NotFound();
            }
            return Ok(staffAttendance);
        }

        [HttpGet("staff-details")]
        public async Task<IActionResult> GetAllStaffDetails()
        {
            var staffDetails = await _superAdminRepositary.GetAllStaffDetails();
            return Ok(staffDetails);
        }

        [HttpGet("staff-details/{staffId}")]
        public async Task<IActionResult> FindStaffDetailsByStaffId(int staffId)
        {
            var staffDetails = await _superAdminRepositary.FindStaffDetailsByStaffId(staffId);
            if (staffDetails == null)
            {
                return NotFound();
            }
            return Ok(staffDetails);
        }

        [HttpGet("subject-teachers")]
        public async Task<IActionResult> GetAllSubjectTeachers()
        {
            var subjectTeachers = await _superAdminRepositary.GetAllSubjectTeachers();
            return Ok(subjectTeachers);
        }

        [HttpGet("subject-teachers/staff/{staffId}")]
        public async Task<IActionResult> FindSubjectTeacherByStaffId(int staffId)
        {
            var subjectTeacher = await _superAdminRepositary.FindSubjectTeacherByStaffId(staffId);
            if (subjectTeacher == null)
            {
                return NotFound();
            }
            return Ok(subjectTeacher);
        }

        [HttpGet("subject-teachers/class/{classId}")]
        public async Task<IActionResult> FindSubjectTeacherByClassId(int classId)
        {
            var subjectTeachers = await _superAdminRepositary.FindSubjectTeacherByClassId(classId);
            return Ok(subjectTeachers);
        }

        [HttpGet("subject-teachers/section/{sectionId}")]
        public async Task<IActionResult> FindSubjectTeacherBySectionId(int sectionId)
        {
            var subjectTeachers = await _superAdminRepositary.FindSubjectTeacherBySectionId(sectionId);
            return Ok(subjectTeachers);
        }


        [HttpGet("approval-of-fees")]
        public async Task<IActionResult> GetAllApprovalOfFees()
        {
            var approvalOfFees = await _superAdminRepositary.GetAllApprovalOfFees();
            return Ok(approvalOfFees);
        }

        [HttpGet("approval-of-fees/student/{studentId}")]
        public async Task<IActionResult> FindApprovalOfFeesByStudentId(int studentId)
        {
            var approvalOfFees = await _superAdminRepositary.FindApprovalOfFeesByStudentId(studentId);
            if (approvalOfFees == null)
            {
                return NotFound();
            }
            return Ok(approvalOfFees);
        }

        [HttpGet("approval-of-fees/class/{classId}")]
        public async Task<IActionResult> FindApprovalOfFeesByClassId(int classId)
        {
            var approvalOfFees = await _superAdminRepositary.FindApprovalOfFeesByClassId(classId);
            return Ok(approvalOfFees);
        }

        [HttpGet("approval-of-fees/section/{sectionId}")]
        public async Task<IActionResult> FindApprovalOfFeesBySectionId(int sectionId)
        {
            var approvalOfFees = await _superAdminRepositary.FindApprovalOfFeesBySectionId(sectionId);
            return Ok(approvalOfFees);
        }

        [HttpGet("approval-of-fees/utr/{utr}")]
        public async Task<IActionResult> FindApprovalOfFeesByUTR(string utr)
        {
            var approvalOfFees = await _superAdminRepositary.FindApprovalOfFeesByUTR(utr);
            return Ok(approvalOfFees);
        }


        [HttpGet("generate-fees")]
        public async Task<IActionResult> GetAllGenerateFeesForStudent()
        {
            var generateFees = await _superAdminRepositary.GetAllGenerateFeesForStudent();
            return Ok(generateFees);
        }

        [HttpGet("generate-fees/student/{studentId}")]
        public async Task<IActionResult> FindGenerateFeesForStudentByStudentId(int studentId)
        {
            var generateFees = await _superAdminRepositary.FindGenerateFeesForStudentByStudentId(studentId);
            if (generateFees == null)
            {
                return NotFound();
            }
            return Ok(generateFees);
        }

        [HttpGet("generate-fees/class/{classId}")]
        public async Task<IActionResult> FindGenerateFeesForStudentByClassId(int classId)
        {
            var generateFees = await _superAdminRepositary.FindGenerateFeesForStudentByClassId(classId);
            return Ok(generateFees);
        }

        [HttpGet("generate-fees/section/{sectionId}")]
        public async Task<IActionResult> FindGenerateFeesForStudentBySectionId(int sectionId)
        {
            var generateFees = await _superAdminRepositary.FindGenerateFeesForStudentBySectionId(sectionId);
            return Ok(generateFees);
        }


        [HttpGet("revenue")]
        public async Task<IActionResult> GetAllRevenue()
        {
            var revenueList = await _superAdminRepositary.GetAllRevenue();
            return Ok(revenueList);
        }

        [HttpGet("revenue/{revenueId}")]
        public async Task<IActionResult> FindRevenueByRevenueId(int revenueId)
        {
            var revenue = await _superAdminRepositary.FindRevenueByRevenueId(revenueId);
            if (revenue == null)
            {
                return NotFound();
            }
            return Ok(revenue);
        }

        [HttpGet("classes")]
        
        public async Task<ActionResult<List<Class>>> GetAllClasses()
        {
            var classes = await _superAdminRepositary.GetAllClasses();
            return Ok(classes);
        }

        [HttpGet("class/{classId}")]
        public async Task<ActionResult<Class>> FindClassByClassId(int classId)
        {
            var classEntity = await _superAdminRepositary.FindClassByClassId(classId);
            if (classEntity == null)
            {
                return NotFound();
            }
            return Ok(classEntity);
        }

        [HttpGet("sections")]
        public async Task<ActionResult<List<Section>>> GetAllSections()
        {
            var sections = await _superAdminRepositary.GetAllSections();
            return Ok(sections);
        }

        [HttpGet("sections/class/{classId}")]
        public async Task<ActionResult<List<Section>>> FindSectionByClassId(int classId)
        {
            var sections = await _superAdminRepositary.FindSectionByClassId(classId);
            return Ok(sections);
        }

        [HttpGet("section/{sectionId}")]
        public async Task<ActionResult<Section>> FindSectionBySectionId(int sectionId)
        {
            var section = await _superAdminRepositary.FindSectionBySectionId(sectionId);
            if (section == null)
            {
                return NotFound();
            }
            return Ok(section);
        }


        [HttpGet("AllStudentDetails")]
        public async Task<ActionResult<List<StudentDetails>>> GetAllStudentDetails()
        {
            var studentDetails = await _superAdminRepositary.GetAllStudentDetails();
            return Ok(studentDetails);
        }

        [HttpGet("StudentById/{studentId}")]
        public async Task<ActionResult<StudentDetails>> FindStudentByStudentId(int studentId)
        {
            var studentDetails = await _superAdminRepositary.FindStudentByStudentId(studentId);
            if (studentDetails == null)
            {
                return NotFound();
            }
            return Ok(studentDetails);
        }

        [HttpGet("StudentsByClassId/{classId}")]
        public async Task<ActionResult<List<StudentDetails>>> FindStudentByClassId(int classId)
        {
            var studentDetails = await _superAdminRepositary.FindStudentByClassId(classId);
            return Ok(studentDetails);
        }

        [HttpGet("StudentsBySectionId/{sectionId}")]
        public async Task<ActionResult<List<StudentDetails>>> FindStudentBySectionId(int sectionId)
        {
            var studentDetails = await _superAdminRepositary.FindStudentBySectionId(sectionId);
            return Ok(studentDetails);
        }



        [HttpGet("complaints")]
        public async Task<IActionResult> GetAllComplaintsByStudent()
        {
            var complaints = await _superAdminRepositary.GetAllComplainByStudent();
            return Ok(complaints);
        }

        [HttpGet("complaints/student/{studentId}")]
        public async Task<IActionResult> FindComplaintByStudentId(int studentId)
        {
            var complaint = await _superAdminRepositary.FindComplainByStudentByStudentId(studentId);
            if (complaint == null)
            {
                return NotFound();
            }
            return Ok(complaint);
        }

        [HttpGet("complaints/class/{classId}")]
        public async Task<IActionResult> FindComplaintsByClassId(int classId)
        {
            var complaints = await _superAdminRepositary.FindComplainByStudentByClassId(classId);
            return Ok(complaints);
        }

        [HttpGet("complaints/section/{sectionId}")]
        public async Task<IActionResult> FindComplaintsBySectionId(int sectionId)
        {
            var complaints = await _superAdminRepositary.FindComplainByStudentBySectionId(sectionId);
            return Ok(complaints);
        }


        [HttpGet("fees-update")]
        public async Task<IActionResult> GetAllFeesUpdateByStudent()
        {
            var feesUpdates = await _superAdminRepositary.GetAllFeesUpdateByStudent();
            return Ok(feesUpdates);
        }

        [HttpGet("fees-update/student/{studentId}")]
        public async Task<IActionResult> FindFeesUpdateByStudentByStudentId(int studentId)
        {
            var feesUpdate = await _superAdminRepositary.FindFeesUpdateByStudentByStudentId(studentId);
            if (feesUpdate == null)
            {
                return NotFound();
            }
            return Ok(feesUpdate);
        }

        [HttpGet("fees-update/class/{classId}")]
        public async Task<IActionResult> FindFeesUpdateByStudentByClassId(int classId)
        {
            var feesUpdates = await _superAdminRepositary.FindFeesUpdateByStudentByClassId(classId);
            return Ok(feesUpdates);
        }

        [HttpGet("fees-update/section/{sectionId}")]
        public async Task<IActionResult> FindFeesUpdateByStudentBySectionId(int sectionId)
        {
            var feesUpdates = await _superAdminRepositary.FindFeesUpdateByStudentBySectionId(sectionId);
            return Ok(feesUpdates);
        }

        [HttpGet("fees-update/utr/{utr}")]
        public async Task<IActionResult> FindFeesUpdateByStudentByUTR(string utr)
        {
            var feesUpdates = await _superAdminRepositary.FindFeesUpdateByStudentByUTR(utr);
            return Ok(feesUpdates);
        }


        [HttpGet("hw-cw")]
        public async Task<IActionResult> GetAllHwCw()
        {
            var hwCwList = await _superAdminRepositary.GetAllHwCw();
            return Ok(hwCwList);
        }

        

        [HttpGet("hw-cw/class/{classId}")]
        public async Task<IActionResult> FindHwCwByClassId(int classId)
        {
            var hwCwList = await _superAdminRepositary.FindHwCwByClassId(classId);
            return Ok(hwCwList);
        }

        [HttpGet("hw-cw/section/{sectionId}")]
        public async Task<IActionResult> FindHwCwBySectionId(int sectionId)
        {
            var hwCwList = await _superAdminRepositary.FindHwCwBySectionId(sectionId);
            return Ok(hwCwList);
        }

        [HttpGet("student-achievements")]
        public async Task<IActionResult> GetAllStudentAchievements()
        {
            var achievements = await _superAdminRepositary.GetAllStudentAchievements();
            return Ok(achievements);
        }

        [HttpGet("student-achievements/{studentId}")]
        public async Task<IActionResult> FindStudentAchievementByStudentId(int studentId)
        {
            var achievement = await _superAdminRepositary.FindStudentAchievementByStudentId(studentId);
            if (achievement == null)
            {
                return NotFound();
            }
            return Ok(achievement);
        }

        [HttpGet("student-achievements/class/{classId}")]
        public async Task<IActionResult> FindStudentAchievementByClassId(int classId)
        {
            var achievements = await _superAdminRepositary.FindStudentAchievementByClassId(classId);
            return Ok(achievements);
        }

        [HttpGet("student-achievements/section/{sectionId}")]
        public async Task<IActionResult> FindStudentAchievementBySectionId(int sectionId)
        {
            var achievements = await _superAdminRepositary.FindStudentAchievementBySectionId(sectionId);
            return Ok(achievements);
        }


        [HttpGet("student-remarks")]
        public async Task<IActionResult> GetAllStudentRemarks()
        {
            var remarks = await _superAdminRepositary.GetAllStudentRemarks();
            return Ok(remarks);
        }

        [HttpGet("student-remarks/{studentId}")]
        public async Task<IActionResult> FindStudentRemarksByStudentId(int studentId)
        {
            var remarks = await _superAdminRepositary.FindStudentRemarksByStudentId(studentId);
            return Ok(remarks);
        }

        [HttpGet("student-remarks/class/{classId}")]
        public async Task<IActionResult> FindStudentRemarksByClassId(int classId)
        {
            var remarks = await _superAdminRepositary.FindStudentRemarksByClassId(classId);
            return Ok(remarks);
        }

        [HttpGet("student-remarks/section/{sectionId}")]
        public async Task<IActionResult> FindStudentRemarksBySectionId(int sectionId)
        {
            var remarks = await _superAdminRepositary.FindStudentRemarksBySectionId(sectionId);
            return Ok(remarks);
        }


        [HttpGet("student-attendance")]
        public async Task<IActionResult> GetAllStudentAttendance()
        {
            var attendance = await _superAdminRepositary.GetAllStudentAttendance();
            return Ok(attendance);
        }

        [HttpGet("student-attendance/{studentId}")]
        public async Task<IActionResult> FindStudentAttendanceByStudentId(int studentId)
        {
            var attendance = await _superAdminRepositary.FindStudentAttendanceByStudentId(studentId);
            return Ok(attendance);
        }

        [HttpGet("student-attendance/class/{classId}")]
        public async Task<IActionResult> FindStudentAttendanceByClassId(int classId)
        {
            var attendance = await _superAdminRepositary.FindStudentAttendanceByClassId(classId);
            return Ok(attendance);
        }

        [HttpGet("student-attendance/section/{sectionId}")]
        public async Task<IActionResult> FindStudentAttendanceBySectionId(int sectionId)
        {
            var attendance = await _superAdminRepositary.FindStudentAttendanceBySectionId(sectionId);
            return Ok(attendance);
        }


        [HttpGet("student-marks")]
        public async Task<IActionResult> GetAllStudentMarks()
        {
            var marks = await _superAdminRepositary.GetAllStudentMarks();
            return Ok(marks);
        }

        [HttpGet("student-marks/{studentId}")]
        public async Task<IActionResult> FindStudentMarksByStudentId(int studentId)
        {
            var marks = await _superAdminRepositary.FindStudentMarksByStudentId(studentId);
            return Ok(marks);
        }

        [HttpGet("student-marks/class/{classId}")]
        public async Task<IActionResult> FindStudentMarksByClassId(int classId)
        {
            var marks = await _superAdminRepositary.FindStudentMarksByClassId(classId);
            return Ok(marks);
        }

        [HttpGet("student-marks/section/{sectionId}")]
        public async Task<IActionResult> FindStudentMarksBySectionId(int sectionId)
        {
            var marks = await _superAdminRepositary.FindStudentMarksBySectionId(sectionId);
            return Ok(marks);
        }

    }
}