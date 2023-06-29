using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Models;
using SampleWebApplication.Services;

namespace SampleWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ILogger<SchoolController> _logger;
        private readonly ISchoolService schoolService;
        public SchoolController(ILogger<SchoolController> logger, ISchoolService schoolService)
        {
            _logger = logger;
            this.schoolService = schoolService;
        }

        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            return Ok(schoolService.GetStudents());
        }

        [HttpPost("AddStudent")]
        public IActionResult Add([FromBody] Student student)
        {
            schoolService.AddStudent(student);
            return Ok();
        }

        [HttpGet("GetTeachers")]
        public IActionResult GetTeacher()
        {
            return Ok(schoolService.GetTeachers());
        }

        [HttpGet("GetTeacherByClass/{className}/{section}")]
        public IActionResult GetTeachersbyClass([FromRoute] string className, [FromRoute] string section)
        {
            var result = schoolService.GetTeacherByClassName(className, section);
            if (result.Count()==0)
                return BadRequest();
            return Ok(result);
        }
    }
}