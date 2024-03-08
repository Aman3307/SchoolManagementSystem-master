using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Models.Teacher;
using SchoolManagementSystem.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Roles = "3")]
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepositary _teacherRepositary;

        public TeacherController(ITeacherRepositary teacherRepositary)
        {
            _teacherRepositary = teacherRepositary;
        }

        [HttpGet("hw-cw/class/{classId}")]
        public async Task<IActionResult> GetHwCwByClassId(int classId)
        {
            try
            {
                var hwCwList = await _teacherRepositary.FindHwCwByClassId(classId);
                return Ok(hwCwList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("hw-cw/section/{sectionId}")]
        public async Task<IActionResult> GetHwCwBySectionId(int sectionId)
        {
            try
            {
                var hwCwList = await _teacherRepositary.FindHwCwBySectionId(sectionId);
                return Ok(hwCwList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create-hw-cw")]
        public async Task<IActionResult> CreateHwCw([FromBody] HwCw hwCw)
        {
            try
            {
                await _teacherRepositary.CreateHwCw(hwCw);
                return Ok("HwCw created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("edit-hw-cw")]
        public async Task<IActionResult> EditHwCw([FromBody] HwCw hwCw)
        {
            try
            {
                bool result = await _teacherRepositary.EditHwCw(hwCw);
                if (!result)
                {
                    return NotFound($"HwCw with ID {hwCw.Id} not found");
                }

                return Ok($"HwCw with ID {hwCw.Id} edited successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("studentAchievement/{studentId}")]
        public async Task<ActionResult<StudentAchievement>> GetStudentAchievement(int studentId)
        {
            var studentAchievement = await _teacherRepositary.FindStudentAchievementByStudentId(studentId);
            if (studentAchievement == null)
            {
                return NotFound();
            }
            return studentAchievement;
        }

        [HttpGet("studentAchievementByClass/{classId}")]
        public async Task<ActionResult<StudentAchievement>> GetStudentAchievementByClass(int classId)
        {
            var studentAchievement = await _teacherRepositary.FindStudentAchievementByClassId(classId);
            if (studentAchievement == null)
            {
                return NotFound();
            }
            return studentAchievement;
        }

        [HttpGet("studentAchievementBySection/{sectionId}")]
        public async Task<ActionResult<StudentAchievement>> GetStudentAchievementBySection(int sectionId)
        {
            var studentAchievement = await _teacherRepositary.FindStudentAchievementBySectionId(sectionId);
            if (studentAchievement == null)
            {
                return NotFound();
            }
            return studentAchievement;
        }

        [HttpPost("createStudentAchievement")]
        public async Task<ActionResult<int>> CreateStudentAchievement(StudentAchievement studentAchievement)
        {
            var result = await _teacherRepositary.CreateStudentAchievement(studentAchievement);
            return result;
        }

        [HttpGet("allStudentAchievements")]
        public async Task<ActionResult<List<StudentAchievement>>> GetAllStudentAchievements()
        {
            var studentAchievements = await _teacherRepositary.GetAllStudentAchievements();
            return studentAchievements;
        }

        [HttpPut("editStudentAchievement")]
        public async Task<ActionResult<bool>> EditStudentAchievement(StudentAchievement studentAchievement)
        {
            var result = await _teacherRepositary.EditStudentAchievement(studentAchievement);
            return result;
        }
        // StudentAttendance methods in StudentController
        [HttpGet("studentAttendance/{studentId}")]
        public async Task<ActionResult<List<StudentAttendance>>> GetStudentAttendance(int studentId)
        {
            var studentAttendance = await _teacherRepositary.FindStudentAttendanceByStudentId(studentId);
            if (studentAttendance == null)
            {
                return NotFound();
            }
            return studentAttendance;
        }

        [HttpGet("studentAttendanceByClass/{classId}")]
        public async Task<ActionResult<List<StudentAttendance>>> GetStudentAttendanceByClass(int classId)
        {
            var studentAttendance = await _teacherRepositary.FindStudentAttendanceByClassId(classId);
            if (studentAttendance == null)
            {
                return NotFound();
            }
            return studentAttendance;
        }

        [HttpGet("studentAttendanceBySection/{sectionId}")]
        public async Task<ActionResult<List<StudentAttendance>>> GetStudentAttendanceBySection(int sectionId)
        {
            var studentAttendance = await _teacherRepositary.FindStudentAttendanceBySectionId(sectionId);
            if (studentAttendance == null)
            {
                return NotFound();
            }
            return studentAttendance;
        }

        [HttpPost("createStudentAttendance")]
        public async Task<ActionResult<int>> CreateStudentAttendance(StudentAttendance studentAttendance)
        {
            var result = await _teacherRepositary.CreateStudentAttendance(studentAttendance);
            return result;
        }

        [HttpGet("allStudentAttendance")]
        public async Task<ActionResult<List<StudentAttendance>>> GetAllStudentAttendance()
        {
            var studentAttendance = await _teacherRepositary.GetAllStudentAttendance();
            return studentAttendance;
        }

        [HttpPut("editStudentAttendance")]
        public async Task<ActionResult<bool>> EditStudentAttendance(StudentAttendance studentAttendance)
        {
            var result = await _teacherRepositary.EditStudentAttendance(studentAttendance);
            return result;
        }
        // StudentMarks methods in StudentController
        [HttpGet("studentMarks/{studentId}")]
        public async Task<ActionResult<StudentMarks>> GetStudentMarks(int studentId)
        {
            var studentMarks = await _teacherRepositary.FindStudentMarksByStudentId(studentId);
            if (studentMarks == null)
            {
                return NotFound();
            }
            return studentMarks;
        }

        [HttpGet("studentMarksByClass/{classId}")]
        public async Task<ActionResult<StudentMarks>> GetStudentMarksByClass(int classId)
        {
            var studentMarks = await _teacherRepositary.FindStudentMarksByClassId(classId);
            if (studentMarks == null)
            {
                return NotFound();
            }
            return studentMarks;
        }

        [HttpGet("studentMarksBySection/{sectionId}")]
        public async Task<ActionResult<StudentMarks>> GetStudentMarksBySection(int sectionId)
        {
            var studentMarks = await _teacherRepositary.FindStudentMarksBySectionId(sectionId);
            if (studentMarks == null)
            {
                return NotFound();
            }
            return studentMarks;
        }

        [HttpPost("createStudentMarks")]
        public async Task<ActionResult<int>> CreateStudentMarks(StudentMarks studentMarks)
        {
            var result = await _teacherRepositary.CreateStudentMarks(studentMarks);
            return result;
        }

        [HttpGet("getAllStudentMarks")]
        public async Task<ActionResult<List<StudentMarks>>> GetAllStudentMarks()
        {
            var studentMarksList = await _teacherRepositary.GetAllStudentMarks();
            return studentMarksList;
        }

        [HttpPut("editStudentMarks")]
        public async Task<ActionResult<bool>> EditStudentMarks(StudentMarks studentMarks)
        {
            var result = await _teacherRepositary.EditStudentMarks(studentMarks);
            return result;
        }


        [HttpGet("findStudentRemarksByStudentId")]
        public async Task<ActionResult<StudentRemarks>> FindStudentRemarksByStudentId(int studentId)
        {
            var result = await _teacherRepositary.FindStudentRemarksByStudentId(studentId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpGet("findStudentRemarksByClassId")]
        public async Task<ActionResult<StudentRemarks>> FindStudentRemarksByClassId(int classId)
        {
            var result = await _teacherRepositary.FindStudentRemarksByClassId(classId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpGet("findStudentRemarksBySectionId")]
        public async Task<ActionResult<StudentRemarks>> FindStudentRemarksBySectionId(int sectionId)
        {
            var result = await _teacherRepositary.FindStudentRemarksBySectionId(sectionId);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpPost("createStudentRemarks")]
        public async Task<ActionResult<int>> CreateStudentRemarks(StudentRemarks studentRemarks)
        {
            var result = await _teacherRepositary.CreateStudentRemarks(studentRemarks);
            return result;
        }

        [HttpGet("getAllStudentRemarks")]
        public async Task<ActionResult<List<StudentRemarks>>> GetAllStudentRemarks()
        {
            var studentRemarksList = await _teacherRepositary.GetAllStudentRemarks();
            return studentRemarksList;
        }

        [HttpPut("editStudentRemarks")]
        public async Task<ActionResult<bool>> EditStudentRemarks(StudentRemarks studentRemarks)
        {
            var result = await _teacherRepositary.EditStudentRemarks(studentRemarks);
            return result;
        }
    }

}
